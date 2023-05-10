using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab_Csharp_Homework
{
    public struct ScoreData
    {
        public string Name { get; set; }
        public int ChiScore { get; set; }
        public int EngScore { get; set; }
        public int MathScore { get; set; }

        public ScoreData(string StudentName, int StudentChiScore, int StudentEngScore, int StudentMathScore)
        {
            Name = StudentName;
            ChiScore = StudentChiScore;
            EngScore = StudentEngScore;
            MathScore = StudentMathScore;
        }
    }

    public struct Student
    {
        public string Name;
        public int ChiScore;
        public int EngScore;
        public int MathScore;
        public decimal Total;
        public decimal Averge;
        public string Max;
        public string Min;
    }


}
