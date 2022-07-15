Imports System.IO
Imports Newtonsoft.Json
Imports iTextSharp
Imports iTextSharp.text
Imports iTextSharp.text.pdf

Public Class Form1
    Public allTxtBox As TextBox()
    Public jsonPath As String
    Public jsonFromFile As String
    Public tFName As String
    Public tLName As String
    Public tFullName As String
    Public tAddress As String
    Public tCpNumber As String
    Public tLlNumber As String
    Public tEmailAddress As String
    Public tSummary As String
    Public tHighSchool As List(Of String) = New List(Of String)()
    Public tCollege As List(Of String) = New List(Of String)()
    Public tSkills As List(Of String) = New List(Of String)()
    Public tJobTitle As List(Of String) = New List(Of String)()
    Public tCompanyName As List(Of String) = New List(Of String)()
    Public tDuration As List(Of String) = New List(Of String)()

    Private Sub fName_TextChanged(sender As Object, e As EventArgs) Handles fName.TextChanged
        fullName.Text = $"{fName.Text} {lName.Text}"
    End Sub

    Private Sub lName_TextChanged(ByVal sender As Object, ByVal e As EventArgs) Handles lName.TextChanged
        fullName.Text = $"{fName.Text} {lName.Text}"
    End Sub
    Private Sub fName_Click(ByVal sender As Object, ByVal e As EventArgs)
        fName.BackColor = Color.White
    End Sub

    Private Sub lName_Click(ByVal sender As Object, ByVal e As EventArgs)
        lName.BackColor = Color.White
    End Sub

    Private Sub address_Click(ByVal sender As Object, ByVal e As EventArgs) Handles address.Click
        address.BackColor = Color.White
    End Sub

    Private Sub cpNumber_Click(ByVal sender As Object, ByVal e As EventArgs) Handles cpNumber.Click
        cpNumber.BackColor = Color.White
        llNumber.BackColor = Color.White
    End Sub

    Private Sub llNumber_Click(ByVal sender As Object, ByVal e As EventArgs) Handles llNumber.Click
        llNumber.BackColor = Color.White
        cpNumber.BackColor = Color.White
    End Sub

    Private Sub emailAddress_Click(ByVal sender As Object, ByVal e As EventArgs) Handles emailAddress.Click
        emailAddress.BackColor = Color.White
    End Sub

    Private Sub summary_Click(ByVal sender As Object, ByVal e As EventArgs) Handles summary.Click
        summary.BackColor = Color.White
    End Sub

    Private Sub workExperience_CellClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles workExperience.CellClick
        requiredWorkExperience.Text = ""
    End Sub

    Private Sub hsName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles hsName.Click
        hsName.BackColor = SystemColors.Window
        yGHS.BackColor = SystemColors.Window
    End Sub

    Private Sub yGHS_Click(ByVal sender As Object, ByVal e As EventArgs) Handles yGHS.Click
        hsName.BackColor = SystemColors.Window
        yGHS.BackColor = SystemColors.Window
    End Sub

    Private Sub clgUnivName_Click(ByVal sender As Object, ByVal e As EventArgs) Handles clgUnivName.Click
        clgUnivName.BackColor = SystemColors.Window
        yearClgGraduated.BackColor = SystemColors.Window
        course.BackColor = SystemColors.Window
    End Sub

    Private Sub course_Click(ByVal sender As Object, ByVal e As EventArgs) Handles course.Click
        clgUnivName.BackColor = SystemColors.Window
        yearClgGraduated.BackColor = SystemColors.Window
        course.BackColor = SystemColors.Window
    End Sub

    Private Sub yearClgGraduated_Click(ByVal sender As Object, ByVal e As EventArgs) Handles yearClgGraduated.Click
        clgUnivName.BackColor = SystemColors.Window
        yearClgGraduated.BackColor = SystemColors.Window
        course.BackColor = SystemColors.Window
    End Sub

    Private Shared Function Ordinal(ByVal num As Integer) As String
        Select Case num Mod 100
            Case 11, 12, 13
                Return num & "th"
        End Select

        Select Case num Mod 10
            Case 1
                Return num & "st"
            Case 2
                Return num & "nd"
            Case 3
                Return num & "rd"
            Case Else
                Return num & "th"
        End Select
    End Function

    Private Function RequiredNeed() As Boolean
        If summary.Text.Trim() = "" OrElse fName.Text.Trim() = "" OrElse lName.Text.Trim() = "" OrElse address.Text.Trim() = "" OrElse emailAddress.Text.Trim() = "" OrElse (cpNumber.Text.Trim() = "" AndAlso llNumber.Text.Trim() = "") Then
            Return True
        End If

        For i As Integer = 0 To workExperience.RowCount - 1

            If (workExperience.Rows(i).Cells(0).Value IsNot Nothing AndAlso (workExperience.Rows(i).Cells(1).Value Is Nothing OrElse workExperience.Rows(i).Cells(2).Value Is Nothing)) OrElse (workExperience.Rows(i).Cells(1).Value IsNot Nothing AndAlso (workExperience.Rows(i).Cells(0).Value Is Nothing OrElse workExperience.Rows(i).Cells(2).Value Is Nothing)) OrElse (workExperience.Rows(i).Cells(2).Value IsNot Nothing AndAlso (workExperience.Rows(i).Cells(1).Value Is Nothing OrElse workExperience.Rows(i).Cells(0).Value Is Nothing)) Then
                Return True
            End If
        Next

        If (hsName.Text.Trim() = "" AndAlso yGHS.Text.Trim().Length > 0) OrElse (yGHS.Text.Trim() = "" AndAlso hsName.Text.Trim().Length > 0) Then
            Return True
        End If

        If (clgUnivName.Text.Trim() = "" AndAlso (course.Text.Trim() <> "" OrElse yearClgGraduated.Text.Trim() <> "")) OrElse (course.Text.Trim() = "" AndAlso (clgUnivName.Text.Trim() <> "" OrElse yearClgGraduated.Text.Trim() <> "")) OrElse (yearClgGraduated.Text.Trim() = "" AndAlso (course.Text.Trim() <> "" OrElse clgUnivName.Text.Trim() <> "")) Then
            Return True
        End If

        Return False
    End Function

    Private Sub RedRequired()
        For i As Integer = 0 To allTxtBox.Length - 1

            If i = 3 Then

                If allTxtBox(i).Text.Trim() = "" AndAlso allTxtBox(i + 1).Text.Trim() = "" Then
                    allTxtBox(i).BackColor = Color.Red
                    allTxtBox(i + 1).BackColor = Color.Red
                End If
            ElseIf i = 4 Then
                Continue For
            Else

                If allTxtBox(i).Text.Trim() = "" Then
                    allTxtBox(i).BackColor = Color.Red
                End If
            End If
        Next

        For i As Integer = 0 To workExperience.RowCount - 1

            If (workExperience.Rows(i).Cells(0).Value IsNot Nothing AndAlso (workExperience.Rows(i).Cells(1).Value Is Nothing OrElse workExperience.Rows(i).Cells(2).Value Is Nothing)) OrElse (workExperience.Rows(i).Cells(1).Value IsNot Nothing AndAlso (workExperience.Rows(i).Cells(0).Value Is Nothing OrElse workExperience.Rows(i).Cells(2).Value Is Nothing)) OrElse (workExperience.Rows(i).Cells(2).Value IsNot Nothing AndAlso (workExperience.Rows(i).Cells(1).Value Is Nothing OrElse workExperience.Rows(i).Cells(0).Value Is Nothing)) Then
                Dim order As String = Ordinal(i + 1)
                requiredWorkExperience.Text = $"{order} row is not completed."
            End If
        Next

        If (hsName.Text.Trim() = "" AndAlso yGHS.Text.Trim().Length > 0) OrElse (yGHS.Text.Trim() = "" AndAlso hsName.Text.Trim().Length > 0) Then
            hsName.BackColor = Color.Red
            yGHS.BackColor = Color.Red
        End If

        If (clgUnivName.Text.Trim() = "" AndAlso (course.Text.Trim() <> "" OrElse yearClgGraduated.Text.Trim() <> "")) OrElse (course.Text.Trim() = "" AndAlso (clgUnivName.Text.Trim() <> "" OrElse yearClgGraduated.Text.Trim() <> "")) OrElse (yearClgGraduated.Text.Trim() = "" AndAlso (course.Text.Trim() <> "" OrElse clgUnivName.Text.Trim() <> "")) Then
            clgUnivName.BackColor = Color.Red
            course.BackColor = Color.Red
            yearClgGraduated.BackColor = Color.Red
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
        allTxtBox = {fName, lName, address, cpNumber, llNumber, emailAddress, summary}
    End Sub

    Private Sub update_MouseDown(ByVal sender As Object, ByVal e As MouseEventArgs) Handles update.MouseDown
        update.Text = ""
    End Sub

    Private Sub cpNumber_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles cpNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "("c AndAlso e.KeyChar <> ")"c AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> "+"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub llNumber_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles llNumber.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "("c AndAlso e.KeyChar <> ")"c AndAlso e.KeyChar <> "-"c AndAlso e.KeyChar <> "+"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub yGHS_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs) Handles yGHS.KeyPress
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub yearsWorked1_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub yearsWorked2_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub yearsWorked3_KeyPress(ByVal sender As Object, ByVal e As KeyPressEventArgs)
        If Not Char.IsControl(e.KeyChar) AndAlso Not Char.IsDigit(e.KeyChar) AndAlso e.KeyChar <> "-"c Then
            e.Handled = True
        End If
    End Sub

    Private Sub reset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles reset.Click
        ResetData()
        fullName.Text = String.Empty
        summary.Text = String.Empty
        fName.Text = String.Empty
        lName.Text = String.Empty
        address.Text = String.Empty
        emailAddress.Text = String.Empty
        skills.Text = String.Empty
        cpNumber.Text = String.Empty
        llNumber.Text = String.Empty
        hsName.Text = String.Empty
        yGHS.Text = String.Empty
        clgUnivName.Text = String.Empty
        yearClgGraduated.Text = String.Empty
        course.Text = String.Empty
        workExperience.Rows.Clear()
        workExperience.Refresh()
    End Sub

    Private Sub GenerateJSON_Click(ByVal sender As Object, ByVal e As EventArgs) Handles GenerateJSON.Click
        If RequiredNeed() Then
            RedRequired()
        Else
            TempSaveData()
            ParseJSON()
            CreateJsonFile()
            ResetData()
        End If
    End Sub

    Private Sub loadJsonButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles loadJsonButton.Click
        OpenFileDialog1.Filter = "JSON File (*.json)|*.json"
        OpenFileDialog1.FileName = ""

        If OpenFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
            jsonPath = $"{OpenFileDialog1.FileName}"
        End If

        If jsonPath <> String.Empty Then
            GetJson()
        End If
    End Sub

    Private Sub pdfButton_Click(ByVal sender As Object, ByVal e As EventArgs) Handles pdfButton.Click
        If RequiredNeed() Then
            RedRequired()
        Else
            TempSaveData()
            CreatePDF()
            ResetData()
        End If
    End Sub

    Private Sub TempSaveData()
        Dim tempSkill As String
        tFName = fName.Text
        tLName = lName.Text
        tFullName = $"{tFName} {tLName}"
        tAddress = address.Text
        tCpNumber = cpNumber.Text
        tLlNumber = llNumber.Text
        tEmailAddress = emailAddress.Text
        tSummary = summary.Text

        If skills.Text.Trim() <> "" Then
            tempSkill = skills.Text.Replace(" ", String.Empty)
            tSkills.AddRange(tempSkill.Split(","))
        End If

        If hsName.Text.Trim() <> "" Then
            tHighSchool.Add(hsName.Text)
            tHighSchool.Add(yGHS.Text)
        End If

        If clgUnivName.Text.Trim() <> "" Then
            tCollege.Add(clgUnivName.Text)
            tCollege.Add(course.Text)
            tCollege.Add(yearClgGraduated.Text)
        End If

        For i As Integer = 0 To workExperience.RowCount - 1

            If workExperience.Rows(i).Cells(0).Value Is Nothing Then
                Continue For
            Else
                tJobTitle.Add(workExperience.Rows(i).Cells(0).Value.ToString())
                tCompanyName.Add(workExperience.Rows(i).Cells(1).Value.ToString())
                tDuration.Add(workExperience.Rows(i).Cells(2).Value.ToString())
            End If
        Next
    End Sub
    Dim personal As Personalinfo

    Private Sub ParseJSON()
        personal = New Personalinfo()
        personal.Skills = New List(Of String)()
        personal.HighSchool = New List(Of String)()
        personal.College = New List(Of String)()
        personal.JobTitle = New List(Of String)()
        personal.CompanyName = New List(Of String)()
        personal.YearDuration = New List(Of String)()
        personal.FirstName = tFName
        personal.LastName = tLName
        personal.FullName = tFullName
        personal.Address = tAddress
        personal.EmailAddress = tEmailAddress
        personal.Summary = tSummary

        If tCpNumber.Trim() <> "" Then
            personal.CpNumber = tCpNumber
        End If

        If tLlNumber.Trim() <> "" Then
            personal.LlNumber = tLlNumber
        End If

        If tSkills.Count > 0 Then
            personal.Skills.AddRange(tSkills)
        End If

        If tHighSchool.Count > 0 Then
            personal.HighSchool.AddRange(tHighSchool)
        End If

        If tCollege.Count > 0 Then
            personal.College.AddRange(tCollege)
        End If

        If tJobTitle.Count > 0 Then
            personal.JobTitle.AddRange(tJobTitle)
            personal.CompanyName.AddRange(tCompanyName)
            personal.YearDuration.AddRange(tDuration)
        End If
    End Sub

    Private Sub CreateJsonFile()
        If Not System.IO.Directory.Exists("C:\Users\Computer\Documents\PDFResume\") Then
            System.IO.Directory.CreateDirectory("C:\Users\Computer\Documents\PDFResume\")
        End If
        File.WriteAllText($"C:\Users\Computer\Documents\PDFResume\{tLName}_{tFName}.json", JsonConvert.SerializeObject(personal))

        update.Text = "JSON Saved!"
    End Sub

    Private Sub ResetData()
        tFName = ""
        tLName = ""
        tFullName = ""
        tAddress = ""
        tCpNumber = ""
        tLlNumber = ""
        tEmailAddress = ""
        tSummary = ""
        tHighSchool.Clear()
        tCollege.Clear()
        tSkills.Clear()
        tJobTitle.Clear()
        tCompanyName.Clear()
        tDuration.Clear()
    End Sub

    Private Sub GetJson()
        Dim loadPersonal As Personalinfo = JsonConvert.DeserializeObject(Of Personalinfo)(File.ReadAllText($"{jsonPath}"))
        personal = New Personalinfo()
        personal = loadPersonal
        fullName.Text = personal.FullName
        fName.Text = personal.FirstName
        lName.Text = personal.LastName
        address.Text = personal.Address

        If personal.CpNumber <> String.Empty OrElse personal.CpNumber IsNot Nothing Then
            cpNumber.Text = personal.CpNumber
        End If

        If personal.LlNumber <> String.Empty OrElse personal.LlNumber IsNot Nothing Then
            llNumber.Text = personal.LlNumber
        End If

        emailAddress.Text = personal.EmailAddress

        If personal.Skills.Count > 0 Then
            skills.Text = String.Join(", ", personal.Skills)
        End If

        summary.Text = personal.Summary

        If personal.HighSchool.Count > 0 Then
            hsName.Text = personal.HighSchool(0)
            yGHS.Text = personal.HighSchool(1)
        End If

        If personal.College.Count > 0 Then
            clgUnivName.Text = personal.College(0)
            course.Text = personal.College(1)
            yearClgGraduated.Text = personal.College(2)
        End If

        workExperience.Rows.Insert(0)

        For i As Integer = 0 To personal.JobTitle.Count - 1

            If i = 0 Then
                workExperience.Rows(i).Cells(0).Value = personal.JobTitle(i)
                workExperience.Rows(i).Cells(1).Value = personal.CompanyName(i)
                workExperience.Rows(i).Cells(2).Value = personal.YearDuration(i)
            Else
                Dim row As String() = New String() {personal.JobTitle(i), personal.CompanyName(i), personal.YearDuration(i)}
                workExperience.Rows.Insert(i, row)
            End If
        Next

        update.Text = "JSON Loaded!"
        ResetData()
    End Sub

    Private Sub CreatePDF()
        Dim withll As Boolean = False, withcp As Boolean = False
        Dim doc As Document = New Document(iTextSharp.text.PageSize.LETTER, 72, 72, 72, 72)
        Dim bDefault As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, False)
        Dim fDefault As iTextSharp.text.Font = New iTextSharp.text.Font(bDefault, 12)
        Dim linebreak As Chunk = New Chunk(New iTextSharp.text.pdf.draw.LineSeparator(2.0F, 100.0F, BaseColor.BLACK, Element.ALIGN_CENTER, -1))
        Dim endLine As Paragraph = New Paragraph(vbLf)
        Dim bfFullName As BaseFont = BaseFont.CreateFont(BaseFont.TIMES_BOLD, BaseFont.CP1252, False)
        Dim fFullName As iTextSharp.text.Font = New iTextSharp.text.Font(bfFullName, 16)
        Dim pFullName As Paragraph = New Paragraph($"{tFullName.ToUpper()}", fFullName)
        Dim pContactDetails1 As Paragraph = New Paragraph($"Address: {tAddress}", fDefault)
        Dim pContactDetails2 As Paragraph = New Paragraph("")

        If Not System.IO.Directory.Exists("C:\Users\Computer\Documents\PDFResume\") Then
            System.IO.Directory.CreateDirectory("C:\Users\Computer\Documents\PDFResume\")
        End If
        Dim wri As PdfWriter = PdfWriter.GetInstance(doc, New FileStream($"C:\Users\Computer\Documents\PDFResume\{tLName}_{tFName}.pdf", FileMode.Create))


        If tLlNumber <> "" AndAlso tCpNumber <> "" Then
            withll = True
            withcp = True
            pContactDetails2 = New Paragraph($"Landline Number: {tLlNumber}\n" & $"Cellphone Number: {tCpNumber}\n" & $"Email Address: {tEmailAddress}", fDefault)
        ElseIf tLlNumber <> "" Then
            withll = True
            pContactDetails2 = New Paragraph($"Landline Number: {tLlNumber}\n" & $"Email Address: {tEmailAddress}", fDefault)
        ElseIf tCpNumber <> "" Then
            withcp = True
            pContactDetails2 = New Paragraph($"Cellphone Number: {tCpNumber}\n" & $"Email Address: {tEmailAddress}", fDefault)
        End If

        Dim fDefaultBold As iTextSharp.text.Font = New iTextSharp.text.Font(bfFullName, 12)
        Dim taSummary As PdfPTable = New PdfPTable(1)
        Dim cSummary As PdfPCell = New PdfPCell(New Phrase("SUMMARY", fDefaultBold))
        cSummary.BackgroundColor = BaseColor.LIGHT_GRAY
        cSummary.VerticalAlignment = 1
        taSummary.AddCell(cSummary)
        taSummary.WidthPercentage = 100
        Dim pSummary As Paragraph = New Paragraph($"{tSummary}", fDefault)
        Dim taEduc As PdfPTable = New PdfPTable(1)
        Dim cEduc As PdfPCell = New PdfPCell(New Phrase("EDUCATIONAL BACKGROUND", fDefaultBold))
        cEduc.BackgroundColor = BaseColor.LIGHT_GRAY
        cEduc.VerticalAlignment = 1
        taEduc.AddCell(cEduc)
        taEduc.WidthPercentage = 100
        Dim taEducB As PdfPTable = New PdfPTable(3)
        Dim cName As PdfPCell = New PdfPCell(New Phrase("School Name", fDefaultBold))
        Dim cCourseLevel As PdfPCell = New PdfPCell(New Phrase("Degree/Level", fDefaultBold))
        Dim cYear As PdfPCell = New PdfPCell(New Phrase("Year Graduated", fDefaultBold))
        cName.VerticalAlignment = 1
        cName.HorizontalAlignment = 1
        cCourseLevel.VerticalAlignment = 1
        cCourseLevel.HorizontalAlignment = 1
        cYear.VerticalAlignment = 1
        cYear.HorizontalAlignment = 1
        taEducB.AddCell(cName)
        taEducB.AddCell(cCourseLevel)
        taEducB.AddCell(cYear)

        For i As Integer = 0 To tCollege.Count - 1

            If i = 1 Then
                Dim educHolder As PdfPCell = New PdfPCell(New Phrase($"Tertiary\n{tCollege(i)}", fDefault))
                educHolder.VerticalAlignment = 1
                educHolder.HorizontalAlignment = 1
                taEducB.AddCell(educHolder)
            Else
                Dim educHolder As PdfPCell = New PdfPCell(New Phrase($"{tCollege(i)}", fDefault))
                educHolder.VerticalAlignment = 1
                educHolder.HorizontalAlignment = 1
                taEducB.AddCell(educHolder)
            End If
        Next

        For i As Integer = 0 To tHighSchool.Count - 1

            If i = 0 Then
                Dim educHolder As PdfPCell = New PdfPCell(New Phrase($"{tHighSchool(i)}", fDefault))
                Dim educHolder2 As PdfPCell = New PdfPCell(New Phrase($"Secondary Level", fDefault))
                educHolder.VerticalAlignment = 1
                educHolder2.VerticalAlignment = 1
                educHolder.HorizontalAlignment = 1
                educHolder2.HorizontalAlignment = 1
                taEducB.AddCell(educHolder)
                taEducB.AddCell(educHolder2)
            Else
                Dim educHolder As PdfPCell = New PdfPCell(New Phrase($"{tHighSchool(i)}", fDefault))
                educHolder.VerticalAlignment = 1
                educHolder.HorizontalAlignment = 1
                taEducB.AddCell(educHolder)
            End If
        Next

        taEducB.WidthPercentage = 100
        Dim taSkills As PdfPTable = New PdfPTable(1)
        Dim cSkills As PdfPCell = New PdfPCell(New Phrase("SKILLS", fDefaultBold))
        cSkills.BackgroundColor = BaseColor.LIGHT_GRAY
        cSkills.VerticalAlignment = 1
        taSkills.AddCell(cSkills)
        taSkills.WidthPercentage = 100
        Dim skillset As iTextSharp.text.List = New iTextSharp.text.List(iTextSharp.text.List.UNORDERED)

        For i As Integer = 0 To tSkills.Count - 1
            Dim holder = New Phrase(tSkills(i), fDefault)
            skillset.Add(New iTextSharp.text.ListItem(holder))
        Next

        Dim taWorkExp As PdfPTable = New PdfPTable(1)
        Dim cWorkExp As PdfPCell = New PdfPCell(New Phrase("WORKING EXPERIENCE", fDefaultBold))
        cWorkExp.BackgroundColor = BaseColor.LIGHT_GRAY
        cWorkExp.VerticalAlignment = 1
        taWorkExp.AddCell(cWorkExp)
        taWorkExp.WidthPercentage = 100
        Dim taWE As PdfPTable = New PdfPTable(3)
        taWE.WidthPercentage = 100
        Dim cJobTitleL As PdfPCell = New PdfPCell(New Phrase("Job Title", fDefaultBold))
        cJobTitleL.VerticalAlignment = 1
        cJobTitleL.HorizontalAlignment = 1
        Dim cCompanyNameL As PdfPCell = New PdfPCell(New Phrase("Company Name", fDefaultBold))
        cCompanyNameL.VerticalAlignment = 1
        cCompanyNameL.HorizontalAlignment = 1
        Dim cDurationL As PdfPCell = New PdfPCell(New Phrase("Duration", fDefaultBold))
        cDurationL.VerticalAlignment = 1
        cDurationL.HorizontalAlignment = 1
        taWE.AddCell(cJobTitleL)
        taWE.AddCell(cCompanyNameL)
        taWE.AddCell(cDurationL)

        For i As Integer = 0 To tJobTitle.Count - 1
            Dim cJobTitle As PdfPCell = New PdfPCell(New Phrase(tJobTitle(i), fDefault))
            cJobTitle.VerticalAlignment = 1
            cJobTitle.HorizontalAlignment = 1
            Dim cCompanyName As PdfPCell = New PdfPCell(New Phrase(tCompanyName(i), fDefault))
            cCompanyName.VerticalAlignment = 1
            cCompanyName.HorizontalAlignment = 1
            Dim cDuration As PdfPCell = New PdfPCell(New Phrase(tDuration(i), fDefault))
            cDuration.VerticalAlignment = 1
            cDuration.HorizontalAlignment = 1
            taWE.AddCell(cJobTitle)
            taWE.AddCell(cCompanyName)
            taWE.AddCell(cDuration)
        Next

        doc.Open()
        doc.Add(pFullName)
        doc.Add(pContactDetails1)
        doc.Add(pContactDetails2)
        doc.Add(linebreak)
        doc.Add(taSummary)
        doc.Add(pSummary)
        doc.Add(endLine)
        doc.Add(taEduc)
        doc.Add(endLine)
        doc.Add(taEducB)
        doc.Add(endLine)
        doc.Add(taSkills)
        doc.Add(skillset)
        doc.Add(endLine)
        doc.Add(taWorkExp)
        doc.Add(endLine)
        doc.Add(taWE)
        doc.Close()
        update.Text = "PDF Generated"
    End Sub
    Public Class Personalinfo
        Public Property FirstName As String
        Public Property LastName As String
        Public Property FullName As String
        Public Property Address As String
        Public Property CpNumber As String
        Public Property LlNumber As String
        Public Property EmailAddress As String
        Public Property Skills As List(Of String)
        Public Property Summary As String
        Public Property HighSchool As List(Of String)
        Public Property College As List(Of String)
        Public Property JobTitle As List(Of String)
        Public Property CompanyName As List(Of String)
        Public Property YearDuration As List(Of String)
    End Class

End Class
