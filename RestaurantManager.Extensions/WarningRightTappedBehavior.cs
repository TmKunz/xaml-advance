using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Popups;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml.Input;

namespace RestaurantManager.Extensions
{
    public class WarningRightTappedBehavior:DependencyObject, IBehavior
    {
        public string Message { get; set; }

        public DependencyObject AssociatedObject { get; private set; }

        public void Attach(DependencyObject associatedObject)
        {
            this.AssociatedObject = associatedObject;
            if(this.AssociatedObject is Grid)
            {
                (this.AssociatedObject as Grid).RightTapped += WarningRightTapped_Tapped;
            }
        }

        private void WarningRightTapped_Tapped(object sender, RightTappedRoutedEventArgs e)
        {
            new MessageDialog(this.Message, "Thanks!").ShowAsync();
        }

        public void Detach()
        {
            (this.AssociatedObject as Grid).RightTapped -= WarningRightTapped_Tapped;
        }
    }
}
