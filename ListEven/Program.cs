using System.Collections.Generic;

namespace ListEven
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();
            //otpechatvane na funkciite
           
            Console.WriteLine("Nechetni"+ string.Join("",GetEvenElements(list)));
            Console.WriteLine("Chetni"+ string.Join("",GetOddElements(list)));
        }
        static List<int> GetEvenElements(List<int> inputs)
        {
            List<int> listEven = new List<int>();
            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i] % 2 == 0)
                {
                    listEven.Add(inputs[i]);
                }
            }
            return listEven;
        }

        static List<int> GetOddElements(List<int> inputs)
        {
            List<int> listodd = new List<int>();
            for (int i = 0; i < inputs.Count; i++)
            {
                if (inputs[i] % 2 != 0)
                {
                    listodd.Add(inputs[i]);
                }
            }
            return listodd;
        }
    }
}
