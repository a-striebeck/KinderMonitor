namespace KinderMonitor.Models
{
    public abstract class Media
    {
        public String ID { get; set; }
        public String Title { get; set; }
        public String PathToFile { get; set; }
        public DateTime UploadDate { get; set; }

        public Media(String id, String title, String pathToFile)
        {
            ID = id;
            Title = title;
            PathToFile = pathToFile;
            UploadDate = DateTime.Now;
        }
    }
}
