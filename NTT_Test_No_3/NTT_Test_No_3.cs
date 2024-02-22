using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace NTT
{
    public class NTT_Test_No_3
    {
        public static void Main(string[] args)
        {
            Console.Write("Input Z : ");
            int Z = Convert.ToInt32(Console.ReadLine());
            int result = functionHitungFaktor(Z);

            Console.WriteLine();
            Console.WriteLine("Output Z : " + result);

        }

        public static int functionHitungFaktor(int z)
        {
            try {
                StringBuilder result = new StringBuilder();
                int totalFaktor = 0;
                for (int start = 1; start <= z; start++)
                {
                    if (z % start == 0)
                    {
                        result.Append(start);

                        if (start < z)
                        {
                            result.Append(", ");
                        }

                        totalFaktor++;
                    }
                }

                return totalFaktor;
            }
            catch (Exception ex)
            {
                // Log Data Error disini
                Console.WriteLine("Error  : " + ex.Message);
                throw;
            }

        }
    }
}
