public abstract class Course : EntityBase
{
    public string Title { get; set; } = "";
    public decimal BasePrice { get; set; }
    public int Hours { get; set; }

    public abstract decimal CalculatePrice();

    public override void Validate()
    {
        if (string.IsNullOrWhiteSpace(Title))
        {
            throw new InvalidOperationException("Укажите название курса.");
        }

        if (Hours <= 0)
        {
            throw new InvalidOperationException("Количество часов должно быть больше нуля.");
        }
    }
}
