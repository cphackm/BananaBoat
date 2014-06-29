using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;

using BananaBoat.GameManagers;
using BananaBoat.GameObjects;

namespace BananaBoat.GameLevels
{
	public abstract class AbstractGameLevel
	{
		protected List<GameObjects.AbstractGameObject> objects;
		protected Dictionary<string, GameObjects.AbstractGameObject> objectsByType;

		public virtual bool RegisterGameObject(GameObjects.AbstractGameObject GameObject)
		{
			GameObject.id = GameManagers.GameManager.GetNextObjectId();

			objects.Add(GameObject);
			objectsByType.Add(GameObject.objectType, GameObject);

			return true;
		}

		public virtual void Update()
		{
			foreach (GameObjects.AbstractGameObject ago in objects)
			{
				ago.Update();
			}
		}

		public virtual void Render()
		{
			foreach (GameObjects.AbstractGameObject ago in objects)
			{
				ago.Render();
			}
		}
	}
}
