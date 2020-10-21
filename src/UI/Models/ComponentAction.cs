using Microsoft.AspNetCore.Components;

namespace Netopes.Blazor.UI.Models
{
    public enum ComponentActionTypes
    {
        Route,
        Event
    }
    
    public class ComponentAction
    {
        public ComponentActionTypes Type { get; set; }
        public string Name { get; set; }
        public string Icon { get; set; }
        public string Route { get; set; }
        public EventCallback<string> Event { get; set; }
    }
}