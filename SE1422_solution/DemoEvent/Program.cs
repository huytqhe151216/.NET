using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DemoEvent
{
     class Program
    {
        static void  CEButton_Click(object sender, int param)
        {
            Console.WriteLine("CE Button");
        }
        static void DigitButton_Click(object sender, int param)
        {
            Console.WriteLine("Digit Button");
        }
        static void Main()
        {
            // dinh nghia ve logic hanh dong cua nut CEButton
            MyButton CeButton = new MyButton();
            CeButton.Id = 1;
            //khi click vao CEButton ->hien thi text "CEButton len" console
            //CeButton.ClickDelegate = CEButton_Click;
            CeButton.OnClick += CEButton_Click;// goi toi lenh add

            //dinh nghia ve logic hanh dong cua nut DigitButton
            MyButton DigitButton = new MyButton();
            DigitButton.Id = 2;
            //khi click vao DigitButton -> hien thi text "Digit Button" len console
            //DigitButton.ClickDelegate = DigitButton_Click;
            DigitButton.OnClick += DigitButton_Click;// goi toi khoi lenh add

            // Qua trinh su dung CEButton va DigitButton
            CeButton.Click();
            CeButton.Click();
            CeButton.Click();
            DigitButton.Click();
            CeButton.Click();
        }

    }
}
