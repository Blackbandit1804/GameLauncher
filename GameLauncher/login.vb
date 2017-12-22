Imports MySql.Data.MySqlClient
Imports System.Security.Cryptography
Public Class login

    Dim server As String = "Server Address (IP or DOMAIN):PORT"
    Dim user As String = "MySQL USERNAME"
    Dim passwd As String = "MySQL PASSWD"
    Dim db As String = "MySQL Database to Use"

    Public Sub login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        userBox.Text = "Username"
        passBox.Text = "Password"
        MaximizeBox = False
        MinimizeBox = False
    End Sub

    Function generateCredentials()
        attemptSignIn()
    End Function

    Function attemptSignInUsingSaved()
        Me.Hide()
        Form1.playBtn.BackColor = Color.Orange
        Form1.playBtn.Enabled = False
        Form1.playBtn.Text = "Signing in..."
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
                Form1.playBtn.Enabled = True
                Form1.playBtn.BackColor = Color.Green
                Form1.playBtn.Text = "PLAY! (Signed in as: " + My.Settings.user + ")"
                Form1.game()
                Form1.loginBtn.Text = "Switch account"
                Form1.signUpBtn.Hide()
                Form1.signOutBtnPublic.Show()
                Form1.signInBtn.Text = "Switch Account"
            ElseIf count > 1 Then
                ' If dupe?
            Else
                ' If incorrect
                MessageBox.Show("Invalid username or password. Please try again.")
                My.Settings.user = ""
                My.Settings.hash = ""
                My.Settings.Save()
                Form1.playBtn.Enabled = False
                Form1.playBtn.BackColor = Color.DarkRed
                Form1.playBtn.Text = "Please log in to continue."
                Form1.loginBtn.Text = "Sign in / Sign up"
            End If
            mydbcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mydbcon.Dispose()
        End Try

    End Function

    Function attemptSignIn()
        Form1.playBtn.BackColor = Color.Orange
        Form1.playBtn.Enabled = False
        Form1.playBtn.Text = "Signing in..."
        Me.Hide()
        Dim username As String = Form1.lgnUsrBox.Text
        Dim passhash As String = SHA256(Form1.lgnPassBox.Text)
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
                Form1.playBtn.Enabled = True
                Form1.playBtn.BackColor = Color.Green
                Form1.playBtn.Text = "PLAY! (Signed in as: " + My.Settings.user + ")"
                Form1.game()
                Form1.loginBtn.Text = "Switch account"
                Form1.MaterialTabControl1.SelectedTab = Form1.TabPage1
                Form1.signUpBtn.Hide()
                Form1.signOutBtnPublic.Show()
                Form1.signInBtn.Text = "Switch Account"
                Me.Hide()
            ElseIf count > 1 Then
                ' If dupe?
            Else
                ' If incorrect
                MessageBox.Show("Invalid username or password. Please try again.")
                My.Settings.user = ""
                My.Settings.hash = ""
                My.Settings.Save()
                Form1.playBtn.Enabled = False
                Form1.playBtn.BackColor = Color.DarkRed
                Form1.playBtn.Text = "Please log in to continue."
                Form1.loginBtn.Text = "Sign in / Sign up"
                Me.Hide()
            End If
            mydbcon.Close()
        Catch ex As MySqlException
            MessageBox.Show(ex.Message)
        Finally
            mydbcon.Dispose()
        End Try

    End Function

    Private Sub loginBtn_Click(sender As Object, e As EventArgs) Handles loginBtn.Click
        generateCredentials()
    End Sub

    Private Function SHA256(ByVal Content As String) As String
        Dim MoLeCuL3 As New Security.Cryptography.SHA256CryptoServiceProvider
        Dim ByteString() As Byte = System.Text.Encoding.ASCII.GetBytes(Content)
        ByteString = MoLeCuL3.ComputeHash(ByteString)

        Dim FinalString As String = Nothing
        For Each bt As Byte In ByteString
            FinalString &= bt.ToString("x2")
        Next
        Return FinalString
    End Function

    Private Sub signUpBtn_Click(sender As Object, e As EventArgs)
        signUp.Show()
    End Sub

    Private Sub MaterialSingleLineTextField1_Click(sender As Object, e As EventArgs) Handles userBox.Click
        userBox.Text = ""
    End Sub

    Private Sub passBox_Click(sender As Object, e As EventArgs) Handles passBox.Click
        passBox.Text = ""
    End Sub
End Class