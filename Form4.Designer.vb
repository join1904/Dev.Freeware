<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.MonoFlat_ThemeContainer1 = New WindowsApplication4.MonoFlat.MonoFlat_ThemeContainer()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.MonoFlat_ControlBox1 = New WindowsApplication4.MonoFlat.MonoFlat_ControlBox()
        Me.MonoFlat_ThemeContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MonoFlat_ThemeContainer1
        '
        Me.MonoFlat_ThemeContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(41, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.MonoFlat_ThemeContainer1.Controls.Add(Me.WebBrowser1)
        Me.MonoFlat_ThemeContainer1.Controls.Add(Me.MonoFlat_ControlBox1)
        Me.MonoFlat_ThemeContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MonoFlat_ThemeContainer1.Font = New System.Drawing.Font("나눔고딕", 8.999999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.MonoFlat_ThemeContainer1.Location = New System.Drawing.Point(0, 0)
        Me.MonoFlat_ThemeContainer1.Name = "MonoFlat_ThemeContainer1"
        Me.MonoFlat_ThemeContainer1.Padding = New System.Windows.Forms.Padding(10, 70, 10, 9)
        Me.MonoFlat_ThemeContainer1.RoundCorners = True
        Me.MonoFlat_ThemeContainer1.Sizable = True
        Me.MonoFlat_ThemeContainer1.Size = New System.Drawing.Size(502, 258)
        Me.MonoFlat_ThemeContainer1.SmartBounds = True
        Me.MonoFlat_ThemeContainer1.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.MonoFlat_ThemeContainer1.TabIndex = 0
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(13, 73)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(20, 20)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(476, 173)
        Me.WebBrowser1.TabIndex = 1
        '
        'MonoFlat_ControlBox1
        '
        Me.MonoFlat_ControlBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.MonoFlat_ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.MonoFlat_ControlBox1.EnableHoverHighlight = False
        Me.MonoFlat_ControlBox1.EnableMaximizeButton = True
        Me.MonoFlat_ControlBox1.EnableMinimizeButton = True
        Me.MonoFlat_ControlBox1.Location = New System.Drawing.Point(390, 15)
        Me.MonoFlat_ControlBox1.Name = "MonoFlat_ControlBox1"
        Me.MonoFlat_ControlBox1.Size = New System.Drawing.Size(100, 25)
        Me.MonoFlat_ControlBox1.TabIndex = 0
        Me.MonoFlat_ControlBox1.Text = "MonoFlat_ControlBox1"
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(502, 258)
        Me.Controls.Add(Me.MonoFlat_ThemeContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Form4"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Form4"
        Me.TransparencyKey = System.Drawing.Color.Fuchsia
        Me.MonoFlat_ThemeContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents MonoFlat_ThemeContainer1 As MonoFlat.MonoFlat_ThemeContainer
    Friend WithEvents MonoFlat_ControlBox1 As MonoFlat.MonoFlat_ControlBox
    Friend WithEvents WebBrowser1 As WebBrowser
End Class
