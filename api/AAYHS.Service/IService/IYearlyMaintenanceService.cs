﻿using AAYHS.Core.DTOs.Request;
using AAYHS.Core.DTOs.Response;
using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Service.IService
{
    public interface IYearlyMaintenanceService
    {
        MainResponse GetAllYearlyMaintenance(GetAllYearlyMaintenanceRequest getAllYearlyMaintenanceRequest);
        MainResponse GetYearlyMaintenanceById(int yearlyMaintenanceId);
        MainResponse GetAllUsers();
        MainResponse ApprovedUser(UserApprovedRequest userApprovedRequest, string actionBy);
        MainResponse DeleteUser(int userId, string actionBy);
        MainResponse AddUpdateYearly(AddYearlyRequest addYearly, string actionBy);
        MainResponse DeleteYearly(int yearlyMaintainenceId, string actionBy);
        MainResponse AddADFee(AddAdFee addAdFee, string actionBy);
        MainResponse GetAllAdFees(int yearlyMaintenanceId);
        MainResponse DeleteAdFee(DeleteAdFee deleteAd , string actionBy);
        MainResponse GetAllUsersApproved();
        MainResponse RemoveApprovedUser(int userId, string actionBy);
        MainResponse GetAllRoles();
        MainResponse GetAllClassCategory();
        MainResponse AddClassCategory(AddClassCategoryRequest addClassCategoryRequest, string actionBy);
        MainResponse RemoveClassCategory(int globalCodeId, string actionBy);
        MainResponse GetAllGeneralFees(int yearlyMaintenanceId);
        MainResponse AddGeneralFees(AddGeneralFeeRequest addGeneralFeeRequest, string actionBy);
        MainResponse RemoveGeneralFee(RemoveGeneralFee removeGeneralFee, string actionBy);
        MainResponse GetRefund(int yearlyMaintenanceId);
        MainResponse AddRefund(AddRefundRequest addRefundRequest, string actionBy);
        MainResponse RemoveRefund(int refundId, string actionBy);
        MainResponse GetContactInfo(int yearlyMaintenanceId);
        MainResponse AddUpdateContactInfo(AddContactInfoRequest addContactInfoRequest, string actionBy);            
        MainResponse GetAllScan(GetScanRequest getScanRequest);
        MainResponse AddUpdateYearlyStatementText(AddStatementTextRequest addStatementTextRequest, string actionBy);
        MainResponse GetYearlyStatementText(int yearlyMaintenanceId);
        MainResponse AddAndUpdateSponsorIncentive(AddSponsorIncentiveRequest addSponsorIncentiveRequest, string actionBy);
        MainResponse GetSponsorIncentive(int yearlyMaintenanceId);
        MainResponse DeleteSponsorIncentive(int sponsorIncentiveId, string actionBy);
        MainResponse ActiveInActiveUser(ActiveInActiveRequest activeInActiveRequest);
        MainResponse ActiveInActiveGeneralFee(ActiveInActiveGeneralFeeRequest activeInActiveGeneralFeeRequest);
        MainResponse ActiveInActiveAdFee(ActiveInActiveAdFeeRequest activeInActiveAdFeeRequest);
        MainResponse ActiveInActiveClassCategory(ActiveInActiveClassCategory activeInActiveClassCategory);
        MainResponse ActiveInActiveScratchRefund(ActiveInActiveScratchRefund activeInActiveScratchRefund);
        MainResponse YearlyDataForNextYear(int yearlyMaintenanceId,string actionBy);
        MainResponse ActiveInActiveIncentive(ActiveInActiveIncentive activeInActiveIncentive);
    }
}
