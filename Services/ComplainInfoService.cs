using TodoApi.ServiceInterface;
using TodoApi.Domain;
using System.Collections.Generic;
using TodoApi.DomainInterfaces;



namespace TodoApi.Service
{
    public class ComplainInfoService : IComplainInfoService
    {

        private readonly IComplainInfoRepository _complainInfoRepository;

        public ComplainInfoService(IComplainInfoRepository complainInfoRepository)
        {
            _complainInfoRepository = complainInfoRepository;
        }
        public IEnumerable<ComplainModal> GetAllComplain()
        {
            var data = _complainInfoRepository.GetAllComplain();
            return data;
        }
    }
}