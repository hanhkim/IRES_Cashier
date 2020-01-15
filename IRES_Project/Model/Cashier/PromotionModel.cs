using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model.Cashier
{
    public class PromotionModel
    {
        private int promotionId;
        private int restaurantId;
        private string promotionCode;
        private string promotionApplyType;
        private DateTime promotionStartDate;
        private DateTime promotionEndDate;
        private int promotionQuantity;
        private int promotionValue;
        private int promotionMaxValue;
        private string promotionUnit;
        private string promotionCondition;
        private string promotionDescription;
        private string createBy;
        private DateTime createDatetime;
        private string updateBy;
        private DateTime updateDatetime;
        private bool active;
        private int version;

        public int PromotionId { get => promotionId; set => promotionId = value; }
        public int RestaurantId { get => restaurantId; set => restaurantId = value; }
        public string PromotionCode { get => promotionCode; set => promotionCode = value; }
        public string PromotionApplyType { get => promotionApplyType; set => promotionApplyType = value; }
        public DateTime PromotionStartDate { get => promotionStartDate; set => promotionStartDate = value; }
        public DateTime PromotionEndDate { get => promotionEndDate; set => promotionEndDate = value; }
        public int PromotionQuantity { get => promotionQuantity; set => promotionQuantity = value; }
        public int PromotionValue { get => promotionValue; set => promotionValue = value; }
        public int PromotionMaxValue { get => promotionMaxValue; set => promotionMaxValue = value; }
        public string PromotionUnit { get => promotionUnit; set => promotionUnit = value; }
        public string PromotionCondition { get => promotionCondition; set => promotionCondition = value; }
        public string PromotionDescription { get => promotionDescription; set => promotionDescription = value; }
        public string CreateBy { get => createBy; set => createBy = value; }
        public DateTime CreateDatetime { get => createDatetime; set => createDatetime = value; }
        public string UpdateBy { get => updateBy; set => updateBy = value; }
        public DateTime UpdateDatetime { get => updateDatetime; set => updateDatetime = value; }
        public bool Active { get => active; set => active = value; }
        public int Version { get => version; set => version = value; }
    }
}
