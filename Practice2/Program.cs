using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice2
{
    class Program
    {
        #region Task1
        public static int SearchMemberInFibonacchi(int sequenceNumber)
        {
            return Enumerable.Range(1, sequenceNumber).Skip(2).Aggregate(new KeyValuePair<int, int>(1, 1), (number, index) => new KeyValuePair<int, int>(number.Value, number.Key + number.Value)).Value;

        }
        #endregion Task1

        #region Task2
        public static int Factorial(int number)
        {
            return Enumerable.Range(1, number).Aggregate(1, (p, item) => p * item);
        }
        #endregion Task2

        static void Main(string[] args)
        {
            Console.WriteLine("Fibonacchi:" + SearchMemberInFibonacchi(10));
            Console.WriteLine("Factorial:" + Factorial(10));

            #region Task3
            List<Cakes> cakes = new List<Cakes> {
                new Cakes("cake1", PastryTypes.choux, CreamTypes.coffee),
                new Cakes("cake2", PastryTypes.flaky, CreamTypes.clotted),
                new Cakes("cake3", PastryTypes.choux, CreamTypes.whipping),
                new Cakes("cake4", PastryTypes.choux, CreamTypes.coffee),
                new Cakes("cake5", PastryTypes.flaky, CreamTypes.clotted),
                new Cakes("cake6", PastryTypes.choux, CreamTypes.coffee),
                new Cakes("cake7", PastryTypes.choux, CreamTypes.coffee),
                new Cakes("cake8", PastryTypes.flaky, CreamTypes.clotted),
                new Cakes("cake9", PastryTypes.puff, CreamTypes.whipping),
                new Cakes("cake10", PastryTypes.choux, CreamTypes.chantilly),
                new Cakes("cake11", PastryTypes.flaky, CreamTypes.clotted),
                new Cakes("cake12", PastryTypes.puff, CreamTypes.chantilly)
            };
            //var sortedDetails = cakes.GroupBy(x => x.Pastry).ToDictionary(t => t.Key, t => t.ToList());
            //Console.WriteLine(sortedDetails);
            //var groupCakes = cakes.GroupBy(x => x.Pastry);
            //foreach (var group in groupCakes)
            //{
            //    Console.WriteLine(group.Key);
            //    foreach (var i in group)
            //    {
            //        Console.Write(i + " ");
            //    }
            //}
            #endregion Task3

            #region Task4
            Console.WriteLine("* Task 4 *");
            int countArray = 10;
            int[] Array = new int[countArray];

            Random rand = new Random();
            Console.WriteLine("Base array: ");
            for (int i = 0; i < Array.Length; i++)
            {
                Array[i] = rand.Next(0, 100);
                Console.Write(Array[i] + " " );
            }

            IEnumerable<IGrouping<int, int>> query = Array.GroupBy(number => number % 2);

            foreach (var group in query)
            {
                Console.WriteLine(group.Key == 0 ? "\nEven numbers:" : "\nOdd numbers:");
                foreach (int i in group)
                {
                    Console.Write(i + " ");
                }
            }
            #endregion Task4

            Console.ReadKey();
        }
    }
}
