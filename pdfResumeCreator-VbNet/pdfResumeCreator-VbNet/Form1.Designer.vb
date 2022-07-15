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
        Me.loadJsonButton = New System.Windows.Forms.Button()
        Me.reset = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.fullNameLabel = New System.Windows.Forms.Label()
        Me.fNameLabel = New System.Windows.Forms.Label()
        Me.lNameLabel = New System.Windows.Forms.Label()
        Me.addressLabel = New System.Windows.Forms.Label()
        Me.cpnLabel = New System.Windows.Forms.Label()
        Me.llnLabel = New System.Windows.Forms.Label()
        Me.emailaLabel = New System.Windows.Forms.Label()
        Me.fName = New System.Windows.Forms.TextBox()
        Me.lName = New System.Windows.Forms.TextBox()
        Me.address = New System.Windows.Forms.TextBox()
        Me.cpNumber = New System.Windows.Forms.TextBox()
        Me.llNumber = New System.Windows.Forms.TextBox()
        Me.emailAddress = New System.Windows.Forms.TextBox()
        Me.fullName = New System.Windows.Forms.Label()
        Me.educTitleLabel = New System.Windows.Forms.Label()
        Me.highSchoolTitleLabel = New System.Windows.Forms.Label()
        Me.hsName = New System.Windows.Forms.TextBox()
        Me.yrhsEnd = New System.Windows.Forms.Label()
        Me.collegeTitleLabel = New System.Windows.Forms.Label()
        Me.hsLabel = New System.Windows.Forms.Label()
        Me.skillLabel = New System.Windows.Forms.Label()
        Me.courseLabel = New System.Windows.Forms.Label()
        Me.clgName = New System.Windows.Forms.Label()
        Me.skills = New System.Windows.Forms.TextBox()
        Me.course = New System.Windows.Forms.TextBox()
        Me.clgUnivName = New System.Windows.Forms.TextBox()
        Me.yrClgGraduatedLabel = New System.Windows.Forms.Label()
        Me.yGHS = New System.Windows.Forms.TextBox()
        Me.yearClgGraduated = New System.Windows.Forms.TextBox()
        Me.workingExperienceLabel = New System.Windows.Forms.Label()
        Me.workExperience = New System.Windows.Forms.DataGridView()
        Me.summaryLabeel = New System.Windows.Forms.Label()
        Me.summary = New System.Windows.Forms.TextBox()
        Me.GenerateJSON = New System.Windows.Forms.Button()
        Me.pdfButton = New System.Windows.Forms.Button()
        Me.requiredWorkExperience = New System.Windows.Forms.Label()
        Me.update = New System.Windows.Forms.Label()
        CType(Me.workExperience, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'loadJsonButton
        '
        Me.loadJsonButton.BackColor = System.Drawing.Color.Plum
        Me.loadJsonButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.loadJsonButton.Location = New System.Drawing.Point(876, 523)
        Me.loadJsonButton.Name = "loadJsonButton"
        Me.loadJsonButton.Size = New System.Drawing.Size(200, 31)
        Me.loadJsonButton.TabIndex = 0
        Me.loadJsonButton.Text = "Load JSON"
        Me.loadJsonButton.UseVisualStyleBackColor = False
        '
        'reset
        '
        Me.reset.BackColor = System.Drawing.Color.Plum
        Me.reset.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.reset.Location = New System.Drawing.Point(876, 560)
        Me.reset.Name = "reset"
        Me.reset.Size = New System.Drawing.Size(200, 31)
        Me.reset.TabIndex = 1
        Me.reset.Text = "Reset"
        Me.reset.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.Label1.Font = New System.Drawing.Font("Bookman Old Style", 15.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.Location = New System.Drawing.Point(206, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(286, 24)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "PERSONAL INFORMATION"
        '
        'fullNameLabel
        '
        Me.fullNameLabel.AutoSize = True
        Me.fullNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.fullNameLabel.Location = New System.Drawing.Point(29, 93)
        Me.fullNameLabel.Name = "fullNameLabel"
        Me.fullNameLabel.Size = New System.Drawing.Size(93, 19)
        Me.fullNameLabel.TabIndex = 3
        Me.fullNameLabel.Text = "Full Name:"
        '
        'fNameLabel
        '
        Me.fNameLabel.AutoSize = True
        Me.fNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.fNameLabel.Location = New System.Drawing.Point(48, 131)
        Me.fNameLabel.Name = "fNameLabel"
        Me.fNameLabel.Size = New System.Drawing.Size(80, 19)
        Me.fNameLabel.TabIndex = 4
        Me.fNameLabel.Text = "First Name:"
        '
        'lNameLabel
        '
        Me.lNameLabel.AutoSize = True
        Me.lNameLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lNameLabel.Location = New System.Drawing.Point(48, 169)
        Me.lNameLabel.Name = "lNameLabel"
        Me.lNameLabel.Size = New System.Drawing.Size(79, 19)
        Me.lNameLabel.TabIndex = 5
        Me.lNameLabel.Text = "Last Name:"
        '
        'addressLabel
        '
        Me.addressLabel.AutoSize = True
        Me.addressLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.addressLabel.Location = New System.Drawing.Point(48, 204)
        Me.addressLabel.Name = "addressLabel"
        Me.addressLabel.Size = New System.Drawing.Size(88, 19)
        Me.addressLabel.TabIndex = 6
        Me.addressLabel.Text = "Full Address:"
        '
        'cpnLabel
        '
        Me.cpnLabel.AutoSize = True
        Me.cpnLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.cpnLabel.Location = New System.Drawing.Point(48, 239)
        Me.cpnLabel.Name = "cpnLabel"
        Me.cpnLabel.Size = New System.Drawing.Size(114, 19)
        Me.cpnLabel.TabIndex = 7
        Me.cpnLabel.Text = "Contact Number:"
        '
        'llnLabel
        '
        Me.llnLabel.AutoSize = True
        Me.llnLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.llnLabel.Location = New System.Drawing.Point(48, 273)
        Me.llnLabel.Name = "llnLabel"
        Me.llnLabel.Size = New System.Drawing.Size(67, 19)
        Me.llnLabel.TabIndex = 8
        Me.llnLabel.Text = "Landline :"
        '
        'emailaLabel
        '
        Me.emailaLabel.AutoSize = True
        Me.emailaLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.emailaLabel.Location = New System.Drawing.Point(48, 308)
        Me.emailaLabel.Name = "emailaLabel"
        Me.emailaLabel.Size = New System.Drawing.Size(99, 19)
        Me.emailaLabel.TabIndex = 9
        Me.emailaLabel.Text = "Email Address:"
        '
        'fName
        '
        Me.fName.BackColor = System.Drawing.Color.LavenderBlush
        Me.fName.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.fName.Location = New System.Drawing.Point(174, 128)
        Me.fName.Name = "fName"
        Me.fName.Size = New System.Drawing.Size(547, 26)
        Me.fName.TabIndex = 10
        '
        'lName
        '
        Me.lName.BackColor = System.Drawing.Color.LavenderBlush
        Me.lName.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.lName.Location = New System.Drawing.Point(174, 162)
        Me.lName.Name = "lName"
        Me.lName.Size = New System.Drawing.Size(547, 26)
        Me.lName.TabIndex = 11
        '
        'address
        '
        Me.address.BackColor = System.Drawing.Color.LavenderBlush
        Me.address.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.address.Location = New System.Drawing.Point(174, 197)
        Me.address.Name = "address"
        Me.address.Size = New System.Drawing.Size(547, 26)
        Me.address.TabIndex = 12
        '
        'cpNumber
        '
        Me.cpNumber.BackColor = System.Drawing.Color.LavenderBlush
        Me.cpNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.cpNumber.Location = New System.Drawing.Point(174, 231)
        Me.cpNumber.Name = "cpNumber"
        Me.cpNumber.Size = New System.Drawing.Size(547, 26)
        Me.cpNumber.TabIndex = 13
        '
        'llNumber
        '
        Me.llNumber.BackColor = System.Drawing.Color.LavenderBlush
        Me.llNumber.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.llNumber.Location = New System.Drawing.Point(174, 266)
        Me.llNumber.Name = "llNumber"
        Me.llNumber.Size = New System.Drawing.Size(547, 26)
        Me.llNumber.TabIndex = 14
        '
        'emailAddress
        '
        Me.emailAddress.BackColor = System.Drawing.Color.LavenderBlush
        Me.emailAddress.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.emailAddress.Location = New System.Drawing.Point(174, 301)
        Me.emailAddress.Name = "emailAddress"
        Me.emailAddress.Size = New System.Drawing.Size(547, 26)
        Me.emailAddress.TabIndex = 15
        '
        'fullName
        '
        Me.fullName.AutoSize = True
        Me.fullName.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.fullName.Location = New System.Drawing.Point(170, 93)
        Me.fullName.Name = "fullName"
        Me.fullName.Size = New System.Drawing.Size(0, 19)
        Me.fullName.TabIndex = 16
        '
        'educTitleLabel
        '
        Me.educTitleLabel.AutoSize = True
        Me.educTitleLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.educTitleLabel.Font = New System.Drawing.Font("Bookman Old Style", 15.0!, System.Drawing.FontStyle.Bold)
        Me.educTitleLabel.Location = New System.Drawing.Point(206, 361)
        Me.educTitleLabel.Name = "educTitleLabel"
        Me.educTitleLabel.Size = New System.Drawing.Size(313, 24)
        Me.educTitleLabel.TabIndex = 17
        Me.educTitleLabel.Text = "EDUCATIONAL ATTAINMENT"
        '
        'highSchoolTitleLabel
        '
        Me.highSchoolTitleLabel.AutoSize = True
        Me.highSchoolTitleLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.highSchoolTitleLabel.Location = New System.Drawing.Point(29, 400)
        Me.highSchoolTitleLabel.Name = "highSchoolTitleLabel"
        Me.highSchoolTitleLabel.Size = New System.Drawing.Size(100, 19)
        Me.highSchoolTitleLabel.TabIndex = 18
        Me.highSchoolTitleLabel.Text = "High School"
        '
        'hsName
        '
        Me.hsName.BackColor = System.Drawing.Color.LavenderBlush
        Me.hsName.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.hsName.Location = New System.Drawing.Point(149, 421)
        Me.hsName.Name = "hsName"
        Me.hsName.Size = New System.Drawing.Size(370, 26)
        Me.hsName.TabIndex = 20
        '
        'yrhsEnd
        '
        Me.yrhsEnd.AutoSize = True
        Me.yrhsEnd.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.yrhsEnd.Location = New System.Drawing.Point(525, 424)
        Me.yrhsEnd.Name = "yrhsEnd"
        Me.yrhsEnd.Size = New System.Drawing.Size(96, 19)
        Me.yrhsEnd.TabIndex = 21
        Me.yrhsEnd.Text = "Yr Graduated:"
        '
        'collegeTitleLabel
        '
        Me.collegeTitleLabel.AutoSize = True
        Me.collegeTitleLabel.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.collegeTitleLabel.Location = New System.Drawing.Point(29, 461)
        Me.collegeTitleLabel.Name = "collegeTitleLabel"
        Me.collegeTitleLabel.Size = New System.Drawing.Size(69, 19)
        Me.collegeTitleLabel.TabIndex = 23
        Me.collegeTitleLabel.Text = "Tertiary"
        '
        'hsLabel
        '
        Me.hsLabel.AutoSize = True
        Me.hsLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.hsLabel.Location = New System.Drawing.Point(48, 428)
        Me.hsLabel.Name = "hsLabel"
        Me.hsLabel.Size = New System.Drawing.Size(95, 19)
        Me.hsLabel.TabIndex = 19
        Me.hsLabel.Text = "School Name:"
        '
        'skillLabel
        '
        Me.skillLabel.AutoSize = True
        Me.skillLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.skillLabel.Location = New System.Drawing.Point(48, 564)
        Me.skillLabel.Name = "skillLabel"
        Me.skillLabel.Size = New System.Drawing.Size(44, 19)
        Me.skillLabel.TabIndex = 26
        Me.skillLabel.Text = "Skills:"
        '
        'courseLabel
        '
        Me.courseLabel.AutoSize = True
        Me.courseLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.courseLabel.Location = New System.Drawing.Point(48, 529)
        Me.courseLabel.Name = "courseLabel"
        Me.courseLabel.Size = New System.Drawing.Size(56, 19)
        Me.courseLabel.TabIndex = 25
        Me.courseLabel.Text = "Course:"
        '
        'clgName
        '
        Me.clgName.AutoSize = True
        Me.clgName.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.clgName.Location = New System.Drawing.Point(48, 495)
        Me.clgName.Name = "clgName"
        Me.clgName.Size = New System.Drawing.Size(99, 19)
        Me.clgName.TabIndex = 24
        Me.clgName.Text = "College Name:"
        '
        'skills
        '
        Me.skills.BackColor = System.Drawing.Color.LavenderBlush
        Me.skills.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.skills.Location = New System.Drawing.Point(149, 558)
        Me.skills.Name = "skills"
        Me.skills.Size = New System.Drawing.Size(370, 26)
        Me.skills.TabIndex = 29
        '
        'course
        '
        Me.course.BackColor = System.Drawing.Color.LavenderBlush
        Me.course.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.course.Location = New System.Drawing.Point(149, 523)
        Me.course.Name = "course"
        Me.course.Size = New System.Drawing.Size(370, 26)
        Me.course.TabIndex = 28
        '
        'clgUnivName
        '
        Me.clgUnivName.BackColor = System.Drawing.Color.LavenderBlush
        Me.clgUnivName.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.clgUnivName.Location = New System.Drawing.Point(149, 488)
        Me.clgUnivName.Name = "clgUnivName"
        Me.clgUnivName.Size = New System.Drawing.Size(370, 26)
        Me.clgUnivName.TabIndex = 27
        '
        'yrClgGraduatedLabel
        '
        Me.yrClgGraduatedLabel.AutoSize = True
        Me.yrClgGraduatedLabel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.yrClgGraduatedLabel.Location = New System.Drawing.Point(525, 495)
        Me.yrClgGraduatedLabel.Name = "yrClgGraduatedLabel"
        Me.yrClgGraduatedLabel.Size = New System.Drawing.Size(96, 19)
        Me.yrClgGraduatedLabel.TabIndex = 30
        Me.yrClgGraduatedLabel.Text = "Yr Graduated:"
        '
        'yGHS
        '
        Me.yGHS.BackColor = System.Drawing.Color.LavenderBlush
        Me.yGHS.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.yGHS.Location = New System.Drawing.Point(627, 417)
        Me.yGHS.Name = "yGHS"
        Me.yGHS.Size = New System.Drawing.Size(94, 26)
        Me.yGHS.TabIndex = 22
        '
        'yearClgGraduated
        '
        Me.yearClgGraduated.BackColor = System.Drawing.Color.LavenderBlush
        Me.yearClgGraduated.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.yearClgGraduated.Location = New System.Drawing.Point(627, 488)
        Me.yearClgGraduated.Name = "yearClgGraduated"
        Me.yearClgGraduated.Size = New System.Drawing.Size(94, 26)
        Me.yearClgGraduated.TabIndex = 31
        '
        'workingExperienceLabel
        '
        Me.workingExperienceLabel.AutoSize = True
        Me.workingExperienceLabel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.workingExperienceLabel.Font = New System.Drawing.Font("Bookman Old Style", 15.0!, System.Drawing.FontStyle.Bold)
        Me.workingExperienceLabel.Location = New System.Drawing.Point(872, 51)
        Me.workingExperienceLabel.Name = "workingExperienceLabel"
        Me.workingExperienceLabel.Size = New System.Drawing.Size(267, 24)
        Me.workingExperienceLabel.TabIndex = 32
        Me.workingExperienceLabel.Text = "WORKING EXPERIENCE"
        '
        'workExperience
        '
        Me.workExperience.BackgroundColor = System.Drawing.Color.LavenderBlush
        Me.workExperience.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.workExperience.Location = New System.Drawing.Point(761, 78)
        Me.workExperience.Name = "workExperience"
        Me.workExperience.Size = New System.Drawing.Size(522, 249)
        Me.workExperience.TabIndex = 33
        '
        'summaryLabeel
        '
        Me.summaryLabeel.AutoSize = True
        Me.summaryLabeel.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.summaryLabeel.Location = New System.Drawing.Point(768, 400)
        Me.summaryLabeel.Name = "summaryLabeel"
        Me.summaryLabeel.Size = New System.Drawing.Size(69, 19)
        Me.summaryLabeel.TabIndex = 34
        Me.summaryLabeel.Text = "Summary:"
        '
        'summary
        '
        Me.summary.AcceptsReturn = True
        Me.summary.BackColor = System.Drawing.Color.LavenderBlush
        Me.summary.Font = New System.Drawing.Font("Times New Roman", 12.0!)
        Me.summary.Location = New System.Drawing.Point(843, 400)
        Me.summary.Multiline = True
        Me.summary.Name = "summary"
        Me.summary.Size = New System.Drawing.Size(440, 114)
        Me.summary.TabIndex = 35
        '
        'GenerateJSON
        '
        Me.GenerateJSON.BackColor = System.Drawing.Color.Plum
        Me.GenerateJSON.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GenerateJSON.Location = New System.Drawing.Point(1083, 560)
        Me.GenerateJSON.Name = "GenerateJSON"
        Me.GenerateJSON.Size = New System.Drawing.Size(200, 31)
        Me.GenerateJSON.TabIndex = 37
        Me.GenerateJSON.Text = "Generate JSON"
        Me.GenerateJSON.UseVisualStyleBackColor = False
        '
        'pdfButton
        '
        Me.pdfButton.BackColor = System.Drawing.Color.Plum
        Me.pdfButton.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pdfButton.Location = New System.Drawing.Point(1083, 523)
        Me.pdfButton.Name = "pdfButton"
        Me.pdfButton.Size = New System.Drawing.Size(200, 31)
        Me.pdfButton.TabIndex = 36
        Me.pdfButton.Text = "Generate PDF"
        Me.pdfButton.UseVisualStyleBackColor = False
        '
        'requiredWorkExperience
        '
        Me.requiredWorkExperience.AutoSize = True
        Me.requiredWorkExperience.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.requiredWorkExperience.ForeColor = System.Drawing.Color.Red
        Me.requiredWorkExperience.Location = New System.Drawing.Point(69, 25)
        Me.requiredWorkExperience.Name = "requiredWorkExperience"
        Me.requiredWorkExperience.Size = New System.Drawing.Size(0, 19)
        Me.requiredWorkExperience.TabIndex = 38
        '
        'update
        '
        Me.update.AutoSize = True
        Me.update.Font = New System.Drawing.Font("Times New Roman", 12.75!, System.Drawing.FontStyle.Bold)
        Me.update.ForeColor = System.Drawing.Color.Red
        Me.update.Location = New System.Drawing.Point(29, 25)
        Me.update.Name = "update"
        Me.update.Size = New System.Drawing.Size(0, 19)
        Me.update.TabIndex = 39
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Thistle
        Me.ClientSize = New System.Drawing.Size(1295, 604)
        Me.Controls.Add(Me.update)
        Me.Controls.Add(Me.requiredWorkExperience)
        Me.Controls.Add(Me.GenerateJSON)
        Me.Controls.Add(Me.pdfButton)
        Me.Controls.Add(Me.summary)
        Me.Controls.Add(Me.summaryLabeel)
        Me.Controls.Add(Me.workExperience)
        Me.Controls.Add(Me.workingExperienceLabel)
        Me.Controls.Add(Me.yearClgGraduated)
        Me.Controls.Add(Me.yrClgGraduatedLabel)
        Me.Controls.Add(Me.skills)
        Me.Controls.Add(Me.course)
        Me.Controls.Add(Me.clgUnivName)
        Me.Controls.Add(Me.skillLabel)
        Me.Controls.Add(Me.courseLabel)
        Me.Controls.Add(Me.clgName)
        Me.Controls.Add(Me.collegeTitleLabel)
        Me.Controls.Add(Me.yGHS)
        Me.Controls.Add(Me.yrhsEnd)
        Me.Controls.Add(Me.hsName)
        Me.Controls.Add(Me.hsLabel)
        Me.Controls.Add(Me.highSchoolTitleLabel)
        Me.Controls.Add(Me.educTitleLabel)
        Me.Controls.Add(Me.fullName)
        Me.Controls.Add(Me.emailAddress)
        Me.Controls.Add(Me.llNumber)
        Me.Controls.Add(Me.cpNumber)
        Me.Controls.Add(Me.address)
        Me.Controls.Add(Me.lName)
        Me.Controls.Add(Me.fName)
        Me.Controls.Add(Me.emailaLabel)
        Me.Controls.Add(Me.llnLabel)
        Me.Controls.Add(Me.cpnLabel)
        Me.Controls.Add(Me.addressLabel)
        Me.Controls.Add(Me.lNameLabel)
        Me.Controls.Add(Me.fNameLabel)
        Me.Controls.Add(Me.fullNameLabel)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.reset)
        Me.Controls.Add(Me.loadJsonButton)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.Text = "PDF Resume Creator"
        CType(Me.workExperience, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents loadJsonButton As Button
    Friend WithEvents reset As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents fullNameLabel As Label
    Friend WithEvents fNameLabel As Label
    Friend WithEvents lNameLabel As Label
    Friend WithEvents addressLabel As Label
    Friend WithEvents cpnLabel As Label
    Friend WithEvents llnLabel As Label
    Friend WithEvents emailaLabel As Label
    Friend WithEvents fName As TextBox
    Friend WithEvents lName As TextBox
    Friend WithEvents address As TextBox
    Friend WithEvents cpNumber As TextBox
    Friend WithEvents llNumber As TextBox
    Friend WithEvents emailAddress As TextBox
    Friend WithEvents fullName As Label
    Friend WithEvents educTitleLabel As Label
    Friend WithEvents highSchoolTitleLabel As Label
    Friend WithEvents hsName As TextBox
    Friend WithEvents yrhsEnd As Label
    Friend WithEvents collegeTitleLabel As Label
    Friend WithEvents hsLabel As Label
    Friend WithEvents skillLabel As Label
    Friend WithEvents courseLabel As Label
    Friend WithEvents clgName As Label
    Friend WithEvents skills As TextBox
    Friend WithEvents course As TextBox
    Friend WithEvents clgUnivName As TextBox
    Friend WithEvents yrClgGraduatedLabel As Label
    Friend WithEvents yGHS As TextBox
    Friend WithEvents yearClgGraduated As TextBox
    Friend WithEvents workingExperienceLabel As Label
    Friend WithEvents workExperience As DataGridView
    Friend WithEvents summaryLabeel As Label
    Private WithEvents summary As TextBox
    Friend WithEvents GenerateJSON As Button
    Friend WithEvents pdfButton As Button
    Friend WithEvents requiredWorkExperience As Label
    Friend WithEvents update As Label
End Class
