using Terraria;
using Terraria.ModLoader;
using Terraria.Localization;

namespace TestMod.Content.Buffs
{
    internal class LockBlood : ModBuff
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("LockBlood");
            DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "锁血");
            Description.SetDefault("...");
            Description.AddTranslation((int)GameCulture.CultureName.Chinese, "抵挡一次即死伤害并回复一半的生命值\n" + "有CD");

            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            Main.lightPet[Type] = false;
            Main.vanityPet[Type] = false;
            Main.buffNoTimeDisplay[Type] = true;
        }
    }
}
