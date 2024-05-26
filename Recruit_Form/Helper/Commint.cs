namespace Recruit.Helper
{
    public class Commint
    {

        // Authentecation
        /*
         * هو حمايه لل اي بي اي من خلال تحديد اليوزر الي يكدر يوصل للموقع
         *  (UserA) اول نقطه لازم تنشا كلاس لليوزر
         * يحتوي على معلومات اليوزر
         * نقوم بعمل ريبوستري ونعمل كوسنتركتر ونتصل بقاعده البيانات
         * نقوم بعمل كلاس (دي تي او) وبداخله
         * ولعمل ريزلت (نتيجه) للكلاينت نقوم بعمل كلاس اسمه اوث ريزلت في فلودر الريسبون 
         *  احنه سويناه حنى يرجع قيم
         * وبروبرتي نوعها بولين يعني اذا تروو ترجع البروبرتي البقيه 
         * 
         */

        // JWT
        /*
         * 
         * اول امر تنزل مكتبه identity asp net frameworkcor
         * dawnload too JwtBearer
         * then go to appsetting and working confg
         * add value("JWT": {
           "Issure": "http://localhost:14644", لوكل هوست تجيبه من appsetting
           "Audience": "http://localhost:54332", هنا مال ابو الفرونت 
           "SecreKey": "dm.nkfd.njkdlfn4ru0r38ry373971@##$#%@#%#%#@") هنا الكي 
         * add model AppUser:identityUser
         * and also adding it in DbContext
         * creat controler and also working injcation in progarm
         * 
         */

        //startup
        /*
         * startup
         * يحتوي على دالتين 
         * 1-ConfigureServies , 2-config
         * الستارت اب يحتوي على جميع السيرفيس الي نحتاجها في الابليكشن 
         * هنا كتطبيق نحتاج نضيف سيرفر الاوثنتكيشن وكذالك سيرفس الراوتنك مال الكونترولير 
         * 
         * 
         * 
         */



        //Dependency Injection
        /*
         * اي كلاس معتمد على كلاس ثاني 
         * وحصل اي تعديل في الكلاس الثاني يجب ان تعدل في الكلاس الاول 
         * 
         * -------------------------------------
         * public MyDependency(Request requset)
         * {
         *   title=requset.GetAll();
         * }
         * هنا هذه كونستركتر والتايتل قيمه عرفتها فوك
         * فكتله هذه الكونستركتر يستقبل كلاس ثاني 
         * فقط هذه عمله يستقبل كلاس ثاني 
         * -------------------------------------------
         *   private readonly MyDependency _dependency = new MyDependency();
         *   هنا من ضفنه هذه الكود البرمجي للكلاس الاول اسمه وورك  بمعنى  ان الكلاس الاول حيعتمد على 
         *   هذه الكلاس وبالتالي اي تغيير في هذه الكلاس 
         * كالتغيير الفوك ضفنه كونستركتر بعد التبعيه اي بعد اضافه كود الحقن 
         * فانطاني ايررور وكال لازم هم تغير بكلاس الوورك
         * 
         * فهنا نحتاج الى Dependency Injection
         * اي نخلي الكلاس الاول ما يعتمد ع الثاني 
         * من خلال ثلاث خطوات 
         * 1- تسوي انترفيس 
         * 2- تسوي امبلمنتيشن اله 
         * 3- تضيفه الى program
         * من خلال ثلاث انواع  السكوب والترانزيت وال اد سنكل
         * 
         */



        // Host 
        /*
         * The application needs six things to work
         * 1- السيرفر الي يشتغل عليه الابلكيشن
         * 2- الدبندسي انجكشن
         * 3-لازم يعرف المدل وير
         * 4-يعمل لود للكونفكريشن من الاب سيتينغ  
         * 5-لازم يعرف وين الفلولدر البيه ملفات البروجكت
         * 6- اللوكن كونفكريشن
         * Dependency injection (DI)
           Logging
           Configuration
           IHostedService implementations
         */

        //configraution
        /* appsetting  هو مجموعه من الكونفكريشن 
         * اي شي عندك تريده من الاب سيتنغ  
         * وتريد تستدعيه للكونترولير فمن خلال اي كونفك
         * 
         * 
         * بالكونترولير من تريد تستدعي الكونفك الموجود في الاب سيتنغ اذا فهو اذا جان 
         * في اكثر من مورد فراح يكون حسب التسلسل 
         * 1-josn file اذا انت تكريته
         * ثناي شي يروح Environment variables
         * 3- Manage User Secret موجود في قائمه المشروع نفسه
         * 4- appsettings.Development 
         * 5- appsettings
         * https://www.youtube.com/watch?v=uak0gmdgfdw&list=PLB2pNkhw8PWVe0u-5qi8-wllmHtYVKS0M&index=12 
         * 
         * CreateDefaultBuilder 
         * هو عباره عن مجموعه دفيلت كونفكريشن من ضمنها اللوكن من الاب سيتنغ
         * 
         */



        // Logging
        /*
         * هو عباره عن معلومات وملاحضات في المود حتى نكدر نقراها من يشتغل البرنامج
         * 
         * 
         *  CreateDefaultBuilder 
         * هو عباره عن مجموعه دفيلت كونفكريشن من ضمنها اللوكن من الاب سيتنغ
         * 
         * 
         */

    }
}
