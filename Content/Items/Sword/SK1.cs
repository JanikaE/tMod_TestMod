using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;

namespace TestMod.Content.Items.Sword
{
    public class SK1 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sword1.0");
            DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "一代剑");
            Tooltip.SetDefault("dirt");
            Tooltip.AddTranslation((int)GameCulture.CultureName.Chinese, "土制");
        }

        public override void SetDefaults()
        {
            Item.width = 40;
            Item.height = 40;

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;

            Item.value = 10000;
            Item.rare = ItemRarityID.Green;

            Item.damage = 50;
            Item.DamageType = DamageClass.Melee;
            Item.knockBack = 6;
            Item.autoReuse = true;
            Item.mana = 4;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ItemID.DirtBlock, 10);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            //Vector2 mouse = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            Dust dust = Dust.NewDustDirect(hitbox.TopLeft(), hitbox.Width, hitbox.Width, DustID.Water, Scale: 5);
            dust.noGravity = true;
        }
    }
}