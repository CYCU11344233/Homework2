using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int studentID = -1;
            float temp;
            List<float> curScores = new List<float>();
            Dictionary<int, float> Students = new Dictionary<int, float>();
            
            Dictionary<string, List<float>> classScores = new Dictionary<string, List<float>>();
            classScores.Add("國文", new List<float>());
            classScores.Add("數學", new List<float>());
            classScores.Add("英文", new List<float>());

            // Input
            while (studentID != 0) {
                // 學號
                Console.Write("請輸入學號：");
                if (int.TryParse(Console.ReadLine(), out var id)){
                    studentID = id;
                }
                if (studentID == 0) { break; }

                // 學生分數
                Console.Write("國文分數：");
                temp = System.Convert.ToSingle(Console.ReadLine());
                curScores.Add(temp);
                classScores["國文"].Add(temp);

                Console.Write("數學分數：");
                temp = System.Convert.ToSingle(Console.ReadLine());
                curScores.Add(temp);
                classScores["數學"].Add(temp);

                Console.Write("英文分數：");
                temp = System.Convert.ToSingle(Console.ReadLine());
                curScores.Add(temp);
                classScores["英文"].Add(temp);

                Students[studentID] = curScores.Average();
                curScores.Clear();
            }

            // Result
            Console.WriteLine("------------------");

            foreach (var student in Students)
            {
                Console.WriteLine("學號 "+student.Key+" 的平均分數 : "+student.Value);
            }

            Console.WriteLine("------------------");

            foreach (var subject in classScores)
            {
                float avgScore = subject.Value.Average();
                Console.WriteLine("全班 "+subject.Key+" 的平均分數 : "+ avgScore);
            }

            Console.WriteLine("------------------");

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
