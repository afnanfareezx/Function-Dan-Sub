Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Call Afnan()
    End Sub
    Private Sub Afnan()
        lbl1.Text = "Data tersebut"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Call Fareez()
    End Sub
    Private Sub Fareez()
        Dim intKira As String
        intKira = Trim(TxtBox1.Text)
        lbl2.Text = intKira
    End Sub

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Call Haiqal()
    End Function

    Private Function Haiqal()
        lbl3.Text = "Data Tersebut"
        Return lbl3
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        lbl4.Text = Nama()
    End Function
    Private Function Nama()
        Dim strNama As String
        strNama = txtBox2.Text
        Return strNama
    End Function
End Class
