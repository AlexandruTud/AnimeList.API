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
        private readonly IUpdateViewRecordRepository _updateViewRecordRepository;
        private readonly IGetViewingRecordByAnimeNameRepository _getViewRecordByAnimeNameRepository;
        public ViewRecordController(IInsertViewingRecordDetailsService insertViewRecordService, IDeleteViewRecRepository deleteViewRecRepository, IUpdateViewRecordRepository updateViewRecordRepository, IGetViewingRecordByAnimeNameRepository getViewingRecordByAnimeNameRepository)
        {
            _insertViewRecordService = insertViewRecordService;
            _deleteViewRecRepository = deleteViewRecRepository;
            _updateViewRecordRepository = updateViewRecordRepository;
            _getViewRecordByAnimeNameRepository = getViewingRecordByAnimeNameRepository;
        }
        [HttpPost]
        [Route("InsertViewRecord")]
        public async Task<IActionResult> InsertViewRecordControllerAsync(ViewRecordDTO viewRecord)
        {
            
            var result = await _insertViewRecordService.InsertViewRecordServiceAsync(viewRecord);
            if(result != 0)
            {
                return Ok(result);
            }
            return BadRequest();
        }
        [HttpDelete]
        [Route("DeleteViewRecord")]
        public async Task<IActionResult> DeleteViewRecordControllerAsync( int userID ,string animeName)
        {
            var result = await _deleteViewRecRepository.DeleteViewRecordAsync(userID,animeName);
            if(result == true)
            {
                return Ok();
            }
            return BadRequest();
        }
        [HttpPatch]
        [Route("UpdateViewRecord")]
        public async Task<IActionResult> UpdateViewRecordControllerAsync(UpdatedRecordDTO updatedRecordDTO)
        {
            var result = await _updateViewRecordRepository.UpdateViewRecordAsync(updatedRecordDTO);
            if(result == true)
            {
                return Ok("Update Successful");
            }
            return BadRequest();
        }
        [HttpGet]
        [Route("GetViewRecordByAnimeName/{animeName}")]
        public async Task<IActionResult> GetViewRecordByAnimeNameControllerAsync(string animeName)
        {
            var result = await _getViewRecordByAnimeNameRepository.GetViewingRecordByAnimeNameRepositoryAsync(animeName);
            if(result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }
    }
}
