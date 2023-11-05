﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Beckjan.ViewModels;
using ReactiveUI;

namespace Beckjan.Pages;
/// <summary>
/// Логика взаимодействия для ShellSortPage.xaml
/// </summary>
public partial class ShellSortPage : ReactiveUserControl<ShellSortViewModel>
{
    public ShellSortPage()
    {
        InitializeComponent();
    }

    protected override void OnPropertyChanged(DependencyPropertyChangedEventArgs e)
    {
        if (e.Property.Name == nameof(ViewModel))
        {
            DataContext = ViewModel;
        }
        base.OnPropertyChanged(e);
    }
}

