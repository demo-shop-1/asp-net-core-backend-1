namespace CNET1.Exceptions
{
    [Serializable]
    public class AppException : Exception
    {
        public AppException() { }
        public AppException(string Message) : base(Message) { }
        public AppException(string MessageCode, string MessageRaw) : base(MessageCode, new Exception(MessageRaw)) { }
    }
}
