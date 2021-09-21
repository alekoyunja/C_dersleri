using System;

namespace ShortTipi
{
    class program1
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu Giriniz");

            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu Girin");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("Zayıfsınız   ...!");
                Console.ReadLine();
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("Endeksiniz Normal");
                Console.ReadLine();
            }
            else if (bke > 25)
            {
                Console.WriteLine("Az ye kaşiim");
                Console.ReadLine();
            }

            /*
                        int bakiye = 1000;
                        Console.WriteLine(" ATM ye Hoşgeldiniz");
                        Console.WriteLine(" Yapmak istediğiniz işlemi seçiniz");
                        Console.WriteLine("1 - Bakiye öğrenme");
                        Console.WriteLine("2 - Para Çekme");
                        Console.WriteLine("3 - Para Yatırma");
                        Console.WriteLine("q - Sistemden Ayrılma");
                        //Console.ReadLine();
                        String islem = Console.ReadLine();

                        if (islem=="1")
                        {
                            Console.WriteLine("Şu anki bakiyeniz : " + bakiye);
                            Console.ReadLine();

                        }
                        else if (islem=="2")
                        {
                            Console.WriteLine("Çekmek istediğiniz tutarı giriniz ?");


                            int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                            if(cekilecek_tutar >= bakiye || cekilecek_tutar <= 0)
                            {
                                Console.WriteLine("Hatalı tutar girdiniz");
                            }
                            else
                            {
                                bakiye -= cekilecek_tutar;
                                Console.WriteLine("Kalan tutarızınız : " + bakiye);
                                Console.ReadLine();
                            }

                        }
                        else if (islem=="3")
                        {
                            Console.WriteLine("Yatırmak istediğiniz tutarı giriniz");

                            int yatırılacak_tutar = Convert.ToInt32(Console.ReadLine());
                            if(yatırılacak_tutar>=0)
                            {
                                bakiye += yatırılacak_tutar;
                                Console.WriteLine("Yeni bakiyeniz : " + bakiye);
                                Console.ReadLine();
                            }
                            else
                            {
                                Console.WriteLine("Geçerli bir bakiye giriniz");
                            }

                        }
                        else if(islem=="q")
                        {
                            Console.WriteLine("ATM den çıkış yapılıyor, yine bekleriz");
                            Console.WriteLine("Çıkış yapıldı");
                            Console.ReadLine();
                        }
                        else
                        {
                            Console.WriteLine("Lütfen geçerli bir işlem seçiniz");
                            Console.ReadLine();
                        }



                    }*/

        }
    }
}
