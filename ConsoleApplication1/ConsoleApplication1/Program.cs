namespace ConsoleApplication1
{
    using System;
    using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            var values = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            // 比較対象とする値を記憶させる
            var comparedValue = 5;

            // 匿名関数による比較判定基準
            Func<int, bool> predicate = delegate(int x)
            {
                // Main()メソッドのスコープにある変数も使える
                return x < comparedValue;
            };
            // 比較対象より小さい要素数を数える
            var count = Count<int>(values, predicate);
            Console.WriteLine("valuesの中で判定基準を満たす要素は" + count + "個あります。");

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }

        /// <summary>
        /// 指定された判定基準を満たすものの要素数を数えます。
        /// </summary>
        /// <typeparam name="T">判定対象とするオブジェクトの肩を指定します。</typeparam>
        /// <param name="enumerator">判定対象とするオブジェクトのコレクションを指定します。</param>
        /// <param name="prodicate">判定処理を指定します。</param>
        /// <returns>判定基準を満たす要素数を返します。</returns>
        private static int Count<T>(IEnumerable<T> enumerator, Func<T, bool> predicate)
        {
            int count = 0;
            foreach (T item in enumerator)
            {
                if (predicate(item))
                    count++;
            }
            return count;
        }
    }
}
