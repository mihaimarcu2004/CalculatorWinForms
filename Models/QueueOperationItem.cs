using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Models
{
    public class QueueOperationItem:IQueueItem
    {
        public OperationType Operation { get; private set; }
        public QueueOperationItem(OperationType operation)
        {
            this.Operation = operation;
        }
    }
}
