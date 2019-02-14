# BetterFolderBrowser
[![bfb-nuget](/Assets/NuGet-Package-1.0.0-brightgreen.svg)](https://www.nuget.org/packages/BetterFolderBrowser/) [![bfb-donate](/Assets/Donate-PayPal-blue.svg)](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=DJ8D9CE8BWA3J&source=url)

**BetterFolderBrowser** is a .NET component library that was written to help developers provide a better folder-browsing and selection experience to users by employing a similar browser dialog as the standard [OpenFileDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=netframework-4.7.2) in place of the current [FolderBrowserDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=netframework-4.7.2) which only allows for single-folder selections with its tree-view display format. This allows for a much easier _viewing_, _modification_, _searching_ and _selection_ experience using the standard Windows Explorer dialog.

Take a look at the folder-selection screenshot and usage-preview in action:

![bfb-preview-01](/Assets/better-folder-browser-static-preview.png)
![bfb-usage](/Assets/better-folder-browser-live-preview.gif)

# Installation

To install via the [NuGet Package Manager](https://www.nuget.org/packages/BetterFolderBrowser/1.0.0) Console, type:

> `Install-Package BetterFolderBrowser -Version 1.0.0`

You can also choose to [download](https://github.com/Willy-Kimura/BetterFolderBrowser/releases/download/v1.0.0/BetterFolderBrowser.dll) the assembly and add it to Visual Studio's Toolbox.

# Features
- Works with [.NET 2.0](https://www.microsoft.com/en-us/download/details.aspx?id=1639) and above allowing for usability across most .NET applications.
- Built as a component making it accessible in Design Mode.
- Uses the same dialog model as the [OpenFileDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=netframework-4.7.2), making it super easy for users to *view*, *search*, *select*, and *modify* folders when opened.
- Allows passing of literal paths as strings to the `RootFolder` property.
- Allows multiple selection of folders in constrast to the standard WinForms [FolderBrowserDialog](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.folderbrowserdialog?view=netframework-4.7.2) which only allows for single-folder selections. One can then access the list of selected folders using the property `SelectedPaths` or its variant `SelectedFolders` property.
- The dialog can be displayed either blocking the UI thread or not using the `ShowDialog(IWin32Window)` or `ShowDialog()` methods respectively.
- Provides additional custom [UITypeEditor](https://docs.microsoft.com/en-us/dotnet/api/system.drawing.design.uitypeeditor?view=netframework-4.7.2) variants for folder-selection within the *Properties* window. They include the `SelectedPathEditor` (for **single** folder selection) and `SelectedPathsEditor` (for **multiple** folder selection) for use in-place of the standard WinForms [SelectedPathEditor](http://www.dotnetframework.org/default.aspx/DotNET/DotNET/8@0/untmp/whidbey/REDBITS/ndp/fx/src/Designer/WinForms/System/WinForms/Design/SelectedPathEditor@cs/1/SelectedPathEditor@cs). For usage of these editors, ensure you import the namespace `WK.Libraries.BetterFolderBrowserNS.Editors`.
> Here are two examples of properties implementing the given custom editors:
> ```c#
>     // Allows selection of one folder.
>     [Editor(typeof(SelectedPathEditor), typeof(UITypeEditor))]
>     public string MyFolderPath { get; set; }
>     
>     // Allows selection of many folders.
>     [Editor(typeof(SelectedPathsEditor), typeof(UITypeEditor))]
>     public string[] MyFolderPaths { get; set; }
> ```

# Usage
If you prefer working with the Designer, simply add the component to Visual Studio's Toolbox and use the
*Properties* window to change its options:

![bfb-properties](/Assets/better-folder-browser-properties.png)

To use it in code, first import `WK.Libraries.BetterFolderBrowserNS` - the code below will then assist you: 
```c#
    var betterFolderBrowser = new BetterFolderBrowser();

    betterFolderBrowser.Title = "Select folders...";
    betterFolderBrowser.RootFolder = "C:\\";
    
    // Allow multi-selection of folders.
    betterFolderBrowser.Multiselect = true;

    if (betterFolderBrowser.ShowDialog() == DialogResult.OK)
    {
        string[] selectedFolders = betterFolderBrowser1.SelectedFolders;
        
        // If you've disabled multi-selection, use 'SelectedFolder'.
        // string selectedFolder = betterFolderBrowser1.SelectedFolder;
    }
```

If you'd prefer blocking the main UI thread when calling the dialog, simply specify the window owner of the dialog using the `ShowDialog(IWin32Window)` method:
```c#
    if (betterFolderBrowser.ShowDialog(this) == DialogResult.OK)
    {
        // ...
    }
```
Note that we've specified the owner with the keyword `this` since we're calling the dialog from the Form where it is hosted.

If you're calling the dialog from within a custom [UserControl](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.usercontrol) and would prefer blocking the main UI thread when calling it, you can still specify the window owner using the `ShowDialog(IWin32Window)` method:
```c#
    if (betterFolderBrowser.ShowDialog(this.FindForm()) == DialogResult.OK)
    {
        // ...
    }
```

## Donate
Hey, you can always [buy me a coffee](https://www.paypal.com/cgi-bin/webscr?cmd=_s-xclick&hosted_button_id=DJ8D9CE8BWA3J&source=url) if this component library ([or others](https://github.com/Willy-Kimura/SharpClipboard)) has been of value to you.