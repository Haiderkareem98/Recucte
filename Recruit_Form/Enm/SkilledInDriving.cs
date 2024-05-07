using System.ComponentModel;

namespace Recruit_Form.Enm
{
    public enum SkilledInDriving
    {
        [Description("يجيد قيادة العجلات الصالون")]
        SkilledInDrivingSedans = 1,
        [Description("يجيد قيادة المعدات الثقيلة")]
        SkilledInDrivingHeavyEquipment,
        [Description("يجيد استخدام السلاح المتوسط")]
        ProficientWithMediumWeapons,
        [Description("يجيد استخدام السلاح الثقيل")]
        ProficientWithHeavyWeapons,
    }
}
