using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoExtendsionMethod_linQ
{
    static class AccountExtension
    {
        static public void Display(this Account a)
        {
            Console.WriteLine(a);
        }
    }
}
