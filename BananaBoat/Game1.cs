﻿#region Using Statements
using System;
using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Storage;
using Microsoft.Xna.Framework.GamerServices;

using BananaBoat.GameManagers;
using BananaBoat.GameLevels;
using BananaBoat.GameObjects;
using BananaBoat.GameChunks;
#endregion

namespace BananaBoat
{
	/// <summary>
	/// This is the main type for your game
	/// </summary>
	public class Game1 : Game
	{
		GraphicsDeviceManager graphics;

		public Game1()
			: base()
		{
			graphics = new GraphicsDeviceManager(this);
			Content.RootDirectory = "Content";
		}

		/// <summary>
		/// Allows the game to perform any initialization it needs to before starting to run.
		/// This is where it can query for any required services and load any non-graphic
		/// related content.  Calling base.Initialize will enumerate through any components
		/// and initialize them as well.
		/// </summary>
		protected override void Initialize()
		{
			// Initialize the render manager
			GameManager.InitGameManager();
			RenderManager.InitRenderManager(GraphicsDevice, this.Content);
			InputManager.InitInputManager();

			InputManager.BindInputs("test", Keys.Space, Buttons.A, PlayerIndex.One);

			base.Initialize();
		}

		/// <summary>
		/// LoadContent will be called once per game and is the place to load
		/// all of your content.
		/// </summary>
		protected override void LoadContent()
		{
			RenderManager.LoadTexture("test", "walmartGuyRunWithGun");
		}

		/// <summary>
		/// UnloadContent will be called once per game and is the place to unload
		/// all content.
		/// </summary>
		protected override void UnloadContent()
		{
			// TODO: Unload any non ContentManager content here
		}

		/// <summary>
		/// Allows the game to run logic such as updating the world,
		/// checking for collisions, gathering input, and playing audio.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Update(GameTime gameTime)
		{
			if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
				Exit();

			GameManager.UpdateGameManager(gameTime);
			InputManager.UpdateInputManager();

			base.Update(gameTime);
		}

		/// <summary>
		/// This is called when the game should draw itself.
		/// </summary>
		/// <param name="gameTime">Provides a snapshot of timing values.</param>
		protected override void Draw(GameTime gameTime)
		{
			GraphicsDevice.Clear(Color.CornflowerBlue);

			RenderManager.BeginRender();

			if (InputManager.IsInputHeld("test"))
			{
				RenderManager.DrawQuad("test", Vector2.Zero, Vector2.One, RenderManager.OriginKeys.topLeft);
			}
			if (InputManager.IsInputHit("test"))
			{
				RenderManager.DrawQuad("test", new Vector2(0.0f, 64.0f), Vector2.One, RenderManager.OriginKeys.topLeft);
			}

			RenderManager.EndRender();

			base.Draw(gameTime);
		}
	}
}
