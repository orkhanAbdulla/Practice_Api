using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuarterApp.Core.Entities
{
    public class Property:BaseEntity
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal MonthlyPrice { get; set; }
        public decimal WeeklyPrice { get; set; }
        public decimal DailyPrice { get; set; }
        public DateTime BuildDate { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
