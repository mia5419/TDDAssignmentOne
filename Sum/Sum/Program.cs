using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum
{
    class Program
    {

        static void Main(string[] args)
        {
            IEnumerable<Item> data = GetDefaultData();

            var line = Console.ReadLine();
            var arguments = line.Split(',');

            var setLength = Int32.Parse(arguments[0]);
            var type = ToEnum<CalculateType>(arguments[1].ToString());
       
            var result = MakeSum(data, setLength, type);
            Console.Write(string.Join(",", result));
            Console.ReadLine();
        }

        private static CalculateType ToEnum<CalculateType>(string v)
        {
            
        return (CalculateType)Enum.Parse(typeof(CalculateType), v, true);
        }

        private static IEnumerable<Item> GetDefaultData()
        {
            var itemlist = new List<Item>();
            
            var myData = new List<int>[]{
                        new List<int> { 1, 1, 11, 21 },
                        new List<int> { 2, 2, 12, 22 },
                        new List<int> { 3, 3, 13, 23 },
                        new List<int> { 4, 4, 14, 24 },
                        new List<int> { 5, 5, 15, 25 },
                        new List<int> { 6, 6, 16, 26 },
                        new List<int> { 7, 7, 17, 27 },
                        new List<int> { 8, 8, 18, 28 },
                        new List<int> { 9, 9, 19, 29 },
                        new List<int> { 10, 10, 20, 30},
                        new List<int> { 11, 11, 21, 31}
            };

            foreach(var data in myData)
            {
                var item = new Item();
                item.Id = data[0].ToString();
                item.Cost = data[1];
                item.Revenue = data[2];
                item.SellPrice = data[3];
                itemlist.Add(item);
            }

            return itemlist;
        }

        private static IEnumerable<int> MakeSum(IEnumerable<Item> data, int setLength, CalculateType type)
        {
            return new List<int> { 5, 6 };
        }

    }
}
