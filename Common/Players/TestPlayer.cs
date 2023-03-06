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
        public bool isNPCGray;

        public override void Initialize()
        {
            base.Initialize();
            isGBlur = false;
            isNPCGray = false;
        }

        public override bool PreHurt(bool pvp, bool quiet, ref int damage, ref int hitDirection, ref bool crit, ref bool customDamage, ref bool playSound, ref bool genGore, ref PlayerDeathReason damageSource, ref int cooldownCounter)
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

            //if (!Filters.Scene["TestMod:GBlur"].IsActive())
            //{
            //    // 开启滤镜
            //    Filters.Scene.Activate("TestMod:GBlur");
            //}
            if (isGBlur)
            {
                // 开启滤镜
                Filters.Scene.Activate("TestMod:GBlur");
            }
            else
            {
                // 关闭滤镜
                Filters.Scene.Deactivate("TestMod:GBlur");
            }
        }
    }
}
