using System;
using SoluciónProfe.Models.People;
namespace SoluciónProfe.Drivers.DriverClasses
{
    public class teacher_Creator{
         private static string _path = 
            @"C:\Users\Borking\Desktop\trabajos universidad\Programacion\SoluciónProfe\Drivers\DriverObjects\teachers.txt";
        
        public static Teacher[] _t_teacherList = new Teacher[12];


        public static void CreateList()
        {
            string[] lines = System.IO.File.ReadAllLines(_path);
            _t_teacherList = new Teacher[lines.Length];
            for (int i = 0; i < lines.Length; i++)
            {
                _t_teacherList[i] = _ParseLine(lines[i]);
            }
        }

        private static Teacher _ParseLine(string s)
        {
            string[] data = s.Split(";");
            return new Teacher(
                firstName:       data[0],
                lastName:   data[1],
                email:      data[2],
                Id:         Convert.ToUInt32(data[3]),
                cellphone:  Convert.ToUInt32(data[4])
            );
        }
    }
}