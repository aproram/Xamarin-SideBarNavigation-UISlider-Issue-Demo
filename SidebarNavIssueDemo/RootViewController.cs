using Foundation;
using System;
using UIKit;
using SidebarNavigation;

namespace SidebarNavIssueDemo
{
    public partial class RootViewController : UIViewController
    {
		SidebarController SidebarController;
        public RootViewController (IntPtr handle) : base (handle)
        {
        }

		public override void ViewDidLoad()
		{
			base.ViewDidLoad();

			UIStoryboard sb = UIStoryboard.FromName("Main", NSBundle.MainBundle);

			MenuViewController menuVC = (MenuViewController)sb.InstantiateViewController("MenuVC");



			MasterNavigationController contentVC = (MasterNavigationController)sb.InstantiateViewController("MasterNC");


			// create a slideout navigation controller with the top navigation controller and the menu view controller
			SidebarController = new SidebarController(this, contentVC, menuVC);
			SidebarController.MenuLocation = SidebarController.MenuLocations.Right;
			contentVC.SideBarController = SidebarController;
			contentVC.holderVC = this;
		}
    }
}