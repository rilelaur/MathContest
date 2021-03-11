'Laura Riley
'RCET 0265
'Spring 2021
'Math Contest
'https://github.com/rilelaur/MathContest.git

Option Explicit On
Option Strict On

Public Class MathContestForm
    'When the program loads it populates the first and second number textboxes with a number
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PopulateFirstNumber(100)
        PopulateSecondNumber(100)
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
        FirstNumberTextBox.Clear()
        SecondNumberTextBox.Clear()
        StudentAnswerTextBox.Clear()
    End Sub

    Private Sub SubmitButton_Click(sender As Object, e As EventArgs) Handles SubmitButton.Click

        Dim correctAnswer As Double

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

        'computes the correct answer based on which radio box is checked
        If AddRadioButton.Checked Then
            correctAnswer = CInt(FirstNumberTextBox.Text) + CInt(SecondNumberTextBox.Text)
        ElseIf SubtractRadioButton.Checked Then
            correctAnswer = CInt(FirstNumberTextBox.Text) - CInt(SecondNumberTextBox.Text)
        ElseIf MultiplyRadioButton.Checked Then
            correctAnswer = CInt(FirstNumberTextBox.Text) * CInt(SecondNumberTextBox.Text)
        ElseIf DivideRadioButton.Checked Then
            correctAnswer = CInt(FirstNumberTextBox.Text) / CInt(SecondNumberTextBox.Text)
        End If

        'determines if the students answer is correct or not and displays accordingly
        If StudentAnswerTextBox.Text = "" Then
            MessageBox.Show("Message to user: Please input your answer.")
        ElseIf CInt(StudentAnswerTextBox.Text) = correctAnswer Then
            MessageBox.Show("Congratulations! You submited the correct answer.")
            RunningTotal(1, 0)
        Else
            MessageBox.Show($"The correct answer is {correctAnswer}")
            RunningTotal(0, 1)
        End If
    End Sub

    'generates a random number
    Function GenerateRandomNumber(maxNumber As Integer) As Integer
        Randomize()
        Return CInt(maxNumber * Rnd() + 1)
    End Function

    'populates the first number textbox with a random number
    Function PopulateFirstNumber(maxnumber As Integer) As String
        Dim firstNumber As Integer
        firstNumber = GenerateRandomNumber(100)
        FirstNumberTextBox.Text = CStr(firstNumber)
        Return FirstNumberTextBox.Text
    End Function

    'populates the second number textbox with a random number
    Function PopulateSecondNumber(maxnumber As Integer) As String
        Dim secondNumber As Integer
        secondNumber = GenerateRandomNumber(100)
        SecondNumberTextBox.Text = CStr(secondNumber)
        Return SecondNumberTextBox.Text
    End Function

    'keeps track of correct and incorrect answers
    Function RunningTotal(correct As Integer, incorrect As Integer) As Integer
        If correct = 1 Then
            correct += 1
        Else
            incorrect += 1
        End If
        Return correct And incorrect
    End Function

    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        MessageBox.Show($"Correct {RunningTotal(1, 0)} Incorrect {RunningTotal(0, 1)}")
    End Sub
End Class
