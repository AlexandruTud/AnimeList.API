using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using Anime_BackEndAPI.Requests;
using Microsoft.AspNetCore.Mvc;

namespace Anime_BackEndAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ViewRecordController : ControllerBase
    {
        private readonly IInsertViewingRecordDetailsService _insertViewRecordService;
        private readonly IDeleteViewRecRepository _deleteViewRecRepository;
        public ViewRecordController(IInsertViewingRecordDetailsService insertViewRecordService, IDeleteViewRecRepository deleteViewRecRepository)
        {
            _insertViewRecordService = insertViewRecordService;
            _deleteViewRecRepository = deleteViewRecRepository;
        }
        [HttpPost]
        [Route("InsertViewRecord")]
        public async Task<IActionResult> InsertViewRecordControllerAsync(ViewRecordDTO viewRecord)
        {
            
            var result = await _insertViewRecordService.InsertViewRecordServiceAsync(viewRecord);
            if(result == true)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpDelete]
        [Route("DeleteViewRecord")]
        public async Task<IActionResult> DeleteViewRecordControllerAsync(ViewRecordRequest viewRecordRequest)
        {
            var result = await _deleteViewRecRepository.DeleteViewRecordAsync(viewRecordRequest);
            if(result == true)
            {
                return Ok();
            }
            return BadRequest();
        }
    }
}
