// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
class Program
{
    public static SortedDictionary<int,Bike> bikeDetails = new SortedDictionary<int,Bike>();
    public static void Main(String[] args)
    {
        BikeUtility utilityObj = new BikeUtility();
        //menu based application
        int choice;
        do
        {
            Console.WriteLine("1.Add Bike Details");
            Console.WriteLine("2.Group by brands");
            Console.WriteLine("3.Exit");
            Console.WriteLine("Enter your choice");
            choice = Int32.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.WriteLine("Enter the model");
                        string model = Console.ReadLine();
                        Console.WriteLine("Enter the brand");
                        string brand = Console.ReadLine();
                        Console.WriteLine("Enter the price per day");
                        int price = Int32.Parse(Console.ReadLine());

                        utilityObj.AddBikeDetails(model,brand,price);
                        Console.WriteLine("the details are added");
                        break;
                    }

                case 2:
                    {
                        var groupedBikes = utilityObj.GroupByBrand();

                    foreach (var item in groupedBikes)
                    {
                        Console.WriteLine(item.Key);
                        foreach (Bike bike in item.Value)
                        {
                            Console.WriteLine(bike.Model);
                        }
                        Console.WriteLine();
                    }
                        break;
                    } 

                case 3:
                    {
                        break;
                    }       
            }
        }while(choice != 3);
    }
}
