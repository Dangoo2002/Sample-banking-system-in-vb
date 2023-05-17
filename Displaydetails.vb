Imports System.Data.OleDb

Public Class form5
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        form2.Show()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles displaybtn.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\sampleproj1.accdb")
        Dim cmd As New OleDbCommand("SELECT * FROM Table1", con)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()
        da.Fill(dt)

        dgv.DataSource = dt
    End Sub

    Private Sub form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class