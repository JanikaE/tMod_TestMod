using Terraria;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;
using TestMod.Common.Players;

namespace TestMod.Content.Items
{
    internal class ScreenController : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Screen Controller");
            Tooltip.SetDefault("GBlur");
        }

        public override void SetDefaults()
        {
            Item.useTime = 10;
            Item.useAnimation = 10;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;
        }

        public override bool? UseItem(Player player)
        {
            player.GetModPlayer<TestPlayer>().isGBlur = !player.GetModPlayer<TestPlayer>().isGBlur;
            return true;
        }
    }
}
