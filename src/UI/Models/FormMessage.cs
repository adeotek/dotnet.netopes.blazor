namespace Netopes.Blazor.UI.Models
{
    public class FormMessage
    {
        public string Message { get; set; }
        public bool IsError { get; set; } = true;

        public FormMessage(string message, bool isError = true)
        {
            Message = message;
            IsError = isError;
        }
    }
}