using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Telefon_Rehberi
{
    public class AnaRehber
    {
        
        List<Rehber> rehber = new List<Rehber>
            {
                new Rehber{Name="Ahmet", Surname="Üstün",Number="555"},
                new Rehber{Name="Samet", Surname="Baydar",Number="234"},
                new Rehber{Name="Sinan Ramazan", Surname="Kabil",Number="465"},
                new Rehber{Name="Berkan", Surname="Tekin",Number="895"},
                new Rehber{Name="İbrahim", Surname="Sarıkaya",Number="545"},
            };

        public string name;
        public string surname;
        public string number;


        public void Add()
        {
            
            Console.Write("Lütfen isim giriniz: ");
            name = Console.ReadLine();
            Console.Write("Lütfen soyisim giriniz: ");
            surname = Console.ReadLine();
            Console.Write("Lütfen numara giriniz: ");
            number = Console.ReadLine();
            rehber.Add(new Rehber { Name = name, Surname=surname, Number = number });
            Kalanlar();
        }

        public void Remove()
        {
            
            Console.WriteLine("Lütfen numarası silmek istediğiniz kişinin adını ya da soyadını giriniz: ");
            name = Console.ReadLine();
            var result = rehber.FirstOrDefault(c => c.Name == name);
            if (result == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            }
            else
            {
                Console.WriteLine("["+ result.Name +"]" + "isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string cevap = Convert.ToString(Console.ReadLine());
                if (cevap == "y")
                {
                    rehber.Remove(result);
                }
                else
                    Console.WriteLine("Kişi Silinemedi.");
                
            }
            Console.WriteLine("(1) Silmeyi Sonlandırmak için");
            Console.WriteLine("(2) Yeniden denemek için");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi==1)
            {
                Kalanlar();
                Environment.Exit(0);
            }
            else if(sayi == 2)
            {
                Sorgu();
            }
           
            Kalanlar();

        }

        public void Update()
        {
            
            Console.Write("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz: ");
            name = Console.ReadLine();
            Console.Write("Yeni numarasını giriniz: ");
            number = Console.ReadLine();
            var result = rehber.FirstOrDefault(c => c.Name == name);
            if (result == null)
            {
                Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
            }
            else
            {
                result.Number = number;
                Kalanlar();
                Environment.Exit(0);
            }
            
            Console.WriteLine("(1) Güncellemeyi Sonlandırmak için");
            Console.WriteLine("(2) Yeniden denemek için");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi==1)
            {
                Kalanlar();
                Environment.Exit(0);
            }
            else if(sayi == 2)
            {
                Sorgu();
            }

            Kalanlar();
        }

        public void List()
        {
            Console.WriteLine("Rehberde toplam: " + " " + rehber.Count + " " + "Kisi vardır");
            Kalanlar();
        }

        public void Search()
        {
            Console.WriteLine("Aramak yapmak istediğiniz tipi seçiniz: ");
            Console.WriteLine("----------------------");
            Console.WriteLine("İsim veya soyisime göre arama yapmak için: (1)");
            Console.WriteLine("Telefon numarasına göre arama yapmak için: (2)");
            int sayi = Convert.ToInt32(Console.ReadLine());
            if (sayi==1)
            {
                Console.WriteLine("Aramak istediğiniz kişinin ismini giriniz: ");
                name = Console.ReadLine();
                var result = rehber.FirstOrDefault(c => c.Name == name);
                if (result==null)
                {
                    Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil");
                }
                else
                {
                    Console.WriteLine("İsim: " + result.Name + " " + "\nSoyisim: " + result.Surname + " " + "\nTel: " + result.Number);
                }
            }
            else if (sayi == 2)
            {
                Console.WriteLine("Aramak istediğiniz kişinin numarasını giriniz: ");
                number=Console.ReadLine();
                var result2 = rehber.FirstOrDefault(a => a.Number == number);
                if (result2==null)
                {
                    Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil");
                }
                else
                {
                    Console.WriteLine("İsim: " + result2.Name + " " + "\nSoyisim: " + result2.Surname + " " + "\nTel: " + result2.Number);
                }
            }
            
            
        }
        public void EkranaYazdirma()
        {
            Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz.");
            Console.WriteLine("..................................");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");
        }
        public void Sorgu()
        {
            AnaRehber anaRehber = new AnaRehber();
            anaRehber.EkranaYazdirma();
            int num = Convert.ToInt32(Console.ReadLine());
            switch (num)     
            {
                case 1:
                    anaRehber.Add();
                    break;
                case 2:
                    anaRehber.Remove();
                    break;
                case 3:
                    anaRehber.Update();
                    break;
                 case 4:
                    anaRehber.List();
                    break;
                 case 5:
                    anaRehber.Search();
                     break; 
                default:
                     break;
            }
        }
        public void Kalanlar()
        {
            Console.WriteLine("Telefon Rehberi");
            Console.WriteLine("----------------------");
            foreach (var item in rehber)
            {
                Console.WriteLine("İsim: " + " " + item.Name);
                Console.WriteLine("Soyisim: " + " " + item.Surname);
                Console.WriteLine("Numara: " + " " + item.Number);
                Console.WriteLine("----------------------");
            }
        }
    }
}
