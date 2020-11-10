namespace SoluciónProfe.Models.People
{
    public class Person
    {
        protected string[] _FirstName = new string[2];  //Field
        protected string[] _LastName = new string[2];   // Field
        protected uint _Id;                             // Field

        public static string[] SplitString(string s)
        {
            string[] value = s.Split(" ");

            return value;
        }
    }
}