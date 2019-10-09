using System;
using System.Windows;
using System.Windows.Controls;

namespace UkuleleSkin.Controls
{
    public class SkinButton : Button
    {
        public CornerRadius CornerRadius
        {
            get { return (CornerRadius)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty CornerRadiusProperty =
            DependencyProperty.Register("CornerRadius", typeof(CornerRadius), typeof(SkinButton), new PropertyMetadata(null));
    }
}
