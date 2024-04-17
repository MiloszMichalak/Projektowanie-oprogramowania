namespace Sprawdzian_17._04___kolekcje;

class Program
{
    
    static void Main(string[] args)
    {
        // nierosnace i niemalejace 1-1-1-1-1-1
        Console.WriteLine("zadanie 0");
        string[] wejscie = Console.ReadLine().Split("-");
        int[] liczby = Array.ConvertAll(wejscie, int.Parse);

        bool maleje = false;
        bool rosnie = false;
        bool rowna = false;
        
        for (int i = 1; i < liczby.Length; i++)
        {
            // rosnaca
            if (liczby[i - 1] <= liczby[i])
            {
                rosnie = true;
            }
            else
            {
                rosnie = false;
                break;
            }
        }
        
        for (int i = 1; i < liczby.Length; i++)
        {
            // malejaca
            if (liczby[i - 1] >= liczby[i])
            {
                maleje = true;
            }
            else
            {
                maleje = false;
                break;
            }
        }

        if (maleje)
        {
            Console.WriteLine("Malorolna");
        }
        else if (rosnie)
        {
            Console.WriteLine("Wielkomiejska");
        }
        else
        {
            Console.WriteLine("Zadna z powyzszych");
        }

        Console.WriteLine();

        Console.WriteLine("Zadanie 1");
        int[] array = new int[10];
        Random random = new Random();
        for (int i = 0; i < 10; i++)
        {
            array[i] = random.Next(-9, 10);
        }

        foreach (var item in array)
        {
            Console.Write(item + " ");
        }

        Console.WriteLine();

        List<List<int>> podciags = new List<List<int>>();
        List<int> podciag = new List<int>();

        for (int i = 1; i < array.Length; i++)
        {
            if (array[i - 1] == array[i] + 1 || array[i - 1] == array[i] - 1)
            {
                podciag.Add(array[i - 1]);
                podciag.Add(array[i]);
            }
            else
            {
                if (podciag.Count != 0)
                {
                    podciags.Add(podciag.Distinct().ToList());
                    podciag.Clear();
                }
            }
        }


        int suma = 0;
        int index = 0;
        for (int i = podciags.Count - 1; i >= 0 ; i--)
        {
            if (podciags[i].Sum() > suma)
            { 
                suma = podciags[i].Sum();
                index = i;
            }
        }

        if (podciags.Count != 0)
        {
            Console.WriteLine(podciags[index].ElementAt(0));
            Console.WriteLine(podciags[index].ElementAt(podciags[index].Count - 1));
            Console.WriteLine(podciags[index].Sum());
        }
        

        Console.WriteLine();

        Console.WriteLine("Zadanie 2");

        int w = Convert.ToInt32(Console.ReadLine());
        List<List<int>> potwor = new List<List<int>>();
        for (int i = 0; i < w; i++)
        {
            for (int j = 0; j < w; j++)
            {
                potwor[i].Add(random.Next(1, 10));
            }
            potwor.Add(potwor[i]);
        }

        Console.WriteLine();

        Console.WriteLine("Zadanie 3");
        Dictionary<int, List<int>> graf = new Dictionary<int, List<int>>();
        
        List<int> polaczenia = new List<int>();
        
        int n = Convert.ToInt32(Console.ReadLine());

        for (int i = 0 ; i < n; i++)
        {
            Console.WriteLine("wierzcholek " + (i + 1));
            
                Console.WriteLine("Podaj w lini oddzielone spacjami");
                string[] input = Console.ReadLine()!.Split(" ");

                if (input[0] != "")
                {
                    polaczenia = Array.ConvertAll(input, int.Parse).ToList();
            
                    graf.Add(i + 1, polaczenia);
                    polaczenia.Clear();
                }
                
        }
        
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());

        if (graf[a].Contains(b) && graf[b].Contains(a))
        {
            Console.WriteLine("Sa polaczone bezposrednio");
        }
        
        List<int> temp = new List<int>();
        List<int> polaczenia1 = graf[a];
        List<int> polaczenia2 = graf[b];
        int ile = 0;

        for (int i = 0; i < n; i++)
        {
            if (polaczenia1.Contains(i))
            {
                ile++;
            }

            if (polaczenia2.Contains(i))
            {
                ile++;
            }
            temp.Add(ile);
            ile = 0;
        }

        if (!temp.Contains(2))
        {
            Console.WriteLine("Miedzy tymi dwoma wierzchlokami nie wystepuja bezposrednie polaczenia");
        }
        else
        {
            Console.WriteLine("Miedzy tymi dwoma wierzchlokami wystepuje bezposrednie polaczenia");
        }
    }
}
