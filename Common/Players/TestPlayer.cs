using Terraria;
using Terraria.DataStructures;
using Terraria.Graphics.Effects;
using Terraria.ModLoader;
using TestMod.Content.Buffs;

namespace TestMod.Common.Players
{
    internal class TestPlayer : ModPlayer
    {
        public bool isGBlur;

        public override void Initialize()
        {
            base.Initialize();
            isGBlur = false;
        }

        [System.Obsolete]
        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource)
        {
            if (Player.HasBuff<LockBlood>() && !Player.HasBuff<LockBloodCD>() && damage > Player.statLife)
            {
                damage = 1;
                Player.statLife = Player.statLifeMax2 / 2;
                Player.AddBuff(ModContent.BuffType<LockBloodCD>(), 1200);
            }
            return false;
        }

        public override void PreUpdate()
        {
            base.PreUpdate();

            if (!Filters.Scene["TestMod:GBlur"].IsActive() && isGBlur)
            {
                // 开启滤镜
                Filters.Scene.Activate("TestMod:GBlur");
            }
            if (Filters.Scene["TestMod:GBlur"].IsActive() && !isGBlur)
            {
                // 关闭滤镜
                Filters.Scene.Deactivate("TestMod:GBlur");
            }
        }
    }
}
