using CommunityToolkit.Mvvm.ComponentModel;

namespace LibWithMvvm
{
    public partial class Data : ObservableRecipient
    {
        [ObservableProperty]
        private int id;
    }
}