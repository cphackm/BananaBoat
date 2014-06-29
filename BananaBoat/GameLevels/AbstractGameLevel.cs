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
		protected static Dictionary<string, object> levelStates;

		protected List<AbstractGameObject> objects;
		protected Dictionary<Type, List<AbstractGameObject>> objectsByType;

		public static void SetLevelState(string Key, object Value)
		{
			if (levelStates.ContainsKey(Key))
			{
				levelStates[Key] = Value;
			}
			else
			{
				levelStates.Add(Key, Value);
			}
		}

		public static T GetLevelState<T>(string Key)
		{
			return (T)levelStates[Key];
		}

		public virtual bool RegisterGameObject(AbstractGameObject GameObject)
		{
			GameObject.id = GameManagers.GameManager.GetNextObjectId();
			objects.Add(GameObject);

			Type objType = GameObject.GetType();

			if (!objectsByType.ContainsKey(objType))
			{
				objectsByType.Add(objType, new List<AbstractGameObject>());
			}

			objectsByType[objType].Add(GameObject);

			return true;
		}

		public virtual T GetGameObjectById<T>(int Id) where T : AbstractGameObject
		{
			return (T)objects.Find(ago => ago.id == Id );
		}

		public virtual List<T> GetGameObjectsByType<T>() where T : AbstractGameObject
		{
			return objectsByType[typeof(T)].Cast<T>().ToList();
		}

		public virtual void Update()
		{
			foreach (AbstractGameObject ago in objects)
			{
				ago.Update();
			}
		}

		public virtual void Render()
		{
			foreach (AbstractGameObject ago in objects)
			{
				ago.Render();
			}
		}
	}
}
