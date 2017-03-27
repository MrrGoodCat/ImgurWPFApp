using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
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
                MaximizeButton.Source = new ImageSourceConverter().ConvertFromString(@"D:\Git Projects\ImgurDesktop\ImgurWPF_Flat\ImgurWPF_Flat\Images\maximize.png") as ImageSource;
                SystemCommands.RestoreWindow(this);
                IsMaximized = false;
            }
            else
            {
                MaximizeButton.Source = new ImageSourceConverter().ConvertFromString(@"D:\Git Projects\ImgurDesktop\ImgurWPF_Flat\ImgurWPF_Flat\Images\TabWindow.png") as ImageSource;
                SystemCommands.MaximizeWindow(this);
                IsMaximized = true;
            }
        }

        private void image1_Copy_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {

            DoubleAnimation animation = new DoubleAnimation();
            Thickness marg;
            if (IsExpandedMenu)
            {
                marg = ImgurLogo.Margin;
                marg.Left = 50;
                ImgurLogo.Margin = marg;

                marg = image1_Copy.Margin;
                marg.Left = 6;
                image1_Copy.Margin = marg;

                animation.From = 250;
                animation.To = 44;
                animation.Duration = new Duration(TimeSpan.FromMilliseconds(200));
                MenuPanel.BeginAnimation(Panel.WidthProperty, animation);
                //MenuPanel.Width = 49;

                marg = MainPagebutton.Margin;
                marg.Left = -44;
                MainPagebutton.Margin = marg;

                marg = PopularButton.Margin;
                marg.Left = -44;
                PopularButton.Margin = marg;

                marg = FavoritesButton.Margin;
                marg.Left = -44;
                FavoritesButton.Margin = marg;

                marg = ImgurChatButton.Margin;
                marg.Left = -44;
                ImgurChatButton.Margin = marg;

                marg = MemesButton.Margin;
                marg.Left = -44;
                MemesButton.Margin = marg;

                marg = SettingsButton.Margin;
                marg.Left = -44;
                SettingsButton.Margin = marg;

                IsExpandedMenu = false;
            }
            else
            {
                animation.From = 44;
                animation.To = 250;
                animation.Duration = new Duration(TimeSpan.FromMilliseconds(200));
                MenuPanel.BeginAnimation(Panel.WidthProperty, animation);

                marg = ImgurLogo.Margin;
                marg.Left = 20;
                ImgurLogo.Margin = marg;

                marg = image1_Copy.Margin;
                marg.Left = 200;
                image1_Copy.Margin = marg;

                //MenuPanel.Width = 250;

                marg = MainPagebutton.Margin;
                marg.Left = -125;
                MainPagebutton.Margin = marg;

                marg = PopularButton.Margin;
                marg.Left = -200;
                PopularButton.Margin = marg;

                marg = FavoritesButton.Margin;
                marg.Left = -200;
                FavoritesButton.Margin = marg;

                marg = ImgurChatButton.Margin;
                marg.Left = -200;
                ImgurChatButton.Margin = marg;

                marg = MemesButton.Margin;
                marg.Left = -200;
                MemesButton.Margin = marg;

                marg = SettingsButton.Margin;
                marg.Left = -200;
                SettingsButton.Margin = marg;

                IsExpandedMenu = true;
            }            
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            (sender as Button).ContextMenu.IsEnabled = true;
            (sender as Button).ContextMenu.PlacementTarget = (sender as Button);
            (sender as Button).ContextMenu.Placement = System.Windows.Controls.Primitives.PlacementMode.Bottom;
            (sender as Button).ContextMenu.IsOpen = true;
        }

    }
}
