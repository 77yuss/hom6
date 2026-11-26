public class Teacher : Person
{
    public string Expertise { get; set; }

    public override void Notify(string message)
    {
        Console.WriteLine($"Уведомление преподавателю {FullName} — {message}");
    }

    public override string ShortInfo()
    {
        return $"Преподаватель {FullName}, профиль {Expertise}";
    }
}
