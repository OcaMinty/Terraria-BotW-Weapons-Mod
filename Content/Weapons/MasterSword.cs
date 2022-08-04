using OneHitObliterator.Content.Projectiles;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Weapons
{
	public class MasterSword : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("The Legendary sword that seals the darkness. Its blade gleams with a sacred luster that can oppose the Calamity. Only a hero chosen by the sword itself may wield it.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 30;
			Item.DamageType = DamageClass.Melee;
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.noMelee = false;
			Item.knockBack = 4.0f;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<MasterSwordProjectile>();
			Item.shootSpeed = 20;
			Item.crit = 32;
			Item.mana = 11;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.IronBar, 5)
				.AddIngredient(ItemID.DemoniteBar, 5)
				.AddIngredient(ItemID.Amethyst, 5);

			CreateRecipe()
				.AddIngredient(ItemID.LeadBar, 5)
				.AddIngredient(ItemID.DemoniteBar, 5)
				.AddIngredient(ItemID.Amethyst, 5)
				.Register();
		}
	}
}