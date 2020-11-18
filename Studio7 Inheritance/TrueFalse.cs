using System;

namespace Studio7_Inheritance
{
    class TrueFalse : Question
    {
        public TrueFalse(string text) : base(text) { }

        public override void Ask()
        {
            string template = $"{text}?\n\n";
            template += "Please enter true or false: ";
            Console.Write(template);
            Response = Console.ReadLine().ToUpper().ToCharArray();
        }

    }
}
