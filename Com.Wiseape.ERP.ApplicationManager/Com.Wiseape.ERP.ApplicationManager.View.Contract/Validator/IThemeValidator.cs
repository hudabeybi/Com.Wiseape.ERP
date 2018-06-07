using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Com.Wiseape.Framework;

namespace Com.Wiseape.ERP.ApplicationManager.View.Contract.Validator
{
    public interface IThemeValidator
    {

		ValidationResult ValidateThemeName(Int16 idTheme, string themeName);

		ValidationResult ValidateThemeName(string themeName);

		ValidationResult ValidateThemeInfo(Int16 idTheme, string themeInfo);

		ValidationResult ValidateThemeInfo(string themeInfo);

		ValidationResult ValidateLoadingAnimation(Int16 idTheme, string loadingAnimation);

		ValidationResult ValidateLoadingAnimation(string loadingAnimation);

		ValidationResult ValidateLoadingAnimationAudio(Int16 idTheme, string loadingAnimationAudio);

		ValidationResult ValidateLoadingAnimationAudio(string loadingAnimationAudio);

		ValidationResult ValidateDefaultWallpaper(Int16 idTheme, string defaultWallpaper);

		ValidationResult ValidateDefaultWallpaper(string defaultWallpaper);

		ValidationResult ValidateTaskbarColor(Int16 idTheme, string taskbarColor);

		ValidationResult ValidateTaskbarColor(string taskbarColor);

		ValidationResult ValidateTaskbarMenuColor(Int16 idTheme, string taskbarMenuColor);

		ValidationResult ValidateTaskbarMenuColor(string taskbarMenuColor);

	}
}