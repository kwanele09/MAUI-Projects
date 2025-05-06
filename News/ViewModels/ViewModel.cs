using CommunityToolkit.Mvvm.ComponentModel;

namespace News.ViewModels
{
    [ObservableObject]
    public abstract partial class ViewModel
    {
        public INavigate Navigation { get; init; }
        internal ViewModel(INavigate navigation) => Navigation = navigation;
    }
}
