using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace REst.viewmodel
{
    public class MainViewModel : BaseViewModel
    {
        public MainViewModel()
        {
            Picks = GetPicks();
        }
        public List<Pick> Picks { get; set; }

        public ICommand OrderCommand => new Command(() => Application.Current.MainPage.Navigation.PushAsync(new OrderPage()));
        private List<Pick> GetPicks()
        {
            return new List<Pick>
            {
                new Pick { Title = "Breakfast", Image = "IMG01.png", Description = "Замовте наший чудовий, корисний, гарячий сніданок " },
                new Pick { Title = "Lunch", Image = "IMG03.png", Description = "Замовте наший смачний обід, щоб ваш обід був продуктивним та солодким " }
            };
        }

    }

    
    public class Pick
    {
        public string Title { get; set; }
        public string Image { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
    }
    public class BaseViewModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string name = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }

    }
}
