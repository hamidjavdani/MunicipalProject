using _0_Framework.Domain;
using EarthManagement.Domain.DirectionAgg;
using EarthManagement.Domain.MelkAgg;
using System;
using System.Collections.Generic;
using System.Text;

namespace EarthManagement.Domain.MelkDirectionAgg
{
    public class MelkDirection : EntityBase
    {
        public int MelkId { get; private set; }
        public Melk Melk { get; private set; }
        public int DirectionId { get; private set; }
        public Direction Direction { get; private set; }   //نوع جهت ملک
        public string Dimensions1 { get; private set; }   //ابعاد طبق سند
        public string Dimensions2 { get; private set; }   //ابعاد اصلاحی 
        public int Crossing1 { get; private set; }       //عرض معبر موجود
        public int Crossing2 { get; private set; }       //عرض معبر تفصیلی
    }
}
