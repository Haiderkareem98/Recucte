using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum ComputerSkills
    {
        [Description("يجيد العمل على برامج الحاسوب")]
        ProficientComputerSkills=1,
        [Description("يجيد العمل على برنامج الوورد والاكسل")]
        ProficientInWordAndExcel,
        [Description("يجيد العمل على برنامج الاكسل فقط")]
        ProficientInExcelOnly,
        [Description("يجيد العمل على برنامج الوورد فقط")]
        ProficientInWordOnly,
    }
}
