Public Class Calcutator
    Private Sub Calcutator_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_sqrt.Click
        Dim sqrt As Double
        sqrt = Convert.ToDouble(display.Text)
        display.Text = Convert.ToString(Math.Sqrt(sqrt))
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        display.Clear()
        Label1.Text = ""
        Label2.Text = ""
        Label3.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_div.Click
        Label1.Text = display.Text
        Label2.Text = "/"
        display.Clear()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles btn_7.Click
        display.AppendText(7)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles btn_8.Click
        display.AppendText(8)
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles btn_9.Click
        display.AppendText(9)
    End Sub

    Private Sub Button14_Click(sender As Object, e As EventArgs) Handles btn_3.Click
        display.AppendText(3)
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles btn_mul.Click
        Label1.Text = display.Text
        Label2.Text = "*"
        display.Clear()
    End Sub

    Private Sub Button12_Click(sender As Object, e As EventArgs) Handles btn_4.Click
        display.AppendText(4)
    End Sub

    Private Sub Button11_Click(sender As Object, e As EventArgs) Handles btn_5.Click
        display.AppendText(5)
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles btn_6.Click
        display.AppendText(6)
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles btn_sub.Click
        Label1.Text = display.Text
        Label2.Text = "-"
        display.Clear()
    End Sub

    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles btn_1.Click
        display.AppendText(1)
    End Sub

    Private Sub Button15_Click(sender As Object, e As EventArgs) Handles btn_2.Click
        display.AppendText(2)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btn_plusOrmin.Click
        Dim numb As Double
        numb = Convert.ToDouble(display.Text)
        Dim nu As Double
        nu = numb - numb - numb
        display.Text = Convert.ToString(nu)
    End Sub

    Private Sub Button13_Click(sender As Object, e As EventArgs) Handles btn_add.Click
        Label1.Text = display.Text
        Label2.Text = "+"
        display.Clear()
    End Sub

    Private Sub btn_0_Click(sender As Object, e As EventArgs) Handles btn_0.Click
        display.AppendText(0)
    End Sub

    Private Sub btn_point_Click(sender As Object, e As EventArgs) Handles btn_point.Click
        display.AppendText(".")
    End Sub

    Private Sub btn_equl_Click(sender As Object, e As EventArgs) Handles btn_equl.Click
        Label3.Text = display.Text
        Dim sign As Char
        sign = Label2.Text
        Dim n1 As Double
        n1 = Convert.ToDouble(Label1.Text)
        Dim n2 As Double
        n2 = Convert.ToDouble(Label3.Text)
        Dim n3 As Double

        Select Case (sign)
            Case "+"
                n3 = n1 + n2
            Case "-"
                n3 = n1 - n2
            Case "*"
                n3 = n1 * n2
            Case "/"
                n3 = n1 / n2
        End Select
        display.Text = Convert.ToString(n3)
    End Sub
End Class
