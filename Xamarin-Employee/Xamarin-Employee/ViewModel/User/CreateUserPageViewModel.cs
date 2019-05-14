using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_Employee.ViewModel.User
{
    public class CreateUserPageViewModel : INotifyPropertyChanged
    {
        public CreateUserPageViewModel()
        {

        }

        // 속성값
        private string _UserPicture;
        public string UserPicture
        {
            get { return _UserPicture; }
            set
            {
                if (_UserPicture == value) return;
                _UserPicture = value;
                OnPropertyChanged("UserPicture");
            }
        }


        private string _UserName;
        public string UserName
        {
            get { return _UserName; }
            set
            {
                if (UserName == value) return;
                _UserName = value;
                OnPropertyChanged("UserName");
            }
        }

        private string _UserNickName;
        public string UserNickName
        {
            get { return _UserNickName; }
            set
            {
                if (UserNickName == value) return;
                _UserNickName = value;
                OnPropertyChanged("UserNickName");
            }
        }

        private string _UserID;
        public string UserID
        {
            get { return _UserID; }
            set
            {
                if (UserID == value) return;
                _UserID = value;
                OnPropertyChanged("UserID");
            }
        }

        private string _UserPW;
        public string UserPW
        {
            get { return _UserPW; }
            set
            {
                if (UserPW == value) return;
                _UserPW = value;
                OnPropertyChanged("UserPW");
            }
        }

        private string _UserBirth;
        public string UserBirth
        {
            get { return _UserBirth; }
            set
            {
                if (UserBirth == value) return;
                _UserBirth = value;
                OnPropertyChanged("UserBirth");
            }
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
}
