using Clean.Application.DTOs.RecordArea;
using MediatR;

namespace Clean.Application.UseCases.Commands.RecordArea.CreateRecord;

public sealed record CreateRecordCommand(CreateRecordRequestDto CreateRecordRequestDto) : IRequest<bool>;
