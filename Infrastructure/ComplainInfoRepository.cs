using TodoApi.Domain;
using System.Collections.Generic;
using TodoApi.DomainInterfaces;

namespace TodoApi.Infrastructure
{
    public class ComplainInfoRepository : IComplainInfoRepository
    {
        public IEnumerable<ComplainModal> GetAllComplain()
        {
            return new List<ComplainModal>
        {
            new ComplainModal {CallerName =".NET Core", CallerPhone = "1289012", CallerEmail = "test1@gmail.com" },
            new ComplainModal {CallerName ="Docker",CallerPhone = "3429093" , CallerEmail = "test2@gmail.com"},
            new ComplainModal { CallerName ="C#", CallerPhone = "1234234212", CallerEmail = "test2@gmail.com" }
        };
        }
    }
}