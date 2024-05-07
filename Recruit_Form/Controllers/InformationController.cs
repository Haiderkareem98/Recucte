using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Recruit_Form.Form;
using Recruit_Form.Model;
using Recruit_Form.Model.Response;
using Recruit_Form.Repository;
using System.Net.NetworkInformation;

namespace Recruit_Form.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class InformationController : ControllerBase
    {
        private readonly IInformationRepository _info;
       public InformationController(IInformationRepository info)
        { 
           _info = info;
        
        }


        [HttpPost]
        public async Task<ActionResult<GlobalResponse>> AddInfomation(RequsteInformation requste)
        {
            var info = await _info.AddPer(requste);

            if (info.Error)
            {
                BadRequest(info);
            }
            return Ok(info);
        }

        [HttpGet]
        public async Task<ActionResult<GlobalResponse>>GetAllInformation(PagingForm form)
        {

            var Per= await _info.GetAll(form);

            return Ok(Per);


        }
    }
 }
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
