using OneHitObliterator.Content.Projectiles;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Bows
{
	public class BowOfLight : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Bow Of Light");
			Tooltip.SetDefault("Princess Zelda gave you this bow and arrow for the battle with Dark beast Ganon. When wielded by the hero, it fires arrows of pure light strong enough to oppose the Calamity.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 100;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.knockBack = 10.0f;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.IchorArrow;
			Item.shootSpeed = 10;
			Item.crit = 32;
			Item.mana = 11;
			Item.useAmmo = AmmoID.Arrow;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.ManaCrystal, 20)
				.AddIngredient(ItemID.FragmentStardust, 1)
				.Register();
		}
	}
}