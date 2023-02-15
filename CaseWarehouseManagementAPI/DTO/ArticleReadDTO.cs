using CaseWarehouseManagementAPI.Models;
using System.ComponentModel;

namespace CaseWarehouseManagementAPI.DTO
{
    public class ArticleReadDTO
    {
        public int? Id { get; set; }
        public string? Name { get; set; }
        public int? AmountOf { get; set; }

    }
}
