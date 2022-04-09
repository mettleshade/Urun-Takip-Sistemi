Imports System.Data.OleDb
Imports System.Net.Mail

Public Class ceksenet
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\database.mdb;")
    Dim komut As New OleDbCommand("select * from ceksenet", baglanti)
    Dim dr As OleDb.OleDbDataReader



    Private Sub ceksenetkaydet()
        Try

            If odeceyecekkisiadi.Text = "" Or odenecekkisiadi.Text = "" Or odenecektutar.Text = "" Then
                MsgBox("Lütfen Boş Kısımları Doldurunuz.", MsgBoxStyle.Critical, "Dikkat !")
            Else
                Dim RastgeleSayi As New Random
                Dim OlusturulanSayi As Integer = RastgeleSayi.Next(1, 9999999)
                Dim Sql, sql2 As String
                Sql = "insert into [ceksenet](Sayi,OdeyecekKisiAdi,Adres,TC,Telefon,KefilKisiAdi,KefilTel,KefilTc,OdenecekKisiAdi,OdenecekTutar,Tarih,Durum) values ('" & OlusturulanSayi & "','" & odeceyecekkisiadi.Text & "','" & adres.Text & "','" & tckimlikno.Text & "','" & tel.Text & "','" & kefilisim.Text & "','" & kefiltel.Text & "','" & kefiltc.Text & "','" & odenecekkisiadi.Text & "','" & odenecektutar.Text & "','" & tarih.Text & "','" & "Gonderilmedi" & "')"

                sql2 = "select * from ceksenet"
                Dim komut As New OleDbCommand(sql2, baglanti)
                Dim dr2 As OleDb.OleDbDataReader
                baglanti.Close()
                baglanti.Open()
                dr2 = komut.ExecuteReader
                Do While dr2.Read
                    If dr2("Sayi") = OlusturulanSayi Then
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
                        Me.CeksenetTableAdapter.Fill(Me.DatabaseDataSet.ceksenet)
                        temizle()
                        MsgBox("Senet Kayıt Edilmiştir.", MsgBoxStyle.Information, "Dikkat !")
                    End If
                Loop
                dr2.Close()
                komut.CommandText = Sql
                komut.ExecuteNonQuery()
                baglanti.Close()
                Me.CeksenetTableAdapter.Fill(Me.DatabaseDataSet.ceksenet)

                MsgBox("Senet Kayıt Edilmiştir.", MsgBoxStyle.Information, "Dikkat !")
                temizle()
            End If
        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub guncelleme()
        Try
            baglanti.Open()
            Dim sql As String
            sql = "update ceksenet set OdeyecekKisiAdi ='" & odeceyecekkisiadi.Text & "', Adres ='" & adres.Text & "', TC ='" & tckimlikno.Text & "', Telefon='" & tel.Text & "', KefilKisiAdi ='" & kefilisim.Text & "', KefilTel ='" & kefiltel.Text & "', KefilTc ='" & kefiltc.Text & "', OdenecekKisiAdi ='" & odenecekkisiadi.Text & "', OdenecekTutar ='" & odenecektutar.Text & "', OdenecekTarih ='" & tarih.Text & "' where Sayi='" & sayi.Text & "'"
            Dim komut As New OleDbCommand
            komut.Connection = baglanti
            komut.CommandText = sql
            komut.ExecuteNonQuery()
            baglanti.Close()
            Me.CeksenetTableAdapter.Fill(Me.DatabaseDataSet.ceksenet)

            MsgBox("Bilgiler Başarıyla Güncellenmiştir.", MsgBoxStyle.Information, "Dikkat !")
        Catch ex As Exception
            MsgBox("İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub silme()
        Try
            If MsgBox(odeceyecekkisiadi.Text & " İsimli Kayıt Silinsinmi ?", MsgBoxStyle.YesNoCancel, "Dikkat !") = vbYes Then
                Dim sql As String
                sql = "delete from ceksenet where Sayi='" & sayi.Text & "'"
                Dim komut As New OleDbCommand
                komut.Connection = baglanti
                komut.CommandText = sql
                baglanti.Open()
                komut.ExecuteNonQuery()
                Me.CeksenetTableAdapter.Fill(Me.DatabaseDataSet.ceksenet)

                MsgBox("Seçilen Kayıt Başarıyla Silindi.", MsgBoxStyle.Information, "Dikkat !")
                baglanti.Close()

            End If

        Catch ex As Exception
            MsgBox("İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        sayicek()
        mesajgönder()
        gönderildiolarakisaretle()
        Me.CeksenetTableAdapter.Fill(Me.DatabaseDataSet.ceksenet)
    End Sub


    Private Sub sayicek()
        Try
            baglanti.Close()
            baglanti.Open()
            dr = komut.ExecuteReader
            Do While dr.Read
                If dr("Tarih") = Today And dr("Durum") = "Gonderilmedi" Then
                    sayi.Text = dr("Sayi")
                    odenecekkisiadi.Text = dr("OdenecekKisiAdi")
                    adres.Text = dr("Adres")
                    tel.Text = dr("Telefon")
                    kefilisim.Text = dr("KefilKisiAdi")
                    kefiltel.Text = dr("KefilTel")
                    kefiltc.Text = dr("KefilTc")
                    odeceyecekkisiadi.Text = dr("OdeyecekKisiAdi")
                    odenecektutar.Text = dr("OdenecekTutar")
                    tarih.Text = dr("Tarih")
                    tckimlikno.Text = dr("TC")

                End If
            Loop

            baglanti.Close()

        Catch ex As Exception
            MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try


    End Sub

    Private Sub mesajgönder()

        Dim Mail As New MailMessage
        Mail.Subject = "Senet Ödeme Tarih Hatırlatıcı -- Mettless Dizayn"
        Mail.To.Add("pinar.aktn42@gmail.com")
        Mail.From = New MailAddress("pinar.aktn42@gmail.com")
        Mail.Body = "----------------------------------------------" & vbCrLf & vbCrLf & "Ödenecek Kişi : " & odenecekkisiadi.Text & vbCrLf & "Ödenecek Tutar : " & odenecektutar.Text & vbCrLf & "Ödenecek Tarih : " & tarih.Text & vbCrLf & vbCrLf & "----------------------------------------------" & vbCrLf & vbCrLf & "Ödeyecek Kişinin Bilgileri : " & vbCrLf & vbCrLf & "Ödeyecek Kişi İsmi : " & odeceyecekkisiadi.Text & vbCrLf & "Adres : " & adres.Text & vbCrLf & "Tc Kimlik No : " & adres.Text & vbCrLf & "Telefon : " & tel.Text & vbCrLf & "Kefil İsmi / Tel : " & kefilisim.Text & "/" & kefiltel.Text & vbCrLf & "Kefil Tc Kimlik No : " & kefiltc.Text & vbCrLf & vbCrLf & "----------------------------------------------" & vbCrLf & vbCrLf & "Mettless Dizayn"
        Dim SMTP As New SmtpClient("smtp.gmail.com")
        SMTP.EnableSsl = True
        SMTP.Credentials = New System.Net.NetworkCredential("mettlessdizayn@gmail.com", "14022012")
        SMTP.Port = "587"
        SMTP.Send(Mail)
        gönderildiolarakisaretle()
    End Sub

    Private Sub gönderildiolarakisaretle()
        '    Try
        baglanti.Close()
        baglanti.Open()
        Dim sql As String
        sql = "update ceksenet set Durum ='" & "Gonderildi" & "' where Sayi='" & sayi.Text & "'"
        Dim komut1 As New OleDbCommand
        komut1.Connection = baglanti
        komut1.CommandText = sql
        komut1.ExecuteNonQuery()
        baglanti.Close()
        Timer1.Stop()
        Me.CeksenetTableAdapter.Fill(Me.DatabaseDataSet.ceksenet)

        'Catch ex As Exception
        'MsgBox(ex.Message & "İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")

        'End Try

    End Sub



    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            odeceyecekkisiadi.Text = DataGridView1.Item(1, i).Value
            adres.Text = DataGridView1.Item(2, i).Value
            tckimlikno.Text = DataGridView1.Item(3, i).Value
            tel.Text = DataGridView1.Item(4, i).Value
            kefilisim.Text = DataGridView1.Item(5, i).Value
            kefiltel.Text = DataGridView1.Item(6, i).Value
            kefiltc.Text = DataGridView1.Item(7, i).Value
            odenecekkisiadi.Text = DataGridView1.Item(8, i).Value
            odenecektutar.Text = DataGridView1.Item(9, i).Value
            tarih.Text = DataGridView1.Item(10, i).Value
            sayi.Text = DataGridView1.Item(12, i).Value
        Catch ex As Exception
            MsgBox("Lütfen Bir Kayıt Seçin", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        ceksenetkaydet()
    End Sub

    Private Sub ceksenet_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.CeksenetTableAdapter.Fill(Me.DatabaseDataSet.ceksenet)
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        guncelleme()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        silme()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        temizle()
    End Sub

    Private Sub temizle()
        odenecekkisiadi.Text = ""
        adres.Text = ""
        tarih.Text = Today
        tckimlikno.Text = ""
        tel.Text = ""
        kefilisim.Text = ""
        kefiltc.Text = ""
        kefiltel.Text = ""
        odeceyecekkisiadi.Text = ""
        odenecektutar.Text = ""
    End Sub

    Private Sub yenisistem()
        For Each dr As DataGridViewRow In DataGridView1.Rows
            If dr.Cells(10).Value = Today And dr.Cells(11).Value = "Gonderilmedi" Then
                Timer1.Start()
            End If
        Next

    End Sub


    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        yenisistem()
    End Sub
End Class