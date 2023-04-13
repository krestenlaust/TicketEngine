namespace TicketEngine;

public class Worker
{
    public uint UID { get; }
    public string Name { get; set; }

    public Worker(uint UID, string name)
    {
        this.UID = UID;
        Name = name;
    }
}
