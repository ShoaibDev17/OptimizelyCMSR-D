using EPiServer.Forms.EditView.Models.Internal;
using EPiServer.Forms.Implementation.Elements;

namespace Optimizely_Project.Models.Blocks
{
	[ContentType(
		   DisplayName = "Third Custom form Block",
		   GUID = "6c231015-1a9d-4eb5-8223-cbee2de9111a",
		   Description = "Use when you need the options in another language",
		   GroupName = "Custom Elements")]
	public class ThirdCustomFormBlock : SelectionElementBlock
	{
		[CultureSpecific]
		public override IEnumerable<OptionItem> Items { get; set; }

        //private TextareaElementBlock _textBlock;
        //public virtual TextareaElementBlock textBlock { get; set; }
        //{
        //    get
        //    {
        //        if (_textBlock == null)
        //        {
        //            _textBlock = new TextareaElementBlock();
        //        }
        //        return _textBlock;
        //    }
        //     set
        //    {
        //        _textBlock = value;
        //    }
        //}
    }

    //[ContentType(
    //       DisplayName = "Third Custom Text Area Block",
    //       GUID = "6c233015-1a9d-4eb5-8223-cbee2de9111a",
    //       Description = "Use when you need the options in another language",
    //       GroupName = "Text Area Block Elements")]
    //public class ThirdCustomtTextFormBlock : TextareaElementBlock
    //{
    //}
}
