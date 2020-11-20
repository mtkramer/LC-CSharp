using System;
using System.Collections;
using System.Collections.Generic;

namespace Reading8_Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            Job j1 = new Job("Junior Developer", "Entry level.");
            Job j2 = new Job("Senior Developer", "5 years experience.");
            JobComparer jc = new JobComparer();
            int result = jc.Compare(j1, j2);
            Console.WriteLine(result);

            DaysOfTheWeek dow = new DaysOfTheWeek();
            foreach(string day in dow)
            {
                Console.WriteLine(day);
            }

        }

        public class DaysOfTheWeek : IEnumerable
        {
            private string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

            public IEnumerator GetEnumerator()
            {
                for (int i=0; i < days.Length; i++)
                {
                    yield return days[i];
                }
            }
        }
    }
}
