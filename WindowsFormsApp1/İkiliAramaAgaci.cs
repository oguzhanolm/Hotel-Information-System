using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class IkiliAramaAgac
    {
        private IkiliAramaAgacDugumu kok;
        private string dugumler;
        public IkiliAramaAgac()
        {
        }
        public IkiliAramaAgac(IkiliAramaAgacDugumu kok)
        {
            this.kok = kok;
        }
        public int DugumSayisi()
        {
            return DugumSayisi(kok);
        }
        public int DugumSayisi(IkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                count = 1;
                count += DugumSayisi(dugum.sol);
                count += DugumSayisi(dugum.sag);
            }
            return count;
        }
        public int YaprakSayisi()
        {
            return YaprakSayisi(kok);
        }
        public int YaprakSayisi(IkiliAramaAgacDugumu dugum)
        {
            int count = 0;
            if (dugum != null)
            {
                if ((dugum.sol == null) && (dugum.sag == null))
                    count = 1;
                else
                    count = count + YaprakSayisi(dugum.sol) + YaprakSayisi(dugum.sag);
            }
            return count;
        }
        public string DugumleriYazdir()
        {
            return dugumler;
        }
        public void InOrder()
        {
            dugumler = "";
            InOrderInt(kok);
        }
        private void InOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            InOrderInt(dugum.sol);
            Ziyaret(dugum);
            InOrderInt(dugum.sag);
        }
        public void PostOrder()
        {
            dugumler = "";
            PostOrderInt(kok);
        }
        private void PostOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            PostOrderInt(dugum.sol);
            PostOrderInt(dugum.sag);
            Ziyaret(dugum);
        }
        public void PreOrder()
        {
            dugumler = "";
            PreOrderInt(kok);
        }
        private void PreOrderInt(IkiliAramaAgacDugumu dugum)
        {
            if (dugum == null)
                return;
            Ziyaret(dugum);
            PreOrderInt(dugum.sol);
            PreOrderInt(dugum.sag);
        }

        private void Ziyaret(IkiliAramaAgacDugumu dugum)
        {
            dugumler += dugum.veri + " ";
            dugumler += "Otel Adı: " + (dugum.veri as Otel).hotelName + " " + "Adres: " + (dugum.veri as Otel).hotelAdress + Environment.NewLine;
        }
        public void Ekle(Otel o)
        {
            //Yeni eklenecek düğümün parent'ı
            IkiliAramaAgacDugumu tempParent = new IkiliAramaAgacDugumu();
            //Kökten başla ve ilerle
            IkiliAramaAgacDugumu tempSearch = kok;

            while (tempSearch != null)
            {
                tempParent = tempSearch;
                //Deger zaten var, çık.
                if (string.Compare(o.hotelName,(tempSearch.veri as Otel).hotelName)==0)
                    return;
                else if (string.Compare(o.hotelName, (tempSearch.veri as Otel).hotelName) < 0)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
            IkiliAramaAgacDugumu eklenecek = new IkiliAramaAgacDugumu(o);
            //Ağaç boş, köke ekle
            if (kok == null)
                kok = eklenecek;
            else if (string.Compare(o.hotelName, (tempParent.veri as Otel).hotelName) == 0)
                tempParent.sol = eklenecek;
            else
                tempParent.sag = eklenecek;
        }
        public IkiliAramaAgacDugumu Ara(int anahtar)
        {
            return AraInt(kok, anahtar);
        }
        private IkiliAramaAgacDugumu AraInt(IkiliAramaAgacDugumu dugum,int anahtar)
        {
            if (dugum == null)
                return null;
            else if ((int)dugum.veri == anahtar)
                return dugum;
            else if ((int)dugum.veri > anahtar)
                return (AraInt(dugum.sol, anahtar));
            else
                return (AraInt(dugum.sag, anahtar));
        }

        public void Guncelle(IkiliAramaAgacDugumu dugum)
        {
             Otel o = (Otel)dugum.veri;
                        
            IkiliAramaAgacDugumu tempSearch = kok;
            
            while (tempSearch != null)
            {
                if (string.Compare(o.hotelName, (tempSearch.veri as Otel).hotelName) == 0)
                {
                    tempSearch.veri = o;
                    break;
                }
                else if (string.Compare(o.hotelName, (tempSearch.veri as Otel).hotelName) < 0)
                    tempSearch = tempSearch.sol;
                else
                    tempSearch = tempSearch.sag;
            }
        }

       private IkiliAramaAgacDugumu Successor(IkiliAramaAgacDugumu silDugum)
        {
            IkiliAramaAgacDugumu successorParent = silDugum;
            IkiliAramaAgacDugumu successor = silDugum;
            IkiliAramaAgacDugumu current = silDugum.sag;
            while (current != null)
            {
                successorParent = successor;
                successor = current;
                current = current.sol;
            }
            if (successor != silDugum.sag)
            {
                successorParent.sol = successor.sag;
                successor.sag = silDugum.sag;
            }
            return successor;
        }
        public bool Sil(Otel o)
        {
            IkiliAramaAgacDugumu current = kok;
            IkiliAramaAgacDugumu parent = kok;
            Otel otel = new Otel();
            bool issol = true;
            //DÜĞÜMÜ BUL
            while (Convert.ToString(current.veri)  != o.hotelName)
            {
                parent = current;
                if (string.Compare(otel.hotelName,(current.veri as Otel).hotelName)==-1)
                {
                    issol = true;
                    current = current.sol;
                }
                else
                {
                    issol = false;
                    current = current.sag;
                }
                if (current == null)
                    return false;
            }
            //DURUM 1: YAPRAK DÜĞÜM
            if (current.sol == null && current.sag == null)
            {
                if (current == kok)
                    kok = null;
                else if (issol)
                    parent.sol = null;
                else
                    parent.sag = null;
            }
            //DURUM 2: TEK ÇOCUKLU DÜĞÜM
            else if (current.sag == null)
            {
                if (current == kok)
                    kok = current.sol;
                else if (issol)
                    parent.sol = current.sol;
                else
                    parent.sag = current.sol;
            }
            else if (current.sol == null)
            {
                if (current == kok)
                    kok = current.sag;
                else if (issol)
                    parent.sol = current.sag;
                else
                    parent.sag = current.sag;
            }
            //DURUM 3: İKİ ÇOCUKLU DÜĞÜM
            else
            {
                IkiliAramaAgacDugumu successor = Successor(current);
                if (current == kok)
                    kok = successor;
                else if (issol)
                    parent.sol = successor;
                else
                    parent.sag = successor;
                successor.sol = current.sol;
            }
            return true;
        }

    }
}
