using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    internal class PersonX : Person
    {
        /// <summary>
        /// 新しいインスタンスを生成します。
        /// </summary>
        public PersonX()
        {
            System.Console.WriteLine("PersonX クラスのコンストラクタが処理されました。");
        }

        /// <summary>
        /// 口癖を含む独り言をつぶやきます
        /// </summary>
        /// <param name="statement">つぶやく独り言を指定します。</param>
        public override void SpeakingToMyself(string statement)
        {
            //base.SpeakingToMyself(statement);
            this.Statement = statement + "別にいいけど。";
        }
    }
}
