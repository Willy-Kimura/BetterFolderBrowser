/*
 * Developer    : Willy Kimura (WK).
 * Library      : BetterFolderBrowser.
 * License      : MIT.
 * 
 * This .NET component was written to help developers
 * provide a better folder-browsing and selection
 * experience to users by employing the old Windows
 * Vista folder browser dialog in place of the current
 * 'FolderBrowserDialog' tree-view style. This dialog
 * implementation mimics the 'OpenFileDialog' design
 * which allows for a much easier viewing, selection, 
 * and search experience using Windows Explorer.
 * 
 * +------------------------------------+
 * | if (BetterFolderBrowserIsActive()) |
 * | --> AwesomeUX = true;              |
 * +------------------------------------+
 * 
 * Improvements are always welcome :)
 * 
 */


using System;
using System.Drawing;
using System.Diagnostics;
using System.Windows.Forms;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms.Design;
using System.ComponentModel.Design;

using WK.Libraries.BetterFolderBrowserNS.Editors;

namespace WK.Libraries.BetterFolderBrowserNS
{
    /// <summary>
    /// A Windows Forms component that enhances the standard folder-browsing experience.
    /// </summary>
    [DefaultProperty("RootFolder")]
    [ToolboxBitmap(typeof(FolderBrowserDialog))]
    [Description("A .NET component library that delivers a better folder-browsing and selection experience.")]
    public partial class BetterFolderBrowser : CommonDialog
    {
        #region Constructors

        public BetterFolderBrowser()
        {
            InitializeComponent();

            SetDefaults();
        }

        public BetterFolderBrowser(IContainer container)
        {
            container.Add(this);

            InitializeComponent();

            SetDefaults();
        }

        #endregion

        #region Fields
        
        private Helpers.BetterFolderBrowserDialog _dialog = 
            new Helpers.BetterFolderBrowserDialog();

        /// <summary>
        /// Used in creating a <see cref="UITypeEditor"/> service
        /// for extending its usage into the Properties window.
        /// Developers can use it where possible.
        /// </summary>
        internal IWindowsFormsEditorService editorService;

        #endregion

        #region Properties

        #region Browsable

        /// <summary>
        /// Gets or sets the folder dialog box title.
        /// </summary>
        [Category("Better Folder Browsing")]
        [Description("Sets the folder dialog box title.")]
        public string Title
        {
            get { return _dialog.Title; }
            set { _dialog.Title = value; }
        }

        /// <summary>
        /// Gets or sets the root folder where the browsing starts from.
        /// </summary>
        [Category("Better Folder Browsing")]
        [Editor(typeof(SelectedPathEditor), typeof(UITypeEditor))]
        [Description("Sets the root folder where the browsing starts from.")]
        public string RootFolder
        {
            get { return _dialog.InitialDirectory; }
            set { _dialog.InitialDirectory = value; }
        }

        /// <summary>
        /// Gets or sets a value indicating whether the 
        /// dialog box allows multiple folders to be selected.
        /// </summary>
        [Category("Better Folder Browsing")]
        [Description("Sets a value indicating whether the dialog " +
                     "box allows multiple folders to be selected.")]
        public bool Multiselect
        {
            get { return _dialog.AllowMultiselect; }
            set { _dialog.AllowMultiselect = value; }
        }
        
        #endregion

        #region Non-browsable

        /// <summary>
        /// Gets the folder-path selected by the user.
        /// </summary>
        [Browsable(false)]
        public string SelectedPath
        {
            get { return _dialog.FileName; }
        }

        /// <summary>
        /// Gets the list of folder-paths selected by the user.
        /// </summary>
        [Browsable(false)]
        public string[] SelectedPaths
        {
            get { return _dialog.FileNames; }
        }

        /// <summary>
        /// Variant of <see cref="SelectedPath"/> property.
        /// Gets the folder-path selected by the user.
        /// </summary>
        [Browsable(false)]
        public string SelectedFolder
        {
            get { return _dialog.FileName; }
        }

        /// <summary>
        /// Variant of <see cref="SelectedPaths"/> property.
        /// Gets the list of folder-paths selected by the user.
        /// </summary>
        [Browsable(false)]
        public string[] SelectedFolders
        {
            get { return _dialog.FileNames; }
        }

        #endregion

        #endregion

        #region Methods

        #region Private

        private void SetDefaults()
        {
            _dialog.AllowMultiselect = false;
            _dialog.Title = "Please select a folder...";
            _dialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        }

        #endregion

        #region Public

        /// <summary>
        /// Runs a common dialog box with a default owner.
        /// </summary>
        public new DialogResult ShowDialog()
        {
            DialogResult result = DialogResult.Cancel;

            if (_dialog.ShowDialog(IntPtr.Zero))
                result = DialogResult.OK;
            else
                result = DialogResult.Cancel;

            return result;
        }

        /// <summary>
        /// Runs a common dialog box with the specified owner.
        /// </summary>
        /// <param name="owner">
        /// Any object that implements <see cref="IWin32Window"/> that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        public new DialogResult ShowDialog(IWin32Window owner)
        {
            DialogResult result = DialogResult.Cancel;

            if (_dialog.ShowDialog(owner.Handle))
                result = DialogResult.OK;
            else
                result = DialogResult.Cancel;

            return result;
        }

        #endregion

        #region Overrides

        /// <summary>
        /// Specifies a common dialog box.
        /// </summary>
        /// <param name="hwndOwner">
        /// Any object that implements <see cref="IWin32Window"/> that represents
        /// the top-level window that will own the modal dialog box.
        /// </param>
        /// <returns></returns>
        protected override bool RunDialog(IntPtr hwndOwner)
        {
            return _dialog.ShowDialog(hwndOwner);
        }

        /// <summary>
        /// Resets all properties to their default values.
        /// </summary>
        public override void Reset()
        {
            SetDefaults();
        }

        #endregion

        #endregion
    }
}

namespace WK.Libraries.BetterFolderBrowserNS.Editors
{
    /// <summary>
    /// Provides a custom <see cref="BetterFolderBrowser"/> UI Editor
    /// for browsing through folders via the Properties window. 
    /// This allows for the selection of a single folder.
    /// It's designed as a replacement for <see cref="FolderBrowserDialog"/>'s
    /// <see cref="UITypeEditor"/>.
    /// 
    /// <para>
    /// Example:
    /// <code>[Editor(typeof(BetterFolderBrowserPathEditor), typeof(UITypeEditor))]</code>
    /// </para>
    /// </summary>
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class SelectedPathEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context,
                                IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService editorService =
               provider.GetService(typeof(IWindowsFormsEditorService)) as
               IWindowsFormsEditorService;

            if (editorService != null)
            {
                BetterFolderBrowser editor = new BetterFolderBrowser();

                editor.editorService = editorService;
                editor.Multiselect = false;

                if (editor.ShowDialog() == DialogResult.OK)
                    value = editor.SelectedPath;
            }

            return value;
        }
    }
    
    /// <summary>
    /// Provides a custom <see cref="BetterFolderBrowser"/> UI Editor
    /// for browsing through folders via the Properties window. 
    /// This allows for the selection of a single folder.
    /// It's designed as a replacement for <see cref="FolderBrowserDialog"/>'s
    /// <see cref="UITypeEditor"/>.
    /// 
    /// <para>
    /// Example:
    /// <code>[Editor(typeof(BetterFolderBrowserPathsEditor), typeof(UITypeEditor))]</code>
    /// </para>
    /// </summary>
    [DebuggerStepThrough]
    [EditorBrowsable(EditorBrowsableState.Never)]
    public class SelectedPathsEditor : UITypeEditor
    {
        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            return UITypeEditorEditStyle.Modal;
        }

        public override object EditValue(ITypeDescriptorContext context,
                                IServiceProvider provider, object value)
        {
            IWindowsFormsEditorService editorService =
               provider.GetService(typeof(IWindowsFormsEditorService)) as
               IWindowsFormsEditorService;

            if (editorService != null)
            {
                BetterFolderBrowser editor = new BetterFolderBrowser();

                editor.editorService = editorService;
                editor.Multiselect = true;

                if (editor.ShowDialog() == DialogResult.OK)
                    value = editor.SelectedPaths;
            }

            return value;
        }
    }
}