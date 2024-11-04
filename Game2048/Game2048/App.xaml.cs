using Game2048.Views.MainWindow.Logic;
using System.Windows;

namespace Game2048;

public partial class App : Application
{
    private readonly IAuthorizationWindowProvider _authorizationWindowProvider;

    public App(IAuthorizationWindowProvider authorizationWindowProvider)
    {
        _authorizationWindowProvider = authorizationWindowProvider;

        InitializeComponent();
    }

    protected override void OnStartup(StartupEventArgs e)
    {
        base.OnStartup(e);

        _authorizationWindowProvider.Show();
    }

    protected override void OnExit(ExitEventArgs e)
    {
        base.OnExit(e);
    }
}