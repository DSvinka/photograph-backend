using System.ComponentModel.DataAnnotations;

namespace Domain.Shared.Enums;

public enum EFileType
{
    [Display(Name="jpeg")]
    Jpeg = 0,
    
    [Display(Name="jpg")]
    Jpg = 1,

    [Display(Name="png")]
    Png = 2,
    
    [Display(Name="gif")]
    Gif = 3,
    
    [Display(Name="wav")]
    Wav = 4,
    
    [Display(Name="mp3")]
    Mp3 = 5,
}