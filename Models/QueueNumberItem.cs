using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class QueueNumberItem:IQueueItem
    {
        public double Number { get;  set; }
        public QueueNumberItem(double number)
        {
            this.Number = number;
        }
    }
}
