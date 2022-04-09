Imports Microsoft.Win32

Public Class ayarlar

    Private Sub acilisaekle(ByVal name As String, ByVal path As String)
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        key.SetValue(name, path)
    End Sub

    Private Sub acilistankaldir(ByVal name As String)
        Dim key As RegistryKey = Registry.CurrentUser.OpenSubKey("Software\Microsoft\Windows\CurrentVersion\Run", True)
        key.DeleteValue(name, False)
    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then
            My.Settings.ac = True
            My.Settings.Save()
            acilisaekle("StartupExample", System.Reflection.Assembly.GetEntryAssembly.Location)
            MsgBox("Uygulama Başlangıca Eklendi", MsgBoxStyle.Information)
        Else
            My.Settings.ac = False
            My.Settings.Save()
            acilistankaldir("StartupExample")
            MsgBox("Uygulama Başlangıçtan Kaldırıldı!", MsgBoxStyle.Information)
            
        End If
    End Sub

    Private Sub ayarlar_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CheckBox1.Checked = My.Settings.ac
    End Sub
End Class