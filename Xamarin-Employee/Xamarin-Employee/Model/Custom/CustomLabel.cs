﻿using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace Xamarin_Employee.Model.Custom
{
    public class CustomLabel : Label
    {
        public int Size { get; set; }
        public static readonly BindableProperty IsUnderlinedProperty = BindableProperty.Create("IsUnderlined", typeof(bool), typeof(CustomLabel), false);

        public bool IsUnderlined
        {
            get { return (bool)GetValue(IsUnderlinedProperty); }
            set { SetValue(IsUnderlinedProperty, value); }
        }
        public static readonly BindableProperty MyStyleIdProperty =
                BindableProperty.Create("MyStyleId", typeof(string), typeof(CustomLabel), "Body");

        public string MyStyleId
        {
            get { return (string)GetValue(MyStyleIdProperty); }
        }
    }
}
