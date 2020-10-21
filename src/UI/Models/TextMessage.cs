using Microsoft.AspNetCore.Components;

namespace Netopes.Blazor.UI.Models
{
    public class TextMessage
    {
        public string Text { get; set; }
        public bool IsError { get; set; } = true;
        
        public TextMessage(string text, bool isError = true)
        {
            Text = text;
            IsError = isError;
        }
        
        public MarkupString Message => (MarkupString) Text;
    }
}