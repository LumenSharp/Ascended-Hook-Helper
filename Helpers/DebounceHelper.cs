namespace AscendedHookHelper.Helpers;

public class DebounceHelper
{
    private CancellationTokenSource? _debounceCancellationToken = null;
    public async Task DebounceAsync(Func<CancellationToken, Task> func, int debounceMilliseconds = 500)
    {
        try
        {
            if (_debounceCancellationToken != null)
                _debounceCancellationToken.Cancel();

            _debounceCancellationToken = new CancellationTokenSource();

            await Task.Delay(debounceMilliseconds, _debounceCancellationToken.Token);

            if (_debounceCancellationToken.IsCancellationRequested)
                return;

            await func(_debounceCancellationToken.Token);
        }
        catch (TaskCanceledException) { }
    }
}