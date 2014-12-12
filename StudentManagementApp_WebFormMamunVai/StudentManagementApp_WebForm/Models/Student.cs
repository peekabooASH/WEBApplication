namespace StudentManagementApp_WebForm.Models
{
    public class Student
    {

        public int ID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string RegNo { get; set; }
        public Student()
        {

        }
        public Student(string name, string email, string regNo):this()
        {
            Name = name;
            Email = email;
            RegNo = regNo;

        }

      

       
    }
}