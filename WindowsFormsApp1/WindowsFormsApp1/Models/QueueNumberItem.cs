namespace WindowsFormsApp1.Models
{
    public class QueueNumberItem : IQueueItem
    {
        public double Number { get; private set; }

        public QueueNumberItem(double number)
        {
            this.Number = number;
        }
    }
}
