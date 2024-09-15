using System.Globalization;
using System.Reflection;
using System.Resources;

namespace TicketVending.Languages;

public class Lang(string lang)
{
    ResourceManager _resourceManager = new("TicketVending.Languages.Languages", Assembly.GetExecutingAssembly());
    CultureInfo _culture = CultureInfo.GetCultureInfo(lang);

    public string Get(string key)
    {
        return _resourceManager.GetString(key, _culture) ?? key;
    }
}