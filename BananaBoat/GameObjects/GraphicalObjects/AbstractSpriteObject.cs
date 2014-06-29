using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BananaBoat.GameObjects.GraphicalObjects
{
	public abstract class AbstractSpriteObject : AbstractGameObject
	{
		protected float x { set; get; }
		protected float y { set; get; }
		protected float angle { set; get; }
		protected float scale { set; get; }
		protected Color color { set; get; }

		public abstract void Update();
		public abstract void Render();
	}
}
