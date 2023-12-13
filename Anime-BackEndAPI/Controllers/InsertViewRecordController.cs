using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Anime_BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InsertViewRecordController : ControllerBase
    {
        private readonly IInsertViewingRecordDetailsService _insertViewRecordService;
        public InsertViewRecordController(IInsertViewingRecordDetailsService insertViewRecordService)
        {
            _insertViewRecordService = insertViewRecordService;
        }
        [HttpPost]
        public async Task<IActionResult> InsertViewRecordControllerAsync(ViewRecordDTO viewRecord)
        {
            
            var result = await _insertViewRecordService.InsertViewRecordServiceAsync(viewRecord);
            if(result == true)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
