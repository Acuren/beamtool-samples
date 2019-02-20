# How to use this Sample
Clone or download the repository. Open the BeamToolIntegration.sln file in Visual Studio.
1. Remove the reference to BeamTool from the BeamToolHost project.
2. Add a reference to your installed instance of BeamTool in the Program Files folder.
3. Edit the [App.xaml.cs](https://github.com/Acuren/beamtool-samples/blob/master/WPF/BeamToolHost/App.xaml.cs) file and set the value of the beamToolInstallLocation variable to the correct path to your installation of BeamTool.
3. Build and run the application.

# Demonstrated in this Sample
- Hosting the BeamToolView in the [WindowsFormsHost](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.integration.windowsformshost?view=netframework-4.7.2) control
- [Runtime Assembly Resolution](https://docs.microsoft.com/en-us/dotnet/framework/app-domains/resolve-assembly-loads)
- Extending the [WindowsFormsHost](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.integration.windowsformshost?view=netframework-4.7.2) control to add addtional dependency properties
- Configuring the [PropertyMap](https://docs.microsoft.com/en-us/dotnet/api/system.windows.forms.integration.windowsformshost.propertymap?view=netframework-4.7.2) to enable interaction with the BeamToolView control via [DataBinding](https://docs.microsoft.com/en-us/dotnet/framework/wpf/data/data-binding-overview).
