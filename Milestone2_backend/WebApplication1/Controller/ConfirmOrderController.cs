using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.DTO.Request;
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

        [HttpPost ("ConfirmOrder")]
        public IActionResult AddConfirmOrder(ConfirmOrderRequest confirmOrderRequest)
        {
            try
            {
                var data = _confirmOrderService.AddConfirmOrder(confirmOrderRequest);
                return Ok(data);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
          
        }
    }
}
