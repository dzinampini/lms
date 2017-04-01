<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Admin
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
        Me.rdoManageLibrarians = New System.Windows.Forms.RadioButton()
        Me.rdoManageAcc = New System.Windows.Forms.RadioButton()
        Me.rdoReports = New System.Windows.Forms.RadioButton()
        Me.grpMenu.SuspendLayout()
        Me.SuspendLayout()
        '
        'grpMenu
        '
        Me.grpMenu.Controls.Add(Me.rdoManageLibrarians)
        Me.grpMenu.Controls.Add(Me.rdoManageAcc)
        Me.grpMenu.Controls.Add(Me.rdoReports)
        Me.grpMenu.Location = New System.Drawing.Point(27, 89)
        Me.grpMenu.Name = "grpMenu"
        Me.grpMenu.Size = New System.Drawing.Size(390, 440)
        Me.grpMenu.TabIndex = 2
        Me.grpMenu.TabStop = False
        Me.grpMenu.Text = "Actions"
        '
        'rdoManageLibrarians
        '
        Me.rdoManageLibrarians.AutoSize = True
        Me.rdoManageLibrarians.Location = New System.Drawing.Point(21, 89)
        Me.rdoManageLibrarians.Name = "rdoManageLibrarians"
        Me.rdoManageLibrarians.Size = New System.Drawing.Size(112, 17)
        Me.rdoManageLibrarians.TabIndex = 2
        Me.rdoManageLibrarians.TabStop = True
        Me.rdoManageLibrarians.Text = "Manage Librarians"
        Me.rdoManageLibrarians.UseVisualStyleBackColor = True
        '
        'rdoManageAcc
        '
        Me.rdoManageAcc.AutoSize = True
        Me.rdoManageAcc.Location = New System.Drawing.Point(21, 65)
        Me.rdoManageAcc.Name = "rdoManageAcc"
        Me.rdoManageAcc.Size = New System.Drawing.Size(107, 17)
        Me.rdoManageAcc.TabIndex = 1
        Me.rdoManageAcc.TabStop = True
        Me.rdoManageAcc.Text = "Manage Account"
        Me.rdoManageAcc.UseVisualStyleBackColor = True
        '
        'rdoReports
        '
        Me.rdoReports.AutoSize = True
        Me.rdoReports.Location = New System.Drawing.Point(21, 42)
        Me.rdoReports.Name = "rdoReports"
        Me.rdoReports.Size = New System.Drawing.Size(62, 17)
        Me.rdoReports.TabIndex = 0
        Me.rdoReports.TabStop = True
        Me.rdoReports.Text = "Reports"
        Me.rdoReports.UseVisualStyleBackColor = True
        '
        'Admin
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(699, 558)
        Me.Controls.Add(Me.grpMenu)
        Me.Name = "Admin"
        Me.Text = "Admin"
        Me.grpMenu.ResumeLayout(False)
        Me.grpMenu.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grpMenu As System.Windows.Forms.GroupBox
    Friend WithEvents rdoManageLibrarians As System.Windows.Forms.RadioButton
    Friend WithEvents rdoManageAcc As System.Windows.Forms.RadioButton
    Friend WithEvents rdoReports As System.Windows.Forms.RadioButton
End Class
