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
			Item.autoReuse = true; // Automatically re-swing/re-use this item after its swinging animation is over.

			Item.axe = 30; // How much axe power the weapon has, note that the axe power displayed in-game is this value multiplied by 5
			Item.hammer = 100; // How much hammer power the weapon has
		}

		// Please see Content/ExampleRecipes.cs for a detailed explanation of recipe creation.
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