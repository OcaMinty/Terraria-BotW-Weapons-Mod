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
			Item.DamageType = DamageClass.Melee; // Makes the damage register as magic. If your item does not have any damage type, it becomes true damage (which means that damage scalars will not affect it). Be sure to have a damage type.
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Swing; // Makes the player use a 'Shoot' use style for the Item.
			Item.noMelee = true; // Makes the item not do damage with it's melee hitbox.
			Item.knockBack = 25;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ModContent.ProjectileType<WindcleaverProjectile>(); // Shoot a black bolt, also known as the projectile shot from the onyx blaster.
			Item.shootSpeed = 20; // How fast the item shoots the projectile.
			Item.crit = 32; // The percent chance at hitting an enemy with a crit, plus the default amount of 4.
			Item.mana = 11; // This is how much mana the item uses.
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
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