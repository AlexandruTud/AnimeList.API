using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;

namespace Anime_BackEndAPI.Services
{
    public class InsertViewingRecordDetailsService : IInsertViewingRecordDetailsService
    {
         private readonly IInsertViewingRecordDetailsRepository _insertViewRecordRepository;
        public InsertViewingRecordDetailsService(IInsertViewingRecordDetailsRepository insertViewRecordRepository)
        {
            _insertViewRecordRepository = insertViewRecordRepository;
        }
        public async Task<bool> InsertViewRecordServiceAsync(ViewRecordDTO viewRecord)
        {
            viewRecord.StartDate.CreateDate();
            viewRecord.EndDate.CreateDate();
            return await _insertViewRecordRepository.InsertViewRecordRepositoryAsync(viewRecord);
        }
    }
}
