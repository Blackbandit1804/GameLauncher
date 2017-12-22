Public Class DevMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        My.Settings.user = ""
        My.Settings.hash = ""
        My.Settings.Save()
        Form1.playBtn.Enabled = False
        Form1.playBtn.BackColor = Color.DarkRed
        Form1.playBtn.Text = "Please log in to continue."
        Form1.loginBtn.Text = "Sign in / Sign up"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Process.Start(Environment.CurrentDirectory)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim isDeveloper As String
        If My.Application.CommandLineArgs.Count = 1 Then
            IsDeveloper = My.Application.CommandLineArgs(0)
        End If
        Form1.frmPrgs.AppendText("DEVELOPER UPDATE INITATED! (3)" & Environment.NewLine & "DEV_KEY: " + isDeveloper & Environment.NewLine)
        Form1.GameDev()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form1.playBtn.Enabled = True
        Form1.playBtn.BackColor = Color.Green
    End Sub

    Private Sub MaterialRaisedButton1_Click(sender As Object, e As EventArgs) Handles MaterialRaisedButton1.Click
        MaterialLabel1.Text = "My.settings.keepKeepLauncherOpen = " + My.Settings.keepLauncherOpen
        devmenuSaveLoginCredentials.Text = "SaveLoginCredentials = " + My.Settings.saveLoginDetails
        If Form1.keepLauncherOpenBox.Checked Then
            MaterialLabel2.Text = "Form1.keepLauncherOpenBox = True"
        Else
            MaterialLabel2.Text = "Form1.keepLauncherOpenBox = False"
        End If
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Console.Show()
    End Sub
End Class