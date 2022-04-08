using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp79
{
    public class Student
    {
        public string FullName { get; set; }
        public Dictionary<string, double> Exams=new Dictionary<string, double>();
        private static int _no;
        public int No { get; }
        public Student()
        {
            _no++;
            No = _no;
        }
        public double GetExamResult(string ExamName)
        {
            if (!string.IsNullOrEmpty(ExamName))
            {
                if (Exams.ContainsKey(ExamName))
                {
                    return Exams[ExamName];
                }
                throw new Exception("Xeta");
            }
            else
            {
                throw new Exception("Xeta!");
            }
        }
        public void AddExam(string examName,double point)
        {
            if (!string.IsNullOrEmpty(examName) && point>=0 && point<=100)
            {
                Exams.Add(examName,point);
            }
            else
            {
                throw new Exception("Xeta!");
            }
        }
        public double GetExamAvg()
        {
            double sum = 0;
            foreach (var item in Exams)
            {
                sum = sum + item.Value;
            }
            return sum;
        }
    }
}
