<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.StatusStrip1 = New System.Windows.Forms.StatusStrip()
        Me.StatusCPU = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusRAM = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusFreeSpace = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusMAC = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusExIP = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusTime = New System.Windows.Forms.ToolStripStatusLabel()
        Me.StatusDate = New System.Windows.Forms.ToolStripStatusLabel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.pcRAM = New System.Diagnostics.PerformanceCounter()
        Me.pcCPU = New System.Diagnostics.PerformanceCounter()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.SystrayIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.lblMBSer = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.StatusStrip1.SuspendLayout()
        CType(Me.pcRAM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pcCPU, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(276, 10)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Popup"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 12)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(258, 20)
        Me.TextBox1.TabIndex = 1
        Me.TextBox1.Text = "Popup Test Message"
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1460
        '
        'StatusStrip1
        '
        Me.StatusStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.StatusCPU, Me.StatusRAM, Me.StatusFreeSpace, Me.StatusMAC, Me.StatusIP, Me.StatusExIP, Me.StatusTime, Me.StatusDate})
        Me.StatusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow
        Me.StatusStrip1.Location = New System.Drawing.Point(0, 116)
        Me.StatusStrip1.Name = "StatusStrip1"
        Me.StatusStrip1.Size = New System.Drawing.Size(596, 20)
        Me.StatusStrip1.TabIndex = 2
        Me.StatusStrip1.Text = "StatusStrip1"
        '
        'StatusCPU
        '
        Me.StatusCPU.Name = "StatusCPU"
        Me.StatusCPU.Size = New System.Drawing.Size(27, 15)
        Me.StatusCPU.Text = "cpu"
        '
        'StatusRAM
        '
        Me.StatusRAM.Name = "StatusRAM"
        Me.StatusRAM.Size = New System.Drawing.Size(33, 15)
        Me.StatusRAM.Text = "RAM"
        '
        'StatusFreeSpace
        '
        Me.StatusFreeSpace.Name = "StatusFreeSpace"
        Me.StatusFreeSpace.Size = New System.Drawing.Size(18, 15)
        Me.StatusFreeSpace.Text = "C:"
        '
        'StatusMAC
        '
        Me.StatusMAC.Name = "StatusMAC"
        Me.StatusMAC.Size = New System.Drawing.Size(34, 15)
        Me.StatusMAC.Text = "MAC"
        '
        'StatusIP
        '
        Me.StatusIP.Name = "StatusIP"
        Me.StatusIP.Size = New System.Drawing.Size(31, 15)
        Me.StatusIP.Text = "intIP"
        '
        'StatusExIP
        '
        Me.StatusExIP.Name = "StatusExIP"
        Me.StatusExIP.Size = New System.Drawing.Size(32, 15)
        Me.StatusExIP.Text = "extIP"
        '
        'StatusTime
        '
        Me.StatusTime.Name = "StatusTime"
        Me.StatusTime.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.StatusTime.Size = New System.Drawing.Size(31, 15)
        Me.StatusTime.Text = "time"
        '
        'StatusDate
        '
        Me.StatusDate.Name = "StatusDate"
        Me.StatusDate.Size = New System.Drawing.Size(30, 15)
        Me.StatusDate.Spring = True
        Me.StatusDate.Text = "date"
        '
        'Button2
        '
        Me.Button2.Enabled = False
        Me.Button2.Location = New System.Drawing.Point(357, 36)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(75, 23)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Hex"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(276, 39)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(75, 20)
        Me.TextBox2.TabIndex = 4
        Me.TextBox2.Text = "Coming Soon!"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(357, 9)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(75, 23)
        Me.Button3.TabIndex = 5
        Me.Button3.Text = "Seizure"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'pcRAM
        '
        Me.pcRAM.CategoryName = "Memory"
        Me.pcRAM.CounterName = "% Committed Bytes In Use"
        '
        'pcCPU
        '
        Me.pcCPU.CategoryName = "Processor"
        Me.pcCPU.CounterName = "% Processor Time"
        Me.pcCPU.InstanceName = "_Total"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(433, 8)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(84, 17)
        Me.CheckBox1.TabIndex = 7
        Me.CheckBox1.Text = "Stay on Top"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 13)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "CPU INFO"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(12, 77)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(234, 20)
        Me.TextBox3.TabIndex = 9
        Me.TextBox3.Text = "Encrypt and Decrypt"
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(296, 75)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(65, 23)
        Me.Button4.TabIndex = 10
        Me.Button4.Text = "Encrypt"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(367, 75)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(65, 23)
        Me.Button5.TabIndex = 11
        Me.Button5.Text = "Decrypt"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(252, 77)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {129, 0, 0, 0})
        Me.NumericUpDown1.Minimum = New Decimal(New Integer() {1, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(38, 20)
        Me.NumericUpDown1.TabIndex = 12
        Me.NumericUpDown1.Value = New Decimal(New Integer() {7, 0, 0, 0})
        '
        'SystrayIcon
        '
        Me.SystrayIcon.BalloonTipText = "Work in Progress!"
        Me.SystrayIcon.Icon = CType(resources.GetObject("SystrayIcon.Icon"), System.Drawing.Icon)
        Me.SystrayIcon.Text = "PsyCenter"
        Me.SystrayIcon.Visible = True
        '
        'lblMBSer
        '
        Me.lblMBSer.AutoSize = True
        Me.lblMBSer.Location = New System.Drawing.Point(435, 79)
        Me.lblMBSer.Name = "lblMBSer"
        Me.lblMBSer.Size = New System.Drawing.Size(52, 13)
        Me.lblMBSer.TabIndex = 13
        Me.lblMBSer.Text = "MB Serial"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.PsyCenter.My.Resources.Resources.psycenter
        Me.PictureBox1.Location = New System.Drawing.Point(511, 8)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(73, 67)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 14
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlDark
        Me.ClientSize = New System.Drawing.Size(596, 136)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lblMBSer)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.StatusStrip1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form1"
        Me.StatusStrip1.ResumeLayout(False)
        Me.StatusStrip1.PerformLayout()
        CType(Me.pcRAM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pcCPU, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button1 As Button
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Timer1 As Timer
    Friend WithEvents StatusStrip1 As StatusStrip
    Friend WithEvents StatusTime As ToolStripStatusLabel
    Friend WithEvents StatusDate As ToolStripStatusLabel
    Friend WithEvents Button2 As Button
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button3 As Button
    Friend WithEvents StatusFreeSpace As ToolStripStatusLabel
    Friend WithEvents StatusCPU As ToolStripStatusLabel
    Friend WithEvents StatusRAM As ToolStripStatusLabel
    Friend WithEvents pcRAM As PerformanceCounter
    Friend WithEvents pcCPU As PerformanceCounter
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Button4 As Button
    Friend WithEvents Button5 As Button
    Friend WithEvents NumericUpDown1 As NumericUpDown
    Friend WithEvents SystrayIcon As NotifyIcon
    Friend WithEvents StatusMAC As ToolStripStatusLabel
    Friend WithEvents StatusIP As ToolStripStatusLabel
    Friend WithEvents StatusExIP As ToolStripStatusLabel
    Friend WithEvents lblMBSer As Label
    Friend WithEvents PictureBox1 As PictureBox
End Class
