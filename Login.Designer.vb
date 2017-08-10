<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt1 = New System.Windows.Forms.TextBox()
        Me.txt2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.AdminRadioButton = New System.Windows.Forms.RadioButton()
        Me.StudentRadioButton = New System.Windows.Forms.RadioButton()
        Me.LibrarianRadioButton3 = New System.Windows.Forms.RadioButton()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        Me.LinkLabel2 = New System.Windows.Forms.LinkLabel()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(50, 126)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(53, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(50, 69)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 13)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "User ID"
        '
        'txt1
        '
        Me.txt1.Location = New System.Drawing.Point(135, 69)
        Me.txt1.Name = "txt1"
        Me.txt1.Size = New System.Drawing.Size(118, 20)
        Me.txt1.TabIndex = 3
        '
        'txt2
        '
        Me.txt2.Location = New System.Drawing.Point(135, 119)
        Me.txt2.Name = "txt2"
        Me.txt2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt2.Size = New System.Drawing.Size(118, 20)
        Me.txt2.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(28, 184)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 9
        Me.Button2.Text = "Refresh"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(200, 184)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Sign In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'AdminRadioButton
        '
        Me.AdminRadioButton.AutoSize = True
        Me.AdminRadioButton.Location = New System.Drawing.Point(12, 24)
        Me.AdminRadioButton.Name = "AdminRadioButton"
        Me.AdminRadioButton.Size = New System.Drawing.Size(54, 17)
        Me.AdminRadioButton.TabIndex = 0
        Me.AdminRadioButton.TabStop = True
        Me.AdminRadioButton.Text = "Admin"
        Me.AdminRadioButton.UseVisualStyleBackColor = True
        '
        'StudentRadioButton
        '
        Me.StudentRadioButton.AutoSize = True
        Me.StudentRadioButton.Location = New System.Drawing.Point(135, 24)
        Me.StudentRadioButton.Name = "StudentRadioButton"
        Me.StudentRadioButton.Size = New System.Drawing.Size(62, 17)
        Me.StudentRadioButton.TabIndex = 1
        Me.StudentRadioButton.TabStop = True
        Me.StudentRadioButton.Text = "Student"
        Me.StudentRadioButton.UseVisualStyleBackColor = True
        '
        'LibrarianRadioButton3
        '
        Me.LibrarianRadioButton3.AutoSize = True
        Me.LibrarianRadioButton3.Location = New System.Drawing.Point(267, 24)
        Me.LibrarianRadioButton3.Name = "LibrarianRadioButton3"
        Me.LibrarianRadioButton3.Size = New System.Drawing.Size(65, 17)
        Me.LibrarianRadioButton3.TabIndex = 2
        Me.LibrarianRadioButton3.TabStop = True
        Me.LibrarianRadioButton3.Text = "Librarian"
        Me.LibrarianRadioButton3.UseVisualStyleBackColor = True
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Location = New System.Drawing.Point(34, 226)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(95, 13)
        Me.LinkLabel1.TabIndex = 15
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Forget Password :("
        '
        'LinkLabel2
        '
        Me.LinkLabel2.AutoSize = True
        Me.LinkLabel2.Location = New System.Drawing.Point(217, 226)
        Me.LinkLabel2.Name = "LinkLabel2"
        Me.LinkLabel2.Size = New System.Drawing.Size(76, 13)
        Me.LinkLabel2.TabIndex = 16
        Me.LinkLabel2.TabStop = True
        Me.LinkLabel2.Text = "Sign up here..."
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(344, 261)
        Me.Controls.Add(Me.LinkLabel2)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.LibrarianRadioButton3)
        Me.Controls.Add(Me.StudentRadioButton)
        Me.Controls.Add(Me.AdminRadioButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt1)
        Me.Controls.Add(Me.txt2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Login"
        Me.Text = "Login"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt1 As System.Windows.Forms.TextBox
    Friend WithEvents txt2 As System.Windows.Forms.TextBox
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents AdminRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents StudentRadioButton As System.Windows.Forms.RadioButton
    Friend WithEvents LibrarianRadioButton3 As System.Windows.Forms.RadioButton
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
    Friend WithEvents LinkLabel2 As System.Windows.Forms.LinkLabel
End Class
