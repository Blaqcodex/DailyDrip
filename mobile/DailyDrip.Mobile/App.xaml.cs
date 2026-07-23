using Microsoft.Extensions.DependencyInjection;
using DailyDrip.Mobile.Views;

namespace DailyDrip.Mobile;

public partial class App : Application
{
    public App()
    {
        InitializeComponent();
    }

    protected override Window CreateWindow(IActivationState? activationState)
    {
        return new Window(new WelcomePage());
    }
}