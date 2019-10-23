<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.txtLogin = New System.Windows.Forms.TextBox()
        Me.btnForgotPass = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDebug = New System.Windows.Forms.Button()
        Me.chkInstructor = New System.Windows.Forms.CheckBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnLogin
        '
        Me.btnLogin.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.Location = New System.Drawing.Point(85, 187)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(72, 33)
        Me.btnLogin.TabIndex = 0
        Me.btnLogin.Text = "Login"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'txtLogin
        '
        Me.txtLogin.Location = New System.Drawing.Point(85, 152)
        Me.txtLogin.Name = "txtLogin"
        Me.txtLogin.Size = New System.Drawing.Size(177, 20)
        Me.txtLogin.TabIndex = 1
        '
        'btnForgotPass
        '
        Me.btnForgotPass.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnForgotPass.Location = New System.Drawing.Point(163, 187)
        Me.btnForgotPass.Name = "btnForgotPass"
        Me.btnForgotPass.Size = New System.Drawing.Size(99, 33)
        Me.btnForgotPass.TabIndex = 2
        Me.btnForgotPass.Text = "Forgot ID"
        Me.btnForgotPass.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(145, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(102, 32)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "LOGIN"
        '
        'btnDebug
        '
        Me.btnDebug.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnDebug.Location = New System.Drawing.Point(301, 187)
        Me.btnDebug.Name = "btnDebug"
        Me.btnDebug.Size = New System.Drawing.Size(93, 33)
        Me.btnDebug.TabIndex = 16
        Me.btnDebug.Text = "DEBUG"
        Me.btnDebug.UseVisualStyleBackColor = True
        '
        'chkInstructor
        '
        Me.chkInstructor.AutoSize = True
        Me.chkInstructor.Location = New System.Drawing.Point(87, 112)
        Me.chkInstructor.Name = "chkInstructor"
        Me.chkInstructor.Size = New System.Drawing.Size(70, 17)
        Me.chkInstructor.TabIndex = 17
        Me.chkInstructor.Text = "Instructor"
        Me.chkInstructor.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Black
        Me.PictureBox1.Location = New System.Drawing.Point(-2, 44)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(420, 5)
        Me.PictureBox1.TabIndex = 18
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.Prototype.My.Resources.Resources.PuregymLogo
        Me.PictureBox2.Location = New System.Drawing.Point(-2, -15)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(101, 69)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 19
        Me.PictureBox2.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(406, 262)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.chkInstructor)
        Me.Controls.Add(Me.btnDebug)
        Me.Controls.Add(Me.btnForgotPass)
        Me.Controls.Add(Me.txtLogin)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.PictureBox2)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnLogin As System.Windows.Forms.Button
    Friend WithEvents txtLogin As System.Windows.Forms.TextBox
    Friend WithEvents btnForgotPass As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDebug As System.Windows.Forms.Button
    Friend WithEvents chkInstructor As System.Windows.Forms.CheckBox
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox

End Class
