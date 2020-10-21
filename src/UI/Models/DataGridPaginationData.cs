using System;
using System.Text.Json.Serialization;

namespace Netopes.Blazor.UI.Models
{
    public class DataGridPaginationData
    {
        public int CurrentPage { get; set; }
        public int TotalRecords { get; set; }
        public int RowsPerPage { get; set; } = 20;
        [JsonIgnore]
        public int PagesNo => (int) Math.Ceiling((double) TotalRecords / RowsPerPage);
        
        public (int, int) GetPaginationOffset()
        {
            if (CurrentPage == -1)
            {
                return (-1, -1);
            }
            
            if (CurrentPage < 1)
            {
                return RowsPerPage > 0 ? (-1, RowsPerPage) : (-1, -1);
            }

            return RowsPerPage > 0 ? ((CurrentPage - 1) * RowsPerPage, RowsPerPage) : (-1, -1);
        }
        
        public (int, int) GetPaginationInterval()
        {
            if (CurrentPage == -1)
            {
                return (-1, -1);
            }
            
            if (CurrentPage < 1)
            {
                return RowsPerPage > 0 ? (-1, RowsPerPage) : (-1, -1);
            }

            return RowsPerPage > 0 ? ((CurrentPage - 1) * RowsPerPage + 1, CurrentPage * RowsPerPage - 1) : (-1, -1);
        }
    }
}