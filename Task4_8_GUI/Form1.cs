using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Task4_8_Lib;

namespace Task4_8_GUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void CreatePercentExamBtn_Click(object sender, EventArgs e)
        {
            string subject = subjectTB.Text;
            int numbeOfStudent = (int)studentCountNUD.Value;
            float duration = (float)durationNUD.Value;
            int percent = (int)percentNUD.Value;

            ModifiedExam modifiedExam = new ModifiedExam(subject, numbeOfStudent, duration, percent);
            outputTB.Text += modifiedExam.ToString() + Environment.NewLine;
        }

        private void CreateExamBtn_Click(object sender, EventArgs e)
        {
            string subject = subjectTB.Text;
            int numbeOfStudent = (int)studentCountNUD.Value;
            float duration = (float)durationNUD.Value;

            Exam exam = new Exam(subject, numbeOfStudent, duration);
            outputTB.Text += exam.ToString() + Environment.NewLine;

        }
    }
}
