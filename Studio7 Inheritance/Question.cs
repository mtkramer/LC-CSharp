using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Inheritance
{
    class Question
    {
        public readonly string text;
        public string Response;

        public Question(string text)
        {
            this.text = text;
        }

        public virtual void Ask() {  }


    }
}
