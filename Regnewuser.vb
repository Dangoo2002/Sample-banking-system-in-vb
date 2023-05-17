
Imports System.Data.OleDb
Imports System.IO

Public Class form3

    Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\sampleproj1.accdb;")

    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        form2.Show()
    End Sub


    Private Sub savebtn_Click(sender As Object, e As EventArgs) Handles savebtn.Click

        Dim con As New OleDb.OleDbConnection
        Dim cmd As New OleDb.OleDbCommand



        con.ConnectionString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\sampleproj1.accdb;Persist Security Info=False"
        con.Open()

        cmd.Connection = con
        cmd.CommandText = " INSERT INTO Table1 ( ID, FirstName, LastName ,Phone ,Amount,Email )VALUES ('" & idtxt.Text & "','" & firstnametxt.Text & "', '" & lastnametxt.Text & "', '" & phonetxt.Text & "', '" & amnttxt.Text & "', '" & mailtxt.Text & "')"



        If cmd.CommandText = " INSERT INTO Table1 ( ID, FirstName, LastName ,Phone ,Amount,Email )VALUES ('" & idtxt.Text & "','" & firstnametxt.Text & "', '" & lastnametxt.Text & "', '" & phonetxt.Text & "', '" & amnttxt.Text & "', '" & mailtxt.Text & "')" Then
            MessageBox.Show("Data Saved Succesfully")
        Else
            MessageBox.Show(" Failed to Save Data")
        End If

        cmd.ExecuteNonQuery()

        con.Close()







        'Declare a random number generator
        Dim rnd As New Random()


        'Declare a string to store 12 numbers
        Dim numbers As String = ""

        'Loop 12 times to generate and append random numbers
        For i As Integer = 1 To 12
            'Generate a random number between 0 and 9
            Dim num As Integer = rnd.Next(0, 10)

            'Append the number to the string
            numbers &= num.ToString()
        Next

        'Display the numbers in a textbox
        'Assuming you have a textbox named TextBox1
        gentxt.Text = numbers


    End Sub







    Private Sub loadpic_Click(sender As Object, e As EventArgs) Handles loadpicbtn.Click

        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            picbox.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub



End Class