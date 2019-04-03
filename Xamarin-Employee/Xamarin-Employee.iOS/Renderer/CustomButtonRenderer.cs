using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Foundation;
using UIKit;
using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;
using Xamarin_Employee.iOS.Renderer;
using Xamarin_Employee.Model.Custom;

[assembly: ExportRenderer(typeof(CustomButton), typeof(CustomButtonRenderer))]
namespace Xamarin_Employee.iOS.Renderer
{
    public class CustomButtonRenderer : ButtonRenderer
    {
        protected override void OnElementChanged(ElementChangedEventArgs<Button> e)
        {
            base.OnElementChanged(e);

            if (e == null) return;
            if (e.NewElement == null) return;

            var label = Control as UIButton;
            if (label != null)
            {
                //label.AdjustsFontSizeToFitWidth = true;
                //label.AdjustsFontForContentSizeCategory = true;
                //label.BaselineAdjustment = UIBaselineAdjustment.AlignCenters;
                //label.LineBreakMode = UILineBreakMode.Clip;

                CustomButton control_label = e.NewElement as CustomButton;
                label.Font = UIFont.FromName("NANUMSQUAREROUNDB", control_label.Size);
            }
        }
    }
}