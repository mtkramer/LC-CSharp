using System;
using System.Collections.Generic;
using System.Text;

namespace Exercise7_Inheritance
{
    public class Message
    {
        public bool Friendly { get; } = true;
        public string Language { get; }
        public string Text { get; }

        public Message(string language, string text)
        {
            Language = language;
            Text = text;
        }
    }

    public class Greeting : Message
    {
        public bool Waving { get; set; }

        public Greeting(string language, string text) : base(language, text) { }

        public void Wave()
        {
            Waving = true;
        }
    }
}
