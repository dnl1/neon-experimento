namespace SampleRestfulAPI.Exceptions
{
    public class ValidateException : System.Exception
    {
        public ValidateException():base(){}
        public ValidateException(string message) : base(message) {}
    }
}