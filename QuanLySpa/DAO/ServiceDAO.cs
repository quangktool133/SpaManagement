using QuanLySpa.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySpa.DAO
{
    public class ServiceDAO
    {
        private static ServiceDAO instance;

        public static ServiceDAO Instance
        {
            get
            {
                if (instance == null) instance = new ServiceDAO();
                return ServiceDAO.instance;
            }
            private set { ServiceDAO.instance = value; }
        }

        private ServiceDAO() { }

        public List<Service> GetServiceByCategoryID(int id)
        {
            List<Service> list = new List<Service>();

            string query = "Select * from Service where idCategory = " + id;

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }

            return list;

        }

        public List<Service> GetListService ()
        {
            List<Service> list = new List<Service>();

            string query = "select *  from Service ";

        DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }

            return list;
            }


        public List<Service> SearchServiceByName(string name)
        {

            List<Service> list = new List<Service>();

            string query = string.Format("Select * from Service Where dbo.fuConvertToUnsign1(name) like N'%' + dbo.fuConvertToUnsign1(N'{0}') + '%'", name);
            

            DataTable data = DataProvider.Instance.ExecuteQuery(query);

            foreach (DataRow item in data.Rows)
            {
                Service service = new Service(item);
                list.Add(service);
            }

            return list;
        }


        public bool InsertService(string name, int id, float price)
        {
            string query = string.Format("INSERT Service ( name, idCategory, price )VALUES  ( N'{0}', {1}, {2})", name, id, price);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool UpdateService(int idService, string name, int id, float price)
        {
            string query = string.Format("UPDATE Service SET name = N'{0}', idCategory = {1}, price = {2} WHERE id = {3}", name, id, price, idService);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }

        public bool DeleteService(int idService)
        {
            BillInforDAO.Instance.DeleteBillInfoByServiceID(idService);

            string query = string.Format("Delete Service where id = {0}", idService);
            int result = DataProvider.Instance.ExecuteNonQuery(query);

            return result > 0;
        }
    }
}
