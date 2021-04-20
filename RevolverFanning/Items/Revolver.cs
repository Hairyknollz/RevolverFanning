using Microsoft.Xna.Framework;
using Terraria;
using Terraria.ID;
using Terraria.ModLoader;

namespace RevolverFanning.Items
{
    public class Revolver : ModItem
    {
        public override void SetDefaults()
        {
            item.CloneDefaults(ItemID.Revolver);
            item.autoReuse = true;
            item.useAnimation = 48;
            item.useTime = 8;
            item.reuseDelay = 80;
            item.UseSound = mod.GetLegacySoundSlot(SoundType.Item, "Sounds/Item/BurstFire");
        }

        //public override void AddRecipes()
        //{
        //    ModRecipe recipe = new ModRecipe(mod);
        //    recipe.AddIngredient(ItemID.Wood);
        //    recipe.AddTile(TileID.WorkBenches);
        //    recipe.SetResult(this);
        //    recipe.AddRecipe();
        //}
    }
}
