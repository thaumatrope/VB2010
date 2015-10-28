' Project: Calorie Counter (Exercise 3.1)
' Programmer: Andre M Flaherty
' Date: 09 OCT 2015
' Description: Calculates and displays the number of calories for each category of food item (Fat, Carb, Protein), 
'              for whole food item, then counts number of food items and calories as a total.
' Folder: WindowsApplication1 (CaloriesForm, Documents: Visual Studio 2010, Projects)

Option Strict On

Public Class Form1

    ' Declare module-level variables and constants.
    Private Protein, Carbs, Fat, FoodItemInteger, Calories, TotalCalories As Integer
    Const CaloriesFatPerGram As Integer = 9
    Const CaloriesCarbsPerGram As Integer = 4
    Const CaloriesProteinPerGram As Integer = 4

    Private Sub CalculateButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CalculateButton.Click
        ' Calculate the number of calories for the current item and add the totals.
        Dim GramFat, GramCarbs, GramProtein As Integer

        Try
            ' Convert quantity to numeric value.
            GramFatInteger = Integer.Parse(
        Catch ex As Exception

        End Try

        Try
            ' Show Calories if valid input.
            Fat = Integer.Parse(FatTextBox.Text)
            Carbs = Integer.Parse(CarbTextBox.Text)
            Protein = Integer.Parse(ProteinTextBox.Text)

            ' Calculate values for Calories.
            Fat = GramFat * CaloriesFatPerGram
            Carbs = GramCarbs * CaloriesCarbsPerGram
            Protein = GramProtein * CaloriesProteinPerGram

            ' Calculate summary values.
            FoodItemInteger += 1
            Calories = (Fat + Carbs + Protein)
            TotalCalories += Calories

            ' Format and display Calories.
            FatTextBox.Text = Fat.ToString("NO")
            CarbTextBox.Text = Carbs.ToString("NO")
            ProteinTextBox.Text = Protein.ToString("NO")

            ' Format and display summary values.
            FoodItemTextBox.Text = FoodItemInteger.ToString("NO")
            CaloriesTextBox.Text = Calories.ToString("NO")
            TotCalTextBox.Text = TotalCalories.ToString("NO")

        Catch FatException As FormatException
            ' Handle Gram Fat input.
            MessageBox.Show("Gram Fat input must be numeric!",
            ' "Data Entry Error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With FatTextBox
                .Focus()
                .SelectAll()
            End With

        Catch CarbsException As FormatException
            ' Handle Gram Carb input.
            MessageBox.Show("Gram Carb input must be numeric!",
            "Data entry error!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            With CarbTextBox
                .Focus()
                .SelectAll()
            End With

        Catch AnException As Exception
            ' Handle any other Exception.
            MessageBox.Show("Data Error!" & AnException.Message)
        End Try
    End Sub

    Private Sub ClearButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ClearButton.Click
        'Clear previous amounts from the form.

        TitleTextBox.Clear()
        FatTextBox.Clear()
        CarbTextBox.Clear()
        ProteinTextBox.Clear()
        With FatTextBox
            .Clear()
            .Focus()
        End With
    End Sub

    Private Sub PrintButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles PrintButton.Click
        ' Print the form.

        PrintForm1.PrintAction = Printing.PrintAction.PrintToPreview
        PrintForm1.Print()
    End Sub

    Private Sub ExitButton_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ExitButton.Click
        ' Exit the project.

        Me.Close()
    End Sub
End Class

