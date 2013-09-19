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

        private Vector2 position = new Vector2(100, 100);


        private KeyboardState prevKeyboard;

        public Player(Game game)
            : base(game)
        {
        }

        public override void Initialize()
        {
            Settings settings = (Settings)this.Game.Services.GetService(typeof(Settings));
            spriteBatch = (SpriteBatch)this.Game.Services.GetService(typeof(SpriteBatch));

            prevKeyboard = Keyboard.GetState();

            base.Initialize();
        }

        protected override void LoadContent()
        {
            this.img = this.Game.Content.Load<Texture2D>("Capture");

            base.LoadContent();
        }

        public override void Update(GameTime gameTime)
        {
            KeyboardState ks = Keyboard.GetState();

            if (prevKeyboard.IsKeyUp(Keys.D) && ks.IsKeyDown(Keys.D))
                this.position.X += 5 * (float)gameTime.ElapsedGameTime.TotalSeconds;


            prevKeyboard = ks;
            base.Update(gameTime);
        }

        public override void Draw(GameTime gameTime)
        {
            this.spriteBatch.Draw(this.img, position, Color.White);

            base.Draw(gameTime);
        }
    }
}
