/*
 * The classes here are designed to create a wrapper
 * around the System.Windows.Forms.OpenFileDialog
 * and present it as a Folder Browser Dialog.
 * 
 */


using System;
using System.Windows.Forms;

namespace WK.Libraries.BetterFolderBrowserNS.Helpers
{
    /// <summary>
    /// Wraps System.Windows.Forms.OpenFileDialog to make it present
    /// a vista-style dialog.
    /// </summary>
    public class BetterFolderBrowserDialog
    {
        #region Constructor

        /// <summary>
        /// Default constructor.
        /// </summary>
        public BetterFolderBrowserDialog()
        {
            ofd = new OpenFileDialog();

            ofd.Filter = "Folders|" + "\n";
            ofd.AddExtension = false;
            ofd.CheckFileExists = false;
            ofd.DereferenceLinks = true;
            ofd.Multiselect = false;
        }

        #endregion

        #region Fields

        private OpenFileDialog ofd = null;

        #endregion

        #region Properties

        /// <summary>
        /// Gets/Sets a value indicating whether to allow multi-selection of folders.
        /// </summary>
        /// <remarks></remarks>
        public bool AllowMultiselect
        {
            get { return ofd.Multiselect; }
            set { ofd.Multiselect = value; }
        }

        /// <summary>
        /// Gets the list of selected folders as filenames.
        /// </summary>
        public string[] FileNames
        {
            get { return ofd.FileNames; }
        }
        
        /// <summary>
        /// Gets/Sets the initial folder to be selected. A null value selects the current directory.
        /// </summary>
        public string InitialDirectory
        {
            get { return ofd.InitialDirectory; }
            set {
                ofd.InitialDirectory = (value == null || value.Length == 0) ? Environment.CurrentDirectory : value;
            }
        }

        /// <summary>
        /// Gets/Sets the title to show in the dialog.
        /// </summary>
        public string Title
        {
            get { return ofd.Title; }
            set { ofd.Title = (value == null) ? "Select a folder" : value; }
        }

        /// <summary>
        /// Gets the selected folder.
        /// </summary>
        public string FileName
        {
            get { return ofd.FileName; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Shows the dialog.
        /// </summary>
        /// <returns>True if the user presses OK else false.</returns>
        public bool ShowDialog()
        {
            return ShowDialog(IntPtr.Zero);
        }

        /// <summary>
        /// Shows the dialog.
        /// </summary>
        /// <param name="hWndOwner">Handle of the control to be parent.</param>
        /// <returns>True if the user presses OK else false.</returns>
        public bool ShowDialog(IntPtr hWndOwner)
        {
            bool flag = false;

            if (Environment.OSVersion.Version.Major >= 6)
            {
                var r = new Reflector("System.Windows.Forms");

                uint num = 0;
                Type typeIFileDialog = r.GetTypo("FileDialogNative.IFileDialog");
                object dialog = r.Call(ofd, "CreateVistaDialog");
                r.Call(ofd, "OnBeforeVistaDialog", dialog);

                uint options = Convert.ToUInt32(r.CallAs(typeof(System.Windows.Forms.FileDialog), ofd, "GetOptions"));
                options |= Convert.ToUInt32(r.GetEnum("FileDialogNative.FOS", "FOS_PICKFOLDERS"));
                r.CallAs(typeIFileDialog, dialog, "SetOptions", options);

                object pfde = r.New("FileDialog.VistaDialogEvents", ofd);
                object[] parameters = new object[] { pfde, num };
                r.CallAs2(typeIFileDialog, dialog, "Advise", parameters);

                num = Convert.ToUInt32(parameters[1]);

                try
                {
                    int num2 = Convert.ToInt32(r.CallAs(typeIFileDialog, dialog, "Show", hWndOwner));
                    flag = 0 == num2;
                }
                finally
                {
                    r.CallAs(typeIFileDialog, dialog, "Unadvise", num);
                    GC.KeepAlive(pfde);
                }
            }
            else
            {
                var fbd = new FolderBrowserDialog();

                fbd.Description = this.Title;
                fbd.SelectedPath = this.InitialDirectory;
                fbd.ShowNewFolderButton = false;

                if (fbd.ShowDialog(new WindowWrapper(hWndOwner)) != DialogResult.OK)
                {
                    return false;
                }

                ofd.FileName = fbd.SelectedPath;
                flag = true;
            }

            return flag;
        }

        #endregion
    }

    /// <summary>
    /// Creates IWin32Window around an IntPtr.
    /// </summary>
    public class WindowWrapper : IWin32Window
    {
        #region Fields

        private IntPtr _hwnd;

        #endregion

        #region Properties

        /// <summary>
        /// Original pointer.
        /// </summary>
        public IntPtr Handle
        {
            get { return _hwnd; }
        }

        #endregion

        #region Methods

        /// <summary>
        /// Provides a wrapper for <see cref="IWin32Window"/>.
        /// </summary>
        /// <param name="handle">Handle to wrap.</param>
        public WindowWrapper(IntPtr handle)
        {
            _hwnd = handle;
        }

        #endregion
    }
}