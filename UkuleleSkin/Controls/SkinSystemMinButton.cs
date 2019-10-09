using System;
using System.Windows;

namespace UkuleleSkin.Controls
{
    public class SkinSystemMinButton : SkinSystemButton
    {
        Window targetWindow;
        public SkinSystemMinButton()
        {
            Click += delegate
            {
                if (targetWindow == null)
                {
                    targetWindow = Window.GetWindow(this);
                }
                targetWindow.WindowState = WindowState.Minimized;
            };
        }
    }
}
