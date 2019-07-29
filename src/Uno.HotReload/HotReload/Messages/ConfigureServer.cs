﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Uno.UI.HotReload.HotReload.Messages
{
	class ConfigureServer : IMessage
	{
		public const string Name = nameof(ConfigureServer);

		public ConfigureServer(string projectPath, string[] xamlPaths)
		{
			ProjectPath = projectPath;
			XamlPaths = xamlPaths;
		}

		public string ProjectPath { get; set; }

		public string[] XamlPaths { get; set; }

		public string Scope => "hotreload";

		string IMessage.Name => Name;
	}
}