namespace DemoContentNegotiation.Models
{
    public class ProfileB
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    public class Profile : ProfileB
    {
        public Guid StudentID { get; set; }
    }
}
