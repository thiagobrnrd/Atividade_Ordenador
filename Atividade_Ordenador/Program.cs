using Atividade_Ordenador;
using System;
using System.Diagnostics;
using System.Threading;

class Program
{
    static void Main(string[] args)
    {
        Stopwatch sw = Stopwatch.StartNew();
        sw.Reset();

        int[] array;
        int n = 5000;
        
        array = new int[n];
        Random random = new Random();
        for (int i = 0; i < array.Length; i++)
            array[i] = random.Next(0, 100);
        sw.Start();
        Selection.SelectionSort(array);
        //Quick.Sort(array);
        //Insertion.InsertionArray(array);
        //Quick.Sort(array);
        // Shell.ShellSort(array);
        //Merge.Sort(array);


        //imprimir(array);

        sw.Stop();
        TimeSpan ts = sw.Elapsed;

        string formated = String.Format("{0:00}:{1:00}:{2:00}.{3:0000}",
            ts.Hours, ts.Minutes, ts.Seconds, ts.Milliseconds / 10.0);
        Console.WriteLine(ts.TotalSeconds);
        Console.WriteLine("TEMPO TOTAL: " + formated);
        return;
    }

    static void imprimir(int[] array)
    {
        Console.WriteLine("Array antes da ordenação:");
        Console.WriteLine(string.Join("|", array));
       



        Console.WriteLine("\nArray após a ordenação:");
        Console.WriteLine(string.Join("|", array));
    }
}
