using System;
using System.Windows;
using System.Windows.Media;

namespace SkinDesign
{
    public class LoadSkinResources
    {
        public ResourceDictionary loadSkin()
        {
            return defaultSkin();
        }

        private ResourceDictionary defaultSkin()
        {
            ResourceDictionary Resources = new ResourceDictionary();
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/Animation.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/Skin.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinButton.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinCheckBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinContextMenu.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinDataGrid.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinIcon.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinImage.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinItemsControl.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinListBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinRadioButton.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinResizeGrip.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinScrollViewer.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinSlider.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinTabControl.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinTestBox.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinToolTip.xaml", UriKind.Relative)) as ResourceDictionary);
            Resources.MergedDictionaries.Add(Application.LoadComponent(new Uri("Default/SkinTreeView.xaml", UriKind.Relative)) as ResourceDictionary);

            Resources.Add("FontNormal", new FontFamily("微软雅黑,SimSun"));
            Resources.Add("FontTitle", new FontFamily("微软雅黑"));

            return Resources;
        }
    }
}
