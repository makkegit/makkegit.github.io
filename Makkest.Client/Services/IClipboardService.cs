namespace Makkest.Client.Services;

public interface IClipboardService
{
    ValueTask WriteTextAsync(string text);
}