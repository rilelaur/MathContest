'Laura Riley
'RCET 0265
'Spring 2021
'Math Contest
'https://github.com/rilelaur/MathContest.git

Option Explicit On
Option Strict On

Public Class MathContestForm

    Sub Main()

    End Sub

    'exits the program when the exit button is clicked or "x" is selected
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    'clears all textboxes when the clear button is clicked
    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click
        StudentNameTextBox.Clear()
        StudentAgeTextBox.Clear()
        StudentGradeTextBox.Clear()
        FirstNumbrTextBox.Clear()
        SecondNumberTextBox.Clear()
        StudentAnswerTextBox.Clear()
    End Sub


    Function GenerateRandomNumber(maxNumber As Integer) As Integer
        Randomize()
        maxNumber = CInt(100 * Rnd() + 1)
    End Function

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        'Verify's that the students information is correct before allowing them to do anything
        If StudentNameTextBox.Text = "" Then
            MessageBox.Show("Message To User: Enter the Students name")
            StudentNameTextBox.Focus()
        ElseIf StudentAgeTextBox.Text <> "7" And StudentAgeTextBox.Text <> "8" And StudentAgeTextBox.Text <> "9" And StudentAgeTextBox.Text <> "10" And StudentAgeTextBox.Text <> "11" Then
            MessageBox.Show("Student not eligigble to compete.")
            StudentAgeTextBox.Clear()
            StudentAgeTextBox.Focus()
        ElseIf StudentGradeTextBox.Text <> "1" And StudentGradeTextBox.Text <> "2" And StudentGradeTextBox.Text <> "3" And StudentGradeTextBox.Text <> "4" Then
            MessageBox.Show("Message To User: Student not eligible to compete due to grade level")
            StudentGradeTextBox.Clear()
            StudentGradeTextBox.Focus()
        End If

    End Sub
End Class
