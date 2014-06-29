using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BananaBoat.GameObjects
{
	public abstract class AbstractGameObject
	{
		private int id { get; set; }
		private float x { get; set; }
		private float y { get; set; }

		public abstract bool Update();
		public abstract bool Render();
	}
}
