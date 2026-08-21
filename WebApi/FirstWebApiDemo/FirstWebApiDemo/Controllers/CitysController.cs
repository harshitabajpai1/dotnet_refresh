using FirstWebApiDemo.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Cryptography.X509Certificates;

namespace FirstWebApiDemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CitysController : ControllerBase
    {
        public static List<string> cityList = null;
        public CitysController()
        {
            if(cityList == null){
                cityList = new List<string>()
                {
                    "Delhi",
                    "Pune",
                    "Mumbai",
                    "Bangalore",
                    "Hydrabad"
                };
            }
            
        }
        [Route("JoiningCitys")] //to specify the route for the method
        //[Route("/CGLocations")]
        [HttpGet] //decorator to specify the type of request
        public List<string> ShowAllCities() { 
            return cityList;

        }
        [Route("GetCityList/{stateName}")]
        [HttpGet]
        public List<string> GetCityList(string stateName)
        {
            return cityList;
        }

        [Route("FetchAllCities/{stateID}")]
        [HttpGet]
        public List<string> FetchAllCities(int stateID)
        {
            return cityList;
        }

        [HttpPost]
        public int AddMe(int num1,int num2)
        {
            return num1 + num2;
        }
        [Route("DoSomeTask1")]
        [HttpPost]

        //Default behavoir for the premitive data type is query type , we can change it
        public ActionResult DoSomeTask1(int empId,[FromBody] string Name)
        {
            return Created();

        }
        [Route("DoSomeTask2")]
        [HttpPost]

        //Default behaviour for the composite  type is body type , we can change it
        public void DoSomeTask2([FromQuery]Student sObj)
        {

        }





    }
}
