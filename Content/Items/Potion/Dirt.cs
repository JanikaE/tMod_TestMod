using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TestMod.Content.Items.Potion
{
    internal class Dirt : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("DirtPotion");
            DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "土（不可食用）");
            Tooltip.SetDefault("can't eat");
            Tooltip.AddTranslation((int)GameCulture.CultureName.Chinese, "你吃一个试试");
        }

        public override void SetDefaults()
        {
            Item.width = 20;
            Item.height = 20;
            Item.maxStack = 10;

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.UseSound = SoundID.DD2_CrystalCartImpact;
            Item.useStyle = ItemUseStyleID.EatFood;
            Item.consumable = true;

            Item.value = 100;
            Item.rare = ItemRarityID.Green;

            Item.buffType = BuffID.Ironskin;
            Item.buffTime = 1;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        public override bool CanUseItem(Player player)
        {
            player.Hurt(PlayerDeathReason.ByCustomReason("eat dirt"), 80, 0);
            return true;
        }
    }
}
