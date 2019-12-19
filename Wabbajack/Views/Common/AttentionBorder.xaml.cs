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

namespace Wabbajack
{
    /// <summary>
    /// Interaction logic for AttentionBorder.xaml
    /// </summary>
    public partial class AttentionBorder : UserControl
    {
        public object DisplayContent
        {
            get => (object)GetValue(DisplayContentProperty);
            set => SetValue(DisplayContentProperty, value);
        }
        public static readonly DependencyProperty DisplayContentProperty = DependencyProperty.Register(nameof(DisplayContent), typeof(object), typeof(AttentionBorder),
             new FrameworkPropertyMetadata(default(object)));

        public AttentionBorder()
        {
            InitializeComponent();
        }
    }
}
