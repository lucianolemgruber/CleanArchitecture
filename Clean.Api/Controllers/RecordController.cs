using Clean.Application.DTOs.RecordArea;
using Clean.Application.UseCases.Commands.RecordArea.CreateRecord;
using Clean.Application.UseCases.Commands.RecordArea.DeleteRecord;
using Clean.Application.UseCases.Queries.RecordArea.GetAllRecords;
using Clean.Application.UseCases.Queries.RecordArea.GetAllRecordsByParams;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Clean.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class RecordController(IMediator mediator) : ControllerBase
{
    private readonly IMediator _mediator = mediator;

    [HttpGet(Name = "GetAllRecords")]
    public async Task<List<RecordDto>?> GetAllRecords()
    {
        GetAllRecordsRequest request = new();
        List<RecordDto>? recordDtos = await _mediator.Send(request);
        return recordDtos;
    }

    [HttpGet("{getAllRecordsByParamsRequestDto}", Name = "GetRecordByParams")]
    public async Task<List<RecordDto>?> GetRecordByParams(GetAllRecordsByParamsRequestDto getAllRecordsByParamsRequestDto)
    {
        GetAllRecordsByParamsRequest request = new(getAllRecordsByParamsRequestDto);
        List<RecordDto>? recordDtos = await _mediator.Send(request);

        return recordDtos;
    }

    [HttpPost(Name = "CreateRecord")]
    public async Task<IActionResult> CreateRecord(CreateRecordRequestDto createRecordRequestDto)
    {
        CreateRecordCommand command = new(createRecordRequestDto);
        bool result = await _mediator.Send(command);
        return Ok(result);
    }

    [HttpDelete("{id}", Name = "DeleteRecord")]
    public async Task<IActionResult> DeleteRecord(int id)
    {
        DeleteRecordCommand command = new(id);
        bool result = await _mediator.Send(command);
        return Ok(result);
    }
}
