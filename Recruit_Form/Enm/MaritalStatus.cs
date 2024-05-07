using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum MaritalStatus
    {
        [Description("اعزب")]
        Single=1,
        [Description("عزباء")]
        SingleFemale,
        [Description("متزوج")]
        Married,
        [Description("متزوجة")]
        MarriedFemale,
        [Description("منفصل")]
        Divorced,
        [Description("منفصلة")]
        DivorcedFemale,
        [Description("ارمل")]
        Widowed,
        [Description("أرملة")]
        WidowedFemale,
        [Description("أخرى")]
        Other
    }

}
