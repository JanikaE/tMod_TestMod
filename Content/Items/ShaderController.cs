using Terraria;
using Terraria.Graphics.Effects;
using Terraria.ID;
using Terraria.ModLoader;
using TestMod.Common.Players;

namespace TestMod.Content.Items
{
    internal class ShaderController : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Shader Controller");
            Tooltip.SetDefault("Left:GBlur\n" +
                                "Right:NPC Gray");
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
            if (player.altFunctionUse == 0)
            {
                player.GetModPlayer<TestPlayer>().isGBlur = !player.GetModPlayer<TestPlayer>().isGBlur;
            }
            else if (player.altFunctionUse == 2)
            {
                player.GetModPlayer<TestPlayer>().isNPCGray = !player.GetModPlayer<TestPlayer>().isNPCGray;
            }            
            return true;
        }

        public override bool AltFunctionUse(Player player)
        {
            return true;
        }
    }
}
