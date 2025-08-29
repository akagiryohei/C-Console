namespace ConsoleApplication1
{
    internal class Person
    {
        /// <summary>
        /// 発言内容
        /// </summary>
        private string _statement;

        /// <summary>
        /// 発言内容を取得します。
        /// </summary>
        /// <returns>現在の発言を返します。</returns>
        public string Statement
        {
            get { return this._statement; }
            set { this._statement = value; }
        }
    }
}
