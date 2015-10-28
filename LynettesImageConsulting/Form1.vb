Option Strict On

Public Class LynetteIC

    Private iHairstyle As Integer
    Private iManicure As Integer
    Private iMakeover As Integer
    Private iMakeup As Integer

    Private dCurrentService As Decimal
    Private dTotalServices As Decimal

    Const HairstylePrice As Decimal = 60
    Const ManicurePrice As Decimal = 35
    Const MakeoverPrice As Decimal = 125
    Const MakeupPrice As Decimal = 200


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Private Sub RadioButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RadioButton1.Click, RadioButton2.Click, RadioButton3.Click, RadioButton5.Click, RadioButton4.Click, RadioButton6.Click

        Dim dDiscount As Decimal

        If RadioButton1.Checked = True Then
            dDiscount = 0D
        ElseIf RadioButton2.Checked = True Then
            dDiscount = 0.1D
        ElseIf RadioButton3.Checked = True Then
            dDiscount = 0.2D
        Else
            dDiscount = 0D
        End If

        If RadioButton4.Checked = True Then
            dCurrentService = HairstylePrice - (HairstylePrice * dDiscount)
        ElseIf RadioButton5.Checked = True Then
            dCurrentService = ManicurePrice - (ManicurePrice * dDiscount)
        ElseIf RadioButton6.Checked = True Then
            dCurrentService = MakeoverPrice - (MakeoverPrice * dDiscount)
        ElseIf RadioButton6.Checked = True Then
            dCurrentService = MakeupPrice - (MakeupPrice * dDiscount)
        Else
            dCurrentService = 0D
        End If


        tbCurrent.Text = dCurrentService.ToString("N2")


    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.myPrint.PrintAction = Printing.PrintAction.PrintToPreview
        Me.myPrint.Print()
    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click

        tbCurrent.Text = "0"
        tbTotal.Text = "0"

        iHairstyle = 0
        iManicure = 0
        iMakeover = 0
        iMakeup = 0

        dCurrentService = 0
        dTotalServices = 0

        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False


    End Sub


    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim dDiscount As Decimal

        If RadioButton1.Checked = True Then
            dDiscount = 0D
        ElseIf RadioButton2.Checked = True Then
            dDiscount = 0.1D
        ElseIf RadioButton3.Checked = True Then
            dDiscount = 0.2D
        Else
            dDiscount = 0D
        End If

        If RadioButton4.Checked = True Then
            dCurrentService = HairstylePrice - (HairstylePrice * dDiscount)
        ElseIf RadioButton5.Checked = True Then
            dCurrentService = ManicurePrice - (ManicurePrice * dDiscount)
        ElseIf RadioButton6.Checked = True Then
            dCurrentService = MakeoverPrice - (MakeoverPrice * dDiscount)
        ElseIf RadioButton7.Checked = True Then
            dCurrentService = MakeupPrice - (MakeupPrice * dDiscount)
        Else
            dCurrentService = 0D
        End If

        dTotalServices += dCurrentService
        tbTotal.Text = dTotalServices.ToString("N2")


        iHairstyle = 0
        iManicure = 0
        iMakeover = 0
        iMakeup = 0

        dCurrentService = 0D
        tbCurrent.Text = "0"

        RadioButton1.Checked = True
        RadioButton2.Checked = False
        RadioButton3.Checked = False
        RadioButton4.Checked = False
        RadioButton5.Checked = False
        RadioButton6.Checked = False
        RadioButton7.Checked = False

    End Sub
End Class
