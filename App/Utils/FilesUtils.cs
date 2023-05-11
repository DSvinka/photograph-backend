using App.Extensions;
using Domain.Models;
using Domain.Shared.Enums;

namespace App.Utils;

public static class FilesUtils
{
    public static EFileType? GetFileType(this IFormFile file)
    {
        var fileTypeString = Path.GetExtension(file.FileName).ToLower();
        return GetFileType(fileTypeString);
    }
    
    public static EFileType? GetFileType(string fileTypeString)
    {
        EFileType fileType;

        switch (fileTypeString)
        {
            case "png":
                fileType = EFileType.Png;
                break;

            case "jpg":
                fileType = EFileType.Jpg;
                break;

            case "jpeg":
                fileType = EFileType.Jpeg;
                break;

            case "mp3":
                fileType = EFileType.Mp3;
                break;

            case "wav":
                fileType = EFileType.Wav;
                break;

            default:
                return null;
        }

        return fileType;
    }

    public static string GetFileName(this IFormFile file, EFileType fileType)
    {
        return GetFileName(file.FileName, fileType);
    }
    
    public static string GetFileName(string fileName, EFileType fileType)
    {
        return fileName + "." + fileType.GetDisplayName();
    }

    public static string GetFileUrl(this FileModel file, SettingsModel settings)
    {
        return $"{settings.BackendUrl}/files/{file.Id}.{file.FileType.GetDisplayName()}";
    }
}