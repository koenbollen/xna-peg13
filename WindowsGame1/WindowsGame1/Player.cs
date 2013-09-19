using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Audio;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.GamerServices;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using Microsoft.Xna.Framework.Media;


namespace WindowsGame1
{
    public class Player : DrawableGameComponent
    {

        SpriteBatch spriteBatch;

        private Texture2D img;

        private Vector2 position;

        public Player(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
            base.Initialize();
        }

        protected override void LoadContent()
        {
            spriteBatch = new SpriteBatch(GraphicsDevice);
            this.img = this.Game.Content.Load<Texture2D>("Capture");

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            position += new Vector2(10, 0) * (float)gameTime.ElapsedGameTime.TotalSeconds;
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Begin();

            this.spriteBatch.Draw(this.img, position, Color.White);

            this.spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
