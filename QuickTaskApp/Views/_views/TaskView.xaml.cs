﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace QuickTaskApp.Views._views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class TaskView : ContentView
    {
        public TaskView()
        {
            InitializeComponent();
        }
    }
}