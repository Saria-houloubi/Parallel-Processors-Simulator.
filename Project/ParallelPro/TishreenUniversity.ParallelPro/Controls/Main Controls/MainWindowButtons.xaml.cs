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
using TishreenUniversity.ParallelPro.Windows;

namespace TishreenUniversity.ParallelPro.Controls
{
    /// <summary>
    /// Interaction logic for MainWindowButtons.xaml
    /// </summary>
    public partial class MainWindowButtons : BaseUserControl
    {
        public MainWindowButtons()
        {

            InitializeComponent();

            AnimateInAnimationType = AnimationTypes.FadeIn;
        }
    }
}
