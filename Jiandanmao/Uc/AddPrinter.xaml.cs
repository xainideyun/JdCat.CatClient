﻿using Jiandanmao.Code;
using Jiandanmao.Enum;
using MaterialDesignThemes.Wpf;
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

namespace Jiandanmao.Uc
{
    /// <summary>
    /// AddPrinter.xaml 的交互逻辑
    /// </summary>
    public partial class AddPrinter : UserControl
    {
        public Printer Printer { get; set; }
        public AddPrinter(Printer printer)
        {
            InitializeComponent();
            Printer = printer;
            DataContext = printer.Clone();
            cbType.ItemsSource = new[] {
                new { Name = "前台打印机", Value = 1 },
                new { Name = "后厨打印机", Value = 2 }
            };
            cbQuantity.ItemsSource = new[] { 1, 2, 3, 4, 5 };
            cbMode.ItemsSource = new[] {
                new { Name = "一菜一打", Value = PrinterMode.Food },
                new { Name = "一份一打", Value = PrinterMode.Share },
                new { Name = "一单一打", Value = PrinterMode.Order },
            };
            cbFormat.ItemsSource = new[] {
                new { Name = "80mm", Value = 80 },
                new { Name = "58mm", Value = 58 }
            };
            cbState.ItemsSource = new[] {
                new { Name = "正常", Value = 1 },
                new { Name = "停用", Value = 2 }
            };
        }

    }
}
