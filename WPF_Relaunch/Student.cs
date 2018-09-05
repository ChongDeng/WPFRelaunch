using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_Relaunch
{
    public class Student
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Sex { get; set; }
        public string Address { get; set; }

        public List<Student> Children { get; private set; }

        public Student()
        {
            this.Children = new List<Student>();
        }

        public static List<Student> GetStudents()
        {
            var studentList = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                var stu = new Student
                {
                    Name = string.Format("张 {0}", i + 1),
                    Age = 10 + i,
                    Sex = i % 2 == 0 ? "Boy" : "Girl",
                    Address = string.Format("北京市朝阳区某某路{0}号", i + 1)
                };
                for (int j = 0; j < 5; j++)
                {
                    stu.Children.Add(new Student
                    {
                        Name = string.Format("张 {0} 孩子 {1}", i + 1, j + 1),
                        Age = 10 + i,
                        Sex = i % 2 == 0 ? "Boy" : "Girl",
                        Address = string.Format("北京市朝阳区某某路{0}号", j + 1)
                    });
                }
                studentList.Add(stu);
            }
            return studentList;
        }
    }
}
