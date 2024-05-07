using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum Technical_Information
    {
        [Description("المعلومات حول التخصص الاكاديمي ممتاز")]
        Excellent = 1,
        [Description("المعلومات حول التخصص الاكاديمي جيد")]
        Good,
        [Description("المعلومات حول التخصص الاكاديمي متوسط")]
        Average,
        [Description("المعلومات حول التخصص الاكاديمي ضعيف")]
        Weak,
        [Description("لم يمارس العمل في مجال تخصصه الاكاديمي")]
        NoExperienceInField,
    }

}
