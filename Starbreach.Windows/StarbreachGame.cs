// Copyright (c) Silicon Studio Corp. (https://www.siliconstudio.co.jp)
// Distributed under the MIT license. See the LICENSE.md file in the project root for more information.
using Stride.Engine;
using Stride.Games;
using Stride.Graphics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace Starbreach
{
    public class StarbreachGame : Game, IStarbreach
    {
        public Entity PlayerUiEntity { get; private set; }


        public StarbreachGame()
        {
            IsFixedTimeStep = true;
            IsDrawDesynchronized = true;
        }

        //工具方法 保存图片到地址
        public void SaveTexture(Texture texture, string path, ImageFileType fileType)
        {
            using (var stream = File.Create(path))
            {
                texture.Save(GraphicsContext.CommandList, stream, fileType);
            }
        }

        //Game Create => Initialize => GraphicDevice Availlable => LoadContent
        protected override void Initialize()
        {
            base.Initialize();

            Services.AddService<IStarbreach>(this);
        }

        protected override Task LoadContent()
        {
            return base.LoadContent();
        }

        protected override void BeginRun()
        {
            Scene uiScene = Content.Load<Scene>("UI/UISceneSoldier");
            PlayerUiEntity = uiScene.Entities.First(x => x.Name == "UI");

            base.BeginRun();
        }

        protected override void Draw(GameTime gameTime)
        {
            base.Draw(gameTime);
        }

        protected override void Update(GameTime gameTime)
        {
            base.Update(gameTime);
        }

        protected override void Destroy()
        {
            base.Destroy();
        }
    }
}
