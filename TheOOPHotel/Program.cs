namespace TheOOPHotel
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var guestName = GetNameInput();
            var startDate = GetStartDateInput();
            var lengthOfStay = GetLengthOfStayInput();

            var hotelBooking = new HotelBooking(guestName,startDate, lengthOfStay);

            hotelBooking.DisplayBookingInfo();

            hotelBooking.GuestName = Console.ReadLine();
        }

        static string GetNameInput()
        {
            while (true)
            {
                Console.Write("Skriv in ditt namn: ");
                var input = Console.ReadLine();

                if (!string.IsNullOrWhiteSpace(input))
                {
                    return input;
                }

                Console.WriteLine("Ogiltig inmatning!");
            }
        }

        static DateTime GetStartDateInput()
        {
            while (true)
            {
                Console.Write("Skriv in ditt startdatum (yyyy-MM-dd): ");
                var input = Console.ReadLine();

                if (DateTime.TryParse(input, out DateTime result))
                {
                    return result;
                }

                Console.WriteLine("Ogiltig inmatning!");
            }
        }

        static int GetLengthOfStayInput()
        {
            while (true)
            {
                Console.Write("Skriv in hur många dagar du stannar: ");
                var input = Console.ReadLine();

                if (int.TryParse(input, out int result))
                {
                    return result;
                }

                Console.WriteLine("Ogiltig inmatning!");
            }
        }
    }
}
