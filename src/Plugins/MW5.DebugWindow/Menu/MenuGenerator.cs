﻿// --------------------------------------------------------------------------------------------------------------------
// <copyright file="MenuGenerator.cs" company="MapWindow OSS Team - www.mapwindow.org">
//   MapWindow OSS Team - 2015
// </copyright>
// <summary>
//   The menu generator.
// </summary>
// --------------------------------------------------------------------------------------------------------------------

namespace MW5.Plugins.DebugWindow.Menu
{
    #region

    using MW5.Plugins.Concrete;
    using MW5.Plugins.DebugWindow;
    using MW5.Plugins.Interfaces;

    #endregion

    /// <summary>
    /// The menu generator.
    /// </summary>
    public class MenuGenerator
    {
        #region Fields

        /// <summary>
        /// The menu commands.
        /// </summary>
        private readonly MenuCommands _commands;

        #endregion

        #region Constructors and Destructors

        /// <summary>
        /// Initializes a new instance of the <see cref="MenuGenerator"/> class.
        /// </summary>
        /// <param name="context">
        /// The application context.
        /// </param>
        /// <param name="plugin">
        /// The plugin.
        /// </param>
        public MenuGenerator(IAppContext context, DebugWindowPlugin plugin)
        {
            _commands = new MenuCommands(plugin.Identity);

            // Create the toolbar:
            this.InitToolbar(context, plugin.Identity);
        }
        #endregion

        #region Methods

        /// <summary>
        /// Initialize the toolbar.
        /// </summary>
        /// <param name="context">
        /// The application context.
        /// </param>
        /// <param name="identity">
        /// The plug-in identity.
        /// </param>
        private void InitToolbar(IAppContext context, PluginIdentity identity)
        {
            // Create a new toolbar
            var bar = context.Toolbars.Add("DebugWindow Plugin toolbar", identity);
            bar.DockState = ToolbarDockState.Top;

            // Add toolbar buttons, use MenuKeys to identify the buttons and add the command in MenuCommands:
            _commands.AddToMenu(bar.Items, MenuKeys.ShowDebugWindow);
        }

        #endregion
    }
}