namespace ConsoleApplication1
{
    internal class Person
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public Person()
        {
            this.Statement = "どうも。";
        }

        /// <summary>
        /// 発言内容を取得します。
        /// </summary>
        /// <returns>現在の発言を返します。</returns>
        public string Statement { get; set; }
    }
}
