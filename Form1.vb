Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Call Afnan()
    End Sub
    Private Sub Afnan()
        lbl1.Text = "AFNAN"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim strText As String = TxtBox1.Text
        Fareez(strText)
        lbl2.Text = strText
    End Sub
    Private Sub Fareez(ByRef strText As String)
        strText = "Hello " & strText
    End Sub

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Haiqal()
    End Function

    Private Function Haiqal()
        lbl3.Text = "Selamat Pagi"
        Return Haiqal
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim strNama As String = txtBox2.Text
        Nama(strNama)
        lbl4.Text = strNama
    End Function
    Private Function Nama(ByRef strNama As String)
        strNama = "Hello " & strNama
        Return Nama
    End Function
End Class
