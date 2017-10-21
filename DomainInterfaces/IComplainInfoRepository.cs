using TodoApi.Domain;
using System.Collections.Generic;

namespace TodoApi.DomainInterfaces
{
    public interface IComplainInfoRepository
    {
        IEnumerable<ComplainModal> GetAllComplain();
    }
}