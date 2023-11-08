using System;
using System.Windows;
using System.Windows.Input;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MVVM4.ViewModels.Base;
using MVVM4.Infrostructre.Commands;
using MVVM4.Services;

namespace MVVM4.ViewModels
{
    internal class MainWindowViewModel : ViewModel
    {
        private string _City ;

        private List<string> _Temperature;
        private List<string> _Date;
        private List<string> _Description;
        public List<string> Temperature
        {
            get => _Temperature;
            set => Set(ref _Temperature, value);
        }
        public List<string> Description
        {
            get => _Description;
            set => Set(ref _Description, value);
        }
        public List<string> Date
        {
            get => _Date;
            set => Set(ref _Date, value);
        }
        public string City
        {
            get => _City;

            set => Set(ref _City, value);
        }
        
        public ICommand CloseApplicationCommand { get;}

        private void OnCloseApplicationCommandExecute(object p)
        {
            
            DataService.GetLatLon();
            
        }
        private bool CanCloseApplicationCommandExecute(object p) => true;
        
        
        public MainWindowViewModel()
        {
            DataService ds = new DataService();
            CloseApplicationCommand = new LambdaCommand(OnCloseApplicationCommandExecute, CanCloseApplicationCommandExecute);
            Description=new List<string>();
        }
    }
}