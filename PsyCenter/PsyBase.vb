Imports System.Threading
Imports System.Management
Imports System.Diagnostics
Imports System.IO
Imports System
Imports System.Net
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic.Logging
Imports Microsoft.Win32
Module PsyBase
    Dim wmi As ManagementClass, Mobj As ManagementObject, Mobjs As ManagementObjectCollection, CPUID As String, CPUType As String
    Function Popup(message As String)
        MsgBox(message, vbOKOnly, Application.ProductName.ToString)
        Return message
    End Function
    Function getTime()
        Return System.DateTime.Now.ToShortTimeString
    End Function
    Function getDate()
        Return System.DateTime.Today.ToShortDateString
    End Function
    Function PatchOffset()
        Dim FS As System.IO.FileStream, BW As System.IO.BinaryWriter
        FS = New System.IO.FileStream("C:\Users\User\Desktop\7zFM.exe", IO.FileMode.OpenOrCreate)
        BW = New System.IO.BinaryWriter(FS)
        FS.Position = &H6C
        BW.Write(&H204E4957)
        Return FS.ReadByte.ToString
        BW.Close()
        FS.Close()
    End Function
    Function Freespace()
        Return Math.Round(My.Computer.FileSystem.Drives.Item(0).AvailableFreeSpace).ToString
    End Function
    Function Playwav(file)
        My.Computer.Audio.Play(file, AudioPlayMode.Background)
        Return True
    End Function
    Function GetProcInfo()
        wmi = New ManagementClass("Win32_Processor")
        Mobjs = wmi.GetInstances()
        For Each Mobj In Mobjs
            CPUType = Mobj("Name")
            Dim blah As String = "CPU:  " + CPUType.ToString
            CPUID = Mobj("ProcessorID")
            blah = blah + vbCrLf + "Serial: " + CPUID.ToString
            Return blah
        Next
        Mobjs.Dispose()
        wmi.Dispose()
        Return "unknown"
    End Function
    Function Logit(where As String, intentr As String)
        My.Application.Log.WriteEntry(where + " " + intentr)
        Return True
    End Function
    Function EncDec(message As String, frap As Integer, encrypt As Boolean)
        Dim v As Long = CLng(frap) '3
        If encrypt = False Then Return Decryptr(message, v)
        If encrypt = True Then Return Encryptr(message, v)
        Return ""
    End Function
    Private Function Encryptr(s As String, v As Long) As String
        Dim tmp As String, total As String = ""
        For i = 1 To Len(s)
            tmp = Mid(s, i, 1)
            tmp = Asc(tmp) + v
            tmp = Chr(tmp)
            total = total & tmp
        Next i
        Encryptr = total
    End Function
    Private Function Decryptr(s As String, v As Long) As String
        Dim tmp As String, total As String = ""
        For i = 1 To Len(s)
            tmp = Mid(s, i, 1)
            tmp = Asc(tmp) - v
            tmp = Chr(tmp)
            total = total & tmp
        Next i
        Decryptr = total
    End Function
    Function GetMacAddress()
        Dim nics() As NetworkInterface =
                NetworkInterface.GetAllNetworkInterfaces
        Return nics(0).GetPhysicalAddress.ToString
    End Function
    Function Localip()
        Dim hostname As String = Dns.GetHostName()
        Dim iPAddress1 As IPAddress = CType(Dns.GetHostEntry(hostname).AddressList.GetValue(0), IPAddress)
        Dim ipaddress As String = iPAddress1.ToString
        Return ipaddress
    End Function
    Function GetMyIP2() As String
        Using wc As New Net.WebClient
            Return System.Text.Encoding.UTF8.GetString(wc.DownloadData("http://tools.feron.it/php/ip.php"))
        End Using
    End Function
    Function SystemSerialNumber() As String
        Dim wmi As Object = GetObject("WinMgmts:")
        Dim serial_numbers As String = ""
        Dim mother_boards As Object =
                wmi.InstancesOf("Win32_BaseBoard")
        For Each board As Object In mother_boards
            serial_numbers &= ", " & board.SerialNumber
        Next board
        If serial_numbers.Length > 0 Then serial_numbers =
            serial_numbers.Substring(2)
        Return serial_numbers
    End Function
    Function GetMyIP() As String
        Try
            Dim ExternalIP As String
            ExternalIP = (New WebClient()).DownloadString("http://checkip.dyndns.org/")
            ExternalIP = (New Regex("\d{1,3}\.\d{1,3}\.\d{1,3}\.\d{1,3}")) _
                .Matches(ExternalIP)(0).ToString()
            Return ExternalIP
        Catch
            Return Nothing
        End Try
    End Function
End Module
