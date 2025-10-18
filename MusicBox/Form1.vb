' Created by The Autastic Media Dev Team © 2020.
' This software is provided as source-available for educational and recreational use only.
' Redistribution, modification, and use are permitted under the following conditions:
' - Non-commercial use only
' - Attribution to The Autastic Media Dev Team must be preserved
' - No warranty is provided; use at your own risk
' For full details, visit: https://github.com/Autastic-Media

Imports System.IO
Imports NAudio.Wave

Public Class Form1
    Private play_all As Boolean
    Private waveOut As WaveOutEvent
    Private audioStream As MemoryStream
    Private audioReader As WaveFileReader
    Private isLooping As Boolean = False
    Private isPaused As Boolean = False
    Private toolTip1 As ToolTip
    Private currentVolume As Single = 1.0F
    Private WithEvents CheckBox_RememberVolume As CheckBox

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If ComboBox1.SelectedIndex = -1 Then ComboBox1.SelectedIndex = 0

        toolTip1 = New ToolTip()
        toolTip1.AutoPopDelay = 5000
        toolTip1.InitialDelay = 500
        toolTip1.ReshowDelay = 200
        toolTip1.ShowAlways = True

        toolTip1.SetToolTip(btnTogglePlayback, "Pause or resume music playback")
        toolTip1.SetToolTip(Button_Clear, "Clear current selection and reset")
        toolTip1.SetToolTip(Button_Close, "Close the application")
        toolTip1.SetToolTip(Button_About, "Information about the application")
        toolTip1.SetToolTip(CheckBox1, "Enable first to loop selected music")
        toolTip1.SetToolTip(CheckBox2, "Enable this to play all music in sequence")
        toolTip1.SetToolTip(TrackBar_Volume, "Adjust playback volume")

        Dim baseLeft As Integer = TrackBar_Volume.Left
        Dim labelTop As Integer = TrackBar_Volume.Top - -28

        Label1.Left = baseLeft + 8
        Label3.Left = baseLeft + 67
        Label4.Left = baseLeft + 128
        Label5.Left = baseLeft + 190
        Label6.Left = baseLeft + 247

        Label1.Top = labelTop
        Label3.Top = labelTop
        Label4.Top = labelTop
        Label5.Top = labelTop
        Label6.Top = labelTop

        If My.Settings.LastVolume > 0 Then
            currentVolume = My.Settings.LastVolume
        Else
            currentVolume = 1.0F
        End If

        TrackBar_Volume.Value = CInt(currentVolume * 100)
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If Me.ComboBox1.Text = "Music Select: (Click on Loop Selected Music first, to loop selected music)" Then
            PictureBox1.Image = My.Resources.ImageBoxStillMed
            StopPlayback()
            CheckBox1.Enabled = True
        End If

        Select Case Me.ComboBox1.Text
            Case "25: Air on the G String - Johann Sebastian Bach" : PlaySelectedSong(My.Resources._25)
            Case "26: Arabesque No.1 - Claude Debussy" : PlaySelectedSong(My.Resources._26)
            Case "27: Ave Maria - Franz Schubert" : PlaySelectedSong(My.Resources._27)
            Case "28: Bolero - Maurice Ravel" : PlaySelectedSong(My.Resources._28)
            Case "29: Canon in D - Johann Pachelbel" : PlaySelectedSong(My.Resources._29)
            Case "30: Caprice No.24 - Niccolò Paganini" : PlaySelectedSong(My.Resources._30)
            Case "31: Carmina Burana (O Fortuna) - Carl Orff" : PlaySelectedSong(My.Resources._31)
            Case "32: Clair de lune - Claude Debussy" : PlaySelectedSong(My.Resources._32)
            Case "33: Die Forelle - Franz Schubert" : PlaySelectedSong(My.Resources._33)
            Case "34: Dolly's Dreaming and Awakening - Theodore Oesten" : PlaySelectedSong(My.Resources._34)
            Case "35: Etude Op.10 No.3 in E major - Frédéric Chopin" : PlaySelectedSong(My.Resources._35)
            Case "36: Für Elise - Ludwig van Beethoven" : PlaySelectedSong(My.Resources._36)
        End Select
    End Sub

    Private Sub PlaySelectedSong(ByVal file As System.IO.UnmanagedMemoryStream)
        StopPlayback()

        audioStream = New MemoryStream()
        file.CopyTo(audioStream)
        audioStream.Position = 0

        audioReader = New WaveFileReader(audioStream)
        waveOut = New WaveOutEvent()
        waveOut.Init(audioReader)
        waveOut.Volume = currentVolume

        PictureBox1.Image = My.Resources.ImageBoxMoveMed
        PictureBox1.Image.Tag = "Playing"

        CheckBox1.Enabled = False
        CheckBox2.Enabled = False

        If CheckBox1.Checked Then
            CheckBox1.Text = "Press Clear to Reset"
            isLooping = True
            AddHandler waveOut.PlaybackStopped, AddressOf LoopPlayback
        Else
            isLooping = False
            Timer1.Interval = CInt(audioReader.TotalTime.TotalMilliseconds)
            Timer1.Start()
        End If

        waveOut.Play()
        isPaused = False
        btnTogglePlayback.Text = "Pause"
    End Sub

    Private Sub LoopPlayback(sender As Object, e As StoppedEventArgs)
        If isLooping Then
            audioStream.Position = 0
            audioReader = New WaveFileReader(audioStream)
            waveOut.Init(audioReader)
            waveOut.Volume = currentVolume
            waveOut.Play()
        End If
    End Sub

    Private Sub StopPlayback()
        If waveOut IsNot Nothing Then
            RemoveHandler waveOut.PlaybackStopped, AddressOf LoopPlayback
            waveOut.Stop()
            waveOut.Dispose()
            waveOut = Nothing
        End If
        If audioReader IsNot Nothing Then
            audioReader.Dispose()
            audioReader = Nothing
        End If
        If audioStream IsNot Nothing Then
            audioStream.Dispose()
            audioStream = Nothing
        End If
    End Sub

    Private Sub btnTogglePlayback_Click(sender As Object, e As EventArgs) Handles btnTogglePlayback.Click
        If waveOut IsNot Nothing Then
            If waveOut.PlaybackState = PlaybackState.Playing Then
                waveOut.Pause()
                isPaused = True
                btnTogglePlayback.Text = "Resume"
                PictureBox1.Image = My.Resources.ImageBoxStillMed
                PictureBox1.Image.Tag = "Paused"
            ElseIf isPaused Then
                waveOut.Play()
                isPaused = False
                btnTogglePlayback.Text = "Pause"
                PictureBox1.Image = My.Resources.ImageBoxMoveMed
                PictureBox1.Image.Tag = "Playing"
            End If
        End If
    End Sub

    Private Sub Button_Close_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Close.Click
        Close()
    End Sub

    Private Sub Button_Clear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_Clear.Click
        EndOfSelection()
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If Me.CheckBox1.Checked = False Then
            CheckBox1.Text = "Loop Selected Music"
            Timer1.Stop()
            ComboBox1.Text = "Music Select: (Click on Loop Selected Music first, to loop selected music)"
            CheckBox1.Enabled = True
            PictureBox1.Image = My.Resources.ImageBoxStillMed
            PlayEndSound()
        End If
    End Sub

    Private Sub Button_About_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button_About.Click
        Form_About.Show()
    End Sub

    Private Sub PictureBox3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox3.Click
        System.Diagnostics.Process.Start("https://github.com/Autastic-Media")
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If Me.CheckBox2.Checked Then
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False

            play_all = True
            Timer1.Start()
            Timer1.Interval = 1
        End If
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Timer1.Stop()

        If play_all And ComboBox1.SelectedIndex + 1 < ComboBox1.Items.Count Then
            ComboBox1.SelectedIndex += 1
        Else
            play_all = False
            EndOfSelection()
        End If
    End Sub

    Private Sub EndOfSelection()
        If waveOut IsNot Nothing Then
            RemoveHandler waveOut.PlaybackStopped, AddressOf LoopPlayback
        End If

        StopPlayback()

        isLooping = False
        play_all = False
        ComboBox1.BringToFront()
        ComboBox1.Enabled = True
        PictureBox1.Image = My.Resources.ImageBoxStillMed
        PictureBox1.Image.Tag = String.Empty
        ComboBox1.SelectedIndex = 0
        CheckBox1.Checked = False
        CheckBox2.Checked = False
        CheckBox1.Enabled = True
        CheckBox2.Enabled = True
        btnTogglePlayback.Text = "Pause"

        PlayEndSound()
    End Sub

    Private Sub PlayEndSound()
        StopPlayback()
        audioStream = New MemoryStream()
        My.Resources._End.CopyTo(audioStream)
        audioStream.Position = 0

        audioReader = New WaveFileReader(audioStream)
        waveOut = New WaveOutEvent()
        waveOut.Init(audioReader)
        waveOut.Volume = currentVolume

        PictureBox1.Image = My.Resources.ImageBoxStillMed
        PictureBox1.Image.Tag = "End"

        waveOut.Play()
        isPaused = False
    End Sub

    Private Sub TrackBar_Volume_Scroll(sender As Object, e As EventArgs) Handles TrackBar_Volume.Scroll
        Dim raw = TrackBar_Volume.Value
        Dim snapPoints() As Integer = {0, 25, 50, 75, 100}
        Dim threshold As Integer = 3

        Dim closest = snapPoints.OrderBy(Function(p) Math.Abs(p - raw)).First()
        If Math.Abs(closest - raw) <= threshold Then
            TrackBar_Volume.Value = closest
            raw = closest
        End If

        Dim newVolume As Single = raw / 100.0F
        If waveOut IsNot Nothing AndAlso waveOut.Volume <> newVolume Then
            waveOut.Volume = newVolume
        End If

        currentVolume = newVolume

        My.Settings.LastVolume = currentVolume
        My.Settings.Save()
    End Sub
End Class