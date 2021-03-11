<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MathContestForm
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
        Me.StudentInformationGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentGradeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentGradeLabel = New System.Windows.Forms.Label()
        Me.StudentAgeTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAgeLabel = New System.Windows.Forms.Label()
        Me.StudentNameTextBox = New System.Windows.Forms.TextBox()
        Me.StudentNameLabel = New System.Windows.Forms.Label()
        Me.CurrentMathProblmeGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentAnswerTextBox = New System.Windows.Forms.TextBox()
        Me.SecondNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FirstNumberTextBox = New System.Windows.Forms.TextBox()
        Me.StudentAnswerLabel = New System.Windows.Forms.Label()
        Me.SecondNumberLabel = New System.Windows.Forms.Label()
        Me.FirstNumberLabel = New System.Windows.Forms.Label()
        Me.MathProblemTypeGroupBox = New System.Windows.Forms.GroupBox()
        Me.MultiplyRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubtractRadioButton = New System.Windows.Forms.RadioButton()
        Me.DivideRadioButton = New System.Windows.Forms.RadioButton()
        Me.AddRadioButton = New System.Windows.Forms.RadioButton()
        Me.SubmitButton = New System.Windows.Forms.Button()
        Me.ClearButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SummeryButton = New System.Windows.Forms.Button()
        Me.ButtonsGroupBox = New System.Windows.Forms.GroupBox()
        Me.StudentInformationGroupBox.SuspendLayout()
        Me.CurrentMathProblmeGroupBox.SuspendLayout()
        Me.MathProblemTypeGroupBox.SuspendLayout()
        Me.ButtonsGroupBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'StudentInformationGroupBox
        '
        Me.StudentInformationGroupBox.Controls.Add(Me.StudentGradeTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.StudentGradeLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.StudentAgeTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.StudentAgeLabel)
        Me.StudentInformationGroupBox.Controls.Add(Me.StudentNameTextBox)
        Me.StudentInformationGroupBox.Controls.Add(Me.StudentNameLabel)
        Me.StudentInformationGroupBox.Location = New System.Drawing.Point(6, 5)
        Me.StudentInformationGroupBox.Name = "StudentInformationGroupBox"
        Me.StudentInformationGroupBox.Size = New System.Drawing.Size(485, 103)
        Me.StudentInformationGroupBox.TabIndex = 0
        Me.StudentInformationGroupBox.TabStop = False
        Me.StudentInformationGroupBox.Text = "Student Information"
        '
        'StudentGradeTextBox
        '
        Me.StudentGradeTextBox.Location = New System.Drawing.Point(382, 48)
        Me.StudentGradeTextBox.Name = "StudentGradeTextBox"
        Me.StudentGradeTextBox.Size = New System.Drawing.Size(47, 22)
        Me.StudentGradeTextBox.TabIndex = 2
        '
        'StudentGradeLabel
        '
        Me.StudentGradeLabel.AutoSize = True
        Me.StudentGradeLabel.Location = New System.Drawing.Point(379, 28)
        Me.StudentGradeLabel.Name = "StudentGradeLabel"
        Me.StudentGradeLabel.Size = New System.Drawing.Size(48, 17)
        Me.StudentGradeLabel.TabIndex = 4
        Me.StudentGradeLabel.Text = "Grade"
        '
        'StudentAgeTextBox
        '
        Me.StudentAgeTextBox.Location = New System.Drawing.Point(285, 48)
        Me.StudentAgeTextBox.Name = "StudentAgeTextBox"
        Me.StudentAgeTextBox.Size = New System.Drawing.Size(47, 22)
        Me.StudentAgeTextBox.TabIndex = 1
        '
        'StudentAgeLabel
        '
        Me.StudentAgeLabel.AutoSize = True
        Me.StudentAgeLabel.Location = New System.Drawing.Point(282, 28)
        Me.StudentAgeLabel.Name = "StudentAgeLabel"
        Me.StudentAgeLabel.Size = New System.Drawing.Size(33, 17)
        Me.StudentAgeLabel.TabIndex = 2
        Me.StudentAgeLabel.Text = "Age"
        '
        'StudentNameTextBox
        '
        Me.StudentNameTextBox.Location = New System.Drawing.Point(22, 48)
        Me.StudentNameTextBox.Name = "StudentNameTextBox"
        Me.StudentNameTextBox.Size = New System.Drawing.Size(215, 22)
        Me.StudentNameTextBox.TabIndex = 0
        '
        'StudentNameLabel
        '
        Me.StudentNameLabel.AutoSize = True
        Me.StudentNameLabel.Location = New System.Drawing.Point(19, 28)
        Me.StudentNameLabel.Name = "StudentNameLabel"
        Me.StudentNameLabel.Size = New System.Drawing.Size(45, 17)
        Me.StudentNameLabel.TabIndex = 0
        Me.StudentNameLabel.Text = "Name"
        '
        'CurrentMathProblmeGroupBox
        '
        Me.CurrentMathProblmeGroupBox.Controls.Add(Me.StudentAnswerTextBox)
        Me.CurrentMathProblmeGroupBox.Controls.Add(Me.SecondNumberTextBox)
        Me.CurrentMathProblmeGroupBox.Controls.Add(Me.FirstNumberTextBox)
        Me.CurrentMathProblmeGroupBox.Controls.Add(Me.StudentAnswerLabel)
        Me.CurrentMathProblmeGroupBox.Controls.Add(Me.SecondNumberLabel)
        Me.CurrentMathProblmeGroupBox.Controls.Add(Me.FirstNumberLabel)
        Me.CurrentMathProblmeGroupBox.Location = New System.Drawing.Point(10, 124)
        Me.CurrentMathProblmeGroupBox.Name = "CurrentMathProblmeGroupBox"
        Me.CurrentMathProblmeGroupBox.Size = New System.Drawing.Size(310, 307)
        Me.CurrentMathProblmeGroupBox.TabIndex = 1
        Me.CurrentMathProblmeGroupBox.TabStop = False
        Me.CurrentMathProblmeGroupBox.Text = "Current Math Problem"
        '
        'StudentAnswerTextBox
        '
        Me.StudentAnswerTextBox.Location = New System.Drawing.Point(24, 229)
        Me.StudentAnswerTextBox.Name = "StudentAnswerTextBox"
        Me.StudentAnswerTextBox.Size = New System.Drawing.Size(166, 22)
        Me.StudentAnswerTextBox.TabIndex = 2
        '
        'SecondNumberTextBox
        '
        Me.SecondNumberTextBox.Enabled = False
        Me.SecondNumberTextBox.Location = New System.Drawing.Point(24, 156)
        Me.SecondNumberTextBox.Name = "SecondNumberTextBox"
        Me.SecondNumberTextBox.Size = New System.Drawing.Size(166, 22)
        Me.SecondNumberTextBox.TabIndex = 1
        '
        'FirstNumberTextBox
        '
        Me.FirstNumberTextBox.Enabled = False
        Me.FirstNumberTextBox.Location = New System.Drawing.Point(24, 67)
        Me.FirstNumberTextBox.Name = "FirstNumberTextBox"
        Me.FirstNumberTextBox.Size = New System.Drawing.Size(166, 22)
        Me.FirstNumberTextBox.TabIndex = 0
        '
        'StudentAnswerLabel
        '
        Me.StudentAnswerLabel.AutoSize = True
        Me.StudentAnswerLabel.Location = New System.Drawing.Point(21, 199)
        Me.StudentAnswerLabel.Name = "StudentAnswerLabel"
        Me.StudentAnswerLabel.Size = New System.Drawing.Size(107, 17)
        Me.StudentAnswerLabel.TabIndex = 2
        Me.StudentAnswerLabel.Text = "Student Answer"
        '
        'SecondNumberLabel
        '
        Me.SecondNumberLabel.AutoSize = True
        Me.SecondNumberLabel.Location = New System.Drawing.Point(21, 120)
        Me.SecondNumberLabel.Name = "SecondNumberLabel"
        Me.SecondNumberLabel.Size = New System.Drawing.Size(110, 17)
        Me.SecondNumberLabel.TabIndex = 1
        Me.SecondNumberLabel.Text = "Second Number"
        '
        'FirstNumberLabel
        '
        Me.FirstNumberLabel.AutoSize = True
        Me.FirstNumberLabel.Location = New System.Drawing.Point(21, 34)
        Me.FirstNumberLabel.Name = "FirstNumberLabel"
        Me.FirstNumberLabel.Size = New System.Drawing.Size(89, 17)
        Me.FirstNumberLabel.TabIndex = 0
        Me.FirstNumberLabel.Text = "First Number"
        '
        'MathProblemTypeGroupBox
        '
        Me.MathProblemTypeGroupBox.Controls.Add(Me.MultiplyRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.SubtractRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.DivideRadioButton)
        Me.MathProblemTypeGroupBox.Controls.Add(Me.AddRadioButton)
        Me.MathProblemTypeGroupBox.Location = New System.Drawing.Point(339, 124)
        Me.MathProblemTypeGroupBox.Name = "MathProblemTypeGroupBox"
        Me.MathProblemTypeGroupBox.Size = New System.Drawing.Size(151, 306)
        Me.MathProblemTypeGroupBox.TabIndex = 2
        Me.MathProblemTypeGroupBox.TabStop = False
        Me.MathProblemTypeGroupBox.Text = "Math Problem Type"
        '
        'MultiplyRadioButton
        '
        Me.MultiplyRadioButton.AutoSize = True
        Me.MultiplyRadioButton.Location = New System.Drawing.Point(6, 169)
        Me.MultiplyRadioButton.Name = "MultiplyRadioButton"
        Me.MultiplyRadioButton.Size = New System.Drawing.Size(76, 21)
        Me.MultiplyRadioButton.TabIndex = 2
        Me.MultiplyRadioButton.Text = "Multiply"
        Me.MultiplyRadioButton.UseVisualStyleBackColor = True
        '
        'SubtractRadioButton
        '
        Me.SubtractRadioButton.AutoSize = True
        Me.SubtractRadioButton.Location = New System.Drawing.Point(6, 118)
        Me.SubtractRadioButton.Name = "SubtractRadioButton"
        Me.SubtractRadioButton.Size = New System.Drawing.Size(82, 21)
        Me.SubtractRadioButton.TabIndex = 1
        Me.SubtractRadioButton.Text = "Subtract"
        Me.SubtractRadioButton.UseVisualStyleBackColor = True
        '
        'DivideRadioButton
        '
        Me.DivideRadioButton.AutoSize = True
        Me.DivideRadioButton.Location = New System.Drawing.Point(6, 218)
        Me.DivideRadioButton.Name = "DivideRadioButton"
        Me.DivideRadioButton.Size = New System.Drawing.Size(68, 21)
        Me.DivideRadioButton.TabIndex = 3
        Me.DivideRadioButton.Text = "Divide"
        Me.DivideRadioButton.UseVisualStyleBackColor = True
        '
        'AddRadioButton
        '
        Me.AddRadioButton.AutoSize = True
        Me.AddRadioButton.Checked = True
        Me.AddRadioButton.Location = New System.Drawing.Point(6, 67)
        Me.AddRadioButton.Name = "AddRadioButton"
        Me.AddRadioButton.Size = New System.Drawing.Size(54, 21)
        Me.AddRadioButton.TabIndex = 0
        Me.AddRadioButton.TabStop = True
        Me.AddRadioButton.Text = "Add"
        Me.AddRadioButton.UseVisualStyleBackColor = True
        '
        'SubmitButton
        '
        Me.SubmitButton.Location = New System.Drawing.Point(18, 19)
        Me.SubmitButton.Name = "SubmitButton"
        Me.SubmitButton.Size = New System.Drawing.Size(251, 58)
        Me.SubmitButton.TabIndex = 0
        Me.SubmitButton.Text = "&Submit"
        Me.SubmitButton.UseVisualStyleBackColor = True
        '
        'ClearButton
        '
        Me.ClearButton.Location = New System.Drawing.Point(18, 103)
        Me.ClearButton.Name = "ClearButton"
        Me.ClearButton.Size = New System.Drawing.Size(251, 58)
        Me.ClearButton.TabIndex = 1
        Me.ClearButton.Text = "&Clear"
        Me.ClearButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(18, 275)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(251, 58)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'SummeryButton
        '
        Me.SummeryButton.Location = New System.Drawing.Point(18, 191)
        Me.SummeryButton.Name = "SummeryButton"
        Me.SummeryButton.Size = New System.Drawing.Size(251, 58)
        Me.SummeryButton.TabIndex = 2
        Me.SummeryButton.Text = "S&ummery"
        Me.SummeryButton.UseVisualStyleBackColor = True
        '
        'ButtonsGroupBox
        '
        Me.ButtonsGroupBox.Controls.Add(Me.ExitButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SummeryButton)
        Me.ButtonsGroupBox.Controls.Add(Me.ClearButton)
        Me.ButtonsGroupBox.Controls.Add(Me.SubmitButton)
        Me.ButtonsGroupBox.Location = New System.Drawing.Point(499, 14)
        Me.ButtonsGroupBox.Name = "ButtonsGroupBox"
        Me.ButtonsGroupBox.Size = New System.Drawing.Size(281, 415)
        Me.ButtonsGroupBox.TabIndex = 3
        Me.ButtonsGroupBox.TabStop = False
        '
        'MathContestForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ButtonsGroupBox)
        Me.Controls.Add(Me.MathProblemTypeGroupBox)
        Me.Controls.Add(Me.CurrentMathProblmeGroupBox)
        Me.Controls.Add(Me.StudentInformationGroupBox)
        Me.Name = "MathContestForm"
        Me.Text = "Math Contest"
        Me.StudentInformationGroupBox.ResumeLayout(False)
        Me.StudentInformationGroupBox.PerformLayout()
        Me.CurrentMathProblmeGroupBox.ResumeLayout(False)
        Me.CurrentMathProblmeGroupBox.PerformLayout()
        Me.MathProblemTypeGroupBox.ResumeLayout(False)
        Me.MathProblemTypeGroupBox.PerformLayout()
        Me.ButtonsGroupBox.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StudentInformationGroupBox As GroupBox
    Friend WithEvents StudentNameTextBox As TextBox
    Friend WithEvents StudentNameLabel As Label
    Friend WithEvents StudentGradeTextBox As TextBox
    Friend WithEvents StudentGradeLabel As Label
    Friend WithEvents StudentAgeTextBox As TextBox
    Friend WithEvents StudentAgeLabel As Label
    Friend WithEvents CurrentMathProblmeGroupBox As GroupBox
    Friend WithEvents StudentAnswerTextBox As TextBox
    Friend WithEvents SecondNumberTextBox As TextBox
    Friend WithEvents FirstNumberTextBox As TextBox
    Friend WithEvents StudentAnswerLabel As Label
    Friend WithEvents SecondNumberLabel As Label
    Friend WithEvents FirstNumberLabel As Label
    Friend WithEvents MathProblemTypeGroupBox As GroupBox
    Friend WithEvents MultiplyRadioButton As RadioButton
    Friend WithEvents SubtractRadioButton As RadioButton
    Friend WithEvents DivideRadioButton As RadioButton
    Friend WithEvents AddRadioButton As RadioButton
    Friend WithEvents SubmitButton As Button
    Friend WithEvents ClearButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents SummeryButton As Button
    Friend WithEvents ButtonsGroupBox As GroupBox
End Class
