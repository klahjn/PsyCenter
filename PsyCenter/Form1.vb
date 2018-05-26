Imports System.ComponentModel
Imports PsyCenter.PsyBase
Public Class Form1
    Dim sizeW As String = My.Settings.SizeW
    Dim sizeH As String = My.Settings.SizeH
    Dim blaSter As String = My.Settings.blah
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim working_area As Rectangle = SystemInformation.WorkingArea
        Dim x As Integer = working_area.Left + working_area.Width - Me.Width
        Dim y As Integer = working_area.Top + working_area.Height - Me.Height
        With Me
            .Width = sizeW
            .Height = sizeH
            .Location = New Point(x, y)
            .Text = Application.ProductName.ToString + " " + Application.ProductVersion.ToString
            .NumericUpDown1.Value = blaSter
            .Label2.Text = GetProcInfo.ToString
            .StatusMAC.Text = GetMacAddress()
            .StatusIP.Text = Localip()
            .StatusExIP.Text = GetMyIP().ToString
            .lblMBSer.Text = "MB Serial:" + SystemSerialNumber()
        End With
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Popup(TextBox1.Text)
        TextBox1.Text = ""
    End Sub
    Private Sub Form1_ResizeBegin(sender As Object, e As EventArgs) Handles Me.ResizeBegin
        Me.Width = sizeW : Me.Height = sizeH
    End Sub
    Private Sub Form1_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        Me.Width = sizeW : Me.Height = sizeH
    End Sub
    Private Sub Form1_ResizeEnd(sender As Object, e As EventArgs) Handles Me.ResizeEnd
        Me.Width = sizeW : Me.Height = sizeH
    End Sub
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        StatusTime.Text = getTime()
        StatusDate.Text = getDate()
        StatusFreeSpace.Text = Decimal.Round(Freespace() / 1024 / 1024 / 1024 / 1024, 2).ToString + "TB"
        StatusCPU.Text = "CPU:" + pcCPU.NextValue.ToString + "% "
        StatusRAM.Text = "RAM:" + pcRAM.NextValue.ToString + "% "
        If CheckBox1.Checked = True Then Me.TopMost = True
        If CheckBox1.Checked = False Then Me.TopMost = False
        System.Threading.Thread.Sleep(65)
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        'Dim offs As String = TextBox2.Text
        PatchOffset()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim FB As Integer
        If System.IO.File.Exists(Application.StartupPath + "\Files\Sounds\seize.wav") Then
            Playwav(Application.StartupPath + "\Files\Sounds\seize.wav")
        End If
        While FB < 10
            Me.Location = New Point(Me.Location.X + 20, Me.Location.Y + 20)
            System.Threading.Thread.Sleep(30)
            Me.Location = New Point(Me.Location.X - 20, Me.Location.Y - 20)
            System.Threading.Thread.Sleep(20)
            FB += 1
        End While
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TextBox3.Text = EncDec(TextBox3.Text, NumericUpDown1.Value, True)
        My.Settings.blah = NumericUpDown1.Value
        My.Settings.Save()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        TextBox3.Text = EncDec(TextBox3.Text, NumericUpDown1.Value, False)
        My.Settings.blah = NumericUpDown1.Value
        My.Settings.Save()
    End Sub

    Private Sub Form1_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing
        SystrayIcon.Visible = False
        SystrayIcon.Dispose()
        SystrayIcon = Nothing
        My.Settings.blah = NumericUpDown1.Value
        My.Settings.Save()
    End Sub
End Class
