using DataAccess.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface Iservice
    {
        ManageEmployeeMasterLogic ManageEmployeeMaster { get; }
        ManageYearLogic ManageYear { get; }
        BankAccountLogic BankAccount { get; }
        ManageBankLogic ManageBank { get; }
        HonoroficLogic Honorofic { get; }
        GenderLogic Gender { get; }
        CompanyDocumentGroupLogic CompanyDocumentGroup { get; }
        ServiceGroupLogic ServiceGroup { get; }
        DepartmentLogic Department { get; }
        CountryLogic Country { get; }
        StateLogic State { get; }
        CityLogic City { get; }
        ManageVenderLogic ManageVender { get; }
        ManageCustomerLogic ManageCustomer { get; }
        ManageEmployeeDocLogic ManageEmployeeDoc { get; }
        ManageLanguageLogic ManageLanguage { get; }
        ManageSkillLogic ManageSkill { get; }
        AchievementLogic Achievement { get; }
        BloodGroupLogic BloodGroup { get; }
        CampaignLogic Campaign { get; }
        ClientLogic Client { get; }
        CompanyMasterLogic CompanyMaster { get; }
        ContactLogic Contact { get; }
        HolidaysLogic Holidays { get; }
        IndustrySectorLogic IndustrySector { get; }
        LeadMasterLogic LeadMaster { get; }
        LeadHistoryLogic LeadHistory { get; }
        LeadTypeLogic LeadType { get; }
        LeaveAddonLogic LeaveAddon { get; }
        LeaveMasterLogic LeaveMaster { get; }
        LeaveParameterLogic LeaveParameter { get; }
        NoticeBoardLogic NoticeBoard { get; }
        OrderLogic Order { get; }
        PriorityLogic Priority { get; }
        ProjectLogic Project { get; }
        ProjectMeetingLogic ProjectMeeting { get; }
        ProjectPhaseLogic ProjectPhase { get; }
        PunchDataLogic PunchData { get; }
        ShiftMasterLogic ShiftMaster { get; }
        StarLogic Star { get; }
        StarAssignLogic StarAssign { get; }
        WorklistLogic Worklist { get; }
        CustomerLogic Customer { get; }
        DesignationLogic Designation { get; }
        TaskListLogic TaskList { get; }
        EmailCredentialLogic EmailCredential { get; }
        EmailTemplateLogic EmailTemplate { get; }
        StatusLogic Status { get; }
        DailytaskLogic Dailytask { get; }
        MonthLogic Month { get; }
        DomainRegistrationLogic DomainRegistration { get; }
        WebHostingLogic WebHosting { get; }
        EmailAccountLogic  EmailAccount { get; }
        SEOSubmissionLogic SEOSubmission { get; }
        WebsiteDesigningLogic WebsiteDesigning { get; }
        WebApplicationLogic WebApplication { get; }
        SoftwareDevelopmentLogic SoftwareDevelopment { get; }
        MobileApplicationLogic MobileApplication { get; }
        CorporateBrandingLogic CorporateBranding { get; }
        SSLCertificateLogic SSLCertificate { get; }
        ServicePasswordLogic ServicePassword { get; }
        SMMSubmissionLogic SMMSubmission { get; }
        ERPImplementataionLogic ERPImplementataion { get; }


    }
}