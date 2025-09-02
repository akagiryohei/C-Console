using System;

namespace ConsoleApplication1
{
    class EventTest
    {
        private string _name;
        /// <summary>
        /// 名前を取得または設定します。
        /// </summary>
        public string Name
        {
            get { return this._name;  }
            set
            {
                if (this._name != value)
                {
                    this._name = value;
                    Console.WriteLine("名前が変更されました。");
                    RaiseNameChanged();
                }
            }
        }

        /// <summary>
        /// 名前が変更されたときに発生します。
        /// </summary>
        public event EventHandler NameChanged;

        /// <summary>
        /// NameChanged イベントを発行します。
        /// </summary>
        private void RaiseNameChanged()
        {
            var h = this.NameChanged;
            if (h != null)
            {
                Console.WriteLine("イベントを発生させます。");
                h(this, EventArgs.Empty);
            }
        }
    }
}
