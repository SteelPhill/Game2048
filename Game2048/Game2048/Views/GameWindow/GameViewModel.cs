using System.Windows;
using System.Windows.Input;
using GalaSoft.MvvmLight.CommandWpf;
using GalaSoft.MvvmLight.Messaging;
using Game2048.Base;
using Game2048.Database;
using Game2048.Entities;
using Game2048.Logic;
using Game2048.Models;

namespace Game2048.Views.GameWindow;

public class GameViewModel : ViewModel<GameWindow>
{
    public override object Header => "2048";

    private readonly IUserDB _userDB;
    private readonly IMessenger _messenger;

    private User _user;
    private FieldModel _fieldModel;
    private int _score;

    private Game _game;

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

    public int Score
    {
        get => _score;
        set => Set(ref _score, value);
    }

    private ICommand _contentRenderedCommand;
    private ICommand _keyDownCommand;
    private ICommand _restartCommand;

    public ICommand ContentRenderedCommand => _contentRenderedCommand ??= new RelayCommand(OnContentRendered);
    public ICommand KeyDownCommand => _keyDownCommand ??= new RelayCommand<KeyEventArgs>(OnKeyboardArrow);
    public ICommand RestartCommand => _restartCommand ??= new RelayCommand(OnRestart);

    public GameViewModel(
        IUserDB userDB,
        IMessenger messenger,
        User user)
    {
        _userDB = userDB;
        _messenger = messenger;
        User = user;
        FieldModel = new FieldModel();
        Score = 0;
        _game = new Game(FieldModel, Score);
    }

    private void OnContentRendered()
    {
        _game.RandomTwoOrFour();
        _game.RandomTwoOrFour();
    }

    private void OnKeyboardArrow(KeyEventArgs args)
    {
        switch (args.Key)
        {
            case Key.Left:
            case Key.A:
                _game.MoveLeft();
                _game.RandomTwoOrFour();
                break;
            case Key.Up:
            case Key.W:
                _game.MoveUp();
                _game.RandomTwoOrFour();
                break;
            case Key.Right:
            case Key.D:
                _game.MoveRight();
                _game.RandomTwoOrFour();
                break;
            case Key.Down:
            case Key.S:
                _game.MoveDown();
                _game.RandomTwoOrFour();
                break;
            default:
                break;
        }

        if (_game.IsWin())
        {
            MessageBox.Show("You win!", "Game over");
            if (User.HighScore < Score)
                User.HighScore = Score;
            RaisePropertyChanged(nameof(User));
            _game.Restart();
            return;
        }

        if (_game.IsNoFreeSpace())
        {
            if (_game.IsNoMoves())
            {
                MessageBox.Show("You lose!", "Game over");
                if (User.HighScore < Score)
                    User.HighScore = Score;
                RaisePropertyChanged(nameof(User));
                _game.Restart();
            }
        }
    }

    private void OnRestart()
    {
        _game.Restart();
    }

    public interface IFactory
    {
        GameViewModel Create(User user);
    }
}