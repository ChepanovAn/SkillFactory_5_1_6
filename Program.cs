using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillFactory_5_1_6
{
    class Program
    {
        static int[] GetArrayFromConsole()
        {
            var result = new int[5];

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine("Введите элемент массива номер {0}", i + 1);
                result[i] = int.Parse(Console.ReadLine());
            }
            var number = 0;
            for (int j = 0; j < result.Length; j++)
            {
                for (int k = j + 1; k < result.Length; k++)
                {
                    if (result[j] > result[k])
                    {
                        number = result[k];
                        result[k] = result[j];
                        result[j] = number;
                    }
                }
            }

            for (int i = 0; i < result.Length; i++)
            {
                Console.WriteLine(result[i]);
                Console.ReadKey();
            }

            return result;
        }
        static void Main(string[] args)
        {
            GetArrayFromConsole();
        }
    }
}
