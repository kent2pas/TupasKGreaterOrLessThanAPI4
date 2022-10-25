//Kent Tupas
//10/25/2022
// Greater Or Less Than
//Peer Review: Freddy Aguilar - The program takes their mini challenge 4 and converts it to API format. It takes in two numbers from the user and successfully outputs whether number 1 is greater than, less than, or equal to number 2.

using Microsoft.AspNetCore.Mvc;

namespace TupasKGreaterOrLessThanAPI.Controllers;

[ApiController]
[Route("[controller]")]
public class GreaterorLessThanController : ControllerBase
{
[HttpGet]
[Route("Than/{numberone}/{numbertwo}")]

public string Than(string numberone, string numbertwo)
{
int num1 = Convert.ToInt32(numberone);
int num2 = Convert.ToInt32(numbertwo);

if(num1 > num2)
{
return num1 + " greater than " + num2;
}else if
(num1 < num2)
{
return num1 +" less than "+ num2;
}else if
(num1 == num2)
{
return num1 + " is equal to "+ num2;
}else 
return "";
}

}


