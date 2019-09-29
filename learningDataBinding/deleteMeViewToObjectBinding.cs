using System;

using Xamarin.Forms;

namespace learningDataBinding
{
    public class deleteMeViewToObjectBinding : ContentPage
    {
        public deleteMeViewToObjectBinding()
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

