﻿using DAL.Interfaces;
using DAL.Models;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Buyer, int> BuyerData()
        {
            return new BuyerRepo();
        }
        public static IRepo<Landlord, int> LandlordData()
        {
            return new LandlordRepo();
        }
        public static IRepo<Management, int> ManagementData()
        {
            return new ManagementRepo();
        }
        public static IRepoPropertyBidding<Bidding, int> BiddingData()
        {
            return new BiddingRepo();
        }
        public static IRepoPropertyBidding<Property, int> PropertyData()
        {
            return new PropertyRepo();
        }
        //public static IRepoPropertyBidding<FavProperty, int> FavPropertyData()
        //{
        //    return new FavPropertyRepo();
        //}


    }
}
