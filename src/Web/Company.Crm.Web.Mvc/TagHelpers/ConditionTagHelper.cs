using Microsoft.AspNetCore.Razor.TagHelpers;

namespace Company.Crm.Web.Mvc.TagHelpers;

//[HtmlTargetElement("cmg", Attributes = "cmg-if")) ikili kullan�m
[HtmlTargetElement(Attributes = "cmg-if")] //Ba�ka yerlerdede kullanabilmek i�in (mesela <div cmg-if></div> olarak kullanabilirim)
public class ConditionTagHelper : TagHelper
{
    [HtmlAttributeName("cmg-if")]
    public bool Condition { get; set; } = true;

    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        if (!Condition)
        {
            output.TagName = null;

            output.SuppressOutput();
        }
    }
}
