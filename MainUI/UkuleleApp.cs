using DMSkin.Core.Converters;
using MainUI.Converters;
using System;
using System.Windows;
using System.Windows.Media;

namespace MainUI
{
    public class UkuleleApp : Application
    {
        protected override void OnStartup(System.Windows.StartupEventArgs e)
        {
            addResources();
        }
        private void addResources()
        {
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/AntDesignSkin.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;Component/Styles/DMScrollViewer.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMIcon.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMButton.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMCheckBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;Component/Styles/Animation.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMTextBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMSlider.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMToolTip.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMContextMenu.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMTabControl.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMRadioButton.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMTreeView.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMDataGrid.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMListBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMResizeGrip.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/DMSkin.WPF;component/Styles/DMImage.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/Color.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/Path.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/Expander.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/Button.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/RadioButton.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/DMScrollViewer.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/DMSlider.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("Resources/Style/ProgressBar.xaml", UriKind.Relative)) as ResourceDictionary);

            Resources.Add("FontNormal", new FontFamily("微软雅黑,SimSun"));
            Resources.Add("FontTitle", new FontFamily("微软雅黑"));
            Resources.Add("Enum2BooleanConverter", new Enum2BooleanConverter());
            Resources.Add("TimeSpanToStringConverter", new TimeSpanToStringConverter());
        }
    }
}
