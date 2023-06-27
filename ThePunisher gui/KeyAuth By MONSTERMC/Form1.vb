Imports System
Imports System.Net
Imports System.Threading
Imports KeyAuth_By_MONSTERMC.KeyAuth

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        LoadFormCode()
    End Sub
#Region "KeyAuth"
    Public Shared KeyAuthApp As New api(name:="App Name", ownerid:="ownerid her", secret:="your secret", version:="1.0")
    Public Sub LoadFormCode()
        KeyAuthApp.init()

        If KeyAuthApp.response.message = "invalidver" Then
            If Not String.IsNullOrEmpty(KeyAuthApp.app_data.downloadLink) Then

                Dim dialogResult_Renamed As DialogResult = MessageBox.Show("Yes to open file in browser" & ControlChars.Lf & "No to download file automatically", "Auto update", MessageBoxButtons.YesNo)
                Select Case dialogResult_Renamed
                    Case System.Windows.Forms.DialogResult.Yes
                        Process.Start(KeyAuthApp.app_data.downloadLink)
                        Environment.Exit(0)
                    Case System.Windows.Forms.DialogResult.No
                        Dim webClient As New WebClient()
                        Dim destFile As String = Application.ExecutablePath

                        Dim rand As String = random_string()

                        destFile = destFile.Replace(".exe", $"-{rand}.exe")
                        webClient.DownloadFile(KeyAuthApp.app_data.downloadLink, destFile)

                        Process.Start(destFile)
                        Process.Start(New ProcessStartInfo() With {.Arguments = "/C choice /C Y /N /D Y /T 3 & Del """ & Application.ExecutablePath & """", .WindowStyle = ProcessWindowStyle.Hidden, .CreateNoWindow = True, .FileName = "cmd.exe"})
                        Environment.Exit(0)

                    Case Else
                        MessageBox.Show("Invalid option")
                        Environment.Exit(0)
                End Select
            End If
            MessageBox.Show("Version of this program does not match the one online. Furthermore, the download link online isn't set. You will need to manually obtain the download link from the developer")
            Thread.Sleep(2500)
            Environment.Exit(0)
        End If

        If Not KeyAuthApp.response.success Then
            MessageBox.Show(KeyAuthApp.response.message)
            Environment.Exit(0)
        End If
        ' if(KeyAuthApp.checkblack())
        ' {
        '     MessageBox.Show("user is blacklisted");
        ' }
        ' else
        ' {
        '     MessageBox.Show("user is not blacklisted");
        ' }
        KeyAuthApp.check()
        Guna2HtmlLabel2.Text = $"Current Session Validation Status: {KeyAuthApp.response.success}"

    End Sub
    Private Shared Function random_string() As String
        Dim str As String = Nothing

        Dim random As New Random()
        For i As Integer = 0 To 4
            str &= Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString()
        Next i
        Return str

    End Function
    Private Sub Guna2ImageButton1_Click(sender As Object, e As EventArgs) Handles Guna2ImageButton1.Click
        My.Computer.Audio.Play(My.Resources.click_one, AudioPlayMode.Background)
        KeyAuthApp.license(Guna2TextBox1.Text)
        If KeyAuthApp.response.success Then
            '
            Dim main_Renamed As New mainform()
            main_Renamed.Show()
            Me.Hide()
        Else
            Guna2HtmlLabel2.Text = "Status: " & KeyAuthApp.response.message
        End If
    End Sub

    Private Sub Guna2ControlBox1_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox1.Click
        My.Computer.Audio.Play(My.Resources.click_one, AudioPlayMode.Background)
        End
    End Sub

    Private Sub Guna2ControlBox2_Click(sender As Object, e As EventArgs) Handles Guna2ControlBox2.Click
        My.Computer.Audio.Play(My.Resources.click_one, AudioPlayMode.Background)
    End Sub
#End Region
End Class
