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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using WPF_MC.UserControls;

namespace WPF_MC.Pages
{
    /// <summary>
    /// Interaction logic for Main.xaml
    /// </summary>
    public partial class Main : Page
    {
        public delegate void OnAppClicked(AnApp sender, RoutedEventArgs e);
        public event OnAppClicked AppClicked;

        public delegate void OnTopAppButtonClicked(object sender, RoutedEventArgs e);
        public event OnTopAppButtonClicked TopAppButtonClicked;

        public delegate void OnDownloadsAndUpdatesClicked();
        public event OnDownloadsAndUpdatesClicked DownloadsAndUpdatesClicked;

        public Main()
        {
            InitializeComponent();

            #region Deals Tab Events

            DealsAppsViewer.AppClicked += AnAppClicked;

            #endregion

            #region Productivity Tab Events

            ProductivityTopApps.AppClicked += AnAppClicked;
            ProductivityAppsL1.AppClicked += AnAppClicked;
            ProductivityAppsL2.AppClicked += AnAppClicked;
            ProductivityAppsL3.AppClicked += AnAppClicked;

            #endregion

            #region Entertainment Tab Events

            EntertainmentAppsViewer.AppClicked += AnAppClicked;

            #endregion

            #region Gaming Tab Events

            GamingAppsViewer.AppClicked += AnAppClicked;

            #endregion

            #region Home Tab Events

            TopApps.AppClicked += AnAppClicked;
            TopApps.TopAppButtonClicked += TopApps_TopAppButtonClicked;
            FeaturesAppsViewer.AppClicked += AnAppClicked;
            MostPopularAppsViewer.AppClicked += AnAppClicked;
            TopFreeAppsViewer.AppClicked += AnAppClicked;
            TopFreeGamesAppsViewer.AppClicked += AnAppClicked;

            #endregion

            #region Right Button Command Events

            RightHeaderButtons.HeaderRightButtonsDownloadButtonClick += RightHeaderButtons_HeaderRightButtonsDownloadButtonClick;

            #endregion
        }

        private void RightHeaderButtons_HeaderRightButtonsDownloadButtonClick(object sender, RoutedEventArgs e)
        {
            DownloadsAndUpdatesClicked();
        }
        private void TopApps_TopAppButtonClicked(object sender, RoutedEventArgs e)
        {
            TopAppButtonClicked(sender, e);
        }

        private void AnAppClicked(AnApp sender, RoutedEventArgs e)
        {
            AppClicked(sender, e);
        }

        private void Page_PreviewMouseDown(object sender, MouseButtonEventArgs e)
        {
            RightHeaderButtons.MouseDown_OutsideOfHeaderRightButtons();
        }
    }
}
