public class OnlineCourse : Course
{
    public override decimal CalculatePrice()
    {
        return BasePrice * 0.90m;
    }
}
