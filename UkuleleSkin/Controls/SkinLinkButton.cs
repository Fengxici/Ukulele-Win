using System;
using System.Windows;

namespace UkuleleSkin.Controls
{
    public class SkinLinkButton : SkinSystemButton
    {
        public bool SkinDisplayLine
        {
            get { return (bool)GetValue(SkinDisplayLineProperty); }
            set { SetValue(SkinDisplayLineProperty, value); }
        }
        public static readonly DependencyProperty SkinDisplayLineProperty =
            DependencyProperty.Register("SkinDisplayLine", typeof(bool), typeof(SkinLinkButton), new PropertyMetadata(true));
    }
}
