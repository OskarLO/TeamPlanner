using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Microsoft.UI.Xaml.Controls;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using TeamPlannerTFT.Contracts.Services;
using TeamPlannerTFT.Contracts.ViewModels;
using TeamPlannerTFT.Core.Contracts.Services;
using TeamPlannerTFT.Core.Dtos;
using TeamPlannerTFT.DataAccess.Model;
using TeamPlannerTFT.Views;

namespace TeamPlannerTFT.ViewModels
{
    public class CrudViewModel : ObservableRecipient, INavigationAware
    {

        private readonly IUnitService _unitService;
        private readonly INavigationService _navigationService;

        public CrudViewModel(IUnitService unitService, INavigationService navigationService)
        {
            _unitService = unitService;
            _navigationService = navigationService;
        }

        private DialogViewModel _selectedUnit;
        public DialogViewModel Selected
        {
            get => _selectedUnit;
            set => SetProperty(ref _selectedUnit, value);

        }

        public void OnNavigatedFrom()
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(object parameter)
        {
            GetUnits();
        }

        public ObservableCollection<DialogViewModel> Units { get; set; } = new();

        public async void GetUnits()
        {
            var units = await _unitService.GetUnitsAsync();

            foreach (var unit in units)
            {
                Units.Add(new DialogViewModel(unit));
            }
        }

        private ICommand _addCommand;
        public ICommand AddCommand
        {
            get
            {
                if (_addCommand == null)
                {
                    _addCommand = new RelayCommand(async () =>
                    {
                        DialogViewModel newUnit = new();
                        DialogPage addUnitPage = new(newUnit);

                        ContentDialog dialog = new()
                        {
                            Title = "Add new unit",
                            Content = addUnitPage,
                            PrimaryButtonText = "Add",
                            IsPrimaryButtonEnabled = false,
                            CloseButtonText = "Cancel",
                            DefaultButton = ContentDialogButton.Primary,
                            XamlRoot = _navigationService.Frame.XamlRoot
                        };

                        newUnit.PropertyChanged += (sender, e) => dialog.IsPrimaryButtonEnabled = !newUnit.HasErrors;

                        ContentDialogResult result = await dialog.ShowAsync();

                        if (result == ContentDialogResult.Primary)
                        {
                            var unitDto = await _unitService.CreateUnitAsync((UnitDto)newUnit);
                            DialogViewModel unit = new(unitDto);

                            Units.Add(unit);
                            Selected = unit;
                        }
                    });
                }

                return _addCommand;
            }
        }

        private ICommand _updateCommand;
        public ICommand UpdateCommand
        {
            get
            {
                if (_updateCommand == null)
                {
                    _updateCommand = new RelayCommand<DialogViewModel>(async param =>
                    {
                        DialogViewModel currentUnit = Selected;
                        DialogPage UpdateUnitPage = new(currentUnit);

                        ContentDialog dialog = new()
                        {
                            Title = "Update existing student: " + currentUnit.Name,
                            Content = UpdateUnitPage,
                            PrimaryButtonText = "Apply Changes",
                            IsPrimaryButtonEnabled = false,
                            CloseButtonText = "Cancel",
                            DefaultButton = ContentDialogButton.Primary,
                            XamlRoot = _navigationService.Frame.XamlRoot
                        };

                        currentUnit.PropertyChanged += (sender, e) => dialog.IsPrimaryButtonEnabled = !currentUnit.HasErrors;

                        ContentDialogResult result = await dialog.ShowAsync();

                        if (result == ContentDialogResult.Primary)
                        {
                            _unitService.UpdateUnitAsync((UnitDto)currentUnit);

                            var unitDto = (UnitDto)currentUnit;
                            DialogViewModel unit = new(unitDto);

                            var tempUnit = Units.FirstOrDefault(i => i.Id == unit.Id);
                            int i = Units.IndexOf(tempUnit);
                            Units[i] = currentUnit;

                            Selected = unit;
                        }
                    }, param => param != null);
                }
                return _updateCommand;
            }
        }

        private ICommand _deleteCommand;
        public ICommand DeleteCommand
        {
            get
            {
                if (_deleteCommand == null)
                {
                    _deleteCommand = new RelayCommand<DialogViewModel>(async param =>
                    {
                        ContentDialog deleteDialog = new()
                        {
                            Title = "Delete unit permanently?",
                            Content = "If you delete this unit, you won't be able to recover it. Do you want to delete it?",
                            PrimaryButtonText = "Delete",
                            CloseButtonText = "Cancel",
                            DefaultButton = ContentDialogButton.Close,
                            XamlRoot = _navigationService.Frame.XamlRoot
                        };

                        ContentDialogResult result = await deleteDialog.ShowAsync();

                        if (result == ContentDialogResult.Primary)
                        {
                            if (await _unitService.DeleteUnitAsync((UnitDto)param))
                            {
                                _ = Units.Remove(param);
                            }
                        }
                    }, param => param != null);
                }

                return _deleteCommand;
            }
        }

    }
}
