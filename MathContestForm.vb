'Laura Riley
'RCET 0265
'Spring 2021
'Math Contest
'https://github.com/rilelaur/MathContest.git

Option Explicit On
Option Strict On

Public Class MathContestForm
    Shared btnclicked As Boolean = False

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
        StudentAnswerTextBox.Clear()
        btnclicked = True
        RunningTotal(0)
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
            CorrectAnswerSubmitted(True)
        Else
            MessageBox.Show($"The correct answer is {correctAnswer}")
            CorrectAnswerSubmitted(False)
        End If

        PopulateFirstNumber(100)
        PopulateSecondNumber(100)

        StudentAnswerTextBox.Clear()
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

    'tests if the correct answer was submitted
    Sub CorrectAnswerSubmitted(correct As Boolean)
        If correct = True Then
            RunningTotal(1)
        End If
    End Sub

    'keeps track of correct answers
    Function RunningTotal(ByRef countCorrect As Integer) As Integer
        Static _countCorrect As Integer

        _countCorrect += 1

        countCorrect = _countCorrect

        If btnclicked = True Then
            _countCorrect = 0
        End If

        Return countCorrect
    End Function

    'Shows how many questions the student answered correctly
    Private Sub SummeryButton_Click(sender As Object, e As EventArgs) Handles SummeryButton.Click
        MessageBox.Show($"You got {RunningTotal(0) - 1} questions correct.")
    End Sub
End Class
