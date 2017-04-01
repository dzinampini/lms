<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Librarian
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.grpMenu = New System.Windows.Forms.GroupBox()
        Me.rdoSearch = New System.Windows.Forms.RadioButton()
        Me.rdoReturn = New System.Windows.Forms.RadioButton()
        Me.rdoManageBooks = New System.Windows.Forms.RadioButton()
        Me.rdoManageCategories = New System.Windows.Forms.RadioButton()
        Me.rdoManageAccount = New System.Windows.Forms.RadioButton()
        Me.rdoManageStudents = New System.Windows.Forms.RadioButton()
        Me.grpManageBooks = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAddBooks = New System.Windows.Forms.Button()
        Me.btnRemoveBooks = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.TextBox5 = New System.Windows.Forms.TextBox()
        Me.TextBox6 = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.grpManageCategories = New System.Windows.Forms.GroupBox()
        Me.btnAddCategory = New System.Windows.Forms.Button()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txtAddCategory = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.grpMenu.SuspendLayout()
        Me.grpManageBooks.SuspendLayout()
        Me.grpManageCategories.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.grpManageCategories)
        Me.grpMenu.Controls.Add(Me.rdoManageStudents)
        Me.grpMenu.Controls.Add(Me.grpManageBooks)
        Me.grpMenu.Controls.Add(Me.rdoManageAccount)
        Me.grpMenu.Controls.Add(Me.rdoManageCategories)
        Me.grpMenu.Controls.Add(Me.rdoManageBooks)
        Me.grpMenu.Controls.Add(Me.rdoReturn)
        Me.grpMenu.Controls.Add(Me.rdoSearch)
        Me.grpMenu.Location = New System.Drawing.Point(22, 114)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(390, 440)
        Me.grpMenu.TabIndex = 1
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Actions"
        '
        'rdoSearch
        '
        Me.rdoSearch.AutoSize = True
        Me.rdoSearch.Location = New System.Drawing.Point(21, 42)
        Me.rdoSearch.Name = "rdoSearch"
        Me.rdoSearch.Size = New System.Drawing.Size(122, 17)
        Me.rdoSearch.TabIndex = 0
        Me.rdoSearch.TabStop = True
        Me.rdoSearch.Text = "Search/Issue Books"
        Me.rdoSearch.UseVisualStyleBackColor = True
        '
        'rdoReturn
        '
        Me.rdoReturn.AutoSize = True
        Me.rdoReturn.Location = New System.Drawing.Point(21, 65)
        Me.rdoReturn.Name = "rdoReturn"
        Me.rdoReturn.Size = New System.Drawing.Size(90, 17)
        Me.rdoReturn.TabIndex = 1
        Me.rdoReturn.TabStop = True
        Me.rdoReturn.Text = "Return Books"
        Me.rdoReturn.UseVisualStyleBackColor = True
        '
        'rdoManageBooks
        '
        Me.rdoManageBooks.AutoSize = True
        Me.rdoManageBooks.Location = New System.Drawing.Point(21, 89)
        Me.rdoManageBooks.Name = "rdoManageBooks"
        Me.rdoManageBooks.Size = New System.Drawing.Size(97, 17)
        Me.rdoManageBooks.TabIndex = 2
        Me.rdoManageBooks.TabStop = True
        Me.rdoManageBooks.Text = "Manage Books"
        Me.rdoManageBooks.UseVisualStyleBackColor = True
        '
        'rdoManageCategories
        '
        Me.rdoManageCategories.AutoSize = True
        Me.rdoManageCategories.Location = New System.Drawing.Point(21, 113)
        Me.rdoManageCategories.Name = "rdoManageCategories"
        Me.rdoManageCategories.Size = New System.Drawing.Size(117, 17)
        Me.rdoManageCategories.TabIndex = 3
        Me.rdoManageCategories.TabStop = True
        Me.rdoManageCategories.Text = "Manage Categories"
        Me.rdoManageCategories.UseVisualStyleBackColor = True
        '
        'rdoManageAccount
        '
        Me.rdoManageAccount.AutoSize = True
        Me.rdoManageAccount.Location = New System.Drawing.Point(21, 159)
        Me.rdoManageAccount.Name = "rdoManageAccount"
        Me.rdoManageAccount.Size = New System.Drawing.Size(107, 17)
        Me.rdoManageAccount.TabIndex = 4
        Me.rdoManageAccount.TabStop = True
        Me.rdoManageAccount.Text = "Manage Account"
        Me.rdoManageAccount.UseVisualStyleBackColor = True
        '
        'rdoManageStudents
        '
        Me.rdoManageStudents.AutoSize = True
        Me.rdoManageStudents.Location = New System.Drawing.Point(21, 136)
        Me.rdoManageStudents.Name = "rdoManageStudents"
        Me.rdoManageStudents.Size = New System.Drawing.Size(109, 17)
        Me.rdoManageStudents.TabIndex = 5
        Me.rdoManageStudents.TabStop = True
        Me.rdoManageStudents.Text = "Manage Students"
        Me.rdoManageStudents.UseVisualStyleBackColor = True
        '
        'grpManageBooks
        '
        Me.grpManageBooks.Controls.Add(Me.btnRemoveBooks)
        Me.grpManageBooks.Controls.Add(Me.Label6)
        Me.grpManageBooks.Controls.Add(Me.Label7)
        Me.grpManageBooks.Controls.Add(Me.Label8)
        Me.grpManageBooks.Controls.Add(Me.ComboBox2)
        Me.grpManageBooks.Controls.Add(Me.TextBox3)
        Me.grpManageBooks.Controls.Add(Me.TextBox5)
        Me.grpManageBooks.Controls.Add(Me.TextBox6)
        Me.grpManageBooks.Controls.Add(Me.Label9)
        Me.grpManageBooks.Controls.Add(Me.Label10)
        Me.grpManageBooks.Controls.Add(Me.btnAddBooks)
        Me.grpManageBooks.Controls.Add(Me.Label5)
        Me.grpManageBooks.Controls.Add(Me.Label4)
        Me.grpManageBooks.Controls.Add(Me.Label3)
        Me.grpManageBooks.Controls.Add(Me.ComboBox1)
        Me.grpManageBooks.Controls.Add(Me.TextBox4)
        Me.grpManageBooks.Controls.Add(Me.TextBox2)
        Me.grpManageBooks.Controls.Add(Me.TextBox1)
        Me.grpManageBooks.Controls.Add(Me.Label2)
        Me.grpManageBooks.Controls.Add(Me.Label1)
        Me.grpManageBooks.Location = New System.Drawing.Point(76, 0)
        Me.grpManageBooks.Name = "grpManageBooks"
        Me.grpManageBooks.Size = New System.Drawing.Size(390, 440)
        Me.grpManageBooks.TabIndex = 6
        Me.grpManageBooks.TabStop = False
        Me.grpManageBooks.Text = "Manage Books"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(17, 34)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Add Books"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(17, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(55, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Book Title"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(165, 60)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(199, 20)
        Me.TextBox1.TabIndex = 2
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(165, 86)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(199, 20)
        Me.TextBox2.TabIndex = 3
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(165, 137)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(199, 20)
        Me.TextBox4.TabIndex = 5
        '
        'ComboBox1
        '
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(165, 112)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox1.TabIndex = 6
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(17, 86)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "Author"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(17, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(49, 13)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Category"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 137)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(32, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "ISBN"
        '
        'btnAddBooks
        '
        Me.btnAddBooks.Location = New System.Drawing.Point(289, 170)
        Me.btnAddBooks.Name = "btnAddBooks"
        Me.btnAddBooks.Size = New System.Drawing.Size(75, 23)
        Me.btnAddBooks.TabIndex = 10
        Me.btnAddBooks.Text = "Add Book/s"
        Me.btnAddBooks.UseVisualStyleBackColor = True
        '
        'btnRemoveBooks
        '
        Me.btnRemoveBooks.Location = New System.Drawing.Point(269, 387)
        Me.btnRemoveBooks.Name = "btnRemoveBooks"
        Me.btnRemoveBooks.Size = New System.Drawing.Size(95, 23)
        Me.btnRemoveBooks.TabIndex = 20
        Me.btnRemoveBooks.Text = "Remove Book/s"
        Me.btnRemoveBooks.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 354)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(32, 13)
        Me.Label6.TabIndex = 19
        Me.Label6.Text = "ISBN"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 329)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(49, 13)
        Me.Label7.TabIndex = 18
        Me.Label7.Text = "Category"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 303)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(38, 13)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Author"
        '
        'ComboBox2
        '
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(165, 329)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(199, 21)
        Me.ComboBox2.TabIndex = 16
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(165, 354)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(199, 20)
        Me.TextBox3.TabIndex = 15
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(165, 303)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(199, 20)
        Me.TextBox5.TabIndex = 14
        '
        'TextBox6
        '
        Me.TextBox6.Location = New System.Drawing.Point(165, 277)
        Me.TextBox6.Name = "TextBox6"
        Me.TextBox6.Size = New System.Drawing.Size(199, 20)
        Me.TextBox6.TabIndex = 13
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 280)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(55, 13)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Book Title"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 251)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(92, 13)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Remove Books"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(72, 575)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(364, 13)
        Me.Label11.TabIndex = 6
        Me.Label11.Text = "You are logged in as (cookies). Designed and Developed by (student name)"
        '
        'grpManageCategories
        '
        Me.grpManageCategories.Controls.Add(Me.btnAddCategory)
        Me.grpManageCategories.Controls.Add(Me.Label18)
        Me.grpManageCategories.Controls.Add(Me.txtAddCategory)
        Me.grpManageCategories.Controls.Add(Me.Label21)
        Me.grpManageCategories.Location = New System.Drawing.Point(21, 31)
        Me.grpManageCategories.Name = "grpManageCategories"
        Me.grpManageCategories.Size = New System.Drawing.Size(390, 440)
        Me.grpManageCategories.TabIndex = 21
        Me.grpManageCategories.TabStop = False
        Me.grpManageCategories.Text = "Manage Categories"
        '
        'btnAddCategory
        '
        Me.btnAddCategory.Location = New System.Drawing.Point(255, 104)
        Me.btnAddCategory.Name = "btnAddCategory"
        Me.btnAddCategory.Size = New System.Drawing.Size(108, 23)
        Me.btnAddCategory.TabIndex = 10
        Me.btnAddCategory.Text = "Add Category"
        Me.btnAddCategory.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(17, 67)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(49, 13)
        Me.Label18.TabIndex = 8
        Me.Label18.Text = "Category"
        '
        'txtAddCategory
        '
        Me.txtAddCategory.Location = New System.Drawing.Point(103, 64)
        Me.txtAddCategory.Name = "txtAddCategory"
        Me.txtAddCategory.Size = New System.Drawing.Size(261, 20)
        Me.txtAddCategory.TabIndex = 2
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(17, 34)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(83, 13)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "Add Category"
        '
        'Librarian
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(770, 597)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.grpMenu)
        Me.Name = "Librarian"
        Me.Text = "Librarian"
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        Me.grpManageBooks.ResumeLayout(False)
        Me.grpManageBooks.PerformLayout()
        Me.grpManageCategories.ResumeLayout(False)
        Me.grpManageCategories.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grpMenu As System.Windows.Forms.GroupBox
    Friend WithEvents rdoManageStudents As System.Windows.Forms.RadioButton
    Friend WithEvents rdoManageAccount As System.Windows.Forms.RadioButton
    Friend WithEvents rdoManageCategories As System.Windows.Forms.RadioButton
    Friend WithEvents rdoManageBooks As System.Windows.Forms.RadioButton
    Friend WithEvents rdoReturn As System.Windows.Forms.RadioButton
    Friend WithEvents rdoSearch As System.Windows.Forms.RadioButton
    Friend WithEvents grpManageBooks As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnRemoveBooks As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
    Friend WithEvents TextBox6 As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btnAddBooks As System.Windows.Forms.Button
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents grpManageCategories As System.Windows.Forms.GroupBox
    Friend WithEvents btnAddCategory As System.Windows.Forms.Button
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txtAddCategory As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
End Class
