namespace CNET1.Exceptions
{
    public record AppErrorDTO
    (
        string MessageRaw,
        string MessageCode,
        string Status,
        int StausCode,
        string Date
    );
}
