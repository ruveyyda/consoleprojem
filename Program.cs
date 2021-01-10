using System;

namespace ilerinesneproje
{
    class Program
    {
        static void Main(string[] args)
        {
            double secim, adet, toplam = 0;
            double hesap = 0;
            Console.WriteLine("***********************************************************************************");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("**          TATLILAR                   **               İÇECEKLER                  ");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("**      1- Cheesecake -  15 TL         **         7-Türk Kahvesi - 7.50 TL       **");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("**      2- Fırında Sütlaç - 8 TL       **         8-Americano - 8.50 TL          **");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("**      3- Tiramisu - 7 TL             **         9-Fanta - 4 TL                  **");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("** 4- Dondurmalı İrmik Helvası - 8 TL  **         10-Ihlamur - 12TL              **");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("**      5- Tavukgöğsü - 6 TL           **         11-Sahlep - 9 TL               **");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("**      6- Revani - 6 TL               **         12-Çay - 4 TL                  **");
            Console.WriteLine("**                                     **                                        **");
            Console.WriteLine("***********************************************************************************");


            for (int i = 0; i< 100; i++)
            {
                Console.WriteLine("");
                Console.WriteLine("Sipariş Vermek İstediğiniz Ürünün Numarası:  ");
                secim = Convert.ToDouble(Console.ReadLine());

                if (secim == 1)
                {
                    Console.Write("Kaç dilim cheesecake ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 15;
                    hesap = hesap + toplam;
                }

                else if (secim == 2)
                {
                    Console.Write("Kaç porsiyon sütlaç  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 8;
                    hesap = hesap + toplam;

                }
                else if (secim == 3)
                {
                    Console.Write("Kaç dilim tiramisu  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7;
                    hesap = hesap + toplam;

                }
                else if (secim == 4)
                {
                    Console.Write("Kaç porsiyon dondurmalı irmik helvası  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 8;
                    hesap = hesap + toplam;

                }
                else if (secim == 5)
                {
                    Console.Write("Kaç dilim tavukgöğsü  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap = hesap + toplam;

                }
                else if (secim == 6)
                {
                    Console.Write("Kaç dilim revani  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 6;
                    hesap = hesap + toplam;

                }
                else if (secim == 7)
                {
                    Console.Write("Kaç tane türk kahvesi  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 7.50;
                    hesap = hesap + toplam;

                }
                else if (secim == 8)
                {
                    Console.Write("Kaç tane americano  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 8.50;
                    hesap = hesap + toplam;

                }
                else if (secim == 9)
                {
                    Console.Write("Kaç tane fanta  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 4;
                    hesap = hesap + toplam;

                }
                else if (secim == 10)
                {
                    Console.Write("Kaç tane ıhlamur  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 12;
                    hesap = hesap + toplam;

                }
                else if (secim == 11)
                {
                    Console.Write("Kaç tane salep  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 9;
                    hesap = hesap + toplam;

                }
                else if (secim == 12)
                {
                    Console.Write("Kaç tane çay  ? : ");
                    adet = Convert.ToDouble(Console.ReadLine());
                    toplam = adet * 4;
                    hesap = hesap + toplam;

                }

                else
                    Console.WriteLine("Böyle Bir Seçim Yok!!");
                    Console.WriteLine();
                    Console.WriteLine("Başka Bir İsteğiniz Var Mı? ");
                    string cevap = Console.ReadLine();
                if (cevap == "hayır" || cevap == "HAYIR" || cevap == "Hayır" || cevap == "h" || cevap == "H")
                    break;

            }

            Console.WriteLine("TOPLAM TUTAR:" + hesap);

            Console.Read();
        }
    }
}
