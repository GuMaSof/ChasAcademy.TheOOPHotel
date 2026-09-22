namespace TheOOPHotel;

internal class HotelBooking
{
    internal List<Person> Guests {  get; set; } // sätter in guest name
    internal DateTime StartDate { get; set; } // hämtar in start datumet 
    internal DateTime EndDate { get; set; } // och slut datumet

    internal double PricePerNight { get; set; } 





    public HotelBooking(List<Person> guests, DateTime startDate, int lengthOfStayInDays) // Hämtar in från internal string guestname , den både hämtar och sätter värdet
    {
        Guests = guests; // hämtar och sätter ett värde
        StartDate = startDate;// hämtar och sätter ett värde
        EndDate = startDate.AddDays(lengthOfStayInDays); // hämtar och sätter ett värde
        PricePerNight = 200;
    }

    internal void DisplayBookingInfo()
    {
        Console.WriteLine($"Start Date: {StartDate.ToShortDateString()}"); // Hämtar ut start datumet 
        Console.WriteLine($"End Date: {EndDate.ToShortDateString()}"); // Hämtar ut slut datumet 
        foreach (var guest in Guests)
        {
            Console.WriteLine($"Guest Email: {guest.GuestEmail}");
            Console.WriteLine($"Guest Phonenumber: {guest.PhoneNumber}");
            Console.WriteLine($"Name: {guest.Name}"); // Slutligen hämtar ut informartion från guestname
        }
       

        


    }

    internal void UpdateBoking()
    {
        Console.Write("Hur många extra dagar vill du stanna? ");
        int NewupDateBooking = int.Parse(Console.ReadLine());
        
        EndDate = StartDate.AddDays(NewupDateBooking); // hämtar och sätter ett värde


        Console.WriteLine($"UpdateBooking End Date: {EndDate.ToShortDateString()}");
    }

    internal void TotalPrice() 
    
    {
        var span = EndDate.Subtract(StartDate);
        int days = span.Days;
        var totalPrice = days * PricePerNight;
        Console.WriteLine(totalPrice);

    
    }
    



}
