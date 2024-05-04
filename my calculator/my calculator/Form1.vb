Public Class Form1

    Dim firstvalue, secondvalue, result As Double
    Dim op As String



    Private Sub Number_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnzero.Click, btndashama.Click, btn9.Click, btn8.Click, btn7.Click, btn6.Click, btn5.Click, btn4.Click, btn3.Click, btn2.Click, btn1.Click
        Dim b As Button = sender

        If (txtdisplay.Text = "0") Then
            txtdisplay.Text = ""
            txtdisplay.Text = b.Text

        ElseIf (b.Text = ".") Then
            If (Not txtdisplay.Text.Contains(".")) Then
                txtdisplay.Text = txtdisplay.Text + b.Text
            End If
        Else
            txtdisplay.Text = txtdisplay.Text + b.Text
        End If
    End Sub

    Private Sub btnback_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnback.Click
        If (txtdisplay.Text.Length > 0) Then
            txtdisplay.Text = txtdisplay.Text.Remove(txtdisplay.Text.Length - 1, 1)
        End If
        If (txtdisplay.Text = "") Then
            txtdisplay.Text = "0"
        End If

    End Sub

    Private Sub Operator_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Click, btnplus.Click, btnpersentage.Click, btnmultiple.Click, btnminus.Click, btndivision.Click

        Dim b As Button = sender

        firstvalue = txtdisplay.Text
        op = b.Text
        txtdisplay.Text = ""

    End Sub

    Private Sub btnequal_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnequal.Click
        secondvalue = txtdisplay.Text
        If op = "+" Then
            result = firstvalue + secondvalue
            txtdisplay.Text = result

        ElseIf op = "-" Then
            result = firstvalue - secondvalue
            txtdisplay.Text = result

        ElseIf op = "*" Then
            result = firstvalue * secondvalue
            txtdisplay.Text = result

        ElseIf op = "/" Then
            result = firstvalue / secondvalue
            txtdisplay.Text = result
        ElseIf op = "%" Then
            result = firstvalue * secondvalue / 100
            txtdisplay.Text = result
        

    

        End If
    End Sub

    Private Sub btnplusminus_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnplusminus.Click
        If (txtdisplay.Text.Contains("-")) Then
            txtdisplay.Text = txtdisplay.Text.Remove(0, 1)
        Else
            txtdisplay.Text = "-" + txtdisplay.Text

        End If


    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnclear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnclear.Click
        txtdisplay.Text = "0"
    End Sub
End Class
