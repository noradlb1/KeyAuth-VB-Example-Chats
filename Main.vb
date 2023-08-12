Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.IO
Imports System.Linq
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports EncryptAndDecrypt

Namespace KeyAuth
	Partial Public Class Main
		Inherits Form

		Public Sub New()
			InitializeComponent()
		End Sub
		Dim Encrypt As New EncryptAndDecrypt.Encrypt_String_By_MONSTERMC

		Private Sub siticoneControlBox1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles siticoneControlBox1.Click
			Environment.Exit(0)
		End Sub
		'Private chatchannel As String = "Chats Chanel Name اسم الشات في البانيل" ' chat channel name

		'''''''''''''''''Encrypt
		Private chatchannel As String = Encrypt.decrypt("Chats Chanel Name اسم الشات في البانيل") ' chat channel name

		Private Sub Main_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Login.KeyAuthApp.check()
			siticoneLabel1.Text = $"Current Session Validation Status: {Login.KeyAuthApp.response.success}"
			key.Text = "Username: " & Login.KeyAuthApp.user_data.username
			expiry.Text = "Expiry: " & UnixTimeToDateTime(Long.Parse(Login.KeyAuthApp.user_data.subscriptions(0).expiry))
			subscription.Text = "Subscription: " & Login.KeyAuthApp.user_data.subscriptions(0).subscription
			ip.Text = "IP Address: " & Login.KeyAuthApp.user_data.ip
			hwid.Text = "HWID: " & Login.KeyAuthApp.user_data.hwid
			createDate.Text = "Creation date: " & UnixTimeToDateTime(Long.Parse(Login.KeyAuthApp.user_data.createdate))
			lastLogin.Text = "Last login: " & UnixTimeToDateTime(Long.Parse(Login.KeyAuthApp.user_data.lastlogin))
			subscriptionDaysLabel.Text = "Expiry in Days: " & Login.KeyAuthApp.expirydaysleft()
			numUsers.Text = "Number of users: " & Login.KeyAuthApp.app_data.numUsers
			numOnlineUsers.Text = "Number of online users: " & Login.KeyAuthApp.app_data.numOnlineUsers
			numKeys.Text = "Number of licenses: " & Login.KeyAuthApp.app_data.numKeys
			version.Text = "Current version: " & Login.KeyAuthApp.app_data.version
			customerPanelLink.Text = "Customer panel: " & Login.KeyAuthApp.app_data.customerPanelLink
		End Sub

		Public Function UnixTimeToDateTime(ByVal unixtime As Long) As Date
			Dim dtDateTime As New Date(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local)
			dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime()
			Return dtDateTime
		End Function

		Private Sub sendmsg_Click(ByVal sender As Object, ByVal e As EventArgs) Handles sendmsg.Click
			If Login.KeyAuthApp.chatsend(chatmsg.Text, chatchannel) Then
				dataGridView1.Rows.Insert(0, Login.KeyAuthApp.user_data.username, chatmsg.Text, UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()))
			Else
				chatmsg.Text = "Status: " & Login.KeyAuthApp.response.message
			End If
		End Sub

		Private Sub timer1_Tick(ByVal sender As Object, ByVal e As EventArgs) Handles timer1.Tick
			dataGridView1.Rows.Clear()
			timer1.Interval = 15000 ' get chat messages every 15 seconds
			If Not String.IsNullOrEmpty(chatchannel) Then
				Dim messages = Login.KeyAuthApp.chatget(chatchannel)
				If messages Is Nothing OrElse (Not messages.Any()) Then
					dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()))
				Else
					'
					For Each message_Renamed In messages
						dataGridView1.Rows.Insert(0, message_Renamed.author, message_Renamed.message, UnixTimeToDateTime(Long.Parse(message_Renamed.timestamp)))
					Next message_Renamed
				End If
			Else
				dataGridView1.Rows.Insert(0, "KeyAuth", "No Chat Messages", UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()))
			End If
		End Sub
	End Class
End Namespace
