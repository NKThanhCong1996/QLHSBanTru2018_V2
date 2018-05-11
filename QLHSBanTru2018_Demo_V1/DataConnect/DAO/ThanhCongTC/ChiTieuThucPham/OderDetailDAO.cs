using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataConnect.DAO.ThanhCongTC.ChiTieuThucPham
{
    public class OderDetailDAO
    {
        QLHSSmartKidsDataContext dt = new QLHSSmartKidsDataContext();
        public bool Insert(OrderDetail oderDetail)
        {
            OrderDetail a = new OrderDetail();
            a.OrderID = oderDetail.OrderID;
            a.IngredientID = oderDetail.IngredientID;
            a.PriceOfUnit = oderDetail.PriceOfUnit;
            a.QuantityOfUnit = oderDetail.QuantityOfUnit;
            a.TotalPrice = oderDetail.TotalPrice;
            a.Discount = oderDetail.Discount;
            a.Status = oderDetail.Status;
            dt.OrderDetails.InsertOnSubmit(a);
            dt.SubmitChanges();
            return true;
        }
        public bool Edit(OrderDetail orderDetail)
        {
            OrderDetail a = dt.OrderDetails.FirstOrDefault(t => t.OrderID == orderDetail.OrderID && t.IngredientID == orderDetail.IngredientID);
            a.Status = orderDetail.Status;
            dt.SubmitChanges();
            return true;
        }
        public List<OrderDetail> ListOrderDetailByID(int OrderID)
        {
            var a = dt.OrderDetails.Where(t => t.OrderID == OrderID);
            return a.ToList();
        }
    }
}
