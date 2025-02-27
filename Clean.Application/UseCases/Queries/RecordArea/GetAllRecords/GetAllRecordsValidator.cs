using FluentValidation;

namespace Clean.Application.UseCases.Queries.RecordArea.GetAllRecords;

public class GetAllRecordsValidator : AbstractValidator<GetAllRecordsRequest>
{
    public GetAllRecordsValidator()
    {
    }
}
