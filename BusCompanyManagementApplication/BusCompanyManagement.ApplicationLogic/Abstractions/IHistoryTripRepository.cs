﻿using BusCompanyManagement.ApplicationLogic.DataModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusCompanyManagement.ApplicationLogic.Abstractions
{
    public interface IHistoryTripRepository : IRepository<PersonalTrip>
    {
        PersonalTrip GetHistoryTripByUserId(Guid userId);
    }
}

