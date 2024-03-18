using System.ComponentModel.DataAnnotations;

namespace Optimizely_Project;

public class Globals
{
    public const string LoginPath = "/util/login";

    /// <summary>
    /// Group names for content types and properties
    /// </summary>
    [GroupDefinitions]
    public static class GroupNames
    {
        [Display(Name = "Default", Order = 10)]
        public const string Default = "Default";

        [Display(Name = SystemTabNames.Content, Order = 20)]
        public const string Content = SystemTabNames.Content;

        [Display(Name = "Contact", Order = 30)]
        public const string Contact = "Contact";

        [Display(Name = "Metadata", Order = 40)]
        public const string MetaData = "Metadata";

        [Display(Name = "News", Order = 50)]
        public const string News = "News";

        [Display(Name = "Products", Order = 60)]
        public const string Products = "Products";

        [Display(Name = SystemTabNames.Settings, Order = 70)]
        public const string Settings = SystemTabNames.Settings;

        [Display(Name = "SiteSettings", Order = 80)]
        public const string SiteSettings = "SiteSettings";

        [Display(Name = "Specialized", Order = 90)]
        public const string Specialized = "Specialized";
    }

	/// <summary>
	/// Names used for UIHint attributes to map specific rendering controls to page properties
	/// </summary>
	public static class SiteUIHints
    {
        public const string Contact = "contact";
        public const string Strings = "StringList";
        public const string StringsCollection = "StringsCollection";
    }
    /// <summary>
    /// Tags to use for the main widths used in the Bootstrap HTML framework
    /// </summary>
    public static class ContentAreaTags
    {
        public const string FullWidth = "full";
        public const string WideWidth = "wide";
        public const string HalfWidth = "half";
        public const string NarrowWidth = "narrow";
        public const string NoRenderer = "norenderer";
        public const string TwoThirdsWidth = "TwoThirdsWidth";
        public const string OneThirdWidth = "TwoThirdsWidth";
    }
    public static class FormDisplayOptionTags
    {
        public static readonly string[] FullWidth = new string[] { "span12", "col-xs-12", "col-sm-12", "col-md-12", "col-lg-12" };
        public static readonly string[] ThirdQuaterWidth = new string[] { "span9", "col-xs-9", "col-sm-9", "col-md-9", "col-lg-9" };
        public static readonly string[] TwoThirdsWidth = new string[] { "span8", "col-xs-8", "col-sm-8", "col-md-8", "col-lg-8" };
        public static readonly string[] HalfWidth = new string[] { "span6", "col-xs-6", "col-sm-6", "col-md-6", "col-lg-6" };
        public static readonly string[] OneThirdWidth = new string[] { "span4", "col-xs-4", "col-sm-4", "col-md-4", "col-lg-4" };
        public static readonly string[] OneQuaterWidth = new string[] { "span3", "col-xs-3", "col-sm-3", "col-md-3", "col-lg-3" };
    }
    /// <summary>
    /// Virtual path to folder with static graphics, such as "/gfx/"
    /// </summary>
    public const string StaticGraphicsFolderPath = "/gfx/";
}
