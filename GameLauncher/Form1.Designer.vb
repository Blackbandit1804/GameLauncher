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
        Me.components = New System.ComponentModel.Container()
        Me.Download = New System.ComponentModel.BackgroundWorker()
        Me.Progress = New System.Windows.Forms.Timer(Me.components)
        Me.downloadProgressBar = New MaterialSkin.Controls.MaterialProgressBar()
        Me.playBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.buildNumberNotifier = New MaterialSkin.Controls.MaterialLabel()
        Me.loginBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.newsBtn = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabControl1 = New MaterialSkin.Controls.MaterialTabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.WebControl3 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.signOutBtnPublic = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.lgnPassBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.lgnUsrBox = New MaterialSkin.Controls.MaterialSingleLineTextField()
        Me.signUpBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.signInBtn = New MaterialSkin.Controls.MaterialRaisedButton()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.keepSidebarOpenTick = New MaterialSkin.Controls.MaterialCheckBox()
        Me.keepChangeLogOpenOnUpdateChkBox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.EnableDevBtnToggle = New MaterialSkin.Controls.MaterialCheckBox()
        Me.SaveLoginDetailsBtn = New MaterialSkin.Controls.MaterialCheckBox()
        Me.keepLauncherOpenBox = New MaterialSkin.Controls.MaterialCheckBox()
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.frmPrgs = New System.Windows.Forms.TextBox()
        Me.WebControl2 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.WebControl1 = New Awesomium.Windows.Forms.WebControl(Me.components)
        Me.freezeWarning = New MaterialSkin.Controls.MaterialLabel()
        Me.MaterialFlatButton1 = New MaterialSkin.Controls.MaterialFlatButton()
        Me.MaterialTabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        Me.TabPage2.SuspendLayout()
        Me.TabPage3.SuspendLayout()
        Me.TabPage4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Download
        '
        '
        'Progress
        '
        Me.Progress.Interval = 50
        '
        'downloadProgressBar
        '
        Me.downloadProgressBar.Depth = 0
        Me.downloadProgressBar.Location = New System.Drawing.Point(12, 517)
        Me.downloadProgressBar.MouseState = MaterialSkin.MouseState.HOVER
        Me.downloadProgressBar.Name = "downloadProgressBar"
        Me.downloadProgressBar.Size = New System.Drawing.Size(1113, 5)
        Me.downloadProgressBar.TabIndex = 3
        '
        'playBtn
        '
        Me.playBtn.AutoSize = True
        Me.playBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.playBtn.Depth = 0
        Me.playBtn.Icon = Nothing
        Me.playBtn.Location = New System.Drawing.Point(12, 528)
        Me.playBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Primary = True
        Me.playBtn.Size = New System.Drawing.Size(58, 36)
        Me.playBtn.TabIndex = 4
        Me.playBtn.Text = "PLAY!"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'buildNumberNotifier
        '
        Me.buildNumberNotifier.AutoSize = True
        Me.buildNumberNotifier.Depth = 0
        Me.buildNumberNotifier.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.buildNumberNotifier.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.buildNumberNotifier.Location = New System.Drawing.Point(1072, 9)
        Me.buildNumberNotifier.MouseState = MaterialSkin.MouseState.HOVER
        Me.buildNumberNotifier.Name = "buildNumberNotifier"
        Me.buildNumberNotifier.Size = New System.Drawing.Size(53, 19)
        Me.buildNumberNotifier.TabIndex = 11
        Me.buildNumberNotifier.Text = "0.0.0.0"
        '
        'loginBtn
        '
        Me.loginBtn.AutoSize = True
        Me.loginBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.loginBtn.Depth = 0
        Me.loginBtn.Icon = Nothing
        Me.loginBtn.Location = New System.Drawing.Point(6, 4)
        Me.loginBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.loginBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.loginBtn.Name = "loginBtn"
        Me.loginBtn.Primary = False
        Me.loginBtn.Size = New System.Drawing.Size(126, 36)
        Me.loginBtn.TabIndex = 13
        Me.loginBtn.Text = "Login / Sign up"
        Me.loginBtn.UseVisualStyleBackColor = True
        '
        'newsBtn
        '
        Me.newsBtn.AutoSize = True
        Me.newsBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.newsBtn.Depth = 0
        Me.newsBtn.Icon = Nothing
        Me.newsBtn.Location = New System.Drawing.Point(140, 4)
        Me.newsBtn.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.newsBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.newsBtn.Name = "newsBtn"
        Me.newsBtn.Primary = False
        Me.newsBtn.Size = New System.Drawing.Size(59, 36)
        Me.newsBtn.TabIndex = 14
        Me.newsBtn.Text = "News"
        Me.newsBtn.UseVisualStyleBackColor = True
        '
        'MaterialTabControl1
        '
        Me.MaterialTabControl1.Controls.Add(Me.TabPage1)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage2)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage3)
        Me.MaterialTabControl1.Controls.Add(Me.TabPage4)
        Me.MaterialTabControl1.Depth = 0
        Me.MaterialTabControl1.Location = New System.Drawing.Point(-1, 46)
        Me.MaterialTabControl1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialTabControl1.Name = "MaterialTabControl1"
        Me.MaterialTabControl1.SelectedIndex = 0
        Me.MaterialTabControl1.Size = New System.Drawing.Size(1139, 465)
        Me.MaterialTabControl1.TabIndex = 15
        '
        'TabPage1
        '
        Me.TabPage1.BackColor = System.Drawing.Color.Gray
        Me.TabPage1.Controls.Add(Me.WebControl3)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(1131, 439)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "TabPage1"
        '
        'WebControl3
        '
        Me.WebControl3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl3.Location = New System.Drawing.Point(3, 3)
        Me.WebControl3.Size = New System.Drawing.Size(1125, 433)
        Me.WebControl3.Source = New System.Uri("https://example.com", System.UriKind.Absolute)
        Me.WebControl3.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.BackColor = System.Drawing.Color.Gray
        Me.TabPage2.Controls.Add(Me.signOutBtnPublic)
        Me.TabPage2.Controls.Add(Me.RichTextBox1)
        Me.TabPage2.Controls.Add(Me.lgnPassBox)
        Me.TabPage2.Controls.Add(Me.lgnUsrBox)
        Me.TabPage2.Controls.Add(Me.signUpBtn)
        Me.TabPage2.Controls.Add(Me.signInBtn)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(1131, 439)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "TabPage2"
        '
        'signOutBtnPublic
        '
        Me.signOutBtnPublic.AutoSize = True
        Me.signOutBtnPublic.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.signOutBtnPublic.Depth = 0
        Me.signOutBtnPublic.Icon = Nothing
        Me.signOutBtnPublic.Location = New System.Drawing.Point(1040, 397)
        Me.signOutBtnPublic.MouseState = MaterialSkin.MouseState.HOVER
        Me.signOutBtnPublic.Name = "signOutBtnPublic"
        Me.signOutBtnPublic.Primary = True
        Me.signOutBtnPublic.Size = New System.Drawing.Size(82, 36)
        Me.signOutBtnPublic.TabIndex = 5
        Me.signOutBtnPublic.Text = "Sign out"
        Me.signOutBtnPublic.UseVisualStyleBackColor = True
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BackColor = System.Drawing.Color.Gray
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.ForeColor = System.Drawing.Color.White
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 64)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(1113, 327)
        Me.RichTextBox1.TabIndex = 4
        Me.RichTextBox1.Text = "You can put extra information in this TextBox." & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(10) & "Such as rules, or just replace it" &
    " with a news WebBrowser, though you should probably use Awesomum based stuffs."
        '
        'lgnPassBox
        '
        Me.lgnPassBox.Depth = 0
        Me.lgnPassBox.Hint = ""
        Me.lgnPassBox.Location = New System.Drawing.Point(9, 35)
        Me.lgnPassBox.MaxLength = 32767
        Me.lgnPassBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.lgnPassBox.Name = "lgnPassBox"
        Me.lgnPassBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.lgnPassBox.SelectedText = ""
        Me.lgnPassBox.SelectionLength = 0
        Me.lgnPassBox.SelectionStart = 0
        Me.lgnPassBox.Size = New System.Drawing.Size(1113, 23)
        Me.lgnPassBox.TabIndex = 3
        Me.lgnPassBox.TabStop = False
        Me.lgnPassBox.Text = "Password"
        Me.lgnPassBox.UseSystemPasswordChar = False
        '
        'lgnUsrBox
        '
        Me.lgnUsrBox.Depth = 0
        Me.lgnUsrBox.Hint = ""
        Me.lgnUsrBox.Location = New System.Drawing.Point(9, 6)
        Me.lgnUsrBox.MaxLength = 32767
        Me.lgnUsrBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.lgnUsrBox.Name = "lgnUsrBox"
        Me.lgnUsrBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(0)
        Me.lgnUsrBox.SelectedText = ""
        Me.lgnUsrBox.SelectionLength = 0
        Me.lgnUsrBox.SelectionStart = 0
        Me.lgnUsrBox.Size = New System.Drawing.Size(1113, 23)
        Me.lgnUsrBox.TabIndex = 2
        Me.lgnUsrBox.TabStop = False
        Me.lgnUsrBox.Text = "Username"
        Me.lgnUsrBox.UseSystemPasswordChar = False
        '
        'signUpBtn
        '
        Me.signUpBtn.AutoSize = True
        Me.signUpBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.signUpBtn.Depth = 0
        Me.signUpBtn.Icon = Nothing
        Me.signUpBtn.Location = New System.Drawing.Point(1049, 397)
        Me.signUpBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.signUpBtn.Name = "signUpBtn"
        Me.signUpBtn.Primary = True
        Me.signUpBtn.Size = New System.Drawing.Size(73, 36)
        Me.signUpBtn.TabIndex = 1
        Me.signUpBtn.Text = "SIGN UP"
        Me.signUpBtn.UseVisualStyleBackColor = True
        '
        'signInBtn
        '
        Me.signInBtn.AutoSize = True
        Me.signInBtn.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.signInBtn.Depth = 0
        Me.signInBtn.Icon = Nothing
        Me.signInBtn.Location = New System.Drawing.Point(9, 397)
        Me.signInBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.signInBtn.Name = "signInBtn"
        Me.signInBtn.Primary = True
        Me.signInBtn.Size = New System.Drawing.Size(69, 36)
        Me.signInBtn.TabIndex = 0
        Me.signInBtn.Text = "SIGN IN"
        Me.signInBtn.UseVisualStyleBackColor = True
        '
        'TabPage3
        '
        Me.TabPage3.BackColor = System.Drawing.Color.Gray
        Me.TabPage3.Controls.Add(Me.keepSidebarOpenTick)
        Me.TabPage3.Controls.Add(Me.keepChangeLogOpenOnUpdateChkBox)
        Me.TabPage3.Controls.Add(Me.EnableDevBtnToggle)
        Me.TabPage3.Controls.Add(Me.SaveLoginDetailsBtn)
        Me.TabPage3.Controls.Add(Me.keepLauncherOpenBox)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(1131, 439)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "TabPage3"
        '
        'keepSidebarOpenTick
        '
        Me.keepSidebarOpenTick.AutoSize = True
        Me.keepSidebarOpenTick.Depth = 0
        Me.keepSidebarOpenTick.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.keepSidebarOpenTick.Location = New System.Drawing.Point(9, 105)
        Me.keepSidebarOpenTick.Margin = New System.Windows.Forms.Padding(0)
        Me.keepSidebarOpenTick.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.keepSidebarOpenTick.MouseState = MaterialSkin.MouseState.HOVER
        Me.keepSidebarOpenTick.Name = "keepSidebarOpenTick"
        Me.keepSidebarOpenTick.Ripple = True
        Me.keepSidebarOpenTick.Size = New System.Drawing.Size(251, 30)
        Me.keepSidebarOpenTick.TabIndex = 19
        Me.keepSidebarOpenTick.Text = "Keep Sidebar Open on Button Click?"
        Me.keepSidebarOpenTick.UseVisualStyleBackColor = True
        '
        'keepChangeLogOpenOnUpdateChkBox
        '
        Me.keepChangeLogOpenOnUpdateChkBox.AutoSize = True
        Me.keepChangeLogOpenOnUpdateChkBox.Depth = 0
        Me.keepChangeLogOpenOnUpdateChkBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.keepChangeLogOpenOnUpdateChkBox.Location = New System.Drawing.Point(9, 75)
        Me.keepChangeLogOpenOnUpdateChkBox.Margin = New System.Windows.Forms.Padding(0)
        Me.keepChangeLogOpenOnUpdateChkBox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.keepChangeLogOpenOnUpdateChkBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.keepChangeLogOpenOnUpdateChkBox.Name = "keepChangeLogOpenOnUpdateChkBox"
        Me.keepChangeLogOpenOnUpdateChkBox.Ripple = True
        Me.keepChangeLogOpenOnUpdateChkBox.Size = New System.Drawing.Size(177, 30)
        Me.keepChangeLogOpenOnUpdateChkBox.TabIndex = 18
        Me.keepChangeLogOpenOnUpdateChkBox.Text = "Keep Update Log Open?"
        Me.keepChangeLogOpenOnUpdateChkBox.UseVisualStyleBackColor = True
        '
        'EnableDevBtnToggle
        '
        Me.EnableDevBtnToggle.AutoSize = True
        Me.EnableDevBtnToggle.Depth = 0
        Me.EnableDevBtnToggle.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.EnableDevBtnToggle.Location = New System.Drawing.Point(10, 135)
        Me.EnableDevBtnToggle.Margin = New System.Windows.Forms.Padding(0)
        Me.EnableDevBtnToggle.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.EnableDevBtnToggle.MouseState = MaterialSkin.MouseState.HOVER
        Me.EnableDevBtnToggle.Name = "EnableDevBtnToggle"
        Me.EnableDevBtnToggle.Ripple = True
        Me.EnableDevBtnToggle.Size = New System.Drawing.Size(205, 30)
        Me.EnableDevBtnToggle.TabIndex = 1
        Me.EnableDevBtnToggle.Text = "Enable Developer Test Menu"
        Me.EnableDevBtnToggle.UseVisualStyleBackColor = True
        '
        'SaveLoginDetailsBtn
        '
        Me.SaveLoginDetailsBtn.AutoSize = True
        Me.SaveLoginDetailsBtn.Depth = 0
        Me.SaveLoginDetailsBtn.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.SaveLoginDetailsBtn.Location = New System.Drawing.Point(9, 15)
        Me.SaveLoginDetailsBtn.Margin = New System.Windows.Forms.Padding(0)
        Me.SaveLoginDetailsBtn.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.SaveLoginDetailsBtn.MouseState = MaterialSkin.MouseState.HOVER
        Me.SaveLoginDetailsBtn.Name = "SaveLoginDetailsBtn"
        Me.SaveLoginDetailsBtn.Ripple = True
        Me.SaveLoginDetailsBtn.Size = New System.Drawing.Size(178, 30)
        Me.SaveLoginDetailsBtn.TabIndex = 0
        Me.SaveLoginDetailsBtn.Text = "Save Login Credentials?"
        Me.SaveLoginDetailsBtn.UseVisualStyleBackColor = True
        '
        'keepLauncherOpenBox
        '
        Me.keepLauncherOpenBox.AutoSize = True
        Me.keepLauncherOpenBox.Depth = 0
        Me.keepLauncherOpenBox.Font = New System.Drawing.Font("Roboto", 10.0!)
        Me.keepLauncherOpenBox.Location = New System.Drawing.Point(9, 45)
        Me.keepLauncherOpenBox.Margin = New System.Windows.Forms.Padding(0)
        Me.keepLauncherOpenBox.MouseLocation = New System.Drawing.Point(-1, -1)
        Me.keepLauncherOpenBox.MouseState = MaterialSkin.MouseState.HOVER
        Me.keepLauncherOpenBox.Name = "keepLauncherOpenBox"
        Me.keepLauncherOpenBox.Ripple = True
        Me.keepLauncherOpenBox.Size = New System.Drawing.Size(164, 30)
        Me.keepLauncherOpenBox.TabIndex = 17
        Me.keepLauncherOpenBox.Text = "Keep Launcher Open?"
        Me.keepLauncherOpenBox.UseVisualStyleBackColor = True
        '
        'TabPage4
        '
        Me.TabPage4.Controls.Add(Me.frmPrgs)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage4.Size = New System.Drawing.Size(1131, 439)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "TabPage4"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'frmPrgs
        '
        Me.frmPrgs.Dock = System.Windows.Forms.DockStyle.Fill
        Me.frmPrgs.Location = New System.Drawing.Point(3, 3)
        Me.frmPrgs.Multiline = True
        Me.frmPrgs.Name = "frmPrgs"
        Me.frmPrgs.Size = New System.Drawing.Size(1125, 433)
        Me.frmPrgs.TabIndex = 0
        '
        'WebControl2
        '
        Me.WebControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.WebControl2.Location = New System.Drawing.Point(3, 3)
        Me.WebControl2.Size = New System.Drawing.Size(1125, 433)
        Me.WebControl2.Source = New System.Uri("https://example.com", System.UriKind.Absolute)
        Me.WebControl2.TabIndex = 0
        '
        'WebControl1
        '
        Me.WebControl1.Location = New System.Drawing.Point(0, 0)
        Me.WebControl1.Size = New System.Drawing.Size(1131, 439)
        Me.WebControl1.Source = New System.Uri("http://greenie.csxking.me/news/news.html", System.UriKind.Absolute)
        Me.WebControl1.TabIndex = 0
        '
        'freezeWarning
        '
        Me.freezeWarning.AutoSize = True
        Me.freezeWarning.Depth = 0
        Me.freezeWarning.Font = New System.Drawing.Font("Roboto", 11.0!)
        Me.freezeWarning.ForeColor = System.Drawing.Color.FromArgb(CType(CType(222, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.freezeWarning.Location = New System.Drawing.Point(691, 46)
        Me.freezeWarning.MouseState = MaterialSkin.MouseState.HOVER
        Me.freezeWarning.Name = "freezeWarning"
        Me.freezeWarning.Size = New System.Drawing.Size(88, 19)
        Me.freezeWarning.TabIndex = 16
        Me.freezeWarning.Text = "Extracting..."
        '
        'MaterialFlatButton1
        '
        Me.MaterialFlatButton1.AutoSize = True
        Me.MaterialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.MaterialFlatButton1.Depth = 0
        Me.MaterialFlatButton1.Icon = Nothing
        Me.MaterialFlatButton1.Location = New System.Drawing.Point(207, 4)
        Me.MaterialFlatButton1.Margin = New System.Windows.Forms.Padding(4, 6, 4, 6)
        Me.MaterialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER
        Me.MaterialFlatButton1.Name = "MaterialFlatButton1"
        Me.MaterialFlatButton1.Primary = False
        Me.MaterialFlatButton1.Size = New System.Drawing.Size(85, 36)
        Me.MaterialFlatButton1.TabIndex = 18
        Me.MaterialFlatButton1.Text = "Settings"
        Me.MaterialFlatButton1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1137, 575)
        Me.Controls.Add(Me.loginBtn)
        Me.Controls.Add(Me.newsBtn)
        Me.Controls.Add(Me.MaterialFlatButton1)
        Me.Controls.Add(Me.MaterialTabControl1)
        Me.Controls.Add(Me.buildNumberNotifier)
        Me.Controls.Add(Me.playBtn)
        Me.Controls.Add(Me.downloadProgressBar)
        Me.Controls.Add(Me.freezeWarning)
        Me.MaximumSize = New System.Drawing.Size(1153, 614)
        Me.MinimumSize = New System.Drawing.Size(1153, 614)
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GameLauncher_SQUIRREL_DEV_3"
        Me.MaterialTabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.TabPage2.ResumeLayout(False)
        Me.TabPage2.PerformLayout()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        Me.TabPage4.ResumeLayout(False)
        Me.TabPage4.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Download As System.ComponentModel.BackgroundWorker
    Friend WithEvents Progress As Timer
    Friend WithEvents downloadProgressBar As MaterialSkin.Controls.MaterialProgressBar
    Friend WithEvents playBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents buildNumberNotifier As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents loginBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents newsBtn As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents MaterialTabControl1 As MaterialSkin.Controls.MaterialTabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents signInBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents signUpBtn As MaterialSkin.Controls.MaterialRaisedButton
    Friend WithEvents lgnUsrBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents lgnPassBox As MaterialSkin.Controls.MaterialSingleLineTextField
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents freezeWarning As MaterialSkin.Controls.MaterialLabel
    Friend WithEvents keepLauncherOpenBox As MaterialSkin.Controls.MaterialCheckBox
    Private WithEvents WebControl1 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents MaterialFlatButton1 As MaterialSkin.Controls.MaterialFlatButton
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents SaveLoginDetailsBtn As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents EnableDevBtnToggle As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents frmPrgs As TextBox
    Friend WithEvents keepChangeLogOpenOnUpdateChkBox As MaterialSkin.Controls.MaterialCheckBox
    Friend WithEvents signOutBtnPublic As MaterialSkin.Controls.MaterialRaisedButton
    Private WithEvents WebControl2 As Awesomium.Windows.Forms.WebControl
    Private WithEvents WebControl3 As Awesomium.Windows.Forms.WebControl
    Friend WithEvents keepSidebarOpenTick As MaterialSkin.Controls.MaterialCheckBox
End Class
