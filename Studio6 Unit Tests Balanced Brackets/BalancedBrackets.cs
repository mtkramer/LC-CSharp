using System;

namespace Studio6_Unit_Tests_Balanced_Brackets
{
    public class BalancedBrackets
    {
        private char[] CharArray { get; }
        private bool IsBalanced { get; set; } = false;
        public BalancedBrackets(string str) { 
            if (str.Length == 0) { IsBalanced = true; }
            CharArray = str.ToCharArray();
        }
        public bool CheckBalance()
        {
            if (!IsBalanced)
            {
                for(int i=0; i<CharArray.Length; i++)
                {
                    if(CharArray[i] == ']') { return false; }
                    if (CharArray[i] == '[')
                    {
                        int count = 1;
                        for(int j=i; j<CharArray.Length; j++)
                        {
                            if (CharArray[j] == '[') { count++; }
                            if (CharArray[j] == ']') { count--; }
                        }
                        if(count == 0)
                        {
                            return true;
                        }
                        return false;
                    }
                }
            }
            return IsBalanced;
        }
    }
}