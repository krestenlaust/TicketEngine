namespace TicketEngine.Commands;

public class AddWorkLog : ICommand
{
    readonly Ticket ticket;
    readonly Worker author;
    readonly string logMessage;

    public AddWorkLog(Ticket ticket, Worker author, string logMessage)
    {
        this.ticket = ticket;
        this.author = author;
        this.logMessage = logMessage;
    }

    public void Execute()
    {
        ticket.WorkLog.Add(new WorkLogUnit(author, logMessage, DateTime.Now));
    }

    public void Undo()
    {
        ticket.WorkLog.RemoveAt(ticket.WorkLog.Count - 1);
    }
}
