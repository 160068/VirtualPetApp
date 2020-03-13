using System;

using Xamarin.Forms;

namespace VirtualPetApp
{
    public class RenameKittyPage : ContentPage
    {
        public RenameKittyPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }
    }
}

