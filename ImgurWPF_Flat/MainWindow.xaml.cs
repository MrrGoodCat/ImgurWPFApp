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

namespace ImgurWPF_Flat
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private bool IsMaximized;
        public MainWindow()
        {
            InitializeComponent();
            IsMaximized = false;
        }

        private void DockPanel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            Environment.Exit(0);
        }

        private void CloseButton_MouseEnter(object sender, MouseEventArgs e)
        {
            CloseButton.Opacity = 0.5;
        }

        private void CloseButton_MouseLeave(object sender, MouseEventArgs e)
        {
            CloseButton.Opacity = 1;
        }

        private void MinimizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            MinimizeButton.Opacity = 0.5;
        }

        private void MinimizeButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            SystemCommands.MinimizeWindow(this);
        }

        private void MinimizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            MinimizeButton.Opacity = 1;
        }

        private void MaximizeButton_MouseEnter(object sender, MouseEventArgs e)
        {
            MaximizeButton.Opacity = 0.5;
        }

        private void MaximizeButton_MouseLeave(object sender, MouseEventArgs e)
        {
            MaximizeButton.Opacity = 1;
        }

        private void MaximizeButton_MouseLeftButtonUp(object sender, MouseButtonEventArgs e)
        {
            if (IsMaximized)
            {
                SystemCommands.RestoreWindow(this);
                IsMaximized = false;
            }
            else
            {
                SystemCommands.MaximizeWindow(this);
                IsMaximized = true;
            }
        }
    }
}
