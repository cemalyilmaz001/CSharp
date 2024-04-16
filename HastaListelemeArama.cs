using System;

class Program
{
    static void Main(string[] args)
    {
        string[,] Hst;
        Console.Write("hasta sayısı=");
        int hs = Convert.ToInt32(Console.ReadLine());
        Hst = new string[hs, 2];
        int sec;
        do
        {
            Console.WriteLine("1-Hasta Girişi");
            Console.WriteLine("2-Tüm Liste");
            Console.WriteLine("3-Polk Liste");
            Console.WriteLine("4-Hasta Arama");
            Console.WriteLine("5-Çıkış");
            Console.WriteLine("seçiminiz(1-5)");
            sec = Convert.ToInt32(Console.ReadLine());


            if (sec == 1)
            {
                for (int i = 0; i < hs; i++)
                {
                    Console.Write("hasta adı=");
                    Hst[i, 0] = Console.ReadLine();
                    Console.Write("Polk adı=");
                    Hst[i, 1] = Console.ReadLine();
                }
            }

            if (sec == 2)
            {
                Console.WriteLine("Hasta Adı   Polk Adı");
                Console.WriteLine("---------------------");
                for (int i = 0; i < hs; i++)
                {
                    Console.WriteLine(Hst[i, 0] + "    " + Hst[i, 1]);
                }
            }


            if (sec == 3)
            {
                Console.Write("listelenecek Poljk=");
                string plk = Console.ReadLine();

                Console.WriteLine("Hasta Adı   Polk Adı");
                Console.WriteLine("---------------------");
                for (int i = 0; i < hs; i++)
                {
                    if (plk == Hst[i, 1])
                        Console.WriteLine(Hst[i, 0] + "    " + Hst[i, 1]);
                }
            }

            if (sec == 4)
            {
                Console.Write("listelenecek Hasta=");
                string Hadı = Console.ReadLine();

                Console.WriteLine("Hasta Adı   Polk Adı");
                Console.WriteLine("---------------------");
                for (int i = 0; i < hs; i++)
                {
                    if (Hadı == Hst[i, 0])
                        Console.WriteLine(Hst[i, 0] + "    " + Hst[i, 1]);
                }
            }

            Console.WriteLine();
            Console.ReadKey();

        } while (sec != 5);
    }
}
