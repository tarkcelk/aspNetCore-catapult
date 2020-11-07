using ApplicationCore.Constants.Enums;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces.Library;
using System;
using System.Collections.Generic;
using System.Text;

namespace ApplicationCore.Interfaces
{
    public interface ISampleRepository : IRepository<Sample>
    {
        IEnumerable<SampleDetail> GetSampleDetailsBySampleId(int sampleId);
        IEnumerable<Sample> GetSamplesByProcessId(ESampleEnums.Processes process);
    }
}
