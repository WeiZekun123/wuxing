using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using ReLogic.Content;
using System;
using Terraria;
using Terraria.Audio;
using Terraria.GameContent;
using Terraria.GameContent.UI.Elements;
using Terraria.ID;
using Terraria.Localization;
using Terraria.ModLoader;
using Terraria.UI;

namespace wuxing.Items.UI
{
    internal class MyUI : UIState
    {
        public override void OnInitialize()
        {   //添加面板
            UIPanel panel = new UIPanel();
            panel.Width.Set(300, 0);
            panel.Height.Set(300, 0);
            panel.VAlign = 0.5f;
            panel.VAlign = 0.2f;
            Append(panel);


            //添加标题
            UIText title = new UIText("wuxing");
            title.HAlign = 0.5f;
            title.Top.Set(15, 0);
            panel.Append(title);
            
            
            UIImageButton button = new UIImageButton(ModContent.GetTexture("Terraria/UI/ButtonPlay"));
            


        }

    }
}
