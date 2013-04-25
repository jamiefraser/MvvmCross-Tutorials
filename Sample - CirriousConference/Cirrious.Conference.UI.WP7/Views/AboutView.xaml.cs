﻿using System;
using System.Collections.Generic;
using System.Device.Location;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Cirrious.Conference.Core.ViewModels;
using Cirrious.Conference.Core.ViewModels.SessionLists;
using Cirrious.MvvmCross.WindowsPhone.Views;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Controls.Maps;

namespace Cirrious.Conference.UI.WP7.Views
{
    public abstract class BaseAboutView : BaseView<AboutViewModel>
    {        
    }

    public partial class AboutView : BaseAboutView
    {
        public AboutView()
        {
            InitializeComponent();
        }
    }
}