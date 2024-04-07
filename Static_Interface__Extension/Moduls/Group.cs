using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Interface__Extension.Moduls
{
    internal class Group
    {
        private static int GroupCount = 0;

        public static Group[] Groups { get; private set; } = new Group[0];

        public int GroupId { get; }
        public string GroupName { get; set; }
        public Student[] Students { get; set; } = new Student[0];

        public Group(string groupName)
        {
            GroupId = ++GroupCount;
            GroupName = groupName;
            AddGroup(this);
        }
        public string GetGroupInfo()
        {
            string info = $"GroupId: {GroupId}, GroupName: {GroupName}\n";
            foreach (Student student in Students)
            {
                info += $"{student.GetInfo()}\n";
            }
            return info;
        }

        public Student GetStudent(int id)
        {
            foreach (Student student in Students)
            {
                if (student.Id == id)
                    return student;
            }
            return null;
        }
        public void AddStudent(Student student)
        {
            Array.Resize(ref Students, Students.Length + 1);
            Students[Students.Length - 1] = student;
        }
    }
}
