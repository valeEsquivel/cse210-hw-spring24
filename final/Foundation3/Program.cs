using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        Address address1 = new Address("New York", "NY", "USA", "Central Park");
        OutdoorGatherings outdoorGatherings = new OutdoorGatherings("LDS Charity Annual Event", "12-06-2024", address1, "Fundraising to send supplies to Central Africa", "10:00", "Sunny");
        Console.WriteLine("\n");
        outdoorGatherings.OutdoorDescription();
        outdoorGatherings.DisplayFullDetails();

        Address address2 = new Address("Santa Tecla", "La Libertad", "El Salvador", "Lions Club");
        Receptions receptions = new Receptions("New Year's Eve Party", "31-12-2024", address2, "New Year's Eve Party for all the personal of CASSA Team", "20:00", "vale_hlj@hotmail.com");
        Console.WriteLine("\n");
        receptions.ReceptionDescription();
        receptions.DisplayFullDetails();

        Address address3 = new Address("Sonsonate", "Sonsonate", "El Salvador", "Cultural Palace");
        Lectures lectures = new Lectures("Traces of the Past", "26-08-2024", address3, "Commemoration of those who fell in the Civil War of El Salvador 1980s", "12:00", "Miguel Orellana", "100");
        Console.WriteLine("\n");
        lectures.LectureDescription();
        lectures.DisplayFullDetails();
    }
}