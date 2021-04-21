Public Class Form1
    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        Call Afnan()
    End Sub
    Private Sub Afnan()
        lbl1.Text = "AFNAN"
    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        Fareez(strFareez:=TxtBox1.Text)
    End Sub
    Private Sub Fareez(ByVal strFareez As String)
        lbl2.Text = strFareez
    End Sub

    Private Function btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        Haiqal()
    End Function

    Private Function Haiqal()
        lbl3.Text = "Selamat Pagi"
        Return Haiqal
    End Function

    Private Function btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        Nama(strNama:=txtBox2.Text)
    End Function
    Private Function Nama(ByVal strNama As String)
        lbl4.Text = strNama
        Return Nama
    End Function
End Class
