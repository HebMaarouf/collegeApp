using collegeApp.MyLogging;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace collegeApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        /* //1-strongly/tightly coupled depdency injection
         private readonly IMyLogger _myLogger;
         public DemoController()
         {
             //_myLogger = new LogToFile();
             //_myLogger = new LogToDB();
             _myLogger = new LogToServerMemory();
         }
         [HttpGet]
         public ActionResult Index()
         {
             _myLogger.Log("Index method started");
             return Ok();
         }*/


        //2-Loosely coupled technic indepdency injection
         private readonly IMyLogger _myLogger;
         public DemoController(IMyLogger myLogger)
         {
             _myLogger = myLogger;
         }
         [HttpGet]
         public ActionResult Index()
         {
             _myLogger.Log("Index method started");
             return Ok();
         }
    }
}
