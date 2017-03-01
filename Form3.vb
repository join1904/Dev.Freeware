Public Class Form3
    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        MsgBox("설치가 시작됩니다.", vbInformation, "시작")
        ProgressBar1.Value = "0"

        '경로에 Minecraft.Jar 설치한다
        'Snoic.Jar 은 소닉쉐이더와 기타 모드를 깔아둔 minecraft.jar 을 뜻한다.
        My.Computer.Network.DownloadFile("http://join1904.dothome.co.kr/Freeware_Utility/Sonic.jar", Environ("AppData") & "\.minecraft\bin\minecraft.jar", "", "", "false", "100", "true")
        ProgressBar1.Value = "30"
        ProgressBar1.Value = "40"
        ProgressBar1.Value = "70"
        My.Computer.Network.DownloadFile("http://join1904.dothome.co.kr/Freeware_Utility/Ultra_DoF_wip.zip", Environ("AppData") & "\.minecraft\shaderpacks\[프리웨어]_쉐이더팩", "join1904", "wnsgur1004", "false", "100", "true")
        ProgressBar1.Value = "100"

        MsgBox("설치가 완료되었습니다!", vbInformation, "완료")

    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub MonoFlat_Button1_Click_1(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click

    End Sub
End Class