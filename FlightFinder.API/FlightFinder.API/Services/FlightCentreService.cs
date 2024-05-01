namespace FlightFinder.API.Services
{
    public class FlightCentreService : IFlightCentreService
    {
        public int CountFlights(string inputString)
        {

            int count = 0;
            while (inputString.Contains("f") && inputString.Contains("l") && inputString.Contains("i") &&
                   inputString.Contains("g") && inputString.Contains("h") && inputString.Contains("t"))
            {
                count++;
                inputString = inputString.Remove(inputString.IndexOf("f"), 1);
                inputString = inputString.Remove(inputString.IndexOf("l"), 1);
                inputString = inputString.Remove(inputString.IndexOf("i"), 1);
                inputString = inputString.Remove(inputString.IndexOf("g"), 1);
                inputString = inputString.Remove(inputString.IndexOf("h"), 1);
                inputString = inputString.Remove(inputString.IndexOf("t"), 1);
            }

            return count;
        }
    }
}
