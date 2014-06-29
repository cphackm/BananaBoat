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
		private static int nextObjectId = 0;

		public static int GetNextObjectId()
		{
			return nextObjectId++;
		}
	}
}
