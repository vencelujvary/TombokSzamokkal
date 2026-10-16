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

        static void Main(string[] args)
        {
            Feltolt(); 
            OsszegzesTetele();
            MegszamolasTetele();
        }
    }
}
