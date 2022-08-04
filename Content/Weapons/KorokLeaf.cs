using Terraria;
using Terraria.ModLoader;
using Terraria.ID;
using Terraria.GameContent.Creative;
using Microsoft.Xna.Framework;
using OneHitObliterator.Content.Projectiles;

namespace OneHitObliterator.Content.Weapons
{
    internal class KorokLeaf : ModItem
    {
        public override void SetStaticDefaults()
        {
            DisplayName.SetDefault("Korok Leaf");
            Tooltip.SetDefault("A single swing of this giant, sturdy leaf can create a gust of wind strong enough to blow away light objects.");
            CreativeItemSacrificesCatalog.Instance.SacrificeCountNeededByItemId[Type] = 1;
        }

        public override void SetDefaults()
        {
            Item.damage = 1;
            Item.DamageType = DamageClass.Melee;
            Item.width = 34;
            Item.height = 40;
            Item.useTime = 20;
            Item.useAnimation = 20;
            Item.useStyle = ItemUseStyleID.Swing;
            Item.noMelee = false;
            Item.knockBack = 999999f;
            Item.value = 10000;
            Item.rare = ItemRarityID.LightRed;
            Item.UseSound = SoundID.Item1;
            Item.autoReuse = true;
            Item.shoot = ModContent.ProjectileType<KorokLeafProjectile>();
            Item.shootSpeed = 20;
            Item.crit = 32;
        }

        public override void AddRecipes()
        {
            CreateRecipe()
                .AddIngredient(ItemID.LeafWand, 1)
                .AddIngredient(ItemID.Wood, 5)
                .Register();
        }
    }
}
