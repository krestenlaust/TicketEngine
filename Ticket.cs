using System.Net;

namespace TicketEngine;

public class Ticket
{
    public uint UID { get; }
    public Worker Author { get; }
    public string Subject { get; set; }
    public string Description { get; set; }
    public TicketStatus TicketStatus { get; set; }
    public IList<WorkLogUnit> WorkLog { get; set; }
    
    public Ticket(uint UID, Worker author, string subject)
    {
        this.UID = UID;
        Author = author;
        Subject = subject;
    }
}