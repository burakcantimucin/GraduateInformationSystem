using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalProjesi
{
    public partial class formMezunBilgiSistemi : System.Windows.Forms.Form
    {
        MezunBST Mezunlar = new MezunBST();
        BolumHashMap Bolumler = new BolumHashMap();
        Sirket Sirket = new Sirket();
        String EnIyiMezun = "";
        string bolumAdi = "";
        int bolumNo;
        int MezunOgrenciSayisi = 0;

        public formMezunBilgiSistemi()
        {
            InitializeComponent();
        }

        private void formMezunBilgiSistemi_Load(object sender, EventArgs e)
        {

            Sirket s1 = new Sirket("Monitise MEA", "Yazılım Mühendisliği"); Sirket.SirketEkle(s1);
            Sirket s2 = new Sirket("BMC", "Mekatronik Mühendisliği"); Sirket.SirketEkle(s2);
            Sirket s3 = new Sirket("Schneider Elektrik", "Makine ve İmalat Mühendisliği"); Sirket.SirketEkle(s3);
            Sirket s4 = new Sirket("Batıçim", "Enerji Sistemleri Mühendisliği"); Sirket.SirketEkle(s4);

            MezunNode Mezun = new MezunNode();

            MezuniyetBilgilerNode MB1 = new MezuniyetBilgilerNode();
            MB1.BolumAdi = "Yazılım Mühendisliği";
            MB1.BaslangicTarihi = 2011;
            MB1.BitisTarihi = 2015;
            MB1.NotOrtalamasi = 86.50;
            MB1.BasariBelgesi = true;
            StajDeneyimNode S1 = new StajDeneyimNode();
            S1.Departman = "Bilgi İşlem";
            S1.Gorev = "Veritabanı Yönetimi";
            S1.SirketAdi = "KoçSistem";
            S1.Tarih = "20/09/2012";
            Mezun M1 = new Mezun(S1, MB1);
            M1.Ad = "Burakcan Timuçin";
            M1.Adres = "Turgutlu";
            M1.DogumTarihi = "17/07/1991";
            M1.ePosta = "burakcantimucin@gmail.com";
            M1.IlgiAlanlari = "Yağlı Boya Sanatı";
            M1.IngilizceSeviye = "Advanced";
            M1.Telefon = "05304821406";
            M1.OgrenciNo = 1112;
            M1.Uyruk = "Türkiye Cumhuriyeti";
            Mezunlar.Ekle(M1, S1, MB1);
            
            Mezun = Mezunlar.OgrenciNoBazindaArama(M1.OgrenciNo);
            Bolumler.MezununBolumeAtanmasi(1, Mezun);
            MezunOgrenciSayisi++;

            MezuniyetBilgilerNode MB2 = new MezuniyetBilgilerNode();
            MB2.BolumAdi = "Mekatronik Mühendisliği";
            MB2.BaslangicTarihi = 2010;
            MB2.BitisTarihi = 2014;
            MB2.NotOrtalamasi = 79.63;
            MB2.BasariBelgesi = false;
            StajDeneyimNode S2 = new StajDeneyimNode();
            S2.Departman = "Ana Sanayi";
            S2.Gorev = "Robot Sistemler";
            S2.SirketAdi = "Vestel";
            S2.Tarih = "22/09/2013";
            Mezun M2 = new Mezun(S2, MB2);
            M2.Ad = "Intizar Najimaddinova";
            M2.Adres = "Bornova";
            M2.DogumTarihi = "01/06/1992";
            M2.ePosta = "intizarnajimaddinova@gmail.com";
            M2.IlgiAlanlari = "Gitar Çalmak";
            M2.IngilizceSeviye = "Advanced";
            M2.Telefon = "05359451758";
            M2.OgrenciNo = 1011;
            M2.Uyruk = "Türkiye Cumhuriyeti";
            Mezunlar.Ekle(M2, S2, MB2);

            Mezun = Mezunlar.OgrenciNoBazindaArama(M2.OgrenciNo);
            Bolumler.MezununBolumeAtanmasi(2, Mezun);
            MezunOgrenciSayisi++;

            MezuniyetBilgilerNode MB3 = new MezuniyetBilgilerNode();
            MB3.BolumAdi = "Makine ve İmalat Mühendisliği";
            MB3.BaslangicTarihi = 2013;
            MB3.BitisTarihi = 2017;
            MB3.NotOrtalamasi = 93.04;
            MB3.BasariBelgesi = true;
            StajDeneyimNode S3 = new StajDeneyimNode();
            S3.Departman = "Şantiye";
            S3.Gorev = "Motor Sistemleri";
            S3.SirketAdi = "İnci Akü";
            S3.Tarih = "21/09/2014";
            Mezun M3 = new Mezun(S3, MB3);
            M3.Ad = "Oğuz Döğer";
            M3.Adres = "Konak";
            M3.DogumTarihi = "27/03/1993";
            M3.ePosta = "oguzdoger@gmail.com";
            M3.IlgiAlanlari = "Bisiklet Sürmek";
            M3.IngilizceSeviye = "Intermediate";
            M3.Telefon = "05423914526";
            M3.OgrenciNo = 1314;
            M3.Uyruk = "Türkiye Cumhuriyeti";
            Mezunlar.Ekle(M3, S3, MB3);

            Mezun = Mezunlar.OgrenciNoBazindaArama(M3.OgrenciNo);
            Bolumler.MezununBolumeAtanmasi(3, Mezun);
            MezunOgrenciSayisi++;

            MezuniyetBilgilerNode MB4 = new MezuniyetBilgilerNode();
            MB4.BolumAdi = "Enerji Sistemleri Mühendisliği";
            MB4.BaslangicTarihi = 2012;
            MB4.BitisTarihi = 2016;
            MB4.NotOrtalamasi = 71.58;
            MB4.BasariBelgesi = false;
            StajDeneyimNode S4 = new StajDeneyimNode();
            S4.Departman = "Şantiye";
            S4.Gorev = "Mekanik Tesisat";
            S4.SirketAdi = "Petkim Petrokimya";
            S4.Tarih = "23/09/2015";
            Mezun M4 = new Mezun(S4, MB4);
            M4.Ad = "Reyhan Selimoğlu";
            M4.Adres = "Aliağa";
            M4.DogumTarihi = "18/11/1994";
            M4.ePosta = "reyhanselimoglu@gmail.com";
            M4.IlgiAlanlari = "Dağcılık";
            M4.IngilizceSeviye = "Preintermediate";
            M4.Telefon = "05385756537";
            M4.OgrenciNo = 1213;
            M4.Uyruk = "Türkiye Cumhuriyeti";
            Mezunlar.Ekle(M4, S4, MB4);

            Mezun = Mezunlar.OgrenciNoBazindaArama(M4.OgrenciNo);
            Bolumler.MezununBolumeAtanmasi(4, Mezun);
            MezunOgrenciSayisi++;
        }

        private void btnMezunEkle_Click(object sender, EventArgs e)
        {
            MezunNode Mezun = new MezunNode();
            StajDeneyimNode sd = new StajDeneyimNode();
            sd.Departman = txtMezunEkle_Departman.Text;
            sd.Gorev = txtMezunEkle_Gorev.Text;
            sd.SirketAdi = txtMezunEkle_SirketAdi.Text;
            sd.Tarih = txtMezunEkle_Tarih.Text;
            MezuniyetBilgilerNode mb = new MezuniyetBilgilerNode();
            if (cbMezunEkle_BasariBelgesi.Text == "Var") { mb.BasariBelgesi = true; }
            else if (cbMezunEkle_BasariBelgesi.Text == "Yok") { mb.BasariBelgesi = false; }
            mb.BaslangicTarihi = Convert.ToInt32(txtMezunEkle_BaslangicTarihi.Text);
            mb.BitisTarihi = Convert.ToInt32(txtMezunEkle_BitisTarihi.Text);
            mb.BolumAdi = cbMezunEkle_BolumAdi.Text;
            if (mb.BolumAdi == "Yazılım Mühendisliği") { bolumNo = 1; }
            else if (mb.BolumAdi == "Mekatronik Mühendisliği") { bolumNo = 2; }
            else if (mb.BolumAdi == "Makine ve İmalat Mühendisliği") { bolumNo = 3; }
            else if (mb.BolumAdi == "Enerji Sistemleri Mühendisliği") { bolumNo = 4; }
            mb.NotOrtalamasi = Convert.ToDouble(txtMezunEkle_NotOrtalamasi.Text);
            Mezun m = new Mezun(sd, mb);
            m.Ad = txtMezunEkle_Ad.Text;
            m.Adres = txtMezunEkle_Adres.Text;
            m.DogumTarihi = txtMezunEkle_DogumTarihi.Text;
            m.ePosta = txtMezunEkle_ePosta.Text;
            m.IlgiAlanlari = txtMezunEkle_IlgiAlanlari.Text;
            m.IngilizceSeviye = cbMezunEkle_IngilizceSeviye.Text;
            m.OgrenciNo = Convert.ToInt32(txtMezunEkle_OgrenciNo.Text);
            m.Telefon = txtMezunEkle_Telefon.Text;
            m.Uyruk = txtMezunEkle_Uyruk.Text;
            Mezunlar.Ekle(m, sd, mb);
            Mezun = Mezunlar.OgrenciNoBazindaArama(m.OgrenciNo);
            Bolumler.MezununBolumeAtanmasi(bolumNo, Mezun);
            MezunOgrenciSayisi++;
            MessageBox.Show("Kayıt başarıyla eklendi.");
        }

        private void btnMezunGuncelle_Click(object sender, EventArgs e)
        {
            Mezun m = new Mezun();
            m.Adres = txtMezunGuncelle_Adres.Text;
            m.DogumTarihi = txtMezunGuncelle_DogumTarihi.Text;
            m.ePosta = txtMezunGuncelle_ePosta.Text;
            m.IlgiAlanlari = txtMezunGuncelle_IlgiAlanlari.Text;
            m.IngilizceSeviye = cbMezunGuncelle_IngilizceSeviye.Text;
            m.OgrenciNo = Convert.ToInt32(txtMezunGuncelle_OgrenciNo.Text);
            m.Telefon = txtMezunGuncelle_Telefon.Text;
            m.Uyruk = txtMezunGuncelle_Uyruk.Text;
            Mezunlar.Guncelle(txtMezunGuncelle_Ad.Text, m, null, null);
            MessageBox.Show("Kayıt başarıyla güncellendi.");
        }

        private void btnMezunSil_Click(object sender, EventArgs e)
        {
            Mezunlar.Sil(Convert.ToInt32(txtMezunSil_OgrNo.Text));
            MezunOgrenciSayisi--;
            MessageBox.Show("Kayıt başarıyla silindi.");
        }

        private void lvMezun(ListView Liste)
        {
            Liste.Columns.Add("Ad-Soyad", 300);
            Liste.Columns.Add("Başarı Notu", 122);
        }

        private void btnMezunListele_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            string tmpAdv = "", tmpUpp = "", tmpInt = "", tmpPre = "";
            if (checkAdvanced.Checked == true) { tmpAdv = "Advanced"; }
            if (checkUpperIntermediate.Checked == true) { tmpUpp = "Upper Intermediate"; }
            if (checkIntermediate.Checked == true) { tmpInt = "Intermediate"; }
            if (checkPreIntermediate.Checked == true) { tmpPre = "Preintermediate"; }
            int BolumNo = cbBolumeGoreMezunListele.SelectedIndex;
            lvBolumeGoreMezunListeleme.Clear();
            lvBolumeGoreMezunListeleme.View = View.Details;
            lvBolumeGoreMezunListeleme.FullRowSelect = true;
            lvMezun(lvBolumeGoreMezunListeleme);
            BolumHashEntry[] MezunListesi = new BolumHashEntry[1000];
            MezunListesi = Bolumler.HashTablosundakiMezunlar();
            foreach (var item in MezunListesi)
            {
                if (item == null) { continue; }
                int basvuranSayisi = item.MezunKisiler.CurrentSize;
                for (int i = 0; i < basvuranSayisi; i++)
                {
                    BolumeGoreMezunNode[] mezunlar = item.MezunKisiler.MezunlariListele();
                    string[] row = { mezunlar[i].MezunBilgileri.MezunBilgileri.Ad, mezunlar[i].BasariDerecesi.ToString() };
                    ListViewItem liste = new ListViewItem(row);
                    if (mezunlar[i].MezunBilgileri.MezunBilgileri.Mezuniyet.BolumAdi == cbBolumeGoreMezunListele.Text)
                    {
                        bolumAdi = mezunlar[i].MezunBilgileri.MezunBilgileri.Mezuniyet.BolumAdi;
                        if (tmpAdv == "Advanced" && tmpAdv == mezunlar[i].MezunBilgileri.MezunBilgileri.IngilizceSeviye)
                        {
                            lvBolumeGoreMezunListeleme.Items.Add(liste);
                            if (sayac == 0) { EnIyiMezun = mezunlar[i].MezunBilgileri.MezunBilgileri.Ad; }
                        }
                        if (tmpUpp == "Upper Intermediate" && tmpUpp == mezunlar[i].MezunBilgileri.MezunBilgileri.IngilizceSeviye)
                        {
                            lvBolumeGoreMezunListeleme.Items.Add(liste);
                            if (sayac == 0) { EnIyiMezun = mezunlar[i].MezunBilgileri.MezunBilgileri.Ad; }
                        }
                        if (tmpInt == "Intermediate" && tmpInt == mezunlar[i].MezunBilgileri.MezunBilgileri.IngilizceSeviye)
                        {
                            lvBolumeGoreMezunListeleme.Items.Add(liste);
                            if (sayac == 0) { EnIyiMezun = mezunlar[i].MezunBilgileri.MezunBilgileri.Ad; }
                        }
                        if (tmpPre == "Preintermediate" && tmpPre == mezunlar[i].MezunBilgileri.MezunBilgileri.IngilizceSeviye)
                        {
                            lvBolumeGoreMezunListeleme.Items.Add(liste);
                            if (sayac == 0) { EnIyiMezun = mezunlar[i].MezunBilgileri.MezunBilgileri.Ad; }
                        }
                    }
                    sayac++;
                }
            }
        }

        private void btnOgrNoyaGoreMezunAra_Click(object sender, EventArgs e)
        {
            string temp = "";
            if (txtOgrNoyaGoreMezun.Text == "") { MessageBox.Show("Mezun öğrencinin numarasını giriniz!"); }
            txtDigerIslemler.Text = "";
            MezunNode Aranan = new MezunNode();
            Aranan = Mezunlar.OgrenciNoBazindaArama(Convert.ToInt32(txtOgrNoyaGoreMezun.Text));
            if (Aranan == null) { txtDigerIslemler.Text = "Aranan Kişi Yok"; return; }
            else if (Aranan.MezunBilgileri.Mezuniyet.BasariBelgesi == true) { temp = "Var"; }
            else if (Aranan.MezunBilgileri.Mezuniyet.BasariBelgesi == false) { temp = "Yok"; }
            txtDigerIslemler.Text += "Numaraya Göre Arama" + Environment.NewLine + Environment.NewLine +
                             "Kişisel Bilgiler" + Environment.NewLine + Environment.NewLine +
                             "Ad-Soyad: " + Aranan.MezunBilgileri.Ad + Environment.NewLine +
                             "Adres: " + Aranan.MezunBilgileri.Adres + Environment.NewLine +
                             "Doğum Tarihi: " + Aranan.MezunBilgileri.DogumTarihi + Environment.NewLine +
                             "E-Posta: " + Aranan.MezunBilgileri.ePosta + Environment.NewLine +
                             "İlgi Alanları: " + Aranan.MezunBilgileri.IlgiAlanlari + Environment.NewLine +
                             "Uyruk: " + Aranan.MezunBilgileri.Uyruk + Environment.NewLine +
                             "İngilizce Seviyesi: " + Aranan.MezunBilgileri.IngilizceSeviye + Environment.NewLine + Environment.NewLine +
                             "Mezuniyet Bilgileri: " + Environment.NewLine + Environment.NewLine +
                             "Bölüm Adı: " + Aranan.MezunBilgileri.Mezuniyet.BolumAdi + Environment.NewLine +
                             "Başlangıç Tarihi: " + Aranan.MezunBilgileri.Mezuniyet.BaslangicTarihi + Environment.NewLine +
                             "Bitiş Tarihi: " + Aranan.MezunBilgileri.Mezuniyet.BitisTarihi + Environment.NewLine +
                             "Not Ortalaması: " + Aranan.MezunBilgileri.Mezuniyet.NotOrtalamasi + Environment.NewLine +
                             "Başarı Belgesi: " + temp + Environment.NewLine + Environment.NewLine +
                             "Staj Deneyim Bilgileri: " + Environment.NewLine + Environment.NewLine +
                             "Şirket Adı: " + Aranan.MezunBilgileri.StajDeneyim.SirketAdi + Environment.NewLine +
                             "Departman: " + Aranan.MezunBilgileri.StajDeneyim.Departman + Environment.NewLine +
                             "Görev: " + Aranan.MezunBilgileri.StajDeneyim.Gorev + Environment.NewLine +
                             "Tarih: " + Aranan.MezunBilgileri.StajDeneyim.Tarih;
        }

        private void btnSiralama_Click(object sender, EventArgs e)
        {
            txtDigerIslemler.Text = "";
            Mezunlar.InOrder();
            txtDigerIslemler.Text += "In-Order" + Environment.NewLine + Mezunlar.AgactakiKisiler + Environment.NewLine + Environment.NewLine;
            Mezunlar.PreOrder();
            txtDigerIslemler.Text += "Pre-Order" + Environment.NewLine + Mezunlar.AgactakiKisiler + Environment.NewLine + Environment.NewLine;
            Mezunlar.PostOrder();
            txtDigerIslemler.Text += "Post-Order" + Environment.NewLine + Mezunlar.AgactakiKisiler;
        }

        private void btnDoksanUstuOrtalamalilar_Click(object sender, EventArgs e)
        {
            txtDigerIslemler.Text = "";
            txtDigerIslemler.Text += "Ortalaması 90'dan Yüksek Olan Mezunlar: " + Environment.NewLine + Mezunlar.OrtalamaBazindaArama();
        }

        private void btnAdvancedMezunlar_Click(object sender, EventArgs e)
        {
            txtDigerIslemler.Text = "";
            txtDigerIslemler.Text = "İngilizce Seviyesi ADVANCED Olan Mezunlar: " + Environment.NewLine + Mezunlar.IngilizceSeviyeBazindaArama();
        }

        private void btnElemanVeDerinlik_Click(object sender, EventArgs e)
        {
            txtDigerIslemler.Text = "";
            txtDigerIslemler.Text = "Eleman Sayısı: " + Mezunlar.ElemanSayisi() + Environment.NewLine +
                                    "Ağacın Derinliği: " + Mezunlar.DerinlikSayisi();
        }

        private void btnSirketEkle_Click(object sender, EventArgs e)
        {
            Sirket s = new Sirket(txtSirketAdi.Text, cbSirketBolum.Text); Sirket.SirketEkle(s);
        }

        private void btnSirketGoruntule_Click(object sender, EventArgs e)
        {
            txtSirketGoruntule.Text = Sirket.SirketGoruntule().ToString();
        }

        private void cbBolumeGoreMezunListele_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnEnIyiMezunaIsTeklifEt_Click(object sender, EventArgs e)
        {

        }

        private void btnIsTeklifEt_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bolumAdi + " bölümünün en başarılı mezunu olan " + EnIyiMezun + " iş teklifine hak kazanmıştır.");
        }
    }
}
