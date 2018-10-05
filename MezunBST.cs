using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProjesi
{
    public class MezunBST
    {
        private MezunNode Kok { get; set; }
        private MezunNode OgrenciNoyaGoreMezun { get; set; }
        public string DoksanUstuNotuOlanlar { get; set; }
        public string AdvancedIngilizcesiOlan { get; set; }
        public string AgactakiKisiler { get; set; }
        int DoksanUstuMezunlarIcinSayac = 0;
        int AdvancedMezunlarIcinSayac = 0;

        public MezunBST()
        {
            
        }

        public MezunBST(MezunNode Kok)
        {
            this.Kok = Kok;
        }

        public void Ekle(Mezun Mezun, StajDeneyimNode StajDeneyim, MezuniyetBilgilerNode Mezuniyet)
        {
            MezunNode tmpParent = new MezunNode();
            MezunNode tmpSearch = Kok;
            MezunNode yeniKisi = new MezunNode(Mezun, StajDeneyim, Mezuniyet);
            while (tmpSearch != null)
            {
                tmpParent = tmpSearch;
                if (Mezun.OgrenciNo == tmpSearch.MezunBilgileri.OgrenciNo) { return; }
                else if (Mezun.OgrenciNo < tmpSearch.MezunBilgileri.OgrenciNo) { tmpSearch = tmpSearch.Sol; }
                else { tmpSearch = tmpSearch.Sag; }
            }
            if (Kok == null) { Kok = yeniKisi; }
            else if (Mezun.OgrenciNo < tmpParent.MezunBilgileri.OgrenciNo) { tmpParent.Sol = yeniKisi; }
            else { tmpParent.Sag = yeniKisi; }
        }

        public void Ekle(MezunNode Mezun)
        {
            MezunNode geciciAile = new MezunNode();
            MezunNode geciciAra = Kok;
            MezunNode yeniKisi = new MezunNode(Mezun.MezunBilgileri);
            while (geciciAra != null)
            {
                geciciAile = geciciAra;
                if (Mezun.MezunBilgileri.Ad == geciciAra.MezunBilgileri.Ad) { return; }
                else if (String.Compare(Mezun.MezunBilgileri.Ad, geciciAra.MezunBilgileri.Ad) < 0) { geciciAra = geciciAra.Sol; }
                else { geciciAra = geciciAra.Sag; }
            }
            if (Kok == null) { Kok = yeniKisi; }
            else if (String.Compare(Mezun.MezunBilgileri.Ad, geciciAra.MezunBilgileri.Ad) < 0) { geciciAile.Sol = yeniKisi; }
            else { geciciAile.Sag = yeniKisi; }
        }

        public void Guncelle(string Isim, Mezun Mezun, MezuniyetBilgilerNode Mezuniyet, StajDeneyimNode Deneyim)
        {
            Guncelle(Kok, Isim, Mezun, Mezuniyet, Deneyim);
        }

        private void Guncelle(MezunNode Dugum, string Isim, Mezun Mezun, MezuniyetBilgilerNode Mezuniyet, StajDeneyimNode Deneyim)
        {
            int temp = 0;
            if (Dugum == null) { return; }
            else if (Dugum.MezunBilgileri.Ad == Isim)
            {
                Dugum.MezunBilgileri.Adres = Mezun.Adres;
                Dugum.MezunBilgileri.Telefon = Mezun.Telefon;
                Dugum.MezunBilgileri.ePosta = Mezun.ePosta;
                Dugum.MezunBilgileri.Uyruk = Mezun.Uyruk;
                Dugum.MezunBilgileri.DogumTarihi = Mezun.DogumTarihi;
                temp = Dugum.MezunBilgileri.OgrenciNo;
                Dugum.MezunBilgileri.OgrenciNo = Mezun.OgrenciNo;
                Dugum.MezunBilgileri.IngilizceSeviye = Mezun.IngilizceSeviye;
                Dugum.MezunBilgileri.IlgiAlanlari = Mezun.IlgiAlanlari;
            }
            else if (String.Compare(Isim, Dugum.MezunBilgileri.Ad) < 0) { Guncelle(Dugum.Sol, Isim, Mezun, Mezuniyet, Deneyim); }
            else { Guncelle(Dugum.Sag, Isim, Mezun, Mezuniyet, Deneyim); }
        }

        public bool Sil(int No)
        {
            MezunNode Current = Kok;
            MezunNode Parent = Kok;
            bool isSol = true;
            while (Current.MezunBilgileri.OgrenciNo != No)
            {
                Parent = Current;
                if (Current.MezunBilgileri.OgrenciNo < No) { isSol = false; Current = Current.Sag; }
                else { isSol = true; Current = Current.Sol; }
                if (Current == null) { return false; }
            }
            if (Current.Sol == null && Current.Sag == null)
            {
                if (Current == Kok) { Kok = null; }
                else if (isSol) { Parent.Sol = null; }
                else { Parent.Sag = null; }
            }
            else if (Current.Sol == null)
            {
                if (Current == Kok) { Kok = Current.Sag; }
                else if (isSol) { Parent.Sol = Current.Sag; }
                else { Parent.Sag = Current.Sag; }
            }
            else if (Current.Sag == null)
            {
                if (Current == Kok) { Kok = Current.Sol; }
                else if (isSol) { Parent.Sol = Current.Sol; }
                else { Parent.Sag = Current.Sol; }
            }
            else
            {
                MezunNode successor = Successor(Current);
                if (Current == Kok) { Kok = successor; }
                else if (isSol) { Parent.Sol = successor; }
                else { Parent.Sag = successor; }
                successor.Sol = Current.Sol;
            }
            return true;
        }

        private MezunNode Successor(MezunNode Dugum)
        {
            MezunNode SuccessorParent = Dugum;
            MezunNode Successor = Dugum;
            MezunNode Current = Dugum.Sag;
            while (Current != null)
            {
                SuccessorParent = Successor;
                Successor = Current;
                Current = Current.Sol;
            }
            if (Successor != Dugum.Sag)
            {
                SuccessorParent.Sol = Successor.Sag;
                Successor.Sag = Dugum.Sag;
            }
            return Successor;
        }

        public MezunNode OgrenciNoBazindaArama(int No)
        {
            return OgrenciNoBazindaArama(Kok, No);
        }

        private MezunNode OgrenciNoBazindaArama(MezunNode Dugum, int No)
        {
            if (Dugum == null)
            {
                return null;
            }
            else if (Dugum.MezunBilgileri.OgrenciNo == No)
            {
                return OgrenciNoyaGoreMezunYazdir(Dugum);
            }
            else if (Dugum.MezunBilgileri.OgrenciNo < No)
            {
                return (OgrenciNoBazindaArama(Dugum.Sag, No));
            }
            else
            {
                return OgrenciNoBazindaArama(Dugum.Sol, No);
            }
        }

        private MezunNode OgrenciNoyaGoreMezunYazdir(MezunNode Dugum)
        {
            return Dugum;
        }

        public string OrtalamaBazindaArama()
        {
            DoksanUstuNotuOlanlar = "";
            DoksanUstuMezunlarIcinSayac = 0;
            OrtalamaBazindaArama(Kok);
            return DoksanUstuNotuOlanlar;
        }

        private void OrtalamaBazindaArama(MezunNode Dugum)
        {
            MezunBST DoksanUstuMezunlar = new MezunBST();
            if (Dugum == null) { return; }
            else if (Dugum.MezuniyetBilgileri.GetGraduationAverage(1) >= 90)
            {
                DoksanUstuMezunlarIcinSayac++;
                DoksanUstuNotuOlanlar += DoksanUstuMezunlarIcinSayac + ". kişinin Adı-Soyadı: " + Dugum.MezunBilgileri.Ad + Environment.NewLine;
            }
            OrtalamaBazindaArama(Dugum.Sol);
            OrtalamaBazindaArama(Dugum.Sag);
        }


        public string IngilizceSeviyeBazindaArama()
        {
            AdvancedMezunlarIcinSayac = 0;
            AdvancedIngilizcesiOlan = "";
            IngilizceSeviyeBazindaArama(Kok);
            return AdvancedIngilizcesiOlan;
        }
        
        private void IngilizceSeviyeBazindaArama(MezunNode Dugum)
        {
            MezunBST AdvancedOlanMezunlar = new MezunBST();
            if (Dugum == null) { return; }
            else if (Dugum.MezunBilgileri.IngilizceSeviye == "Advanced")
            {
                AdvancedMezunlarIcinSayac++;
                AdvancedIngilizcesiOlan += AdvancedMezunlarIcinSayac + ". kişinin Adı-Soyadı: " + Dugum.MezunBilgileri.Ad + Environment.NewLine;
            }
            IngilizceSeviyeBazindaArama(Dugum.Sol);
            IngilizceSeviyeBazindaArama(Dugum.Sag);
        }

        public void PreOrder()
        {
            AgactakiKisiler = "";
            PreOrder(Kok);
        }

        private void PreOrder(MezunNode Dugum)
        {
            if (Dugum == null) { return; }
            Ziyaret(Dugum);
            PreOrder(Dugum.Sol);
            PreOrder(Dugum.Sag);
        }

        public void InOrder()
        {
            AgactakiKisiler = "";
            InOrder(Kok);
        }

        private void InOrder(MezunNode Dugum)
        {
            if (Dugum == null) { return; }
            PreOrder(Dugum.Sol);
            Ziyaret(Dugum);
            PreOrder(Dugum.Sag);
        }

        public void PostOrder()
        {
            AgactakiKisiler = "";
            PostOrder(Kok);
        }

        private void PostOrder(MezunNode Dugum)
        {
            if (Dugum == null) { return; }
            PreOrder(Dugum.Sol);
            PreOrder(Dugum.Sag);
            Ziyaret(Dugum);
        }

        private void Ziyaret(MezunNode Dugum)
        {
            AgactakiKisiler += Dugum.MezunBilgileri.Ad + "  ";
        }

        public int DerinlikSayisi()
        {
            return DerinlikSayisi(Kok);
        }

        private int DerinlikSayisi(MezunNode Dugum)
        {
            if (Dugum == null) { return 0; }
            else
            {
                int solDerinlik = DerinlikSayisi(Dugum.Sol);
                int sagDerinlik = DerinlikSayisi(Dugum.Sag);
                if (solDerinlik > sagDerinlik) { return solDerinlik + 1; }
                else { return sagDerinlik + 1; }
            }
        }

        public int ElemanSayisi()
        {
            return ElemanSayisi(Kok);
        }

        private int ElemanSayisi(MezunNode Dugum)
        {
            int Toplam = 0;
            if (Dugum != null)
            {
                Toplam = 1;
                Toplam += ElemanSayisi(Dugum.Sol);
                Toplam += ElemanSayisi(Dugum.Sag);
            }
            return Toplam;
        }
    }
}
