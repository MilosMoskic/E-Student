namespace E_Student.Models
{
    public class Subject
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public Subject(int id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}
