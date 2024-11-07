using System.Collections.ObjectModel;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Game2048.Base;
using Game2048.Database;
using Game2048.Entities;
using Game2048.Models;

namespace Game2048.Views.GameWindow;

public class GameViewModel : ViewModel<GameWindow>
{
	public override object Header => "2048";

    private readonly IUserDB _userDB;
	private readonly IMessenger _messenger;

	private User _user;
    private FieldModel _fieldModel;

    public User User
    {
        get => _user;
        set => Set(ref _user, value);
    }

    public FieldModel FieldModel
    {
        get => _fieldModel;
        set => Set(ref _fieldModel, value);
    }

    private ICommand _keyDownCommand;

	public ICommand KeyDownCommand => _keyDownCommand ??= new RelayCommand(OnKeyboardArrow);

	public GameViewModel(
		IUserDB userDB,
		IMessenger messenger,
		User user)
	{
		_userDB = userDB;
		_messenger = messenger;
        User = user;
		FieldModel = new FieldModel();
	}

	private void OnKeyboardArrow()
	{

	}

    public interface IFactory
    {
        GameViewModel Create(User user);
    }
}