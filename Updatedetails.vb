

Imports System.Data.OleDb

Public Class form4


    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()

        form2.Show()
    End Sub

    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connString As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\sampleproj1.accdb;Persist Security Info=False;"
        Dim conn As New OleDbConnection(connString)
        Dim cmd As New OleDbCommand("SELECT * FROM Table1", conn)
        Dim da As New OleDbDataAdapter(cmd)
        Dim dt As New DataTable()

        da.Fill(dt)
        usercombo.DataSource = dt
        usercombo.DisplayMember = "ID"
        usercombo.ValueMember = "FirstName"

    End Sub






    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click


        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\sampleproj1.accdb")

        Dim cmd As New OleDbCommand("UPDATE Table1 SET FirstName =@value, LastName =@value1, Phone =@value2, Amount =@value3, Email =@value4 WHERE ID=@name", con)
        cmd.Parameters.AddWithValue("@value", firsttxt.Text)
        cmd.Parameters.AddWithValue("@value1", lasttxt.Text)
        cmd.Parameters.AddWithValue("@value2", phonetxt.Text)
        cmd.Parameters.AddWithValue("@value3", amounttxt.Text)
        cmd.Parameters.AddWithValue("@value4", mailtxt.Text)
        cmd.Parameters.AddWithValue("@name", usercombo.Text)


        con.Open()
        MessageBox.Show("Data Updated Succesfully")
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub usercombo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles usercombo.SelectedIndexChanged

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\sampleproj1.accdb")
        Dim cmd As New OleDbCommand("SELECT Amount FROM Table1 WHERE ID =@name", con)
        cmd.Parameters.AddWithValue("@name", usercombo.Text)
        con.Open()
        Dim result As Object = cmd.ExecuteScalar()
        If result IsNot Nothing Then
            baltxt.Text = result.ToString()
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Close()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim con As New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\Admin\Documents\sampleproj1.accdb")
        Dim cmd As New OleDbCommand("DELETE FROM Table1 WHERE ID = @Column1", con)
        cmd.Parameters.AddWithValue("@Column1", usercombo.Text)
        con.Open()
        cmd.ExecuteNonQuery()
        con.Close()
    End Sub

    Private Sub picbtn_Click(sender As Object, e As EventArgs) Handles picbtn.Click
        Dim openFileDialog1 As New OpenFileDialog()
        openFileDialog1.Filter = "Image Files (*.bmp;*.jpg;*.jpeg,*.png)|*.BMP;*.JPG;*.JPEG;*.PNG"
        If openFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            picbox.Image = Image.FromFile(openFileDialog1.FileName)
        End If
    End Sub
End Class
