using System;
using System.Globalization;
using System.Reflection;
using System.Resources;
using Avalonia.Threading;
using CommunityToolkit.Mvvm.ComponentModel;
using TicketVending.Languages;

namespace TicketVending.ViewModels;

public partial class MainWindowViewModel : ObservableObject
{
    [ObservableProperty] private string _timeS = DateTime.Now.ToString("HH:mm:ss\nyyyy-MM-dd");

    public MainWindowViewModel()
    {
        // Create a DispatcherTimer that ticks every second
        var timer = new DispatcherTimer { Interval = TimeSpan.FromSeconds(1) };

        // When the timer ticks, update the TimeS property
        timer.Tick += (sender, e) => { TimeS = DateTime.Now.ToString("HH:mm:ss\nyyyy-MM-dd"); };

        timer.Start();
    }
}