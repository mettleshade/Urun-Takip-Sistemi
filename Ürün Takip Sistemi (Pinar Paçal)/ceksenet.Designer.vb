<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ceksenet
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ceksenet))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.sayi = New System.Windows.Forms.Label()
        Me.kefiltc = New System.Windows.Forms.MaskedTextBox()
        Me.kefilisim = New System.Windows.Forms.TextBox()
        Me.tckimlikno = New System.Windows.Forms.MaskedTextBox()
        Me.odeceyecekkisiadi = New System.Windows.Forms.TextBox()
        Me.kefiltel = New System.Windows.Forms.MaskedTextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tel = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.adres = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.tarih = New System.Windows.Forms.DateTimePicker()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.odenecektutar = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.odenecekkisiadi = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.ımageList2 = New System.Windows.Forms.ImageList(Me.components)
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.CeksenetBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DatabaseDataSet = New Ürün_Takip_Sistemi.databaseDataSet()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.CeksenetTableAdapter = New Ürün_Takip_Sistemi.databaseDataSetTableAdapters.ceksenetTableAdapter()
        Me.Timer2 = New System.Windows.Forms.Timer(Me.components)
        Me.Timer3 = New System.Windows.Forms.Timer(Me.components)
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TCDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CeksenetBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.sayi)
        Me.GroupBox1.Controls.Add(Me.kefiltc)
        Me.GroupBox1.Controls.Add(Me.kefilisim)
        Me.GroupBox1.Controls.Add(Me.tckimlikno)
        Me.GroupBox1.Controls.Add(Me.odeceyecekkisiadi)
        Me.GroupBox1.Controls.Add(Me.kefiltel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.tel)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.adres)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(346, 176)
        Me.GroupBox1.TabIndex = 8
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ödeyecek Ünvan Bilgileri :"
        '
        'sayi
        '
        Me.sayi.AutoSize = True
        Me.sayi.Location = New System.Drawing.Point(193, 0)
        Me.sayi.Name = "sayi"
        Me.sayi.Size = New System.Drawing.Size(39, 13)
        Me.sayi.TabIndex = 18
        Me.sayi.Text = "Label9"
        Me.sayi.Visible = False
        '
        'kefiltc
        '
        Me.kefiltc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kefiltc.Location = New System.Drawing.Point(123, 144)
        Me.kefiltc.Mask = "00000000000"
        Me.kefiltc.Name = "kefiltc"
        Me.kefiltc.Size = New System.Drawing.Size(217, 20)
        Me.kefiltc.TabIndex = 6
        '
        'kefilisim
        '
        Me.kefilisim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kefilisim.Location = New System.Drawing.Point(123, 121)
        Me.kefilisim.Name = "kefilisim"
        Me.kefilisim.Size = New System.Drawing.Size(119, 20)
        Me.kefilisim.TabIndex = 4
        '
        'tckimlikno
        '
        Me.tckimlikno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tckimlikno.Location = New System.Drawing.Point(123, 75)
        Me.tckimlikno.Mask = "00000000000"
        Me.tckimlikno.Name = "tckimlikno"
        Me.tckimlikno.Size = New System.Drawing.Size(217, 20)
        Me.tckimlikno.TabIndex = 2
        '
        'odeceyecekkisiadi
        '
        Me.odeceyecekkisiadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.odeceyecekkisiadi.Location = New System.Drawing.Point(123, 28)
        Me.odeceyecekkisiadi.Name = "odeceyecekkisiadi"
        Me.odeceyecekkisiadi.Size = New System.Drawing.Size(217, 20)
        Me.odeceyecekkisiadi.TabIndex = 0
        '
        'kefiltel
        '
        Me.kefiltel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.kefiltel.Location = New System.Drawing.Point(248, 121)
        Me.kefiltel.Mask = "(999) 000-0000"
        Me.kefiltel.Name = "kefiltel"
        Me.kefiltel.Size = New System.Drawing.Size(92, 20)
        Me.kefiltel.TabIndex = 5
        '
        'Label8
        '
        Me.Label8.Location = New System.Drawing.Point(6, 121)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(132, 23)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Kefil İsim veya Tel :"
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tel
        '
        Me.tel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.tel.Location = New System.Drawing.Point(123, 98)
        Me.tel.Mask = "(999) 000-0000"
        Me.tel.Name = "tel"
        Me.tel.Size = New System.Drawing.Size(217, 20)
        Me.tel.TabIndex = 3
        '
        'Label7
        '
        Me.Label7.Location = New System.Drawing.Point(6, 144)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(132, 23)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Kefil Tc Kimlik No :"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'adres
        '
        Me.adres.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.adres.Location = New System.Drawing.Point(123, 51)
        Me.adres.Name = "adres"
        Me.adres.Size = New System.Drawing.Size(217, 20)
        Me.adres.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.Location = New System.Drawing.Point(6, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(103, 23)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "TC Kimlik No :"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label5
        '
        Me.Label5.Location = New System.Drawing.Point(6, 51)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 23)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Adres :"
        Me.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label6
        '
        Me.Label6.Location = New System.Drawing.Point(6, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(132, 23)
        Me.Label6.TabIndex = 9
        Me.Label6.Text = "Telefon :"
        Me.Label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(6, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 23)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Ödeyecek Kişi Adı : *"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'tarih
        '
        Me.tarih.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.tarih.Location = New System.Drawing.Point(123, 75)
        Me.tarih.Name = "tarih"
        Me.tarih.Size = New System.Drawing.Size(136, 20)
        Me.tarih.TabIndex = 9
        '
        'Label4
        '
        Me.Label4.Location = New System.Drawing.Point(6, 75)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(103, 23)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Ödenecek Tarih :"
        Me.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.odenecektutar)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.odenecekkisiadi)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.tarih)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Location = New System.Drawing.Point(364, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(275, 106)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Ödenecek Ünvan Bilgileri :"
        '
        'odenecektutar
        '
        Me.odenecektutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.odenecektutar.Location = New System.Drawing.Point(123, 51)
        Me.odenecektutar.Name = "odenecektutar"
        Me.odenecektutar.Size = New System.Drawing.Size(136, 20)
        Me.odenecektutar.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.Location = New System.Drawing.Point(6, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(111, 23)
        Me.Label3.TabIndex = 15
        Me.Label3.Text = "Ödenecek Tutar :"
        Me.Label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'odenecekkisiadi
        '
        Me.odenecekkisiadi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.odenecekkisiadi.Location = New System.Drawing.Point(123, 28)
        Me.odenecekkisiadi.Name = "odenecekkisiadi"
        Me.odenecekkisiadi.Size = New System.Drawing.Size(136, 20)
        Me.odenecekkisiadi.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.Location = New System.Drawing.Point(6, 28)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 23)
        Me.Label13.TabIndex = 2
        Me.Label13.Text = "Ödenecek Kişi Adı *"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.ImageIndex = 5
        Me.Button1.ImageList = Me.ımageList2
        Me.Button1.Location = New System.Drawing.Point(364, 124)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(138, 32)
        Me.Button1.TabIndex = 10
        Me.Button1.Text = "Kaydet"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'ımageList2
        '
        Me.ımageList2.ImageStream = CType(resources.GetObject("ımageList2.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ımageList2.TransparentColor = System.Drawing.Color.Transparent
        Me.ımageList2.Images.SetKeyName(0, "+.png")
        Me.ımageList2.Images.SetKeyName(1, "1480710381_Cancel.png")
        Me.ımageList2.Images.SetKeyName(2, "1480717594_trash_bin.png")
        Me.ımageList2.Images.SetKeyName(3, "1482241114_system-software-update.png")
        Me.ımageList2.Images.SetKeyName(4, "olustur.png")
        Me.ımageList2.Images.SetKeyName(5, "save.png")
        Me.ımageList2.Images.SetKeyName(6, "temizle.ico")
        Me.ımageList2.Images.SetKeyName(7, "Search.png")
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.ImageIndex = 6
        Me.Button2.ImageList = Me.ımageList2
        Me.Button2.Location = New System.Drawing.Point(364, 159)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 28)
        Me.Button2.TabIndex = 16
        Me.Button2.TabStop = False
        Me.Button2.Text = "Temizle"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.ImageIndex = 3
        Me.Button3.ImageList = Me.ımageList2
        Me.Button3.Location = New System.Drawing.Point(508, 124)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(131, 32)
        Me.Button3.TabIndex = 17
        Me.Button3.TabStop = False
        Me.Button3.Text = "Güncelle"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.ImageIndex = 2
        Me.Button4.ImageList = Me.ımageList2
        Me.Button4.Location = New System.Drawing.Point(508, 159)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(131, 28)
        Me.Button4.TabIndex = 18
        Me.Button4.TabStop = False
        Me.Button4.Text = "Sil"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.BackgroundColor = System.Drawing.Color.White
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.TCDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DurumDataGridViewTextBoxColumn, Me.DataGridViewTextBoxColumn13})
        Me.DataGridView1.DataSource = Me.CeksenetBindingSource
        Me.DataGridView1.GridColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.DataGridView1.Location = New System.Drawing.Point(12, 194)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(627, 200)
        Me.DataGridView1.TabIndex = 19
        Me.DataGridView1.TabStop = False
        '
        'CeksenetBindingSource
        '
        Me.CeksenetBindingSource.DataMember = "ceksenet"
        Me.CeksenetBindingSource.DataSource = Me.DatabaseDataSet
        '
        'DatabaseDataSet
        '
        Me.DatabaseDataSet.DataSetName = "databaseDataSet"
        Me.DatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Timer1
        '
        '
        'CeksenetTableAdapter
        '
        Me.CeksenetTableAdapter.ClearBeforeFill = True
        '
        'Timer2
        '
        Me.Timer2.Enabled = True
        Me.Timer2.Interval = 5000
        '
        'Timer3
        '
        Me.Timer3.Interval = 2000
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "id"
        Me.DataGridViewTextBoxColumn12.HeaderText = "id"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        Me.DataGridViewTextBoxColumn12.ReadOnly = True
        Me.DataGridViewTextBoxColumn12.Visible = False
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "OdeyecekKisiAdi"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Odeyecek Kisi Adi"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        Me.DataGridViewTextBoxColumn14.ReadOnly = True
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "Adres"
        Me.DataGridViewTextBoxColumn15.HeaderText = "Adres"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        Me.DataGridViewTextBoxColumn15.Visible = False
        '
        'TCDataGridViewTextBoxColumn
        '
        Me.TCDataGridViewTextBoxColumn.DataPropertyName = "TC"
        Me.TCDataGridViewTextBoxColumn.HeaderText = "TC"
        Me.TCDataGridViewTextBoxColumn.Name = "TCDataGridViewTextBoxColumn"
        Me.TCDataGridViewTextBoxColumn.ReadOnly = True
        Me.TCDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "Telefon"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Telefon"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        Me.DataGridViewTextBoxColumn16.ReadOnly = True
        Me.DataGridViewTextBoxColumn16.Visible = False
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "KefilKisiAdi"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Kefil Kisi Adi"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        Me.DataGridViewTextBoxColumn17.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "KefilTel"
        Me.DataGridViewTextBoxColumn18.HeaderText = "KefilTel"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        Me.DataGridViewTextBoxColumn18.ReadOnly = True
        Me.DataGridViewTextBoxColumn18.Visible = False
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "KefilTc"
        Me.DataGridViewTextBoxColumn19.HeaderText = "KefilTc"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        Me.DataGridViewTextBoxColumn19.Visible = False
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "OdenecekKisiAdi"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Odenecek Kisi Adi"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        Me.DataGridViewTextBoxColumn20.ReadOnly = True
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "OdenecekTutar"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewTextBoxColumn21.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewTextBoxColumn21.HeaderText = "Odenecek Tutar"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        Me.DataGridViewTextBoxColumn21.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Tarih"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Tarih"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        Me.DataGridViewTextBoxColumn22.ReadOnly = True
        '
        'DurumDataGridViewTextBoxColumn
        '
        Me.DurumDataGridViewTextBoxColumn.DataPropertyName = "Durum"
        Me.DurumDataGridViewTextBoxColumn.HeaderText = "Durum"
        Me.DurumDataGridViewTextBoxColumn.Name = "DurumDataGridViewTextBoxColumn"
        Me.DurumDataGridViewTextBoxColumn.ReadOnly = True
        Me.DurumDataGridViewTextBoxColumn.Visible = False
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Sayi"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Sayi"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        Me.DataGridViewTextBoxColumn13.ReadOnly = True
        Me.DataGridViewTextBoxColumn13.Visible = False
        '
        'ceksenet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(652, 406)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "ceksenet"
        Me.Text = "Çek Senet Takip"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CeksenetBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DatabaseDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents tel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents tarih As System.Windows.Forms.DateTimePicker
    Friend WithEvents adres As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents kefilisim As System.Windows.Forms.TextBox
    Friend WithEvents tckimlikno As System.Windows.Forms.MaskedTextBox
    Friend WithEvents odeceyecekkisiadi As System.Windows.Forms.TextBox
    Friend WithEvents kefiltel As System.Windows.Forms.MaskedTextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents odenecekkisiadi As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents ımageList2 As System.Windows.Forms.ImageList
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents odenecektutar As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents kefiltc As System.Windows.Forms.MaskedTextBox
    Friend WithEvents sayi As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents İdDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SayiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdeyecekKisiAdiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AdresDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TelefonDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KefilKisiAdiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KefilTelDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents KefilTcDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdenecekKisiAdiDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OdenecekTutarDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TarihDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DatabaseDataSet As Ürün_Takip_Sistemi.databaseDataSet
    Friend WithEvents CeksenetBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CeksenetTableAdapter As Ürün_Takip_Sistemi.databaseDataSetTableAdapters.ceksenetTableAdapter
    Friend WithEvents Timer2 As System.Windows.Forms.Timer
    Friend WithEvents Timer3 As System.Windows.Forms.Timer
    Friend WithEvents DataGridViewTextBoxColumn12 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TCDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DurumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
