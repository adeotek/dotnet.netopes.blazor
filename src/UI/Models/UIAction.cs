using Microsoft.AspNetCore.Components;

namespace Netopes.Blazor.UI.Models
{
    public enum UIActionTypes
    {
        Route,
        Event
    }
    
    public class UIAction
    {
        public UIActionTypes Type { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string CssClass { get; set; }
        public string Url { get; set; }
        public EventCallback<string> Event { get; set; }
    }
}