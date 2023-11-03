using CommandMVVM.Commands;
using CommandMVVM.Models;
using CommandMVVM.Services;
using CommandMVVM.Views.Pages;
using CommandMVVM.Views.Windows;
using MaterialDesignThemes.Wpf;
using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Navigation;



namespace CommandMVVM.ViewModels.PageViewModels;

public class DashboardViewModel : NotificationService
{
    private Car? car1;
    public Car? car { get => car1; set { car1 = value; OnPropertyChanged(); } }

    private NavigationWindow navigationWindow;
    
    public ObservableCollection<Car> Cars { get; set; }


    public ICommand AddCommand{ get; set; }
    public ICommand GetAllCommand{ get; set; }
    public ICommand EditAllCommand{ get; set; }
    public ICommand RemoveCommand { get; set; }
    public ICommand SaveCommand { get; set; }
    public ICommand CancelAllCommand { get; set; }

     


    public DashboardViewModel()
    {
        Cars = new ObservableCollection<Car>()
        {
            new("Kia", "Optima", "2012"),
            new("Hyundai", "Elantra", "2014"),
            new("Audi", "Q7", "2023"),
        };

        car = new();


        AddCommand = new RelayCommand(AddCar, CanAddCar);
        GetAllCommand = new RelayCommand(GetAllCars, CanAllCars);
        EditAllCommand = new RelayCommand(EditCar, CanEditCar);
        RemoveCommand = new RelayCommand(RemoveCar, CanRemoveCar);
        SaveCommand = new RelayCommand(SaveCar, CanSaveCars);
        CancelAllCommand = new RelayCommand(Cancel, CanCancel);

        navigationWindow = new NavigationWindow();
    }

    public void SaveCar(object? parameter)
    {
       
    }

    public bool CanSaveCars(object? parameter)
    {
        return true;
    }

    public void Cancel(object? parameter)
    {

    }

    public bool CanCancel(object? parameter)
    {
        return true;
    }

    public void GetAllCars(object? parameter)
    {
        var getAllView = new AllCarView();
        getAllView.DataContext = new GetAllCarViewModel(Cars);
        getAllView.ShowDialog();
    }

    public bool CanAllCars(object? parameter)
    {
        return Cars.Count >= 5;
    }


    public void AddCar(object? parameter)
    {
       //var btn = parameter as Button;
       // MessageBox.Show($"{btn.Content} - {btn.Width} - {btn.Margin}");
        Cars.Add(car!);
        car = new();
        
    }

    public bool CanAddCar(object? parameter)
    {
        return !string.IsNullOrEmpty(car?.Make) &&
               !string.IsNullOrEmpty(car?.Model) &&
               !string.IsNullOrEmpty(car?.Year);
    }
    public void EditCar(object? parameter)
    {
        
        



    }
    public bool CanEditCar(object? parameter)
    {
       
        return (int)parameter!=-1;
    }

    public void RemoveCar(object? parameter)
    {
       
        
        Cars.Remove(Cars[(int)parameter]);
        
    }
    public bool CanRemoveCar(object? parameter)
    {

        return true;
    }
    
}
