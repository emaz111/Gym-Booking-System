<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class intructorBookings
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.cboDay = New System.Windows.Forms.ComboBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.cboTime = New System.Windows.Forms.ComboBox()
        Me.ListBox2 = New System.Windows.Forms.ListBox()
        Me.ListBox3 = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.Button5 = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(121, 174)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(54, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Jon Snow"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Rounded MT Bold", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(102, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(146, 32)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "BOOKING"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(30, 467)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(78, 37)
        Me.btnSave.TabIndex = 22
        Me.btnSave.Text = "Save"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'cboDay
        '
        Me.cboDay.FormattingEnabled = True
        Me.cboDay.Items.AddRange(New Object() {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"})
        Me.cboDay.Location = New System.Drawing.Point(30, 422)
        Me.cboDay.Name = "cboDay"
        Me.cboDay.Size = New System.Drawing.Size(121, 21)
        Me.cboDay.TabIndex = 23
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Items.AddRange(New Object() {"Whether you want to lose weight, tone up,", " build muscle, burn fat or just maintain", " a healthy active lifestyle - I can help!"})
        Me.ListBox1.Location = New System.Drawing.Point(30, 214)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(252, 82)
        Me.ListBox1.TabIndex = 24
        '
        'cboTime
        '
        Me.cboTime.FormattingEnabled = True
        Me.cboTime.Items.AddRange(New Object() {"12:00-13:00", "13:00-14:00", "15:00-16:00", "17:00-18:00", "19:00-20:00"})
        Me.cboTime.Location = New System.Drawing.Point(157, 422)
        Me.cboTime.Name = "cboTime"
        Me.cboTime.Size = New System.Drawing.Size(121, 21)
        Me.cboTime.TabIndex = 25
        '
        'ListBox2
        '
        Me.ListBox2.FormattingEnabled = True
        Me.ListBox2.Items.AddRange(New Object() {"Exercise for Health & Fitness FdSc", "Level 3 Personal Trainer", "Level 2 Fitness Instructor", "Boxercise", "First Aid at Work"})
        Me.ListBox2.Location = New System.Drawing.Point(30, 324)
        Me.ListBox2.Name = "ListBox2"
        Me.ListBox2.Size = New System.Drawing.Size(123, 82)
        Me.ListBox2.TabIndex = 26
        '
        'ListBox3
        '
        Me.ListBox3.FormattingEnabled = True
        Me.ListBox3.Items.AddRange(New Object() {"Nutritional guidance", "Special populations", "Sport specific training", "Weight loss"})
        Me.ListBox3.Location = New System.Drawing.Point(159, 324)
        Me.ListBox3.Name = "ListBox3"
        Me.ListBox3.Size = New System.Drawing.Size(123, 82)
        Me.ListBox3.TabIndex = 27
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 198)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(54, 13)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "Biography"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 308)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(65, 13)
        Me.Label4.TabIndex = 29
        Me.Label4.Text = "Qualification"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(156, 308)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 13)
        Me.Label5.TabIndex = 30
        Me.Label5.Text = "Specialist Area"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Prototype.My.Resources.Resources.user1
        Me.PictureBox1.Location = New System.Drawing.Point(108, 84)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(80, 87)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 31
        Me.PictureBox1.TabStop = False
        '
        'PictureBox2
        '
        Me.PictureBox2.BackColor = System.Drawing.Color.Black
        Me.PictureBox2.Location = New System.Drawing.Point(-9, 45)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(420, 5)
        Me.PictureBox2.TabIndex = 32
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = Global.Prototype.My.Resources.Resources.PuregymLogo
        Me.PictureBox3.Location = New System.Drawing.Point(-9, -14)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(101, 69)
        Me.PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox3.TabIndex = 33
        Me.PictureBox3.TabStop = False
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(249, 9)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(98, 31)
        Me.Button5.TabIndex = 38
        Me.Button5.Text = "Main Menu"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'intructorBookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(359, 516)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.ListBox3)
        Me.Controls.Add(Me.ListBox2)
        Me.Controls.Add(Me.cboTime)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.cboDay)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "intructorBookings"
        Me.Text = "intructorBookings"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSave As System.Windows.Forms.Button
    Friend WithEvents cboDay As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents cboTime As System.Windows.Forms.ComboBox
    Friend WithEvents ListBox2 As System.Windows.Forms.ListBox
    Friend WithEvents ListBox3 As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents Button5 As Button
End Class
