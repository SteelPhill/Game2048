namespace Game2048.Logic;

public interface IGameService
{
    int Score { get; }

    void InsertTwoOrFour();
    bool IsNoFreeSpace();
    bool IsNoMoves();
    bool IsWin();
    void Restart();
    bool TryMoveDown();
    bool TryMoveLeft();
    bool TryMoveRight();
    bool TryMoveUp();
}