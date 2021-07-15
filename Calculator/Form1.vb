Public Class Calculator
    Dim nilaia As Double
    Dim nilaib As Double
    Dim hasil As Double
    Dim opt As String

    Private Sub Calculator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Btn1_Click(sender As Object, e As EventArgs) Handles Btn1.Click
        TextBox1.Text = TextBox1.Text & Btn1.Text
    End Sub

    Private Sub Btn2_Click(sender As Object, e As EventArgs) Handles Btn2.Click
        TextBox1.Text = TextBox1.Text & Btn2.Text
    End Sub

    Private Sub Btn3_Click(sender As Object, e As EventArgs) Handles Btn3.Click
        TextBox1.Text = TextBox1.Text & Btn3.Text
    End Sub

    Private Sub Btn4_Click(sender As Object, e As EventArgs) Handles Btn4.Click
        TextBox1.Text = TextBox1.Text & Btn4.Text
    End Sub

    Private Sub Btn5_Click(sender As Object, e As EventArgs) Handles Btn5.Click
        TextBox1.Text = TextBox1.Text & Btn5.Text
    End Sub

    Private Sub Btn6_Click(sender As Object, e As EventArgs) Handles Btn6.Click
        TextBox1.Text = TextBox1.Text & Btn6.Text
    End Sub

    Private Sub Btn7_Click(sender As Object, e As EventArgs) Handles Btn7.Click
        TextBox1.Text = TextBox1.Text & Btn7.Text
    End Sub

    Private Sub Btn8_Click(sender As Object, e As EventArgs) Handles Btn8.Click
        TextBox1.Text = TextBox1.Text & Btn8.Text
    End Sub

    Private Sub Btn9_Click(sender As Object, e As EventArgs) Handles Btn9.Click
        TextBox1.Text = TextBox1.Text & Btn9.Text
    End Sub

    Private Sub Btn0_Click(sender As Object, e As EventArgs) Handles Btn0.Click
        TextBox1.Text = TextBox1.Text & Btn0.Text
    End Sub

    Private Sub BtnTambah_Click(sender As Object, e As EventArgs) Handles BtnTambah.Click
        nilaia = Val(TextBox1.Text)
        TextBox1.Text = ""
        opt = "+"
    End Sub

    Private Sub BtnKurang_Click(sender As Object, e As EventArgs) Handles BtnKurang.Click
        nilaia = Val(TextBox1.Text)
        TextBox1.Text = ""
        opt = "-"
    End Sub

    Private Sub BtnBagi_Click(sender As Object, e As EventArgs) Handles BtnBagi.Click
        nilaia = Val(TextBox1.Text)
        TextBox1.Text = ""
        opt = "/"
    End Sub

    Private Sub BtnKali_Click(sender As Object, e As EventArgs) Handles BtnKali.Click
        nilaia = Val(TextBox1.Text)
        TextBox1.Text = ""
        opt = "X"
    End Sub

    Private Sub BtnHasil_Click(sender As Object, e As EventArgs) Handles BtnHasil.Click
        nilaib = Val(TextBox1.Text)
        Select Case opt
            Case "+"
                hasil = nilaia + nilaib
            Case "-"
                hasil = nilaia - nilaib
            Case "/"
                hasil = nilaia / nilaib
            Case "X"
                hasil = nilaia * nilaib
        End Select
        TextBox1.Text = hasil
    End Sub

    Private Sub BtnExit_Click(sender As Object, e As EventArgs) Handles BtnExit.Click
        Dim pesan As String
        pesan = MsgBox("Yakin ingin keluar?", vbYesNo, "Konfirmasi")

        If pesan = vbYes Then
            MsgBox("Terimakasih sudah mencoba.")
            End
        Else
            Me.Show()
        End If
    End Sub

    Private Sub BtnC_Click(sender As Object, e As EventArgs) Handles BtnC.Click
        TextBox1.Text = ""
    End Sub
End Class
