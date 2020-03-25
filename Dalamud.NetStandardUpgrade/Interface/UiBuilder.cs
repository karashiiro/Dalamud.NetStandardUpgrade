using ImguiNET;
using ImguiScene;
using System;

namespace Dalamud.Interface
{
    public class UiBuilder : IDisposable
    {
        /// <summary>
        /// The delegate that gets called when Dalamud is ready to draw your windows or overlays.
        /// When it is called, you can use static ImGui calls.
        /// </summary>
        public event BuildUIDelegate OnBuildUi;

        /// <summary>
        /// Unregister the UiBuilder. Do not call this in plugin code.
        /// </summary>
        public void Dispose() {}

        /// <summary>
        /// Loads an image from the specified file.
        /// </summary>
        /// <param name="filePath">The full filepath to the image.</param>
        /// <returns>A <see cref="TextureWrap"/> object wrapping the created image.  Use <see cref="TextureWrap.ImGuiHandle"/> inside ImGui.Image()</returns>
        public TextureWrap LoadImage(string filePath)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// Event that is fired when the plugin should open its configuration interface.
        /// </summary>
        public EventHandler OnOpenConfigUi;
    }
}
