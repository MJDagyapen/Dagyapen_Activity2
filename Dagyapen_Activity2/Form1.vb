Public Class Form1

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        Dim a As Integer
        Dim b As Integer
        a = txtfirstnum.Text
        b = txtsecondnum.Text
        lblResult.Text = a - b

    End Sub
End Class
65