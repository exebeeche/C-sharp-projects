using PersonClass;

class Program {
    static void Main(string[] args) {
        Person person = new Person { FirstName = "Luke", LastName = "Skywalker" };
        person.PrintName();
        Student student = new Student { FirstName = "Leia", LastName = "Skywalker", SchoolName = "Jedi Academy" };
        student.PrintName();
        student.Learn();
        Teacher teacher = new Teacher { FirstName = "Obi-Wan", LastName = "Kenobi", SchoolName = "Jedi Academy" };
        teacher.PrintName();
        teacher.Teach();
    }
}