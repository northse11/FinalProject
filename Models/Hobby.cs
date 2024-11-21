namespace FinalProject.Models
{
    public class Hobby
    {
        public int? HobbyID { get; set; }
        public string HobbyName { get; set; }
        public string HobbyDescription { get; set; }
        public DateTime HobbyAge { get; set; }
        public bool HobbyActive {  get; set; }
        public string HobbyDifficulty { get; set; }

        public Hobby() { }
        public Hobby(int? hobbyID, string hobbyName, string hobbyDescription, DateTime hobbyAge, bool hobbyActive, string hobbyDifficulty)
        {
            HobbyID = hobbyID;
            HobbyName = hobbyName;
            HobbyDescription = hobbyDescription;
            HobbyAge = hobbyAge;
            HobbyActive = hobbyActive;
            HobbyDifficulty = hobbyDifficulty;
        }
    }
}
