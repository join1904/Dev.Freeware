Public Class Form5
    Private Sub MonoFlat_Button1_Click(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click
        MsgBox("설치가 시작됩니다.", vbInformation, "시작")
        ProgressBar1.Value = "0"

        'bin 폴더에 노더스.jar 파일을 주입하고 native 파일에 나머지 dll 파일을 넣습니다.
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/Nodus.jar", Environ("AppData") & "\.minecraft\bin\jinput-dx8.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "10"
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/jinput-dx8.dll", Environ("AppData") & "\.minecraft\bin\natives\jinput-dx8.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "20"
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/jinput-dx8_64.dll", Environ("AppData") & "\.minecraft\bin\natives\jinput-dx8_64.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "30"
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/jinput-raw.dll", Environ("AppData") & "\.minecraft\bin\natives\jinput-raw.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "40"
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/jinput-raw_64.dll", Environ("AppData") & "\.minecraft\bin\natives\jinput-raw_64.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "50"
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/jinput-lwjgl.dll", Environ("AppData") & "\.minecraft\bin\natives\lwjgl.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "60"
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/OpenAl32.dll", Environ("AppData") & "\.minecraft\bin\natives\OpenAl64.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "70"
        My.Computer.Network.DownloadFile("http://.dothome.co.kr/Freeware_Utility/lwjgl64.dll", Environ("AppData") & "\.minecraft\bin\natives\lwjgl64.dll", "", "", "false", "100", "true")
        ProgressBar1.Value = "100"
        MsgBox("설치가 완료되었습니다!", vbInformation, "완료")

    End Sub

    Private Sub MonoFlat_Button1_Click_1(sender As Object, e As EventArgs) Handles MonoFlat_Button1.Click

    End Sub
End Class