using System;

namespace Game2048;

public static class Constants
{
    public static readonly string UsersFileName = "Users.xml";
    public static readonly string UsersFilePath = Environment.CurrentDirectory + "\\" + UsersFileName;
    public static readonly int FieldSideSize = 4;
    public static readonly int NinetyPercent = 90;
    public static readonly int OneHundredPercent = 100;
}