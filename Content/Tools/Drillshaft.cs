using OneHitObliterator.Content.Projectiles;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent.Creative;
using Terraria.ID;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Tools
{
	public class Drillshaft : ModItem
	{
		public override void SetStaticDefaults()
		{
			Tooltip.SetDefault("WIP does not work as intended. Still works as weapon.");

			ItemID.Sets.SkipsInitialUseSound[Item.type] = true;
			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.rare = ItemRarityID.Pink;
			Item.value = Item.sellPrice(silver: 10);

			Item.useStyle = ItemUseStyleID.Shoot;
			Item.useAnimation = 12;
			Item.useTime = 18;
			Item.UseSound = SoundID.Item71;
			Item.autoReuse = true;

			Item.damage = 14;
			Item.knockBack = 5.0f;
			Item.noUseGraphic = true;
			Item.DamageType = DamageClass.MeleeNoSpeed;
			Item.noMelee = false; 

			Item.shootSpeed = 3.7f;
			Item.shoot = ModContent.ProjectileType<DrillshaftProjectile>();

			Item.pick = 100;
		}

		public override bool CanUseItem(Player player)
		{
			return player.ownedProjectileCounts[Item.shoot] < 1;
		}

		public override bool? UseItem(Player player)
		{
			if (!Main.dedServ && Item.UseSound.HasValue)
			{
				SoundEngine.PlaySound(Item.UseSound.Value, player.Center);
			}

			return null;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.GoldBar, 5)
				.AddIngredient(ItemID.LeadBar, 5)
				.AddTile(TileID.Anvils)
				.Register();
		}
	}
}