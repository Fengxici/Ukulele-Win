using DMSkin.Core.MVVM;
using MainUI.Api;
using MainUI.Model;
using System.Windows.Controls;

namespace MainUI.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        #region 初始化
        public MainWindowViewModel()
        {
        }
        #endregion

        #region 页面切换
        private Page currentPage = PageManager.PageEmpty;

        /// <summary>
        /// 当前页面
        /// </summary>
        public Page CurrentPage
        {
            get { return currentPage; }
            set
            {
                currentPage = value;
                OnPropertyChanged("CurrentPage");
            }
        }

        private LeftMenu selectMenu;
        /// <summary>
        /// 选中的菜单
        /// </summary>
        public LeftMenu SelectMenu
        {
            get { return selectMenu; }
            set
            {
                selectMenu = value;
                switch (selectMenu)
                {
                    case LeftMenu.Empty:
                        CurrentPage = PageManager.PageEmpty;
                        break;
                    case LeftMenu.MiniBlink:

                        CurrentPage = PageManager.PageMiniBlink;
                        break;
                }
                OnPropertyChanged("SelectMenu");
            }
        }
        #endregion
    }
}
