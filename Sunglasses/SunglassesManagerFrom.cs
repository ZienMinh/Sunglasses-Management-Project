using Service;
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

    public partial class SunglassesManagerFrom : Form
    {
        private SunglassService sunglassService = new SunglassService();
        private ManufactureService manufactureService = new ManufactureService();

        public SunglassesManagerFrom()
        {
            InitializeComponent();
        }

        private void SunglassesManagerFrom_Load(object sender, EventArgs e)
        {
            var result = sunglassService.GetAllSunglasses();

            var displayList = result.Select(sunglass => new
            {
                sunglass.SunglassesId,
                sunglass.SunglassesName,
                sunglass.Feature,
                sunglass.Material,
                sunglass.Shape,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ManufacturerId,
                ManufacturerName = sunglass.Manufacturer?.ManufacturerName
            }).ToList();

            dgvSunglassList.DataSource = null;
            dgvSunglassList.DataSource = displayList;

            cboManufacture.DataSource = manufactureService.GetAllCategories();
            cboManufacture.DisplayMember = "ManufacturerName";
            cboManufacture.ValueMember = "ManufacturerId";


        }

        private void SunglassesManagerFrom_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var result = sunglassService.SearchSunglasses(txtKeyword.Text.Trim());

            if (result.Count == 0)
            {
                MessageBox.Show("Cannot find the result!!!",
                    "Search keyword cannot find",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var displayList = result.Select(sunglass => new
            {
                sunglass.SunglassesId,
                sunglass.SunglassesName,
                sunglass.Feature,
                sunglass.Material,
                sunglass.Shape,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ManufacturerId,
                ManufacturerName = sunglass.Manufacturer?.ManufacturerName
            }).ToList();

            dgvSunglassList.DataSource = null;
            dgvSunglassList.DataSource = displayList;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id;

            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The Sunglass ID is invalid. Please input a number!!!",
                    "Invalid Sunglass ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            sunglassService.DeleteASunglass(id);

            var result = sunglassService.GetAllSunglasses();

            var displayList = result.Select(sunglass => new
            {
                sunglass.SunglassesId,
                sunglass.SunglassesName,
                sunglass.Feature,
                sunglass.Material,
                sunglass.Shape,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ManufacturerId,
                ManufacturerName = sunglass.Manufacturer?.ManufacturerName
            }).ToList();

            dgvSunglassList.DataSource = null;
            dgvSunglassList.DataSource = displayList;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int id;
            if (string.IsNullOrWhiteSpace(txtId.Text) || !int.TryParse(txtId.Text, out id))
            {
                MessageBox.Show("The Sunglass ID is invalid. Please select a row in the grid to edit or input a number!!!",
                    "Invalid Sunglass ID",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            SunglassForm sunglassForm = new SunglassForm();
            sunglassForm.SunglassesId = int.Parse(txtId.Text);
            sunglassForm.ShowDialog();

            var result = sunglassService.GetAllSunglasses();

            var displayList = result.Select(sunglass => new
            {
                sunglass.SunglassesId,
                sunglass.SunglassesName,
                sunglass.Feature,
                sunglass.Material,
                sunglass.Shape,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ManufacturerId,
                ManufacturerName = sunglass.Manufacturer?.ManufacturerName
            }).ToList();

            dgvSunglassList.DataSource = null;
            dgvSunglassList.DataSource = displayList;
        }

        private void dgvSunglassList_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvSunglassList.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedSunglass = dgvSunglassList.SelectedRows[0];
                txtId.Text = selectedSunglass.Cells[0].Value.ToString();
                txtName.Text = selectedSunglass.Cells[1].Value.ToString();
                txtFeature.Text = selectedSunglass.Cells[2].Value.ToString();
                txtMaterial.Text = selectedSunglass.Cells[3].Value.ToString();
                txtShape.Text = selectedSunglass.Cells[4].Value.ToString();
                if (selectedSunglass.Cells[7].Value is DateTime)
                {
                    dtpCreatedDate.Value = (DateTime)selectedSunglass.Cells[7].Value;
                }
                txtQuantity.Text = selectedSunglass.Cells[6].Value.ToString();
                txtPrice.Text = selectedSunglass.Cells[5].Value.ToString();
                cboManufacture.SelectedValue = selectedSunglass.Cells[8].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SunglassForm sunglassForm = new SunglassForm();
            sunglassForm.SunglassesId = null;
            sunglassForm.ShowDialog();

            var result = sunglassService.GetAllSunglasses();

            var displayList = result.Select(sunglass => new
            {
                sunglass.SunglassesId,
                sunglass.SunglassesName,
                sunglass.Feature,
                sunglass.Material,
                sunglass.Shape,
                sunglass.Price,
                sunglass.Quantity,
                sunglass.CreatedDate,
                sunglass.ManufacturerId,
                ManufacturerName = sunglass.Manufacturer?.ManufacturerName
            }).ToList();

            dgvSunglassList.DataSource = null;
            dgvSunglassList.DataSource = displayList;
        }
    }
}
