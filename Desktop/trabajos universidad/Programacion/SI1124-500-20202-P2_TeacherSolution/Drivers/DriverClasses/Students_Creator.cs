using System;
using System.Text;
using SoluciónProfe.Models.People;
using SoluciónProfe.Drivers.DriverClasses;
using SoluciónProfe.Models.Asignements;

namespace SoluciónProfe.Drivers.DriverClasses
{
    public class Students_Creator
    {
        #region Static Instances

        private static string _path = 
            @"C:\Users\Borking\Desktop\trabajos universidad\Programacion\SoluciónProfe\Drivers\DriverObjects\StudentData.txt";
        private static Student[] _f_studentList = new Student[20];
        public static Student[] p_studentList 
        {
            get
            {
                if(_f_studentList[0] == null)
                {
                    _f_studentList = CreateList();
                }
                return _f_studentList;
            }
            private set
            {
                _f_studentList = value;
            }
        }

        #endregion

        #region Creator Methods
        public static Student[] CreateList()
        {
            string[] lines = System.IO.File.ReadAllLines(_path);
            
            Student[] data = new Student[lines.Length];

            for (int i = 0; i < lines.Length; i++)
            {
                data[i] = _ParseLine(lines[i]);
            }

            return data;
        }
        private static Student _ParseLine(string s)
        {
            string[] data = s.Split(";");
            return new Student(
                name:       _NullSpaceDetector(data[0]),
                lastName:   _NullSpaceDetector(data[1]),
                email:      data[2],
                id:         Convert.ToUInt32(data[3]),
                studentID:  Convert.ToUInt32(data[4])
            );
        } 
        private static string[] _NullSpaceDetector(string s)
        {
            string[] temp = s.Split(" ");
            string[] data  = new string[2];

            if(temp.Length == 1)
            {
                data[0] = temp[0];
                data[1] = "";
            }else
            {
                data[0] = temp[0];
                data[1] = temp[1];
            }
            return data;
        }
        public static void Start()
        {
            if(_f_studentList[0] == null)
                {
                    _f_studentList = CreateList();
                }
        }
        #endregion

        #region Update Methods
        public static void AddAsignementList(Asignement[] al)
        {
            foreach(Student s in p_studentList)
            {
                s.p_listOfAsignements = al;
            }
        }
        #endregion

        #region Print Methods
        public static new string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Student a in p_studentList)
            {
                sb.AppendLine(a.ToString());
            }
            return sb.ToString();
        }
        #endregion
    }
}