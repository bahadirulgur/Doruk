using Doruk.Entities;

namespace Doruk.Models
{
    public class Report
    {
       
        public int WorkOrderId { get; set; }
        public int WorkOrderStopTypeId { get; set; }         
        public double StopMinute { get; set; }
    }
}
