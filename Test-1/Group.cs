using System;
using System.Collections.Generic;
using System.Text;

namespace Test_1
{
    internal class Group
    {
        private Student[] students = new Student[0];

        public void RemoveStudent(string name)
        {
            Student endElem = students[students.Length - 1];
            for (int i = 0; i < students.Length; i++)
            {
                if (students[i].Fullname.Contains(name))
                {
                    students[i] = endElem;
                    Array.Resize(ref students,students.Length-1);
                }
            }
        }
    }
}
