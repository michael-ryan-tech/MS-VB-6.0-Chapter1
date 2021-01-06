Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub cmdEvaluate_Click(sender As Object, e As EventArgs) Handles cmdEvaluate.Click

        Dim dblWidth As Double, dblHeight As Double
        Dim strWidth As String, strHeight As String
        Dim blIsNumber As Boolean

        blIsNumber = False

        strWidth = ""
        strHeight = ""

        If txtWidth.Text = "" Then

            MsgBox("Please enter width", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing Width")

            Exit Sub

        End If

        If txtHeight.Text = "" Then

            MsgBox("Please enter height", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Missing height")

            Exit Sub

        End If

        strWidth = txtWidth.Text
        strHeight = txtHeight.Text

        blIsNumber = IsNumeric(strWidth) And IsNumeric(strHeight)

        If blIsNumber = False Then

            MsgBox("Please Enter a Number", MsgBoxStyle.OkOnly, "Numbers Only")

            Exit Sub

        End If

        dblWidth = CDbl(strWidth)
        dblHeight = CDbl(strHeight)

        txtPerimeter.Text = CStr((dblWidth + dblHeight) * 2)
        txtArea.Text = CStr(dblWidth * dblHeight)

    End Sub
End Class