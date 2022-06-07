﻿using FishingBookerLibrary.DataAccess;
using FishingBookerLibrary.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBookerLibrary.BusinessLogic
{
    public class LoyaltyProgramCRUD
    {

        public static int UpdateLoyaltyProgram(decimal pointsForClient,
                                               decimal pointsForOwner)
        {

            LoyaltyProgram data = new LoyaltyProgram
            {
                Id = 1,
                PointsAfterSuccResClient = pointsForClient,
                PointsAfterSuccResOwner = pointsForOwner,
            };
            string sql = @" UPDATE dbo.LoyaltyProgram
                            SET PointsAfterSuccResClient = @PointsAfterSuccResClient, PointsAfterSuccResOwner = @PointsAfterSuccResOwner
                            WHERE Id = @Id;";

            return SSMSDataAccess.SaveData(sql, data);
        }

        public static int CreateScale(string scaleName,
                                      float clientsBenefits,
                                      float ownerBenefits,
                                      float minEarnedPoints)
        {
            LoyaltyScale data = new LoyaltyScale
            {
                LoyaltyProgramId = 1,
                ScaleName = scaleName,
                ClientsBenefits = clientsBenefits,
                OwnerBenefits = ownerBenefits,
                MinEarnedPoints = minEarnedPoints
            };

            string sql = @"INSERT INTO dbo.LoyaltyScale (LoyaltyProgramId, ScaleName, ClientsBenefits, OwnerBenefits, MinEarnedPoints)
                           VALUES (@LoyaltyProgramId, @ScaleName, @ClientsBenefits, @OwnerBenefits, @MinEarnedPoints);";

            return SSMSDataAccess.SaveData(sql, data);
        }

        public static LoyaltyProgram LoadLoyaltyProgram(int loyaltyId)
        {
            string sql = @"SELECT *
                           FROM dbo.LoyaltyProgram;";

            return SSMSDataAccess.LoadLoyaltyProgram<LoyaltyProgram>(sql, loyaltyId);
        }

        public static List<LoyaltyScale> LoadLoyaltyScales()
        {
            string sql = @"SELECT *
                           FROM dbo.LoyaltyScale;";

            return SSMSDataAccess.LoadData<LoyaltyScale>(sql);


        }
    }
}