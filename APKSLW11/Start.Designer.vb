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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Start))
        Me.ApkPath = New System.Windows.Forms.TextBox()
        Me.InstallAPK = New System.Windows.Forms.Button()
        Me.IP = New System.Windows.Forms.TextBox()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.CP = New System.Windows.Forms.CheckBox()
        Me.CADB = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
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
        Me.InstallAPK.Location = New System.Drawing.Point(12, 63)
        Me.InstallAPK.Name = "InstallAPK"
        Me.InstallAPK.Size = New System.Drawing.Size(320, 23)
        Me.InstallAPK.TabIndex = 2
        Me.InstallAPK.Text = "Install APK"
        Me.InstallAPK.UseVisualStyleBackColor = True
        '
        'IP
        '
        Me.IP.Enabled = False
        Me.IP.Location = New System.Drawing.Point(113, 37)
        Me.IP.Name = "IP"
        Me.IP.Size = New System.Drawing.Size(219, 20)
        Me.IP.TabIndex = 3
        Me.IP.Text = "IP Here"
        Me.IP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.IP.Visible = False
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(12, 92)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(320, 11)
        Me.ProgressBar1.TabIndex = 5
        Me.ProgressBar1.Visible = False
        '
        'CP
        '
        Me.CP.AutoSize = True
        Me.CP.ForeColor = System.Drawing.Color.White
        Me.CP.Location = New System.Drawing.Point(12, 40)
        Me.CP.Name = "CP"
        Me.CP.Size = New System.Drawing.Size(95, 17)
        Me.CP.TabIndex = 6
        Me.CP.Text = "Use custom IP"
        Me.CP.UseVisualStyleBackColor = True
        '
        'CADB
        '
        Me.CADB.Enabled = True
        '
        'Start
        '
        Me.AllowDrop = True
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(342, 116)
        Me.Controls.Add(Me.CP)
        Me.Controls.Add(Me.ProgressBar1)
        Me.Controls.Add(Me.IP)
        Me.Controls.Add(Me.InstallAPK)
        Me.Controls.Add(Me.ApkPath)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Start"
        Me.Text = "APK SideLoader"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ApkPath As TextBox
    Friend WithEvents InstallAPK As Button
    Friend WithEvents IP As TextBox
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents CP As CheckBox
    Friend WithEvents CADB As Timer
End Class
