namespace TicketEngine;

public enum TicketStatus : byte
{
    /// <summary>
    /// The task has not been started.
    /// </summary>
    NotStarted,

    /// <summary>
    /// The task is in progress.
    /// </summary>
    InProgress,

    /// <summary>
    /// The task is dependent on an specified external factor.
    /// </summary>
    Waiting,

    /// <summary>
    /// The task has been finished.
    /// </summary>
    Finished,
}
