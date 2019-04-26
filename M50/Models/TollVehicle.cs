using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace M50.Models
{
    public class TollVehicle
    {
        // 4 different vehicle types
        public enum VehicleTypes {Car, PSV, Bus, Goods};
            

        // toll charges in euro
        const double CarTollCharge = 2.00;
        const double PSVTollCharge = 2.00;
        const double BusTollCharge = 2.80;
        const double GoodsTollCharge = 4.10;

        // discount for having an electronic tag
        const double DiscountPercentage = 0.20;                // 20%


        [Required]
        [Display(Name = "Vehicle Type")]
        public VehicleTypes VehicleType { get; set; }

        [Required]
        [Display(Name = "Electronic Tag")]
        public bool HasETag { get; set; }
 

        public double CalculateCharge()
        {
            double toll = 0;
            switch (VehicleType)
            {
                case (VehicleTypes.Car):
                    toll = CarTollCharge;
                    break;
                case (VehicleTypes.PSV):
                    toll = PSVTollCharge;
                    break;
                case (VehicleTypes.Bus):
                    toll = BusTollCharge;
                    break;
                case (VehicleTypes.Goods):
                    toll = GoodsTollCharge;
                    break;
            }

            if (HasETag)                // apply discount
            {
                toll *= 1 - DiscountPercentage;
            }
            return toll;
        }
    }


}