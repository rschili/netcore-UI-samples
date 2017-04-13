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
