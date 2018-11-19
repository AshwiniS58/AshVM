using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssetMgmt.Models
{
    public class Asset
    {
        [Display(Name = "Asset No")]
        [Key]
        public string AssetNo { get; set; }

        [ForeignKey("AssetTypes")]
        public string AssetType { get; set; }
        public AssetTypes AssetTypes { get; set; }

        [Display(Name = "Make/Model")]
        public string MakeAndModel { get; set; }

        [ForeignKey("AssetStatus")]
        public string AssetStatusName { get; set; }
        public AssetStatus AssetStatus { get; set; }

        [ForeignKey("LOB")]
        public string LOBName { get; set; }
        public LOB LOB { get; set; }

        [ForeignKey("Department")]
        public string Dept { get; set; }
        public Department Department { get; set; }

        [ForeignKey("ProjectCodes")]
        public string ProjectCode { get; set; }
        public ProjectCodes ProjectCodes { get; set; }

        public decimal Cost { get; set; }

        [Display(Name = "Unit Price")]
        public decimal UnitPrice { get; set; }

        [Display(Name = "Voucher #")]
        public string VoucherNumber { get; set; }

        [Display(Name = "Purchased On")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public DateTime PurchaseDate { get; set; }

        [Display(Name = "Asset Taggable")]
        public string AssetTaggable { get; set; }

        [Display(Name = "Asset Description")]
        public string AssetDescription { get; set; }

        [Display(Name = "Asset Location")]
        public string AssetLocation { get; set; }
    }
}