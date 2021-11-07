using HW2OnAdoNetWinForms.DbFactory;
using HW2OnAdoNetWinForms.DbQueryList;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.Common;
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
        private DbCommandBuilder _builder;
        private IDbDataAdapter adapter;
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
                case 13:
                    query = _queryList.ShowMostProdMan();
                    break;
                case 14:
                    query = _queryList.ShowMostExpMan();
                    break;
                case 15:
                    query = _queryList.ShowMostExpBuyer();
                    break;
                case 16:
                    query = _queryList.ShowMostProdType();
                    break;
                case 17:
                    query = _queryList.ShowMostExpType();
                    break;
                case 18:
                    query = _queryList.ShowMostPopProd();
                    break;
                case 19:
                    query = _queryList.ShowMostExpManByDate();
                    break;
                case 20:
                    query = _queryList.ShowNonBoughtProdByDay();
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
                    case 19:
                        parameter = _dbFactory.CreateParameter("@Date1", SqlDbType.DateTime);
                        parameter.Value = dateTimePicker1.Value;
                        command.Parameters.Add(parameter);
                        parameter = _dbFactory.CreateParameter("@Date2", SqlDbType.DateTime);
                        parameter.Value = dateTimePicker2.Value;
                        command.Parameters.Add(parameter);
                        break;
                    case 20:
                        parameter = _dbFactory.CreateParameter("@Days", SqlDbType.Int);
                        parameter.Value = InfoString;
                        command.Parameters.Add(parameter);
                        break;
                    default:
                        break;
                }

                adapter = _dbFactory.CreateAdapter(command);
                
                adapter.Fill(data);
            }
            dgData.DataSource = data.Tables[0];
        }

        private void btnTable_Click(object sender, EventArgs e)
        {
            data = new DataSet();
            dgData.DataSource = null;

            string query = "";

            switch ((sender as Button).Name)
            {
                case ("btnProd"):
                    query = _queryList.ShowProductsPure();
                    break;
                case ("btnTypes"):
                    query = _queryList.ShowTypesPure();
                    break;
                case ("btnManagers"):
                    query = _queryList.ShowManagersPure();
                    break;
                case ("btnSales"):
                    query = _queryList.ShowSalesPure();
                    break;
                case ("btnBuyers"):
                    query = _queryList.ShowBuyersPure();
                    break;
                default:
                    break;
            }

            IDbConnection connection = GetConnection();
            IDbCommand command = _dbFactory.CreateCommand(query, connection);
            adapter = _dbFactory.CreateAdapter(command);
            _builder = _dbFactory.CreateBuilder(adapter);

            adapter.Fill(data);

            dgData.DataSource = data.Tables[0];
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            adapter.Update(data);
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            data.Clear();
        }
    }
}
