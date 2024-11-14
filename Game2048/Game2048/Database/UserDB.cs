using Game2048.Entities;
using Game2048.Helpers;
using System.Collections.Generic;
using System.IO;

namespace Game2048.Database;

public class UserDB : IUserDB
{
    public List<User> Users { get; private set; }

    public void Add(User user)
    {
        Users.Add(user);
    }

    public void Read()
    {
        if (!File.Exists(Constants.UsersFilePath))
        {
            Users = [];
            return;
        }

        Users = XmlSerializerHelper.Deserializing<List<User>>(File.ReadAllText(Constants.UsersFileName));
    }

    public void Write()
    {
        if (Users.Count == 0)
            return;

        File.WriteAllText(Constants.UsersFileName, XmlSerializerHelper.Serializing(Users));
    }
}