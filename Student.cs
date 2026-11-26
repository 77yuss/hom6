public class Student : Person
{
    public string GroupName { get; set; }

    public override void Notify(string message)
    {
        Console.WriteLine($"Письмо студенту {Email} — {message}");
    }

    public override string ShortInfo()
    {
        return $"Студент {FullName}, группа {GroupName}";
    }
}
