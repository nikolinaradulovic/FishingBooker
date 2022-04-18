﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FishingBookerLibrary.Models
{
    public class Enums
    {
        public enum CancellationPolicyType
        {
            ForFree,
            Suspension10,
            Suspension20,
            Suspension30
        }

        public enum ClientCategoryType
        {
            Regular,
            Silver,
            Gold
        }

        public enum RegistrationType
        {
            CottageOwner,
            FishingInstructor,
            ShipOwner,
            Client
        }

        public enum RegistrationTypeInDB
        {
            InvalidClient,
            InvalidOwner,
            ValidClient,
            ValidCottageOwner,
            ValidFishingInstructor,
            ValidShipOwner,
            Admin,
            HeadAdmin
        }

        public enum RoleType
        {
            None,
            Captain,
            Officer
        }

        public enum UserStatus
        {
            Waiting,
            Validated,
            Blocked
        }

        public enum ReservationType
        {
            Fast,
            Regular
        }

        public enum RecordImpressionType
        {
            GoodExperience,
            BadExperience,
            DidNotShowUp
        }
    }
}
