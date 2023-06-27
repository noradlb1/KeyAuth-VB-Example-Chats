<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class mainform
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
        Me.Guna2Elipse1 = New Guna.UI2.WinForms.Guna2Elipse(Me.components)
        Me.Guna2DragControl1 = New Guna.UI2.WinForms.Guna2DragControl(Me.components)
        Me.Guna2GradientPanel1 = New Guna.UI2.WinForms.Guna2GradientPanel()
        Me.Guna2HtmlLabel3ip = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel6expirdey = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox2 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2HtmlLabel5lastlogin = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2ControlBox1 = New Guna.UI2.WinForms.Guna2ControlBox()
        Me.Guna2ToggleSwitch1 = New Guna.UI2.WinForms.Guna2ToggleSwitch()
        Me.Guna2HtmlLabel4hwid = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel1Usename = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Guna2HtmlLabel2expy = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.Guna2GradientPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Guna2Elipse1
        '
        Me.Guna2Elipse1.BorderRadius = 8
        Me.Guna2Elipse1.TargetControl = Me
        '
        'Guna2DragControl1
        '
        Me.Guna2DragControl1.DockIndicatorTransparencyValue = 0.6R
        Me.Guna2DragControl1.TargetControl = Me.Guna2GradientPanel1
        Me.Guna2DragControl1.UseTransparentDrag = True
        '
        'Guna2GradientPanel1
        '
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel3ip)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel6expirdey)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ControlBox2)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel5lastlogin)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ControlBox1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2ToggleSwitch1)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel4hwid)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel1Usename)
        Me.Guna2GradientPanel1.Controls.Add(Me.Guna2HtmlLabel2expy)
        Me.Guna2GradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Guna2GradientPanel1.FillColor = System.Drawing.Color.FromArgb(CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2GradientPanel1.FillColor2 = System.Drawing.Color.FromArgb(CType(CType(41, Byte), Integer), CType(CType(25, Byte), Integer), CType(CType(25, Byte), Integer))
        Me.Guna2GradientPanel1.Location = New System.Drawing.Point(0, 0)
        Me.Guna2GradientPanel1.Name = "Guna2GradientPanel1"
        Me.Guna2GradientPanel1.Size = New System.Drawing.Size(589, 316)
        Me.Guna2GradientPanel1.TabIndex = 0
        '
        'Guna2HtmlLabel3ip
        '
        Me.Guna2HtmlLabel3ip.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel3ip.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel3ip.Location = New System.Drawing.Point(6, 46)
        Me.Guna2HtmlLabel3ip.Name = "Guna2HtmlLabel3ip"
        Me.Guna2HtmlLabel3ip.Size = New System.Drawing.Size(37, 15)
        Me.Guna2HtmlLabel3ip.TabIndex = 13
        Me.Guna2HtmlLabel3ip.Text = "ipLabel"
        '
        'Guna2HtmlLabel6expirdey
        '
        Me.Guna2HtmlLabel6expirdey.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel6expirdey.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel6expirdey.Location = New System.Drawing.Point(6, 109)
        Me.Guna2HtmlLabel6expirdey.Name = "Guna2HtmlLabel6expirdey"
        Me.Guna2HtmlLabel6expirdey.Size = New System.Drawing.Size(109, 15)
        Me.Guna2HtmlLabel6expirdey.TabIndex = 16
        Me.Guna2HtmlLabel6expirdey.Text = "subscriptionDaysLabel"
        '
        'Guna2ControlBox2
        '
        Me.Guna2ControlBox2.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox2.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox
        Me.Guna2ControlBox2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox2.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox2.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox2.Location = New System.Drawing.Point(533, 4)
        Me.Guna2ControlBox2.Name = "Guna2ControlBox2"
        Me.Guna2ControlBox2.Size = New System.Drawing.Size(24, 10)
        Me.Guna2ControlBox2.TabIndex = 10
        '
        'Guna2HtmlLabel5lastlogin
        '
        Me.Guna2HtmlLabel5lastlogin.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel5lastlogin.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel5lastlogin.Location = New System.Drawing.Point(6, 88)
        Me.Guna2HtmlLabel5lastlogin.Name = "Guna2HtmlLabel5lastlogin"
        Me.Guna2HtmlLabel5lastlogin.Size = New System.Drawing.Size(71, 15)
        Me.Guna2HtmlLabel5lastlogin.TabIndex = 15
        Me.Guna2HtmlLabel5lastlogin.Text = "lastLoginLabel"
        '
        'Guna2ControlBox1
        '
        Me.Guna2ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Guna2ControlBox1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ControlBox1.FillColor = System.Drawing.Color.Transparent
        Me.Guna2ControlBox1.IconColor = System.Drawing.Color.DimGray
        Me.Guna2ControlBox1.Location = New System.Drawing.Point(563, 4)
        Me.Guna2ControlBox1.Name = "Guna2ControlBox1"
        Me.Guna2ControlBox1.Size = New System.Drawing.Size(24, 10)
        Me.Guna2ControlBox1.TabIndex = 9
        '
        'Guna2ToggleSwitch1
        '
        Me.Guna2ToggleSwitch1.BackColor = System.Drawing.Color.Transparent
        Me.Guna2ToggleSwitch1.Checked = True
        Me.Guna2ToggleSwitch1.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(43, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.InnerBorderColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2ToggleSwitch1.CheckedState.InnerColor = System.Drawing.Color.FromArgb(CType(CType(62, Byte), Integer), CType(CType(31, Byte), Integer), CType(CType(31, Byte), Integer))
        Me.Guna2ToggleSwitch1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Guna2ToggleSwitch1.Location = New System.Drawing.Point(6, 293)
        Me.Guna2ToggleSwitch1.Name = "Guna2ToggleSwitch1"
        Me.Guna2ToggleSwitch1.Size = New System.Drawing.Size(50, 20)
        Me.Guna2ToggleSwitch1.TabIndex = 17
        Me.Guna2ToggleSwitch1.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.Guna2ToggleSwitch1.UncheckedState.InnerBorderColor = System.Drawing.Color.White
        Me.Guna2ToggleSwitch1.UncheckedState.InnerColor = System.Drawing.Color.White
        '
        'Guna2HtmlLabel4hwid
        '
        Me.Guna2HtmlLabel4hwid.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel4hwid.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel4hwid.Location = New System.Drawing.Point(6, 67)
        Me.Guna2HtmlLabel4hwid.Name = "Guna2HtmlLabel4hwid"
        Me.Guna2HtmlLabel4hwid.Size = New System.Drawing.Size(51, 15)
        Me.Guna2HtmlLabel4hwid.TabIndex = 14
        Me.Guna2HtmlLabel4hwid.Text = "hwidLabel"
        '
        'Guna2HtmlLabel1Usename
        '
        Me.Guna2HtmlLabel1Usename.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel1Usename.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel1Usename.Location = New System.Drawing.Point(6, 4)
        Me.Guna2HtmlLabel1Usename.Name = "Guna2HtmlLabel1Usename"
        Me.Guna2HtmlLabel1Usename.Size = New System.Drawing.Size(75, 15)
        Me.Guna2HtmlLabel1Usename.TabIndex = 11
        Me.Guna2HtmlLabel1Usename.Text = "usernameLabel"
        '
        'Guna2HtmlLabel2expy
        '
        Me.Guna2HtmlLabel2expy.BackColor = System.Drawing.Color.Transparent
        Me.Guna2HtmlLabel2expy.ForeColor = System.Drawing.Color.DimGray
        Me.Guna2HtmlLabel2expy.Location = New System.Drawing.Point(6, 25)
        Me.Guna2HtmlLabel2expy.Name = "Guna2HtmlLabel2expy"
        Me.Guna2HtmlLabel2expy.Size = New System.Drawing.Size(56, 15)
        Me.Guna2HtmlLabel2expy.TabIndex = 12
        Me.Guna2HtmlLabel2expy.Text = "expiryLabel"
        '
        'mainform
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveCaption
        Me.ClientSize = New System.Drawing.Size(589, 316)
        Me.Controls.Add(Me.Guna2GradientPanel1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "mainform"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "mainform"
        Me.Guna2GradientPanel1.ResumeLayout(False)
        Me.Guna2GradientPanel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Guna2Elipse1 As Guna.UI2.WinForms.Guna2Elipse
    Friend WithEvents Guna2GradientPanel1 As Guna.UI2.WinForms.Guna2GradientPanel
    Friend WithEvents Guna2DragControl1 As Guna.UI2.WinForms.Guna2DragControl
    Friend WithEvents Guna2ControlBox2 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2ControlBox1 As Guna.UI2.WinForms.Guna2ControlBox
    Friend WithEvents Guna2HtmlLabel1Usename As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel6expirdey As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel5lastlogin As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel4hwid As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel3ip As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel2expy As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Timer1 As Timer
    Friend WithEvents Guna2ToggleSwitch1 As Guna.UI2.WinForms.Guna2ToggleSwitch
End Class
