using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sunglasses
{
    partial class SunglassForm
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
            gbSunglassInfo = new GroupBox();
            txtShape = new TextBox();
            lblShape = new Label();
            txtMaterial = new TextBox();
            lblMaterial = new Label();
            txtFeature = new TextBox();
            txtPrice = new TextBox();
            txtQuantity = new TextBox();
            cboManufacture = new ComboBox();
            dtpCreatedDate = new DateTimePicker();
            txtName = new TextBox();
            txtId = new TextBox();
            lblManufacturer = new Label();
            lblPrice = new Label();
            lblQuantity = new Label();
            lblCreatedDate = new Label();
            lblFeature = new Label();
            lblName = new Label();
            lblId = new Label();
            lblFormTitle = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            gbSunglassInfo.SuspendLayout();
            SuspendLayout();
            // 
            // gbSunglassInfo
            // 
            gbSunglassInfo.Controls.Add(txtShape);
            gbSunglassInfo.Controls.Add(lblShape);
            gbSunglassInfo.Controls.Add(txtMaterial);
            gbSunglassInfo.Controls.Add(lblMaterial);
            gbSunglassInfo.Controls.Add(txtFeature);
            gbSunglassInfo.Controls.Add(txtPrice);
            gbSunglassInfo.Controls.Add(txtQuantity);
            gbSunglassInfo.Controls.Add(cboManufacture);
            gbSunglassInfo.Controls.Add(dtpCreatedDate);
            gbSunglassInfo.Controls.Add(txtName);
            gbSunglassInfo.Controls.Add(txtId);
            gbSunglassInfo.Controls.Add(lblManufacturer);
            gbSunglassInfo.Controls.Add(lblPrice);
            gbSunglassInfo.Controls.Add(lblQuantity);
            gbSunglassInfo.Controls.Add(lblCreatedDate);
            gbSunglassInfo.Controls.Add(lblFeature);
            gbSunglassInfo.Controls.Add(lblName);
            gbSunglassInfo.Controls.Add(lblId);
            gbSunglassInfo.ForeColor = Color.Yellow;
            gbSunglassInfo.Location = new Point(193, 71);
            gbSunglassInfo.Name = "gbSunglassInfo";
            gbSunglassInfo.Size = new Size(501, 445);
            gbSunglassInfo.TabIndex = 27;
            gbSunglassInfo.TabStop = false;
            gbSunglassInfo.Text = "Sunglass Info ";
            // 
            // txtShape
            // 
            txtShape.Location = new Point(129, 215);
            txtShape.Name = "txtShape";
            txtShape.Size = new Size(355, 27);
            txtShape.TabIndex = 12;
            // 
            // lblShape
            // 
            lblShape.AutoSize = true;
            lblShape.Location = new Point(17, 224);
            lblShape.Name = "lblShape";
            lblShape.Size = new Size(50, 20);
            lblShape.TabIndex = 11;
            lblShape.Text = "Shape";
            // 
            // txtMaterial
            // 
            txtMaterial.Location = new Point(129, 173);
            txtMaterial.Name = "txtMaterial";
            txtMaterial.Size = new Size(355, 27);
            txtMaterial.TabIndex = 10;
            // 
            // lblMaterial
            // 
            lblMaterial.AutoSize = true;
            lblMaterial.Location = new Point(17, 183);
            lblMaterial.Name = "lblMaterial";
            lblMaterial.Size = new Size(64, 20);
            lblMaterial.TabIndex = 9;
            lblMaterial.Text = "Material";
            // 
            // txtFeature
            // 
            txtFeature.Location = new Point(131, 125);
            txtFeature.Name = "txtFeature";
            txtFeature.Size = new Size(353, 27);
            txtFeature.TabIndex = 8;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(357, 329);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(125, 27);
            txtPrice.TabIndex = 5;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(129, 329);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(153, 27);
            txtQuantity.TabIndex = 4;
            // 
            // cboManufacture
            // 
            cboManufacture.FormattingEnabled = true;
            cboManufacture.Location = new Point(131, 393);
            cboManufacture.Name = "cboManufacture";
            cboManufacture.Size = new Size(353, 28);
            cboManufacture.TabIndex = 7;
            // 
            // dtpCreatedDate
            // 
            dtpCreatedDate.CustomFormat = "dd/MM/yyyy";
            dtpCreatedDate.Format = DateTimePickerFormat.Custom;
            dtpCreatedDate.Location = new Point(129, 273);
            dtpCreatedDate.Name = "dtpCreatedDate";
            dtpCreatedDate.Size = new Size(153, 27);
            dtpCreatedDate.TabIndex = 3;
            // 
            // txtName
            // 
            txtName.Location = new Point(131, 85);
            txtName.Name = "txtName";
            txtName.Size = new Size(353, 27);
            txtName.TabIndex = 1;
            // 
            // txtId
            // 
            txtId.BackColor = SystemColors.ControlLightLight;
            txtId.BorderStyle = BorderStyle.FixedSingle;
            txtId.Location = new Point(131, 43);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 0;
            // 
            // lblManufacturer
            // 
            lblManufacturer.AutoSize = true;
            lblManufacturer.Location = new Point(17, 393);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(97, 20);
            lblManufacturer.TabIndex = 7;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(299, 332);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(19, 332);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(17, 280);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(97, 20);
            lblCreatedDate.TabIndex = 3;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblFeature
            // 
            lblFeature.AutoSize = true;
            lblFeature.Location = new Point(17, 135);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new Size(58, 20);
            lblFeature.TabIndex = 2;
            lblFeature.Text = "Feature";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 87);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(17, 43);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(193, 12);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(262, 46);
            lblFormTitle.TabIndex = 28;
            lblFormTitle.Text = "Add a Sunglass";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.FromArgb(192, 0, 0);
            btnSave.Location = new Point(493, 544);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(94, 29);
            btnSave.TabIndex = 29;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.BackColor = Color.FromArgb(192, 0, 0);
            btnCancel.Location = new Point(600, 544);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(94, 29);
            btnCancel.TabIndex = 30;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = false;
            btnCancel.Click += btnCancel_Click;
            // 
            // SunglassForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(914, 600);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(lblFormTitle);
            Controls.Add(gbSunglassInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SunglassForm";
            Text = "SunglassForm";
            Load += SunglassForm_Load;
            gbSunglassInfo.ResumeLayout(false);
            gbSunglassInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox gbSunglassInfo;
        private TextBox txtShape;
        private Label lblShape;
        private TextBox txtMaterial;
        private Label lblMaterial;
        private TextBox txtFeature;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox cboManufacture;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblManufacturer;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCreatedDate;
        private Label lblFeature;
        private Label lblName;
        private Label lblId;
        private Label lblFormTitle;
        private Button btnSave;
        private Button btnCancel;
    }
}