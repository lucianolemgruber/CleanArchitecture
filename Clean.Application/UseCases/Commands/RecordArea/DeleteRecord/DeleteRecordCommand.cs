using MediatR;

namespace Clean.Application.UseCases.Commands.RecordArea.DeleteRecord;

public sealed record DeleteRecordCommand(int Id) : IRequest<bool>;