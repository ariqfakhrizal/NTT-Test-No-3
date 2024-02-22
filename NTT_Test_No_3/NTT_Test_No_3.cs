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
            int numberEnteredZ = Convert.ToInt32(Console.ReadLine());

            int numberEnteredResult = functionHitungFaktor(numberEnteredZ);

            Console.WriteLine();
            Console.WriteLine("Output Z : " + numberEnteredResult);

        }

        public static int functionHitungFaktor(int numberEnteredZ)
        {
            try {
                StringBuilder stringBuilderResult = new StringBuilder();
                int totalFaktor = 0;

                for (int start = 1; start <= numberEnteredZ; start++)
                {
                    if (numberEnteredZ % start == 0)
                    {
                        stringBuilderResult.Append(start);

                        if (start < numberEnteredZ)
                        {
                            stringBuilderResult.Append(", ");
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
