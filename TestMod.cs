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

        public override void Load()
        {
            base.Load();

            // ScreenShader
            // ע��������ȷ��Pass���֣�Scene�����ֿ����������ͱ��Mod�Լ�ԭ���ͻ����
            Filters.Scene["TestMod:GBlur"] = new Filter(
                new ScreenShader(new Ref<Effect>(ModContent.Request<Effect>("TestMod/Common/Effects/Content/GBlur", AssetRequestMode.ImmediateLoad).Value), "Test"), 
                EffectPriority.Medium);
            Filters.Scene["TestMod:GBlur"].Load();

            // NPCShader
            NPCEffect = ModContent.Request<Effect>("TestMod/Common/Effects/Content/Player", AssetRequestMode.ImmediateLoad).Value;
        }
    }
}