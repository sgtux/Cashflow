namespace FinanceApi.Shared
{
  public class ValidateException : System.Exception
  {
    public ValidateException(string message) : base(message) { }
  }
}