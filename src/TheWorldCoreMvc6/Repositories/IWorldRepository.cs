﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheWorldCoreMvc6.Models;

namespace TheWorldCoreMvc6.Repositories
{
    public interface IWorldRepository
    {
        IEnumerable<Trip> GetAllTrips();
        Trip GetTripByName(string tripName, string username);

        void AddTrip(Trip trip);
        void AddStop(string tripName, string username, Stop newStop);

        Task<bool> SaveChangesAsync();
        object GetTripsByUsername(string name);
    }
}
