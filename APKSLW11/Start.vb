Imports System.IO
Imports System.IO.Compression
Imports System.Net
Public Class Start
    Private running As Boolean = False

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles GetADB.Click
        Dim adburl As String = "https://dl.google.com/android/repository/platform-tools-latest-windows.zip"
        Directory.CreateDirectory(Application.StartupPath & "/adb")

        Dim webClient As New WebClient()
        AddHandler webClient.DownloadProgressChanged, AddressOf client_ProgressChanged
        AddHandler webClient.DownloadFileCompleted, AddressOf client_DownloadFileCompleted
        webClient.DownloadFileAsync(New Uri(adburl), Application.StartupPath & "/adb/adb.zip")
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
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles InstallAPK.Click
        Try
            CMD.RunCommandCom(Application.StartupPath & "/adb/platform-tools/adb.exe", "connect " & IP.Text & " && " & Application.StartupPath & "/adb/platform-tools/adb.exe" & " install " & ApkPath.Text, False)
            'MsgBox("Apk installed :)", MsgBoxStyle.Information)
        Catch ex As Exception
            MsgBox(ex.Message, MsgBoxStyle.Critical)
        End Try
    End Sub

    Private Sub ApkPath_TextChanged(sender As Object, e As EventArgs) Handles ApkPath.TextChanged

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
End Class
