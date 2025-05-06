using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DoToo.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoToo.ViewModels
{
    public partial class TodoItemViewModel : ViewModel
    {
        [ObservableProperty]
        TodoItem item;
        public TodoItemViewModel(TodoItem item) => Item = item;
        public event EventHandler ItemStatusChanged;
        public string StatusText => Item.Completed ? "Reactivate" : "Completed";
        [RelayCommand]
        void ToggleCompleted()
        {
            Item.Completed = !Item.Completed;
            ItemStatusChanged?.Invoke(this, new EventArgs());
        }
    }
}
