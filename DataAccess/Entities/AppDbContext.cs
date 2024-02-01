namespace DataAccess.Entities
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class AppDbContext : DbContext
    {
        public AppDbContext()
            : base("name=AppDbContext")
        {
        }

        public virtual DbSet<AchievementMaster> AchievementMasters { get; set; }
        public virtual DbSet<BankACTypeMaster> BankACTypeMasters { get; set; }
        public virtual DbSet<BankInfromationMaster> BankInfromationMasters { get; set; }
        public virtual DbSet<BankMaster> BankMasters { get; set; }
        public virtual DbSet<BloodGroupMaster> BloodGroupMasters { get; set; }
        public virtual DbSet<CampaignCategory> CampaignCategories { get; set; }
        public virtual DbSet<CampaignContactCategory> CampaignContactCategories { get; set; }
        public virtual DbSet<CampaignMaster> CampaignMasters { get; set; }
        public virtual DbSet<CityMaster> CityMasters { get; set; }
        public virtual DbSet<ClientMaster> ClientMasters { get; set; }
        public virtual DbSet<CompanyDocumentTypeMaster> CompanyDocumentTypeMasters { get; set; }
        public virtual DbSet<CompanyMaster> CompanyMasters { get; set; }
        public virtual DbSet<ContactMaster> ContactMasters { get; set; }
        public virtual DbSet<CorporateBrandingMaster> CorporateBrandingMasters { get; set; }
        public virtual DbSet<CountryMaster> CountryMasters { get; set; }
        public virtual DbSet<CustomerMaster> CustomerMasters { get; set; }
        public virtual DbSet<DailytaskMaster> DailytaskMasters { get; set; }
        public virtual DbSet<DailyWorkBook> DailyWorkBooks { get; set; }
        public virtual DbSet<DayBook> DayBooks { get; set; }
        public virtual DbSet<DepartmentMaster> DepartmentMasters { get; set; }
        public virtual DbSet<DepartmentRightsMaster> DepartmentRightsMasters { get; set; }
        public virtual DbSet<DesignationMaster> DesignationMasters { get; set; }
        public virtual DbSet<DocumentTypeMaster> DocumentTypeMasters { get; set; }
        public virtual DbSet<DomainRegistrationMaster> DomainRegistrationMasters { get; set; }
        public virtual DbSet<EmailAccountMaster> EmailAccountMasters { get; set; }
        public virtual DbSet<EmailAccountUserMaster> EmailAccountUserMasters { get; set; }
        public virtual DbSet<EmailCredentialMaster> EmailCredentialMasters { get; set; }
        public virtual DbSet<EmailTemplateMaster> EmailTemplateMasters { get; set; }
        public virtual DbSet<EmployeeBankDetailsMaster> EmployeeBankDetailsMasters { get; set; }
        public virtual DbSet<EmployeeMaster> EmployeeMasters { get; set; }
        public virtual DbSet<EmployeeSkillMaster> EmployeeSkillMasters { get; set; }
        public virtual DbSet<ERPImplemetationMaster> ERPImplemetationMasters { get; set; }
        public virtual DbSet<GenderMaster> GenderMasters { get; set; }
        public virtual DbSet<HolidayMaster> HolidayMasters { get; set; }
        public virtual DbSet<HonorificMaster> HonorificMasters { get; set; }
        public virtual DbSet<IndustrySectorMaster> IndustrySectorMasters { get; set; }
        public virtual DbSet<LanguageMaster> LanguageMasters { get; set; }
        public virtual DbSet<LeadFollowup> LeadFollowups { get; set; }
        public virtual DbSet<LeadGroup> LeadGroups { get; set; }
        public virtual DbSet<LeadHistoryMaster> LeadHistoryMasters { get; set; }
        public virtual DbSet<LeadMaster> LeadMasters { get; set; }
        public virtual DbSet<LeadRatio> LeadRatios { get; set; }
        public virtual DbSet<LeadTypeMaster> LeadTypeMasters { get; set; }
        public virtual DbSet<LeaveAddonMaster> LeaveAddonMasters { get; set; }
        public virtual DbSet<LeaveMaster> LeaveMasters { get; set; }
        public virtual DbSet<LeaveParameterMaster> LeaveParameterMasters { get; set; }
        public virtual DbSet<ManageEmployeeDocumentMaster> ManageEmployeeDocumentMasters { get; set; }
        public virtual DbSet<MeetingMOMMaster> MeetingMOMMasters { get; set; }
        public virtual DbSet<MenuMaster> MenuMasters { get; set; }
        public virtual DbSet<MobileApplication> MobileApplications { get; set; }
        public virtual DbSet<MonthMaster> MonthMasters { get; set; }
        public virtual DbSet<NoticeBoardMaster> NoticeBoardMasters { get; set; }
        public virtual DbSet<OrderMaster> OrderMasters { get; set; }
        public virtual DbSet<PriorityMaster> PriorityMasters { get; set; }
        public virtual DbSet<ProjectMaster> ProjectMasters { get; set; }
        public virtual DbSet<ProjectMeetingMaster> ProjectMeetingMasters { get; set; }
        public virtual DbSet<ProjectPhaseMaster> ProjectPhaseMasters { get; set; }
        public virtual DbSet<ProposalHistory> ProposalHistories { get; set; }
        public virtual DbSet<PunchDataMaster> PunchDataMasters { get; set; }
        public virtual DbSet<RolesAndResposibilityMaster> RolesAndResposibilityMasters { get; set; }
        public virtual DbSet<SalesFunnel> SalesFunnels { get; set; }
        public virtual DbSet<SEOSubmissionMaster> SEOSubmissionMasters { get; set; }
        public virtual DbSet<ServiceGroupMaster> ServiceGroupMasters { get; set; }
        public virtual DbSet<ServicePassword> ServicePasswords { get; set; }
        public virtual DbSet<ShiftMaster> ShiftMasters { get; set; }
        public virtual DbSet<SMMSubmission> SMMSubmissions { get; set; }
        public virtual DbSet<SoftwareDevelopmentMaster> SoftwareDevelopmentMasters { get; set; }
        public virtual DbSet<SSLCertificate> SSLCertificates { get; set; }
        public virtual DbSet<StarAssignMaster> StarAssignMasters { get; set; }
        public virtual DbSet<StarMaster> StarMasters { get; set; }
        public virtual DbSet<StateMaster> StateMasters { get; set; }
        public virtual DbSet<StatusMaster> StatusMasters { get; set; }
        public virtual DbSet<TaskDay> TaskDays { get; set; }
        public virtual DbSet<TaskListMaster> TaskListMasters { get; set; }
        public virtual DbSet<TaskTransfer> TaskTransfers { get; set; }
        public virtual DbSet<TaskTransferMaster> TaskTransferMasters { get; set; }
        public virtual DbSet<TechnologyMaster> TechnologyMasters { get; set; }
        public virtual DbSet<TypesOfResponse> TypesOfResponses { get; set; }
        public virtual DbSet<VendorMaster> VendorMasters { get; set; }
        public virtual DbSet<WebApplicationMaster> WebApplicationMasters { get; set; }
        public virtual DbSet<WebDesignMaster> WebDesignMasters { get; set; }
        public virtual DbSet<WebHosting> WebHostings { get; set; }
        public virtual DbSet<WFHBalance> WFHBalances { get; set; }
        public virtual DbSet<WFHLeave> WFHLeaves { get; set; }
        public virtual DbSet<WFHParameter> WFHParameters { get; set; }
        public virtual DbSet<WFHType> WFHTypes { get; set; }
        public virtual DbSet<WorklistMaster> WorklistMasters { get; set; }
        public virtual DbSet<YearMaster> YearMasters { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AchievementMaster>()
                .Property(e => e.AchivementId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AchievementMaster>()
                .Property(e => e.GetEmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AchievementMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AchievementMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<AchievementMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankACTypeMaster>()
                .Property(e => e.BankACTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankInfromationMaster>()
                .Property(e => e.BankInfromationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankInfromationMaster>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankInfromationMaster>()
                .Property(e => e.BankID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankInfromationMaster>()
                .Property(e => e.BankACTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankMaster>()
                .Property(e => e.BankId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BankMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BloodGroupMaster>()
                .Property(e => e.BloodID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BloodGroupMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BloodGroupMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<BloodGroupMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.CampaignCategoryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.CampaignName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.Status)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.LeadsInCampaign)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.ContactInCampaign)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignCategory>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignContactCategory>()
                .Property(e => e.CampaignContactCategoryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignContactCategory>()
                .Property(e => e.CampaignContactName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignContactCategory>()
                .Property(e => e.ContactID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignContactCategory>()
                .Property(e => e.RefferalID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignContactCategory>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignContactCategory>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignContactCategory>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.CampaignID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.CampaignCategoryName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.CampaignContactID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.SalesFunnelId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CampaignMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CityMaster>()
                .Property(e => e.CityId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CityMaster>()
                .Property(e => e.StateId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CityMaster>()
                .Property(e => e.CountryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CityMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CityMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CityMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClientMaster>()
                .Property(e => e.ClientID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClientMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClientMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClientMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ClientMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyDocumentTypeMaster>()
                .Property(e => e.CompanyDocumentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyDocumentTypeMaster>()
                .Property(e => e.DocumentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyDocumentTypeMaster>()
                .Property(e => e.CompanyID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyDocumentTypeMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyDocumentTypeMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyDocumentTypeMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.IndustrialSectorId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.CompanyAge)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.EstablishmentId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.CityId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.StateId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.CountryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.NumberofEmployees)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.WorkingDaysinweek)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.WorkingHoursinday)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CompanyMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.ContactID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.IndustrySector)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.Country)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.State)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.City)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ContactMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CorporateBrandingMaster>()
                .Property(e => e.CorporateBrandingID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CorporateBrandingMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CorporateBrandingMaster>()
                .Property(e => e.CustomerId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CountryMaster>()
                .Property(e => e.CountryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CountryMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CountryMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CountryMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomerMaster>()
                .Property(e => e.CustomerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomerMaster>()
                .Property(e => e.DesignationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomerMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomerMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<CustomerMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.DailyTaskID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.TaskListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.WorkListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.EmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailytaskMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailyWorkBook>()
                .Property(e => e.DailyWorkBookID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailyWorkBook>()
                .Property(e => e.Project)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailyWorkBook>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailyWorkBook>()
                .Property(e => e.TaskListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DailyWorkBook>()
                .Property(e => e.Status)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DayBook>()
                .Property(e => e.DayBookID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DayBook>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DayBook>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DayBook>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DayBook>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentMaster>()
                .Property(e => e.DepartmentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentRightsMaster>()
                .Property(e => e.DepartmentId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentRightsMaster>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<DepartmentRightsMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentRightsMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DepartmentRightsMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DesignationMaster>()
                .Property(e => e.DesignationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DesignationMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DesignationMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DesignationMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DocumentTypeMaster>()
                .Property(e => e.DocumentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DocumentTypeMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DocumentTypeMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DocumentTypeMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DomainRegistrationMaster>()
                .Property(e => e.DomainRegistrationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DomainRegistrationMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DomainRegistrationMaster>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<DomainRegistrationMaster>()
                .Property(e => e.SupplierId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountMaster>()
                .Property(e => e.EmailAccountID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountMaster>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountMaster>()
                .Property(e => e.SupplierId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountUserMaster>()
                .Property(e => e.EmailAccountUserId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountUserMaster>()
                .Property(e => e.EmailAccountId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountUserMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountUserMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailAccountUserMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailCredentialMaster>()
                .Property(e => e.EmailCredentialID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailCredentialMaster>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailCredentialMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailCredentialMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailCredentialMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailTemplateMaster>()
                .Property(e => e.EmailTemplateID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailTemplateMaster>()
                .Property(e => e.EmailCredentialID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailTemplateMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailTemplateMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmailTemplateMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.EmployeeBankDetailID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.BankID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.BankACTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.BankACType)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.BankName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeBankDetailsMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.HonorificID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.CompanyID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.DepartmentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.ShiftID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.MobileNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.AltMobileNo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.CountryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.StateID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.CityID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.GenderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.DesignationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.BloodGrpID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSkillMaster>()
                .Property(e => e.SkillID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSkillMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSkillMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<EmployeeSkillMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ERPImplemetationMaster>()
                .Property(e => e.ERPImplementationId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ERPImplemetationMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ERPImplemetationMaster>()
                .Property(e => e.CustomerId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ERPImplemetationMaster>()
                .Property(e => e.BusinessCategoryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GenderMaster>()
                .Property(e => e.GenderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GenderMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GenderMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<GenderMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HolidayMaster>()
                .Property(e => e.HolidayId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HolidayMaster>()
                .Property(e => e.LeaveParameterId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HolidayMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HolidayMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HolidayMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HonorificMaster>()
                .Property(e => e.HonorificID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HonorificMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HonorificMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<HonorificMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IndustrySectorMaster>()
                .Property(e => e.IndustryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IndustrySectorMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IndustrySectorMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<IndustrySectorMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LanguageMaster>()
                .Property(e => e.LanguageID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LanguageMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LanguageMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LanguageMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadFollowup>()
                .Property(e => e.LeadFollowupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadFollowup>()
                .Property(e => e.LeadName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadFollowup>()
                .Property(e => e.TypeOfFollowUp)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadFollowup>()
                .Property(e => e.Lead)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadFollowup>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadFollowup>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadFollowup>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadGroup>()
                .Property(e => e.LeadGroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadGroup>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadGroup>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadGroup>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadHistoryMaster>()
                .Property(e => e.LeadHistoryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadHistoryMaster>()
                .Property(e => e.LeadTypeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadHistoryMaster>()
                .Property(e => e.LeadResponseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadHistoryMaster>()
                .Property(e => e.LeadGroupId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadHistoryMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadHistoryMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadHistoryMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.LeadID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.CampaignContactName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.LeadInitiatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.CampaignID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.SalesFunnelName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.ContactGroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadRatio>()
                .Property(e => e.LeadRatioID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadRatio>()
                .Property(e => e.LeadNameID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadRatio>()
                .Property(e => e.LeadGroupNameID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadRatio>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadRatio>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadRatio>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadTypeMaster>()
                .Property(e => e.LeadTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadTypeMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadTypeMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeadTypeMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveAddonMaster>()
                .Property(e => e.LeaveAddonID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveAddonMaster>()
                .Property(e => e.LeaveTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveAddonMaster>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveAddonMaster>()
                .Property(e => e.LeaveAllowedInMonths)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveAddonMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveAddonMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveAddonMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveMaster>()
                .Property(e => e.LeaveId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveParameterMaster>()
                .Property(e => e.LeaveParameterId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveParameterMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveParameterMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<LeaveParameterMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ManageEmployeeDocumentMaster>()
                .Property(e => e.EmployeeDocumentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ManageEmployeeDocumentMaster>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ManageEmployeeDocumentMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ManageEmployeeDocumentMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ManageEmployeeDocumentMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MeetingMOMMaster>()
                .Property(e => e.MeetingMOMID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MeetingMOMMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MeetingMOMMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MeetingMOMMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MenuMaster>()
                .Property(e => e.MenuId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MenuMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MenuMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MenuMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileApplication>()
                .Property(e => e.MobileIApplicationD)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileApplication>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileApplication>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileApplication>()
                .Property(e => e.SupplierId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MobileApplication>()
                .Property(e => e.BusinessCategoryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MonthMaster>()
                .Property(e => e.MonthId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MonthMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MonthMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<MonthMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NoticeBoardMaster>()
                .Property(e => e.NoticeBoardId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NoticeBoardMaster>()
                .Property(e => e.EmployeeName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NoticeBoardMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NoticeBoardMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<NoticeBoardMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.OrderMasterID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.LeadId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.ServiceGroup)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.OrderID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.ProjectManager)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<OrderMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PriorityMaster>()
                .Property(e => e.PriorityId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PriorityMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PriorityMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PriorityMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.CompanyID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.ServiceGroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.ServiceGroupName)
                .IsFixedLength();

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.CustomerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.ProjectLeaderId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.TechnologyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMaster>()
                .Property(e => e.ProjectMangerID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMeetingMaster>()
                .Property(e => e.ProjectMeetingID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMeetingMaster>()
                .Property(e => e.CompanyID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectMeetingMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectPhaseMaster>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProjectPhaseMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProposalHistory>()
                .Property(e => e.ProposalHistoryID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProposalHistory>()
                .Property(e => e.LeadName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProposalHistory>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProposalHistory>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ProposalHistory>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PunchDataMaster>()
                .Property(e => e.PunchDataID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PunchDataMaster>()
                .Property(e => e.EmployeeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PunchDataMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PunchDataMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<PunchDataMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RolesAndResposibilityMaster>()
                .Property(e => e.RoleId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RolesAndResposibilityMaster>()
                .Property(e => e.Menu)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RolesAndResposibilityMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RolesAndResposibilityMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<RolesAndResposibilityMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SalesFunnel>()
                .Property(e => e.SalesFunnelID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SalesFunnel>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SalesFunnel>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SalesFunnel>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SEOSubmissionMaster>()
                .Property(e => e.SEOSubmissionID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SEOSubmissionMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServiceGroupMaster>()
                .Property(e => e.ServiceGroupID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServiceGroupMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServiceGroupMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServiceGroupMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServicePassword>()
                .Property(e => e.ServicePasswordID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServicePassword>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ServicePassword>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ShiftMaster>()
                .Property(e => e.ShiftId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ShiftMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ShiftMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<ShiftMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SMMSubmission>()
                .Property(e => e.SSMSubmissionId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SMMSubmission>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SMMSubmission>()
                .Property(e => e.CustomerId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SoftwareDevelopmentMaster>()
                .Property(e => e.SoftwareDevelopmentID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SoftwareDevelopmentMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SSLCertificate>()
                .Property(e => e.SSLCertificateID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SSLCertificate>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SSLCertificate>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<SSLCertificate>()
                .Property(e => e.SupplierId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarAssignMaster>()
                .Property(e => e.StarAssignId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarAssignMaster>()
                .Property(e => e.GetEmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarAssignMaster>()
                .Property(e => e.StarId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarAssignMaster>()
                .Property(e => e.GivenByEmployeeId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarAssignMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarAssignMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarAssignMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarMaster>()
                .Property(e => e.StarId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StarMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StateMaster>()
                .Property(e => e.StateId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StateMaster>()
                .Property(e => e.CountryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StateMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StateMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StateMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StatusMaster>()
                .Property(e => e.StatusID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StatusMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StatusMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<StatusMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.TaskDayID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.WorkListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.StatusID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.WorkHours)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskDay>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskListMaster>()
                .Property(e => e.TaskListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskListMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskListMaster>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskListMaster>()
                .Property(e => e.WorkListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskListMaster>()
                .Property(e => e.Status)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskListMaster>()
                .Property(e => e.Employee)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransfer>()
                .Property(e => e.TaskTransferID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransfer>()
                .Property(e => e.TaskListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransfer>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransfer>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransfer>()
                .Property(e => e.WorkListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransfer>()
                .Property(e => e.EmployeeFrom)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransfer>()
                .Property(e => e.EmployeeTo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.TaskTransferID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.TaskListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.WorkListID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.EmployeeFrom)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.EmployeeTo)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TaskTransferMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TechnologyMaster>()
                .Property(e => e.TechnologyID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TechnologyMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TechnologyMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TechnologyMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypesOfResponse>()
                .Property(e => e.TypeResponseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypesOfResponse>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypesOfResponse>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<TypesOfResponse>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.VendorID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.Country)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.State)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.City)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.Gender)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<VendorMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebApplicationMaster>()
                .Property(e => e.WebsiteApplicationID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebApplicationMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebApplicationMaster>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebApplicationMaster>()
                .Property(e => e.BusinessCategoryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebDesignMaster>()
                .Property(e => e.WebsiteDesigningID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebDesignMaster>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebDesignMaster>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebDesignMaster>()
                .Property(e => e.SupplierId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebDesignMaster>()
                .Property(e => e.BusinessCategoryId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebHosting>()
                .Property(e => e.WebHostingID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebHosting>()
                .Property(e => e.CompanyId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebHosting>()
                .Property(e => e.Customer)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WebHosting>()
                .Property(e => e.SupplierId)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHBalance>()
                .Property(e => e.WFHBalanceID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHBalance>()
                .Property(e => e.EmployeeName)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHBalance>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHBalance>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHBalance>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHLeave>()
                .Property(e => e.WFHLeaveID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHLeave>()
                .Property(e => e.WFHType)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHLeave>()
                .Property(e => e.WFHParameter)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHLeave>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHLeave>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHLeave>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHParameter>()
                .Property(e => e.WFHParameterID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHParameter>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHParameter>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHType>()
                .Property(e => e.WFHTypeID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHType>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WFHType>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorklistMaster>()
                .Property(e => e.WorklistID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorklistMaster>()
                .Property(e => e.ProjectID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorklistMaster>()
                .Property(e => e.ProjectPhaseID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorklistMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorklistMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<WorklistMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YearMaster>()
                .Property(e => e.YearID)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YearMaster>()
                .Property(e => e.IsAddedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YearMaster>()
                .Property(e => e.IsUpdatedBy)
                .HasPrecision(18, 0);

            modelBuilder.Entity<YearMaster>()
                .Property(e => e.IsDeletedBy)
                .HasPrecision(18, 0);
        }
    }
}
