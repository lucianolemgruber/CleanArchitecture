using FluentValidation;

namespace Clean.Application.UseCases.Commands.RecordArea.CreateRecord;

public class CreateRecordValidator : AbstractValidator<CreateRecordCommand>
{
    public CreateRecordValidator()
    {
        RuleFor(x => x.CreateRecordRequestDto)
            .NotNull()
            .WithMessage("CreateRecordRequestDto is required");
        
        RuleFor(x => x.CreateRecordRequestDto.Email)
            .NotEmpty()
            .WithMessage("Email is required")
            .EmailAddress()
            .WithMessage("Email is invalid");
        
        RuleFor(x => x.CreateRecordRequestDto.Name)
            .NotEmpty()
            .WithMessage("Name is required");
        
        RuleFor(x => x.CreateRecordRequestDto.Phone)
            .NotEmpty()
            .WithMessage("Phone is required");
    }
}
