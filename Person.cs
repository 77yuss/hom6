using System.Net.Mail;

public abstract class Person : EntityBase
{
    public string FullName { get; set; } = "";
    public string Email { get; set; } = "";
    public string Phone { get; set; } = "";

    public abstract void Notify(string message);

    public virtual string ShortInfo()
    {
        return FullName;
    }

    public override void Validate()
    {
        if (string.IsNullOrWhiteSpace(FullName))
        {
            throw new InvalidOperationException("Укажите имя.");
        }

        if (!MailAddress.TryCreate(Email, out var address) || address.Address != Email)
        {
            throw new InvalidOperationException("Укажите корректный email.");
        }
    }
}
