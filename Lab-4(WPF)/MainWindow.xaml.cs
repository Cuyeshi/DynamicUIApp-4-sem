﻿using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace Lab_4_WPF
{
    public partial class MainWindow : Window
    {
        private Slider slider;
        private RotateTransform rotateTransform;
        private Rectangle rectangle;

        public MainWindow()
        {
            InitializeComponent();
            CreateUI();
        }

        
    }
}
