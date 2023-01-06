using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrackerLibrary.Models
{
    public class PrizeModel
    {
        public int Id { get; set; }
        public int PrizePlace { get; set; }
        public String PrizeName { get; set; }
        public int PrizeMoney { get; set; }
        public String PrizeMaterial { get; set; }
        public string DisplayName
        {
            get
            {
                if (PrizeMoney != 0 && PrizeMaterial.Length != 0)
                {
                    return $"{PrizeName}: {PrizeMoney}€ + {PrizeMaterial}";
                }
                else if (PrizeMaterial.Length == 0)
                {
                    return $"{PrizeName}: {PrizeMoney}€";
                }
                else
                {
                    return $"{PrizeName}: {PrizeMaterial}";
                }
            }
        }

        public PrizeModel()
        {

        }

        public PrizeModel(string prizePlace, string prizeName, string prizeMoney, string prizeMaterial)
        {
            int prizePlaceValue = 0;
            int.TryParse(prizePlace, out prizePlaceValue);
            PrizePlace = prizePlaceValue;

            PrizeName = prizeName;

            int prizeMoneyValue = 0;
            int.TryParse(prizeMoney, out prizeMoneyValue);
            PrizeMoney = prizeMoneyValue;

            PrizeMaterial = prizeMaterial;
        }
    }

}
