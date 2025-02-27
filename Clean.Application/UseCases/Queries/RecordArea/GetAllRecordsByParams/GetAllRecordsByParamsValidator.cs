using FluentValidation;

namespace Clean.Application.UseCases.Queries.RecordArea.GetAllRecordsByParams;

public class GetAllRecordsByParamsValidator : AbstractValidator<GetAllRecordsByParamsRequest>
{
    public GetAllRecordsByParamsValidator()
    {
        RuleFor(x => x.RequestDto.Page).GreaterThan(0);
        RuleFor(x => x.RequestDto.PageSize).GreaterThan(0);
    }
}