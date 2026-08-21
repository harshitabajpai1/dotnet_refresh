// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace EventDelegateDemo
{
    public delegate bool CreateRecord(Product p);
    public delegate void Caller(string str);
    class Program
    {
        public static void ShowMe(string str)
        {
            Console.WriteLine("Message from ShowMe ");
        }

        public void GenerateMe(string str)
        {
            Console.WriteLine("Message from GenerateMe ");
        }
        static void Main(string[] args)
        {
            // ProductRepo pRepo = new ProductRepo();
            // CreateRecord AddProduct = new CreateRecord(pRepo.Add);
            
            // //addProduct is the funtion pointer to the main funtion Add (we are using delegates here)
            // AddProduct(new Product());


            Program p1 = new Program();

            Caller CallMe = new Caller(Program.ShowMe); //static method  ---------->envoking via class name
            CallMe += new Caller(p1.GenerateMe); //instance method------------>envoking via object name

            CallMe("Hello from Delegate");
        }
    }
}
