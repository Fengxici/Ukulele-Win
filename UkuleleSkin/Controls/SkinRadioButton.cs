using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UkuleleSkin.Controls
{
    public class SkinRadioButton : RadioButton
    {
        public SolidColorBrush IconColor
        {
            get { return (SolidColorBrush)GetValue(IconColorProperty); }
            set { SetValue(IconColorProperty, value); }
        }
        public static readonly DependencyProperty IconColorProperty =
            DependencyProperty.Register("IconColor", typeof(SolidColorBrush), typeof(SkinRadioButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));
    }
}
