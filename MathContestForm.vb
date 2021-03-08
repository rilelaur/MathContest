'Laura Riley
'RCET 0265
'Spring 2021
'Math Contest
'https://github.com/rilelaur/MathContest.git

Option Explicit On
Option Strict On

Public Class MathContestForm

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


End Class
