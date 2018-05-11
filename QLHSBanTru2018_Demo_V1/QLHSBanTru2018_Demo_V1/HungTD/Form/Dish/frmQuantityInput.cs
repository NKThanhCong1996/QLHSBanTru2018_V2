using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DataConnect.DAO.HungTD;

namespace QLHSBanTru2018_Demo_V1.HungTD.Form.Dish
{
    public partial class frmQuantityInput : DevExpress.XtraEditors.XtraForm
    {
        DataConnect.Ingredient ingredient;
        public void setTitle(string title)
        {
            this.Text = title;
        }
        public void setIngredient(int ingredientID)
        {
            this.ingredient = new IngredientDAO().GetByID(ingredientID);
        }
        public frmQuantityInput()
        {
            InitializeComponent();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}