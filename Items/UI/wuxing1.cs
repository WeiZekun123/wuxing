using Microsoft.Xna.Framework;
using System;
using System.Collections.Generic;
using Terraria;
using Terraria.GameContent.UI.Elements;
using Terraria.ModLoader;
using Terraria.UI;

namespace wuxing.Items.UI
{
    public class MyModSystem : ModSystem
    {
        public static UserInterface MyUserInterface;
        public static TheUI MyUI;
        public static GameTime _lastUpDateUiGameTime;
        internal MyModSystem uiSystemInstance = ModContent.GetInstance<MyModSystem>();
        
        
        public override void UpdateUI(GameTime gameTime)
        {
            
            if (wuxing.Visible)
            {
                MyUserInterface?.Update(gameTime);
                base.UpdateUI(gameTime);
            }
        }

        public override void ModifyInterfaceLayers(List<GameInterfaceLayer> layers)
        {   //将自定义层添加到vanilla面板
            int MouseTextIndex = layers.FindIndex(layer => layer.Name.Equals("Vanilla: Mouse Text"));
            if (MouseTextIndex != -1)
            {
                layers.Insert(MouseTextIndex, new LegacyGameInterfaceLayer(
                    "wuxing: MyUserInterface",
                    delegate
                {
                    if (wuxing.Visible)
                    {
                        MyUI.Draw(Main.spriteBatch);
                    }
                    return true;
                },
                InterfaceScaleType.UI));
            }
            
        }


        internal void ShowMyUI()
        {   //显示UI的方法
            wuxing.Visible = true;
        }

        internal void HideMyUI()
        {   //隐藏UI的方法
            wuxing.Visible = false;
        }

        
    }



    public class TheUI : UIState
    {
        


        
    }
}
