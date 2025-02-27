using FluentValidation;

namespace Clean.Application.UseCases.Commands.RecordArea.DeleteRecord;

public class DeleteRecordValidator : AbstractValidator<DeleteRecordCommand>
{
    public DeleteRecordValidator()
    {
        RuleFor(x => x.Id)
            .GreaterThan(0)
            .WithMessage("Id is required");
    }
}
