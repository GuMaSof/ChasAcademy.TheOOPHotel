namespace TheOOPHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hotelBooking = new HotelBooking("s",DateTime.Now, 3);

            hotelBooking.DisplayBookingInfo();

            hotelBooking.GuestName = Console.ReadLine();
        }

        static string GetNameInput()
        {

            return "";
        }
    }
}
