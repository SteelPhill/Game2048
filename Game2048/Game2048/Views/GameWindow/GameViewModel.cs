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

	public ICommand KeyDownCommand => _keyDownCommand ??= new RelayCommand<KeyEventArgs>(OnKeyboardArrow);

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

	private void OnKeyboardArrow(KeyEventArgs args)
	{
        switch (args.Key)
        {
            case Key.Left:
            case Key.A:
                MoveLeft();
                break;
            case Key.Up:
            case Key.W:
                MoveUp();
                break;
            case Key.Right:
            case Key.D:
                MoveRight();
                break;
            case Key.Down:
            case Key.S:
                MoveDown();
                break;
            default:
                break;
        }
    }

    public void MoveRight()
    {
        var length = FieldModel.Field.Count;
        for (var i = 0; i < length; i++)
        {
            var col = length - 1;

            for (var j = length - 2; j >= 0; j--)
            {
                if (FieldModel.Field[i][j].IsNone())
                    continue;

                if (FieldModel.Field[i][col].IsNone())
                {
                    FieldModel.Field[i][col].Value = FieldModel.Field[i][j].Value;
                    if (j != col)
                        FieldModel.Field[i][j].Value = CellValues.None;
                }
                else if (FieldModel.Field[i][col].Value == FieldModel.Field[i][j].Value)
                {
                    var newValue = (CellValues)((int)FieldModel.Field[i][col].Value * 2);
                    FieldModel.Field[i][col].Value = newValue;
                    FieldModel.Field[i][j].Value = CellValues.None;
                    col--;
                }
                else
                {
                    col--;
                    if (col == j)
                        continue;

                    FieldModel.Field[i][col].Value = FieldModel.Field[i][j].Value;
                    FieldModel.Field[i][j].Value = CellValues.None;
                }
            }
        }
    }

    public void MoveDown()
    {
        var length = FieldModel.Field.Count;

        for (var j = 0; j < length; j++)
        {
            var row = length - 1;

            for (var i = length - 2; i >= 0; i--)
            {
                if (FieldModel.Field[i][j].IsNone())
                    continue;

                if (FieldModel.Field[row][j].IsNone())
                {
                    FieldModel.Field[row][j].Value = FieldModel.Field[i][j].Value;
                    if (i != row)
                        FieldModel.Field[i][j].Value = CellValues.None;
                }
                else if (FieldModel.Field[row][j].Value == FieldModel.Field[i][j].Value)
                {
                    var newValue = (CellValues)((int)FieldModel.Field[row][j].Value * 2);
                    FieldModel.Field[row][j].Value = newValue;
                    FieldModel.Field[i][j].Value = CellValues.None;
                    row--;
                }
                else
                {
                    row--;
                    if (row == i)
                        continue;

                    FieldModel.Field[row][j].Value = FieldModel.Field[i][j].Value;
                    FieldModel.Field[i][j].Value = CellValues.None;
                }
            }
        }
    }

    public void MoveLeft()
    {
        var length = FieldModel.Field.Count;

        for (var i = 0; i < length; i++)
        {
            var col = 0;

            for (var j = 1; j < length; j++)
            {
                if (FieldModel.Field[i][j].IsNone())
                    continue;

                if (FieldModel.Field[i][col].IsNone())
                {
                    FieldModel.Field[i][col].Value = FieldModel.Field[i][j].Value;
                    if (j != col)
                        FieldModel.Field[i][j].Value = CellValues.None;
                }
                else if (FieldModel.Field[i][col].Value == FieldModel.Field[i][j].Value)
                {
                    var newValue = (CellValues)((int)FieldModel.Field[i][col].Value * 2);
                    FieldModel.Field[i][col].Value = newValue;
                    FieldModel.Field[i][j].Value = CellValues.None;
                    col++;
                }
                else
                {
                    col++;
                    if (col == j)
                        continue;

                    FieldModel.Field[i][col].Value = FieldModel.Field[i][j].Value;
                    FieldModel.Field[i][j].Value = CellValues.None;
                }
            }
        }
    }

    public void MoveUp()
    {
        var length = FieldModel.Field.Count;

        for (var j = 0; j < length; j++)
        {
            var row = 0;

            for (var i = 1; i < length; i++)
            {
                if (FieldModel.Field[i][j].IsNone())
                    continue;

                if (FieldModel.Field[row][j].IsNone())
                {
                    FieldModel.Field[row][j].Value = FieldModel.Field[i][j].Value;
                    if (i != row)
                        FieldModel.Field[i][j].Value = CellValues.None;
                }
                else if (FieldModel.Field[row][j].Value == FieldModel.Field[i][j].Value)
                {
                    var newValue = (CellValues)((int)FieldModel.Field[row][j].Value * 2);
                    FieldModel.Field[row][j].Value = newValue;
                    FieldModel.Field[i][j].Value = CellValues.None;
                    row++;
                }
                else
                {
                    row++;
                    if (row == i)
                        continue;

                    FieldModel.Field[row][j].Value = FieldModel.Field[i][j].Value;
                    FieldModel.Field[i][j].Value = CellValues.None;
                }
            }
        }
    }

    public interface IFactory
    {
        GameViewModel Create(User user);
    }
}