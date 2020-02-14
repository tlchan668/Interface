using System;
using System.Collections.Generic;
using System.Text;

namespace Interface {
    interface ISpeakable {
        
        void SayHello();
        void SayGoodbye();

        string GetMessage(int messageNumber);
    }
}
