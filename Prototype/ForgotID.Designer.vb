<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ForgotID
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
        Me.btnForgotPass = New System.Windows.Forms.Button()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtDigit = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblPin = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnForgotPass
        '
        Me.btnForgotPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgotPass.Location = New System.Drawing.Point(136, 191)
        Me.btnForgotPass.Name = "btnForgotPass"
        Me.btnForgotPass.Size = New System.Drawing.Size(99, 33)
        Me.btnForgotPass.TabIndex = 5
        Me.btnForgotPass.Text = "Get ID"
        Me.btnForgotPass.UseVisualStyleBackColor = True
        '
        'txtEmail
        '
        Me.txtEmail.Location = New System.Drawing.Point(136, 97)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(177, 20)
        Me.txtEmail.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(83, 100)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(32, 13)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Email"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Digit Pin"
        '
        'txtDigit
        '
        Me.txtDigit.Location = New System.Drawing.Point(136, 121)
        Me.txtDigit.Name = "txtDigit"
        Me.txtDigit.Size = New System.Drawing.Size(59, 20)
        Me.txtDigit.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(130, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(165, 32)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "FORGOT ID"
        '
      
        '
        'lblPin
        '
        Me.lblPin.AutoSize = True
        Me.lblPin.Location = New System.Drawing.Point(44, 154)
        Me.lblPin.Name = "lblPin"
        Me.lblPin.Size = New System.Drawing.Size(85, 13)
        Me.lblPin.TabIndex = 11
        Me.lblPin.Text = "Membership Pin:"
        '
        'ForgotID
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(376, 250)
        Me.Controls.Add(Me.lblPin)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.txtDigit)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnForgotPass)
        Me.Controls.Add(Me.txtEmail)
        Me.Name = "ForgotID"
        Me.Text = "ForgotID"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnForgotPass As System.Windows.Forms.Button
    Friend WithEvents txtEmail As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtDigit As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblPin As System.Windows.Forms.Label
End Class
