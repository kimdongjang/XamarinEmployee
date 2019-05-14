using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin_Employee.iOS.Renderer;
using Xamarin_Employee.Model.Custom;

[assembly: ExportRenderer(typeof(CustomLabel), typeof(CustomLabelRenderer))]
namespace Xamarin_Employee.iOS.Renderer
{
    [DesignTimeVisible(true)]
    public class CustomLabelRenderer : LabelRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
        {
            base.OnElementChanged(e);

            if (e == null) return;
            if (e.NewElement == null) return;

            var label = Control as UILabel;

            if (label != null)
            {
                //label.AdjustsFontSizeToFitWidth = true;
                //label.AdjustsFontForContentSizeCategory = true;
                label.BaselineAdjustment = UIBaselineAdjustment.AlignCenters;
                label.LineBreakMode = UILineBreakMode.Clip;

                CustomLabel control_label = e.NewElement as CustomLabel;
                label.Font = UIFont.FromName("NANUMSQUAREROUNDB", (int)control_label.FontSize);
            }
        }
    }
}