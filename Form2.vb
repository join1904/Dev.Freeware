Public Class Form2
    Private Sub MonoFlat_ThemeContainer1_Click(sender As Object, e As EventArgs) Handles MonoFlat_ThemeContainer1.Click

    End Sub

    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click

        MsgBox("설치가 시작됩니다.", vbInformation, "시작")

        'FTP 에서 파일을 다운받습니다.
        'FTP의 minecraft.jar 파일을 bin 폴더에 넣습니다. minecraft.jar 파일이 존재한다면 덮어쓰기를 시도합니다.
        My.Computer.Network.DownloadFile("http://join1904.dothome.co.kr/Freeware_Utility/minecraft.jar", Environ("AppData") & "\.minecraft\bin\minecraft.jar", "", "", "false", "100", "true")
        ProgressBar1.Value = "100"
        MsgBox("설치가 완료되었습니다!", vbInformation, "완료")

    End Sub

    Private Sub MonoFlat_Button1_Click_1(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click

    End Sub
End Class