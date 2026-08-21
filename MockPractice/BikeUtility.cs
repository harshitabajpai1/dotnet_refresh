using System.Collections.Generic;
class BikeUtility
{
    public void AddBikeDetails(string model, string brand, int pricePerDay)
    {
        int key = Program.bikeDetails.Count+1;
        //dictionary it defined in program class
        Bike bike = new Bike
        {
            Model = model,
            Brand = brand,
            PricePerDay = pricePerDay
        };
        Program.bikeDetails.Add(key,bike);
    }
    public SortedDictionary<string,List<Bike>> GroupByBrand()
    {
        // SortedDictionary<string,List<Bike>> BikeGroupedbyBrand =
        // new SortedDictionary<String,List<Bike>>();

        // foreach (var item in Program.bikeDetails.Values)
        // {
        //     if (!BikeGroupedbyBrand.ContainsKey(item.Brand))
        //     {
        //         BikeGroupedbyBrand[item.Brand] = new List<Bike>();
        //     }

        //     BikeGroupedbyBrand[item.Brand].Add(item);
        // }
        // return BikeGroupedbyBrand;


        return new SortedDictionary<string, List<Bike>>(
            Program.bikeDetails.Values.GroupBy( b => b.Brand).ToDictionary(g => g.Key , g => g.ToList())
        );
    }
}