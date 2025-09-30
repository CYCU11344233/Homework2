using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2025._09._30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentID = -1;
            List<int> scores = new List<int>();

            while (studentID != 0) {
                Console.Write("請輸入學號：");
                if (int.TryParse(Console.ReadLine(), out var id)){
                    studentID = id;
                }
                if (studentID == 0) { break; }

                Console.Write("國文分數：");
                scores.Add(System.Convert.ToInt32(Console.ReadLine()));

                Console.Write("數學分數：");
                scores.Add(System.Convert.ToInt32(Console.ReadLine()));

                Console.Write("英文分數：");
                scores.Add(System.Convert.ToInt32(Console.ReadLine()));
            }

            // Calculate
            if (scores.Count > 0) {
                double avgScore = scores.Average();
                Console.WriteLine("平均分數 : " + avgScore.ToString());
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
