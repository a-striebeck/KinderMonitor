namespace KinderMonitor.Models
{
    public class Staff : User
    {
        public Staff(string id, string name, string password´, string email) { 
            ID = id;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
