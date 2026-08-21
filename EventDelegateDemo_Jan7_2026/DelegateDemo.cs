namespace EventDelegateDemo
{
    //Muticlast delegate ----> if the return type is void --->multiple methods
    public delegate void GreetMsg(string msg);

    //UniCast Delegate ---> must have a return type ----> one method
    public delegate int Calculation(int num1,int num2);
    class Hindi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Suprabhat"+userName);
        }
    }
    class Tamil
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Vanakkam"+userName);
        }
    }
    class Telugu
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskaram"+userName);
        }
    }
    class Marathi
    {
        public void WelcomeMsg(string userName)
        {
            Console.WriteLine("Namaskar"+userName);
        }
    }
    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            Tamil tObj = new Tamil(); //----> Intance method
            GreetMsg GreetInTamil = new GreetMsg(tObj.WelcomeMsg);
            GreetInTamil("Alok");  //---> function pointer pointing toward the named function
        }
        
    }
}