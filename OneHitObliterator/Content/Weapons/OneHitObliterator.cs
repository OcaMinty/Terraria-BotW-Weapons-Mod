using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;

namespace OneHitObliterator.Content.Weapons
{
    internal class OneHitObliterator : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("One Hit Obliterator");
            Tooltip.SetDefault("A sacred weapon told to slay any foe in one swing\n'Link, wake up..'");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.width = 32;
            Item.height = 32;

            Item.useStyle = ItemUseStyleID.Swing;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.autoReuse = true;

            Item.DamageType = DamageClass.Melee;
            Item.damage = 99999999;
            Item.knockBack = 999999999999999999999999999999999999f;
            Item.crit = 5;

            Item.value = Item.buyPrice(gold: 20, copper: 1);
            Item.rare = ItemRarityID.Purple;

            Item.UseSound = SoundID.Item1;


        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LunarBar, 15)
                .AddIngredient(ItemID.Diamond, 5)
                .AddTile(TileID.LunarCraftingStation)
                .Register();
        }
        public override void UpdateInventory(Player player)
        {
            player.statLife = 1;
        }
    }
}
