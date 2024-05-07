using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum Appearance
    {
        [Description("المظهر الخارجي لائق")]
        GoodAppearance=1,
        [Description("المظهر الخارجي غير لائق")]
        InappropriateAppearance,
        [Description("المظهر الخارجي غير محتشم")]
        ImmodestAppearance,
    }
}
