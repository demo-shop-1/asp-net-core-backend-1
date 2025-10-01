namespace CNET1.Utils
{
    public abstract class AppServiceUtil<T>([FromKeyedServices("service")] AppBaseUtil<T> baseUtil)
    {
        protected readonly AppBaseUtil<T> BaseUtil = baseUtil;

        protected void InfoMethod(string NameMethod, string Message)
        => BaseUtil.InfoMethod(NameMethod, Message);

        protected void StartMethod(string NameMethod)
        => BaseUtil.StartMethod(NameMethod);

        protected void EndMethod(string NameMethod)
        => BaseUtil.EndMethod(NameMethod);
    }
}
