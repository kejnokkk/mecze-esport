namespace site_blazor.Services;

public class ThemeService
{
    public bool IsDarkMode { get; private set; } = false;
    public event Action? OnThemeChanged;

    public void Toggle()
    {
        IsDarkMode = !IsDarkMode;
        OnThemeChanged?.Invoke();
    }
}