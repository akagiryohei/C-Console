namespace ConsoleApplication1
{
    using System;

    class Program
    {
        static void Main(string[] args)
        {
            var test = new EventTest();
            test.NameChanged += OnNameChanged;

            Console.WriteLine("処理をおこないます。");
            test.Name = "Mike";

            Console.WriteLine("何かキーを押すと終了します。");
            Console.ReadKey();
        }
        
        /// <summary>
        /// NameChanged イベントハンドラ
        /// </summary>
        /// <param name="sender">イベント発行元</param>
        /// <param name="e">イベント引数</param>
        private static void OnNameChanged(object sender,EventArgs e)
        {
            Console.WriteLine("NameChanged イベントハンドラが実行されました。");
        }


    }
}
