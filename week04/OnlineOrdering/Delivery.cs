class Delivery
{
    private DateOnly _estimatedDate; //save the estimated date.

    //constructor to choose how many days to add from today to the delivery. (It use date  time, but after all it makes the time disappear, and just print the date without hours or minutes)
    public Delivery(int daysToAdd)
    {
        _estimatedDate = DateOnly.FromDateTime(DateTime.Now.AddDays(daysToAdd));
    }
    //getter to use it from conect it to order and then to print it in the program along with the order.
    public DateOnly GetEstimatedDate()
    {
        return _estimatedDate;
    }
}