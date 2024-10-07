using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.IService;

namespace WebApplication1.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConfirmOrderController : ControllerBase
    {
        private IConfirmOrderService _confirmOrderService;

        public ConfirmOrderController(IConfirmOrderService confirmOrderService)
        {
            _confirmOrderService = confirmOrderService;
        }
    }
}
