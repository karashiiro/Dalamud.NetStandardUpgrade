using Lumina.Data;
using Lumina.Excel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Threading.Tasks;

namespace Dalamud.Data
{
    /// <summary>
    /// This class provides data for Dalamud-internal features, but can also be used by plugins if needed.
    /// </summary>
    public class DataManager
    {
        public ReadOnlyDictionary<string, ushort> ServerOpCodes { get; private set; }

        /// <summary>
        /// An <see cref="ExcelModule"/> object which gives access to any of the game's sheet data.
        /// </summary>
        public ExcelModule Excel => this.gameData?.Excel;

        /// <summary>
        /// Indicates whether Game Data is ready to be read.
        /// </summary>
        public bool IsDataReady { get; private set; }

        /// <summary>
        /// A <see cref="Lumina"/> object which gives access to any excel/game data.
        /// </summary>
        private Lumina.Lumina gameData;

        private ClientLanguage language;

        public DataManager(ClientLanguage language)
        {
            // Set up default values so plugins do not null-reference when data is being loaded.
            this.ServerOpCodes = new ReadOnlyDictionary<string, ushort>(new Dictionary<string, ushort>());

            this.language = language;
        }

        public async Task Initialize()
        {
        }

        #region Lumina Wrappers

        /// <summary>
        /// Get an <see cref="ExcelSheet{T}"/> with the given Excel sheet row type.
        /// </summary>
        /// <typeparam name="T">The excel sheet type to get.</typeparam>
        /// <returns>The <see cref="ExcelSheet{T}"/>, giving access to game rows.</returns>
        public ExcelSheet<T> GetExcelSheet<T>() where T : IExcelRow
        {
            return this.Excel.GetSheet<T>();
        }

        /// <summary>
        /// Get a <see cref="FileResource"/> with the given path.
        /// </summary>
        /// <param name="path">The path inside of the game files.</param>
        /// <returns>The <see cref="FileResource"/> of the file.</returns>
        public FileResource GetFile(string path)
        {
            return this.GetFile<FileResource>(path);
        }

        /// <summary>
        /// Get a <see cref="FileResource"/> with the given path, of the given type.
        /// </summary>
        /// <typeparam name="T">The type of resource</typeparam>
        /// <param name="path">The path inside of the game files.</param>
        /// <returns>The <see cref="FileResource"/> of the file.</returns>
        public T GetFile<T>(string path) where T : FileResource
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
