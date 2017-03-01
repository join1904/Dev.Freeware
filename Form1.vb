Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://join1904.dothome.co.kr/Freeware.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        'FTP 에서 버전 값을 가져와서 최신 버전이 아니면 블로그로 이동
        Dim newstversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        Dim filename = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim req = Net.HttpWebRequest.CreateHttp("http://join1904.dothome.co.kr/Freeware.txt")
        Dim res = req.GetResponse
        Dim stream = res.GetResponseStream
        Dim reader = New IO.StreamReader(stream)
        Dim rver = reader.ReadLine.TrimEnd
        If newstversion.Contains(currentversion) Then
            MsgBox("유틸리티 제작 : 프리웨어", vbInformation, "제작")
        Else
            MsgBox("업데이트 버전이 존재합니다.", vbInformation, "버전 정보")
            Shell("explorer http://dev24.kro.kr")
            Label1.Text = ("업데이트 버전이 존재합니다.")
        End If
    End Sub

    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        Form2.Show()
    End Sub

    Private Sub MonoFlat_Button5_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button5.Click
        Form4.Show()
    End Sub
    Private Sub MonoFlat_Button6_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button6.Click
        Form3.Show()
    End Sub

    Private Sub MonoFlat_LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MonoFlat_LinkLabel1.LinkClicked
        Shell("explorer http://blog.naver.com/freeware1904")
    End Sub

    Private Sub MonoFlat_LinkLabel2_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MonoFlat_LinkLabel2.LinkClicked
        Shell("explorer http://www.minecraftforum.net/")
    End Sub

    Private Sub MonoFlat_LinkLabel3_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MonoFlat_LinkLabel3.LinkClicked
        Shell("explorer https://www.fmforum.net/")
    End Sub

    Private Sub MonoFlat_ThemeContainer1_Click(sender As Object, e As EventArgs) Handles MonoFlat_ThemeContainer1.Click

    End Sub

    Private Sub MonoFlat_Button2_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button2.Click
        Form5.Show
    End Sub

    Private Sub MonoFlat_Button4_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button4.Click
        MsgBox("업데이트 계획")
    End Sub

    Private Sub MonoFlat_Button7_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button7.Click
        MsgBox("업데이트 계획")
    End Sub

    Private Sub MonoFlat_Button3_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button3.Click
        MsgBox("업데이트 계획")
    End Sub

    Private Sub MonoFlat_LinkLabel4_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles MonoFlat_LinkLabel4.LinkClicked
        Shell("explorer http://blog.naver.com/won983212/90172804656")
    End Sub
End Class
