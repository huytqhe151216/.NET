using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoEvent
{
    class MyButton
    {
        private int id;//field
        public int Id //public property
        {
            get { return id; }
            set { id = value; }
        }

        //private EvenHandler ClickDelegate;// delegate vai tro giong field
        //public event EvenHandler Onclick//vai tro giong public property
        //{
        //    add { ClickDelegate += value; }
        //    remove { ClickDelegate -= value; }
        //}

        // viet tat thanh
        public event EventHandler OnClick;

        public void Click()
        {
            //if (ClickDelegate != null) ClickDelegate(this, 0);
            if (OnClick != null) OnClick(this, 0);
        }
    }
    delegate void EventHandler(object sender, int param);

}
