
namespace Studio7_Inheritance
{
    class Question
    {
        public readonly string text;
        public char[] Response;

        public Question(string text)
        {
            this.text = text;
        }

        public virtual void Ask() {  }


    }
}
