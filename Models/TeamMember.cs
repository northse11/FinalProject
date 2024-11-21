namespace FinalProject.Models
{
    public class TeamMember
    {
        public int? ID { get; set; }
        public string FirstName {  get; set; }
        public string LastName { get; set; }
        public DateTime Birthdate { get; set; }
        public string Program {  get; set; }
        public string Year { get; set; }

        public TeamMember() { }

        public TeamMember(int? id, string firstname, string lastname, DateTime birthdate, string program, string year)
        {
            ID = id;
            FirstName = firstname;
            LastName = lastname;
            Birthdate = birthdate;
            Program = program;
            Year = year;
        }

    }
}
