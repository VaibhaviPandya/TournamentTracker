using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary
{
    public class PrizeModel
    {
        //unique identifier for price
        public int Id { get; set; }
        //numberic identifier for the place (2nd for second place etc..)
        public int PlaceNumber { get; set; }

        //friendly name for the place
        public string PlaceName { get; set; }

        //fixed amount this place earn or zero if it is not use
        public decimal PriceAmount { get; set; }
        public double PricePercenage { get; set; }

        public PrizeModel(string placeName,string placeNumber,string prizeAmount,string prizePercentage)
        {
            PlaceName= placeName;
            
            int placeNumberValue = 0;
            int.TryParse(placeName,out placeNumberValue);
            PlaceNumber = placeNumberValue;

            decimal prizeAmountValue = 0;
            decimal.TryParse(prizeAmount,out prizeAmountValue);
            PriceAmount = prizeAmountValue;

            double prizePercentageValue = 0;
            double.TryParse(prizePercentage,out prizePercentageValue);  
            PricePercenage = prizePercentageValue;
        }
    }
}
