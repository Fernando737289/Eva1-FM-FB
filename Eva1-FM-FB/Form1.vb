Public Class Form1
    Dim valorPorDefecto As Double = 0
    Dim operaionPorDefecto As String = ""
    Dim OperacionClik As Boolean = False

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txtDisplay.Text = ""
    End Sub

    Private Sub btn_Click(sender As Object, e As EventArgs) Handles bt0.Click, bt1.Click, bt2.Click, bt3.Click, bt4.Click, bt5.Click, bt6.Click, bt7.Click, bt8.Click, bt9.Click
        txtDisplay.Text &= sender.text
    End Sub

    Private Sub btnOperation_Click(sender As Object, e As EventArgs) Handles btSum.Click, btRestar.Click, btMul.Click, btDiv.Click
        txtDisplay.Text &= " " & sender.text & " "
    End Sub

    Private Sub btIgual_Click(sender As Object, e As EventArgs) Handles btIgual.Click

        Dim parts As String() = txtDisplay.Text.Split(" "c)
        If parts.Length = 3 Then
            Dim num1 As Double = Convert.ToDouble(parts(0))
            Dim num2 As Double = Convert.ToDouble(parts(2))
            Dim result As Double = 0

            Select Case parts(1)
                Case "+"
                    result = num1 + num2
                Case "-"
                    result = num1 - num2
                Case "X"
                    result = num1 * num2
                Case "/"
                    If num2 <> 0 Then
                        result = num1 / num2
                    Else
                        MessageBox.Show("No se puede dividir entre 0.")
                        Exit Sub
                    End If
            End Select

            txtDisplay.Text = result.ToString()
        End If
    End Sub

    Private Sub btBorrar_Click(sender As Object, e As EventArgs) Handles btBorrar.Click
        txtDisplay.Text = ""
        valorPorDefecto = 0
        operaionPorDefecto = ""
    End Sub
End Class
