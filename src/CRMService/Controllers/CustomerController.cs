using Contracts;
using MassTransit;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route("api/customer")]
public class CustomerController : ControllerBase
{
    private readonly IPublishEndpoint _publishEndpoint;

    public CustomerController(IPublishEndpoint publishEndpoint){
        _publishEndpoint = publishEndpoint;
    }

    [HttpPost(Name ="addCustomer")]
    public async Task<ActionResult> addCustomer(String customerName){
        try{
          Console.WriteLine("We are adding new customer");
          throw new NotImplementedException();
        }
        catch(Exception ex){
            Console.WriteLine("Add new customer - Exception was thrown. Publish it");
            ErrorCreated errorCreated = new ErrorCreated();
            errorCreated.Message = ex.Message;
            errorCreated.StackTrace = ex.StackTrace;
            await _publishEndpoint.Publish(errorCreated);
            return BadRequest();
        }
    }
}