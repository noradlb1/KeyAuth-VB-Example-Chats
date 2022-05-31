Namespace KeyAuth
	Partial Public Class Main
		Inherits System.Windows.Forms.Form

		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			Dim flag As Boolean = disposing AndAlso Me.components IsNot Nothing
			If flag Then
				Me.components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub
		Private Sub InitializeComponent()
			Me.components = New System.ComponentModel.Container()
			Dim animation1 As New Siticone.UI.AnimatorNS.Animation()
			Dim resources As New System.ComponentModel.ComponentResourceManager(GetType(Main))
			Me.siticoneDragControl1 = New Siticone.UI.WinForms.SiticoneDragControl(Me.components)
			Me.siticoneControlBox1 = New Siticone.UI.WinForms.SiticoneControlBox()
			Me.siticoneControlBox2 = New Siticone.UI.WinForms.SiticoneControlBox()
			Me.siticoneTransition1 = New Siticone.UI.WinForms.SiticoneTransition()
			Me.label1 = New System.Windows.Forms.Label()
			Me.label2 = New System.Windows.Forms.Label()
			Me.key = New Siticone.UI.WinForms.SiticoneLabel()
			Me.expiry = New Siticone.UI.WinForms.SiticoneLabel()
			Me.subscription = New Siticone.UI.WinForms.SiticoneLabel()
			Me.dataGridView1 = New System.Windows.Forms.DataGridView()
			Me.Sender = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Message = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.Time = New System.Windows.Forms.DataGridViewTextBoxColumn()
			Me.sendmsg = New Siticone.UI.WinForms.SiticoneRoundedButton()
			Me.chatmsg = New Siticone.UI.WinForms.SiticoneRoundedTextBox()
			Me.ip = New Siticone.UI.WinForms.SiticoneLabel()
			Me.hwid = New Siticone.UI.WinForms.SiticoneLabel()
			Me.createDate = New Siticone.UI.WinForms.SiticoneLabel()
			Me.lastLogin = New Siticone.UI.WinForms.SiticoneLabel()
			Me.numUsers = New Siticone.UI.WinForms.SiticoneLabel()
			Me.numOnlineUsers = New Siticone.UI.WinForms.SiticoneLabel()
			Me.numKeys = New Siticone.UI.WinForms.SiticoneLabel()
			Me.version = New Siticone.UI.WinForms.SiticoneLabel()
			Me.customerPanelLink = New Siticone.UI.WinForms.SiticoneLabel()
			Me.siticoneShadowForm = New Siticone.UI.WinForms.SiticoneShadowForm(Me.components)
			Me.timer1 = New System.Windows.Forms.Timer(Me.components)

			Me.subscriptionDaysLabel = New Siticone.UI.WinForms.SiticoneLabel()

			Me.siticoneLabel1 = New Siticone.UI.WinForms.SiticoneLabel()

			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
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
			Me.siticoneControlBox1.Location = New System.Drawing.Point(573, 4)
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
			Me.siticoneControlBox2.Location = New System.Drawing.Point(528, 4)
			Me.siticoneControlBox2.Name = "siticoneControlBox2"
			Me.siticoneControlBox2.ShadowDecoration.Parent = Me.siticoneControlBox2
			Me.siticoneControlBox2.Size = New System.Drawing.Size(45, 29)
			Me.siticoneControlBox2.TabIndex = 2
			' 
			' siticoneTransition1
			' 
			Me.siticoneTransition1.AnimationType = Siticone.UI.AnimatorNS.AnimationType.Rotate
			Me.siticoneTransition1.Cursor = Nothing
			animation1.AnimateOnlyDifferences = True
			animation1.BlindCoeff = (DirectCast(resources.GetObject("animation1.BlindCoeff"), System.Drawing.PointF))
			animation1.LeafCoeff = 0F
			animation1.MaxTime = 1F
			animation1.MinTime = 0F
			animation1.MosaicCoeff = (DirectCast(resources.GetObject("animation1.MosaicCoeff"), System.Drawing.PointF))
			animation1.MosaicShift = (DirectCast(resources.GetObject("animation1.MosaicShift"), System.Drawing.PointF))
			animation1.MosaicSize = 0
			animation1.Padding = New System.Windows.Forms.Padding(50)
			animation1.RotateCoeff = 1F
			animation1.RotateLimit = 0F
			animation1.ScaleCoeff = (DirectCast(resources.GetObject("animation1.ScaleCoeff"), System.Drawing.PointF))
			animation1.SlideCoeff = (DirectCast(resources.GetObject("animation1.SlideCoeff"), System.Drawing.PointF))
			animation1.TimeCoeff = 0F
			animation1.TransparencyCoeff = 1F
			Me.siticoneTransition1.DefaultAnimation = animation1
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
			Me.label2.Size = New System.Drawing.Size(87, 19)
			Me.label2.TabIndex = 27
			Me.label2.Text = "Loader Main"
			' 
			' key
			' 
			Me.key.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.key, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.key.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.key.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.key.Location = New System.Drawing.Point(20, 60)
			Me.key.Margin = New System.Windows.Forms.Padding(2)
			Me.key.Name = "key"
			Me.key.Size = New System.Drawing.Size(71, 14)
			Me.key.TabIndex = 37
			Me.key.Text = "usernameLabel"
			' 
			' expiry
			' 
			Me.expiry.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.expiry, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.expiry.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.expiry.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.expiry.Location = New System.Drawing.Point(20, 80)
			Me.expiry.Margin = New System.Windows.Forms.Padding(2)
			Me.expiry.Name = "expiry"
			Me.expiry.Size = New System.Drawing.Size(56, 14)
			Me.expiry.TabIndex = 38
			Me.expiry.Text = "expiryLabel"
			' 
			' subscription
			' 
			Me.subscription.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.subscription, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.subscription.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.subscription.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.subscription.Location = New System.Drawing.Point(20, 101)
			Me.subscription.Margin = New System.Windows.Forms.Padding(2)
			Me.subscription.Name = "subscription"
			Me.subscription.Size = New System.Drawing.Size(84, 14)
			Me.subscription.TabIndex = 39
			Me.subscription.Text = "subscriptionLabel"
			' 
			' dataGridView1
			' 
			Me.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
			Me.dataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() { Me.Sender, Me.Message, Me.Time})
			Me.siticoneTransition1.SetDecoration(Me.dataGridView1, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.dataGridView1.Location = New System.Drawing.Point(64, 255)
			Me.dataGridView1.Name = "dataGridView1"
			Me.dataGridView1.Size = New System.Drawing.Size(493, 227)
			Me.dataGridView1.TabIndex = 41
			' 
			' Sender
			' 
			Me.Sender.HeaderText = "Sender"
			Me.Sender.Name = "Sender"
			Me.Sender.Width = 75
			' 
			' Message
			' 
			Me.Message.HeaderText = "Message"
			Me.Message.Name = "Message"
			Me.Message.Width = 200
			' 
			' Time
			' 
			Me.Time.HeaderText = "Time"
			Me.Time.MaxInputLength = 50000
			Me.Time.Name = "Time"
			Me.Time.Width = 175
			' 
			' sendmsg
			' 
			Me.sendmsg.BorderColor = System.Drawing.Color.DodgerBlue
			Me.sendmsg.BorderThickness = 1
			Me.sendmsg.CheckedState.Parent = Me.sendmsg
			Me.sendmsg.CustomImages.Parent = Me.sendmsg
			Me.siticoneTransition1.SetDecoration(Me.sendmsg, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.sendmsg.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.sendmsg.Font = New System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.sendmsg.ForeColor = System.Drawing.Color.White
			Me.sendmsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(213)))), (CInt((CByte(218)))), (CInt((CByte(223)))))
			Me.sendmsg.HoveredState.Parent = Me.sendmsg
			Me.sendmsg.Location = New System.Drawing.Point(406, 488)
			Me.sendmsg.Name = "sendmsg"
			Me.sendmsg.ShadowDecoration.Parent = Me.sendmsg
			Me.sendmsg.Size = New System.Drawing.Size(151, 27)
			Me.sendmsg.TabIndex = 42
			Me.sendmsg.Text = "Send"
'			Me.sendmsg.Click += New System.EventHandler(Me.sendmsg_Click)
			' 
			' chatmsg
			' 
			Me.chatmsg.AllowDrop = True
			Me.chatmsg.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(7)))), (CInt((CByte(127)))), (CInt((CByte(243)))))
			Me.chatmsg.Cursor = System.Windows.Forms.Cursors.IBeam
			Me.siticoneTransition1.SetDecoration(Me.chatmsg, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.chatmsg.DefaultText = "Your message here"
			Me.chatmsg.DisabledState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(208)))), (CInt((CByte(208)))), (CInt((CByte(208)))))
			Me.chatmsg.DisabledState.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(226)))), (CInt((CByte(226)))), (CInt((CByte(226)))))
			Me.chatmsg.DisabledState.ForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.chatmsg.DisabledState.Parent = Me.chatmsg
			Me.chatmsg.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb((CInt((CByte(138)))), (CInt((CByte(138)))), (CInt((CByte(138)))))
			Me.chatmsg.FillColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.chatmsg.FocusedState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.chatmsg.FocusedState.Parent = Me.chatmsg
			Me.chatmsg.HoveredState.BorderColor = System.Drawing.Color.FromArgb((CInt((CByte(94)))), (CInt((CByte(148)))), (CInt((CByte(255)))))
			Me.chatmsg.HoveredState.Parent = Me.chatmsg
			Me.chatmsg.Location = New System.Drawing.Point(64, 485)
			Me.chatmsg.Margin = New System.Windows.Forms.Padding(4)
			Me.chatmsg.Name = "chatmsg"
			Me.chatmsg.PasswordChar = ControlChars.NullChar
			Me.chatmsg.PlaceholderText = ""
			Me.chatmsg.SelectedText = ""
			Me.chatmsg.ShadowDecoration.Parent = Me.chatmsg
			Me.chatmsg.Size = New System.Drawing.Size(335, 30)
			Me.chatmsg.TabIndex = 43
			Me.chatmsg.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
			' 
			' ip
			' 
			Me.ip.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.ip, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.ip.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.ip.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.ip.Location = New System.Drawing.Point(20, 119)
			Me.ip.Margin = New System.Windows.Forms.Padding(2)
			Me.ip.Name = "ip"
			Me.ip.Size = New System.Drawing.Size(36, 14)
			Me.ip.TabIndex = 44
			Me.ip.Text = "ipLabel"
			' 
			' hwid
			' 
			Me.hwid.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.hwid, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.hwid.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.hwid.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.hwid.Location = New System.Drawing.Point(20, 137)
			Me.hwid.Margin = New System.Windows.Forms.Padding(2)
			Me.hwid.Name = "hwid"
			Me.hwid.Size = New System.Drawing.Size(50, 14)
			Me.hwid.TabIndex = 45
			Me.hwid.Text = "hwidLabel"
			' 
			' createDate
			' 
			Me.createDate.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.createDate, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.createDate.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.createDate.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.createDate.Location = New System.Drawing.Point(20, 155)
			Me.createDate.Margin = New System.Windows.Forms.Padding(2)
			Me.createDate.Name = "createDate"
			Me.createDate.Size = New System.Drawing.Size(76, 14)
			Me.createDate.TabIndex = 46
			Me.createDate.Text = "createDateLabel"
			' 
			' lastLogin
			' 
			Me.lastLogin.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.lastLogin, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.lastLogin.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.lastLogin.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.lastLogin.Location = New System.Drawing.Point(20, 173)
			Me.lastLogin.Margin = New System.Windows.Forms.Padding(2)
			Me.lastLogin.Name = "lastLogin"
			Me.lastLogin.Size = New System.Drawing.Size(69, 14)
			Me.lastLogin.TabIndex = 47
			Me.lastLogin.Text = "lastLoginLabel"
			' 
			' numUsers
			' 
			Me.numUsers.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.numUsers, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.numUsers.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.numUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.numUsers.Location = New System.Drawing.Point(325, 60)
			Me.numUsers.Margin = New System.Windows.Forms.Padding(2)
			Me.numUsers.Name = "numUsers"
			Me.numUsers.Size = New System.Drawing.Size(72, 14)
			Me.numUsers.TabIndex = 48
			Me.numUsers.Text = "numUsersLabel"
			' 
			' numOnlineUsers
			' 
			Me.numOnlineUsers.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.numOnlineUsers, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.numOnlineUsers.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.numOnlineUsers.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.numOnlineUsers.Location = New System.Drawing.Point(325, 80)
			Me.numOnlineUsers.Margin = New System.Windows.Forms.Padding(2)
			Me.numOnlineUsers.Name = "numOnlineUsers"
			Me.numOnlineUsers.Size = New System.Drawing.Size(103, 14)
			Me.numOnlineUsers.TabIndex = 49
			Me.numOnlineUsers.Text = "numOnlineUsersLabel"
			' 
			' numKeys
			' 
			Me.numKeys.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.numKeys, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.numKeys.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.numKeys.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.numKeys.Location = New System.Drawing.Point(325, 101)
			Me.numKeys.Margin = New System.Windows.Forms.Padding(2)
			Me.numKeys.Name = "numKeys"
			Me.numKeys.Size = New System.Drawing.Size(68, 14)
			Me.numKeys.TabIndex = 50
			Me.numKeys.Text = "numKeysLabel"
			' 
			' version
			' 
			Me.version.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.version, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.version.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.version.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.version.Location = New System.Drawing.Point(325, 119)
			Me.version.Margin = New System.Windows.Forms.Padding(2)
			Me.version.Name = "version"
			Me.version.Size = New System.Drawing.Size(60, 14)
			Me.version.TabIndex = 51
			Me.version.Text = "versionLabel"
			' 
			' customerPanelLink
			' 
			Me.customerPanelLink.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.customerPanelLink, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.customerPanelLink.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.customerPanelLink.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.customerPanelLink.Location = New System.Drawing.Point(325, 137)
			Me.customerPanelLink.Margin = New System.Windows.Forms.Padding(2)
			Me.customerPanelLink.Name = "customerPanelLink"
			Me.customerPanelLink.Size = New System.Drawing.Size(115, 14)
			Me.customerPanelLink.TabIndex = 52
			Me.customerPanelLink.Text = "customerPanelLinkLabel"
			' 
			' timer1
			' 
			Me.timer1.Enabled = True
			Me.timer1.Interval = 1
'			Me.timer1.Tick += New System.EventHandler(Me.timer1_Tick)
			' 

			' subscriptionDaysLabel
			' 
			Me.subscriptionDaysLabel.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.subscriptionDaysLabel, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.subscriptionDaysLabel.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.subscriptionDaysLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.subscriptionDaysLabel.Location = New System.Drawing.Point(20, 210)
			Me.subscriptionDaysLabel.Margin = New System.Windows.Forms.Padding(2)
			Me.subscriptionDaysLabel.Name = "subscriptionDaysLabel"
			Me.subscriptionDaysLabel.Size = New System.Drawing.Size(105, 14)
			Me.subscriptionDaysLabel.TabIndex = 53
			Me.subscriptionDaysLabel.Text = "subscriptionDaysLabel"

			' siticoneLabel1
			' 
			Me.siticoneLabel1.BackColor = System.Drawing.Color.Transparent
			Me.siticoneTransition1.SetDecoration(Me.siticoneLabel1, Siticone.UI.AnimatorNS.DecorationType.None)
			Me.siticoneLabel1.Font = New System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, (CByte(0)))
			Me.siticoneLabel1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
			Me.siticoneLabel1.Location = New System.Drawing.Point(20, 191)
			Me.siticoneLabel1.Margin = New System.Windows.Forms.Padding(2)
			Me.siticoneLabel1.Name = "siticoneLabel1"
			Me.siticoneLabel1.Size = New System.Drawing.Size(161, 14)
			Me.siticoneLabel1.TabIndex = 53
			Me.siticoneLabel1.Text = "Current Session Valdiation Status: "

			' 
			' Main
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.AutoValidate = System.Windows.Forms.AutoValidate.Disable
			Me.BackColor = System.Drawing.Color.FromArgb((CInt((CByte(35)))), (CInt((CByte(39)))), (CInt((CByte(42)))))
			Me.ClientSize = New System.Drawing.Size(622, 543)

			Me.Controls.Add(Me.subscriptionDaysLabel)

			Me.Controls.Add(Me.siticoneLabel1)

			Me.Controls.Add(Me.customerPanelLink)
			Me.Controls.Add(Me.version)
			Me.Controls.Add(Me.numKeys)
			Me.Controls.Add(Me.numOnlineUsers)
			Me.Controls.Add(Me.numUsers)
			Me.Controls.Add(Me.lastLogin)
			Me.Controls.Add(Me.createDate)
			Me.Controls.Add(Me.hwid)
			Me.Controls.Add(Me.ip)
			Me.Controls.Add(Me.chatmsg)
			Me.Controls.Add(Me.sendmsg)
			Me.Controls.Add(Me.dataGridView1)
			Me.Controls.Add(Me.subscription)
			Me.Controls.Add(Me.expiry)
			Me.Controls.Add(Me.key)
			Me.Controls.Add(Me.label2)
			Me.Controls.Add(Me.label1)
			Me.Controls.Add(Me.siticoneControlBox2)
			Me.Controls.Add(Me.siticoneControlBox1)
			Me.siticoneTransition1.SetDecoration(Me, Siticone.UI.AnimatorNS.DecorationType.BottomMirror)
			Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
			Me.Name = "Main"
			Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
			Me.Text = "Loader"
			Me.TransparencyKey = System.Drawing.Color.Maroon
'			Me.Load += New System.EventHandler(Me.Main_Load)
			DirectCast(Me.dataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
		Private siticoneShadowForm As Siticone.UI.WinForms.SiticoneShadowForm
		Private subscription As Siticone.UI.WinForms.SiticoneLabel
		Private expiry As Siticone.UI.WinForms.SiticoneLabel
		Private key As Siticone.UI.WinForms.SiticoneLabel
		Private dataGridView1 As System.Windows.Forms.DataGridView
		Private Sender As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Message As System.Windows.Forms.DataGridViewTextBoxColumn
		Private Time As System.Windows.Forms.DataGridViewTextBoxColumn
		Private WithEvents sendmsg As Siticone.UI.WinForms.SiticoneRoundedButton
		Private chatmsg As Siticone.UI.WinForms.SiticoneRoundedTextBox
		Private WithEvents timer1 As System.Windows.Forms.Timer
		Private ip As Siticone.UI.WinForms.SiticoneLabel
		Private hwid As Siticone.UI.WinForms.SiticoneLabel
		Private createDate As Siticone.UI.WinForms.SiticoneLabel
		Private lastLogin As Siticone.UI.WinForms.SiticoneLabel
		Private numUsers As Siticone.UI.WinForms.SiticoneLabel
		Private numOnlineUsers As Siticone.UI.WinForms.SiticoneLabel
		Private numKeys As Siticone.UI.WinForms.SiticoneLabel
		Private customerPanelLink As Siticone.UI.WinForms.SiticoneLabel
		Private version As Siticone.UI.WinForms.SiticoneLabel
		Private subscriptionDaysLabel As Siticone.UI.WinForms.SiticoneLabel
		Private siticoneLabel1 As Siticone.UI.WinForms.SiticoneLabel

	End Class
End Namespace
