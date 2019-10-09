using System.Collections.ObjectModel;
using System.Windows;

namespace MainUI
{
    /// <summary>
    /// App.xaml 的交互逻辑
    /// </summary>
    public partial class App : Application
    {

        public void ApplySkin(Collection<ResourceDictionary> mergedResources)
        {
            // Load the ResourceDictionary into memory.
            try
            {
                Collection<ResourceDictionary> mergedDicts = base.Resources.MergedDictionaries;
                // Remove the existing skin dictionary, if one exists.
                // NOTE: In a real application, this logic might need
                // to be more complex, because there might be dictionaries
                // which should not be removed.
                if (mergedDicts.Count > 0)
                    mergedDicts.Clear();
                // Apply the selected skin so that all elements in the
                // application will honor the new look and feel.
                mergedDicts = mergedResources;
            }
            catch
            {
                MessageBox.Show("背景应用失败，请勿擅自修改配置文件！");
            }

        }
    }
}
