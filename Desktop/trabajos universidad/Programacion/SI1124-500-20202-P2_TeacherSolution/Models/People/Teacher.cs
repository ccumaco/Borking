using System;

namespace SoluciónProfe.Models.People
{
    public class Teacher : Person
    {
        protected string _email;
        protected uint _cellphone;

        #region Constructors
        private Teacher()
        {
            System.Console.WriteLine("Por favor, ingresar los datos del docente por linea");
        }
        public Teacher(string firstName, string lastName, uint Id)
                : this ()
        {
            _FirstName = Person.SplitString(firstName);
            _LastName = Person.SplitString(lastName);
            _Id = Id;
        }
        public Teacher(string firstName, string lastName, uint Id,
                string email, uint cellphone) 
                : this(firstName, lastName, Id)
        {
            _email = email;
            _cellphone = cellphone; 
        }
        #endregion
        
    }
}