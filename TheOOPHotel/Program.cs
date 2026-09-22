namespace TheOOPHotel
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
             List<HotelBooking> hotelList = new List<HotelBooking>();
            HotelMeny(hotelList);
            //var guestName = GetStringInput("skriv ditt namn: ");
            //var guestEmail = GetStringInput("skriv in din epost: ");
            //var guestPhoneNumber = GetStringInput("Skriv in ditt telefon nummer: ");
            //Person hotelGuest = new Person(guestName, guestEmail, guestPhoneNumber);
            //List<Person> people = new List<Person>();
            //people.Add(hotelGuest);
            //var startDate = GetStartDateInput();
            //var lengthOfStay = GetLengthOfStayInput();


            //var hotelBooking = new HotelBooking(people,startDate, lengthOfStay);


            //hotelBooking.DisplayBookingInfo();
            //hotelBooking.UpdateBoking();
            //hotelBooking.DisplayBookingInfo();
            //hotelBooking.TotalPrice();

            
            
            
        }

        private static void HotelMeny(List<HotelBooking> hotelBookingList)
        {

            bool isRuning = true;
            while (isRuning)
            {
                Console.WriteLine("1. Boka Rum");
                Console.WriteLine("2. Avboka Rum");
                Console.WriteLine("3. Ändra Bokning");
                Console.WriteLine("4. Avsluta Programmet");
                

                switch (Console.ReadLine())
                {
                    case "1":
                        var guestName = GetStringInput("skriv ditt namn: ");
                        var guestEmail = GetStringInput("skriv in din epost: ");
                        var guestPhoneNumber = GetStringInput("Skriv in ditt telefon nummer: ");
                        Person hotelGuest = new Person(guestName, guestEmail, guestPhoneNumber);
                        List<Person> people = new List<Person>();
                        people.Add(hotelGuest);
                        var startDate = GetStartDateInput();
                        var lengthOfStay = GetLengthOfStayInput();


                        var hotelBooking = new HotelBooking(people, startDate, lengthOfStay);
                        hotelBookingList.Add(hotelBooking);
                        
                        hotelBooking.DisplayBookingInfo();
                        break;
                    case "2":
                        if (hotelBookingList.Count == 0)
                        {
                            Console.WriteLine("Det finns inga bokningar");
                            break;
                        }
                        foreach (var booking in hotelBookingList)
                        {
                            booking.DisplayBookingInfo();
                        }
                        break;
                    case "3":
                        break;
                    case "4":
                        Console.WriteLine("Tack för din tid");
                        isRuning = false;
                        break;
                }
            }
        }

        static string GetStringInput(string messeage)
        {
            while (true)  // Loopar igenom while true 
            {
                Console.Write(messeage);
                var input = Console.ReadLine(); 

                if (!string.IsNullOrWhiteSpace(input)) // ifall du skriver in fel information
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

                if (DateTime.TryParse(input, out DateTime result) && result >= DateTime.Now) 
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

                if (int.TryParse(input, out int result) && result > 0)
                {
                    return result;
                }

                Console.WriteLine("Ogiltig inmatning!");
            }

        }
    }
}



