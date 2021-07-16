using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SPhoneDic
{
    public class DataSeeder
    {
        public void SeedCustomer()
        {
            List<Customer> cList = new List<Customer>();

            cList.Add(new Customer("cus1", "address1", "mail1@gmail.com", "0369"));
            cList.Add(new Customer("cus2", "address2", "mail2@gmail.com", "036444449"));

            DBContext db = DBContext.Instance();
            foreach (Customer cus in cList)
            {
                int num = db.InsertCustomer(cus);
            }
        }

        public void ResetDbCustomer()
        {
            DBContext db = DBContext.Instance();
            db.ResetDB();
        }
    }
}
