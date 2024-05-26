using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruit.Controllers;
using Recruit_Form.Form;
using Recruit_Form.Helper;
using Recruit_Form.Model;
using Recruit_Form.Model.Response;
using Recruit_Form.Repository;
using System.Net.NetworkInformation;

namespace Recruit_Form.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController(IServiceProvider serviceProvider) : BaseController(serviceProvider)
    {
       // private readonly IInformationRepository _info;
       //// public InformationController(IInformationRepository info)
       // {
       //     _info = info;

       // }


        [HttpPost]
        public async Task<ActionResult<PersonalInformation>> AddInfomation(RequsteInformation requste)
        {
            //var info = await _info.AddPer(requste);

            //if (info==null)
            //{
            //    BadRequest(info);
            //}
            return Ok(await _info.AddPer(requste));
        }

        [HttpGet]
        public async Task<ActionResult<GlobalResponse<PersonalInformation>>> GetAllInformation([FromQuery] PagingForm form, string? FlterValue)
        {
            try
            {
                if (string.IsNullOrEmpty(FlterValue))
                {
                    FlterValue = string.Empty; // تأكيد عدم وجود قيمة فارغة للتصفية
                }

                var Per = await _info.GetAll(form, FlterValue);
                return Ok(Per);
            }
            catch (Exception ex)
            {
                // يمكنك إدراج رسالة خطأ مناسبة هنا في حالة حدوث استثناء
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }

        //[HttpGet]
        //public async Task<ActionResult<GlobalResponse<PersonalInformation>>>GetAllInformation([FromQuery]PagingForm form,string FlterValue)
        //{
         
        //    var Per= await _info.GetAll(form,FlterValue);
        //    return Ok(Per);


        //}
    }
 };
     //     var allInformation = _info.GetAll().ToList();


       //     if (allInformation.Count == 0)
       //     {
       //         return NotFound("لا توجد بيانات متاحة");
       //     }

       //     var requestInformationList = allInformation.Select
       //                          (info => _mapper.Map<RequsteInformation>(info)).ToList();

       //     return Ok(requestInformationList);

       // }
       ////  return Ok(_mapper.Map<RequsteInformation>(PersonalInformation));

       // var empp1 = _mapper.Map<PersonalInformation>(requste);
       // _info.AddPer(empp1);
        //return Ok();
