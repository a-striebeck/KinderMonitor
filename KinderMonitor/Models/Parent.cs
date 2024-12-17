namespace KinderMonitor.Models
{
    public class Parent : User
    {

        public Parent(string id, string name, string password, string email)
        {
            ID = id;
            Name = name;
            Password = password;
            Email = email;
        }
    }
}
