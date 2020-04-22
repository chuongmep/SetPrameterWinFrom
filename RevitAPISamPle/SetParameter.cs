using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace RevitAPISamPle
{


    public partial class SetParameter : DevExpress.XtraEditors.XtraForm
    {

        SetParameterViewModel _viewModel;

        public SetParameter(SetParameterViewModel viewModel)
        {
            InitializeComponent();
            _viewModel = viewModel;
            TopMost = true;

            CbbParameter.DataSource = _viewModel.AllParameterName;
            _viewModel.SelectedParameter = CbbParameter.SelectedItem.ToString();

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {
           
        }

        void Addbinding()
        {
            TxtStatus.DataBindings.Add(new Binding("Text", CbbParameter.DataSource, "ValueParameter"));
        }

        private void TxtStatus_EditValueChanged(object sender, EventArgs e)
        {
            
        }

        private void BtnSetValue_Click(object sender, EventArgs e)
        {

            string value = TxtStatus.Text;
            if (string.IsNullOrEmpty(value))
            {
                MessageBox.Show("Please Input Value","Warning",MessageBoxButtons.OK);
                return;
            }

            DialogResult = DialogResult.OK;

            _viewModel.SelectedParameter = CbbParameter.SelectedItem.ToString();
            _viewModel.TxtStatus = TxtStatus.Text;

        }
    }

    
}