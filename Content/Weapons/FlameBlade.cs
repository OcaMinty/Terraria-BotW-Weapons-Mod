using OneHitObliterator.Content.Projectiles;
using Terraria;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Weapons
{
	public class FlameBlade : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Flameblade");
			Tooltip.SetDefault("This magical sword was forged in the lava of Death Mountain. It leaves white-hot flames in its wake when the blade glows red.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 24;
			Item.knockBack = 3.6f;
			Item.useStyle = ItemUseStyleID.Rapier;
			Item.useAnimation = 12;
			Item.useTime = 12;
			Item.width = 32;
			Item.height = 32;
			Item.UseSound = SoundID.Item1;
			Item.DamageType = DamageClass.Magic;
			Item.autoReuse = false;
			Item.noUseGraphic = true;
			Item.noMelee = true;
			Item.mana = 10;

			Item.rare = ItemRarityID.White;
			Item.value = Item.sellPrice(0, 0, 0, 10);

			Item.shoot = ModContent.ProjectileType<FlameBladeProjectile>(); 
			Item.shootSpeed = 2.1f; 
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.PalladiumBar, 3)
				.AddIngredient(ItemID.Wood, 1)
				.AddTile(TileID.AdamantiteForge)
				.Register();
		}
        public override void OnHitNPC(Player player, NPC target, int damage, float knockBack, bool crit)
        {
			target.AddBuff(BuffID.Burning, 600);
			target.AddBuff(BuffID.OnFire, 600);
        }
    }
}