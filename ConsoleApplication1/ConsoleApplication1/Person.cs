namespace ConsoleApplication1
{
    internal class Person
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public Person()
        {
            System.Console.WriteLine("Person クラスのコンストラクタが処理されました。");
        }

        /// <summary>
        /// 発言内容を取得します。
        /// </summary>
        /// <returns>現在の発言を返します。</returns>
        public string Statement { get; private set; }

        /// <summary>
        /// 独り言をつぶやきます。
        /// </summary>
        /// <param name="statement">つぶやく独り言を指定します。</param>
        public void SpeakingToMyself(string statement)
        {
            this.Statement = statement;
        }
    }
}
