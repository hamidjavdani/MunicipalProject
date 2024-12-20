using _0_Framework.Domain;
using EarthManagement.Domain.BlockAgg;
using EarthManagement.Domain.BuildingAgg;
using EarthManagement.Domain.MelkComprehensivePlanAgg;
using EarthManagement.Domain.MelkDetailedPlanAgg;
using EarthManagement.Domain.MelkDirectionAgg;
using EarthManagement.Domain.MelkZoningAgg;
using EarthManagement.Domain.TitleDocumentAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.MelkAgg
{
    public class Melk:EntityBase
    {
        public string Name { get; private  set; }
        public int BlockId { get;private set; }
        public Block Block { get;private set; }
        public int TitleDocumentId { get; set; }                     // شماره عنوان سند
        public TitleDocument TitleDocument { get; set; }             // نوع سند
        public float Area1 { get; private set; }                    //مساحت زمین طبق سند
        public float Area2 { get; private set; }                    //مساحت زمین طبق موجود
        public string Address { get; private set; }                  //آدرس ملک
        public string OriginalCode { get; private set; }             //کد اصلی ثبتی
        public string SubCode { get; private set; }                  //کد فرعی ثبتی
        public string RegistrationDepartment { get; private set; }   //بخش ثیتی
        public string RegistrationPiece { get; private set; }        //قطعه ثبتی
        public string RegistrationArea { get; private set; }        //ناحیه ثبتی        
        public string PostalCode { get; private set; }              //کد پستی
        public List<Building> Buildings { get; private set; }        //ساختمان های ملک
        public bool WornTexture { get; private set; }              //بافت فرسوده
        public bool OldTexture { get; private set; }               //بافت کهن

        public List<MelkComprehensivePlan> MelkComprehensivePlans { get; set; }  //طرح جامع
        public List<MelkDetailedPlan> MelkDetailedPlans { get; private set; }    //طرح تفصیلی
        public List<MelkZoning> MelkZonings { get; set; }              //پهنه عملکردی
        public List<MelkDirection> MelkDirections { get; private set; } //ابعاد ملک
    }
}
