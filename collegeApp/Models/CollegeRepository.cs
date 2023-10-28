namespace collegeApp.Models
{
    public static class CollegeRepository
    {
        public static List<Student> Students { get; set; } = new List<Student>()
          {
              new Student
              {
                  Id =1,
                  StudentName = "Heba",
                  Email="hiba.marof97o@gmail.com",
                  Address="Damas,Syria"
              },
              new Student
              {
                  Id =2,
                  StudentName = "Hala",
                  Email="hala.marof97o@gmail.com",
                  Address="Damas,Syria"
              },
          };
    }
}
