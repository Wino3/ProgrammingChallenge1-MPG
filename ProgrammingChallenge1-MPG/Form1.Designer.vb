<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMPG
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnAccept = New System.Windows.Forms.Button()
        Me.btnExitCancel = New System.Windows.Forms.Button()
        Me.txtMilesDrive = New System.Windows.Forms.TextBox()
        Me.txtGasTank = New System.Windows.Forms.TextBox()
        Me.lblGallonsCarHolds = New System.Windows.Forms.Label()
        Me.lblMilesDriven = New System.Windows.Forms.Label()
        Me.lblMPGTotal = New System.Windows.Forms.Label()
        Me.btnClear = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 26)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cher Hill" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "CS 115" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'btnAccept
        '
        Me.btnAccept.AccessibleRole = System.Windows.Forms.AccessibleRole.None
        Me.btnAccept.Location = New System.Drawing.Point(185, 313)
        Me.btnAccept.Name = "btnAccept"
        Me.btnAccept.Size = New System.Drawing.Size(100, 23)
        Me.btnAccept.TabIndex = 6
        Me.btnAccept.TabStop = False
        Me.btnAccept.Text = "Accept"
        Me.btnAccept.UseVisualStyleBackColor = True
        '
        'btnExitCancel
        '
        Me.btnExitCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnExitCancel.Location = New System.Drawing.Point(462, 313)
        Me.btnExitCancel.Name = "btnExitCancel"
        Me.btnExitCancel.Size = New System.Drawing.Size(75, 23)
        Me.btnExitCancel.TabIndex = 7
        Me.btnExitCancel.Text = "Exit/Cancel"
        Me.btnExitCancel.UseVisualStyleBackColor = True
        '
        'txtMilesDrive
        '
        Me.txtMilesDrive.Location = New System.Drawing.Point(437, 131)
        Me.txtMilesDrive.Name = "txtMilesDrive"
        Me.txtMilesDrive.Size = New System.Drawing.Size(100, 20)
        Me.txtMilesDrive.TabIndex = 4
        '
        'txtGasTank
        '
        Me.txtGasTank.Location = New System.Drawing.Point(437, 78)
        Me.txtGasTank.Name = "txtGasTank"
        Me.txtGasTank.Size = New System.Drawing.Size(100, 20)
        Me.txtGasTank.TabIndex = 2
        '
        'lblGallonsCarHolds
        '
        Me.lblGallonsCarHolds.AutoSize = True
        Me.lblGallonsCarHolds.Location = New System.Drawing.Point(161, 78)
        Me.lblGallonsCarHolds.Name = "lblGallonsCarHolds"
        Me.lblGallonsCarHolds.Size = New System.Drawing.Size(251, 13)
        Me.lblGallonsCarHolds.TabIndex = 1
        Me.lblGallonsCarHolds.Text = "Enter the number of gallons the car's gas tank holds"
        '
        'lblMilesDriven
        '
        Me.lblMilesDriven.AutoSize = True
        Me.lblMilesDriven.Location = New System.Drawing.Point(161, 138)
        Me.lblMilesDriven.Name = "lblMilesDriven"
        Me.lblMilesDriven.Size = New System.Drawing.Size(257, 13)
        Me.lblMilesDriven.TabIndex = 3
        Me.lblMilesDriven.Text = "Enter the number of miles traveled on this tank of gas"
        '
        'lblMPGTotal
        '
        Me.lblMPGTotal.AutoSize = True
        Me.lblMPGTotal.Location = New System.Drawing.Point(161, 202)
        Me.lblMPGTotal.Name = "lblMPGTotal"
        Me.lblMPGTotal.Size = New System.Drawing.Size(0, 13)
        Me.lblMPGTotal.TabIndex = 5
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(343, 313)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(75, 23)
        Me.btnClear.TabIndex = 6
        Me.btnClear.Text = "Clear"
        Me.btnClear.UseVisualStyleBackColor = True
        '
        'frmMPG
        '
        Me.AcceptButton = Me.btnAccept
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnExitCancel
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnClear)
        Me.Controls.Add(Me.lblMPGTotal)
        Me.Controls.Add(Me.lblMilesDriven)
        Me.Controls.Add(Me.lblGallonsCarHolds)
        Me.Controls.Add(Me.txtGasTank)
        Me.Controls.Add(Me.txtMilesDrive)
        Me.Controls.Add(Me.btnExitCancel)
        Me.Controls.Add(Me.btnAccept)
        Me.Controls.Add(Me.Label1)
        Me.Name = "frmMPG"
        Me.Text = "Miles per gallon"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents btnAccept As Button
    Friend WithEvents btnExitCancel As Button
    Friend WithEvents txtMilesDrive As TextBox
    Friend WithEvents txtGasTank As TextBox
    Friend WithEvents lblGallonsCarHolds As Label
    Friend WithEvents lblMilesDriven As Label
    Friend WithEvents lblMPGTotal As Label
    Friend WithEvents btnClear As Button
End Class
