using System.Windows.Input;
using System;

namespace CommandMVVM.Commands;

public class RelayCommand: ICommand
{
    public event EventHandler? CanExecuteChanged
    {
        add { CommandManager.RequerySuggested += value; }
        remove { CommandManager.RequerySuggested -= value; }
    }


    private readonly Action<object?> _execute;
    private readonly Predicate<object?>? _canExecute;


    public RelayCommand(Action<object?> execute, Predicate<object?>? canExecute = null)
    {
        _execute = execute;
        _canExecute = canExecute;
    }

    public bool CanExecute(object? parameter)
    {
        return _canExecute.Invoke(parameter);
    }
   

    public void Execute(object? parameter)
    {
        _execute.Invoke(parameter);
    }
}
