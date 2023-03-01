using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace TestMod.Content.Buffs
{
    internal class LockBloodCD : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LockBloodCD...");
            DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "锁血CD中...");
            Description.SetDefault("...");
            Description.AddTranslation((int)GameCulture.CultureName.Chinese, "别急");

            Main.buffNoSave[Type] = false;
            Main.debuff[Type] = true;
            Main.lightPet[Type] = false;
            Main.vanityPet[Type] = false;
        }
    }
}
