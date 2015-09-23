﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using Xunit.Runners.UI;

namespace XunitXamarin.WinPhone
{
    public partial class MainPage : RunnerApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        protected override void OnInitializeRunner()
        {
            // tests can be inside the main assembly
            AddTestAssembly(Assembly.GetExecutingAssembly());
            
			// otherwise you need to ensure that the test assemblies will 
            // become part of the app bundle
            //AddTestAssembly(typeof(PortableTests).Assembly);
        }
    }
}
