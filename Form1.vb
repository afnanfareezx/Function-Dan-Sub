Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Call Afnan()
    End Sub
    Private Sub Afnan()
        lbl1.Text = "AFNAN"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Dim strTxt As String
        strTxt = TxtBox1.Text
        lbl2.Text = strTxt
        Fareez(strFareez:=TxtBox1.Text)
    End Sub
    Private Sub Fareez(ByVal strFareez As String)
        Dim strInput As String
    End Sub

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Haiqal()
    End Function

    Private Function Haiqal()
        lbl3.Text = "Selamat Pagi"
        Return lbl3.Text
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Dim strTxt2 As String
        strTxt2 = txtBox2.Text
        lbl4.Text = strTxt2
        Nama(strNama:=txtBox2.Text)
        Return lbl4
    End Function
    Private Function Nama(ByVal strNama As String)
        Dim str As String
    End Function
End Class
