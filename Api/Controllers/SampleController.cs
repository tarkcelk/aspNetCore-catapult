using Api.Helper.Api;
using ApplicationCore.Constants.Enums;
using ApplicationCore.Entities;
using ApplicationCore.Interfaces;
using ApplicationCore.Interfaces.Library;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Api.Controllers
{
    public class SampleController : BaseApiController
    {
        private readonly ISampleRepository _sampleRepository;
        private readonly IUnitOfWork _unitOfWork; 
        public SampleController(ISampleRepository sampleRepository, IUnitOfWork unitOfWork)
        {
            _sampleRepository = sampleRepository;
            _unitOfWork = unitOfWork;
        }
        [HttpGet]
        public ApiResult Get(int id)
        {
            try
            {
                var result = _sampleRepository.GetById(id);
                return ApiResultExtension.Send(result);
            }
            catch (Exception exc)
            {
                return ApiResultExtension.ExceptionEncountered(exc);
            }
        }

        [HttpPost]
        public ApiResult Create([FromBody] Sample sample)
        {
            try
            {
                _sampleRepository.Add(sample);
                return ApiResultExtension.Send(sample);
            }
            catch (Exception exc)
            {
                return ApiResultExtension.ExceptionEncountered(exc);
            }
        }

        [HttpGet]
        public ApiResult Get(ESampleEnums.Processes process)
        {
            try
            {
                var result = _sampleRepository.GetSamplesByProcessId(process);
                return ApiResultExtension.Send(result);
            }
            catch (Exception exc)
            {
                return ApiResultExtension.ExceptionEncountered(exc);
            }
        }
    }
}