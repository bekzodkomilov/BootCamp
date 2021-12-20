namespace math.Models
{
    public class ErrorMathModel
    {
        public string RequestId {get; set;}

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}