using Foundation;
using System;
using UIKit;
using SidebarNavigation;

namespace SidebarNavIssueDemo
{
    public partial class MasterNavigationController : UINavigationController
    {
		public SidebarController SideBarController;
		public UIViewController holderVC;
        public MasterNavigationController (IntPtr handle) : base (handle)
        {
        }

	}
}