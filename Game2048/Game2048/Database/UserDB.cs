using Game2048.Entities;
using Game2048.Helpers;
using System.Collections.Generic;
using System.IO;

namespace Game2048.Database;

public class UserDB : IUserDB
{
    private const string UsersFileName = "Users.xml";

    public List<User> Users { get; private set; }

    public void Add(User user)
    {
        Users.Add(user);
    }

    public void Read()
    {
        Users = XmlSerializerHelper.Deserializing<List<User>>(File.ReadAllText(UsersFileName));
    }

    public void Write()
    {
        File.WriteAllText(UsersFileName, XmlSerializerHelper.Serializing(Users));
    }
}