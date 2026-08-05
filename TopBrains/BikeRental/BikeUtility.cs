using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BikeRental
{
    public class BikeUtility
    {
        public void AddBikeDetails(string model, string brand, int pricePerDay)
        {
            Bike bike = new Bike
            {
                Model = model,
                Brand = brand,
                PricePerDay = pricePerDay
            };
            int key = Program.bikeDetails.Count + 1;
            Program.bikeDetails.Add(key, bike);
        }

        public SortedDictionary<string, List<Bike>> GroupBikesByBrand()
        {
            SortedDictionary<string, List<Bike>> result = new SortedDictionary<string, List<Bike>>();

            foreach (KeyValuePair<int, Bike> item in Program.bikeDetails)
            {
                if (!result.ContainsKey(item.Value.Brand))
                {
                    result[item.Value.Brand] = new List<Bike>();
                }

                result[item.Value.Brand].Add(item.Value);
            }

            return result;
        }
    }
}

