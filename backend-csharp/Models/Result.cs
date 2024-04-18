namespace backend_csharp.Models
{
    public enum ResultStatusValues
    {
        OK,
        Error
    }

    public class Result
    {
        public ResultStatusValues Status { get; set; } = ResultStatusValues.OK;
        public int Code { get; set; } = 0;
        public string Message { get; set; } = string.Empty;
    }

    public class Result<T> : Result
    {
        public T? Data { get; set; }
    }
}
