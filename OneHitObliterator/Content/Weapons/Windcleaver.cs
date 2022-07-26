using OneHitObliterator.Content.Projectiles;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Weapons
{
	public class Windcleaver : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("This is an example magic weapon");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 40;
			Item.DamageType = DamageClass.Melee;
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.noMelee = true;
			Item.knockBack = 25;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<WindcleaverProjectile>();
			Item.shootSpeed = 20;
			Item.crit = 32;
			Item.mana = 11;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.IronOre, 10)
				.AddIngredient(ItemID.CloudinaBottle, 1);

			CreateRecipe()
				.AddIngredient(ItemID.TinOre, 10)
				.AddIngredient(ItemID.CloudinaBottle, 1)
				.Register();
		}
	}
}
