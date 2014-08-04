﻿namespace Limelight_new
{
    using Windows.Storage;
    using Windows.UI.Xaml.Controls;

    /// <summary>
    /// Persist user settings between app uses
    /// </summary>
    public sealed partial class MainPage : Page
    {
        #region Persistent Settings
        /// <summary>
        /// Save page settings so the user doesn't have to select them each time she opens the app
        /// </summary>
        private void SaveSettings()
        {
            var settings = ApplicationData.Current.RoamingSettings;

            // Save fps radio button state

            settings.Values["fps"] = _30fps_button.IsChecked;
            settings.Values["pixels"] = _720p_button.IsChecked;
        }

        /// <summary>
        /// Load persisted settings. Called on page load. 
        /// </summary>
        private void LoadSettings()
        {
            // Load fps radio button state
            if (ApplicationData.Current.RoamingSettings.Values.ContainsKey("fps"))
            {
                if ((bool)ApplicationData.Current.RoamingSettings.Values["fps"])
                {
                    _30fps_button.IsChecked = true;
                }
                else
                {
                    _60fps_button.IsChecked = true;
                }
            }
            // Load fps radio button state
            if (ApplicationData.Current.RoamingSettings.Values.ContainsKey("pixels"))
            {
                if ((bool)ApplicationData.Current.RoamingSettings.Values["pixels"])
                {
                    _720p_button.IsChecked = true;
                }
                else
                {
                    _1080p_button.IsChecked = true;
                }
            }
        }
        #endregion Persistent Settings
    }
}