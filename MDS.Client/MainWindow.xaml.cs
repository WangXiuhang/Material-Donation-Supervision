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

using MDS.Client.NavigationPages;

namespace MDS.Client
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MyMainPage MyMainPage { set; get; } = new MyMainPage();

        public MainWindow()
        {
            InitializeComponent();

            MyMainPageFrame.Content = MyMainPage;
        }
    }
}
