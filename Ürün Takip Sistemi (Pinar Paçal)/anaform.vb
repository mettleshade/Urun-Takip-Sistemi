Imports System.Data
Imports System.Data.OleDb
Imports System.IO
Imports Microsoft.Win32

Public Class anaform
    Dim baglanti As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\database.mdb;")
    Dim ilktarih As Date
    Dim ekleneceksure As Integer

    Private Sub vericekk()
        Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
        Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
        Me.SatilanurunlerTableAdapter.Fill(Me.DatabaseDataSet.satilanurunler)
        suadi.Text = ""
        saadi.Text = ""
    End Sub

    Private Sub anaform_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter AndAlso (e.Control) Then
            satilanurunkaydet()
        End If
    End Sub


    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Me.KisilerTableAdapter.Fill(Me.DatabaseDataSet.kisiler)
        Me.UrunlerTableAdapter.Fill(Me.DatabaseDataSet.urunler)
        Me.SatilanurunlerTableAdapter.Fill(Me.DatabaseDataSet.satilanurunler)
        suadi.Text = ""
        saadi.Text = ""
        suadi.Focus()
        gunlukistatik()
        haftalik()
        ceksenet.Show()
        ceksenet.Hide()
    End Sub

    Private Sub satilanurunkaydet()
        Try

            If suadi.Text = "" Or kacadet.Text = "" Or saadi.Text = "" Or tel.Text = "" Then
                MsgBox("Lütfen Boş Kısımları Doldurunuz.", MsgBoxStyle.Critical, "Dikkat !")
            Else
                Dim RastgeleSayi As New Random
                Dim OlusturulanSayi As Integer = RastgeleSayi.Next(1, 9999999)
                Dim Sql, sql2 As String
                Sql = "insert into [satilanurunler](Sayi,SatilanUrunAdi,SatinAlanKisi,KacAdet,Telefon,Adres,Tarih,ToplamTutar) values ('" & OlusturulanSayi & "','" & suadi.Text & "','" & saadi.Text & "','" & kacadet.Text & "','" & tel.Text & "','" & adres.Text & "','" & tarih.Text & "','" & TextBox4.Text & "')"

                sql2 = "select * from satilanurunler"
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
                        gunlukistatik()
                        haftalik()
                        MsgBox("Satış Kayıt Edilmiştir.", MsgBoxStyle.Information, "Dikkat !")
                        kalanurunmiktar()
                        vericekk()
                        kacadethesaplama()
                        temizle()
                    End If
                Loop

                dr.Close()
                komut.CommandText = Sql
                komut.ExecuteNonQuery()
                baglanti.Close()
                gunlukistatik()
                haftalik()
                MsgBox("Satış Kayıt Edilmiştir.", MsgBoxStyle.Information, "Dikkat !")
                kalanurunmiktar()
                vericekk()
                kacadethesaplama()
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
            sql = "update satilanurunler set SatilanUrunAdi ='" & suadi.Text & "', SatinAlanKisi ='" & saadi.Text & "', KacAdet ='" & kacadet.Text & "', Telefon='" & tel.Text & "', Adres ='" & adres.Text & "', Tarih ='" & tarih.Text & "' where Sayi='" & sayi.Text & "'"
            Dim komut As New OleDbCommand
            komut.Connection = baglanti
            komut.CommandText = sql
            komut.ExecuteNonQuery()
            baglanti.Close()
            vericekk()
            gunlukistatik()
            haftalik()
            kalanurunmiktar()
            MsgBox("Bilgiler Başarıyla Güncellenmiştir.", MsgBoxStyle.Information, "Dikkat !")

        Catch ex As Exception
            MsgBox("İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub kalanurunmiktar()
        Try
            baglanti.Open()
            Dim sql As String
            sql = "update urunler set KacAdet ='" & TextBox7.Text & "' where Sayi='" & TextBox8.Text & "'"
            Dim komut As New OleDbCommand
            komut.Connection = baglanti
            komut.CommandText = sql
            komut.ExecuteNonQuery()
            baglanti.Close()

        Catch ex As Exception
            MsgBox("İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub silme()
        Try
            If MsgBox(suadi.Text & " İsimli Kayıt Silinsinmi ?", MsgBoxStyle.YesNoCancel, "Dikkat !") = vbYes Then
                Dim sql As String
                sql = "delete from satilanurunler where Sayi='" & sayi.Text & "'"
                Dim komut As New OleDbCommand
                komut.Connection = baglanti
                komut.CommandText = sql
                baglanti.Open()
                komut.ExecuteNonQuery()
                vericekk()
                MsgBox("Seçilen Kayıt Başarıyla Silindi.", MsgBoxStyle.Information, "Dikkat !")
                baglanti.Close()
                uzerineekle()
            End If

        Catch ex As Exception
            MsgBox("İşlem Başarısız Lütfen Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub gunlukistatik()
        Dim TT As Double
        Dim TT1 As Double
        baglanti.Open()
        Dim komut As New OleDb.OleDbCommand("SELECT * FROM satilanurunler  order by id; ", baglanti)
        Dim oku As OleDb.OleDbDataReader
        oku = komut.ExecuteReader()
        Do While oku.Read = True
            If oku("Tarih") = Today Then
                TT += oku("ToplamTutar")
                TT1 += oku("KacAdet")
            End If

        Loop
        Label7.Text = "Toplam Kazanç : " & FormatCurrency(TT)
        Label12.Text = "Toplam Satılan Ürün : " & TT1
        baglanti.Close()

    End Sub

    Private Sub haftalik()
        Dim TT As Double
        Dim TT1 As Double
        baglanti.Open()
        Dim komut As New OleDb.OleDbCommand("SELECT * FROM satilanurunler  order by id; ", baglanti)
        Dim oku As OleDb.OleDbDataReader
        oku = komut.ExecuteReader()
        Do While oku.Read = True
            TT += oku("ToplamTutar")
            TT1 += oku("KacAdet")
        Loop
        Label8.Text = "Toplam Kazanç : " & FormatCurrency(TT)
        Label9.Text = "Toplam Satılan Ürün : " & TT1
        baglanti.Close()

    End Sub

    Private Sub temizle()
        suadi.Text = ""
        saadi.Text = ""
        adres.Text = ""
        tel.Text = ""
        kacadet.Text = ""
        tarih.Text = Today
        TextBox1.Text = ""
        TextBox3.Text = ""
    End Sub

    Private Sub DataGridView1_CellMouseClick(ByVal sender As System.Object, ByVal e As System.Windows.Forms.DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        Try
            Dim i As Integer
            i = DataGridView1.CurrentRow.Index
            sayi.Text = DataGridView1.Item(1, i).Value
            suadi.Text = DataGridView1.Item(2, i).Value
            saadi.Text = DataGridView1.Item(3, i).Value
            TextBox6.Text = DataGridView1.Item(4, i).Value
            kacadet.Text = DataGridView1.Item(4, i).Value
            tel.Text = DataGridView1.Item(5, i).Value
            adres.Text = DataGridView1.Item(6, i).Value
            tarih.Text = DataGridView1.Item(7, i).Value
            FormatCurrency(TextBox3.Text)
            TextBox3.Text = DataGridView1.Item(8, i).Value
            FormatCurrency(TextBox3.Text)
            suadicek()
        Catch ex As Exception
            MsgBox("Lütfen Bir Kayıt Seçin", MsgBoxStyle.Critical, "Dikkat !")
        End Try
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        satilanurunkaydet()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        guncelleme()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        silme()
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        temizle()
    End Sub

    Private Sub suadi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles suadi.SelectedIndexChanged
        suadicek()
    End Sub

    Private Sub suadicek()
        Dim komut As New OleDbCommand("select * from urunler", baglanti)
        Dim dr As OleDb.OleDbDataReader
        baglanti.Close()
        baglanti.Open()
        dr = komut.ExecuteReader
        Do While dr.Read
            If dr("UrunAdi") = suadi.Text Then
                TextBox1.Text = FormatCurrency(dr("BFiyat"))
                TextBox2.Text = dr("BFiyat")
                TextBox6.Text = dr("KacAdet")
                TextBox8.Text = dr("Sayi")
                kacadet.Enabled = True
                saadi.Enabled = True
                tel.Enabled = True
                adres.Enabled = True
                If kacadet.Text = "" Then
                Else
                    toplamtutar()
                End If

                If TextBox6.Text = "0" Then
                    Button1.Enabled = False
                    kacadet.Enabled = False
                Else
                    Button1.Enabled = True
                    kacadet.Enabled = True
                End If
            End If
        Loop
        baglanti.Close()
    End Sub

    Private Sub KişiEkleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KişiEkleToolStripMenuItem.Click
        kisiurunekle.Show()
    End Sub

    Private Sub saadi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles saadi.SelectedIndexChanged
        Dim komut As New OleDbCommand("select * from kisiler", baglanti)
        Dim dr As OleDb.OleDbDataReader
        baglanti.Open()
        dr = komut.ExecuteReader
        Do While dr.Read
            If dr("KisiAdi") = saadi.Text Then
                tel.Text = dr("Telefon")
                adres.Text = dr("Adres")
            End If
        Loop
        baglanti.Close()
    End Sub


    Private Sub kacadet_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles kacadet.TextChanged
        toplamtutar()
        
    End Sub
    Private Sub toplamtutar()
        If kacadet.Text = "" Then
        Else
            Dim b As Integer
            Dim a, c As Double
            a = TextBox2.Text
            b = kacadet.Text
            c = a * b
            TextBox3.Text = FormatCurrency(c)
            TextBox4.Text = c
        End If
        
    End Sub

    Private Sub kacadethesaplama()
        Dim sayi1, sayi2 As Integer
        sayi1 = kacadet.Text
        sayi2 = TextBox6.Text
        If sayi1 > sayi2 Then
            MsgBox("Elinizdeki miktardan çok miktar girilemez. Elinizde olan miktar : " & TextBox6.Text & " Adet.", MsgBoxStyle.Critical, "Hata !")
            Timer1.Stop()
        Else
            Dim d, g, f As Integer
            d = kacadet.Text
            g = TextBox6.Text
            f = g - d
            TextBox7.Text = f
        End If
    End Sub

    Private Sub ÇekSenetTakipToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇekSenetTakipToolStripMenuItem.Click
        ceksenet.Show()
    End Sub

    Private Sub uzerineekle()

        Dim a, b, c As Integer
        a = TextBox6.Text
        b = kacadet.Text
        c = a + b

        baglanti.Open()
        Dim sql As String
        sql = "update urunler set KacAdet ='" & c & "' where Sayi='" & TextBox8.Text & "'"
        Dim komut1 As New OleDbCommand
        komut1.Connection = baglanti
        komut1.CommandText = sql
        komut1.ExecuteNonQuery()
        baglanti.Close()
        vericekk()
    End Sub

    Private Sub KısayollarToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles KısayollarToolStripMenuItem.Click
        ayarlar.Show()
    End Sub

    Private Sub VerileriYedekleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerileriYedekleToolStripMenuItem.Click
        If MsgBox("Bilgileriniz Yedeklensinmi ?", MsgBoxStyle.YesNo, "Dikkat !") = vbYes Then
            My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath.ToString() & "\Veritabani Yedegi")
            Dim zaman As New Date
            Dim zaman2 As New Date
            Dim uzanti As String
            zaman = DateTime.Today
            uzanti = (".mdb")
            Select Case File.Exists(My.Application.Info.DirectoryPath.ToString() & (zaman) & (uzanti))
                Case True
                    If MsgBox("Bugün Zaten Yedek Alınmış. Üstüne Yazılsınmı ?", MsgBoxStyle.YesNoCancel, "Dikkat !") = vbYes Then
                        File.Delete(My.Application.Info.DirectoryPath.ToString() & zaman & uzanti)
                        FileCopy("database.mdb", My.Application.Info.DirectoryPath.ToString() & "\Veritabani Yedegi\" & Path.GetFileName(zaman) & uzanti)
                        MsgBox("Bilgileriniz " & My.Application.Info.DirectoryPath.ToString() & "\Veritabani Yedegi\" & "  Dosyasının İçinde Kayıt Edilmiştir.", MsgBoxStyle.Information, "Dikkat !")
                    End If
                Case False
                    My.Computer.FileSystem.CreateDirectory(My.Application.Info.DirectoryPath.ToString())
                    FileCopy("database.mdb", My.Application.Info.DirectoryPath.ToString() & "\Veritabani Yedegi\" & Path.GetFileName(zaman) & uzanti)
                    MsgBox("Bilgileriniz " & My.Application.Info.DirectoryPath.ToString() & "\Veritabani Yedegi\" & "  Dosyasının İçinde Kayıt Edilmiştir.", MsgBoxStyle.Information, "Dikkat !")
                Case Else
                    MsgBox("İşlemi tekrar deneyiniz.", MsgBoxStyle.Information, Me.Text)
            End Select
        End If
    End Sub

    Private Sub VerileriGeriYükleToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles VerileriGeriYükleToolStripMenuItem.Click
        Try
            Dim uzanti As String
            Dim dosyadi As String
            Dim zaman As New Date
            dosyadi = ("database")
            uzanti = (".mdb")
            Dim dosya As New FileInfo("\database.mdb")
            Dim Ac As New OpenFileDialog
            Ac.FileName = vbNullString
            Ac.Filter = "Database(*.mdb*) |*.mdb*"
            If Ac.ShowDialog = Windows.Forms.DialogResult.OK Then
                Select Case File.Exists(Application.StartupPath & "\" & (dosyadi) & (uzanti))
                    Case True
                        Kill(Application.StartupPath & "\database.mdb")
                        File.Copy(Ac.FileName, Application.StartupPath & "\" & (dosyadi) & (uzanti))
                        vericekk()
                    Case False
                        File.Copy(Ac.FileName, Application.StartupPath & "\" & (dosyadi) & (uzanti))
                        vericekk()
                    Case Else
                        MsgBox("İşlemi tekrar deneyiniz.", MsgBoxStyle.Information, Me.Text)
                End Select

            End If
        Catch ex As Exception
            MsgBox("İşlemi Daha Sonra Tekrar Deneyiniz.", MsgBoxStyle.Critical, Me.Text)
        End Try
    End Sub

    Private Sub ÇıkışToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ÇıkışToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub HakkındaToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles HakkındaToolStripMenuItem.Click
        AboutBox1.Show()
    End Sub

    Private Sub Label10_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label10.Click
        Process.Start("http://www.facebook.com/MettlessDizayn")
        Process.Start("http://www.mettlessdizayn.com")
        Process.Start("http://www.facebook.com/Metlesshade")

    End Sub


    Private Sub TextBox5_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox5.TextChanged
        If ComboBox2.Text = "ÜRÜN ADİ" Then
            Dim dv As DataView = New DataView()
            dv.Table = DatabaseDataSet.satilanurunler
            dv.RowFilter = "[SatilanUrunAdi] Like '" & TextBox5.Text & "%'"
            DataGridView1.DataSource = dv
        Else
            Dim dv As DataView = New DataView()
            dv.Table = DatabaseDataSet.satilanurunler
            dv.RowFilter = "[SatinAlanKisi] Like '" & TextBox5.Text & "%'"
            DataGridView1.DataSource = dv
        End If
    End Sub

    Private Sub suadi_KeyPress(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles suadi.KeyPress
        If Not (Char.IsLetter(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) And e.KeyChar <> ChrW(Keys.Space) Then
            e.Handled = True
        End If
        If Not (Char.IsNumber(e.KeyChar) = True) And e.KeyChar <> ChrW(Keys.Back) Then
            e.Handled = True
        End If

    End Sub

    Private Sub anaform_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        ac.Close()
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        If kacadet.Text = "" Then
        Else
            kacadethesaplama()
        End If
    End Sub


End Class
