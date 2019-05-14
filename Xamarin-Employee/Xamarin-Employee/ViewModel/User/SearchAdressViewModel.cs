using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Xamarin_Employee.ViewModel.User
{
    class SearchAdressViewModel : INotifyPropertyChanged
    {
        public SearchAdressViewModel()
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
}
