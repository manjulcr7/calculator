Public Class Form1
    Dim firstnumber As Decimal
    Dim secondnumber As Decimal
    Dim Operations As Integer
    Dim OperatorSelector As Boolean = False

    Private Sub Number2_Click(sender As Object, e As EventArgs) Handles Number2.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "2"
        Else
            TextBox1.Text += "2"
        End If
    End Sub

    Private Sub Number1_Click(sender As Object, e As EventArgs) Handles Number1.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "1"
        Else
            TextBox1.Text += "1"
        End If
    End Sub

    Private Sub Number3_Click(sender As Object, e As EventArgs) Handles Number3.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "3"
        Else
            TextBox1.Text += "3"
        End If
    End Sub

    Private Sub Number4_Click(sender As Object, e As EventArgs) Handles Number4.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "4"
        Else
            TextBox1.Text += "4"
        End If
    End Sub

    Private Sub Number5_Click(sender As Object, e As EventArgs) Handles Number5.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "5"
        Else
            TextBox1.Text += "5"
        End If
    End Sub

    Private Sub Number6_Click(sender As Object, e As EventArgs) Handles Number6.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "6"
        Else
            TextBox1.Text += "6"
        End If
    End Sub

    Private Sub Number7_Click(sender As Object, e As EventArgs) Handles Number7.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "7"
        Else
            TextBox1.Text += "7"
        End If
    End Sub

    Private Sub Number8_Click(sender As Object, e As EventArgs) Handles Number8.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "8"
        Else
            TextBox1.Text += "8"
        End If
    End Sub

    Private Sub Number9_Click(sender As Object, e As EventArgs) Handles Number9.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "9"
        Else
            TextBox1.Text += "9"
        End If
    End Sub

    Private Sub add_Click(sender As Object, e As EventArgs) Handles add.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0" 'text is zero now
        OperatorSelector = True
        Operations = 1
    End Sub

    Private Sub subt_Click(sender As Object, e As EventArgs) Handles subt.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0" 'text is zero now
        OperatorSelector = True
        Operations = 2
    End Sub

    Private Sub mult_Click(sender As Object, e As EventArgs) Handles mult.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0" 'text is zero now
        OperatorSelector = True
        Operations = 3
    End Sub

    Private Sub div_Click(sender As Object, e As EventArgs) Handles div.Click
        firstnumber = TextBox1.Text
        TextBox1.Text = "0" 'text is zero now
        OperatorSelector = True
        Operations = 4
    End Sub

    Private Sub period_Click(sender As Object, e As EventArgs) Handles period.Click
        If Not TextBox1.Text.Contains(".") Then
            TextBox1.Text += "."
        End If
    End Sub

    Private Sub equals_Click(sender As Object, e As EventArgs) Handles equals.Click
        If OperatorSelector = True Then
            secondnumber = TextBox1.Text
            If Operations = 1 Then
                TextBox1.Text = firstnumber + secondnumber
            ElseIf Operations = 2 Then
                TextBox1.Text = firstnumber - secondnumber
            ElseIf Operations = 3 Then
                TextBox1.Text = firstnumber * secondnumber
            Else
                If secondnumber = 0 Then
                    TextBox1.Text = "ERROR!"
                Else
                    TextBox1.Text = firstnumber / secondnumber
                End If
            End If
            OperatorSelector = False
        End If
    End Sub

    Private Sub C_Click(sender As Object, e As EventArgs) Handles C.Click
        TextBox1.Text = "0"
    End Sub

    Private Sub Number0_Click(sender As Object, e As EventArgs) Handles Number0.Click
        If TextBox1.Text = "0" Then
            TextBox1.Text = "0"
        Else
            TextBox1.Text += "0"
        End If
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class
