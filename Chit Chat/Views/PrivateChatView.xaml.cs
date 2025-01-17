﻿using ChitChat.Models;
using ChitChat.ViewModels;
using System;
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

namespace ChitChat.Views
{
    /// <summary>
    /// Interaction logic for PrivateChatView.xaml
    /// </summary>
    public partial class PrivateChatView : UserControl
    {
        public PrivateChatView()
        {
            InitializeComponent();
        }

        private void OnExitClick(object sender, RoutedEventArgs e)
        {
            var parentWindow = Window.GetWindow(this) as ChatView;
            parentWindow.Transitioner.SelectedIndex = 1;
        }
    }
}
