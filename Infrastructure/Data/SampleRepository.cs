using ApplicationCore.Constants.Enums;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using Infrastructure.Data.EntityFramework;
using Infrastructure.Data.Library;
using System.Collections.Generic;
using System.Linq;

namespace Infrastructure.Data
{
    public class SampleRepository : EfRepository<Sample>, ISampleRepository
    {
        public SampleRepository(SampleContext context) : base(context)
        {
        }

        IEnumerable<SampleDetail> ISampleRepository.GetSampleDetailsBySampleId(int sampleId)
        {
            return _context.SampleDetail.Where(x => x.SampleId == sampleId).ToList();
        }

        IEnumerable<Sample> ISampleRepository.GetSamplesByProcessId(ESampleEnums.Processes process)
        {
            return _context.Sample.Where(x => x.ProccessId == (int)process).ToList();
        }
    }
}
