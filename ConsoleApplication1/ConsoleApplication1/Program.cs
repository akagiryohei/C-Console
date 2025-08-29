namespace ConsoleApplication1
{
    using System;

    class Program
    {
        /// <summary>
        /// 入力引数なし、戻り値なしのデリゲート
        /// </summary>
        delegate void SomeDelegate1();

        /// <summary>
        /// int 型の入力引数、int型の戻り値のデリゲート
        /// </summary>
        /// <param name="i"></param>
        delegate int SomeDelegate2(int i);

        static void Main(string[] args)
        {
            SomeDelegate1 d1 = Func1;
            d1();

            SomeDelegate2 d2 = Func2;
            var d2_return = d2(3);
            Console.WriteLine(d2_return + "が返ってきました。");

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }

        static void Func1()
        {
            Console.WriteLine("Func1()が呼ばれました");
        }

        static int Func2(int x)
        {
            Console.WriteLine("Func2({0})が呼ばれました。", x);

            return 2 * x;
        }
    }
}
