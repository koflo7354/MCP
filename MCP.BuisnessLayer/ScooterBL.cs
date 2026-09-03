using MCP_DataAccess;
using MCP_Domain.Models;
namespace MCP.BuisnessLayer
{
    public class ScooterBL
    {
        private IScooterDAO scooterDAO;

        public ScooterBL(IScooterDAO dao)
        {
            scooterDAO = dao;
        }
        //public int MostFequentDriver()
        //{

        //}
        public float AverageCostPerKm()
        {
            List<Trip> trips = scooterDAO.EveryFinishedTrips();
            int totalCost = 0;
            int totalKm = 0;
            foreach (Trip trip in trips)
            {
                totalCost += trip.Cost;
                totalKm += trip.Distance;
            }
            float averageCost = totalKm / totalCost;
            return averageCost;
        }

        public int CreateUser(string name) { 
            App_User user = new App_User(name);
            return scooterDAO.CreateUser(user);
        }
        public int CreatesScooter(string brand)
        {
            Scooter scooter = new Scooter(brand);
            return scooterDAO.CreateScooter(scooter);
        }
        public int CreateTrip (App_User user, Scooter scooter)
        {
            Trip trip = new(user.Id, scooter.Id);
            return scooterDAO.CreateTrip(trip);
        }
    }

}
