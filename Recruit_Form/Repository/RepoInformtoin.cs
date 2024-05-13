
using AutoMapper;
using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;
using Recruit_Form.Data;
using Recruit_Form.Form;
using Recruit_Form.Helper;
using Recruit_Form.Model;
using Recruit_Form.Model.Response;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace Recruit_Form.Repository
{
    public class RepoInformtoin : IInformationRepository
    {
        private readonly DbContextApp1 _db;
        private readonly IMapper _mapper;
        public RepoInformtoin(DbContextApp1 db , IMapper mapper)
        {
            _db = db;
            _mapper = mapper;
            
        }

        public async Task<PagedResponse<PersonalInformation>> AddPer(RequsteInformation requste)
        {
            try
            {

                if (_db.PerInform.Any(
                  info => info.FirstName == requste.FirstName &&
                          info.SecondName == requste.SecondName &&
                          info.ThirdName == requste.ThirdName &&
                          info.Fourth_Name == requste.Fourth_Name &&
                          info.Surname == requste.Surname
                           ))
                {
                    return new PagedResponse <PersonalInformation>
                    {
                        Message = ("Duplicate entry found")
                    };
                };
               /* //var check = await _db.PerInform.FirstOrDefaultAsync(
                //        info => info.FirstName == requste.FirstName &&
                //        info.SecondName == requste.SecondName &&
                //        info.ThirdName == requste.ThirdName &&
                //        info.Fourth_Name == requste.Fourth_Name &&
                //        info.Surname == requste.Surname
                //         );
                // if (check!=null)
                //{
                //    return new PagedResponse<PersonalInformation>
                //   {
                //       //Data = null,
                //        //Error = true,
                //        Message = "Duplicate entry found"
                //    };
                //}
               */

                /*   //if (check != null)
                   //{
                   //    return 
                   //    {
                   //        //Data = null,
                   //        //Error = true,
                   //        //Message = "exsit"
                   //    };
                   //}*/

                var empp1 = _mapper.Map<PersonalInformation>(requste);
                _db.Add(empp1);
                await _db.SaveChangesAsync();
                return new PagedResponse<PersonalInformation> { Message="done"};
           
                /*   //return new GlobalResponse
                //{
                //    Data = null,
                //    Error = false,
                //    Message = "done"
                //};*/

            }
            catch (Exception)
            {
                throw;
            }


        }

        public void Delete(int id)
        {
           var info=_db.PerInform.FirstOrDefault(x=>x.PersonalInformationId== id) ;
            _db.PerInform.Remove(info);
            _db.SaveChanges();
        }

       

        public PersonalInformation Get(int id)
        {
            var info = _db.PerInform.FirstOrDefault(x => x.PersonalInformationId == id);
            _db.PerInform.Add(info);
            _db.SaveChanges();
            return info;
        }



        public async Task<GlobalResponse<PersonalInformation>> GetAll(PagingForm paging, string? filterValue)
        {
            try
            {
                // استعلام قاعدة البيانات باستخدام Linq
                var query = _db.PerInform.AsQueryable();

                // تطبيق عملية التصفية إذا تم توفير قيمة التصفية
                if (!string.IsNullOrWhiteSpace(filterValue))
                {
                    query = query.Where(info =>
                        info.FirstName.Contains(filterValue) ||
                        info.SecondName.Contains(filterValue) ||
                        info.ThirdName.Contains(filterValue) ||
                        info.Fourth_Name.Contains(filterValue) ||
                        info.Surname.Contains(filterValue));
                }

                

                // بناء الاستجابة
                var response = new GlobalResponse<PersonalInformation>(query, paging)
                {
                   
                    Message = "done",
                };

                return response;
            }
            catch (Exception ex)
            {
                // في حالة حدوث أي استثناء، قم بإرجاع رسالة خطأ
                return new GlobalResponse<PersonalInformation>(null, paging)
                {
                    Data = null,
                    Paging = null,
                  
                    Message = "Enter the value",
                   
                };
            }
        }

    }


    //var allInformation =  _db.PerInform.AsQueryable();

    //return new GlobalResponse
    //{
    //    Data = allInformation.ToList(),
    //    Error = false,
    //    Message = "Bone"

    //};


}
       /* 
        * public void Update(int id, PersonalInformation information)
        {
            var info = _db.PerInform.FirstOrDefault(x => x.PersonalInformationId == id);
            information.
        }*/


    

