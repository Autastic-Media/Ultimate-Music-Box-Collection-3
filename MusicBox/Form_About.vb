' Created by The Autastic Media Dev Team © 2020.
' Permission is granted to use this for recreational fun.
' Autastic Media Dev Team: https://github.com/Autastic-Meida.

Public Class Form_About
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click, Button2.Click
        Close()
    End Sub

    Private Sub PictureBox2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PictureBox2.Click
        System.Diagnostics.Process.Start("https://github.com/Autastic-Meida")
        Me.Close()
    End Sub
End Class