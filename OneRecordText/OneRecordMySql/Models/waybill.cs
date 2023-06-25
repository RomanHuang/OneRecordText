using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OneRecordMySql.Models
{
    public class waybill
    {
        
        [Column(TypeName = "nvarchar(50)")]
        public string waybillPrefix { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string waybillNumber { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string IdUrl { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string waybillType { get; set; }
        [Column(TypeName = "int")]
        public int PiecesCount { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string totalGrossWeight   { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string totalVolumetricWeight { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string goodsDescription { get; set; }
        [Column(TypeName = "nvarchar(200)")]
        public string ImgPath { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string Air { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string AirNo { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string startTime { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string endTime { get; set; }
        [Column(TypeName = "nvarchar(100)")]
        public string MasterWab { get; set; }
        [Column(TypeName = "nvarchar(50)")]
        public string Phone { get; set; }
        [Column(TypeName = "nvarchar(10)")]
        public string Event { get; set; }
    }
}

