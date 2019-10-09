using System;
using System.Windows;
using System.Windows.Media;

namespace UkuleleSkin.Controls
{
    public class SkinSystemCloseButton : SkinSystemButton
    {
        Window targetWindow;
        public SkinSystemCloseButton()
        {
            SkinSystemButtonHoverColor = new SolidColorBrush(Color.FromArgb(255, 255, 0, 0));

            Click += delegate {
                if (targetWindow == null)
                {
                    targetWindow = Window.GetWindow(this);
                }
                targetWindow.Close();
            };
        }
    }
}
