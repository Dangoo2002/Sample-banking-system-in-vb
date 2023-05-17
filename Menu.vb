Public Class form2
    Private Sub backbtn_Click(sender As Object, e As EventArgs) Handles backbtn.Click
        Me.Hide()
        form1.Show()
    End Sub

    Private Sub regbtn_Click(sender As Object, e As EventArgs) Handles regbtn.Click
        Me.Hide()

        form3.Show()
    End Sub

    Private Sub updatebtn_Click(sender As Object, e As EventArgs) Handles updatebtn.Click
        Me.Hide()

        form4.Show()
    End Sub

    Private Sub displaybtn_Click(sender As Object, e As EventArgs) Handles displaybtn.Click
        Me.Hide()

        form5.Show()
    End Sub
End Class