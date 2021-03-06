﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin_Employee.Droid.Renderer;
using Xamarin_Employee.Model.Custom;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace Xamarin_Employee.Droid.Renderer
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Xamarin.Forms.Button> e)
        {
            base.OnElementChanged(e);

            CustomButton control = e.NewElement as CustomButton;
            var label = (TextView)Control;
            label.SetTextSize(Android.Util.ComplexUnitType.Dip, (int)control.FontSize);

            Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "NANUMSQUAREROUNDB.TTF");
            label.Typeface = font;
        }
    }
}