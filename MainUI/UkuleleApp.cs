using System;
using System.Windows;
using System.Windows.Media;
using UkuleleSkin.Converters;

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
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;Component/Default/SkinScrollViewer.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinIcon.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinButton.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinCheckBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;Component/Default/Animation.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinTextBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinSlider.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinToolTip.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinContextMenu.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinTabControl.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinRadioButton.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinTreeView.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinDataGrid.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinListBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinResizeGrip.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(LoadComponent(new Uri("/SkinDesign;component/Default/SkinImage.xaml", UriKind.Relative)) as ResourceDictionary);
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
            Resources.Add("BoolToVisibilityConverter", new BoolToVisibilityConverter());
            Resources.Add("CompareToVisibilityConverter", new CompareToVisibilityConverter());
            Resources.Add("EnumToBooleanConverter", new EnumToBooleanConverter());
            Resources.Add("EnumToVisibilityConverter", new EnumToVisibilityConverter());
            Resources.Add("SecondToStringConverter", new SecondToStringConverter());
            Resources.Add("TimeSpanToStringConverter", new TimeSpanToStringConverter());
        }
    }
}
