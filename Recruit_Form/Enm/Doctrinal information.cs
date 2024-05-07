using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum Doctrinal_information
    {
        [Description("المعلومات العقائدية (جيد)")]
        ReligiousKnowledgeGood=1,
        [Description("المعلومات العقائدية (متوسط)")]
        ReligiousKnowledgeAverage,
        [Description("المعلومات العقائدية (ضعيف)")]
        ReligiousKnowledgeWeak,
        [Description("ليس لديه معلومات عقائدية")]
        NoReligiousKnowledge,
    }
}
