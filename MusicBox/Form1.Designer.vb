<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.Button_About = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Button_Close = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TrackBar_Volume = New System.Windows.Forms.TrackBar()
        Me.btnTogglePlayback = New System.Windows.Forms.Button()
        Me.Button_Clear = New System.Windows.Forms.Button()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(427, 49)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(85, 17)
        Me.CheckBox2.TabIndex = 4
        Me.CheckBox2.Text = "Play all in list"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'Button_About
        '
        Me.Button_About.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_About.Location = New System.Drawing.Point(432, 83)
        Me.Button_About.Name = "Button_About"
        Me.Button_About.Size = New System.Drawing.Size(80, 21)
        Me.Button_About.TabIndex = 6
        Me.Button_About.Text = "About"
        Me.Button_About.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Image = Global.Ultimate_MusicBox_Collection_3.My.Resources.Resources.ImageBoxStillMed
        Me.PictureBox1.Location = New System.Drawing.Point(13, 12)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(519, 404)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Ultimate_MusicBox_Collection_3.My.Resources.Resources.music_box
        Me.PictureBox2.Location = New System.Drawing.Point(275, 83)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(63, 59)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 9
        Me.PictureBox2.TabStop = False
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(285, 49)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(126, 17)
        Me.CheckBox1.TabIndex = 3
        Me.CheckBox1.Text = "Loop Selected Music"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"Music Select: (Click on Loop Selected Music first, to loop selected music)", "25: Air on the G String - Johann Sebastian Bach", "26: Arabesque No.1 - Claude Debussy", "27: Ave Maria - Franz Schubert", "28: Bolero - Maurice Ravel", "29: Canon in D - Johann Pachelbel", "30: Caprice No.24 - Niccolò Paganini", "31: Carmina Burana (O Fortuna) - Carl Orff", "32: Clair de lune - Claude Debussy", "33: Die Forelle - Franz Schubert", "34: Dolly's Dreaming and Awakening - Theodore Oesten", "35: Etude Op.10 No.3 in E major - Frédéric Chopin", "36: Für Elise - Ludwig van Beethoven"})
        Me.ComboBox1.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(420, 21)
        Me.ComboBox1.TabIndex = 0
        '
        'Button_Close
        '
        Me.Button_Close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Close.Location = New System.Drawing.Point(346, 110)
        Me.Button_Close.Name = "Button_Close"
        Me.Button_Close.Size = New System.Drawing.Size(166, 32)
        Me.Button_Close.TabIndex = 7
        Me.Button_Close.Text = "Close"
        Me.Button_Close.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.PictureBox2)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.btnTogglePlayback)
        Me.GroupBox1.Controls.Add(Me.CheckBox2)
        Me.GroupBox1.Controls.Add(Me.Button_About)
        Me.GroupBox1.Controls.Add(Me.CheckBox1)
        Me.GroupBox1.Controls.Add(Me.Button_Close)
        Me.GroupBox1.Controls.Add(Me.Button_Clear)
        Me.GroupBox1.Controls.Add(Me.ComboBox1)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.PictureBox3)
        Me.GroupBox1.Controls.Add(Me.TrackBar_Volume)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 422)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(518, 148)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Options:"
        '
        'PictureBox3
        '
        Me.PictureBox3.BackColor = System.Drawing.SystemColors.ButtonFace
        Me.PictureBox3.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox3.Image = Global.Ultimate_MusicBox_Collection_3.My.Resources.Resources.am_logo_banner_large
        Me.PictureBox3.Location = New System.Drawing.Point(6, 71)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(263, 71)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox3.TabIndex = 5
        Me.PictureBox3.TabStop = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.Transparent
        Me.Label6.Location = New System.Drawing.Point(254, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(25, 13)
        Me.Label6.TabIndex = 26
        Me.Label6.Text = "100"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.Location = New System.Drawing.Point(197, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(19, 13)
        Me.Label5.TabIndex = 25
        Me.Label5.Text = "75"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.Transparent
        Me.Label4.Location = New System.Drawing.Point(137, 42)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(19, 13)
        Me.Label4.TabIndex = 24
        Me.Label4.Text = "50"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.Location = New System.Drawing.Point(75, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(19, 13)
        Me.Label3.TabIndex = 23
        Me.Label3.Text = "25"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(15, 42)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(13, 13)
        Me.Label1.TabIndex = 22
        Me.Label1.Text = "0"
        '
        'TrackBar_Volume
        '
        Me.TrackBar_Volume.LargeChange = 25
        Me.TrackBar_Volume.Location = New System.Drawing.Point(6, 42)
        Me.TrackBar_Volume.Maximum = 100
        Me.TrackBar_Volume.Name = "TrackBar_Volume"
        Me.TrackBar_Volume.Size = New System.Drawing.Size(273, 45)
        Me.TrackBar_Volume.SmallChange = 5
        Me.TrackBar_Volume.TabIndex = 2
        Me.TrackBar_Volume.TickFrequency = 25
        Me.TrackBar_Volume.Value = 100
        '
        'btnTogglePlayback
        '
        Me.btnTogglePlayback.Location = New System.Drawing.Point(432, 18)
        Me.btnTogglePlayback.Name = "btnTogglePlayback"
        Me.btnTogglePlayback.Size = New System.Drawing.Size(80, 23)
        Me.btnTogglePlayback.TabIndex = 1
        Me.btnTogglePlayback.Text = "Pause"
        Me.btnTogglePlayback.UseVisualStyleBackColor = True
        '
        'Button_Clear
        '
        Me.Button_Clear.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button_Clear.Location = New System.Drawing.Point(346, 83)
        Me.Button_Clear.Name = "Button_Clear"
        Me.Button_Clear.Size = New System.Drawing.Size(80, 21)
        Me.Button_Clear.TabIndex = 5
        Me.Button_Clear.Text = "Clear"
        Me.Button_Clear.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"Music Select: (Click on Loop Selected Music first, to loop selected music)", "25: Air on the G String - Johann Sebastian Bach", "26: Arabesque No.1 - Claude Debussy", "27: Ave Maria - Franz Schubert", "28: Bolero - Maurice Ravel", "29: Canon in D - Johann Pachelbel", "30: Caprice No.24 - Niccolò Paganini", "31: Carmina Burana (O Fortuna) - Carl Orff", "32: Clair de lune - Claude Debussy", "33: Die Forelle - Franz Schubert", "34: Dolly's Dreaming and Awakening - Theodore Oesten", "35: Etude Op.10 No.3 in E major - Frédéric Chopin", "36: Für Elise - Ludwig van Beethoven"})
        Me.ComboBox2.Location = New System.Drawing.Point(6, 19)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(420, 21)
        Me.ComboBox2.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(544, 583)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ultimate Music Box - Collection 3"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TrackBar_Volume, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents Button_About As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Button_Close As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Button_Clear As System.Windows.Forms.Button
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TrackBar_Volume As TrackBar
    Friend WithEvents btnTogglePlayback As Button
End Class
