using System;

namespace SoluciónProfe.Models.Asignements
{
    public class Asignement
    {
        public string name;
        public string prefix;
        public int number;
        public int semester;

        public Asignement(string name, string prefix, int number, int semester)
        {
            this.name = name;
            this.prefix = prefix;
            this.number = number;
            this.semester = semester;
        }

        public override string  ToString()
        {
            string s = string.Format(
                "Código Asignatura: {0}{1} , Semestre: {2}, Nombre Asignatura: {3}: ",
                    this.prefix, this.number, this.semester, this.name
                                    );
            return s;
        }
    }
}