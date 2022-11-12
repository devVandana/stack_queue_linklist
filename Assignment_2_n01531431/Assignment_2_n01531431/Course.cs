using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Formats.Asn1.AsnWriter;

namespace Assignment_2_n01531431
{
    internal class Course
    {
        public Course(string courseName, int score)
        {
            CourseName = courseName;
            Score = score;
        }
        public string CourseName { get; set; }
        public int Score { get; set; }
    }
}
