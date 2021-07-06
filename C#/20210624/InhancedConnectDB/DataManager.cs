using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InhancedConnectDB
{
    class DataManager
    {
        public List<TB_CUST> tb_custs = new List<TB_CUST>();
        public DBHelper instance;

        public DataManager(int db=0)
        {
            instance = new DBHelper().getInstance(db);
        }

        public void Load()
        {
            instance.Query_Select();
            tb_custs.Clear();

            foreach (DataRow item in instance.ds.Tables[0].Rows)
            {
                TB_CUST temp = new TB_CUST();
                temp.cust_id = item["CUST_ID"].ToString();
                temp.birth_dt = item["BIRTH_DT"].ToString();
                tb_custs.Add(temp);
            }
        }

        public void Save()
        {
            //DB 값을 싹 날린다.
            instance.Query_Delete();

            foreach (TB_CUST item in tb_custs)
            {
                instance.Query_Insert(item.cust_id, item.birth_dt);
            }
        }

    }
}
