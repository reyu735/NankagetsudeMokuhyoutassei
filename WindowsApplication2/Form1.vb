Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.FormBorderStyle = FormBorderStyle.FixedSingle

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("数値を入力しような")
        ElseIf TextBox2.Text = "" Then
            MsgBox("数値を入力しような")
        Else
            Dim n As Integer
            Do
                If TextBox2.Text * n >= TextBox1.Text Then
                    Exit Do
                End If
                n = n + 1
            Loop
            TextBox3.Text = n
        End If
    End Sub
End Class
