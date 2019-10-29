using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    class Class1    //har 1 field
    {
        public string Name { get; set; }
    }

    class Class2 : Class1   //har 2 field
    {
        public int Age { get; set; }
    }

    class Class3 : Class2   //har 3 field
    {
        public string Adress { get; set; }
    }
}
