using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace Xamarin_Employee.ViewModel.User
{
    public class AcceptTermsPageViewModel : INotifyPropertyChanged
    {
        public AcceptTermsPageViewModel()
        {

        }


        // 바인딩 속성을 묶기 위한 이벤트 핸들러 등록
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }
        }
    }

    //    public LoginPageViewModel()
    //    {
    //        // 로그인 함수 커맨드를 등록
    //        Cm_LoginBtn = new Command(Login);
    //    }

    //    // 속성값
    //    private string _UserID;
    //    public string UserID
    //    {
    //        get { return _UserID; }
    //        set
    //        {
    //            if (_UserID == value) return;
    //            _UserID = value;
    //            OnPropertyChanged("UserID");
    //        }
    //    }

    //    private string _UserPW;
    //    public string UserPW
    //    {
    //        get { return _UserPW; }
    //        set
    //        {
    //            if (_UserPW == value) return;
    //            _UserPW = value;
    //            OnPropertyChanged("UserPW");
    //        }
    //    }

    //    private ObservableCollection<UserModel> _UserDataList; // 유저 리스트
    //    public ObservableCollection<UserModel> UserDataList
    //    {
    //        get
    //        {
    //            return _UserDataList;
    //        }

    //        set
    //        {
    //            _UserDataList = value;
    //            OnPropertyChanged("UserDataList");
    //        }
    //    }


    //    // 커맨드 이벤트
    //    public ICommand Cm_LoginBtn { get; private set; }
    //    private void Login()
    //    {
    //        UserModel user = new UserModel();
    //        user.UserID = _UserID;
    //        user.UserPW = _UserPW;

    //        UserDataList.Add(user);

    //        // 아이디, 패스워드 일치 확인
    //        _UserID = "";
    //        _UserPW = "";
    //        OnPropertyChanged("UserID");
    //        OnPropertyChanged("UserPW");


    //    }

    //}
}
