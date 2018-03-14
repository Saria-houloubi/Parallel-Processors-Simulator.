﻿using GeneralHelpers.Password;
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
using ThishreenUniversity.ParallelPro.Enums;
using Tishreen.Tishreen.ParallelPro.Core;

namespace TishreenUniversity.ParallelPro.Controls
{
    /// <summary>
    /// Interaction logic for LoginUserControl.xaml
    /// </summary>
    public partial class LoginUserControl : BaseUserControl
    {
        public LoginUserControl()
        {
            InitializeComponent();
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            //when the checkbox is not check means the user is not a student
            if (!(bool)checkbox.IsChecked && Username.Text.ToLower() != Properties.Settings.Default.AdminUsername)
            {
                MessageBox.Show("Username is invalid\n please check and try again!", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }
            //Send the password for check
            var check = LoginViewModel.LoginCheck(Username.Text, Password.Password, Properties.Settings.Default.Password, Properties.Settings.Default.AdminSalt,(bool)checkbox.IsChecked?UserTypes.student:UserTypes.admin);

            if (!check)
                MessageBox.Show("Password are is incorrect\n please check and try again!", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
        }

        /// <summary>
        /// Is called once the exam button is loaded
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ExamButton_Loaded(object sender, RoutedEventArgs e)
        {
            //Get the send
            var button = (sender as Button);

            //If we are in exam mode ...
            if (Properties.Settings.Default.IsExamMode)
            {
                //Make the exam button visible
                button.Visibility = Visibility.Visible;
                //Hide the student checkbox
                studentCheck.Visibility = Visibility.Collapsed;
            }
            //If not in exam mode ...
            else
            {
                //Hide the exam button
                button.Visibility = Visibility.Collapsed;
                //Show student checkbox
                studentCheck.Visibility = Visibility.Visible;
            }
        }
    }
}
