namespace TicketEngine;

internal interface ICommand
{
    /// <summary>
    /// TODO: Consider whether it is possible to expand it to undo in any order.
    /// Undoes the previous step, assuming nothing has happended since.
    /// </summary>
    public void Undo();

    /// <summary>
    /// Executes the step.
    /// </summary>
    public void Execute();
}
