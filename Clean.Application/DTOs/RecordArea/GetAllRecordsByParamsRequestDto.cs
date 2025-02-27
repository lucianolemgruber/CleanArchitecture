namespace Clean.Application.DTOs.RecordArea;

public class GetAllRecordsByParamsRequestDto
{
    public string? Name { get; set; }
    public string? Email { get; set; }
    public string? Phone { get; set; }
    public int Page { get; set; } = 1;
    public int PageSize { get; set; } = 10;
}
