namespace RevitAPISamPle
{
    partial class SetParameter
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SetParameter));
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.CbbParameter = new System.Windows.Forms.ComboBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.TxtStatus = new DevExpress.XtraEditors.TextEdit();
            this.BtnSetValue = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStatus.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.CbbParameter);
            this.panelControl1.Controls.Add(this.labelControl2);
            this.panelControl1.Controls.Add(this.labelControl1);
            this.panelControl1.Controls.Add(this.TxtStatus);
            this.panelControl1.Controls.Add(this.BtnSetValue);
            this.panelControl1.Controls.Add(this.simpleButton1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(267, 145);
            this.panelControl1.TabIndex = 0;
            // 
            // CbbParameter
            // 
            this.CbbParameter.FormattingEnabled = true;
            this.CbbParameter.Location = new System.Drawing.Point(76, 21);
            this.CbbParameter.Name = "CbbParameter";
            this.CbbParameter.Size = new System.Drawing.Size(179, 21);
            this.CbbParameter.TabIndex = 5;
            this.CbbParameter.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged_1);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(12, 63);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(33, 13);
            this.labelControl2.TabIndex = 4;
            this.labelControl2.Text = "Value :";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(13, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(57, 13);
            this.labelControl1.TabIndex = 4;
            this.labelControl1.Text = "Parameter :";
            // 
            // TxtStatus
            // 
            this.TxtStatus.EditValue = "";
            this.TxtStatus.Location = new System.Drawing.Point(76, 60);
            this.TxtStatus.Name = "TxtStatus";
            this.TxtStatus.Size = new System.Drawing.Size(179, 20);
            this.TxtStatus.TabIndex = 2;
            this.TxtStatus.EditValueChanged += new System.EventHandler(this.TxtStatus_EditValueChanged);
            // 
            // BtnSetValue
            // 
            this.BtnSetValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSetValue.Location = new System.Drawing.Point(106, 117);
            this.BtnSetValue.Name = "BtnSetValue";
            this.BtnSetValue.Size = new System.Drawing.Size(75, 23);
            this.BtnSetValue.TabIndex = 0;
            this.BtnSetValue.Text = "SetValue";
            this.BtnSetValue.Click += new System.EventHandler(this.BtnSetValue_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Location = new System.Drawing.Point(187, 117);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 0;
            this.simpleButton1.Text = "Close";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // SetParameter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 145);
            this.Controls.Add(this.panelControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.IconOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SetParameter.IconOptions.SvgImage")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SetParameter";
            this.Text = "SetParameter";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panelControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TxtStatus.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.TextEdit TxtStatus;
        private DevExpress.XtraEditors.SimpleButton BtnSetValue;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox CbbParameter;
    }
}