using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using TestMod.Content.Buffs;

namespace TestMod.Content.Items.Accessory
{
    public class Door : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("take the door");
            DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "把门带上");
            //Tooltip.SetDefault("+100hp\n" + "+10def");
        }

        public override void SetDefaults()
        {
            Item.accessory = true;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        public override void UpdateAccessory(Player player, bool hideVisual)
        {
            player.statLifeMax2 += 100;
            player.statDefense += 10;
            player.AddBuff(ModContent.BuffType<LockBlood>(), 10);
        }
    }
}
