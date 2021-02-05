namespace 携帯会社販売管理システム.Model.Entities.DB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class T_Stock
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int StockID { get; set; }

        [Required]
        [StringLength(6)]
        public string PrID { get; set; }

        public int? Squantity { get; set; }

        public virtual M_Product M_Product { get; set; }
    }
}
