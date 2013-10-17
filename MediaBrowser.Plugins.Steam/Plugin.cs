﻿using MediaBrowser.Common.Configuration;
using MediaBrowser.Common.Plugins;
using MediaBrowser.Model.Serialization;
using MediaBrowser.Plugins.Steam.Configuration;
using MediaBrowser.Theater.Interfaces.Plugins;
using System;

namespace MediaBrowser.Plugins.Steam
{
    /// <summary>
    /// Class Plugin
    /// </summary>
    public class Plugin : BasePlugin<PluginConfiguration>, IHasThumbImage
    {
        public Plugin(IApplicationPaths applicationPaths, IXmlSerializer xmlSerializer)
            : base(applicationPaths, xmlSerializer)
        {
        }

        /// <summary>
        /// Gets the name of the plugin
        /// </summary>
        /// <value>The name.</value>
        public override string Name
        {
            get { return "Steam Integration"; }
        }

        public Uri ThumbUri
        {
            get { return GetThumbUri(); }
        }

        public static Uri GetThumbUri()
        {
            return new Uri("pack://application:,,,/MediaBrowser.Plugins.Steam;component/Resources/tile.png", UriKind.Absolute);
        }
    }
}
