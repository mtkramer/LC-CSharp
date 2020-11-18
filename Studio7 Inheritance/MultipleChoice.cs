using System;

namespace Studio7_Inheritance
{
    class MultipleChoice : Question
    {
        public readonly string[] choices;

        public MultipleChoice(string text, string[] choices) : base(text)
        {
            this.choices = choices;
        }

        public override void Ask()
        {
            string template = $"{text}?\n\n";
            char[] letters = { 'A', 'B', 'C', 'D' };
            for(uint i=0; i<choices.Length; i++)
            {
                template += $"{letters[i]}.) {choices[i]}\n";
            }
            template += "Please enter the letter of your answer: ";
            Console.Write(template);
            string input = Console.ReadLine().ToUpper();
            Response = input[0].ToString();
        }


    }
}
