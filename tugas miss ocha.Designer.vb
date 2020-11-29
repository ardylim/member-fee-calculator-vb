<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.type = New System.Windows.Forms.GroupBox()
        Me.senior = New System.Windows.Forms.RadioButton()
        Me.student = New System.Windows.Forms.RadioButton()
        Me.child = New System.Windows.Forms.RadioButton()
        Me.adult = New System.Windows.Forms.RadioButton()
        Me.options = New System.Windows.Forms.GroupBox()
        Me.personalTrainer = New System.Windows.Forms.CheckBox()
        Me.karate = New System.Windows.Forms.CheckBox()
        Me.yoga = New System.Windows.Forms.CheckBox()
        Me.length = New System.Windows.Forms.GroupBox()
        Me.month = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fee = New System.Windows.Forms.GroupBox()
        Me.result = New System.Windows.Forms.Label()
        Me.monthlyfee = New System.Windows.Forms.Label()
        Me.Total = New System.Windows.Forms.Label()
        Me.monthly = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.type.SuspendLayout()
        Me.options.SuspendLayout()
        Me.length.SuspendLayout()
        Me.fee.SuspendLayout()
        Me.SuspendLayout()
        '
        'type
        '
        Me.type.Controls.Add(Me.senior)
        Me.type.Controls.Add(Me.student)
        Me.type.Controls.Add(Me.child)
        Me.type.Controls.Add(Me.adult)
        Me.type.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.type.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.type.Location = New System.Drawing.Point(23, 11)
        Me.type.Margin = New System.Windows.Forms.Padding(2)
        Me.type.Name = "type"
        Me.type.Padding = New System.Windows.Forms.Padding(2)
        Me.type.Size = New System.Drawing.Size(228, 128)
        Me.type.TabIndex = 0
        Me.type.TabStop = False
        Me.type.Text = "Type of Membership"
        '
        'senior
        '
        Me.senior.AutoSize = True
        Me.senior.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.senior.Location = New System.Drawing.Point(11, 99)
        Me.senior.Margin = New System.Windows.Forms.Padding(2)
        Me.senior.Name = "senior"
        Me.senior.Size = New System.Drawing.Size(120, 25)
        Me.senior.TabIndex = 5
        Me.senior.TabStop = True
        Me.senior.Text = "Se&nior Citizen"
        Me.senior.UseVisualStyleBackColor = True
        '
        'student
        '
        Me.student.AutoSize = True
        Me.student.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.student.Location = New System.Drawing.Point(11, 75)
        Me.student.Margin = New System.Windows.Forms.Padding(2)
        Me.student.Name = "student"
        Me.student.Size = New System.Drawing.Size(80, 25)
        Me.student.TabIndex = 4
        Me.student.TabStop = True
        Me.student.Text = "&Student"
        Me.student.UseVisualStyleBackColor = True
        '
        'child
        '
        Me.child.AutoSize = True
        Me.child.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.child.Location = New System.Drawing.Point(10, 49)
        Me.child.Margin = New System.Windows.Forms.Padding(2)
        Me.child.Name = "child"
        Me.child.Size = New System.Drawing.Size(159, 25)
        Me.child.TabIndex = 3
        Me.child.TabStop = True
        Me.child.Text = "Child& (12 && Under)"
        Me.child.UseVisualStyleBackColor = True
        '
        'adult
        '
        Me.adult.AutoSize = True
        Me.adult.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.adult.Location = New System.Drawing.Point(10, 26)
        Me.adult.Margin = New System.Windows.Forms.Padding(2)
        Me.adult.Name = "adult"
        Me.adult.Size = New System.Drawing.Size(130, 25)
        Me.adult.TabIndex = 2
        Me.adult.TabStop = True
        Me.adult.Text = "Standard A&dult"
        Me.adult.UseVisualStyleBackColor = True
        '
        'options
        '
        Me.options.Controls.Add(Me.personalTrainer)
        Me.options.Controls.Add(Me.karate)
        Me.options.Controls.Add(Me.yoga)
        Me.options.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.options.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.options.Location = New System.Drawing.Point(255, 11)
        Me.options.Margin = New System.Windows.Forms.Padding(2)
        Me.options.Name = "options"
        Me.options.Padding = New System.Windows.Forms.Padding(2)
        Me.options.Size = New System.Drawing.Size(201, 128)
        Me.options.TabIndex = 1
        Me.options.TabStop = False
        Me.options.Text = "Options"
        '
        'personalTrainer
        '
        Me.personalTrainer.AutoSize = True
        Me.personalTrainer.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.personalTrainer.Location = New System.Drawing.Point(19, 74)
        Me.personalTrainer.Margin = New System.Windows.Forms.Padding(2)
        Me.personalTrainer.Name = "personalTrainer"
        Me.personalTrainer.Size = New System.Drawing.Size(138, 25)
        Me.personalTrainer.TabIndex = 2
        Me.personalTrainer.Text = "&Personal Trainer"
        Me.personalTrainer.UseVisualStyleBackColor = True
        '
        'karate
        '
        Me.karate.AutoSize = True
        Me.karate.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.karate.Location = New System.Drawing.Point(19, 49)
        Me.karate.Margin = New System.Windows.Forms.Padding(2)
        Me.karate.Name = "karate"
        Me.karate.Size = New System.Drawing.Size(73, 25)
        Me.karate.TabIndex = 1
        Me.karate.Text = "&Karate"
        Me.karate.UseVisualStyleBackColor = True
        '
        'yoga
        '
        Me.yoga.AutoSize = True
        Me.yoga.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.yoga.Location = New System.Drawing.Point(19, 27)
        Me.yoga.Margin = New System.Windows.Forms.Padding(2)
        Me.yoga.Name = "yoga"
        Me.yoga.Size = New System.Drawing.Size(61, 25)
        Me.yoga.TabIndex = 0
        Me.yoga.Text = "&Yoga"
        Me.yoga.UseVisualStyleBackColor = True
        '
        'length
        '
        Me.length.Controls.Add(Me.month)
        Me.length.Controls.Add(Me.Label1)
        Me.length.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.length.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.length.Location = New System.Drawing.Point(23, 143)
        Me.length.Margin = New System.Windows.Forms.Padding(2)
        Me.length.Name = "length"
        Me.length.Padding = New System.Windows.Forms.Padding(2)
        Me.length.Size = New System.Drawing.Size(228, 115)
        Me.length.TabIndex = 2
        Me.length.TabStop = False
        Me.length.Text = "Membership Length"
        '
        'month
        '
        Me.month.BackColor = System.Drawing.SystemColors.InactiveCaption
        Me.month.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.month.Location = New System.Drawing.Point(60, 65)
        Me.month.Margin = New System.Windows.Forms.Padding(2)
        Me.month.Multiline = True
        Me.month.Name = "month"
        Me.month.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.month.Size = New System.Drawing.Size(89, 37)
        Me.month.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(7, 33)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(202, 21)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Enter The number of M&onth:"
        '
        'fee
        '
        Me.fee.Controls.Add(Me.result)
        Me.fee.Controls.Add(Me.monthlyfee)
        Me.fee.Controls.Add(Me.Total)
        Me.fee.Controls.Add(Me.monthly)
        Me.fee.Font = New System.Drawing.Font("Goudy Old Style", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.fee.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.fee.Location = New System.Drawing.Point(255, 143)
        Me.fee.Margin = New System.Windows.Forms.Padding(2)
        Me.fee.Name = "fee"
        Me.fee.Padding = New System.Windows.Forms.Padding(2)
        Me.fee.Size = New System.Drawing.Size(201, 115)
        Me.fee.TabIndex = 3
        Me.fee.TabStop = False
        Me.fee.Text = "Membership Fee"
        '
        'result
        '
        Me.result.AutoSize = True
        Me.result.Location = New System.Drawing.Point(117, 60)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(30, 23)
        Me.result.TabIndex = 5
        Me.result.Text = "...."
        '
        'monthlyfee
        '
        Me.monthlyfee.AutoSize = True
        Me.monthlyfee.Location = New System.Drawing.Point(117, 37)
        Me.monthlyfee.Name = "monthlyfee"
        Me.monthlyfee.Size = New System.Drawing.Size(30, 23)
        Me.monthlyfee.TabIndex = 4
        Me.monthlyfee.Text = "...."
        '
        'Total
        '
        Me.Total.AutoSize = True
        Me.Total.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Total.Location = New System.Drawing.Point(14, 65)
        Me.Total.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Total.Name = "Total"
        Me.Total.Size = New System.Drawing.Size(44, 21)
        Me.Total.TabIndex = 1
        Me.Total.Text = "Total"
        '
        'monthly
        '
        Me.monthly.AutoSize = True
        Me.monthly.Font = New System.Drawing.Font("Goudy Old Style", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.monthly.Location = New System.Drawing.Point(14, 39)
        Me.monthly.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.monthly.Name = "monthly"
        Me.monthly.Size = New System.Drawing.Size(93, 21)
        Me.monthly.TabIndex = 0
        Me.monthly.Text = "Monthly Fee"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button1.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Location = New System.Drawing.Point(23, 264)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(149, 54)
        Me.Button1.TabIndex = 4
        Me.Button1.Text = "&Calculate"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button2.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(169, 264)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(160, 54)
        Me.Button2.TabIndex = 5
        Me.Button2.Text = "Clear& "
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.Button3.Font = New System.Drawing.Font("Perpetua Titling MT", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.ForeColor = System.Drawing.Color.White
        Me.Button3.Location = New System.Drawing.Point(317, 264)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(139, 54)
        Me.Button3.TabIndex = 6
        Me.Button3.Text = "Ex&it"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DodgerBlue
        Me.ClientSize = New System.Drawing.Size(471, 323)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.fee)
        Me.Controls.Add(Me.length)
        Me.Controls.Add(Me.options)
        Me.Controls.Add(Me.type)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.Text = "Member Fee Calculator"
        Me.type.ResumeLayout(False)
        Me.type.PerformLayout()
        Me.options.ResumeLayout(False)
        Me.options.PerformLayout()
        Me.length.ResumeLayout(False)
        Me.length.PerformLayout()
        Me.fee.ResumeLayout(False)
        Me.fee.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents type As System.Windows.Forms.GroupBox
    Friend WithEvents options As System.Windows.Forms.GroupBox
    Friend WithEvents length As System.Windows.Forms.GroupBox
    Friend WithEvents fee As System.Windows.Forms.GroupBox
    Friend WithEvents senior As System.Windows.Forms.RadioButton
    Friend WithEvents student As System.Windows.Forms.RadioButton
    Friend WithEvents child As System.Windows.Forms.RadioButton
    Friend WithEvents adult As System.Windows.Forms.RadioButton
    Friend WithEvents personalTrainer As System.Windows.Forms.CheckBox
    Friend WithEvents karate As System.Windows.Forms.CheckBox
    Friend WithEvents yoga As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents month As System.Windows.Forms.TextBox
    Friend WithEvents Total As System.Windows.Forms.Label
    Friend WithEvents monthly As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents result As System.Windows.Forms.Label
    Friend WithEvents monthlyfee As System.Windows.Forms.Label

End Class
