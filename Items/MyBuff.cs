using Terraria;
using Terraria.ID;
using Terraria.ModLoader;


namespace wuxing.Items
{
    public class MyBuff : ModBuff {
        public override void SetStaticDefaults()
        {
            Main.buffNoSave[Type] = true;
            Main.debuff[Type] = false;
            BuffID.Sets.NurseCannotRemoveDebuff[Type] = true;
            Main.lightPet[Type] = false;
            Main.buffNoTimeDisplay[Type] = false;
            Main.pvpBuff[Type] = false;
            Main.persistentBuff[Type] = true;
            Main.vanityPet[Type] = false;
        }
        public override void Update(Player player, ref int buffIndex)
        {
            player.statLifeMax2 += wuxing.LifeMax;
            player.statDefense += wuxing.Defense;
            player.GetDamage(DamageClass.Generic) += wuxing.AddDamage;
            player.GetCritChance(DamageClass.Generic) += wuxing.Crit;
            player.moveSpeed += wuxing.MovingSpeed;
            player.lifeRegen += wuxing.LifeRegenSpeed;



            
            

        }
    }
    
    
}
