using System;
using SoluciónProfe.Models.Asignements;

namespace SoluciónProfe.Models.People
{
    public class Student : Person
    {
        protected uint _studentID;
        protected string _email;

        private Asignement[] _listOfAsignements;
        public Asignement[] p_listOfAsignements
        {
            set
            {
                _listOfAsignements = value;
            }
        }

        private GroupClass[] _currentAsignements;

        public Student(string[] name, string [] lastName, uint id, 
            uint studentID, string email)
        {
            _FirstName = name;
            _LastName = lastName;
            _Id = id;
            _studentID = studentID;
            _email = email;
        }
        public Student(string[] name, string [] lastName, uint id, 
            uint studentID, string email, Asignement[] list) : 
            this(name,lastName,id,studentID,email)
        {
            _listOfAsignements = list;
        }
        public override string  ToString()
        {
            string s = string.Format(
                "Nombre Estudiante: {0} {1}, Correo: {1}, Identificación: {2}: ",
                    this._FirstName[0],this._FirstName[1], this._email, this._studentID
                                    );
            return s;
        }
    }
}