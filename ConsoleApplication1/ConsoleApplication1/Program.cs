namespace ConsoleApplication1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var statement = "おなかすいた。";

            // Personクラスをインスタンス化
            var person = new Person();
            person.SpeakingToMyself(statement);
            Console.WriteLine(person.Statement);

            // PersonXクラスをインスタンス化
            var personX = new PersonX();
            personX.SpeakingToMyself(statement);
            Console.WriteLine(personX.Statement);

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }
    }
}
