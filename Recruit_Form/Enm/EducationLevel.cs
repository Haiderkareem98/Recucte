using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum EducationLevel
    {

        [Description("أمي")]
        Illiterate = 1,
        [Description("يقرأ ويكتب")]
        Literate,
        [Description("ابتدائية")]
        Primary,
        [Description("متوسطة")]
        Intermediate,
        [Description("إعدادية")]
        Secondary,
        [Description("بكالوريوس")]
        Bachelor,
        [Description("ماجستير")]
        Master,
        [Description("دكتوراه")]
        Doctorate
    }
}
