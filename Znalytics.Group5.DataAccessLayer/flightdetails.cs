class FlightDetail
{
    public FlightDetail()
    {



        public void AddFlights()
        {

            System.Console.WriteLine("enter new flight to be added:");
            string userinput = System.Console.ReadLine();
            if (userinput != "null")
            {
                FlightSchedule.Add(userinput);
                foreach (object obj in Flights)
                    System.Console.WriteLine(obj.ToString() + "");
            }
            else
            {
                System.Console.WriteLine("Not Allowed");
            }
        }
        public void UpdateDetails()
        {

            System.Console.WriteLine("enter flight to be updated:");
            string userInput = System.Console.ReadLine();
            if (userInput != "0")
            {
                Flight.Update(userInput);
                foreach (object obj in Flight)
                    System.Console.WriteLine(obj.ToString() + "");

            }
        }
        public void Delete()
        {
            System.Console.Write("enter flightname to delete:");
            string userInput = System.Console.ReadLine();
            Flight.Remove(userInput);
            foreach (var obj in Flight)
                System.Console.Write(obj.ToString() + "");
        }
        Public void DisplayFlight()
        {
            foreach (object obj in Flight)
                System.Console.Write(obj.ToString() + "");
        }
    }
}
