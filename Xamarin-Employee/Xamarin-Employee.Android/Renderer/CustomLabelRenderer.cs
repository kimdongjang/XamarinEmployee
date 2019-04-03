using System;
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

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace Xamarin_Employee.Droid.Renderer
{
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            CustomLabel control_label = e.NewElement as CustomLabel;
            var label = (TextView)Control;
            label.SetTextSize(Android.Util.ComplexUnitType.Dip, control_label.Size);

            Typeface font = Typeface.CreateFromAsset(Forms.Context.Assets, "NANUMSQUAREROUNDB.TTF");
            label.Typeface = font;
        }
    }
}