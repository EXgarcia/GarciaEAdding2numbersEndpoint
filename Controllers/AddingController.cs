//Elizar Garcia
//10-25-22
//MiniCh#2Adding2Numbers. 
//This a console project that will add 2 numbers together and display them on postman.
//Peer Review:Samuel Laguna
//I ram the code it works as intended to, The inputs work good,
//There where no errors in this code. The convert.ToInt32 works. this code is all good

using Microsoft.AspNetCore.Mvc;

namespace GarciaEAdding2numbersEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class AddingController : ControllerBase
{
    [HttpGet]
    [Route("adding/{number1}/{number2}")]

    public int math(string number1, string number2)
    {
        int convertNum1 = Convert.ToInt32(number1);
        int convertNum2 = Convert.ToInt32(number2);
        return convertNum1 + convertNum2;

    }
   
}
