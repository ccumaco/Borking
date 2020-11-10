using System;
using SoluciónProfe.Drivers.DriverClasses;
using SoluciónProfe.Models.People;
using SoluciónProfe.Models.Asignements;

namespace SoluciónProfe
{
    class Program
    {
        static string s;

        static void Main(string[] args)
        {
            Students_Creator.AddAsignementList(
                Asignemets_Creator.p_listOfAsignements);
            s = Students_Creator.ToString();
            System.Console.WriteLine(s);

            teacher_Creator.CreateList();
            Teacher[] t = teacher_Creator._t_teacherList;
        }
        
    }
}
