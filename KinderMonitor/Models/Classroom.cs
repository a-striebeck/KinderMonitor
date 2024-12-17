namespace KinderMonitor.Models
{
    public class Classroom
    {
        public string ID { get; set; }
        public string Name { get; set; }

        public Classroom (string id, string name)
        {
            ID = id;
            Name = name;
        }
    }


}
