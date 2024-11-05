using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Game2048.Base;
using Game2048.Database;
using Game2048.Entities;
using Game2048.Messages;
using Game2048.Views.GameWindow.Logic;

namespace Game2048.Views.AuthorizationWindow;

public class AuthorizationViewModel : ViewModel<AuthorizationWindow>
{
	public override object Header => "Authentication";

    private User _currentUser;
    private string _login;
    private bool _isRememberMe;

    public string Login
    {
        get => _login;
        set => Set(ref _login, value);
    }

    public bool IsRememberMe
    {
        get => _isRememberMe;
        set => Set(ref _isRememberMe, value);
    }

    private readonly IUserDB _userDB;
    private readonly IMessenger _messenger;
	private readonly IGameWindowProvider _gameWindowProvider;

    private ICommand _contentRenderedCommand;
    private ICommand _logInCommand;
    private ICommand _cancelCommand;

    public ICommand ContentRenderedCommand => _contentRenderedCommand ??= new RelayCommand(OnContentRendered);
    public ICommand LogInCommand => _logInCommand ??= new RelayCommand(OnLogIn);
    public ICommand CancelCommand => _cancelCommand ??= new RelayCommand(OnCancel);

    public AuthorizationViewModel(
		IUserDB userDB,
		IMessenger messenger,
		IGameWindowProvider gameWindowProvider)
	{
        _userDB = userDB;
        _messenger = messenger;
		_gameWindowProvider = gameWindowProvider;
    }

    private void OnContentRendered()
    {
        _currentUser = _userDB.Users.Find(u => u.IsRememberMe);

        if (_currentUser == null)
            return;

        Login = _currentUser.Name;
        IsRememberMe = _currentUser.IsRememberMe;
    }

    private void OnLogIn()
    {
        if (Login == string.Empty)
            return;

        _currentUser.IsRememberMe = false;

        var oldUser = _userDB.Users.Find(u => u.Name == Login);

        if (oldUser != null)
        {
            _currentUser = oldUser;
        }
        else
        {
            _currentUser = new User(Login);
            _userDB.Add(_currentUser);
        }

        _currentUser.IsRememberMe = IsRememberMe;
        _gameWindowProvider.Show(_currentUser);
        _messenger.Send(new RequestCloseMessage(this, null));
    }

    private void OnCancel()
    {
        _messenger.Send(new RequestCloseMessage(this, null));
    }
}