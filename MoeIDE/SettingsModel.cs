﻿using System;
using System.Windows;
using System.Windows.Media;
using System.Xml.Serialization;

namespace Meowtrix.MoeIDE
{
    [Serializable, XmlRoot("Settings")]
    public class SettingsModel
    {
        [Serializable]
        public class ImageInfo
        {
            public string Filename { get; set; }
            public Stretch Stretch { get; set; } = Stretch.UniformToFill;
            public HorizontalAlignment HorizontalAlignment { get; set; } = HorizontalAlignment.Center;
            public VerticalAlignment VerticalAlignment { get; set; } = VerticalAlignment.Center;
        }
        public ImageInfo MainBackground { get; set; }
        public SettingsModel() { }
        public SettingsModel(Settings settings)
        {
            MainBackground = new ImageInfo
            {
                Filename = settings.MainBackgroundFilename,
                Stretch = settings.MainBackgroundStretch,
                HorizontalAlignment = settings.MainBackgroundHorizontalAlignment,
                VerticalAlignment = settings.MainBackgroundVerticalAlignment
            };
        }
    }
}