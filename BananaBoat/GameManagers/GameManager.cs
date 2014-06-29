using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BananaBoat.GameManagers
{
	public class GameManager
	{
		private static Dictionary<string, object> globalStates;
		private static int nextObjectId;

		public static void InitGameManager()
		{
			globalStates = new Dictionary<string, object>();
			nextObjectId = 0;
		}

		public static void SetGlobalState(string Key, object Value)
		{
			globalStates.Add(Key, Value);
		}

		public static T GetGlobalState<T>(string Key)
		{
			return (T)globalStates[Key];
		}

		public static int GetNextObjectId()
		{
			return nextObjectId++;
		}
	}
}
