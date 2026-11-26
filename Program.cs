using System.Text;

Console.OutputEncoding = Encoding.UTF8;

Console.WriteLine("1. Люди и роли");

Person student = new Student()
{
    Id = 1,
    FullName = "Алина Каримова",
    Email = "student@example.com",
    Phone = "+998 90 000 00 01",
    GroupName = "CS-1"
};

Person teacher = new Teacher()
{
    Id = 2,
    FullName = "Тимур Алиев",
    Email = "teacher@example.com",
    Phone = "+998 90 000 00 02",
    Expertise = "C#"
};

List<Person> people = [student, teacher];

foreach (Person person in people)
{
    person.Validate();
    person.Notify("Занятие начнётся в 10:00.");
    Console.WriteLine(person.ShortInfo());
}

Console.WriteLine("Курсы");

Course online = new OnlineCourse() { Title = "C# онлайн", BasePrice = 1000m, Hours = 24 };
Course offline = new OfflineCourse() { Title = "C# в классе", BasePrice = 1000m, Hours = 24 };
List<Course> courses = [online, offline];

foreach (Course course in courses)
{
    course.Validate();
    Console.WriteLine($"{course.Title} — {course.CalculatePrice():0.00}");
}
