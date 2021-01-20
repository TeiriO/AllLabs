using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_8_Lib
{
    public class ModifiedExam : Exam
    {

        public int Percent { get; set; }

        public ModifiedExam(string subject, int numberOfStudents, float duration, int percent) : base(subject, numberOfStudents, duration)
        {
            Percent = percent;
        }

        public override double СaclQuality()
        {
            return base.СaclQuality() * (100 - Percent) * 0.01;
        }

        public override string ToString()
        {
            return base.ToString() + $"Процент двоишников: {Percent}. ";
        }
    }
}
