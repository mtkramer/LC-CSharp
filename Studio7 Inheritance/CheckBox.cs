using System;
using System.Collections.Generic;
using System.Text;

namespace Studio7_Inheritance
{
    class CheckBox : Question
    {
        public readonly string[] choices;

        public CheckBox(string text, string[] choices) : base(text)
        {
            this.choices = choices;
        }

        public override void Ask()
        {
            string template = $"{text}?\n\n";
            char[] letters = { 'A', 'B', 'C', 'D', 'E', 'F' };
            for (uint i = 0; i < choices.Length; i++)
            {
                template += $"{letters[i]}.) {choices[i]}\n";
            }
            template += "Please enter letters for all that apply: ";
            Console.Write(template);
            Response = Console.ReadLine().ToUpper();
        }


    }
}
