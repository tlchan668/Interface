using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class Hello {

        ISpeakable Language;

        public void Speak() {
            //create property of type interface
            Language.SayHello();//injected into the program at runtime
                                //if switched then this would not change
            Language.SayGoodbye();
            
        }
        /*to make it so that can call say hello and goodbye seperately and 
         * cann from command line but changed to be like gregs

        public void Goodbye(){
            Language.SayGoodbye();
            }*/
        public Hello(ISpeakable language) {//constructor take a param  
            Language = language;            //take an instance of a class and use it in another
        }
       
    }
}
