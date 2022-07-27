using OneHitObliterator.Content.Projectiles;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;
using Terraria;
using Terraria.DataStructures;
using Microsoft.Xna.Framework;

namespace OneHitObliterator.Content.Bows
{
	public class DuplexBow : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Duplex Bow");
			Tooltip.SetDefault("A bow favored by the skilled archers of the Yiga Clan. It's been engineered to fire two arrows at once to ensure your target comes to a swift and none-too-pleasant halt.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 14;
			Item.DamageType = DamageClass.Ranged;
			Item.width = 34;
			Item.height = 40;
			Item.useTime = 20;
			Item.useAnimation = 20;
			Item.useStyle = ItemUseStyleID.Shoot;
			Item.noMelee = true;
			Item.knockBack = 1.8f;
			Item.value = 10000;
			Item.rare = ItemRarityID.LightRed;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;
			Item.shoot = ProjectileID.IchorArrow;
			Item.shootSpeed = 10;
			Item.crit = 32;
			Item.useAmmo = AmmoID.Arrow;
		}
		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.Wood, 20)
				.AddIngredient(ItemID.WhiteString, 1)
				.AddIngredient(ItemID.GoldBar, 1)
				.Register();
		}
		public override bool Shoot(Player player, EntitySource_ItemUse_WithAmmo source, Vector2 position, Vector2 velocity, int type, int damage, float knockback)
		{
			float numberProjectiles = 2;
			float rotation = MathHelper.ToRadians(2);
			position += Vector2.Normalize(velocity) * 20f;
			for (int i = 0; i < numberProjectiles; i++)
			{
				Vector2 perturbedSpeed = velocity.RotatedBy(MathHelper.Lerp(-rotation, rotation, i / (numberProjectiles - 1))) * 20f; 
				Projectile.NewProjectile(source, position, perturbedSpeed, type, damage, knockback, player.whoAmI);
			}
			return false;
		}
    }
}