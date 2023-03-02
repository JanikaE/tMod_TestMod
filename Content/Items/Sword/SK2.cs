using Microsoft.Xna.Framework;
using System;
using Terraria;
using Terraria.DataStructures;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using TestMod.Content.Projectiles;

namespace TestMod.Content.Items.Sword
{
    public class SK2 : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Sword2.0");
            DisplayName.AddTranslation((int)GameCulture.CultureName.Chinese, "二代剑");
            Tooltip.SetDefault("wood");
            Tooltip.AddTranslation((int)GameCulture.CultureName.Chinese, "木制");
        }

        public override void SetDefaults()
        {
            Item.width = 75;
            Item.height = 75;

            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.UseSound = SoundID.Item1;

            Item.value = 10000;
            Item.rare = ItemRarityID.Orange;

            Item.damage = 100;
            Item.DamageType = DamageClass.Melee;
            Item.knockBack = 6;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<Bubble>();
            Item.shootSpeed = 100f;
        }

        public override void AddRecipes()
        {
            Recipe recipe = CreateRecipe();
            recipe.AddIngredient(ModContent.ItemType<SK1>(), 1);
            recipe.AddIngredient(ItemID.Wood, 2);
            recipe.AddTile(TileID.WorkBenches);
            recipe.Register();
        }

        public override void MeleeEffects(Player player, Rectangle hitbox)
        {
            //Vector2 mouse = Main.screenPosition + new Vector2((float)Main.mouseX, (float)Main.mouseY);
            Dust dust = Dust.NewDustDirect(player.position, 40, 40, DustID.Water);
            dust.noGravity = true;
        }

        public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
        {
            //velocity.Normalize();
            float x = velocity.X;
            float y = velocity.Y;
            float r = (float)Math.Atan2(y, x);

            for (int i = -2; i <= 2; i++)
            {
                float r2 = r + i * MathHelper.Pi / 36f;
                velocity = r2.ToRotationVector2() * 5;
                Projectile.NewProjectile(source, position, velocity, type, 50, knockback, player.whoAmI);
            }
            return false;
        }
    }
}