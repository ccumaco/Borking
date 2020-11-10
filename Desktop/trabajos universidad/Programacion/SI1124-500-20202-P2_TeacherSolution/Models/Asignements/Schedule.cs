namespace SoluciónProfe.Models.Asignements
{
    public class Schedule
    {
        public enum Day : byte
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
        public Day dayOfClass;
        public byte firstHour;
        public byte lastHour;
    }
}