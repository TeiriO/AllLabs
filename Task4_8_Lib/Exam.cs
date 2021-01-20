using System;
using System.Collections.Generic;
using System.Text;

namespace Task4_8_Lib
{
    public class Exam
    {
        public string Subject { get; set; }

        public int NumberOfStudents { get; set; }

        public float Duration { get; set; }

        public Exam(string subject, int numberOfStudents, float duration)
        {
            Subject = subject;
            NumberOfStudents = numberOfStudents;
            Duration = duration;
        }

        public virtual double СaclQuality()
        {
            return NumberOfStudents / Duration;
        }

        public double GetQuality()
        {
            return СaclQuality();
        }

        public override string ToString()
        {
            return $"Экзамен \"{Subject}\". " +
                $"Количество студентов: {NumberOfStudents}. " +
                $"Длительность экзамена: {Duration}. " +
                $"Q = {GetQuality()}. ";
        }

    }

}
