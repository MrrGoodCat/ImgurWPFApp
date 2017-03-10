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
        private bool IsExpandedMenu;
        public MainWindow()
        {
            InitializeComponent();
            IsMaximized = false;
            IsExpandedMenu = true;
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

        private void image1_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            Thickness marg;
            if (IsExpandedMenu)
            {
                marg = ImgurLogo.Margin;
                marg.Left = 50;
                ImgurLogo.Margin = marg;

                marg = image1_Copy.Margin;
                marg.Left = 10;
                image1_Copy.Margin = marg;

                MenuPanel.Width = 49;

                marg = button.Margin;
                marg.Left = -49;
                button.Margin = marg;

                marg = button1.Margin;
                marg.Left = -49;
                button1.Margin = marg;

                marg = button2.Margin;
                marg.Left = -49;
                button2.Margin = marg;

                marg = button3.Margin;
                marg.Left = -49;
                button3.Margin = marg;

                marg = button4.Margin;
                marg.Left = -49;
                button4.Margin = marg;

                marg = button5.Margin;
                marg.Left = -49;
                button5.Margin = marg;

                IsExpandedMenu = false;
            }
            else
            {
                marg = ImgurLogo.Margin;
                marg.Left = 20;
                ImgurLogo.Margin = marg;

                marg = image1_Copy.Margin;
                marg.Left = 200;
                image1_Copy.Margin = marg;

                MenuPanel.Width = 250;

                marg = button.Margin;
                marg.Left = -125;
                button.Margin = marg;

                marg = button1.Margin;
                marg.Left = -200;
                button1.Margin = marg;

                marg = button2.Margin;
                marg.Left = -200;
                button2.Margin = marg;

                marg = button3.Margin;
                marg.Left = -200;
                button3.Margin = marg;

                marg = button4.Margin;
                marg.Left = -200;
                button4.Margin = marg;

                marg = button5.Margin;
                marg.Left = -200;
                button5.Margin = marg;

                IsExpandedMenu = true;
            }

            
        }
    }
}
