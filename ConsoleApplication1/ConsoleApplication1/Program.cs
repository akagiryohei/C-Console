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
            _comparedValue = 5;
            // 比較対象より小さい要素数を数える
            var count = Count<int>(values, IsLessThanValue);
            Console.WriteLine("values の中で判断基準を満たす要素は" + count + "個あります。");

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

        /// <summary>
        /// 比較対象とする値を保持します。
        /// </summary>
        private static int _comparedValue;

        /// <summary>
        /// ある値より小さいかどうか判断します。
        /// </summary>
        /// <param name="x">判定対象の数値を指定します。</param>
        /// <returns>指定された数値が５より小さい場合にtrueを返します。</returns>
        private static bool IsLessThanValue(int x)
        {
            return x < _comparedValue;
        }

    }
}
