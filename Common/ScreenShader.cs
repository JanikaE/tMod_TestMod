using Microsoft.Xna.Framework.Graphics;
using Terraria;
using Terraria.Graphics.Shaders;

namespace TestMod.Common.Effects
{
    internal class ScreenShader : ScreenShaderData
    {
        public ScreenShader(string passName) : base(passName)
        {
        }

        public ScreenShader(Ref<Effect> shader, string passName) : base(shader, passName)
        {
        }

        public override void Apply()
        {
            base.Apply();
        }
    }
}
