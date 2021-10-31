using HW2OnAdoNetWinForms.DbFactory;
using HW2OnAdoNetWinForms.DbQueryList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HW2OnAdoNetWinForms
{
    public partial class Form1 : Form
    {
        private IDbFactory _dbFactory;
        private IDbQueryList _queryList;
        DataSet data;

        public string InfoString
        {
            get => infoBox.Text;
            set => infoBox.Text = value;
        }

        public Form1()
        {
            InitializeComponent();
            _dbFactory = new SqlFactory();
            _queryList = new SqlQueryList();
            data = new DataSet();
            dgData.DataSource = data;

            TableInit(_queryList.InitTypes());
            TableInit(_queryList.InitBuyers());
            TableInit(_queryList.InitManagers());
            TableInit(_queryList.InitProducts());
            TableInit(_queryList.InitSales());
        }

        void TableInit(string query)
        {
            try
            {
                using (IDbConnection connection = GetConnection())
                {
                    connection.Open();
                    IDbCommand command =
                        _dbFactory.CreateCommand(query, connection);
                    command.ExecuteNonQuery();
                }
            }
            catch (Exception)
            {
            }
        }

        private IDbConnection GetConnection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["Local"].ConnectionString;
            return _dbFactory.CreateConnection(connectionString);
        }

        private void btn_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            dgData.DataSource = null;
            int index = Int32.Parse((sender as Button).Name.Substring(3));
            string query = "";
            switch (index)
            {
                case 1:
                    query = _queryList.MinSalesProducts();
                    break;
                case 2:
                    query = _queryList.MaxSalesProducts();
                    break;
                case 3:
                    query = _queryList.ShowManagers();
                    break;
                case 4:
                    query = _queryList.ShowTypes();
                    break;
                case 5:
                    query = _queryList.ShowProducts();
                    break;
                case 6:
                    query = _queryList.ShowCountProductsType();
                    break;
                case 7:
                    query = _queryList.ShowRecentSale();
                    break;
                case 8:
                    query = _queryList.MaxPriceProducts();
                    break;
                case 9:
                    query = _queryList.MinPriceProducts();
                    break;
                case 10:
                    query = _queryList.ShowSalesByManager();
                    break;
                case 11:
                    query = _queryList.ShowSalesByBuyer();
                    break;
                case 12:
                    query = _queryList.ShowProductsByType();
                    break;
                default:
                    break;
            }
            using (IDbConnection connection = GetConnection())
            {
                IDbCommand command = _dbFactory.CreateCommand(query, connection);
                IDbDataParameter parameter;
                switch (index)
                {
                    case 10:
                        parameter = _dbFactory.CreateParameter("@ManagerName", SqlDbType.NVarChar);
                        parameter.Value = InfoString;
                        command.Parameters.Add(parameter);
                        break;
                    case 11:
                        parameter = _dbFactory.CreateParameter("@BuyerName", SqlDbType.NVarChar);
                        parameter.Value = InfoString;
                        command.Parameters.Add(parameter);
                        break;
                    case 12:
                        parameter = _dbFactory.CreateParameter("@Type", SqlDbType.NVarChar);
                        parameter.Value = InfoString;
                        command.Parameters.Add(parameter);
                        break;
                    default:
                        break;
                }

                //Doesn't work, CS1674
                //IDbDataAdapter adapter = _dbFactory.CreateAdapter(command);
                SqlDataAdapter adapter = _dbFactory.CreateAdapter(command) as SqlDataAdapter;
                
                using (adapter)
                {
                    adapter.Fill(data);
                }
            }
            dgData.DataSource = data.Tables[0];
        }
    }
}
