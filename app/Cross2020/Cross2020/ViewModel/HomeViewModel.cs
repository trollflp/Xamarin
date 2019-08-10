using Cross2020.Models;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Xamarin.Forms;

namespace Cross2020.ViewModel
{
    public sealed class HomeViewModel : BindableObject
    {
        private ObservableCollection<Candy> items = new ObservableCollection<Candy>();

        public ObservableCollection<Candy> Items
        {
            get => items;
            set { items = value; OnPropertyChanged(); }
        }

        public HomeViewModel()
        {
            Items = new ObservableCollection<Candy>(
                new List<Candy> {
                    new Candy { Name = "Nome", Description = "Descrição" }
            });
        }
    }
}
