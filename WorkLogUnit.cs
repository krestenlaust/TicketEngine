namespace TicketEngine;

public record WorkLogUnit(Worker Author, string LogMessage, DateTime Timestamp);
