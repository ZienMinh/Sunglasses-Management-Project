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
    public partial class StaffForm : Form
    {
        private SunglassService sunglassService = new SunglassService();
        public StaffForm()
        {
            InitializeComponent();
        }

        private void StaffForm_Load(object sender, EventArgs e)
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
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void StaffForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
