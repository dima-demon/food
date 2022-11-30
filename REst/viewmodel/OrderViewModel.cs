using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace REst.viewmodel
{
    public class OrderViewModel : BaseViewModel
    {
        public OrderViewModel()
        {
            MenuList = GetMenu();
        }
        public List<Pick> MenuList { get; set; }

        public ICommand BackCommand => new Command(() => Application.Current.MainPage.Navigation.PopAsync());

        private List<Pick> GetMenu()
        {
            return new List<Pick>
            {
                new Pick { Title = "The Ultimate Pack", Image = "IMG05.png", Description = "Гамбургер зі свининою,сиром з перцем та хрустким беконом", Price = "$23.99" },
                new Pick { Title = "Lamb Bundle", Image = "IMG04.png", Description = "Бараняча ніжка по тайськи з каррі,з молодою кукуродзою,квасолею та перцем чилі", Price = "$19.99" },
                new Pick { Title = "Juicy Mushroom", Image = "IMG01.png", Description = "Лісові гриби та горох в різотто,з хрусткою смаженою куркою", Price = "$25.25" }
            };
        }
    }
}
