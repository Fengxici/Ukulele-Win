using Kyozy.MiniblinkNet;
using MainUI.Api;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Interop;

namespace MainUI.Controls
{
    /// <summary>
    /// MiniBlinkWebView.xaml 的交互逻辑
    /// </summary>
    public partial class MiniBlinkWebView : UserControl
    {
        private WebView m_wke;
        public MiniBlinkWebView()
        {
            InitializeComponent();
            m_wke = new WebView(); //构造函数可以是无参，但是后面必须调用 Bind 方法
            m_wke.Bind(bowser_container);//随便绑定一个控件或窗口
            m_wke.OnLoadUrlBegin += M_wke_OnLoadUrlBegin;
            m_wke.OnLoadUrlEnd += M_wke_OnLoadUrlEnd;
            m_wke.OnLoadingFinish += M_wke_OnLoadingFinish;
        }

        private void M_wke_OnLoadingFinish(object sender, LoadingFinishEventArgs e)
        {
            Console.WriteLine("加载结束");
            loading_progress.Value = 0;
            loading_progress.Visibility = Visibility.Hidden;
        }

        private void M_wke_OnLoadUrlEnd(object sender, LoadUrlEndEventArgs e)
        {
            Console.WriteLine("加载结束");
        }

        private void M_wke_OnLoadUrlBegin(object sender, LoadUrlBeginEventArgs e)
        {
            Console.WriteLine("加载开始");
            if (loading_progress.Value == 0)
                loading_progress.Visibility = Visibility.Visible;
            loading_progress.Value += 5;
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
            m_wke.LoadURL("http://www.baidu.com");
        }
    }
}
