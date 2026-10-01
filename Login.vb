Imports System.Data.SqlClient
Public Class Login
    Sub Opened()
        Homepage.LoginToolStripMenuItem.Enabled = False
        Homepage.LogoutToolStripMenuItem.Enabled = True
        Homepage.MasterToolStripMenuItem.Enabled = True
        Homepage.TransactionToolStripMenuItem.Enabled = True
        Homepage.ReportToolStripMenuItem.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim CMD As SqlCommand
        If TextBox1.Text = "" Or TextBox2.Text = "" Then
            MsgBox("Username and Password Required!", MsgBoxStyle.Exclamation, "Enter Username dan Password")
        Else
            Call Connect()
            CMD = New SqlCommand("Select * From admin where adminid='" & TextBox1.Text & "' and password= '" & TextBox2.Text & "'", Conn)
            MsgBox("Login Succeed!", MsgBoxStyle.Information, "Access Succesful")
            Rd = CMD.ExecuteReader
            Rd.Read()
            If Rd.HasRows Then
                Me.Close()
                Call Opened()
                Homepage.STLabel2.Text = Rd!AdminID
                Homepage.STLabel4.Text = Rd!Name
            Else
                MsgBox("Incorrect Username and Password!", MsgBoxStyle.Critical, "Check Username dan Password")
                Call Clean()
            End If

        End If
    End Sub

    Sub Clean()
        TextBox1.Text = ""
        TextBox2.Text = ""
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        TextBox2.UseSystemPasswordChar = True
    End Sub
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            TextBox2.UseSystemPasswordChar = False
        Else
            TextBox2.UseSystemPasswordChar = True
        End If
        TextBox2.Focus()
    End Sub
End Class