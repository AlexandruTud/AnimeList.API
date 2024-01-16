using Anime_BackEndAPI.DTOs;
using Anime_BackEndAPI.Interfaces;
using System.Text.RegularExpressions;

namespace Anime_BackEndAPI.Services
{
    public class InsertViewingRecordDetailsService : IInsertViewingRecordDetailsService
    {
         private readonly IInsertViewingRecordDetailsRepository _insertViewRecordRepository;
        public InsertViewingRecordDetailsService(IInsertViewingRecordDetailsRepository insertViewRecordRepository)
        {
            _insertViewRecordRepository = insertViewRecordRepository;
        }
        public async Task<int> InsertViewRecordServiceAsync(ViewRecordDTO viewRecord)
        {

            if(IsDateFormatValid(viewRecord.StartDate) && IsDateFormatValid(viewRecord.EndDate))
            {
                return await _insertViewRecordRepository.InsertViewRecordRepositoryAsync(viewRecord);
            }
            throw new Exception("Date format is not valid");
        }
        static bool IsDateFormatValid(string inputStringDate)
        {
            string pattern = @"^\d{4}-\d{2}-\d{2}$";
            return Regex.IsMatch(inputStringDate, pattern);
        }
    }
}
