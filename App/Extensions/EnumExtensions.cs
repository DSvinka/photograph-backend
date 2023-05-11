using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace App.Extensions;

public static class EnumExtensions
{
    public static string ToDescriptionString<TEnum>(this TEnum @enum)
    {
        if (@enum == null)
            return string.Empty;

        var info = @enum.GetType().GetField(@enum.ToString() ?? string.Empty);
        if (info == null)
            return string.Empty;
        
        var attributes = (DescriptionAttribute[]) info.GetCustomAttributes(typeof(DescriptionAttribute), false);
        return attributes[0].Description;
    }
    
    public static string GetDisplayName<TEnum>(this TEnum @enum)
    {
        if (@enum == null)
            return string.Empty;

        var info = @enum.GetType().GetField(@enum.ToString() ?? string.Empty);
        if (info == null)
            return string.Empty;
        
        var attributes = (DisplayAttribute[]) info.GetCustomAttributes(typeof(DisplayAttribute), false);
        return attributes[0].Name;
    }
    
    public static string GetDisplayShortName<TEnum>(this TEnum @enum)
    {
        if (@enum == null)
            return string.Empty;

        var info = @enum.GetType().GetField(@enum.ToString() ?? string.Empty);
        if (info == null)
            return string.Empty;
        
        var attributes = (DisplayAttribute[]) info.GetCustomAttributes(typeof(DisplayAttribute), false);
        return attributes[0].ShortName;
    }
}