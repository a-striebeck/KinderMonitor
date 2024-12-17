namespace KinderMonitor.Models
{
    public class Admin :  User
    {
        public Admin(string id, string name, string password, string email) 
        { 
            ID = id;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
