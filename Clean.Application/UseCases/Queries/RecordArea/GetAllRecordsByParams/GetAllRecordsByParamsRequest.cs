using Clean.Application.DTOs.RecordArea;
using MediatR;

namespace Clean.Application.UseCases.Queries.RecordArea.GetAllRecordsByParams;

public sealed record GetAllRecordsByParamsRequest(GetAllRecordsByParamsRequestDto RequestDto) : IRequest<List<RecordDto>?>;
