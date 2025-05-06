using Microsoft.Maui.Controls;
using Microsoft.Maui.Storage;

namespace News.Views;

public partial class SettingsView : ContentPage
{
    public bool IsDarkTheme { get; set; }

    public SettingsView()
    {
        InitializeComponent();
        BindingContext = this;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        IsDarkTheme = Preferences.Get("IsDarkTheme", false);
        ThemeSwitch.IsToggled = IsDarkTheme;
    }

    private void OnThemeToggled(object sender, ToggledEventArgs e)
    {
        Application.Current.UserAppTheme = e.Value ? AppTheme.Dark : AppTheme.Light;
        Preferences.Set("IsDarkTheme", e.Value);
    }
}
