Public Class ac

    Private Sub ac_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If MsgBox("Satılan ürünleri kayıt etmek için ürün ve kisi eklemeniz gerekir. Şimdi eklemek istermisiniz ?", vbYesNo) = MsgBoxResult.Yes Then
            Me.Hide()
            kisiurunekle.Show()
        Else
            Me.Hide()
            anaform.Show()
        End If
    End Sub
End Class