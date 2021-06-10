namespace CoreWebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;

    [Route("[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        [HttpPost]
        public Message Post(Message message)
        {
            return message;
        }
    }
    public class Message
    {
        public string Application { get; set; }

        public string StatusOverride { get; set; }
    }
}
