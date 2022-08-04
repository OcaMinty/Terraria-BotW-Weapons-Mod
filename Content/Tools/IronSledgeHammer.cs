using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Tools
{
	public class IronSledgeHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Iron Sledgehammer");
			Tooltip.SetDefault("This large iron sledgehammer was originally used for mining, but it works reasonably well as a weapon too.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 18;
			Item.knockBack = 3.6f;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 1;
			Item.useAnimation = 10;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.value = Item.buyPrice(gold: 1);
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Item.pick = 15;
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.IronBar, 10)
				.AddIngredient(ItemID.Wood, 2)
				.AddTile(TileID.Anvils)
				.Register();

			CreateRecipe()
				.AddIngredient(ItemID.TinBar, 10)
				.AddIngredient(ItemID.Wood, 2)
				.Register();
		}
        public override bool? UseItem(Player player)
        {
			player.AddBuff(BuffID.Spelunker, 20);
			return true;
        }
    }
}