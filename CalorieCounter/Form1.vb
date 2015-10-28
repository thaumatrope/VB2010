Option Strict On

Public Class CCounter

    Private iFat As Integer
    Private iCarbs As Integer
    Private iProtein As Integer
    Private iTotalFoodItems As Integer
    Private iTotalCalories As Integer
    Private iCurrentCalories As Integer
    Const CaloriesFatPerGram As Integer = 9
    Const CaloriesCarbsPerGram As Integer = 4
    Const CaloriesProteinPerGram As Integer = 4

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub


    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        lb_current_fat.Text = "0"
        lb_current_carbs.Text = "0"
        lb_current_protein.Text = "0"

        lb_TotalFoodItems.Text = "0"
        lb_SumCurrentCal.Text = "0"
        lb_TotalCal.Text = "0"

        in_fat.Text = "0"
        in_carbs.Text = "0"
        in_protein.Text = "0"

        iFat = 0
        iCarbs = 0
        iProtein = 0
        iTotalFoodItems = 0
        iTotalCalories = 0
        iCurrentCalories = 0

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        'Int32.TryParse(in_fat.Text, iFat)
        'Int32.TryParse(in_carbs.Text, iCarbs)
        'Int32.TryParse(in_protein.Text, iProtein)

        Dim exceptionNumber As Integer
        Dim GramFat, GramCarbs, GramProtein As Integer

        Try
            ' Show Calories if valid input.
            exceptionNumber = 0
            GramFat = Integer.Parse(in_fat.Text)
            exceptionNumber = 1
            GramCarbs = Integer.Parse(in_carbs.Text)
            exceptionNumber = 2
            GramProtein = Integer.Parse(in_protein.Text)

            ' Calculate values for Calories.
            iFat = GramFat * CaloriesFatPerGram
            iCarbs = GramCarbs * CaloriesCarbsPerGram
            iProtein = GramProtein * CaloriesProteinPerGram

            ' Calculate summary values.
            iTotalFoodItems += 1
            iCurrentCalories = iFat + iCarbs + iProtein
            iTotalCalories += iCurrentCalories

            ' Format and display Calories.
            lb_current_fat.Text = iFat.ToString("N0")
            lb_current_carbs.Text = iCarbs.ToString("N0")
            lb_current_protein.Text = iProtein.ToString("N0")

            ' Format and display summary values.
            lb_TotalFoodItems.Text = iTotalFoodItems.ToString("N0")
            lb_SumCurrentCal.Text = iCurrentCalories.ToString("N0")
            lb_TotalCal.Text = iTotalCalories.ToString("N0")

        Catch myException As FormatException

            If (exceptionNumber = 0) Then
                ' Handle Gram Fat input.
                MessageBox.Show("Gram Fat input must be numeric!",
                "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With in_fat
                    .Focus()
                    .SelectAll()
                End With
            ElseIf (exceptionNumber = 1) Then
                ' Handle Gram Carbs input.
                MessageBox.Show("Gram Carbs input must be numeric!",
                "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With in_carbs
                    .Focus()
                    .SelectAll()
                End With

            ElseIf (exceptionNumber = 2) Then
                ' Handle Gram Protein input.
                MessageBox.Show("Gram Protein input must be numeric!",
                "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                With in_protein
                    .Focus()
                    .SelectAll()
                End With

            End If


        Catch AnyException As Exception
            ' Handle any other Exception.
            MessageBox.Show("Data Error!" & AnyException.Message)
        End Try

        

    End Sub

    Private Sub TextBox_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles in_fat.Enter, in_carbs.Enter, in_protein.Enter, in_fat.TextChanged, in_carbs.TextChanged, in_protein.TextChanged
        Dim currTextBox As TextBox = DirectCast(sender, TextBox)

        If currTextBox.Equals(in_fat) Then
            If String.IsNullOrEmpty(in_fat.Text) Or (Int32.TryParse(in_fat.Text, iFat)) Then
                lb_current_fat.Text = CStr(iFat * CaloriesFatPerGram)
            Else
                MessageBox.Show("Fat Input, number values only!", "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                in_fat.Text = "0"
                lb_current_fat.Text = "0"
                iFat = 0
            End If
        ElseIf currTextBox.Equals(in_carbs) Then
            If String.IsNullOrEmpty(in_carbs.Text) Or (Int32.TryParse(in_carbs.Text, iCarbs)) Then
                lb_current_carbs.Text = CStr(iCarbs * CaloriesCarbsPerGram)
            Else
                MessageBox.Show("Carbs Input, number values only!", "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                in_carbs.Text = "0"
                lb_current_carbs.Text = "0"
                iCarbs = 0
            End If

        ElseIf currTextBox.Equals(in_protein) Then
            If String.IsNullOrEmpty(in_protein.Text) Or (Int32.TryParse(in_protein.Text, iProtein)) Then
                lb_current_protein.Text = CStr(iProtein * CaloriesProteinPerGram)
            Else
                MessageBox.Show("Proteins Input, number values only!", "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                in_protein.Text = "0"
                lb_current_protein.Text = "0"
                iProtein = 0
            End If

        End If

        lb_SumCurrentCal.Text = CStr((iFat * CaloriesFatPerGram) + (iCarbs * CaloriesCarbsPerGram) + (iProtein * CaloriesProteinPerGram))

    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles Button2.Click
        Me.myPrint.PrintAction = Printing.PrintAction.PrintToPreview
        Me.myPrint.Print()
    End Sub

End Class
