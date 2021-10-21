<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Start
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.GetADB = New System.Windows.Forms.Button()
        Me.ApkPath = New System.Windows.Forms.TextBox()
        Me.InstallAPK = New System.Windows.Forms.Button()
        Me.IP = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'GetADB
        '
        Me.GetADB.Location = New System.Drawing.Point(703, 12)
        Me.GetADB.Name = "GetADB"
        Me.GetADB.Size = New System.Drawing.Size(85, 23)
        Me.GetADB.TabIndex = 0
        Me.GetADB.Text = "Get ADB"
        Me.GetADB.UseVisualStyleBackColor = True
        '
        'ApkPath
        '
        Me.ApkPath.Location = New System.Drawing.Point(12, 14)
        Me.ApkPath.Name = "ApkPath"
        Me.ApkPath.Size = New System.Drawing.Size(320, 20)
        Me.ApkPath.TabIndex = 1
        Me.ApkPath.Text = "Drag and drop apk here"
        Me.ApkPath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'InstallAPK
        '
        Me.InstallAPK.Location = New System.Drawing.Point(588, 12)
        Me.InstallAPK.Name = "InstallAPK"
        Me.InstallAPK.Size = New System.Drawing.Size(109, 23)
        Me.InstallAPK.TabIndex = 2
        Me.InstallAPK.Text = "Install APK"
        Me.InstallAPK.UseVisualStyleBackColor = True
        '
        'IP
        '
        Me.IP.Enabled = False
        Me.IP.Location = New System.Drawing.Point(430, 14)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(152, 20)
        Me.IP.TabIndex = 3
        Me.IP.Text = "IP Here"
        Me.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 53)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(776, 11)
        Me.ProgressBar1.TabIndex = 5
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.ForeColor = System.Drawing.Color.White
        Me.CheckBox1.Location = New System.Drawing.Point(338, 16)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(95, 17)
        Me.CheckBox1.TabIndex = 6
        Me.CheckBox1.Text = "Use custom IP"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Start
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(799, 69)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.IP)
        Me.Controls.Add(Me.InstallAPK)
        Me.Controls.Add(Me.ApkPath)
        Me.Controls.Add(Me.GetADB)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.Text = "APK SideLoader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GetADB As Button
    Friend WithEvents ApkPath As TextBox
    Friend WithEvents InstallAPK As Button
    Friend WithEvents IP As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CheckBox1 As CheckBox
End Class
