using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przychodnia
{
    public partial class UcPatientList : UserControl
    {
        public UcPatientList()
        {
            InitializeComponent();
            dataGridView1.DataSource = Database.patientList;
        }
    }
}
