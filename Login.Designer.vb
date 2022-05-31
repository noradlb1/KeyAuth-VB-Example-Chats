Namespace KeyAuth
	' Token: 0x02000002 RID: 2
	Partial Public Class Login
		Inherits System.Windows.Forms.Form

		' Token: 0x06000011 RID: 17 RVA: 0x0000215C File Offset: 0x0000035C
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
			If flag Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		' Token: 0x06000012 RID: 18 RVA: 0x00002194 File Offset: 0x00000394
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim animation2 As New Siticone.UI.AnimatorNS.Animation()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Login))
			Me.siticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
			Me.siticoneControlBox1 = New Siticone.UI.WinForms.SiticoneControlBox()
			Me.siticoneControlBox2 = New Siticone.UI.WinForms.SiticoneControlBox()
			Me.siticoneTransition1 = New Siticone.UI.WinForms.SiticoneTransition()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.LoginBtn = New Siticone.UI.WinForms.SiticoneRoundedButton()
			Me.key = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.username = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.password = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.RgstrBtn = New Siticone.UI.WinForms.SiticoneRoundedButton()
			Me.UpgradeBtn = New Siticone.UI.WinForms.SiticoneRoundedButton()
			Me.LicBtn = New Siticone.UI.WinForms.SiticoneRoundedButton()
			Me.status = New Siticone.UI.WinForms.SiticoneLabel()
			Me.siticoneShadowForm = New Siticone.UI.WinForms.SiticoneShadowForm(Me.components)
			Me.siticoneLabel1 = New Siticone.UI.WinForms.SiticoneLabel()
			Me.SuspendLayout()
			' 
			' siticoneDragControl1
			' 
			Me.siticoneDragControl1.TargetControl = Me
			' 
			' siticoneControlBox1
			' 
			Me.siticoneControlBox1.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.siticoneControlBox1.BorderRadius = 10
			Me.siticoneTransition1.SetDecoration(Me.siticoneControlBox1, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.siticoneControlBox1.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.siticoneControlBox1.HoveredState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(232)))), (CInt((CByte(17)))), (CInt((CByte(35)))))
			Me.siticoneControlBox1.HoveredState.IconColor = System.Drawing.Color.White
			Me.siticoneControlBox1.HoveredState.Parent = Me.siticoneControlBox1
			Me.siticoneControlBox1.IconColor = System.Drawing.Color.White
			Me.siticoneControlBox1.Location = New System.Drawing.Point(283, 4)
			Me.siticoneControlBox1.Name = "siticoneControlBox1"
			Me.siticoneControlBox1.ShadowDecoration.Parent = Me.siticoneControlBox1
			Me.siticoneControlBox1.Size = New System.Drawing.Size(45, 29)
			Me.siticoneControlBox1.TabIndex = 1
'			Me.siticoneControlBox1.Click += New System.EventHandler(Me.siticoneControlBox1_Click)
			' 
			' siticoneControlBox2
			' 
			Me.siticoneControlBox2.Anchor = (CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles))
			Me.siticoneControlBox2.BorderRadius = 10
			Me.siticoneControlBox2.ControlBoxType = Siticone.UI.WinForms.Enums.ControlBoxType.MinimizeBox
			Me.siticoneTransition1.SetDecoration(Me.siticoneControlBox2, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.siticoneControlBox2.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.siticoneControlBox2.HoveredState.Parent = Me.siticoneControlBox2
			Me.siticoneControlBox2.IconColor = System.Drawing.Color.White
			Me.siticoneControlBox2.Location = New System.Drawing.Point(237, 4)
			Me.siticoneControlBox2.Name = "siticoneControlBox2"
			Me.siticoneControlBox2.ShadowDecoration.Parent = Me.siticoneControlBox2
			Me.siticoneControlBox2.Size = New System.Drawing.Size(45, 29)
			Me.siticoneControlBox2.TabIndex = 2
			' 
			' siticoneTransition1
			' 
			Me.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate
			Me.siticoneTransition1.Cursor = Nothing
			animation2.AnimateOnlyDifferences = True
			animation2.BlindCoeff = (DirectCast(resources.GetObject("animation2.BlindCoeff"), System.Drawing.PointF))
			animation2.LeafCoeff = 0F
			animation2.MaxTime = 1F
			animation2.MinTime = 0F
			animation2.MosaicCoeff = (DirectCast(resources.GetObject("animation2.MosaicCoeff"), System.Drawing.PointF))
			animation2.MosaicShift = (DirectCast(resources.GetObject("animation2.MosaicShift"), System.Drawing.PointF))
			animation2.MosaicSize = 0
			animation2.Padding = New System.Windows.Forms.Padding(50)
			animation2.RotateCoeff = 1F
			animation2.RotateLimit = 0F
			animation2.ScaleCoeff = (DirectCast(resources.GetObject("animation2.ScaleCoeff"), System.Drawing.PointF))
			animation2.SlideCoeff = (DirectCast(resources.GetObject("animation2.SlideCoeff"), System.Drawing.PointF))
			animation2.TimeCoeff = 0F
			animation2.TransparencyCoeff = 1F
			Me.siticoneTransition1.DefaultAnimation = animation2
			' 
			' label1
			' 
			Me.label1.AutoSize = True
			Me.siticoneTransition1.SetDecoration(Me.label1, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.label1.Font = New System.Drawing.Font("Segoe UI Light", 10F)
			Me.label1.ForeColor = System.Drawing.Color.White
			Me.label1.Location = New System.Drawing.Point(-1, 136)
			Me.label1.Name = "label1"
			Me.label1.Size = New System.Drawing.Size(0, 19)
			Me.label1.TabIndex = 22
			' 
			' label2
			' 
			Me.label2.AutoSize = True
			Me.siticoneTransition1.SetDecoration(Me.label2, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.label2.Font = New System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.label2.ForeColor = System.Drawing.SystemColors.ButtonFace
			Me.label2.Location = New System.Drawing.Point(10, 11)
			Me.label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
			Me.label2.Name = "label2"
			Me.label2.Size = New System.Drawing.Size(90, 19)
			Me.label2.TabIndex = 27
			Me.label2.Text = "Loader Login"
			' 
			' LoginBtn
			' 
			Me.LoginBtn.BorderColor = System.Drawing.Color.DodgerBlue
			Me.LoginBtn.BorderThickness = 1
			Me.LoginBtn.CheckedState.Parent = Me.LoginBtn
			Me.LoginBtn.CustomImages.Parent = Me.LoginBtn
			Me.siticoneTransition1.SetDecoration(Me.LoginBtn, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.LoginBtn.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.LoginBtn.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.LoginBtn.ForeColor = System.Drawing.Color.White
			Me.LoginBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(218)))), (CInt((CByte(223)))))
			Me.LoginBtn.HoveredState.Parent = Me.LoginBtn
			Me.LoginBtn.Location = New System.Drawing.Point(12, 167)
			Me.LoginBtn.Name = "LoginBtn"
			Me.LoginBtn.ShadowDecoration.Parent = Me.LoginBtn
			Me.LoginBtn.Size = New System.Drawing.Size(151, 27)
			Me.LoginBtn.TabIndex = 26
			Me.LoginBtn.Text = "Login"
'			Me.LoginBtn.Click += New System.EventHandler(Me.LoginBtn_Click)
			' 
			' key
			' 
			Me.key.AllowDrop = True
			Me.key.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.key.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.siticoneTransition1.SetDecoration(Me.key, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.key.DefaultText = "Key"
			Me.key.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.key.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.key.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.key.DisabledState.Parent = Me.key
			Me.key.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.key.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.key.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.key.FocusedState.Parent = Me.key
			Me.key.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.key.HoveredState.Parent = Me.key
			Me.key.Location = New System.Drawing.Point(48, 130)
			Me.key.Margin = New System.Windows.Forms.Padding(4)
			Me.key.Name = "key"
			Me.key.PasswordChar = ControlChars.NullChar
			Me.key.PlaceholderText = ""
			Me.key.SelectedText = ""
			Me.key.ShadowDecoration.Parent = Me.key
			Me.key.Size = New System.Drawing.Size(236, 30)
			Me.key.TabIndex = 32
			Me.key.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' username
			' 
			Me.username.AllowDrop = True
			Me.username.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.username.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.siticoneTransition1.SetDecoration(Me.username, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.username.DefaultText = "Username"
			Me.username.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.username.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.username.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.username.DisabledState.Parent = Me.username
			Me.username.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.username.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.username.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.username.FocusedState.Parent = Me.username
			Me.username.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.username.HoveredState.Parent = Me.username
			Me.username.Location = New System.Drawing.Point(48, 54)
			Me.username.Margin = New System.Windows.Forms.Padding(4)
			Me.username.Name = "username"
			Me.username.PasswordChar = ControlChars.NullChar
			Me.username.PlaceholderText = ""
			Me.username.SelectedText = ""
			Me.username.ShadowDecoration.Parent = Me.username
			Me.username.Size = New System.Drawing.Size(236, 30)
			Me.username.TabIndex = 33
			Me.username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' password
			' 
			Me.password.AllowDrop = True
			Me.password.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.password.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.siticoneTransition1.SetDecoration(Me.password, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.password.DefaultText = "Password"
			Me.password.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.password.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.password.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.password.DisabledState.Parent = Me.password
			Me.password.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.password.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.password.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.password.FocusedState.Parent = Me.password
			Me.password.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.password.HoveredState.Parent = Me.password
			Me.password.Location = New System.Drawing.Point(48, 92)
			Me.password.Margin = New System.Windows.Forms.Padding(4)
			Me.password.Name = "password"
			Me.password.PasswordChar = ControlChars.NullChar
			Me.password.PlaceholderText = ""
			Me.password.SelectedText = ""
			Me.password.ShadowDecoration.Parent = Me.password
			Me.password.Size = New System.Drawing.Size(236, 30)
			Me.password.TabIndex = 34
			Me.password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' RgstrBtn
			' 
			Me.RgstrBtn.BorderColor = System.Drawing.Color.DodgerBlue
			Me.RgstrBtn.BorderThickness = 1
			Me.RgstrBtn.CheckedState.Parent = Me.RgstrBtn
			Me.RgstrBtn.CustomImages.Parent = Me.RgstrBtn
			Me.siticoneTransition1.SetDecoration(Me.RgstrBtn, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.RgstrBtn.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.RgstrBtn.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.RgstrBtn.ForeColor = System.Drawing.Color.White
			Me.RgstrBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(218)))), (CInt((CByte(223)))))
			Me.RgstrBtn.HoveredState.Parent = Me.RgstrBtn
			Me.RgstrBtn.Location = New System.Drawing.Point(169, 167)
			Me.RgstrBtn.Name = "RgstrBtn"
			Me.RgstrBtn.ShadowDecoration.Parent = Me.RgstrBtn
			Me.RgstrBtn.Size = New System.Drawing.Size(153, 27)
			Me.RgstrBtn.TabIndex = 35
			Me.RgstrBtn.Text = "Register"
'			Me.RgstrBtn.Click += New System.EventHandler(Me.RgstrBtn_Click)
			' 
			' UpgradeBtn
			' 
			Me.UpgradeBtn.BorderColor = System.Drawing.Color.DodgerBlue
			Me.UpgradeBtn.BorderThickness = 1
			Me.UpgradeBtn.CheckedState.Parent = Me.UpgradeBtn
			Me.UpgradeBtn.CustomImages.Parent = Me.UpgradeBtn
			Me.siticoneTransition1.SetDecoration(Me.UpgradeBtn, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.UpgradeBtn.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.UpgradeBtn.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.UpgradeBtn.ForeColor = System.Drawing.Color.White
			Me.UpgradeBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(218)))), (CInt((CByte(223)))))
			Me.UpgradeBtn.HoveredState.Parent = Me.UpgradeBtn
			Me.UpgradeBtn.Location = New System.Drawing.Point(12, 200)
			Me.UpgradeBtn.Name = "UpgradeBtn"
			Me.UpgradeBtn.ShadowDecoration.Parent = Me.UpgradeBtn
			Me.UpgradeBtn.Size = New System.Drawing.Size(151, 27)
			Me.UpgradeBtn.TabIndex = 36
			Me.UpgradeBtn.Text = "Upgrade"
'			Me.UpgradeBtn.Click += New System.EventHandler(Me.UpgradeBtn_Click)
			' 
			' LicBtn
			' 
			Me.LicBtn.BorderColor = System.Drawing.Color.DodgerBlue
			Me.LicBtn.BorderThickness = 1
			Me.LicBtn.CheckedState.Parent = Me.LicBtn
			Me.LicBtn.CustomImages.Parent = Me.LicBtn
			Me.siticoneTransition1.SetDecoration(Me.LicBtn, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.LicBtn.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.LicBtn.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.LicBtn.ForeColor = System.Drawing.Color.White
			Me.LicBtn.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(218)))), (CInt((CByte(223)))))
			Me.LicBtn.HoveredState.Parent = Me.LicBtn
			Me.LicBtn.Location = New System.Drawing.Point(169, 200)
			Me.LicBtn.Name = "LicBtn"
			Me.LicBtn.ShadowDecoration.Parent = Me.LicBtn
			Me.LicBtn.Size = New System.Drawing.Size(153, 27)
			Me.LicBtn.TabIndex = 37
			Me.LicBtn.Text = "License"
'			Me.LicBtn.Click += New System.EventHandler(Me.LicBtn_Click)
			' 
			' status
			' 
			Me.status.AutoSize = False
			Me.status.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.status, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.status.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.status.Font = New System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.status.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.status.Location = New System.Drawing.Point(0, 302)
			Me.status.Margin = New System.Windows.Forms.Padding(2)
			Me.status.Name = "status"
			Me.status.Size = New System.Drawing.Size(332, 42)
			Me.status.TabIndex = 38
			Me.status.Text = "Status: Awaiting login"
			Me.status.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' siticoneLabel1
			' 
			Me.siticoneLabel1.AutoSize = False
			Me.siticoneLabel1.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.siticoneLabel1, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.siticoneLabel1.Dock = System.Windows.Forms.DockStyle.Bottom
			Me.siticoneLabel1.Font = New System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold)
			Me.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.siticoneLabel1.Location = New System.Drawing.Point(0, 260)
			Me.siticoneLabel1.Margin = New System.Windows.Forms.Padding(2)
			Me.siticoneLabel1.Name = "siticoneLabel1"
			Me.siticoneLabel1.Size = New System.Drawing.Size(332, 42)
			Me.siticoneLabel1.TabIndex = 39
			Me.siticoneLabel1.Text = "Current Session Validation Status: " & ControlChars.CrLf
			Me.siticoneLabel1.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter
			' 
			' Login
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.ClientSize = New System.Drawing.Size(332, 344)
			Me.Controls.Add(Me.siticoneLabel1)
			Me.Controls.Add(Me.status)
			Me.Controls.Add(Me.LicBtn)
			Me.Controls.Add(Me.UpgradeBtn)
			Me.Controls.Add(Me.RgstrBtn)
			Me.Controls.Add(Me.password)
			Me.Controls.Add(Me.username)
			Me.Controls.Add(Me.key)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.LoginBtn)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.siticoneControlBox2)
			Me.Controls.Add(Me.siticoneControlBox1)
			Me.siticoneTransition1.SetDecoration(Me, Siticone.UI.AnimatorNS.DecorationType.BottomMirror)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Login"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Loader"
			Me.TransparencyKey = System.Drawing.Color.Maroon
'			Me.Load += New System.EventHandler(Me.Login_Load)
			Me.ResumeLayout(False)
			Me.PerformLayout()

		End Sub

		' Token: 0x04000001 RID: 1
		Private components As Global.System.ComponentModel.IContainer = Nothing

		' Token: 0x04000002 RID: 2
		Private siticoneDragControl1 As Global.Siticone.UI.WinForms.SiticoneDragControl

		' Token: 0x04000004 RID: 4
		Private WithEvents siticoneControlBox1 As Global.Siticone.UI.WinForms.SiticoneControlBox

		' Token: 0x04000005 RID: 5
		Private siticoneControlBox2 As Global.Siticone.UI.WinForms.SiticoneControlBox

		' Token: 0x04000009 RID: 9
		Private siticoneTransition1 As Global.Siticone.UI.WinForms.SiticoneTransition

		' Token: 0x0400000A RID: 10
		Private label1 As Global.System.Windows.Forms.Label
		Private label2 As System.Windows.Forms.Label
		Private WithEvents LoginBtn As Siticone.UI.WinForms.SiticoneRoundedButton
		Private siticoneShadowForm As Siticone.UI.WinForms.SiticoneShadowForm
		Private key As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private password As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private username As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private WithEvents LicBtn As Siticone.UI.WinForms.SiticoneRoundedButton
		Private WithEvents UpgradeBtn As Siticone.UI.WinForms.SiticoneRoundedButton
		Private WithEvents RgstrBtn As Siticone.UI.WinForms.SiticoneRoundedButton
		Private status As Siticone.UI.WinForms.SiticoneLabel
		Private siticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel
	End Class
End Namespace
