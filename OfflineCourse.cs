public class OfflineCourse : Course
{
    public override decimal CalculatePrice()
    {
        return BasePrice * 1.15m;
    }
}
