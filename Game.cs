using System;
using OpenTK;
using OpenTK.Windowing.Common;
using OpenTK.Windowing.Desktop;
using OpenTK.Graphics.OpenGL;
using OpenTK.Mathematics;

namespace OpenTKTest
{
    public class Game : GameWindow
    {
        public Game()
            : base(GameWindowSettings.Default, NativeWindowSettings.Default)
        {
            //centeres window and vector2i(resolution, resolution);
            this.CenterWindow(new Vector2i(1920, 1080));
        }
        // method to update the frame
        protected override void OnUpdateFrame(FrameEventArgs args)
        {
            base.OnUpdateFrame(args);
        }
        // method to render on the frame
        protected override void OnRenderFrame(FrameEventArgs args)
        {
            GL.ClearColor(new Color4(0.2f, 0.1f, 0.5f, 1f));
            GL.Clear(ClearBufferMask.ColorBufferBit);
            // take back buffer to show on unts screen
            this.Context.SwapBuffers();
            base.OnRenderFrame(args);
        }
    }
}
