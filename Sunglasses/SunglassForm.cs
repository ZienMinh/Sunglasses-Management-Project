using Repositories.Models;
using Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sunglasses
{
    public partial class SunglassForm : Form
    {
        public int? SunglassesId { get; set; }
        private SunglassService sunglassService = new();
        private ManufactureService manufactureService = new();

        public SunglassForm()
        {
            InitializeComponent();
        }

        private void SunglassForm_Load(object sender, EventArgs e)
        {
            cboManufacture.DataSource = manufactureService.GetAllCategories();
            cboManufacture.DisplayMember = "ManufacturerName";
            cboManufacture.ValueMember = "ManufacturerId";

            if (this.SunglassesId != null)
            {

                var sunglass = sunglassService.GetASunglass((int)SunglassesId);

                txtId.Text = sunglass.SunglassesId.ToString();
                txtName.Text = sunglass.SunglassesName;
                txtFeature.Text = sunglass.Feature;
                txtMaterial.Text = sunglass.Material;
                txtShape.Text = sunglass.Shape;
                dtpCreatedDate.Value = (DateTime)sunglass.CreatedDate;
                txtQuantity.Text = sunglass.Quantity.ToString();
                txtPrice.Text = sunglass.Price.ToString();
                cboManufacture.SelectedValue = sunglass.ManufacturerId;
                lblFormTitle.Text = "Update a Sunglass";
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtId.Text) ||
                string.IsNullOrWhiteSpace(txtName.Text) ||
                string.IsNullOrWhiteSpace(txtFeature.Text) ||
                string.IsNullOrWhiteSpace(txtMaterial.Text) ||
                string.IsNullOrWhiteSpace(txtShape.Text) ||
                string.IsNullOrWhiteSpace(txtQuantity.Text) ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                cboManufacture.SelectedValue == null)
            {
                MessageBox.Show("Please fill in all the information.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity < 0)
            {
                MessageBox.Show("Quantity must be a non-negative integer.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!decimal.TryParse(txtPrice.Text, out decimal price) || price < 0)
            {
                MessageBox.Show("Price must be a non-negative number.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string sunglassesName = txtName.Text.Trim();
            if (sunglassesName.Length < 5 || sunglassesName.Length > 80)
            {
                MessageBox.Show("SunglassesName must have a length between 5 and 80 characters.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string[] words = sunglassesName.Split(' ');

            foreach (string word in words)
            {
                // Check if the first character of each word is an uppercase letter or a digit
                if (!char.IsUpper(word.FirstOrDefault()) && !char.IsDigit(word.FirstOrDefault()))
                {
                    MessageBox.Show("SunglassesName must start with an uppercase letter or a digit from 0 to 9.",
                        "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Check if each character is a letter, digit, or whitespace
                foreach (char character in word)
                {
                    if (!char.IsLetterOrDigit(character) && !char.IsWhiteSpace(character))
                    {
                        MessageBox.Show("SunglassesName cannot contain special characters, " +
                            "and each word must start with an uppercase letter or a digit from 0 to 9.",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            Sunglass sunglass = new()
            {
                SunglassesId = int.Parse(txtId.Text.Trim()),
                SunglassesName = txtName.Text.Trim(),
                Feature = txtFeature.Text.Trim(),
                Material = txtMaterial.Text.Trim(),
                Shape = txtShape.Text.Trim(),
                Quantity = int.Parse(txtQuantity.Text.Trim()),
                Price = decimal.Parse(txtPrice.Text.Trim()),
                CreatedDate = dtpCreatedDate.Value.Date,
                ManufacturerId = cboManufacture.SelectedValue.ToString()
            };

            if (SunglassesId != null)
                sunglassService.UpdateASunglass(sunglass);
            else
                sunglassService.AddASunglass(sunglass);

            Close();
            //string[] words = sunglassesName.Split(' ');

            //foreach (string word in words)
            //{
            //    if (!char.IsUpper(word.FirstOrDefault()))
            //    {
            //        MessageBox.Show("SunglassesName cannot contain special characters, " +
            //            "and each word must start with an uppercase letter or a digit from 0 to 9.",
            //            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //        return;
            //    }

            //    foreach (char character in word)
            //    {
            //        if (!Regex.IsMatch(character.ToString(), "^[a-zA-Z0-9]+$"))
            //        {
            //            MessageBox.Show("SunglassesName cannot contain special characters, " +
            //                "and each word must start with an uppercase letter or a digit from 0 to 9.",
            //                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //            return;
            //        }
            //    }
            //}
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
