namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            for (var i = 0; i < values.Length; i++)
            {
                Console.WriteLine(values[i]);
            }

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }
    }
}
