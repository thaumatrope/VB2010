Public Class CCounter

    Private iHairstyle As Integer
    Private iManicure As Integer
    Private iMakeover As Integer
    Private iMakeup As Integer

    Private iCurrentService As Integer
    Private iTotalServices As Integer

    Const HairstylePrice As Integer = 60
    Const ManicurePrice As Integer = 35
    Const MakeoverPrice As Integer = 125
    Const MakeupPrice As Integer = 200


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As System.Object, e As System.EventArgs) Handles RadioButton1.CheckedChanged

    End Sub

    Private Sub RadioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton5.Click, RadioButton4.Click, RadioButton6.Click
        Dim rb As RadioButton = DirectCast(sender, RadioButton)

        'If RadioButton3.Checked = True Then
        'MsgBox("You chose a thin crust")
        'Else
        'MsgBox("You chose a thick crust")
        'End If

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.myPrint.PrintAction = Printing.PrintAction.PrintToPreview
        Me.myPrint.Print()
    End Sub
End Class
