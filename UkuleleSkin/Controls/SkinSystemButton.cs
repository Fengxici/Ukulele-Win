using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

namespace UkuleleSkin.Controls
{
    public class SkinSystemButton : Button
    {
        [Description("窗体系统按钮大小"), Category("Skin")]
        public double SkinSystemButtonSize
        {
            get { return (double)GetValue(SkinSystemButtonSizeProperty); }
            set { SetValue(SkinSystemButtonSizeProperty, value); }
        }
        public static readonly DependencyProperty SkinSystemButtonSizeProperty =
            DependencyProperty.Register("SkinSystemButtonSize", typeof(double), typeof(SkinSystemButton), new PropertyMetadata(30.0));

        [Description("窗体系统按钮鼠标悬浮背景颜色"), Category("Skin")]
        public SolidColorBrush SkinSystemButtonHoverColor
        {
            get { return (SolidColorBrush)GetValue(SkinSystemButtonHoverColorProperty); }
            set { SetValue(SkinSystemButtonHoverColorProperty, value); }
        }
        public static readonly DependencyProperty SkinSystemButtonHoverColorProperty =
            DependencyProperty.Register("SkinSystemButtonHoverColor", typeof(SolidColorBrush), typeof(SkinSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(50, 50, 50, 50))));

        [Description("窗体系统按钮颜色"), Category("Skin")]
        public SolidColorBrush SkinSystemButtonForeground
        {
            get { return (SolidColorBrush)GetValue(SkinSystemButtonForegroundProperty); }
            set { SetValue(SkinSystemButtonForegroundProperty, value); }
        }
        public static readonly DependencyProperty SkinSystemButtonForegroundProperty =
            DependencyProperty.Register("SkinSystemButtonForeground", typeof(SolidColorBrush), typeof(SkinSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));

        [Description("窗体系统按钮鼠标悬按钮颜色"), Category("Skin")]
        public SolidColorBrush SkinSystemButtonHoverForeground
        {
            get { return (SolidColorBrush)GetValue(SkinSystemButtonHoverForegroundProperty); }
            set { SetValue(SkinSystemButtonHoverForegroundProperty, value); }
        }
        public static readonly DependencyProperty SkinSystemButtonHoverForegroundProperty =
            DependencyProperty.Register("SkinSystemButtonHoverForeground", typeof(SolidColorBrush), typeof(SkinSystemButton), new PropertyMetadata(new SolidColorBrush(Color.FromArgb(255, 255, 255, 255))));

        /// <summary>
        /// 图标
        /// </summary>
        [Description("图标"), Category("Skin")]
        public Geometry Icon
        {
            get { return (Geometry)GetValue(IconProperty); }
            set { SetValue(IconProperty, value); }
        }
        public static readonly DependencyProperty IconProperty =
            DependencyProperty.Register("Icon", typeof(Geometry), typeof(SkinSystemButton), new PropertyMetadata(null));

        /// <summary>
        /// 图标宽度
        /// </summary>
        public double IconWidth
        {
            get { return (double)GetValue(IconWidthProperty); }
            set { SetValue(IconWidthProperty, value); }
        }
        public static readonly DependencyProperty IconWidthProperty =
            DependencyProperty.Register("IconWidth", typeof(double), typeof(SkinSystemButton), new PropertyMetadata(15.0));

        /// <summary>
        /// 图标高度
        /// </summary>
        public double IconHeight
        {
            get { return (double)GetValue(IconHeightProperty); }
            set { SetValue(IconHeightProperty, value); }
        }
        public static readonly DependencyProperty IconHeightProperty =
            DependencyProperty.Register("IconHeight", typeof(double), typeof(SkinSystemButton), new PropertyMetadata(15.0));
    }
}