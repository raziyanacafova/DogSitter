using DogSitter.DatabaseProvider;
using DogSitter.Models;
using DogSitter.Models.RequestModels;
using DogSitter.Models.ResponseModels;
using Microsoft.AspNetCore.Mvc;
using System.Globalization;

namespace DogSitter.Controllers
{
    [ApiController]
    [Route("DogSit")]
    public class SwaggerController : ControllerBase
    {
        [HttpPost]
        [Route("Add a Sitter")]
        public IActionResult AddSitter(RequestSitter sitter)
        {
            //Sitter newsitter=new Sitter();
            Services.CreateSitter(sitter);
            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPost]
        [Route("Create an Account")]
        public IActionResult AddClient(RequestClient client)
        {
            //Client newclient=new Client();
            Services.CreateClient(client);

            return StatusCode(StatusCodes.Status201Created);
        }
        [HttpPost]
        [Route("Hire a Sitter")]
        public IActionResult HireSitter(RequestHiring hiring) //(RequestClient client,int numofdogs,RequestSitter sitter)
        {
            //Call to GetClientId(hiring.Client)->clientid
            //Call to GetSitterId(hiring.Sitter)->sitterid
            //ResponseHiring responsehiring = new ResponseHiring() { ClientId=clientid, SitterId=sitterid, NumberOfDogs=hiring.NumberOfDogs};
            //Call to CreateHiring(ResponseHiring responsehiring)->hireid   (of last added hire in hirings able)
            //responsehiring.Id=hireid
            //Call to CreateHiringDetails(Response hiring) with argument responsehiring the same above
            return StatusCode(StatusCodes.Status200OK);
        }
        [HttpPost]
        [Route("Leave a Feedback")]
        public IActionResult AddFeedback(RequestFeedback requestfeedback)
        {
            //Call GetSitterId(requestfeedback.Sitter)->sitterid
            //Call GetClientId(requestfeedback.Client)->clientid
            //Logic to transform requestfeedback to a responsefeedback:
            //ResponseFeedback responsefeedback = new ResponseFeedback() { ClientId = clientid,SitterId=sitterid,Feedback="requestfeedback.Feedback" };
           
            //CreateFeedback(ResponseFeedback responsefeedback)
            
            return StatusCode(StatusCodes.Status201Created);
        }



    }
}