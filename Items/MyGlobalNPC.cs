using Terraria;
using Terraria.ID;
using Terraria.ModLoader;
using Terraria.GameContent.ItemDropRules;
using wuxing.Items.Elements;

namespace wuxing.Items
{
    public class MyGlobalNPC : GlobalNPC
    {
        public override void ModifyGlobalLoot(GlobalLoot npcLoot)
        {
            Player player = new Player();
            if (player.ZoneRockLayerHeight)
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Metel>()));
            else if (player.ZoneRockLayerHeight)
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Wood>()));
            else if(player.ZoneBeach)
                npcLoot.Add(ItemDropRule.Common(ItemID.Wood));
            else if (player.ZoneUnderworldHeight)
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Fire>()));
            else if (player.ZoneOverworldHeight)
                npcLoot.Add(ItemDropRule.Common(ModContent.ItemType<Earth>()));
        }
        
    }
}
