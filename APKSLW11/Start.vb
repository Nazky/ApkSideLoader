Imports System.IO
Imports System.IO.Compression
Imports System.Net
Public Class Start
    Private running As Boolean = False

    Sub DADB()
        InstallAPK.Enabled = False
        ProgressBar1.Visible = True
        Dim adburl As String = "https://dl.google.com/android/repository/platform-tools-latest-windows.zip"
        Directory.CreateDirectory(Application.StartupPath & "/adb")

        Dim webClient As New WebClient()
        AddHandler webClient.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler webClient.DownloadFileCompleted, AddressOf client_DownloadFileCompleted
        webClient.DownloadFileAsync(New Uri(adburl), Application.StartupPath & "/adb/adb.zip")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Sub UnZip(outputFolder As String, inputZip As String)

        ZipFile.ExtractToDirectory(inputZip, outputFolder)

    End Sub

    Public Sub client_ProgressChanged(sender As Object, e As Net.DownloadProgressChangedEventArgs)
        Dim bytesIn As Double = Double.Parse(e.BytesReceived.ToString())
        Dim totalBytes As Double = Double.Parse(e.TotalBytesToReceive.ToString())
        Dim percentage As Double = bytesIn / totalBytes * 100
        ProgressBar1.Value = Integer.Parse(Math.Truncate(percentage).ToString())
    End Sub

    Public Sub client_DownloadFileCompleted(sender As Object, e As System.ComponentModel.AsyncCompletedEventArgs)
        UnZip(Application.StartupPath & "/adb", Application.StartupPath & "/adb/adb.zip")
        ProgressBar1.Value = 0
        File.Delete(Application.StartupPath & "/adb/adb.zip")
        MsgBox("ADB download and extract :)", MsgBoxStyle.Information, "APKSLW11")
        InstallAPK.Enabled = True
        ProgressBar1.Visible = False
    End Sub

    Sub IAPK()
        If CP.Checked = True Then
            Try
                InstallAPK.Enabled = False
                CMD.RunCommandCom(Application.StartupPath & "/adb/platform-tools/adb.exe", "connect " & IP.Text & " && " & Application.StartupPath & "/adb/platform-tools/adb.exe" & " install " & ApkPath.Text, False)
                'MsgBox("Apk installed :)", MsgBoxStyle.Information)
                InstallAPK.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                InstallAPK.Enabled = True
            End Try
        Else
            Try
                InstallAPK.Enabled = False
                CMD.RunCommandCom(Application.StartupPath & "/adb/platform-tools/adb.exe", "connect 127.0.0.1:58526" & " && " & Application.StartupPath & "/adb/platform-tools/adb.exe" & " install " & ApkPath.Text, False)
                'MsgBox("Apk installed :)", MsgBoxStyle.Information)
                InstallAPK.Enabled = True
            Catch ex As Exception
                MsgBox(ex.Message, MsgBoxStyle.Critical)
                InstallAPK.Enabled = True
            End Try

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles InstallAPK.Click
        If InstallAPK.Text = "Install APK" Then
            IAPK()
        ElseIf InstallAPK.Text = "Get ADB" Then
            DADB()
        End If

    End Sub

    Private Sub Start_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.AllowDrop = True
    End Sub

    Private Sub Start_DragDrop(sender As Object, e As DragEventArgs) Handles MyBase.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each path In files
            ApkPath.Text = """" & path & """"
        Next
    End Sub

    Private Sub Start_DragEnter(sender As Object, e As DragEventArgs) Handles MyBase.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CP.CheckedChanged
        If CP.Checked = True Then
            IP.Enabled = True
            IP.Visible = True
        Else
            IP.Enabled = False
            IP.Visible = False
        End If
    End Sub

    Private Sub CADB_Tick(sender As Object, e As EventArgs) Handles CADB.Tick
        If Directory.Exists(Application.StartupPath & "/adb") Then
            InstallAPK.Text = "Install APK"
        Else
            InstallAPK.Text = "Get ADB"
        End If
    End Sub
End Class
