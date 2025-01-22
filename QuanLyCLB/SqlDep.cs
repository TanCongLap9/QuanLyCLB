using QuanLyCLB.Utils;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyCLB
{
    public class SqlDep
    {
        private SqlDependency Dep;
        private SqlCommand Comm;
        private SqlConnection Conn;
        public event OnChangeEventHandler OnChange;
        private readonly string Procedure;
        private readonly Dictionary<string, object> Parameters;

        public SqlDep(string procedure, Dictionary<string, object> parameters = null)
        {
            Procedure = procedure;
            Parameters = parameters;
        }

        public async void Start()
        {
            await NewDep();
            SqlDependency.Start(SqlUtils.ConnectionString);
            Dep_OnChange(null, null);
        }

        public async Task NewDep()
        {
            ClearDep();
            Conn = await SqlUtils.CreateConnection();
            Comm = new SqlCommand(Procedure, Conn);
            Comm.CommandType = System.Data.CommandType.StoredProcedure;
            if (Parameters != null)
                foreach (KeyValuePair<string, object> param in Parameters)
                    Comm.Parameters.AddWithValue(param.Key, param.Value);
            Dep = new SqlDependency(Comm);
            Dep.OnChange += Dep_OnChange;
        }

        public void Stop()
        {
            ClearDep();
            SqlDependency.Stop(SqlUtils.ConnectionString);
        }

        public void ClearDep()
        {
            if (Dep != null) Dep.OnChange -= Dep_OnChange;
            if (Comm != null) Comm.Dispose();
            if (Conn != null) Conn.Dispose();
            Dep = null;
        }
        
        private async void Dep_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (Dep.HasChanges)
            {
                OnChange?.Invoke(sender, e);
                await NewDep();
            }
            await Comm.ExecuteReaderAsync();
        }
    }
}
