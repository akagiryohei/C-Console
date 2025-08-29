namespace ConsoleApplication1
{
    internal class Person
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public Person()
            :this("おはよう。")
        {
        }

        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        /// <param name="statement">発言内容の初期化を指定します。</param>
        public Person(string statement)
        {
            this.Statement = statement;
        }

        /// <summary>
        /// 発言内容を取得します。
        /// </summary>
        /// <returns>現在の発言を返します。</returns>
        public string Statement { get; set; }
    }
}
