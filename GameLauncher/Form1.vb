Imports System.ComponentModel
Imports System.IO
Imports System.Net
Imports ComponentAce.Compression.Archiver
Imports ComponentAce.Compression.ZipForge
Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography

Public Class Form1
    ' Variables
    Dim DownloadUrl As String = "https://example.com/latest.zip" ' Latest remote build of the game. Should always contain the full game within it, else updates and installations could fail.
    Dim remoteBuildFile As String = "https://example.com/version.txt" ' Remote version file. Lets us check for updates.
    Dim ThisLocation As String = Environment.CurrentDirectory ' This defines the current directory, in other words, the installation location of the launcher, and therefor, the game.
    Dim DownloadFileName As String = "update.zip" ' The name you want to name the .zip file download to be.
    Dim ExecutableName As String = "Test.exe" ' The name of the executable file for the application in question. Must be the main one to run the application.
    Dim allowSignUp As String = False ' Allow sign up? (Disabled mostly because its not ready yet ;p)
    Dim sideMenuIsHidden As String = "True"

    ' Database Connection Information
    Dim server As String = "Server Address (IP or DOMAIN):PORT"
    Dim user As String = "MySQL USERNAME"
    Dim passwd As String = "MySQL PASSWD"
    Dim db As String = "MySQL Database to Use"
    ' End Database Connection Information

    Dim value As System.Collections.ObjectModel.ReadOnlyCollection(Of String) = My.Application.CommandLineArgs
    Public ReadOnly Property CommandLineArgs As System.Collections.ObjectModel.ReadOnlyCollection(Of String)

    Dim IsDeveloper As String
    Public Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        SideMenuPanel.Hide()
        SideMenuPanel.BringToFront()
        sideMenuBtn.BringToFront()
        sideMenuIsHidden = "True"
        Me.Refresh()
        signOutBtnPublic.Hide()
        frmPrgs.ReadOnly = True
        If allowSignUp = True Then
            signUpBtn.Visible = True
        Else
            signUpBtn.Visible = False
        End If
        If My.Settings.keepLauncherOpen = "True" Then
            keepLauncherOpenBox.Checked = 1
        Else
            keepLauncherOpenBox.Checked = 0
        End If
        If My.Settings.keepLogOpenAfterUpdate = "True" Then
            keepChangeLogOpenOnUpdateChkBox.Checked = 1
        Else
            keepChangeLogOpenOnUpdateChkBox.Checked = 0
        End If
        If My.Settings.saveLoginDetails = "True" Then
            SaveLoginDetailsBtn.Checked = 1
        Else
            SaveLoginDetailsBtn.Checked = 0
        End If
        If My.Settings.hideSidePanelOnMenuOptionClick = True Then
            ' Do nothing
        Else
            keepSidebarOpenTick.Checked = 1
        End If
        ' Pre-Startup -- Make sure the version file exists, as if it doesn't, the application crashes.
        ' If it doesn't exist, we create it, and set it to 0.0.0.0. This will also allow for emergency
        ' reinstalls of the game client without deleting the launcher and/or user settings, potentially,
        ' as when an update is installed, it overwrites all current files, no matter the circumstance.
        If Not System.IO.File.Exists("version") Then
            Using writer As New StreamWriter(ThisLocation + "\version", True)
                writer.WriteLine("0.0.0.0")
            End Using
        End If
        Dim currentBuild As String = My.Computer.FileSystem.ReadAllText("version")
        ' Startup

        MaximizeBox = False
        'downloadLabel.Hide()
        freezeWarning.Hide()
        playBtn.Enabled = False
        playBtn.BackColor = Color.DarkRed
        playBtn.Text = "..."
        Threading.Thread.Sleep(1000)
        buildNumberNotifier.Text = currentBuild

        If My.Settings.user = "" Then
            playBtn.Enabled = False
            playBtn.BackColor = Color.DarkRed
            playBtn.Text = "Please log in to continue."
        End If
        If Not My.Settings.user = "" Then
            If Not My.Settings.hash = "" Then
                playBtn.BackColor = Color.Orange
                playBtn.Enabled = False
                playBtn.Text = "Signing in..."
                attemptSignInUsingSaved()
            End If
        End If

    End Sub

    ' Functions for login and signup. Moved straight from login.vb in preperation to remove it.

    Function generateCredentials()
        attemptSignIn()
    End Function

    Function attemptSignInUsingSaved()
        Me.Hide()
        playBtn.BackColor = Color.Orange
        playBtn.Enabled = False
        playBtn.Text = "Signing in..."
        Dim username As String = My.Settings.user
        Dim passhash As String = My.Settings.hash
        Dim mydbcon As MySqlConnection
        Dim COMMAND As MySqlCommand
        ' The function which handles signing the user into their account in the database.
        mydbcon = New MySqlConnection
        Dim ConnString As String = "server=" + server + ";userid=" + user + ";password=" + passwd + ";database=" + db
        'mydbcon.ConnectionString = "server=ssh.csxking.me;userid=csxking;password=maxelis2;database=greenie"
        mydbcon.ConnectionString = ConnString
        Dim reader As MySqlDataReader

        Try
            mydbcon.Open()
            Dim Query As String
            Query = String.Format("SELECT * FROM accounts WHERE username = '{0}' AND passhash = '{1}'", username.Trim(), passhash.Trim())
            COMMAND = New MySqlCommand(Query, mydbcon)
            reader = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While

            If count = 1 Then
                ' If correct
                playBtn.Enabled = True
                playBtn.BackColor = Color.Green
                playBtn.Text = "PLAY! (Signed in as: " + My.Settings.user + ")"
                usrTxt.Text = "Welcome, " + My.Settings.user
                game()
                loginBtn.Text = "Switch account"
                signUpBtn.Hide()
                signOutBtnPublic.Show()
                signInBtn.Text = "Switch Account"
            ElseIf count > 1 Then
                ' If dupe?
            Else
                ' If incorrect
                MessageBox.Show("Invalid username or password. Please try again.")
                My.Settings.user = ""
                My.Settings.hash = ""
                My.Settings.Save()
                playBtn.Enabled = False
                playBtn.BackColor = Color.DarkRed
                playBtn.Text = "Please log in to continue."
                loginBtn.Text = "Sign in / Sign up"
            End If
            mydbcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mydbcon.Dispose()
        End Try

    End Function

    Function attemptSignIn()
        playBtn.BackColor = Color.Orange
        playBtn.Enabled = False
        playBtn.Text = "Signing in..."
        Me.Hide()
        Dim username As String = lgnUsrBox.Text
        Dim passhash As String = SHA256(lgnPassBox.Text)
        Dim mydbcon As MySqlConnection
        Dim COMMAND As MySqlCommand
        ' The function which handles signing the user into their account in the database.
        mydbcon = New MySqlConnection
        Dim ConnString As String = "server=" + server + ";userid=" + user + ";password=" + passwd + ";database=" + db
        mydbcon.ConnectionString = ConnString
        Dim reader As MySqlDataReader

        Try
            mydbcon.Open()
            Dim Query As String
            Query = String.Format("SELECT * FROM accounts WHERE username = '{0}' AND passhash = '{1}'", username.Trim(), passhash.Trim())
            COMMAND = New MySqlCommand(Query, mydbcon)
            reader = COMMAND.ExecuteReader

            Dim count As Integer
            count = 0
            While reader.Read
                count = count + 1

            End While
            If count = 1 Then
                ' If correct
                My.Settings.user = username
                My.Settings.hash = passhash
                My.Settings.Save()
                playBtn.Enabled = True
                playBtn.BackColor = Color.Green
                playBtn.Text = "PLAY! (Signed in as: " + My.Settings.user + ")"
                usrTxt.Text = "Welcome, " + My.Settings.user
                game()
                loginBtn.Text = "Switch account"
                MaterialTabControl1.SelectedTab = TabPage1
                signUpBtn.Hide()
                signOutBtnPublic.Show()
                signInBtn.Text = "Switch Account"
                Me.Hide()
            ElseIf count > 1 Then
                ' If dupe?
            Else
                ' If incorrect
                MessageBox.Show("Invalid username or password. Please try again.")
                My.Settings.user = ""
                My.Settings.hash = ""
                My.Settings.Save()
                playBtn.Enabled = False
                playBtn.BackColor = Color.DarkRed
                playBtn.Text = "Please log in to continue."
                loginBtn.Text = "Sign in / Sign up"
                Me.Hide()
            End If
            mydbcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mydbcon.Dispose()
        End Try

    End Function

    Private Function SHA256(ByVal Content As String) As String
        Dim MoLeCuL3 As New System.Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MoLeCuL3.ComputeHash(ByteString)

        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString
    End Function

    ' End login.vb functions

    Function GameDev()
        playBtn.Text = "Installing update..."
        playBtn.Enabled = False
        playBtn.BackColor = Color.Orange
        freezeWarning.Hide()
        ' Download update zip
        Dim req As System.Net.WebRequest
        Dim resp As System.Net.WebResponse
        req = Net.WebRequest.Create(DownloadUrl)
        resp = req.GetResponse
        req.Method = Net.WebRequestMethods.Http.Get
        download_size = resp.ContentLength
        downloadProgressBar.Maximum = download_size
        Download.RunWorkerAsync()
        Progress.Start()
    End Function

    Function sidePanelBtnClick()
        If My.Settings.hideSidePanelOnMenuOptionClick = "True" Then
            sideMenuIsHidden = "True"
            SideMenuPanel.Hide()
        Else
        End If
    End Function

    Function game()
        ' One complete, define the version.
        Dim currentBuild As String = My.Computer.FileSystem.ReadAllText("version")
        Dim wc As New WebClient
        Dim remoteBuild As String = wc.DownloadString(remoteBuildFile)
        frmPrgs.AppendText("CHECKING FOR UPDATES......" & Environment.NewLine)
        ' Check if the current version is the latest or not
        If currentBuild < remoteBuild Then
            ' If out of date
            playBtn.Text = "Installing update..."
            MaterialTabControl1.SelectedTab = TabPage4
            frmPrgs.AppendText("NEW UPDATE FOUND! OLD VERSION: " + currentBuild + "NEW VERSION: " + remoteBuild & Environment.NewLine)
            playBtn.Enabled = False
            playBtn.BackColor = Color.Orange
            freezeWarning.Hide()
            ' Download update zip
            Dim req As System.Net.WebRequest
            Dim resp As System.Net.WebResponse
            frmPrgs.AppendText("DOWNLOADING UPDATE ZIP" & Environment.NewLine)
            req = Net.WebRequest.Create(DownloadUrl)
            resp = req.GetResponse
            req.Method = Net.WebRequestMethods.Http.Get
            download_size = resp.ContentLength
            downloadProgressBar.Maximum = download_size
            Download.RunWorkerAsync()
            Progress.Start()
        Else
            ' If not out of date
            playBtn.Text = "PLAY! (Signed in as: " + My.Settings.user + ")"
            playBtn.Enabled = True
            playBtn.BackColor = Color.Green

        End If
    End Function

    Dim download_size As Long
    Dim downloaded_size As Long
    Public Sub BackgroundWorker1_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Download.DoWork

        My.Computer.Network.DownloadFile(DownloadUrl, ThisLocation + "\" + DownloadFileName, "", "", False, 360000, True)

    End Sub

    Function finishInstall()
        If My.Settings.user = "" Then
            playBtn.Enabled = False
            playBtn.BackColor = Color.DarkRed
            playBtn.Text = "Please log in to continue."
        End If
        If Not My.Settings.user = "" Then
            If Not My.Settings.hash = "" Then
                playBtn.BackColor = Color.Orange
                playBtn.Enabled = False
                playBtn.Text = "Signing in..."
                attemptSignInUsingSaved()
            End If
        End If
        Dim newBuildNum As String = My.Computer.FileSystem.ReadAllText("version")
        buildNumberNotifier.Text = newBuildNum
        freezeWarning.Hide()
        frmPrgs.AppendText("UPDATE INSTALLED SUCCESSFULLY! (0) NEW VERSION #: " + newBuildNum & Environment.NewLine)
        If (Not System.IO.Directory.Exists(ThisLocation + "\Logs")) Then
            System.IO.Directory.CreateDirectory(ThisLocation + "\Logs")
        End If
        If File.Exists(ThisLocation + "\Logs\latest_update.log") Then
            My.Computer.FileSystem.DeleteFile(ThisLocation + "\Logs\latest_update.log")
            My.Computer.FileSystem.WriteAllText(ThisLocation + "\Logs\latest_update.log", frmPrgs.Text, False)
        Else
            My.Computer.FileSystem.WriteAllText(ThisLocation + "\Logs\latest_update.log", frmPrgs.Text, False)
        End If

        If My.Settings.keepLogOpenAfterUpdate Then
            frmPrgs.AppendText("(Update log left open based on users settings)")
        Else
            MaterialTabControl1.SelectedTab = TabPage1
        End If
    End Function

    Dim WithEvents archiver As ZipForge = New ZipForge()

    Function installUpdate()
        playBtn.Text = "Installing update..."
        MaterialTabControl1.SelectedTab = TabPage4
        frmPrgs.AppendText("EXTRACTING UPDATE... DO NOT CLOSE THE LAUNCHER." & Environment.NewLine)
        Threading.Thread.Sleep(750)
        playBtn.Enabled = False
        playBtn.BackColor = Color.Orange
        Threading.Thread.Sleep(500)
        Dim startpath As String = ThisLocation
        Dim zipPath As String = ThisLocation + "\" + DownloadFileName
        Dim extractPath As String = ThisLocation + "\bin"
        If (Not System.IO.Directory.Exists(ThisLocation + "\bin")) Then
            System.IO.Directory.CreateDirectory(ThisLocation + "\bin")
        End If
        archiver.FileName = zipPath
        archiver.OpenArchive(System.IO.FileMode.Open)
        archiver.BaseDir = extractPath
        archiver.ExtractFiles("*.*")
        Threading.Thread.Sleep(1000)
        archiver.CloseArchive()
        My.Computer.FileSystem.DeleteFile(ThisLocation + "\version")
        Dim ws As New WebClient
        Dim NewVersion As String = ws.DownloadString(remoteBuildFile)
        Using writer As New StreamWriter(ThisLocation + "\version", True)
            writer.WriteLine(NewVersion)
        End Using
        My.Computer.FileSystem.DeleteFile(ThisLocation + "\" + DownloadFileName)
        Threading.Thread.Sleep(1000)
        archiver.CloseArchive()
        finishInstall()

    End Function

    Sub archiver_OnFileProgress(ByVal sender As Object, ByVal fileName As String, ByVal progress As Double, ByVal timeElapsed As TimeSpan, ByVal timeLeft As TimeSpan, ByVal operation As ProcessOperation, ByVal progressPhase As ProgressPhase, ByRef cancel As Boolean) Handles archiver.OnFileProgress
        'textBox.AppendText("your new text" & Environment.NewLine)
        frmPrgs.AppendText("Extracting file: " + fileName + "... Progress: " + progress.ToString + "%" & Environment.NewLine)
        Console.consoleBox.AppendText("Processing {0}, {1}" + progress.ToString + "% complete, time left: {2}" + fileName + progress.ToString("f2") + " " + timeLeft.ToString & Environment.NewLine)
    End Sub

    Private Sub Progress_Tick(sender As Object, e As EventArgs) Handles Progress.Tick
        If downloaded_size >= download_size Then
            playBtn.Text = "Installing update..."
            playBtn.Enabled = False
            playBtn.BackColor = Color.Orange
            Threading.Thread.Sleep(1000)
            Progress.Stop()
            Threading.Thread.Sleep(1000)
            installUpdate()
        Else
            downloaded_size = My.Computer.FileSystem.GetFileInfo(ThisLocation + "\" + DownloadFileName).Length
            downloadProgressBar.Value = downloaded_size
        End If
    End Sub

    Private Sub playBtn_Click(sender As Object, e As EventArgs)
        Process.Start("bin\" + ExecutableName)
    End Sub

    Private Sub MaterialProgressBar1_Click(sender As Object, e As EventArgs) Handles downloadProgressBar.Click

    End Sub

    Private Sub playBtn_Click_1(sender As Object, e As EventArgs) Handles playBtn.Click
        If keepLauncherOpenBox.Checked Then
            Process.Start("bin\" + ExecutableName)
        Else
            Process.Start("bin\" + ExecutableName)
            Me.Close()
        End If
    End Sub

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        MaterialTabControl1.SelectedTab = TabPage2
        sidePanelBtnClick()
    End Sub

    Private Sub newsBtn_Click(sender As Object, e As EventArgs) Handles newsBtn.Click
        MaterialTabControl1.SelectedTab = TabPage1
        sidePanelBtnClick()
    End Sub

    Private Sub lgnUsrBox_Click(sender As Object, e As EventArgs) Handles lgnUsrBox.Click
        lgnUsrBox.Text = ""
    End Sub

    Private Sub lgnPassBox_Click(sender As Object, e As EventArgs) Handles lgnPassBox.Click
        lgnPassBox.Text = ""
    End Sub

    Private Sub keepLauncherOpenBox_CheckedChanged(sender As Object, e As EventArgs) Handles keepLauncherOpenBox.CheckedChanged
        If keepLauncherOpenBox.Checked = True Then
            My.Settings.keepLauncherOpen = "True"
            My.Settings.Save()
        Else
            My.Settings.keepLauncherOpen = "False"
            My.Settings.Save()
        End If
    End Sub

    Private Sub MaterialFlatButton1_Click(sender As Object, e As EventArgs) Handles MaterialFlatButton1.Click
        MaterialTabControl1.SelectedTab = TabPage3
        sidePanelBtnClick()
    End Sub

    Private Sub MaterialCheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles SaveLoginDetailsBtn.CheckedChanged
        If SaveLoginDetailsBtn.Checked = True Then
            My.Settings.saveLoginDetails = "True"
            My.Settings.Save()
        Else
            My.Settings.saveLoginDetails = "False"
            My.Settings.Save()
        End If
    End Sub

    Private Sub keepChangeLogOpenOnUpdateChkBox_CheckedChanged(sender As Object, e As EventArgs) Handles keepChangeLogOpenOnUpdateChkBox.CheckedChanged
        If keepChangeLogOpenOnUpdateChkBox.Checked = True Then
            My.Settings.keepLogOpenAfterUpdate = "True"
            My.Settings.Save()
        Else
            My.Settings.keepLogOpenAfterUpdate = "False"
            My.Settings.Save()
        End If
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        If My.Settings.saveLoginDetails = True Then
            ' If saving login details
        Else
            My.Settings.user = ""
            My.Settings.hash = ""
            My.Settings.Save()
        End If
    End Sub

    Function signOut()
        My.Settings.user = ""
        My.Settings.hash = ""
        My.Settings.Save()
        playBtn.Enabled = False
        playBtn.BackColor = Color.DarkRed
        playBtn.Text = "Please log in to continue."
        loginBtn.Text = "Sign in / Sign up"
        loginBtn.Show()
        If allowSignUp = True Then
            signUpBtn.Show()
        End If
        signInBtn.Text = "Log in"
        signOutBtnPublic.Hide()
        MaterialTabControl1.SelectedTab = TabPage1
    End Function

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles signOutBtnPublic.Click
        signOut()
    End Sub

    Private Sub sideMenuBtn_Click(sender As Object, e As EventArgs) Handles sideMenuBtn.Click
        If sideMenuIsHidden = "False" Then
            SideMenuPanel.Hide()
            sideMenuIsHidden = "True"
        Else
            sideMenuIsHidden = "False"
            SideMenuPanel.Show()
        End If
    End Sub

    Private Sub keepSidebarOpenTick_CheckedChanged(sender As Object, e As EventArgs) Handles keepSidebarOpenTick.CheckedChanged
        If keepSidebarOpenTick.Checked = True Then
            My.Settings.hideSidePanelOnMenuOptionClick = False
            My.Settings.Save()
        Else
            My.Settings.hideSidePanelOnMenuOptionClick = True
            My.Settings.Save()
        End If
    End Sub
End Class
