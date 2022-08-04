using Terraria;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using Terraria.ModLoader;
using Terraria.Audio;
using Terraria.ID;

namespace OneHitObliterator.Content
{
    public class MenuBackgroundBotW : ModMenu
    {
        public override Asset<Texture2D> Logo => ModContent.Request<Texture2D>("OneHitObliterator/Content/TitleIcon");

        public override Asset<Texture2D> SunTexture => ModContent.Request<Texture2D>("OneHitObliterator/Content/MajoraMoon");

        public override Asset<Texture2D> MoonTexture => ModContent.Request<Texture2D>("OneHitObliterator/Content/MajoraMoon");

        public override int Music => MusicID.OtherworldlyDay;

        public override ModSurfaceBackgroundStyle MenuBackgroundStyle => null;

        public override string DisplayName => "Zelda ModMenu";
    }
}