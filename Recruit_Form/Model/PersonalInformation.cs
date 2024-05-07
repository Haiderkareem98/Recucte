using Recruit_Form.Enm;

namespace Recruit_Form.Model
{
    public class PersonalInformation
    {
        public int PersonalInformationId {  get; set; }
        public string? FirstName { get; set; }
        public string? SecondName { get; set; }
        public string? ThirdName { get; set; }
        public string? Fourth_Name { get; set; }
        public string? Surname { get; set; }
        public string? Phone { get; set; }
        public Enm.EducationLevel EducationLevel { get; set; }
        public string? ScientificSpecialization { get; set; }
        public Conservation Conservation { get; set; }
        public string? BirthYaer { get; set; }
        public MaritalStatus MaritalStatus { get; set; }
        public string? IdentifieName { get; set; }
        public string? IdentifieWorkPlace { get; set; }
        public string? Sessions { get; set; }
        public string? WorkplacesExperience { get; set; }
        public string? Notes { get; set; }
        public bool IsFamiliesMartyrsAndWounded { get; set; }
        //[IgnoreMapper]
        //public List<MartyrStatus>? MartyrStatus { get; set; }
       public Language Language { get; set; }
        public Appearance Appearance { get; set; }
        public Doctrinal_information doctrinal_Information { get; set; }
        public SkilledInDriving SkilledInDriving { get; set; }
        public ComputerSkills ComputerSkills { get; set; }

        public Technical_Information technical_Information { get; set; }
        public string? ProposedAddition { get; set; }
        public string? CommunityCovenant { get; set; }
        public int DegreeOfConfrontation { get; set; }
       // public InterviewPurpose InterviewPurpose { get; set; }
        //public Guid MediaFileId { get; set; }
        //public MediaFile? MediaFile { get; set; }


    }
}
