using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02._students_orm_test_demo.Models
{
    public class Grade
    {
        public int Id { get; set; }

        public double GradeScore { get; set; }

        public Student Student { get; set; }

        public Course Course { get; set; }
    }
}