Imports System.Data.OleDb
Imports System.IO

Public Class Form1
    Dim connectionstring As String = "provider = Microsoft.ACE.OLEDB.12.0;data source = C:\Users\Admin\Documents\sampleproj1.accdb;"
    Dim connection As New OleDbConnection(connectionstring)
    Dim myDA As OleDbDataAdapter

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click






        Dim username As String = usernametxt.Text
        Dim password As String = passwordtxt.Text
        If username = "kenny" And password = "kenny2002" Then
            MessageBox.Show("You have Logged in successfully!", "Login Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Hide()

            form2.Show()
        Else
            MessageBox.Show("Incorrect Username or Password!", "Login failed!", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If



        End Sub


End Class


