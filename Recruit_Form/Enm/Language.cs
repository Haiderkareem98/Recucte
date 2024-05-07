using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum Language
    {
        [Description("يجيد تحدث اللغة الانكليزية")]
        FluentInEnglish=1,
        [Description("يجيد تحدث اللغة الفارسية")]
        FluentInPersian,
        [Description("يجيد تحدث اللغة الفرنسية")]
        FluentInFrench
    }

}

