namespace ConsoleApplication1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            // Personクラスをインスタンス化
            var person = new Person();

            Console.WriteLine(person.Statement);
            person.Statement = "こんにちは。";
            Console.WriteLine(person.Statement);

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }
    }
}
