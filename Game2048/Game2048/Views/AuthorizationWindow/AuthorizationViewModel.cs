using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Game2048.Base;
using Game2048.Database;
using Game2048.Views.GameWindow.Logic;

namespace Game2048.Views.AuthorizationWindow;

public class AuthorizationViewModel : ViewModel<AuthorizationWindow>
{
	public override object Header => "Authentication";

    private readonly IUserDB _userDB;
    private readonly IMessenger _messenger;
	private readonly IGameWindowProvider _editTextWindowProvider;

	private ICommand _logInCommand;
    private ICommand _cancelCommand;

    public ICommand LogInCommand => _logInCommand ??= new RelayCommand(OnLogIn);
    public ICommand CancelCommand => _logInCommand ??= new RelayCommand(OnCancel);

    public AuthorizationViewModel(
		IUserDB userDB,
		IMessenger messenger,
		IGameWindowProvider EditTextWindowProvider)
	{
        _userDB = userDB;
        _messenger = messenger;
		_editTextWindowProvider = EditTextWindowProvider;
	}

    private void OnLogIn()
    {
        
    }

    private void OnCancel()
    {
        
    }
}