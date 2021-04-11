using QuanLySpa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.DAO
{
    public class BillInforDAO
    {
        private static BillInforDAO instance;

        public static BillInforDAO Instance {
            get { if (instance == null) instance = new BillInforDAO();  return BillInforDAO.instance; }
            private set { BillInforDAO.instance = value; }

        }

        private BillInforDAO() { }


        public void DeleteBillInfoByServiceID(int id)
        {
            DataProvider.Instance.ExecuteQuery("delete BillInfo WHERE idService = " + id);
        }

        public List<BillInfo> GetListBillInfo(int id)
        {
            List<BillInfo> listBillInfo = new List<BillInfo>();

            DataTable data = DataProvider.Instance.ExecuteQuery("select * from BillInfo where idBill =" + id);
            foreach (DataRow item in data.Rows)
            {
                BillInfo info = new BillInfo(item);
                listBillInfo.Add(info);
            }

            return listBillInfo;
        }


        public void InsertBillInfo(int idBill, int idService, int count)
        {
            DataProvider.Instance.ExecuteNonQuery(" USP_InsertBillInfo   @idBill , @idService , @count " , new object[] { idBill, idService, count }) ;

        }
    }
}
