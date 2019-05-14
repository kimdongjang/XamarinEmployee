using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Xamarin_Employee.View.User
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class AcceptTermsPage : ContentPage
	{
        bool b_selectall = false;
		public AcceptTermsPage ()
        {

            InitializeComponent();

            #region IOS의 경우 초기화
            NavigationPage.SetHasNavigationBar(this, false); // Navigation Bar 지우는 코드 생성자에 입력
            if (Xamarin.Forms.Device.OS == TargetPlatform.iOS)
            {
                MainGrid.RowDefinitions[0].Height = Global.title_size_value;
            }
            #endregion
            Init();


        }
        private void Init()
        {
            Image_BackButton.GestureRecognizers.Add(new TapGestureRecognizer
             {
                 Command = new Command(() =>
                 {
                     Navigation.PopAsync();
                 })
             });
            Btn_SelectAll.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    if(b_selectall == false)
                    {
                        ((Image)Btn_SelectAll.Children[1]).Source = "radio_checked_icon.png";
                        b_selectall = true;
                    }
                    else
                    {

                    }
                    
                })
            });
        }

    }
}