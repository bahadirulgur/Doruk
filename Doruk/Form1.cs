using Doruk.Entities;
using Doruk.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Doruk
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }


        public List<WorkStopType> initWorkStopTypes()
        {
            List<WorkStopType> result = new List<WorkStopType>();
            WorkStopType workStopType = new WorkStopType();
            workStopType.Name = "Mola";
            workStopType.Id = 1;
            result.Add(workStopType);
            workStopType = new WorkStopType();
            workStopType.Name = "Arıza";
            workStopType.Id = 2;
            result.Add(workStopType);
            workStopType = new WorkStopType();
            workStopType.Name = "Setup";
            workStopType.Id = 3;
            result.Add(workStopType);
            workStopType = new WorkStopType();
            workStopType.Name = "Arge";
            workStopType.Id = 4;
            result.Add(workStopType);
            workStopType = new WorkStopType();
            workStopType.Name = "Bahadır";
            workStopType.Id = 5;
            result.Add(workStopType);
            return result;
        }
        public List<Workorder> initWorkOrders()
        {
            List<Workorder> workorders = new List<Workorder>();
            Workorder workorder = new Workorder();
            workorder.Id = 1001;
            workorder.StartDate = new DateTime(2017, 01, 01, 08, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 01, 16, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1002;
            workorder.StartDate = new DateTime(2017, 01, 01, 16, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 02, 00, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1003;
            workorder.StartDate = new DateTime(2017, 01, 02, 00, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 02, 08, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1004;
            workorder.StartDate = new DateTime(2017, 01, 02, 08, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 02, 16, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1005;
            workorder.StartDate = new DateTime(2017, 01, 02, 16, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 03, 00, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1006;
            workorder.StartDate = new DateTime(2017, 01, 03, 00, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 03, 08, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1007;
            workorder.StartDate = new DateTime(2017, 01, 03, 08, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 03, 16, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1008;
            workorder.StartDate = new DateTime(2017, 01, 03, 16, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 04, 00, 00, 00);
            workorders.Add(workorder);
            workorder = new Workorder();
            workorder.Id = 1009;
            workorder.StartDate = new DateTime(2017, 01, 04, 00, 00, 00);
            workorder.EndDate = new DateTime(2017, 01, 04, 08, 00, 00);
            workorders.Add(workorder);

            return workorders;
        }
        public List<WorkStop> GetworkStops()
        {
            List<WorkStop> workStops = new List<WorkStop>();
            WorkStop workStop = new WorkStop();
            workStop.Id = 1;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 01, 10, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 10, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 2;
            workStop.WorkOrderStopTypeId = 2;
            workStop.StartDate = new DateTime(2017, 01, 01, 10, 30, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 11, 00, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 3;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 01, 12, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 12, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 4;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 01, 14, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 14, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 5;
            workStop.WorkOrderStopTypeId = 3;
            workStop.StartDate = new DateTime(2017, 01, 01, 15, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 16, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 6;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 01, 18, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 18, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 7;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 01, 20, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 20, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 8;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 01, 22, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 01, 22, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 9;
            workStop.WorkOrderStopTypeId = 4;
            workStop.StartDate = new DateTime(2017, 01, 01, 23, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 02, 08, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 10;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 02, 10, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 02, 10, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 11;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 02, 12, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 02, 12, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 12;
            workStop.WorkOrderStopTypeId = 2;
            workStop.StartDate = new DateTime(2017, 01, 02, 13, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 02, 13, 45, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 13;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 02, 14, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 02, 14, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 14;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 02, 18, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 02, 18, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 15;
            workStop.WorkOrderStopTypeId = 4;
            workStop.StartDate = new DateTime(2017, 01, 02, 20, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 02, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 16;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 03, 04, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 04, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 17;
            workStop.WorkOrderStopTypeId = 3;
            workStop.StartDate = new DateTime(2017, 01, 03, 06, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 09, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 18;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 03, 10, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 10, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 19;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 03, 12, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 12, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 20;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 03, 14, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 14, 10, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 21;
            workStop.WorkOrderStopTypeId = 2;
            workStop.StartDate = new DateTime(2017, 01, 03, 15, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 18, 45, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 22;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 03, 20, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 20, 30, 00);
            workStops.Add(workStop);
            workStop = new WorkStop();
            workStop.Id = 23;
            workStop.WorkOrderStopTypeId = 1;
            workStop.StartDate = new DateTime(2017, 01, 03, 22, 00, 00);
            workStop.EndDate = new DateTime(2017, 01, 03, 22, 10, 00);
            workStops.Add(workStop);

            return workStops;
        }
 

        private void btnReport_Click(object sender, EventArgs e)
        {
             
                List<Workorder> workorders = initWorkOrders();
                List<WorkStop> workstops = GetworkStops();
                List<WorkStopType> workStopTypes = initWorkStopTypes();
                dataGridView1.Columns.Add("WorkOrder", "WorkOrder");
                foreach (WorkStopType stopType in workStopTypes)
                {
                    dataGridView1.Columns.Add(stopType.Name, stopType.Name);
                }
                dataGridView1.Columns.Add("Total", "Total");
                DataGridViewRow row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                foreach (Workorder workorder in workorders)
                {

                    workorder.CalculateTotalStop(workstops, workStopTypes);
                    row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                    row.Cells[0].Value = workorder.Id;
                    double rowCount = 0;
                    int i = 1;
                    foreach (Report h in workorder.Reports)
                    {
                        rowCount += h.StopMinute;
                        row.Cells[i].Value = h.StopMinute;
                        i++;

                    }
                    row.Cells[workStopTypes.Count + 1].Value = rowCount;
                    dataGridView1.Rows.Add(row);

                }
                row = (DataGridViewRow)dataGridView1.Rows[0].Clone();
                row.Cells[0].Value = "Total";
                for (int i = 1; i < dataGridView1.Columns.Count; ++i)
                {
                    int total = 0;
                    for (int k = 0; k < dataGridView1.Rows.Count; ++k)
                    {
                        total += Convert.ToInt32(dataGridView1.Rows[k].Cells[i].Value);
                    }

                    row.Cells[i].Value = total;

                }
                dataGridView1.Rows.Add(row);
            
        }
    }
}
