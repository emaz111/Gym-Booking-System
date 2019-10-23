<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class BookingsMember
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
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.PictureBox6 = New System.Windows.Forms.PictureBox()
        Me.PictureBox7 = New System.Windows.Forms.PictureBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnSlctJon = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(98, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 32)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "MANAGE BOOKINGS"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Jon Snow Monday 12:00-13:00"})
        Me.ListBox1.Location = New System.Drawing.Point(43, 72)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(311, 95)
        Me.ListBox1.TabIndex = 20
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(43, 173)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(98, 31)
        Me.btnCancel.TabIndex = 21
        Me.btnCancel.Text = "Cancel Booking"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'PictureBox6
        '
        Me.PictureBox6.BackColor = System.Drawing.Color.Black
        Me.PictureBox6.Location = New System.Drawing.Point(-9, 45)
        Me.PictureBox6.Name = "PictureBox6"
        Me.PictureBox6.Size = New System.Drawing.Size(620, 5)
        Me.PictureBox6.TabIndex = 47
        Me.PictureBox6.TabStop = False
        '
        'PictureBox7
        '
        Me.PictureBox7.Image = Global.Prototype.My.Resources.Resources.PuregymLogo
        Me.PictureBox7.Location = New System.Drawing.Point(-9, -14)
        Me.PictureBox7.Name = "PictureBox7"
        Me.PictureBox7.Size = New System.Drawing.Size(101, 69)
        Me.PictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox7.TabIndex = 48
        Me.PictureBox7.TabStop = False
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(-9, -12)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 23)
        Me.Label6.TabIndex = 38
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(-9, -12)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(75, 23)
        Me.Button4.TabIndex = 39
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(-9, -12)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(100, 23)
        Me.Label5.TabIndex = 40
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(-9, -12)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(-9, -12)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(100, 23)
        Me.Label4.TabIndex = 43
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(-9, -12)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 44
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(-9, -12)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(100, 23)
        Me.Label3.TabIndex = 45
        '
        'btnSlctJon
        '
        Me.btnSlctJon.Location = New System.Drawing.Point(-9, -12)
        Me.btnSlctJon.Name = "btnSlctJon"
        Me.btnSlctJon.Size = New System.Drawing.Size(75, 23)
        Me.btnSlctJon.TabIndex = 46
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(395, 8)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 31)
        Me.Button5.TabIndex = 37
        Me.Button5.Text = "Main Menu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'BookingsMember
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(506, 262)
        Me.Controls.Add(Me.PictureBox6)
        Me.Controls.Add(Me.PictureBox7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnSlctJon)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "BookingsMember"
        Me.Text = "BookingsMember"
        CType(Me.PictureBox6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox7, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents btnCancel As System.Windows.Forms.Button
    Friend WithEvents PictureBox6 As PictureBox
    Friend WithEvents PictureBox7 As PictureBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents Button3 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Button2 As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents btnSlctJon As Button
    Friend WithEvents Button5 As Button
End Class
