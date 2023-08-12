Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Diagnostics
Imports System.Drawing
Imports System.Linq
Imports System.Management
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports EncryptAndDecrypt

Namespace KeyAuth
	Partial Public Class Login
		Inherits Form

		'        
		'        * 
		'        * WATCH THIS VIDEO TO SETUP APPLICATION: https://youtube.com/watch?v=RfDTdiBq4_o
		'        * 
		'        

		'        
		'Optional Functions:
		'
		'KeyAuthApp.webhook("lfvbBrbFhIr", "?sellerkey=CUqDqlCIgl&type=resethash");
		'// send secure request to webhook which is impossible to crack into. the base link set on the website is https://keyauth.com/api/seller/, which nobody except you can see, so the final request is https://keyauth.com/api/seller/?sellerkey=CUqDqlCIgl&type=resethash
		'
		'// byte[] result = KeyAuthApp.download("902901"); // downloads application file
		'// File.WriteAllBytes("C:\\Users\\mak\\Downloads\\KeyAuth-CSHARP-Example-main (5)\\KeyAuth-CSHARP-Example-main\\ConsoleExample\\bin\\Debug\\countkeys.txt", result);
		'
		'MessageBox.Show(KeyAuthApp.var("123456")); // retrieve application variable
		'

		' KeyAuthApp.register("username", "password", "key");
		'KeyAuthApp.login("username", "password"); 
		Dim Encrypt As New EncryptAndDecrypt.Encrypt_String_By_MONSTERMC

		Public Shared KeyAuthApp As New api(name:="APP Name From Panel أسم الأبلكيشن الذي انشئته في البانيل", ownerid:="الأيدي الخاص بك في البانيل", secret:="سيكرت الخاص بك في البانيل يكون تحت اسم الأبلكيشن الذي انشائته", version:="1.0")

		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub siticoneControlBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneControlBox1.Click
			Environment.Exit(0)
		End Sub

		Private Sub Login_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
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
			siticoneLabel1.Text = $"Current Session Validation Status: {KeyAuthApp.response.success}"
		End Sub

		Private Shared Function random_string() As String
			Dim str As String = Nothing

			Dim random As New Random()
			For i As Integer = 0 To 4
				str &= Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65))).ToString()
			Next i
			Return str

		End Function

		Private Sub UpgradeBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles UpgradeBtn.Click
			KeyAuthApp.upgrade(username.Text, key.Text) ' success is set to false so people can't press upgrade then press login and skip logging in. it doesn't matter, since you shouldn't take any action on succesfull upgrade anyways. the only thing that needs to be done is the user needs to see the message from upgrade function
			status.Text = "Status: " & KeyAuthApp.response.message
			' don't login, because they haven't authenticated. this is just to extend expiry of user with new key.
		End Sub

		Private Sub LoginBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LoginBtn.Click
			KeyAuthApp.login(username.Text,password.Text)
			If KeyAuthApp.response.success Then
				'
				Dim main_Renamed As New Main()
				main_Renamed.Show()
				Me.Hide()
			Else
				status.Text = "Status: " & KeyAuthApp.response.message
			End If
		End Sub

		Private Sub RgstrBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles RgstrBtn.Click
			KeyAuthApp.register(username.Text, password.Text, key.Text)
			If KeyAuthApp.response.success Then
				'
				Dim main_Renamed As New Main()
				main_Renamed.Show()
				Me.Hide()
			Else
				status.Text = "Status: " & KeyAuthApp.response.message
			End If
		End Sub

		Private Sub LicBtn_Click(ByVal sender As Object, ByVal e As EventArgs) Handles LicBtn.Click
			KeyAuthApp.license(key.Text)
			If KeyAuthApp.response.success Then
				'
				Dim main_Renamed As New Main()
				main_Renamed.Show()
				Me.Hide()
			Else
				status.Text = "Status: " & KeyAuthApp.response.message
			End If
		End Sub
	End Class
End Namespace
