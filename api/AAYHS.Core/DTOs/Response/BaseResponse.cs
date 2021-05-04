﻿using AAYHS.Core.DTOs.Response.Common;
﻿using AAYHS.Core.Shared.Static;
using AAYHS.Data.DBEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Core.DTOs.Response
{
    /// <summary
    /// This class will contain common property that is used by all API response in the application.
    /// </summary
    public class BaseResponse
    {
        public string Message { get; set; }     
        public int NewId { get; set; }
        public bool Success { get; set; } = true;

    }
  
    public class MainResponse : BaseResponse
    {
        public BaseResponse BaseResponse { get; set; }
        public GetAllClasses GetAllClasses { get; set; }
        public GetClass GetClass { get; set; }
        public GlobalCodeMainResponse GlobalCodeMainResponse { get; set; }
        public GetClassAllExhibitors GetClassAllExhibitors { get; set; }
        public ClassExhibitorHorses ClassExhibitorHorses { get; set; }
        public GetAllClassEntries GetAllClassEntries { get; set; }
        public SponsorResponse SponsorResponse { get; set; }
        public SponsorListResponse SponsorListResponse { get; set; }
        public SponsorClassesListResponse SponsorClassesListResponse { get; set; }
        public ClassSponsorResponse ClassSponsorResponse { get; set; }
        public ClassSponsorListResponse ClassSponsorListResponse { get; set; }

        public ExhibitorResponse ExhibitorResponse { get; set; }
        public ExhibitorListResponse ExhibitorListResponse { get; set; }
        public SponsorExhibitorListResponse SponsorExhibitorListResponse { get; set; }
        
        public SponsorExhibitorResponse SponsorExhibitorResponse { get; set; }
        public SponsorDistributionListResponse SponsorDistributionListResponse { get; set; }
        public SponsorDistributionResponse SponsorDistributionResponse { get; set; }
        
        public ExhibiorAdsSponsorReportListResponse ExhibiorAdsSponsorReportListResponse { get; set; }
        public ExhibiorAdsSponsorReportResponse ExhibiorAdsSponsorReportResponse { get; set; }

        public NonExhibiorSummarySponsorDistributionsListResponse NonExhibiorSummarySponsorDistributionsListResponse { get; set; }
        public NonExhibiorSummarySponsorDistributionsResponse NonExhibiorSummarySponsorDistributionsResponse { get; set; }
        public ResultExhibitorDetails ResultExhibitorDetails { get; set; }
        public GetAllBackNumber GetAllBackNumber { get; set; }
        public CityResponse CityResponse { get; set; }
        public ZipCodeResponse ZipCodeResponse { get; set; }
        public StateResponse StateResponse { get; set; }
        public GetExhibitorAllHorses GetExhibitorAllHorses { get; set; }
        public GetResult GetResult { get; set; }
        public GetAllHorses GetAllHorses { get; set; }
        public UserResponse UserResponse { get; set; }
        public GetAllGroupFinacials GetAllGroupFinacials { get; set; }
        public GetAllGroupsFinacialsModule GetAllGroupsFinacialsModule { get; set; }
        public GroupResponse GroupResponse  { get; set; }
        public GroupListResponse GroupListResponse  { get; set; }
        public GetAllLinkedExhibitors GetAllLinkedExhibitors { get; set; }
        public GetAllGroups GetAllGroups { get; set; }
        public GetHorseById GetHorseById { get; set; }
        public GetAllGroupExhibitors GetAllGroupExhibitors { get; set; }
        public GetAllStall GetAllStall { get; set; }
        public GetGroupStatement GetGroupStatement { get; set; }

        public AdvertisementResponse AdvertisementResponse { get; set; }
        public AdvertisementListResponse AdvertisementListResponse { get; set; }
        public ExhibitorHorsesResponse ExhibitorHorsesResponse { get; set; }
        public GetExhibitorHorsesList GetExhibitorHorsesList { get; set; }
        public GetHorses GetHorses { get; set; }
        public GetAllClassesOfExhibitor GetAllClassesOfExhibitor { get; set; }
        public GetAllClassesForExhibitor GetAllClassesForExhibitor { get; set; }
        public GetClassesForExhibitor GetClassesForExhibitor { get; set; }
        public GetAllSponsorsOfExhibitor GetAllSponsorsOfExhibitor { get; set; }
        public GetAllSponsorForExhibitor GetAllSponsorForExhibitor { get; set; }
        public GetSponsorDetailedInfo GetSponsorDetailedInfo { get; set; }
        public GetSponsorForExhibitor GetSponsorForExhibitor { get; set; }        
        public GetExhibitorFinancials GetExhibitorFinancials { get; set; }        
        public GetAllUploadedDocuments GetAllUploadedDocuments { get; set; }   
        public GetAllFees GetAllFees { get; set; }   
        public GetAllExhibitorTransactions GetAllExhibitorTransactions { get; set; }   
        public GetAllYearlyMaintenance GetAllYearlyMaintenance { get; set; }   
        public GetYearlyMaintenanceById GetYearlyMaintenanceById { get; set; }   
        public GetAllUsers GetAllUsers { get; set; }   
        public GetAllAdFees GetAllAdFees { get; set; }   
        public GetAllClassCategory GetAllClassCategory { get; set; }   
        public GetAllRoles GetAllRoles { get; set; }   
        public GetAllGeneralFees GetAllGeneralFees { get; set; }   
        public GetContactInfo GetContactInfo { get; set; }   
        public GetAllRefund GetAllRefund { get; set; }   
        public GetLocation GetLocation { get; set; }   
        public GetExhibitorRegistrationReport GetExhibitorRegistrationReport { get; set; }   
        public GetExhibitorGroupInformationReport GetExhibitorGroupInformationReport { get; set; }
        
        public GetExhibitorGroupInformationReportForAllGroups GetExhibitorGroupInformationReportForAllGroups { get; set; }
        public GetExhibitorSponsorConfirmationReportForAllExhibitors GetExhibitorSponsorConfirmationReportForAllExhibitors { get; set; }
        public GetExhibitorSponsorConfirmationReport GetExhibitorSponsorConfirmationReport { get; set; }
        public GetProgramReport GetProgramReport { get; set; }   
        public GetPaddockReport GetPaddockReport { get; set; }   
        public GetAllClassesEntries GetAllClassesEntries { get; set; }   
        public GetClassResultReport GetClassResultReport { get; set; }   
        public GetSingleClassResult GetSingleClassResult { get; set; }   
        public GetAllScan GetAllScan { get; set; }   
        public GetAllStatementText GetAllStatementText { get; set; }   
        public GetExhibitorSponsorRefundStatement GetExhibitorSponsorRefundStatement { get; set; }   
        public ExhibitorAllSponsorAmount ExhibitorAllSponsorAmount { get; set; }   
        public GetSponsorAllIncentives GetSponsorAllIncentives { get; set; }   
        public AllSponsorsYealry AllSponsorsYealry { get; set; }   
        public GetPaddockReportOfAllClasses GetPaddockReportOfAllClasses { get; set; }   
        public GetProgramReportOfAllClasses GetProgramReportOfAllClasses { get; set; }   
        public ShowSummaryReport ShowSummaryReport { get; set; }   
        public GetExhibitorsSponsorRefundReport GetExhibitorsSponsorRefundReport { get; set; }   
        public GetAdministrativeReport GetAdministrativeReport { get; set; }   
        public GetNSBAExhibitorFee GetNSBAExhibitorFee { get; set; }   
        public GetAllSponsorAdType GetAllSponsorAdType { get; set; }   
        public GetNonExhibitorSponsor GetNonExhibitorSponsor { get; set; }   
        public GetAllNonExhibitorSponsors GetAllNonExhibitorSponsors { get; set; }   
        public GetAllExhibitorSponsoredAd GetAllExhibitorSponsoredAd { get; set; }   
        public GetAllNonExhibitorSponsorAd GetAllNonExhibitorSponsorAd { get; set; }   
      
    }
   
    public class Response<T> : BaseResponse
    {
        public T Data { get; set; }
    }
}
