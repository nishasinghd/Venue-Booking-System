using System.Xml.Linq;

namespace assignmentOne
{
    
    public class Booking
    {
        public string Name { get; set; }
        public string SeatNumber { get; set; }
        public bool Available { get; set; }
        
        public Booking(string name, string seatNumber)
        {
            Name = name;
            SeatNumber = seatNumber;
        }
        public Booking(string name, string seatNumber, bool available)
        {
            Name = name;            
            SeatNumber = seatNumber;
            Available   = available;
        }
    }
}
