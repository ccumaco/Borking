using SoluciónProfe;
using SoluciónProfe.Models.People;

namespace SoluciónProfe.Models.Asignements
{
    public class GroupClass
    {
        public Asignement asignement;
        public int group;
        public Teacher teacher;
        public Schedule[] schedule = new Schedule[3];
    }
}