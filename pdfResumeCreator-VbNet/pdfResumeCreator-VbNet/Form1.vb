Public Class Form1
    Public allTxtBox As TextBox()

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
End Class
