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
	public partial class CreateUserPage : ContentPage
	{
		public CreateUserPage ()
		{
			InitializeComponent ();

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
            Label_Login.GestureRecognizers.Add(new TapGestureRecognizer
            {
                Command = new Command(() =>
                {
                    // 로그인 페이지로 이동
                })
            });
        }
    }
}