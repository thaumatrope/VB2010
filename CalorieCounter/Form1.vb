Public Class CCounter


    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    
    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs) Handles Button3.Click
        lb_CurrentCal.Text = "0"
        lb_TotalCal.Text = "0"
        lb_TotalFoodItems.Text = "0"

        in_fat.Text = "0"
        in_carbs.Text = "0"
        in_protein.Text = "0"

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles Button1.Click

        Dim iFat As Integer
        Int32.TryParse(in_fat.Text, iFat)

        Dim iCarbs As Integer
        Int32.TryParse(in_carbs.Text, iCarbs)

        Dim iProtein As Integer
        Int32.TryParse(in_protein.Text, iProtein)



        lb_TotalCal.Text = (iFat * 9) + (iCarbs * 4) + (iProtein * 4)
        lb_TotalFoodItems.Text = iFat + iCarbs + iProtein


    End Sub

    Private Sub TextBox_Focus(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles in_fat.Enter, in_carbs.Enter, in_protein.Enter, in_fat.TextChanged, in_carbs.TextChanged, in_protein.TextChanged
        Dim currTextBox As TextBox = sender

        Dim iFat As Integer
        Dim iCarbs As Integer
        Dim iProtein As Integer

        If currTextBox.Equals(in_fat) Then
            If String.IsNullOrEmpty(in_fat.Text) Or (Int32.TryParse(in_fat.Text, iFat)) Then
                lb_CurrentCal.Text = iFat * 9
            Else
                MessageBox.Show("Fat must be in full numbers (Integer)")
                in_fat.Text = "0"
            End If
        ElseIf currTextBox.Equals(in_carbs) Then
            If String.IsNullOrEmpty(in_carbs.Text) Or (Int32.TryParse(in_carbs.Text, iCarbs)) Then
                lb_CurrentCal.Text = iCarbs * 4
            Else
                MessageBox.Show("Carbs must be in full numbers (Integer)")
                in_carbs.Text = "0"
            End If

        ElseIf currTextBox.Equals(in_protein) Then
            If String.IsNullOrEmpty(in_protein.Text) Or (Int32.TryParse(in_protein.Text, iProtein)) Then
                lb_CurrentCal.Text = iProtein * 4
            Else
                MessageBox.Show("Protein must be in full numbers (Integer)")
                in_protein.Text = "0"
            End If

        End If

    End Sub
End Class
