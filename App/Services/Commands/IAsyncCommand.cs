namespace App.Services.Commands;

public interface IAsyncCommand<T>
{
    Task<T> InvokeAsync(CancellationToken cancellationToken = default);
}