﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CCounter
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CCounter))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.in_protein = New System.Windows.Forms.TextBox()
        Me.in_carbs = New System.Windows.Forms.TextBox()
        Me.in_fat = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lb_TotalFoodItems = New System.Windows.Forms.Label()
        Me.lb_TotalCal = New System.Windows.Forms.Label()
        Me.lb_CurrentCal = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.myPrint = New Microsoft.VisualBasic.PowerPacks.Printing.PrintForm(Me.components)
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.in_protein)
        Me.GroupBox1.Controls.Add(Me.in_carbs)
        Me.GroupBox1.Controls.Add(Me.in_fat)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Location = New System.Drawing.Point(42, 66)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(240, 272)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "User Input"
        '
        'in_protein
        '
        Me.in_protein.Location = New System.Drawing.Point(119, 186)
        Me.in_protein.Name = "in_protein"
        Me.in_protein.Size = New System.Drawing.Size(85, 20)
        Me.in_protein.TabIndex = 6
        Me.in_protein.Text = "0"
        Me.in_protein.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'in_carbs
        '
        Me.in_carbs.Location = New System.Drawing.Point(119, 115)
        Me.in_carbs.Name = "in_carbs"
        Me.in_carbs.Size = New System.Drawing.Size(85, 20)
        Me.in_carbs.TabIndex = 5
        Me.in_carbs.Text = "0"
        Me.in_carbs.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'in_fat
        '
        Me.in_fat.Location = New System.Drawing.Point(119, 41)
        Me.in_fat.Name = "in_fat"
        Me.in_fat.Size = New System.Drawing.Size(85, 20)
        Me.in_fat.TabIndex = 4
        Me.in_fat.Text = "0"
        Me.in_fat.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(20, 184)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Protein"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(20, 46)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(24, 15)
        Me.Label5.TabIndex = 2
        Me.Label5.Text = "Fat"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(20, 113)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 15)
        Me.Label4.TabIndex = 1
        Me.Label4.Text = "Carbs"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lb_TotalFoodItems)
        Me.GroupBox2.Controls.Add(Me.lb_TotalCal)
        Me.GroupBox2.Controls.Add(Me.lb_CurrentCal)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Location = New System.Drawing.Point(324, 66)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(240, 272)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Output"
        '
        'lb_TotalFoodItems
        '
        Me.lb_TotalFoodItems.AutoSize = True
        Me.lb_TotalFoodItems.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_TotalFoodItems.Location = New System.Drawing.Point(188, 187)
        Me.lb_TotalFoodItems.Name = "lb_TotalFoodItems"
        Me.lb_TotalFoodItems.Size = New System.Drawing.Size(15, 16)
        Me.lb_TotalFoodItems.TabIndex = 5
        Me.lb_TotalFoodItems.Text = "0"
        '
        'lb_TotalCal
        '
        Me.lb_TotalCal.AutoSize = True
        Me.lb_TotalCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_TotalCal.Location = New System.Drawing.Point(188, 116)
        Me.lb_TotalCal.Name = "lb_TotalCal"
        Me.lb_TotalCal.Size = New System.Drawing.Size(15, 16)
        Me.lb_TotalCal.TabIndex = 4
        Me.lb_TotalCal.Text = "0"
        '
        'lb_CurrentCal
        '
        Me.lb_CurrentCal.AutoSize = True
        Me.lb_CurrentCal.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lb_CurrentCal.Location = New System.Drawing.Point(188, 45)
        Me.lb_CurrentCal.Name = "lb_CurrentCal"
        Me.lb_CurrentCal.Size = New System.Drawing.Size(15, 16)
        Me.lb_CurrentCal.TabIndex = 3
        Me.lb_CurrentCal.Text = "0"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(33, 184)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(98, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Total Food Items"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(33, 113)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(82, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Total Calories"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(33, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Current Calories"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(42, 22)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Calculate"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(261, 22)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Print"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(150, 22)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "Clear"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(489, 22)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Exit"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'myPrint
        '
        Me.myPrint.DocumentName = "document"
        Me.myPrint.Form = Me
        Me.myPrint.PrintAction = System.Drawing.Printing.PrintAction.PrintToPrinter
        Me.myPrint.PrinterSettings = CType(resources.GetObject("myPrint.PrinterSettings"), System.Drawing.Printing.PrinterSettings)
        Me.myPrint.PrintFileName = Nothing
        '
        'CCounter
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(605, 365)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "CCounter"
        Me.Text = "Calorie Counter"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents in_protein As System.Windows.Forms.TextBox
    Friend WithEvents in_carbs As System.Windows.Forms.TextBox
    Friend WithEvents in_fat As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents lb_TotalFoodItems As System.Windows.Forms.Label
    Friend WithEvents lb_TotalCal As System.Windows.Forms.Label
    Friend WithEvents lb_CurrentCal As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents myPrint As Microsoft.VisualBasic.PowerPacks.Printing.PrintForm

End Class
