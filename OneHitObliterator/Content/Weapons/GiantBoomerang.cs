using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using OneHitObliterator.Content.Projectiles;
using Microsoft.Xna.Framework;

namespace OneHitObliterator.Content.Weapons
{
    internal class GiantBoomerang : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Giant Boomerang");
			Tooltip.SetDefault("This is a modded flail with normal behavior.");
			SacrificeTotal = 1;

			ItemID.Sets.ToolTipDamageMultiplier[Type] = 2f;
		}

		public override void SetDefaults()
		{
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 45; 
			Item.useTime = 45; 
			Item.knockBack = 6.75f; 
			Item.width = 30; 
			Item.height = 10; 
			Item.damage = 25; 
			Item.knockBack = 40;
			Item.crit = 7;
			Item.scale = 1.1f;
			Item.noUseGraphic = true;
			Item.shoot = ModContent.ProjectileType<GiantBoomerangProjectile>();
			Item.shootSpeed = 12f;
			Item.UseSound = SoundID.Item1;
			Item.rare = ItemRarityID.Orange;
			Item.value = Item.sellPrice(gold: 2, silver: 50);
			Item.DamageType = DamageClass.Melee;
			Item.channel = true;
			Item.noMelee = true;
		}

		public override Color? GetAlpha(Color lightColor)
		{
			return Color.White;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Wood, 20)
				.AddIngredient(ItemID.GoldBar, 3)
				.AddIngredient(ItemID.IronBar, 10)
				.AddTile(TileID.WorkBenches);

			CreateRecipe()
				.AddIngredient(ItemID.Wood, 20)
				.AddIngredient(ItemID.GoldBar, 3)
				.AddIngredient(ItemID.TinBar, 10)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
