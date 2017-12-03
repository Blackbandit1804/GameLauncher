<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class login
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.loginBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.signUpBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.userBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.passBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(20, 5)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(285, 25)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Please sign in to continue"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(297, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "(Your login in credentials will be remembered by this machine.)"
        '
        'loginBtn
        '
        Me.loginBtn.AutoSize = True
        Me.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.loginBtn.Depth = 0
        Me.loginBtn.Icon = Nothing
        Me.loginBtn.Location = New System.Drawing.Point(15, 104)
        Me.loginBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Primary = True
        Me.loginBtn.Size = New System.Drawing.Size(69, 36)
        Me.loginBtn.TabIndex = 8
        Me.loginBtn.Text = "SIGN IN"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'signUpBtn
        '
        Me.signUpBtn.AutoSize = True
        Me.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.signUpBtn.Depth = 0
        Me.signUpBtn.Icon = Nothing
        Me.signUpBtn.Location = New System.Drawing.Point(236, 104)
        Me.signUpBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.signUpBtn.Name = "signUpBtn"
        Me.signUpBtn.Primary = True
        Me.signUpBtn.Size = New System.Drawing.Size(73, 36)
        Me.signUpBtn.TabIndex = 9
        Me.signUpBtn.Text = "SIGN UP"
        Me.signUpBtn.UseVisualStyleBackColor = True
        '
        'userBox
        '
        Me.userBox.Depth = 0
        Me.userBox.Hint = ""
        Me.userBox.Location = New System.Drawing.Point(19, 46)
        Me.userBox.MaxLength = 32767
        Me.userBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.userBox.Name = "userBox"
        Me.userBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.userBox.SelectedText = ""
        Me.userBox.SelectionLength = 0
        Me.userBox.SelectionStart = 0
        Me.userBox.Size = New System.Drawing.Size(288, 23)
        Me.userBox.TabIndex = 10
        Me.userBox.TabStop = False
        Me.userBox.Text = "Username"
        Me.userBox.UseSystemPasswordChar = False
        '
        'passBox
        '
        Me.passBox.Depth = 0
        Me.passBox.Hint = ""
        Me.passBox.Location = New System.Drawing.Point(19, 75)
        Me.passBox.MaxLength = 32767
        Me.passBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.passBox.Name = "passBox"
        Me.passBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.passBox.SelectedText = ""
        Me.passBox.SelectionLength = 0
        Me.passBox.SelectionStart = 0
        Me.passBox.Size = New System.Drawing.Size(288, 23)
        Me.passBox.TabIndex = 11
        Me.passBox.TabStop = False
        Me.passBox.Text = "Password"
        Me.passBox.UseSystemPasswordChar = False
        '
        'login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.ClientSize = New System.Drawing.Size(317, 147)
        Me.Controls.Add(Me.passBox)
        Me.Controls.Add(Me.userBox)
        Me.Controls.Add(Me.signUpBtn)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.MaximumSize = New System.Drawing.Size(333, 186)
        Me.MinimumSize = New System.Drawing.Size(333, 186)
        Me.Name = "login"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Sign in"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents loginBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents signUpBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents userBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents passBox As MaterialSkin.Controls.MaterialSingleLineTextField
End Class
