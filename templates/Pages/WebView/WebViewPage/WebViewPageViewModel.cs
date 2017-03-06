using System;

namespace ItemNamespace.WebViewPage
{
    public class WebViewPageViewModel : System.ComponentModel.INotifyPropertyChanged
    {
        private Uri _source;
        public Uri Source
        {
            get { return _source; }
            set { Set(ref _source, value); }
        }

        public WebViewPageViewModel()
        {
            Source = new Uri("https://www.microsoft.com/"); //Setup here your web url.
        }
    }
}