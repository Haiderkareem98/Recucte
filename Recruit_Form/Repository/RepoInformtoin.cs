
using AutoMapper;
using Azure.Core;
using Microsoft.EntityFrameworkCore;
using Recruit_Form.Data;
using Recruit_Form.Form;
using Recruit_Form.Model;
using Recruit_Form.Model.Response;

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

        public async Task<GlobalResponse> AddPer(RequsteInformation requste)
        {
            try
            {
                var check = await _db.PerInform.FirstOrDefaultAsync(
                  info => info.FirstName == requste.FirstName &&
                          info.SecondName == requste.SecondName &&
                          info.ThirdName == requste.ThirdName &&
                          info.Fourth_Name == requste.Fourth_Name &&
                          info.Surname == requste.Surname
                           ); 
                    
                if (check != null)
                {
                    return new GlobalResponse
                    {
                        Data = null,
                        Error = true,
                        Message = "exsit"
                    };
                }

                var empp1 = _mapper.Map<PersonalInformation>(requste);
                _db.Add(empp1);
                await _db.SaveChangesAsync();
                return new GlobalResponse
                {
                    Data = null,
                    Error = false,
                    Message = "done"
                };
            }catch (Exception ex)
            {
                return new GlobalResponse
                {
                    Data = null,
                    Error = false,
                    Message = ex.Message
                };
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

        

            public async Task<GlobalResponse> GetAll(PagingForm paging)
            {
                try
                {
                    // حساب العناصر التي يجب تخطيها لبدء الصفحة
                    var skipAmount = (paging.PageNumber - 1) * paging.PageSize;

                    // استعلام قاعدة البيانات باستخدام Linq
                    var query = _db.PerInform.AsQueryable();

                    // تنفيذ عملية التصفية
                    var pageInformation = await query
                        .Skip(skipAmount)
                        .Take(paging.PageSize)
                        .ToListAsync();

                    // بناء الاستجابة
                    var response = new GlobalResponse
                    {
                        Data = pageInformation,
                        Error = false,
                        Message = "Success"
                    };

                    return response;
                }
                catch (Exception ex)
                {
                    // في حالة حدوث أي استثناء، قم بإرجاع رسالة خطأ
                    return new GlobalResponse
                    {
                        Data = null,
                        Error = true,
                        Message = $"Error: {ex.Message}"
                    };
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
}

    

