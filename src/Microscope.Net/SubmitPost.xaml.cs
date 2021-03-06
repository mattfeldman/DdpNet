﻿using Microscope.Net.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Microscope.Net.DataModel;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace Microscope.Net
{
    /// <summary>
    /// A basic page that provides characteristics common to most applications.
    /// </summary>
    public sealed partial class SubmitPost : BasePage
    {
        private PostViewModel viewModel;

        public SubmitPost()
        {
            this.InitializeComponent();
        }

        /// <summary>
        /// Populates the page with content passed during navigation. Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session. The state will be null the first time a page is visited.</param>
        protected override void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
            this.viewModel = new PostViewModel();
            this.DataContext = this.viewModel;
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        protected override void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        private async void SubmitPostButton_OnClick(object sender, RoutedEventArgs e)
        {
            string url = this.UrlTextBox.Text;
            string title = this.TitleTextBox.Text;

            if (string.IsNullOrWhiteSpace(url))
            {
                this.viewModel.Error = "URL required";
                return;
            }

            if (string.IsNullOrWhiteSpace(title))
            {
                this.viewModel.Error = "Title required";
                return;
            }

            PostSubmit postSubmit = new PostSubmit(title, url);

            PostReturn post = await App.Current.Client.Call<PostReturn>("postInsert", postSubmit);

            this.Frame.Navigate(typeof (PostPage), post.ID);
        }
    }
}
