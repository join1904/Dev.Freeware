<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
    Inherits System.Windows.Forms.Form

    'Form은 Dispose를 재정의하여 구성 요소 목록을 정리합니다.
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

    'Windows Form 디자이너에 필요합니다.
    Private components As System.ComponentModel.IContainer

    '참고: 다음 프로시저는 Windows Form 디자이너에 필요합니다.
    '수정하려면 Windows Form 디자이너를 사용하십시오.  
    '코드 편집기에서는 수정하지 마세요.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form5))
        Me.MonoFlat_ThemeContainer1 = New WindowsApplication4.MonoFlat.MonoFlat_ThemeContainer()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.MonoFlat_Button1 = New WindowsApplication4.MonoFlat.MonoFlat_Button()
        Me.MonoFlat_ControlBox1 = New WindowsApplication4.MonoFlat.MonoFlat_ControlBox()
        Me.MonoFlat_ThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonoFlat_ThemeContainer1
        '
        Me.MonoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MonoFlat_ThemeContainer1.Controls.Add(Me.Label1)
        Me.MonoFlat_ThemeContainer1.Controls.Add(Me.ProgressBar1)
        Me.MonoFlat_ThemeContainer1.Controls.Add(Me.MonoFlat_Button1)
        Me.MonoFlat_ThemeContainer1.Controls.Add(Me.MonoFlat_ControlBox1)
        Me.MonoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonoFlat_ThemeContainer1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.MonoFlat_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.MonoFlat_ThemeContainer1.Name = "MonoFlat_ThemeContainer1"
        Me.MonoFlat_ThemeContainer1.Padding = New System.Windows.Forms.Padding(10, 70, 10, 9)
        Me.MonoFlat_ThemeContainer1.RoundCorners = True
        Me.MonoFlat_ThemeContainer1.Sizable = True
        Me.MonoFlat_ThemeContainer1.Size = New System.Drawing.Size(347, 156)
        Me.MonoFlat_ThemeContainer1.SmartBounds = True
        Me.MonoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MonoFlat_ThemeContainer1.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(12, 94)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(121, 15)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "노더스가 설치됩니다."
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Location = New System.Drawing.Point(10, 117)
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(231, 27)
        Me.ProgressBar1.TabIndex = 3
        '
        'MonoFlat_Button1
        '
        Me.MonoFlat_Button1.BackColor = System.Drawing.Color.Transparent
        Me.MonoFlat_Button1.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.MonoFlat_Button1.Image = Nothing
        Me.MonoFlat_Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.MonoFlat_Button1.Location = New System.Drawing.Point(247, 103)
        Me.MonoFlat_Button1.Name = "MonoFlat_Button1"
        Me.MonoFlat_Button1.Size = New System.Drawing.Size(87, 41)
        Me.MonoFlat_Button1.TabIndex = 2
        Me.MonoFlat_Button1.Text = "설치"
        Me.MonoFlat_Button1.TextAlignment = System.Drawing.StringAlignment.Center
        '
        'MonoFlat_ControlBox1
        '
        Me.MonoFlat_ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonoFlat_ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonoFlat_ControlBox1.EnableHoverHighlight = False
        Me.MonoFlat_ControlBox1.EnableMaximizeButton = True
        Me.MonoFlat_ControlBox1.EnableMinimizeButton = True
        Me.MonoFlat_ControlBox1.Location = New System.Drawing.Point(235, 15)
        Me.MonoFlat_ControlBox1.Name = "MonoFlat_ControlBox1"
        Me.MonoFlat_ControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.MonoFlat_ControlBox1.TabIndex = 1
        Me.MonoFlat_ControlBox1.Text = "MonoFlat_ControlBox1"
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(347, 156)
        Me.Controls.Add(Me.MonoFlat_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form5"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form5"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MonoFlat_ThemeContainer1.ResumeLayout(False)
        Me.MonoFlat_ThemeContainer1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonoFlat_ThemeContainer1 As MonoFlat.MonoFlat_ThemeContainer
    Friend WithEvents ProgressBar1 As ProgressBar
    Friend WithEvents MonoFlat_Button1 As MonoFlat.MonoFlat_Button
    Friend WithEvents MonoFlat_ControlBox1 As MonoFlat.MonoFlat_ControlBox
    Friend WithEvents Label1 As Label
End Class
