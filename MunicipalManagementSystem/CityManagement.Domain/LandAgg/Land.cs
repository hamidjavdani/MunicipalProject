using _0_Framework.Domain;

namespace CityManagement.Domain.LandAgg
{
    public class Land : EntityBase
    {
        public int IdRegion { get; private set; }                  //منطقه
        public int IdDistrict { get; private set; }                //ناحیه
        public int IdNeighbourhood { get; private set; }            //محله
        public int IdBlock { get; private set; }                    //بلوک
        public int IdLand { get; private set; }                     //ملک یا شماره پلاک
        public float Area1 { get; private set; }                    //مساحت زمین طبق سند
        public float Area2 { get; private set; }                    //مساحت زمین طبق موجود
        public float IdDocument { get; private set; }               // نوع سند
        public string Address { get; private set; }                  //آدرس ملک
        public string OriginalCode { get; private set; }             //کد اصلی ثبتی
        public string SubCode { get; private set; }                  //کد فرعی ثبتی
        public string RegistrationDepartment { get; private set; }   //بخش ثیتی
        public string RegistrationPiece { get; private set; }        //قطعه ثبتی
        public string RegistrationArea { get; private set; }        //ناحیه ثبتی        
        public string PostalCode { get;private set; }                //کد پستی
        public int TypeOwnership { get; private set; }              //نوع مالکیت
        public string CrookedPhoto { get; private set; }            //تصویر کروکی ملک

        public Land
            (
            int idRegion,
            int idDistrict, 
            int idNeighbourhood,
            int idBlock, 
            int idLand,
            float area1,
            float area2,
            float idDocument,
            string address,
            string originalCode,
            string subCode,
            string registrationDepartment,
            string registrationPiece,
            string registrationArea,
            string postalCode,
            int typeOwnership,
            string crookedPhoto
            )
        {
            IdRegion = idRegion;
            IdDistrict = idDistrict;
            IdNeighbourhood = idNeighbourhood;
            IdBlock = idBlock;
            IdLand = idLand;
            Area1 = area1;
            Area2 = area2;
            IdDocument = idDocument;
            Address = address;
            OriginalCode = originalCode;
            SubCode = subCode;
            RegistrationDepartment = registrationDepartment;
            RegistrationPiece = registrationPiece;
            RegistrationArea = registrationArea;
            PostalCode = postalCode;
            TypeOwnership = typeOwnership;
            CrookedPhoto = crookedPhoto;
        }

        public void Edit
            (     
            int idRegion,
            int idDistrict,
            int idNeighbourhood,
            int idBlock,
            int idLand,
            float area1,
            float area2,
            float idDocument,
            string address,
            string originalCode,
            string subCode,
            string registrationDepartment,
            string registrationPiece,
            string registrationArea,
            string postalCode,
            int typeOwnership,
            string crookedPhoto
            )
        {
            IdRegion = idRegion;
            IdDistrict = idDistrict;
            IdNeighbourhood = idNeighbourhood;
            IdBlock = idBlock;
            IdLand = idLand;
            Area1 = area1;
            Area2 = area2;
            IdDocument = idDocument;
            Address = address;
            OriginalCode = originalCode;
            SubCode = subCode;
            RegistrationDepartment = registrationDepartment;
            RegistrationPiece = registrationPiece;
            RegistrationArea = registrationArea;
            PostalCode = postalCode;
            TypeOwnership = typeOwnership;           

            if (!string.IsNullOrWhiteSpace(crookedPhoto))
                CrookedPhoto = crookedPhoto;


        }

    }

}
