namespace _02._14_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Karakter> karakterek = [];

            Beolvasas("karakterek.txt", karakterek);
            LegmagasabbEletero(karakterek);
        }

        static void Beolvasas(string filnenev, List<Karakter> karakterek)
        {
            StreamReader sr = new(filnenev);

            sr.ReadLine();

            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine();
                string[] szavak = sor.Split(';');

                Karakter karakter = new(szavak[0], Convert.ToInt16(szavak[1]), Convert.ToInt16(szavak[2]), Convert.ToInt16(szavak[3]));
                karakterek.Add(karakter);
            }
        }

        static void LegmagasabbEletero(List<Karakter> karakterek)
        {
            int max = karakterek[0].Eletero;
            int index = 0;
            for (int i = 1; i < karakterek.Count; i++)
            {
                if (karakterek[i].Eletero > max)
                {
                    max = karakterek[i].Eletero;
                    index = i;
                }
            }
            Console.WriteLine($" 2.Feladat: {karakterek[index]}");
        }
    }
}
