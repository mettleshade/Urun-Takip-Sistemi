Imports System.Data.OleDb

Public Class kisiurunekle
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\database.mdb;")

    Private Sub kisiurunekle_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        If TypeOf System.Windows.Forms.Form.ActiveForm Is anaform Then
            Button9.Visible = False
        Else

        End If
        'TODO: This line of code loads data into the 'DatabaseDataSet.urunler' table. You can move, or remove it, as needed.
        Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
        'TODO: This line of code loads data into the 'DatabaseDataSet.kisiler' table. You can move, or remove it, as needed.
        Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)

    End Sub

    Private Sub kisikaydet()
        Try

            If kisiadi.Text = "" Or tel.Text = "" Or adres.Text = "" Then
                MsgBox("Lütfen Boş Kısımları Doldurunuz.", MsgBoxStyle.Critical, "Dikkat !")
            Else
                Dim RastgeleSayi As New Random
                Dim OlusturulanSayi As Integer = RastgeleSayi.Next(1, 9999999)
                Dim Sql, sql2 As String
                Sql = "insert into [kisiler](Sayi,KisiAdi,Telefon,Adres) values ('" & OlusturulanSayi & "','" & kisiadi.Text & "','" & tel.Text & "','" & adres.Text & "')"

                sql2 = "select * from kisiler"
                Dim komut As New OleDbCommand(sql2, baglanti)
                Dim dr As OleDb.OleDbDataReader
                baglanti.Open()
                dr = komut.ExecuteReader
                Do While dr.Read
                    If dr("Sayi") = OlusturulanSayi Then
                        Dim RastgeleSayi1 As New Random
                        Dim OlusturulanSayi1 As Integer = RastgeleSayi1.Next(1, 9999999)
                        Dim komut1 As New OleDbCommand(sql2, baglanti)
                        Dim dr1 As OleDb.OleDbDataReader
                        baglanti.Open()
                        dr1 = komut1.ExecuteReader
                        dr1.Close()
                        komut1.CommandText = Sql
                        komut1.ExecuteNonQuery()
                        baglanti.Close()
                        durum.Text = "Kişi Başarıyla Kaydedilmiştir."
                        durum.ForeColor = Color.Green
                        Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
                        Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
                        anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
                        anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
                        anaform.suadi.Text = ""
                        anaform.saadi.Text = ""
                    End If
                Loop
                dr.Close()
                komut.CommandText = Sql
                komut.ExecuteNonQuery()
                baglanti.Close()
                Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
                Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
                anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
                anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
                anaform.suadi.Text = ""
                anaform.saadi.Text = ""
                durum.Text = "Kişi Başarıyla Kaydedilmiştir."
                durum.ForeColor = Color.Green
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub urunkaydet()
        Try

            If urunadi.Text = "" Or bfiyat.Text = "" Or kacadet.Text = "" Then
                MsgBox("Lütfen Boş Kısımları Doldurunuz.", MsgBoxStyle.Critical, "Dikkat !")
            Else
                Dim RastgeleSayi As New Random
                Dim OlusturulanSayi As Integer = RastgeleSayi.Next(1, 9999999)
                Dim Sql, sql2 As String
                Sql = "insert into [urunler](Sayi,UrunAdi,KacAdet,BFiyat) values ('" & OlusturulanSayi & "','" & urunadi.Text & "','" & kacadet.Text & "','" & bfiyat.Text & "')"

                sql2 = "select * from kisiler"
                Dim komut As New OleDbCommand(sql2, baglanti)
                Dim dr As OleDb.OleDbDataReader
                baglanti.Open()
                dr = komut.ExecuteReader
                Do While dr.Read
                    If dr("Sayi") = OlusturulanSayi Then
                        Dim RastgeleSayi1 As New Random
                        Dim OlusturulanSayi1 As Integer = RastgeleSayi1.Next(1, 9999999)
                        Dim komut1 As New OleDbCommand(sql2, baglanti)
                        Dim dr1 As OleDb.OleDbDataReader
                        baglanti.Open()
                        dr1 = komut1.ExecuteReader
                        dr1.Close()
                        komut1.CommandText = Sql
                        komut1.ExecuteNonQuery()
                        baglanti.Close()
                        Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
                        Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
                        anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
                        anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
                        anaform.suadi.Text = ""
                        anaform.saadi.Text = ""
                        durum.Text = "Urun Başarıyla Kayıt Edilmiştir."
                        durum.ForeColor = Color.Green
                    End If
                Loop
                dr.Close()
                komut.CommandText = Sql
                komut.ExecuteNonQuery()
                baglanti.Close()
                Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
                Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
                anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
                anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
                anaform.suadi.Text = ""
                anaform.saadi.Text = ""
                durum.Text = "Urun Başarıyla Kayıt Edilmiştir."
                durum.ForeColor = Color.Green
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub temizle()
        kisiadi.Text = ""
        tel.Text = ""
        adres.Text = ""
    End Sub

    Private Sub temizle1()
        urunadi.Text = ""
        kacadet.Text = ""
        bfiyat.Text = ""
    End Sub

    Private Sub kisiguncelleme()
        Try
            baglanti.Open()
            Dim sql As String
            sql = "update kisiler set KisiAdi ='" & kisiadi.Text & "', Adres ='" & adres.Text & "', Telefon ='" & tel.Text & "' where Sayi='" & Label7.Text & "'"
            Dim komut As New OleDbCommand
            komut.Connection = baglanti
            komut.CommandText = sql
            komut.ExecuteNonQuery()
            baglanti.Close()
            Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
            Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
            anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
            anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
            anaform.suadi.Text = ""
            anaform.saadi.Text = ""
            durum.Text = "Bilgiler Başarıyla Güncellenmiştir."
            durum.ForeColor = Color.Green
        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub urunguncelleme()
        Try
            baglanti.Open()
            Dim sql As String
            sql = "update urunler set UrunAdi ='" & urunadi.Text & "', KacAdet ='" & kacadet.Text & "', BFiyat ='" & bfiyat.Text & "' where Sayi='" & Label8.Text & "'"
            Dim komut As New OleDbCommand
            komut.Connection = baglanti
            komut.CommandText = sql
            komut.ExecuteNonQuery()
            baglanti.Close()
            Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
            Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
            anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
            anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
            anaform.suadi.Text = ""
            anaform.saadi.Text = ""
            durum.Text = "Bilgiler Başarıyla Güncellenmiştir."
            durum.ForeColor = Color.Green
        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub kisisilme()
        Try
            If MsgBox(kisiadi.Text & " İsimli Kayıt Silinsinmi ?", MsgBoxStyle.YesNoCancel, "Dikkat !") = vbYes Then
                Dim sql As String
                sql = "delete from kisiler where Sayi='" & Label7.Text & "'"
                Dim komut As New OleDbCommand
                komut.Connection = baglanti
                komut.CommandText = sql
                baglanti.Open()
                komut.ExecuteNonQuery()
                Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
                Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
                anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
                anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
                anaform.suadi.Text = ""
                anaform.saadi.Text = ""
                    
                durum.Text = "Seçilen Kayıt Başarıyla Silindi."
                durum.ForeColor = Color.Green
                baglanti.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub urunsilme()
        Try
            If MsgBox(urunadi.Text & " İsimli Kayıt Silinsinmi ?", MsgBoxStyle.YesNoCancel, "Dikkat !") = vbYes Then
                Dim sql As String
                sql = "delete from urunler where Sayi='" & Label8.Text & "'"
                Dim komut As New OleDbCommand
                komut.Connection = baglanti
                komut.CommandText = sql
                baglanti.Open()
                komut.ExecuteNonQuery()
                Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
                Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
                anaform.KisilerTableAdapter.Fill(anaform.DatabaseDataSet.kisiler)
                anaform.UrunlerTableAdapter.Fill(anaform.DatabaseDataSet.urunler)
                anaform.suadi.Text = ""
                anaform.saadi.Text = ""
                durum.Text = "Seçilen Kayıt Başarıyla Silindi."
                durum.ForeColor = Color.Green
                baglanti.Close()

            End If

        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            kisiadi.Text = DataGridView1.Item(1, i).Value
            tel.Text = DataGridView1.Item(2, i).Value
            adres.Text = DataGridView1.Item(3, i).Value
            Label7.Text = DataGridView1.Item(4, i).Value
        Catch ex As Exception
            MsgBox(ex.Message & "Lütfen Bir Kayıt Seçin", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub DataGridView2_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView2.CellMouseClick
        Try
            Dim i As Integer
            i = DataGridView2.CurrentRow.Index
            urunadi.Text = DataGridView2.Item(1, i).Value
            bfiyat.Text = DataGridView2.Item(2, i).Value
            kacadet.Text = DataGridView2.Item(3, i).Value
            Label8.Text = DataGridView2.Item(4, i).Value
        Catch ex As Exception
            MsgBox(ex.Message & "Lütfen Bir Kayıt Seçin", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        kisikaydet()
    End Sub

    Private Sub Button8_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button8.Click
        urunkaydet()
    End Sub
    
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        kisiguncelleme()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        kisisilme()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        temizle()
    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        temizle1()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        urunguncelleme()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        urunsilme()
    End Sub

    Private Sub Button9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button9.Click
        Me.Close()
        anaform.Show()
    End Sub
End Class