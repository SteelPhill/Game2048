﻿using GalaSoft.MvvmLight.Messaging;

namespace Game2048.Views.GameWindow;

public class DemoModel : GameViewModel
{
	public DemoModel() : base(null, Messenger.Default, null)
	{
	}
}