<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        btnSubmit = New Button()
        txtGuess = New TextBox()
        lblFeedback = New Label()
        btnStart = New Button()
        lstGuesses = New ListBox()
        SuspendLayout()
        ' 
        ' btnSubmit
        ' 
        btnSubmit.Location = New Point(525, 174)
        btnSubmit.Name = "btnSubmit"
        btnSubmit.Size = New Size(102, 44)
        btnSubmit.TabIndex = 0
        btnSubmit.Text = "Submit"
        btnSubmit.UseVisualStyleBackColor = True
        ' 
        ' txtGuess
        ' 
        txtGuess.Location = New Point(219, 133)
        txtGuess.Name = "txtGuess"
        txtGuess.Size = New Size(265, 23)
        txtGuess.TabIndex = 1
        ' 
        ' lblFeedback
        ' 
        lblFeedback.AutoSize = True
        lblFeedback.Location = New Point(153, 136)
        lblFeedback.Name = "lblFeedback"
        lblFeedback.Size = New Size(60, 15)
        lblFeedback.TabIndex = 2
        lblFeedback.Text = "Feedback:"
        ' 
        ' btnStart
        ' 
        btnStart.Location = New Point(61, 85)
        btnStart.Name = "btnStart"
        btnStart.Size = New Size(102, 44)
        btnStart.TabIndex = 3
        btnStart.Text = "Start"
        btnStart.UseVisualStyleBackColor = True
        ' 
        ' lstGuesses
        ' 
        lstGuesses.FormattingEnabled = True
        lstGuesses.ItemHeight = 15
        lstGuesses.Location = New Point(289, 271)
        lstGuesses.Name = "lstGuesses"
        lstGuesses.Size = New Size(120, 94)
        lstGuesses.TabIndex = 4
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(lstGuesses)
        Controls.Add(btnStart)
        Controls.Add(lblFeedback)
        Controls.Add(txtGuess)
        Controls.Add(btnSubmit)
        Name = "Form1"
        Text = "Form1"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents btnSubmit As Button
    Friend WithEvents txtGuess As TextBox
    Friend WithEvents lblFeedback As Label
    Friend WithEvents btnStart As Button
    Friend WithEvents lstGuesses As ListBox

End Class
