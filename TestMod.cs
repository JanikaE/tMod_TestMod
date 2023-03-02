using Microsoft.Xna.Framework.Graphics;
using Terraria.Graphics.Effects;
using Terraria;
using Terraria.ModLoader;
using TestMod.Common.Effects;
using ReLogic.Content;

namespace TestMod
{
	public class TestMod : Mod
	{
        public static Effect NPCEffect;
        public static Effect ProjectileEffect;

        public override void Load()
        {
            base.Load();

            // ScreenShader
            // 注意设置正确的Pass名字，Scene的名字可以随便填，不和别的Mod以及原版冲突即可
            Filters.Scene["TestMod:GBlur"] = new Filter(
                new ScreenShader(new Ref<Effect>(ModContent.Request<Effect>("TestMod/Assets/Effects/Content/GBlur", AssetRequestMode.ImmediateLoad).Value), "Test"), 
                EffectPriority.Medium);
            Filters.Scene["TestMod:GBlur"].Load();

            // NPCShader
            NPCEffect = ModContent.Request<Effect>("TestMod/Assets/Effects/Content/NPC", AssetRequestMode.ImmediateLoad).Value;

            // ProjectileShader
            ProjectileEffect = ModContent.Request<Effect>("TestMod/Assets/Effects/Content/Bubble", AssetRequestMode.ImmediateLoad).Value;
        }
    }
}