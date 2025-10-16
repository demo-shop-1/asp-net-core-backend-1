namespace CNET1.Enums
{
    public sealed record AppDateTimeEnum(string Value)
    {
        public static readonly AppDateTimeEnum DATE_TIME_FORMAT_DEFAULT = new("dd/MM/yyyy HH:mm:ss");

        public override string ToString() => Value;
    }
}
