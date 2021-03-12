using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Input;
using testScroll.Services.Navigation;
using testScroll.ViewModels.Base;
using testScroll.Views;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace testScroll.ViewModels
{
    public class CuestionarioViewModel : ViewModelBase
    {
        private readonly INavigationService _navigationService;
        private Page _page;
        public ICommand saveQuizCommand { get; set; }
        public CuestionarioViewModel(INavigationService navigationService)
        {
            this._navigationService = navigationService;
        }

        //CheckBoxes
        private bool _Mejoravit;
        public bool Mejoravit
        {
            get { return _Mejoravit; }
            set
            {
                if (value != _Mejoravit)
                {
                    _Mejoravit = value;
                    OnPropertyChanged();
                    if (value == true)
                    {
                        MejoravitVisible = true;
                       
                    }
                    else
                    {
                        MejoravitVisible = false;
                        
                    }
                }
            }
        }
        private bool _Coppel;
        public bool Coppel
        {
            get
            {
                return _Coppel;
            }
            set
            {
                _Coppel = value;
                OnPropertyChanged();
                if (value == true)
                {
                    CoppelVisible = true;
                   
                }
                else
                {
                    CoppelVisible = false;
                   
                }
            }
        }

        private bool _coppelVisible;
        public bool CoppelVisible
        {
            get { return _coppelVisible; }
            set
            {
                _coppelVisible = value;
                OnPropertyChanged();
            }
        }
        private bool _mejoravitVisible;
        public bool MejoravitVisible
        {
            get { return _mejoravitVisible; }
            set
            {
                _mejoravitVisible = value;
                OnPropertyChanged();
            }
        }

        private bool _Tcmapco;
        public bool Tcmapco
        {
            get
            {
                return _Tcmapco;
            }
            set
            {
                _Tcmapco = value;
                OnPropertyChanged();
            }
        }
        private bool _Rpropio;
        public bool Rpropio
        {
            get
            {
                return _Rpropio;
            }
            set
            {
                _Rpropio = value;
                OnPropertyChanged();
            }
        }
        private bool _Ctradicional;
        public bool Ctradicional
        {
            get
            {
                return _Ctradicional;
            }
            set
            {
                _Ctradicional = value;
                OnPropertyChanged();
            }
        }
        private bool _clickedButton = false;
        public bool clickedButton
        {
            get { return _clickedButton; }
            set
            {
                _clickedButton = value;
                OnPropertyChanged();
            }
        }

        public override async void OnAppearing(object navigationContext)
        {
            if (_clickedButton)
                return;

            _clickedButton = true;
            try
            {

                _page = this._navigationService.GetCurrentPage();
                var QuizName = _page.GetType().Name;

            }
            catch (Exception e)
            {
                var rr = e.Message.ToString();
            }

            _clickedButton = !_clickedButton;
        }
    }
}