namespace TheOOPHotel;

internal class HotelBooking
{
    internal string GuestName {  get; set; } // sätter in guest name
    internal DateTime StartDate { get; set; } // hämtar in start datumet 
    internal DateTime EndDate { get; set; } // och slut datumet





    public HotelBooking(string guestName, DateTime startDate, int lengthOfStayInDays) // Hämtar in från internal string guestname , den både hämtar och sätter värdet
    {
        GuestName = guestName; // hämtar och sätter ett värde
        StartDate = startDate;// hämtar och sätter ett värde
        EndDate = startDate.AddDays(lengthOfStayInDays); // hämtar och sätter ett värde
    }

    internal void DisplayBookingInfo()
    {
        Console.WriteLine($"Name: {GuestName}"); // Slutligen hämtar ut informartion från guestname
        Console.WriteLine($"Start Date: {StartDate.ToShortDateString()}"); // Hämtar ut start datumet 
        Console.WriteLine($"End Date: {EndDate.ToShortDateString()}"); // Hämtar ut slut datumet 
        


    }

    internal void UpdateBoking()
    {
        Console.Write("Hur många extra dagar vill du stanna? ");
        int NewupDateBooking = int.Parse(Console.ReadLine());
        
        EndDate = StartDate.AddDays(NewupDateBooking); // hämtar och sätter ett värde


        Console.WriteLine($"UpdateBooking End Date: {EndDate.ToShortDateString()}");
    }
}
