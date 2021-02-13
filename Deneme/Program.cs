using System;

namespace Deneme
{
    public class RefOutExample
    {
        public static void Main()
        {
            int originalValue = 43;

            Console.WriteLine("ChangeMethod'dan önce: " + originalValue);//Output 43

            ChangeMethod(1, 3, ref originalValue);

            Console.WriteLine("ChangeMethod'dan sonra: " + originalValue); //Output 47
        }

        static void ChangeMethod(int x, int y, ref int i)
        {
            i = i + x + y;//47
        }
    }
}
