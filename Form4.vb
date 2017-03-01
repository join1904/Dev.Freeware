Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'FTP 에서 내가 업로드한 메모장 파일을 웹브라우저에 출력시킨다.
        Dim request As System.Net.HttpWebRequest = System.Net.HttpWebRequest.Create("http://join1904.dothome.co.kr/Freeware_Announce.txt")
        Dim response As System.Net.HttpWebResponse = request.GetResponse()

        Dim sr As System.IO.StreamReader = New System.IO.StreamReader(response.GetResponseStream())

        Dim newstversion As String = sr.ReadToEnd()
        Dim currentversion As String = Application.ProductVersion
        Dim filename = System.Reflection.Assembly.GetExecutingAssembly.Location
        Dim req = Net.HttpWebRequest.CreateHttp("http://join1904.dothome.co.kr/Freeware_Announce.txt")
        Dim res = req.GetResponse
        Dim stream = res.GetResponseStream
        Dim reader = New IO.StreamReader(stream)
        Dim rver = reader.ReadLine.TrimEnd

        WebBrowser1.Navigate("http://join1904.dothome.co.kr/Freeware_Announce.txt")
    End Sub
End Class