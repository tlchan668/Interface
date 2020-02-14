﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    class HelloInSpanish : ISpeakable{
        //create a dictionary
        Dictionary<int, string> messages = new Dictionary<int, string> {
            [0] = "Ready!",
            [1] = "Hello",
            [2] = "Goodbye",
            [9999] = "Message not found"
        };
        public void SayHello() {
            Console.WriteLine("Hola");
        }
        public void SayGoodbye() {
            Console.WriteLine("Hasta la vista");
        }

        public string GetMessage(int MessageNumber) {
            //check message number exists
            if (!messages.ContainsKey(MessageNumber)) {//dont find message number return 9999
                return messages[9999];
            }
            return messages[MessageNumber];
        }
    }
}
