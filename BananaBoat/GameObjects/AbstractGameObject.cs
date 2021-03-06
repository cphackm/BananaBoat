﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

namespace BananaBoat.GameObjects
{
	public abstract class AbstractGameObject
	{
		public int id { get; set; }

		public abstract void Update();
		public abstract void Render();
	}
}
