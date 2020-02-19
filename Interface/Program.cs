using System;
using System.Collections.Generic;

namespace Interface {
    class Program {
        static void Main(string[] args) {
            ISpeakable english = new HelloInEnglish();
            var spanish = new HelloInSpanish();

            Hello hello = new Hello(english);//pass in instance of hello in english
            hello.Speak();
            


            Hello hello2 = new Hello(spanish);
            hello2.Speak();
          

            var hellofr = new Hello(new HelloInFrench());//did this so not create new var 
            hellofr.Speak();
     
            
            (new Hello(new HelloInChinese())).Speak();
            //(new Hello(new HelloInChinese())).Goodbye();
            TestInterfaceWidgets();
        }
        static void TestInterfaceWidgets() { 

            IPrintable w1 = new Widget();
            w1.Print();
            IPrintable aw = new Advwidget();
            aw.Print();
            IPrintable sw = new Superwidget();
            sw.Print();

            //put into a collection
            List<IPrintable> widgets = new List<IPrintable>();
            widgets.Add(w1);
            widgets.Add(aw);
            widgets.Add(sw);

            foreach (var widget in widgets) {
                widget.Print();
            }


        }
    }
}
