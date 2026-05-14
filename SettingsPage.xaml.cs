namespace YorubaCatholicHymn;

public partial class SettingsPage : ContentPage
{
    public SettingsPage()
    {
        InitializeComponent(); // works because x:Class matches namespace + class name

        // Load saved preference
        bool isDark = Preferences.Get("dark_mode", false);
        DarkModeSwitch.IsToggled = isDark;
        ApplyTheme(isDark);
    }

    private void OnDarkModeToggled(object sender, ToggledEventArgs e)
    {
        Preferences.Set("dark_mode", e.Value);
        ApplyTheme(e.Value);
    }

    private void ApplyTheme(bool isDark)
    {
        Application.Current.UserAppTheme = isDark ? AppTheme.Dark : AppTheme.Light;
    }
}