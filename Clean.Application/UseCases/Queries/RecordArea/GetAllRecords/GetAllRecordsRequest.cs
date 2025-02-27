using Clean.Application.DTOs.RecordArea;
using MediatR;

namespace Clean.Application.UseCases.Queries.RecordArea.GetAllRecords;

public sealed record GetAllRecordsRequest() : IRequest<List<RecordDto>?>;