using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Game2048.Base;
using Game2048.Database;

namespace Game2048.Views.GameWindow;

public class GameViewModel : ViewModel<GameWindow>
{
	public override object Header => "2048";

	private readonly IUserDB _userDB;
	private readonly IMessenger _messenger;

	private ICommand _anyCommand;

	public ICommand AnyCommand => _anyCommand ??= new RelayCommand(Any);

	public GameViewModel(
		IUserDB userDB,
		IMessenger messenger)
	{
		_userDB = userDB;
		_messenger = messenger;
	}

	private void Any()
	{

	}

	public interface IFactory
	{
		GameViewModel Create();
	}
}