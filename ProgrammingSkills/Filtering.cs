namespace ProgrammingSkills
{
    using System.Collections.Generic;
    using System.Linq;

    public class Filtering
    {
        public static IEnumerable<int> FilterEnumerable(IList<int> numbers, int maxCount)
        {
            //var d = numbers.Count() / maxCount;
            //return numbers.TakeWhile((num, idx) => idx % d == 0).Take(maxCount);

            //return numbers.TakeWhile((num, idx) => idx % 2 == 0);

            //return numbers.TakeWhile((item, idx) => idx > 10);


            var d = numbers.Count / maxCount;
            return numbers.Where((item, idx) => idx % d == 0).Take(maxCount);


            //    string[] fruits = { "apple", "passionfruit", "banana", "mango", 
            //                          "orange", "blueberry", "grape", "strawberry" };

            //    //return fruits.TakeWhile((f, idx) => f.Length >= idx);

            //    return fruits.Where((item, idx) => idx > 5);
            //}
        }
    }
}
