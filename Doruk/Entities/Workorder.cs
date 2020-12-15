using Doruk.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Doruk.Entities
{
    public class Workorder
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public List<Report> Reports { get; set; }

        public Workorder CalculateTotalStop(List<WorkStop> workstops, List<WorkStopType> workStopTypes)
        {
            Reports = new List<Report>();

            List<Report> result = new List<Report>();
            List<WorkStop> workstopList = workstops.Where(c => c.StartDate <= this.EndDate && this.StartDate <= c.EndDate).Select(c =>
            {
                WorkStop workOrder = new WorkStop();
                workOrder.Id = c.Id;

                if (c.StartDate <= this.StartDate)
                    workOrder.StartDate = this.StartDate;
                else
                    workOrder.StartDate = c.StartDate;

                if (c.EndDate > this.EndDate)
                    workOrder.EndDate = this.EndDate;
                else
                    workOrder.EndDate = c.EndDate;

                workOrder.WorkOrderStopTypeId = c.WorkOrderStopTypeId;

                return workOrder;

            }).ToList();


            result = workstopList.GroupBy(c => c.WorkOrderStopTypeId).Select(c =>
                  new Report()
                  {
                      WorkOrderId = this.Id,
                      WorkOrderStopTypeId = c.Key,
                      StopMinute = c.Sum(d => d.DiffDate)

                  }).ToList();

            var notExists = workStopTypes.Where(c => result.Select(f => f.WorkOrderStopTypeId).ToList().Contains(c.Id) == false).Select(c => new Report()
            {
                WorkOrderId = this.Id,
                WorkOrderStopTypeId = c.Id,
                StopMinute = 0
            }).ToList();

            result.AddRange(notExists);

            this.Reports = result;

            return this;


        }

    }
}
