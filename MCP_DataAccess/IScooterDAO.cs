using MCP_Domain.Models;

namespace MCP_DataAccess
{
    public interface IScooterDAO
    {
        List<Trip> AllTripsOneUser(int userId);
        List<Scooter> ScootersWithBatter();
        List<Trip> TripsNotDoneYet();
        List<Trip> EveryFinishedTrips();
        void RebuildDatabase();
        int CreateUser(App_User user);
        int CreateScooter(Scooter scooter);
        int CreateTrip(Trip trip);


    }
}