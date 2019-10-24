using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SalesInfo
{
  public partial class Form1 : Form
  {
    const string connectionString = "Server=A-305-07;Database=sample;Trusted_Connection=True;";
    public Form1()
    {
      InitializeComponent();
    }

    private void GetBuyer_Click(object sender, EventArgs e)
    {
      using (var connection = new SqlConnection(connectionString))
      using (var command = connection.CreateCommand())
      {
        string query = $"select * from dbo.buyer;";
        command.CommandText = query;

        connection.Open();
        command.ExecuteNonQuery();
      }
    }

    private void GetSellers_Click(object sender, EventArgs e)
    {
      using (var connection = new SqlConnection(connectionString))
      using (var command = connection.CreateCommand())
      {
        string query = $"select * from dbo.sellers;";
        command.CommandText = query;

        connection.Open();
        command.ExecuteNonQuery();
      }
    }

    private void GetSales_Click(object sender, EventArgs e)
    {
      using (var connection = new SqlConnection(connectionString))
      using (var command = connection.CreateCommand())
      {
        string query = $"select * from dbo.sales;";
        command.CommandText = query;

        connection.Open();
        command.ExecuteNonQuery();
      }
    }
  }
}
