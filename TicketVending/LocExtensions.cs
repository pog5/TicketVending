using System;
using TicketVending.ViewModels;

namespace TicketVending;

using Avalonia.Data;
using Avalonia.Markup.Xaml;
using System.Globalization;
using System.Resources;
using System.Reflection;

public class LocExtension : MarkupExtension
{
    private static ResourceManager _resourceManager =
        new ResourceManager("TicketVending.Languages.Languages", Assembly.GetExecutingAssembly());

    public string Key { get; set; }

    public override object ProvideValue(IServiceProvider serviceProvider)
    {
        // You'll need a way to get the current language here.
        // This example assumes you can access it from a static property.
        string currentLanguage = Program.CurrentLanguage; // Get language somehow

        if (string.IsNullOrEmpty(Key) || string.IsNullOrEmpty(currentLanguage))
            return Key;

        CultureInfo cultureInfo = CultureInfo.GetCultureInfo(currentLanguage);
        return _resourceManager.GetString(Key, cultureInfo) ?? Key;
    }
}