using Sitecore.Configuration;
using Sitecore.Diagnostics;
using Sitecore.Globalization;

namespace SharedSitecore.Extensions
{
    public static class TranslateExtensions
    {
        public static string TextSetting(this Translate translate, string key)
        {
            Assert.ArgumentNotNull(key, "key");
            var results = Translate.Text(key);
            if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
            return results;
        }

        public static string TextSettingByDomain(this Translate translate, string domain, TranslateOptions options, string key, params object[] parameters)
        {
            Assert.ArgumentNotNull(options, "options");
            Assert.ArgumentNotNull(key, "key");
            var results = Translate.TextByDomain(domain, options, key, parameters);
            if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
            return results;
        }


		public static string TextSettingByDomain(this Translate translate, string domain, string key, params object[] parameters)
		{
			Assert.ArgumentNotNull(key, "key");
			var results = Translate.TextByDomain(domain, key, parameters);
			if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
			return results;
		}

		/// <summary>
		/// Gets the localized string for the key.
		/// </summary>
		/// <param name="key">
		/// The text key.
		/// </param>
		/// <param name="parameters">
		/// The parameters.
		/// </param>
		/// <returns>
		/// The translated text for given key.
		/// </returns>
		/// <remarks>
		/// The localized string is formatted using String.Format.
		/// </remarks>
		public static string TextSetting(this Translate translate, string key, params object[] parameters)
		{
			Assert.ArgumentNotNull(key, "key");
			Assert.ArgumentNotNull(parameters, "parameters");
			var results = Translate.Text(key, parameters);
			if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
			return results;
		}

		/// <summary>
		/// Gets a localized string.
		/// </summary>
		/// <param name="key">
		/// The key of the string.
		/// </param>
		/// <param name="language">
		/// The language identifier.
		/// </param>
		/// <returns>
		/// The localized string.
		/// </returns>
		/// <remarks>
		/// If the key is not found, the key itself is returned.
		/// </remarks>
		/// <example>
		/// <code lang="CS">
		/// string myText = Translate.Text("My Text", "da");
		/// </code>
		/// </example>
		public static string TextSettingByLanguage(this Translate translate, string key, Language language)
		{
			Assert.ArgumentNotNull(key, "key");
			Assert.ArgumentNotNull(language, "language");
			var results = Translate.TextByLanguage(key, language);
			if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
			return results;
		}

		/// <summary>
		/// Texts the by language no default.
		/// </summary>
		/// <param name="key">
		/// The text key.
		/// </param>
		/// <param name="language">
		/// The language.
		/// </param>
		/// <param name="defaultValue">
		/// The default value.
		/// </param>
		/// <returns>
		/// The by language.
		/// </returns>
		public static string TextSettingByLanguage(this Translate translate, string key, Language language, string defaultValue)
		{
			Assert.ArgumentNotNull(key, "key");
			Assert.ArgumentNotNull(language, "language");
			var results = Translate.TextByLanguage(key, language, defaultValue);
			if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
			return results;
		}

		/// <summary>
		/// Texts the by language no default.
		/// </summary>
		/// <param name="key">The text key.</param>
		/// <param name="language">The language.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <param name="parameters">String replacement parameters.</param>
		/// <returns>The by text language.</returns>
		public static string TextSettingByLanguage(this Translate translate, string key, Language language, string defaultValue, params object[] parameters)
		{
			Assert.ArgumentNotNull(language, "language");
			var results = Translate.TextByLanguage(key, language, defaultValue, parameters);
			if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
			return results;
		}

		/// <summary>
		/// Texts the by language.
		/// </summary>
		/// <param name="domainName">Name of the domain.</param>
		/// <param name="options">The options.</param>
		/// <param name="key">The phrase key.</param>
		/// <param name="language">The language.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <param name="parameters">The parameters.</param>
		/// <returns>The translated phrade for specified combination of key, language, domain</returns>
		public static string TextSettingByLanguage(this Translate translate, string domainName, TranslateOptions options, string key, Language language, string defaultValue, params object[] parameters)
		{
			Assert.ArgumentNotNull(options, "options");
			Assert.ArgumentNotNull(language, "language");
			var results = Translate.TextByLanguage(domainName, options, key, language, defaultValue, parameters);
			if (string.IsNullOrEmpty(results)) results = Settings.GetSetting(key);
			return results;
		}
	}
}