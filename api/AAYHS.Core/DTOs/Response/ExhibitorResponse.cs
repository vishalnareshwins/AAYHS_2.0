﻿using System;
using System.Collections.Generic;
using System.Text;

namespace AAYHS.Core.DTOs.Response
{
    public class ExhibitorResponse
    {
        public int ExhibitorId { get; set; }
        public int GroupId { get; set; }
        public int AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int? BackNumber { get; set; }
        public int? BirthYear { get; set; }
        public bool IsNSBAMember { get; set; }
        public bool IsDoctorNote { get; set; }
        public int QTYProgram { get; set; }
        public string PrimaryEmail { get; set; }
        public string SecondaryEmail { get; set; }
        public string Phone { get; set; }
        public string ZipCode { get; set; }
        public int CityId { get; set; }
        public int? StateId { get; set; }
        public string GroupName { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public List<ExhibitorStallAssignmentResponse> exhibitorStallAssignmentResponses { get; set; }

    }

    public class ExhibitorStallAssignmentResponse
    {
        public int StallAssignmentId { get; set; }
        public int StallId { get; set; }
        public int StallAssignmentTypeId { get; set; }
        public int GroupId { get; set; }
        public int ExhibitorId { get; set; }
        public string BookedByType { get; set; }
        public string BookedByName { get; set; }
        public DateTime StallAssignmentDate { get; set; }
    }

    public class ExhibitorListResponse
    {
        public List<ExhibitorResponse> exhibitorResponses { get; set; }
        public int TotalRecords { get; set; }
    }
    public class ExhibitorHorses
    {
        public int ExhibitorHorseId { get; set; }
        public int HorseId { get; set; }
        public string HorseName { get; set; }
        public string HorseType { get; set; }
        public int? BackNumber { get; set; }
        public string Date { get; set; }
    }
    public class ExhibitorHorsesResponse
    {
        public List<ExhibitorHorses> exhibitorHorses { get; set; }
        public int TotalRecords { get; set; }
    }
    public class GetHorses
    {
        public int HorseId { get; set; }
        public string Name { get; set; }
        public string HorseType { get; set; }
    }
    public class GetExhibitorHorsesList
    {
        public List<GetHorses> getHorses { get; set; }
    }
    public class GetClassesOfExhibitor
    {
        public int ExhibitorClassId { get; set; }
        public int ClassId { get; set; }
        public string ClassNumber { get; set; }
        public string Name { get; set; }
        public int HorseId { get; set; }
        public string HorseName { get; set; }
        public string AgeGroup { get; set; }
        public int Entries { get; set; }
        public bool Scratch { get; set; }
        public string Date { get; set; }
    }
    public class GetAllClassesOfExhibitor
    {
        public List<GetClassesOfExhibitor> getClassesOfExhibitors { get; set; }

        public int TotalRecords { get; set; }
    }
    public class GetClassesForExhibitor
    {
        public int ClassId { get; set; }
        public string ClassNumber { get; set; }
        public string Name { get; set; }
        public string AgeGroup { get; set; }
        public int Entries { get; set; }
        public bool IsScratch { get; set; }
    }
    public class GetAllClassesForExhibitor
    {
        public List<GetClassesForExhibitor> getClassesForExhibitor { get; set; }
    }
    public class GetSponsorsOfExhibitor
    {
        public int SponsorExhibitorId { get; set; }
        public int SponsorId { get; set; }        
        public string Sponsor { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zipcode { get; set; }
        public string Email { get; set; }
        public decimal SponsorAmount { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public int SponsorTypeId { get; set; }
        public int HorseId { get; set; }
        public string HorseName { get; set; }
        public string SponsorTypeName { get; set; }
        public string AdTypeName { get; set; }
        public string IdNumber { get; set; }
    }
    public class GetAllSponsorsOfExhibitor
    {
        public List<GetSponsorsOfExhibitor> getSponsorsOfExhibitors { get; set; }
        public int TotalRecords { get; set; }
    }
    public class GetSponsorForExhibitor
    {
        public int SponsorId { get; set; }
        public string SponsorName { get; set; }
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Email { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal Balance { get; set; }
        public int Zipcode { get; set; }
    }
    public class GetAllSponsorForExhibitor
    {
        public List<GetSponsorForExhibitor> getSponsorForExhibitors { get; set; }
    }
    public class GetSponsorDetailedInfo
    {
        public string ContactName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zipcode { get; set; }
    }
    public class GetExhibitorFinancials
    {
        public List<ExhibitorFeesBilled> exhibitorFeesBilled { get; set; }
        public decimal FeeBilledTotal { get; set; }
        public List<ExhibitorMoneyReceived> exhibitorMoneyReceived { get; set; }
        public decimal MoneyReceivedTotal { get; set; }
        public decimal  Outstanding { get; set; }
        public decimal OverPayment { get; set; }
        public decimal Refunds { get; set; }
    }
    public class ExhibitorFeesBilled
    {
        public int FeeTypeId { get; set; }
        public int Qty { get; set; }
        public string FeeType { get; set; }
        public decimal Amount { get; set; }

    }
    public class ExhibitorMoneyReceived
    {
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
    }

    public class GetUploadedDocuments
    {
        public int ScansId { get; set; }
        public string DocumentType { get; set; }
        public string DocumentPath { get; set; }
    }

    public class GetAllUploadedDocuments
    {
        public List<GetUploadedDocuments> getUploadedDocuments { get; set; }
    }
    public class GetFees
    {
        public int FeeTypeId { get; set; }
        public string FeeName { get; set; }
        public string TimeFrameType { get; set; }       
        public decimal Amount { get; set; }
        public decimal RefundPercentage { get; set; }
    }
    public class GetAllFees
    {
        public string DefaultTimeFrame { get; set; }
        public List<GetFees> getFees { get; set; }
    }
    public class GetExhibitorTransactions
    {
        public int ExhibitorPaymentDetailId { get; set; }
        public DateTime PayDate { get; set; }
        public string TypeOfFee { get; set; }
        public string TimeFrameType { get; set; }
        public decimal Amount { get; set; }
        public decimal AmountPaid { get; set; }
        public decimal RefundAmount { get; set; }
        public string DocumentPath { get; set; }
    }
    public class GetAllExhibitorTransactions
    {
        public List<GetExhibitorTransactions> getExhibitorTransactions { get; set; }
        public bool IsRefund { get; set; }
    }

    public class ExhibitorAllSponsorAmount
    {
        public List<ExhibitorSponsor> exhibitorSponsors { get; set; }
    }
    public class ExhibitorSponsor
    {
        public int SponsorId { get; set; }
        public string HorseName { get; set; }
        public string SponsorName { get; set; }
        public decimal Amount { get; set; }
    }
    public class GetAllSponsorAdType
    {
        public List<SponsorAdType> sponsorAdTypes { get; set; }
    }
    public class SponsorAdType
    {
        public int YearlyMaintainenceFeeId { get; set; }
        public string FeeName { get; set; }
    }
}
