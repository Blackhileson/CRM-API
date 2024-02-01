using DataAccess.Entities;
using DataAccess.Logic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess
{
    public class Service : Iservice
    {

        ManageEmployeeMasterLogic _ManageEmployeeMaster;
        public ManageEmployeeMasterLogic ManageEmployeeMaster
        {
            get
            {
                if (_ManageEmployeeMaster == null)
                {
                    _ManageEmployeeMaster = new ManageEmployeeMasterLogic(new AppDbContext());
                }
                return _ManageEmployeeMaster;
            }
        }

        DomainRegistrationLogic _DomainRegistration;
        public DomainRegistrationLogic DomainRegistration
        {
            get
            {
                if (_DomainRegistration == null)
                {
                    _DomainRegistration = new DomainRegistrationLogic(new AppDbContext());
                }
                return _DomainRegistration;
            }
        }

        WebHostingLogic _WebHosting;
        public WebHostingLogic WebHosting
        {
            get
            {
                if (_WebHosting == null)
                {
                    _WebHosting = new WebHostingLogic(new AppDbContext());
                }
                return _WebHosting;
            }
        }

        EmailAccountLogic _EmailAccount;
        public EmailAccountLogic EmailAccount
        {
            get
            {
                if (_EmailAccount == null)
                {
                    _EmailAccount = new EmailAccountLogic(new AppDbContext());
                }
                return _EmailAccount;
            }
        }

        SEOSubmissionLogic _SEOSubmission;
        public SEOSubmissionLogic SEOSubmission
        {
            get
            {
                if (_SEOSubmission == null)
                {
                    _SEOSubmission = new SEOSubmissionLogic(new AppDbContext());
                }
                return _SEOSubmission;
            }
        }

        WebsiteDesigningLogic _WebsiteDesigning;
        public WebsiteDesigningLogic WebsiteDesigning
        {
            get
            {
                if (_WebsiteDesigning == null)
                {
                    _WebsiteDesigning = new WebsiteDesigningLogic(new AppDbContext());
                }
                return _WebsiteDesigning;
            }
        }

        WebApplicationLogic _WebApplication;
        public WebApplicationLogic WebApplication
        {
            get
            {
                if (_WebApplication == null)
                {
                    _WebApplication = new WebApplicationLogic(new AppDbContext());
                }
                return _WebApplication;
            }
        }

        SoftwareDevelopmentLogic _SoftwareDevelopment;
        public SoftwareDevelopmentLogic SoftwareDevelopment
        {
            get
            {
                if (_SoftwareDevelopment == null)
                {
                    _SoftwareDevelopment = new SoftwareDevelopmentLogic(new AppDbContext());
                }
                return _SoftwareDevelopment;
            }
        }


        MobileApplicationLogic _MobileApplication;
        public MobileApplicationLogic MobileApplication
        {
            get
            {
                if (_MobileApplication == null)
                {
                    _MobileApplication = new MobileApplicationLogic(new AppDbContext());
                }
                return _MobileApplication;
            }
        }


        CorporateBrandingLogic _CorporateBranding;
        public CorporateBrandingLogic CorporateBranding
        {
            get
            {
                if (_CorporateBranding == null)
                {
                    _CorporateBranding = new CorporateBrandingLogic(new AppDbContext());
                }
                return _CorporateBranding;
            }
        }


        SSLCertificateLogic _SSLCertificate;
        public SSLCertificateLogic SSLCertificate
        {
            get
            {
                if (_SSLCertificate == null)
                {
                    _SSLCertificate = new SSLCertificateLogic(new AppDbContext());
                }
                return _SSLCertificate;
            }
        }

        ServicePasswordLogic _ServicePassword;
        public ServicePasswordLogic ServicePassword
        {
            get
            {
                if (_ServicePassword == null)
                {
                    _ServicePassword = new ServicePasswordLogic(new AppDbContext());
                }
                return _ServicePassword;
            }
        }

        SMMSubmissionLogic _SMMSubmission;
        public SMMSubmissionLogic SMMSubmission
        {
            get
            {
                if (_SMMSubmission == null)
                {
                    _SMMSubmission = new SMMSubmissionLogic(new AppDbContext());
                }
                return _SMMSubmission;
            }
        }

        ERPImplementataionLogic _ERPImplementataion;
        public ERPImplementataionLogic ERPImplementataion
        {
            get
            {
                if (_ERPImplementataion == null)
                {
                    _ERPImplementataion = new ERPImplementataionLogic(new AppDbContext());
                }
                return _ERPImplementataion;
            }
        }

        MonthLogic _Month;
        public MonthLogic Month
        {
            get
            {
                if (_Month == null)
                {
                    _Month = new MonthLogic(new AppDbContext());
                }
                return _Month;
            }
        }



        TaskListLogic _TaskList;
        public TaskListLogic TaskList
        {
            get
            {
                if (_TaskList == null)
                {
                    _TaskList = new TaskListLogic(new AppDbContext());
                }
                return _TaskList;
            }
        }

        DailytaskLogic _Dailytask;
        public DailytaskLogic Dailytask
        {
            get
            {
                if (_Dailytask == null)
                {
                    _Dailytask = new DailytaskLogic(new AppDbContext());
                }
                return _Dailytask;
            }
        }

        StatusLogic _Status;
        public StatusLogic Status
        {
            get
            {
                if (_Status == null)
                {
                    _Status = new StatusLogic(new AppDbContext());
                }
                return _Status;
            }
        }


        EmailCredentialLogic _EmailCredential;
        public EmailCredentialLogic EmailCredential
        {
            get
            {
                if (_EmailCredential == null)
                {
                    _EmailCredential = new EmailCredentialLogic(new AppDbContext());
                }
                return _EmailCredential;
            }
        }

        EmailTemplateLogic _EmailTemplate;
        public EmailTemplateLogic EmailTemplate
        {
            get
            {
                if (_EmailTemplate == null)
                {
                    _EmailTemplate = new EmailTemplateLogic(new AppDbContext());
                }
                return _EmailTemplate;
            }
        }



        DesignationLogic _Designation;
        public DesignationLogic Designation
        {
            get
            {
                if (_Designation == null)
                {
                    _Designation = new DesignationLogic(new AppDbContext());
                }
                return _Designation;
            }
        }

        ManageYearLogic _ManageYear;
        public ManageYearLogic ManageYear
        {
            get
            {
                if (_ManageYear == null)
                {
                    _ManageYear = new ManageYearLogic(new AppDbContext());
                }
                return _ManageYear;
            }
        }

        ManageVenderLogic _ManageVender;
        public ManageVenderLogic ManageVender
        {
            get
            {
                if (_ManageVender == null)
                {
                    _ManageVender = new ManageVenderLogic(new AppDbContext());
                }
                return _ManageVender;
            }
        }

        BankAccountLogic _BankAccount;
        public BankAccountLogic BankAccount
        {
            get
            {
                if (_BankAccount == null)
                {
                    _BankAccount = new BankAccountLogic(new AppDbContext());
                }
                return _BankAccount;
            }
        }

        ManageBankLogic _ManageBank;
        public ManageBankLogic ManageBank
        {
            get
            {
                if (_ManageBank == null)
                {
                    _ManageBank = new ManageBankLogic(new AppDbContext());
                }
                return _ManageBank;
            }
        }

        HonoroficLogic _Honorofic;
        public HonoroficLogic Honorofic
        {
            get
            {
                if (_Honorofic == null)
                {
                    _Honorofic = new HonoroficLogic(new AppDbContext());
                }
                return _Honorofic;
            }
        }

        GenderLogic _Gender;
        public GenderLogic Gender
        {
            get
            {
                if (_Gender == null)
                {
                    _Gender = new GenderLogic(new AppDbContext());
                }
                return _Gender;
            }
        }

        CompanyDocumentGroupLogic _CompanyDocumentGroup;
        public CompanyDocumentGroupLogic CompanyDocumentGroup
        {
            get
            {
                if (_CompanyDocumentGroup == null)
                {
                    _CompanyDocumentGroup = new CompanyDocumentGroupLogic(new AppDbContext());
                }
                return _CompanyDocumentGroup;
            }
        }

        ServiceGroupLogic _ServiceGroup;
        public ServiceGroupLogic ServiceGroup
        {
            get
            {
                if (_ServiceGroup == null)
                {
                    _ServiceGroup = new ServiceGroupLogic(new AppDbContext());
                }
                return _ServiceGroup;
            }
        }

        DepartmentLogic _Department;
        public DepartmentLogic Department
        {
            get
            {
                if (_Department == null)
                {
                    _Department = new DepartmentLogic(new AppDbContext());
                }
                return _Department;
            }
        }

        CountryLogic _Country;
        public CountryLogic Country
        {
            get
            {
                if (_Country == null)
                {
                    _Country = new CountryLogic(new AppDbContext());
                }
                return _Country;
            }
        }

        StateLogic _State;
        public StateLogic State
        {
            get
            {
                if (_State == null)
                {
                    _State = new StateLogic(new AppDbContext());
                }
                return _State;
            }
        }

        CityLogic _City;
        public CityLogic City
        {
            get
            {
                if (_City == null)
                {
                    _City = new CityLogic(new AppDbContext());
                }
                return _City;
            }
        }

        ManageCustomerLogic _ManageCustomer;
        public ManageCustomerLogic ManageCustomer
        {
            get
            {
                if (_ManageCustomer == null)
                {
                    _ManageCustomer = new ManageCustomerLogic(new AppDbContext());
                }
                return _ManageCustomer;
            }
        }

        ManageEmployeeDocLogic _ManageEmployeeDoc;
        public ManageEmployeeDocLogic ManageEmployeeDoc
        {
            get
            {
                if (_ManageEmployeeDoc == null)
                {
                    _ManageEmployeeDoc = new ManageEmployeeDocLogic(new AppDbContext());
                }
                return _ManageEmployeeDoc;
            }
        }

        ManageLanguageLogic _ManageLanguage;
        public ManageLanguageLogic ManageLanguage
        {
            get
            {
                if (_ManageLanguage == null)
                {
                    _ManageLanguage = new ManageLanguageLogic(new AppDbContext());
                }
                return _ManageLanguage;
            }
        }

        ManageSkillLogic _ManageSkill;
        public ManageSkillLogic ManageSkill
        {
            get
            {
                if (_ManageSkill == null)
                {
                    _ManageSkill = new ManageSkillLogic(new AppDbContext());
                }
                return _ManageSkill;
            }
        }

        ManageTechnologyLogic _ManageTechnology;
        public ManageTechnologyLogic ManageTechnology
        {
            get
            {
                if (_ManageTechnology == null)
                {
                    _ManageTechnology = new ManageTechnologyLogic(new AppDbContext());
                }
                return _ManageTechnology;
            }
        }

        AchievementLogic _Achievement;
        public AchievementLogic Achievement
        {
            get
            {
                if (_Achievement == null)
                {
                    _Achievement = new AchievementLogic(new AppDbContext());
                }
                return _Achievement;
            }
        }

        BloodGroupLogic _BloodGroup;
        public BloodGroupLogic BloodGroup
        {
            get
            {
                if (_BloodGroup == null)
                {
                    _BloodGroup = new BloodGroupLogic(new AppDbContext());
                }
                return _BloodGroup;
            }
        }

        CampaignLogic _Campaign;
        public CampaignLogic Campaign
        {
            get
            {
                if (_Campaign == null)
                {
                    _Campaign = new CampaignLogic(new AppDbContext());
                }
                return _Campaign;
            }
        }

        ClientLogic _Client;
        public ClientLogic Client
        {
            get
            {
                if (_Client == null)
                {
                    _Client = new ClientLogic(new AppDbContext());
                }
                return _Client;
            }
        }


        CompanyMasterLogic _CompanyMaster;
        public CompanyMasterLogic CompanyMaster
        {
            get
            {
                if (_CompanyMaster == null)
                {
                    _CompanyMaster = new CompanyMasterLogic(new AppDbContext());
                }
                return _CompanyMaster;
            }
        }

        ContactLogic _Contact;
        public ContactLogic Contact
        {
            get
            {
                if (_Contact == null)
                {
                    _Contact = new ContactLogic(new AppDbContext());
                }
                return _Contact;
            }
        }

        HolidaysLogic _Holidays;
        public HolidaysLogic Holidays
        {
            get
            {
                if (_Holidays == null)
                {
                    _Holidays = new HolidaysLogic(new AppDbContext());
                }
                return _Holidays;
            }
        }

        IndustrySectorLogic _IndustrySector;
        public IndustrySectorLogic IndustrySector
        {
            get
            {
                if (_IndustrySector == null)
                {
                    _IndustrySector = new IndustrySectorLogic(new AppDbContext());
                }
                return _IndustrySector;
            }
        }


        LeadMasterLogic _LeadMaster;
        public LeadMasterLogic LeadMaster
        {
            get
            {
                if (_LeadMaster == null)
                {
                    _LeadMaster = new LeadMasterLogic(new AppDbContext());
                }
                return _LeadMaster;
            }
        }

        LeadHistoryLogic _LeadHistory;
        public LeadHistoryLogic LeadHistory
        {
            get
            {
                if (_LeadHistory == null)
                {
                    _LeadHistory = new LeadHistoryLogic(new AppDbContext());
                }
                return _LeadHistory;
            }
        }

        LeadTypeLogic _LeadType;
        public LeadTypeLogic LeadType
        {
            get
            {
                if (_LeadType == null)
                {
                    _LeadType = new LeadTypeLogic(new AppDbContext());
                }
                return _LeadType;
            }
        }

        LeaveAddonLogic _LeaveAddon;
        public LeaveAddonLogic LeaveAddon
        {
            get
            {
                if (_LeaveAddon == null)
                {
                    _LeaveAddon = new LeaveAddonLogic(new AppDbContext());
                }
                return _LeaveAddon;
            }
        }

        LeaveMasterLogic _LeaveMaster;
        public LeaveMasterLogic LeaveMaster
        {
            get
            {
                if (_LeaveMaster == null)
                {
                    _LeaveMaster = new LeaveMasterLogic(new AppDbContext());
                }
                return _LeaveMaster;
            }
        }

        LeaveParameterLogic _LeaveParameter;
        public LeaveParameterLogic LeaveParameter
        {
            get
            {
                if (_LeaveParameter == null)
                {
                    _LeaveParameter = new LeaveParameterLogic(new AppDbContext());
                }
                return _LeaveParameter;
            }
        }

        NoticeBoardLogic _NoticeBoard;
        public NoticeBoardLogic NoticeBoard
        {
            get
            {
                if (_NoticeBoard == null)
                {
                    _NoticeBoard = new NoticeBoardLogic(new AppDbContext());
                }
                return _NoticeBoard;
            }
        }

        OrderLogic _Order;
        public OrderLogic Order
        {
            get
            {
                if (_Order == null)
                {
                    _Order = new OrderLogic(new AppDbContext());
                }
                return _Order;
            }
        }

        PriorityLogic _Priority;
        public PriorityLogic Priority
        {
            get
            {
                if (_Priority == null)
                {
                    _Priority = new PriorityLogic(new AppDbContext());
                }
                return _Priority;
            }
        }

        ProjectLogic _Project;
        public ProjectLogic Project
        {
            get
            {
                if (_Project == null)
                {
                    _Project = new ProjectLogic(new AppDbContext());
                }
                return _Project;
            }
        }

        ProjectMeetingLogic _ProjectMeeting;
        public ProjectMeetingLogic ProjectMeeting
        {
            get
            {
                if (_ProjectMeeting == null)
                {
                    _ProjectMeeting = new ProjectMeetingLogic(new AppDbContext());
                }
                return _ProjectMeeting;
            }
        }


        ProjectPhaseLogic _ProjectPhase;
        public ProjectPhaseLogic ProjectPhase
        {
            get
            {
                if (_ProjectPhase == null)
                {
                    _ProjectPhase = new ProjectPhaseLogic(new AppDbContext());
                }
                return _ProjectPhase;
            }
        }

        PunchDataLogic _PunchData;
        public PunchDataLogic PunchData
        {
            get
            {
                if (_PunchData == null)
                {
                    _PunchData = new PunchDataLogic(new AppDbContext());
                }
                return _PunchData;
            }
        }

        ShiftMasterLogic _ShiftMaster;
        public ShiftMasterLogic ShiftMaster
        {
            get
            {
                if (_ShiftMaster == null)
                {
                    _ShiftMaster = new ShiftMasterLogic(new AppDbContext());
                }
                return _ShiftMaster;
            }
        }


        StarLogic _Star;
        public StarLogic Star
        {
            get
            {
                if (_Star == null)
                {
                    _Star = new StarLogic(new AppDbContext());
                }
                return _Star;
            }
        }

        StarAssignLogic _StarAssign;
        public StarAssignLogic StarAssign
        {
            get
            {
                if (_StarAssign == null)
                {
                    _StarAssign = new StarAssignLogic(new AppDbContext());
                }
                return _StarAssign;
            }
        }

        WorklistLogic _Worklist;
        public WorklistLogic Worklist
        {
            get
            {
                if (_Worklist == null)
                {
                    _Worklist = new WorklistLogic(new AppDbContext());
                }
                return _Worklist;
            }
        }

        CustomerLogic _Customer;
        public CustomerLogic Customer
        {
            get
            {
                if (_Customer == null)
                {
                    _Customer = new CustomerLogic(new AppDbContext());
                }
                return _Customer;
            }
        }



    }
}
