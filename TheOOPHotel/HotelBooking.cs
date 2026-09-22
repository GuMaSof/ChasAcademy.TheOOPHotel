namespace TheOOPHotel;

internal class HotelBooking
{
    internal string GuestName {  get; set; }
    internal DateTime StartDate { get; set; }
    internal DateTime EndDate { get; set; }

    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays)
    {
        GuestName = guestName;
        StartDate = startDate;
        EndDate = startDate.AddDays(lengthOfStayInDays);
    }

    internal void DisplayBookingInfo()
    {
        Console.WriteLine($"Name: {GuestName}");
        Console.WriteLine($"Start Date: {StartDate.ToShortDateString()}");
        Console.WriteLine($"End Date: {EndDate.ToShortDateString()}");
    }
}
