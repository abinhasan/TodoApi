using System.Collections.Generic;
using TodoApi.Domain;

namespace TodoApi.ServiceInterface
{
    public interface IComplainInfoService
    {
        IEnumerable<ComplainModal> GetAllComplain();
    }
    
}