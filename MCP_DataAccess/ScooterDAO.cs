using MCP_Domain.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MCP_DataAccess
{
    public class ScooterDAO : IScooterDAO
    {
        public List<Scooter> ScootersWithBatter()
        {
            using ScootDbContext db = new();
            List<Scooter> list = db.Scooter
                .Where(s => s.Battery_Capacity > 0.20)
                .ToList();

            return list;
        }
        public List<Trip> AllTripsOneUser(int userId)
        {
            using ScootDbContext db = new();
            List<Trip> trips = db.Trip
                .Where(s => s.App_UserId == userId)
                .OrderBy(s => s.Start_time)
                .ToList();
            return trips;
        }
        public List<Trip> TripsNotDoneYet()
        {
            using ScootDbContext db = new();
            List<Trip> trips = db.Trip
                .Where(s => s.End_Time == null)
                .ToList();
            return trips;
        }
        public List<Trip> EveryFinishedTrips()
        {
            using ScootDbContext db = new();
            List<Trip> list = db.Trip
                .Where(s => s.End_Time != null)
                .ToList();
            return list;
        }
        public int CreateUser(App_User user)
        {
            using ScootDbContext db = new();
            db.App_user.Add(user);
            db.SaveChanges();
            return user.Id;
        }
        public void RebuildDatabase()
        {
            using ScootDbContext db = new();

            db.Database.EnsureDeleted();
            db.Database.Migrate();

        }
    }
}
