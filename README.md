# netcore-UI-samples
sample collection for various UI frameworks using .NET Core

## Overview

|    Project    |    NetCore    |   Full .Net   |legacy project*|
| --- | :-: | :-: | :-: |
| NetCoreLibrary | X | | |
| Console | X | | |
| WPF_cs | | X | |
| WPF_xaml | | X | X |
| Windows Forms | | X | X |
| DevZH.UI | X | | |

*\* legacy project: does not use the new .csproj format*


## Details

### Console
Plain console application targetting .NET Core.
![Screenshot](Console/screenshot.png)

### WPF_cs
A WPF application using the new csproj format, targetting the full .NET Framework (Windows specific).
This version only uses C# code to initialize all UI controls.

![Screenshot](WPF_cs/screenshot.png)

### WPF_xaml
A WPF application using the default VisualStudip template for WPF.
Requires the older, bigger csproj project, uses XAML.

![Screenshot](WPF_xaml/screenshot.png)

### Windows Forms
A legacy Windows Forms application using the VisualStudio designer.

![Screenshot](WindowsForms/screenshot.png)

### DevZH.UI
https://github.com/noliar/DevZH.UI

A simple binding (Experimental!!!) using .NET Core for https://github.com/andlabs/libui, which is
an awesome native UI library for Unix, OSX and Windows 

![Screenshot](DevZH.UI/screenshot.png)


## Additional frameworks to explore

### Avalonia

https://github.com/AvaloniaUI/Avalonia

Supposed to work with .NET Core, but I wasn't able to get it running, yet. 
It seems the Avalonia base nuget package requires Xamarin.Android and the
Java SDK to be installed.

### Xamarin Forms

Even the "Getting started" projects are huge, see:
https://github.com/xamarin/xamarin-forms-samples/tree/master/GettingStarted/XamarinFormsSample/XamarinFormsSample
There is no "Net Core" app runtime available at this point, you can consume .NET Standard libraries, but the end
application will run on Mono or full .NET, using UWP or WinRT, or one of the Xamarin Platforms (e.g. Xamarin.Android)
