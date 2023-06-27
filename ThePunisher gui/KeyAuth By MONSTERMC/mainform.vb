Imports System
Imports System.Diagnostics
Imports System.Windows.Forms

Public Class mainform
    Private Sub mainform_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        loadformcode()
    End Sub

#Region "PanelData"
    Public Sub loadformcode()
        Form1.KeyAuthApp.check()
        Guna2HtmlLabel1Usename.Text = "Username: " & Form1.KeyAuthApp.user_data.username
        Guna2HtmlLabel2expy.Text = "Expiry: " & UnixTimeToDateTime(Long.Parse(Form1.KeyAuthApp.user_data.subscriptions(0).expiry))
        Guna2HtmlLabel3ip.Text = "IP Address: " & Form1.KeyAuthApp.user_data.ip
        Guna2HtmlLabel4hwid.Text = "HWID: " & Form1.KeyAuthApp.user_data.hwid
        Guna2HtmlLabel5lastlogin.Text = "Last login: " & UnixTimeToDateTime(Long.Parse(Form1.KeyAuthApp.user_data.lastlogin))
        Guna2HtmlLabel6expirdey.Text = "Expiry in Days: " & Form1.KeyAuthApp.expirydaysleft()
    End Sub
    Public Function UnixTimeToDateTime(ByVal unixtime As Long) As Date
        Dim dtDateTime As New Date(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local)
        dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime()
        Return dtDateTime
    End Function

    Private Sub Guna2ToggleSwitch1_CheckedChanged(sender As Object, e As EventArgs) Handles Guna2ToggleSwitch1.CheckedChanged
        If Guna2ToggleSwitch1.Checked Then
            My.Computer.Audio.Play(My.Resources.click_one, AudioPlayMode.Background)

            Guna2HtmlLabel1Usename.Hide()
            Guna2HtmlLabel2expy.Hide()
            Guna2HtmlLabel3ip.Hide()
            Guna2HtmlLabel4hwid.Hide()
            Guna2HtmlLabel5lastlogin.Hide()
            Guna2HtmlLabel6expirdey.Hide()
        Else
            My.Computer.Audio.Play(My.Resources.click_one, AudioPlayMode.Background)

            Guna2HtmlLabel1Usename.Show()
            Guna2HtmlLabel2expy.Show()
            Guna2HtmlLabel3ip.Show()
            Guna2HtmlLabel4hwid.Show()
            Guna2HtmlLabel5lastlogin.Show()
            Guna2HtmlLabel6expirdey.Show()
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