namespace Makkest.Services;

public interface IClipboardService
{
    ValueTask WriteTextAsync(string text);
}