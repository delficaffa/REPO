using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1.Foo
{
    public class Class1
    {
        public int myVar;

        public int MyProperty2
        {
            get { return myVar; }
            set { myVar = value; }
        }

        public int MyProperty { get; set; }

    }
}
