using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class Superwidget  : IPrintable {
        public void Print() {
            Console.WriteLine("SuperWidget");
        }
    }
}
