namespace CNET1.Utils
{
    public class AppObjectUtil
    {
        public static bool IsNull(Object request)
        {
            return request == null;
        }

        public static bool IsBlankString(string? str)
        {
            return string.IsNullOrWhiteSpace(str);
        }
    }
}
