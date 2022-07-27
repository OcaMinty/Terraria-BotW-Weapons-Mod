using OneHitObliterator.Content.Projectiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Weapons
{
	public class ThunderBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Thunderblade");
			Tooltip.SetDefault("A magical sword forged and refined by lightning from the Hyrule Hills. When the blade shines with a golden light, it will electrocute enemies struck by it.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 22;
			Item.knockBack = 3.6f;
			Item.useStyle = ItemUseStyleID.Rapier;
			Item.useAnimation = 12;
			Item.useTime = 12;
			Item.width = 32;
			Item.height = 32;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.MeleeNoSpeed;
			Item.autoReuse = false;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.mana = 10;

			Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(0, 0, 0, 10);

			Item.shoot = ModContent.ProjectileType<ThunderBladeProjectile>();
			Item.shootSpeed = 2.1f;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.SpectreBar, 3)
				.AddIngredient(ItemID.Wood, 1)
				.AddTile(TileID.AdamantiteForge)
				.Register();
		}
	}
}