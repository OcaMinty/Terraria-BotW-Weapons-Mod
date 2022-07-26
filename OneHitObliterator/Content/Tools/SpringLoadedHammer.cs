using Terraria;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Terraria.ModLoader;

namespace OneHitObliterator.Content.Tools
{
	public class SpringLoadedHammer : ModItem
	{
		public override void SetStaticDefaults()
		{
			DisplayName.SetDefault("Spring-Loaded Hammer");
			Tooltip.SetDefault("This strange hammer is one of Kilton's specialties. Being struck by it doesn't hurt much, but will send the victim flying.");

			CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
		}

		public override void SetDefaults()
		{
			Item.damage = 1;
			Item.DamageType = DamageClass.Melee;
			Item.width = 40;
			Item.height = 40;
			Item.useTime = 15;
			Item.useAnimation = 15;
			Item.useStyle = ItemUseStyleID.Swing;
			Item.knockBack = 999999999999999999;
			Item.value = 10000;
			Item.rare = ItemRarityID.Green;
			Item.UseSound = SoundID.Item1;
			Item.autoReuse = true;

			Item.axe = 30; 
			Item.hammer = 100; 
		}

		public override void AddRecipes()
		{
			CreateRecipe()
				.AddIngredient(ItemID.IronHammer, 1)
				.AddIngredient(ItemID.PinkGel, 6)
				.AddTile(TileID.WorkBenches)
				.Register();
		}
	}
}
