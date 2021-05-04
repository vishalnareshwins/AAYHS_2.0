﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AAYHS.Core.DTOs.Request;
using AAYHS.Core.DTOs.Response;
using AAYHS.Service.IService;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

using AAYHS.Core.DTOs.Response.Common;
using AAYHS.Core.Shared.Static;
using System.IO;

namespace AAYHS.API.Controllers
{

    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ExhibitorAPIController : ControllerBase
    {
        #region private       
        private MainResponse _mainResponse;
        private string _jsonString = string.Empty;
        #endregion

        #region readonly
        private readonly IExhibitorService _exhibitorService;
        #endregion

        #region Types
        private string GetMimeType(string file)
        {
            string extension = Path.GetExtension(file).ToLowerInvariant();
            switch (extension)
            {
                case ".txt": return "text/plain";
                case ".pdf": return "application/pdf";
                case ".doc": return "application/vnd.ms-word";
                case ".docx": return "application/vnd.ms-word";
                case ".xls": return "application/vnd.ms-excel";
                case ".xlsx": return "application/vnd.ms-excel";
                case ".png": return "image/png";
                case ".jpg": return "image/jpeg";
                case ".jpeg": return "image/jpeg";
                case ".gif": return "image/gif";
                case ".csv": return "text/csv";
                default: return "";
            }
        }
        #endregion

        public ExhibitorAPIController(IExhibitorService exhibitorService)
        {
            _exhibitorService = exhibitorService;
            _mainResponse = new MainResponse();
        }

        /// <summary>
        /// This API is used to get all Exhibitors.
        /// </summary>
        /// <param name="No parameter is required"></param>
        /// <returns>All Exhibitors list</returns>
        [HttpPost]
        public ActionResult GetAllExhibitors(BaseRecordFilterRequest filterRequest)
        {

            _mainResponse = _exhibitorService.GetAllExhibitors(filterRequest); 
              _jsonString = Mapper.Convert<ExhibitorListResponse> (_mainResponse);
            return new OkObjectResult(_jsonString);
        }   
        /// <summary>
        /// This API is used to get  Exhibitor by Exhibitor id.
        /// </summary>
        /// <param name="Exhibitor id parameter is required"></param>
        /// <returns> Single Exhibitor record</returns>
        [HttpGet]
        public ActionResult GetExhibitorById(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetExhibitorById(exhibitorId);
            _jsonString = Mapper.Convert<ExhibitorListResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This API is used to add/update new  Exhibitor.
        /// </summary>
        /// <param name="Exhibitor detail is required"></param>
        /// <returns> success true or false with message</returns>
        [HttpPost]
        public ActionResult AddUpdateExhibitor([FromBody] ExhibitorRequest request)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.AddUpdateExhibitor(request, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This API is used to delete existing Exhibitor.
        /// </summary>
        /// <param name="Exhibitor detail with Exhibitor id is required"></param>
        /// <returns> success true or false with message</returns>
        [HttpDelete]
        public ActionResult DeleteExhibitor(int exhibitorId)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.DeleteExhibitor(exhibitorId, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }        
        /// <summary>
        /// This API used to get exhibitor horses
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetExhibitorHorses(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetExhibitorHorses(exhibitorId);
            _jsonString = Mapper.Convert<ExhibitorHorsesResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This API used to delete exhibitor horse
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult DeleteExhibitorHorse(int exhibitorHorseId)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.DeleteExhibitorHorse(exhibitorHorseId, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This API used to get all horses 
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllHorses(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetAllHorses(exhibitorId);
            _jsonString = Mapper.Convert<GetExhibitorHorsesList>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get selected horse detail
        /// </summary>
        /// <param name="horseId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetHorseDetail(int horseId)
        {
            _mainResponse = _exhibitorService.GetHorseDetail(horseId);
            _jsonString = Mapper.Convert<GetHorses>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to add horses for the exhibitor
        /// </summary>
        /// <param name="addExhibitorHorseRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddExhibitorHorse(AddExhibitorHorseRequest addExhibitorHorseRequest)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.AddExhibitorHorse(addExhibitorHorseRequest, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get all the classes of a exhibitor
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllClassesOfExhibitor(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetAllClassesOfExhibitor(exhibitorId);
            _jsonString = Mapper.Convert<GetAllClassesOfExhibitor>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to remove the exhibitor from class
        /// </summary>
        /// <param name="exhibitorClassId"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult RemoveExhibitorFromClass(int exhibitorClassId)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.RemoveExhibitorFromClass(exhibitorClassId, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get all classes
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllClasses(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetAllClasses(exhibitorId);
            _jsonString = Mapper.Convert<GetAllClassesForExhibitor>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get class detail
        /// </summary>
        /// <param name="classId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetClassDetail(int classId, int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetClassDetail(classId, exhibitorId);
            _jsonString = Mapper.Convert<GetClassesForExhibitor>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to update exhibitor class scratch
        /// </summary>
        /// <param name="updateScratch"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateScratch(UpdateScratch updateScratch)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.UpdateScratch(updateScratch, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to add exhibitor to a class
        /// </summary>
        /// <param name="addExhibitorToClass"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddExhibitorToClass(AddExhibitorToClass addExhibitorToClass)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.AddExhibitorToClass(addExhibitorToClass, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get all sponsors of exhibitor
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllSponsorsOfExhibitor(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetAllSponsorsOfExhibitor(exhibitorId);
            _jsonString = Mapper.Convert<GetAllSponsorsOfExhibitor>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to removed the sponsor of a exhibitor
        /// </summary>
        /// <param name="sponsorExhibitorId"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult RemoveSponsorFromExhibitor(int sponsorExhibitorId)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.RemoveSponsorFromExhibitor(sponsorExhibitorId, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get all sponsor which is not linked with exhibitor
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllSponsor(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetAllSponsor(exhibitorId);
            _jsonString = Mapper.Convert<GetAllSponsorForExhibitor>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used tp get selected sponsor detail
        /// </summary>
        /// <param name="sponsorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetSponsorDetail(int sponsorId)
        {
            _mainResponse = _exhibitorService.GetSponsorDetail(sponsorId);
            _jsonString = Mapper.Convert<GetSponsorForExhibitor>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to add sponsor for a exhibitor
        /// </summary>
        /// <param name="addSponsorForExhibitor"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddUpdateSponsorForExhibitor(AddSponsorForExhibitor addSponsorForExhibitor)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.AddSponsorForExhibitor(addSponsorForExhibitor, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get exhibitor financials
        /// </summary>
        /// <param name="sponsorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetExhibitorFinancials(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetExhibitorFinancials(exhibitorId);
            _jsonString = Mapper.Convert<GetExhibitorFinancials>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to upload the document
        /// </summary>
        /// <param name="documentUploadRequest"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult UploadDocumentFile([FromForm]DocumentUploadRequest documentUploadRequest)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.UploadDocumentFile(documentUploadRequest, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get uploaded document
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetUploadedDocuments(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetUploadedDocuments(exhibitorId);
            _jsonString = Mapper.Convert<GetAllUploadedDocuments>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to delete the uploaded document
        /// </summary>
        /// <param name="documentDeleteRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult DeleteUploadedDocuments([FromBody] DocumentDeleteRequest documentDeleteRequest)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.DeleteUploadedDocuments(documentDeleteRequest, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get all fees
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetFees()
        {
            _mainResponse = _exhibitorService.GetFees();
            _jsonString = Mapper.Convert<GetAllFees>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to remove the financial transaction
        /// </summary>
        /// <param name="exhibitorPaymentId"></param>
        /// <returns></returns>
        [HttpDelete]
        public ActionResult RemoveExhibitorTransaction(int exhibitorPaymentId)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.RemoveExhibitorTransaction(exhibitorPaymentId, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to upload financial document 
        /// </summary>
        /// <param name="documentUploadRequest"></param>
        /// <returns></returns>
        [HttpPut]
        public ActionResult UploadFinancialDocument([FromForm] FinancialDocumentRequest financialDocumentRequest)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.UploadFinancialDocument(financialDocumentRequest, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get all finacial transactions
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetAllExhibitorTransactions(int exhibitorId)
        {
            _mainResponse = _exhibitorService.GetAllExhibitorTransactions(exhibitorId);
            _jsonString = Mapper.Convert<GetAllExhibitorTransactions>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to add financial transaction
        /// </summary>
        /// <param name="addFinancialTransactionRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult AddFinancialTransaction(AddFinancialTransactionRequest addFinancialTransactionRequest)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.AddFinancialTransaction(addFinancialTransactionRequest,actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get detail of financial
        /// </summary>
        /// <param name="viewDetailRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult GetFinancialViewDetail(ViewDetailRequest viewDetailRequest)
        {
            _mainResponse = _exhibitorService.GetFinancialViewDetail(viewDetailRequest);
            _jsonString = Mapper.Convert<GetAllExhibitorTransactions>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to send email with document file
        /// </summary>
        /// <param name="emailWithDocumentRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult SendEmailWithDocument(EmailWithDocumentRequest emailWithDocumentRequest)
        {
            _mainResponse = _exhibitorService.SendEmailWithDocument(emailWithDocumentRequest);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to download the document
        /// </summary>
        /// <param name="documentPath"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<ActionResult> DownloadDocument(string documentPath)
        {
            await _exhibitorService.DownloadDocument(documentPath);
            _mainResponse.Success = true;
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to download the file
        /// </summary>
        /// <param name="documentPath"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> DownloadFile(string documentPath)
        {
            try
            {
                string uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot");
                var file = uploadsFolder + documentPath;
            
                var memory = new MemoryStream();
                using (var stream = new FileStream(file, FileMode.Open, FileAccess.Read))
                {
                    await stream.CopyToAsync(memory);
                }

                memory.Position = 0;
                return File(memory, GetMimeType(file), documentPath);
            }
            catch (Exception e)
            {
                return BadRequest(e);
            }
        }
        /// <summary>
        /// This api used to get sponsors of a exhibitor with respective horse and amount
        /// </summary>
        /// <param name="exhibitorId"></param>
        /// <returns></returns>
        [HttpGet]
        public ActionResult ExhibitorAllSponsorAmount(int exhibitorId)
        {
            _mainResponse = _exhibitorService.ExhibitorAllSponsorAmount(exhibitorId);
            _jsonString = Mapper.Convert<ExhibitorAllSponsorAmount>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to update Financial Transaction
        /// </summary>
        /// <param name="updateFinancialRequest"></param>
        /// <returns></returns>
        [HttpPost]
        public ActionResult UpdateFinancialTransaction(UpdateFinancialRequest updateFinancialRequest)
        {
            string actionBy = User.Identity.Name;
            _mainResponse = _exhibitorService.UpdateFinancialTransaction(updateFinancialRequest, actionBy);
            _jsonString = Mapper.Convert<BaseResponse>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
        /// <summary>
        /// This api used to get sponsor ad types
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public ActionResult GetSponsorAdTypes()
        {
            _mainResponse = _exhibitorService.GetSponsorAdTypes();
            _jsonString = Mapper.Convert<GetAllSponsorAdType>(_mainResponse);
            return new OkObjectResult(_jsonString);
        }
    }
}
