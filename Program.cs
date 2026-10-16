namespace TombokSzamokkal
{
    
    internal class Program
    {
        static int[] tomb = new int[15];
        static Random r = new Random();
        static void Feltolt()
        {
            
                for (int i = 0; i < tomb.Length; i++)
                {
                    tomb[i] = r.Next(-20, 20);
                }
                foreach (int item in tomb)
                {
                    Console.Write(item + " ");

                }
            Console.WriteLine();
        }
        static void OsszegzesTetele() 
        {
            int osszeg = 0;
            foreach (int item in tomb)
            {
                osszeg += item;
            }
            Console.WriteLine("A tömb elemeinek összege: " + osszeg);
            
        }
        static void MegszamolasTetele()
        {
            int db = 0;
            foreach (int item in tomb)
            {
                if (item < 0)
                {
                    db++;
                }
            }
            Console.WriteLine("A tömbben található negatív számok darabszáma: " + db);
        }
        static void EldontesTetele()
        {
            int i =0;
            while (i < tomb.Length && tomb[i] != 0) 
            {
                i++;
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("A tömbben található Nulla.");
            }
            else
            {
                Console.WriteLine("A tömbben NEM található Nulla.");
            }
        }

        static void KeresesTetele()
        {
            int keresett = 0;
            int i = 0;
            while (i < tomb.Length && tomb[i] != keresett) 
            {
                i++; 
            }
            if (i < tomb.Length)
            {
                Console.WriteLine("A tömbben található a keresett szám: " + keresett);
            }
            else
            {
                Console.WriteLine("A tömbben NEM található a keresett szám: " + keresett);
            }
        }
        static void KivalasztasTetele()
        {
            tomb[8] = 10;
            int i = 0;
            while (tomb[i] != 10)
            {
                i++;
            }
            Console.WriteLine($"A keresett szám az {i + 1}. helyen található.");
        }
        static void Main(string[] args)
        {
            Feltolt(); 
            OsszegzesTetele();
            MegszamolasTetele();
            EldontesTetele();
            KeresesTetele();
            KivalasztasTetele();
        }
    }
}
