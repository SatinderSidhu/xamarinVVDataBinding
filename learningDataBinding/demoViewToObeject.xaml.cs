using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace learningDataBinding
{
    public partial class demoViewToObeject : ContentPage
    {
        public demoViewToObeject()
        {
            InitializeComponent();

            Employee emp = new Employee() { Address = "Morris Plains", Name = "Satinder SIdhu", Age = "40" };

            iAmLabel.BindingContext = emp;            
            
        }
    }

    /// <summary>
    /// Simple employee class
    /// </summary>
    public class Employee
    {
        public string Name;
        public string Age;
        public string Address;
    }
}
