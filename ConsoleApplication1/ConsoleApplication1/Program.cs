namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            var values = SampleObjects();
            foreach (var value in values.Select((x, i) => new { x, i }))
            {
                Console.WriteLine("{0} 番目は {1} です。", value.i, value.x);
            }

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }

        /// <summary>
        /// あるコレクションを返すメソッドです。
        /// </summary>
        /// <returns>サンプル用のコレクションを返します。</returns>
        private static IEnumerable<int> SampleObjects()
        {
            yield return 1;
            yield return 2;
            yield return 3;
            yield return 4;
            yield return 5;
            yield return 6;
            yield return 7;
            yield return 8;
            yield return 9;
            yield return 10;
        }
        
    }
}
