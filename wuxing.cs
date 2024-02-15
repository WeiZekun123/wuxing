using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.ModLoader;
using Terraria.UI;
using wuxing.Items.UI;

namespace wuxing
{
    
    public class wuxing : Mod
	{
		public static float AddDamage = 0f;//����
		public static int MiningSpeed = 0;//�ھ��ٶ�
        public static int LifeMax = 0;//�������
        public static int LifeRegenSpeed = 0;//�����ָ�
		public static float MovingSpeed = 0f;//�ƶ��ٶ�
		public static float Crit = 0f;//������
		public static int Defense = 0;//����
		public static float Endurcance = 0f;//����
        internal static MyUI myUI;
        //����һ������ΪUserInterface�ı���
        public static bool Visible = false;




        public void SetNumber(int Metel, int Wood1, int Wood2, int Water, int Fire1, int Fire2, int Earth1, int Earth2)
		{
			//ǰ��ε�Switch�Ǹ��ݵȼ�������Ӧbuff�ĳ�ֵ
			switch (Metel)
			{
				case 1:
                    MiningSpeed = 15;
					break;
				case 2:
					MiningSpeed = 25;
					break;
				case 3:
					MiningSpeed = 30;
					break;
            }
			switch (Wood1) 
			{
				case 1:
					LifeRegenSpeed = 4;
					break;
				case 2:
					LifeRegenSpeed = 6;
					break;
				case 3:
					LifeRegenSpeed = 8;
					break;
			}
			switch (Wood2)
			{
				case 1:
					LifeMax = 50;
					break;
				case 2:
					LifeMax = 100;
				    break;
				case 3:
					LifeMax = 150;
					break;
			}
			switch(Water) 
			{
				case 1:
					MovingSpeed = 0.1f;
					break;
                case 2:
                    MovingSpeed = 0.2f;
                    break;
                case 3:
                    MovingSpeed = 0.25f;
                    break;
            }
            switch (Fire1)
            {
                case 1:
					Crit = 0.05f;
                    break;
                case 2:
					Crit = 0.1f;
                    break;
                case 3:
					Crit = 0.15f;
                    break;
            }
            switch (Fire2)
            {
                case 1:
					AddDamage = 0.05f;
                    break;
                case 2:
					AddDamage = 0.1f;
                    break;
                case 3:
					AddDamage = 0.15f;
                    break;
            }
            switch (Earth1)
            {
                case 1:
					Defense = 10;
                    break;
                case 2:
					Defense = 20;
                    break;
                case 3:
					Defense= 35;
                    break;
            }
            switch (Earth2)
            {
                case 1:
					Endurcance = 0.05f;
                    break;
                case 2:
					Endurcance = 0.1f;
                    break;
                case 3:
					Endurcance = 0.15f;
                    break;
            }
            //�Ӵ˴���ʼ������˵�����
            //�߼���������ֵ=ԭ��ֵ+ԭ��ֵ*��0.25�ġ�����Ԫ�ص�Ԫ�صȼ����η���-ԭ��ֵ*��0.2�ġ��˴�Ԫ�ص�Ԫ�صȼ����η���
            MiningSpeed = (int)(MiningSpeed + MiningSpeed * Math.Pow(0.25, (Earth1 + Earth2) / 2) - MiningSpeed* Math.Pow(0.2,Fire1+Fire2));
			LifeMax = (int)(LifeMax + LifeMax * Math.Pow(0.25, Water) - LifeMax * Math.Pow(0.2, Metel));
			LifeRegenSpeed = (int)(LifeRegenSpeed + LifeRegenSpeed * Math.Pow(0.25, Water) - LifeRegenSpeed * Math.Pow(0.2, Metel));
			MovingSpeed = (int)(MovingSpeed + MovingSpeed * Math.Pow(0.25, Metel) - MovingSpeed * Math.Pow(0.2, (Earth1 + Earth2) / 2));
             float Damage = (float)(AddDamage + AddDamage * Math.Pow(0.25, (Wood1 + Wood2) / 2) - AddDamage * Math.Pow(0.2, Water));
			AddDamage = (float)Math.Round(Damage, 2);
            float C = (float)(Crit + Crit * Math.Pow(0.25, (Wood1 + Wood2) / 2) - Crit * Math.Pow(0.2, Water));
			Crit = (float)Math.Round(C, 2);
            Defense = (int)(Defense + (Defense * Math.Pow(0.25, (Fire1 + Fire2) / 2)) - (Defense * Math.Pow(0.2, (Wood1 + Wood2) / 2)));
            Endurcance = (int)(Endurcance + (Endurcance * Math.Pow(0.25, (Fire1 + Fire2) / 2)) - (Endurcance * Math.Pow(0.2, (Wood1 + Wood2) / 2)));


        }	
		

		


	}
}