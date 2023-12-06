using static System.Net.Mime.MediaTypeNames;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Sunglasses
{
    partial class SunglassesManagerFrom
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
            lblFormTitle = new Label();
            lblBookList = new Label();
            dgvSunglassList = new DataGridView();
            gbSearch = new GroupBox();
            btnSearch = new Button();
            lblKeyword = new Label();
            txtKeyword = new TextBox();
            gbTask = new GroupBox();
            btnExit = new Button();
            btnDelete = new Button();
            btnUpdate = new Button();
            btnAdd = new Button();
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
            ((System.ComponentModel.ISupportInitialize)dgvSunglassList).BeginInit();
            gbSearch.SuspendLayout();
            gbTask.SuspendLayout();
            gbSunglassInfo.SuspendLayout();
            SuspendLayout();
            // 
            // lblFormTitle
            // 
            lblFormTitle.AutoSize = true;
            lblFormTitle.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point);
            lblFormTitle.ForeColor = Color.Yellow;
            lblFormTitle.Location = new Point(37, 60);
            lblFormTitle.Name = "lblFormTitle";
            lblFormTitle.Size = new Size(312, 46);
            lblFormTitle.TabIndex = 25;
            lblFormTitle.Text = "Sunglass Manager";
            // 
            // lblBookList
            // 
            lblBookList.AutoSize = true;
            lblBookList.ForeColor = Color.Yellow;
            lblBookList.Location = new Point(576, 252);
            lblBookList.Name = "lblBookList";
            lblBookList.Size = new Size(92, 20);
            lblBookList.TabIndex = 29;
            lblBookList.Text = "Sunglass List";
            // 
            // dgvSunglassList
            // 
            dgvSunglassList.BackgroundColor = Color.White;
            dgvSunglassList.BorderStyle = BorderStyle.Fixed3D;
            dgvSunglassList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvSunglassList.Location = new Point(576, 284);
            dgvSunglassList.Name = "dgvSunglassList";
            dgvSunglassList.RowHeadersWidth = 51;
            dgvSunglassList.RowTemplate.Height = 29;
            dgvSunglassList.Size = new Size(523, 371);
            dgvSunglassList.TabIndex = 24;
            dgvSunglassList.SelectionChanged += dgvSunglassList_SelectionChanged;
            // 
            // gbSearch
            // 
            gbSearch.Controls.Add(btnSearch);
            gbSearch.Controls.Add(lblKeyword);
            gbSearch.Controls.Add(txtKeyword);
            gbSearch.ForeColor = Color.Yellow;
            gbSearch.Location = new Point(576, 132);
            gbSearch.Name = "gbSearch";
            gbSearch.Size = new Size(451, 80);
            gbSearch.TabIndex = 28;
            gbSearch.TabStop = false;
            gbSearch.Text = " Search ";
            // 
            // btnSearch
            // 
            btnSearch.BackColor = Color.FromArgb(192, 0, 0);
            btnSearch.Location = new Point(331, 33);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(94, 29);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = false;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblKeyword
            // 
            lblKeyword.AutoSize = true;
            lblKeyword.Location = new Point(18, 36);
            lblKeyword.Name = "lblKeyword";
            lblKeyword.Size = new Size(67, 20);
            lblKeyword.TabIndex = 18;
            lblKeyword.Text = "Keyword";
            // 
            // txtKeyword
            // 
            txtKeyword.Location = new Point(91, 35);
            txtKeyword.Name = "txtKeyword";
            txtKeyword.Size = new Size(221, 27);
            txtKeyword.TabIndex = 0;
            // 
            // gbTask
            // 
            gbTask.Controls.Add(btnExit);
            gbTask.Controls.Add(btnDelete);
            gbTask.Controls.Add(btnUpdate);
            gbTask.Controls.Add(btnAdd);
            gbTask.ForeColor = Color.Yellow;
            gbTask.Location = new Point(37, 589);
            gbTask.Name = "gbTask";
            gbTask.Size = new Size(501, 80);
            gbTask.TabIndex = 27;
            gbTask.TabStop = false;
            gbTask.Text = " Task ";
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.FromArgb(192, 0, 0);
            btnExit.Location = new Point(389, 35);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(94, 29);
            btnExit.TabIndex = 3;
            btnExit.Text = "Exit";
            btnExit.UseVisualStyleBackColor = false;
            btnExit.Click += btnExit_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.FromArgb(192, 0, 0);
            btnDelete.Location = new Point(264, 35);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.FromArgb(192, 0, 0);
            btnUpdate.Location = new Point(141, 35);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(94, 29);
            btnUpdate.TabIndex = 1;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 0, 0);
            btnAdd.Location = new Point(17, 35);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(94, 29);
            btnAdd.TabIndex = 0;
            btnAdd.Text = "Add";
            btnAdd.UseVisualStyleBackColor = false;
            btnAdd.Click += btnAdd_Click;
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
            gbSunglassInfo.Location = new Point(37, 132);
            gbSunglassInfo.Name = "gbSunglassInfo";
            gbSunglassInfo.Size = new Size(501, 445);
            gbSunglassInfo.TabIndex = 26;
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
            lblShape.Location = new Point(17, 225);
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
            lblMaterial.Location = new Point(17, 184);
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
            lblManufacturer.Location = new Point(17, 395);
            lblManufacturer.Name = "lblManufacturer";
            lblManufacturer.Size = new Size(97, 20);
            lblManufacturer.TabIndex = 7;
            lblManufacturer.Text = "Manufacturer";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(299, 333);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblQuantity
            // 
            lblQuantity.AutoSize = true;
            lblQuantity.Location = new Point(19, 333);
            lblQuantity.Name = "lblQuantity";
            lblQuantity.Size = new Size(65, 20);
            lblQuantity.TabIndex = 4;
            lblQuantity.Text = "Quantity";
            // 
            // lblCreatedDate
            // 
            lblCreatedDate.AutoSize = true;
            lblCreatedDate.Location = new Point(17, 281);
            lblCreatedDate.Name = "lblCreatedDate";
            lblCreatedDate.Size = new Size(97, 20);
            lblCreatedDate.TabIndex = 3;
            lblCreatedDate.Text = "Created Date";
            // 
            // lblFeature
            // 
            lblFeature.AutoSize = true;
            lblFeature.Location = new Point(17, 136);
            lblFeature.Name = "lblFeature";
            lblFeature.Size = new Size(58, 20);
            lblFeature.TabIndex = 2;
            lblFeature.Text = "Feature";
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(17, 88);
            lblName.Name = "lblName";
            lblName.Size = new Size(49, 20);
            lblName.TabIndex = 1;
            lblName.Text = "Name";
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.ForeColor = Color.Yellow;
            lblId.Location = new Point(17, 44);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // SunglassesManagerFrom
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.IndianRed;
            ClientSize = new Size(1141, 761);
            Controls.Add(lblFormTitle);
            Controls.Add(lblBookList);
            Controls.Add(dgvSunglassList);
            Controls.Add(gbSearch);
            Controls.Add(gbTask);
            Controls.Add(gbSunglassInfo);
            Margin = new Padding(3, 4, 3, 4);
            Name = "SunglassesManagerFrom";
            Text = "SunglassesManagerFrom";
            FormClosed += SunglassesManagerFrom_FormClosed;
            ((System.ComponentModel.ISupportInitialize)dgvSunglassList).EndInit();
            gbSearch.ResumeLayout(false);
            gbSearch.PerformLayout();
            gbTask.ResumeLayout(false);
            gbSunglassInfo.ResumeLayout(false);
            gbSunglassInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFormTitle;
        private Label lblBookList;
        private DataGridView dgvSunglassList;
        private GroupBox gbSearch;
        private Button btnSearch;
        private Label lblKeyword;
        private TextBox txtKeyword;
        private GroupBox gbTask;
        private Button btnExit;
        private Button btnDelete;
        private Button btnUpdate;
        private Button btnAdd;
        private GroupBox gbSunglassInfo;
        private TextBox txtPrice;
        private TextBox txtQuantity;
        private ComboBox cboManufacture;
        private DateTimePicker dtpCreatedDate;
        private TextBox txtDescription;
        private TextBox txtName;
        private TextBox txtId;
        private Label lblManufacturer;
        private Label lblPrice;
        private Label lblQuantity;
        private Label lblCreatedDate;
        private Label lblFeature;
        private Label lblName;
        private Label lblId;
        private Label lblShape;
        private TextBox txtMaterial;
        private Label lblMaterial;
        private TextBox txtFeature;
        private TextBox txtShape;
    }
}