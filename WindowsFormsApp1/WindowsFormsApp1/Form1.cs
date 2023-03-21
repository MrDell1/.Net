using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public string constSelection;
        public string varSelection;
        public Form1()
        {
            InitializeComponent();
            constSelection = string.Empty;
            varSelection = string.Empty;
        }

        private void ConstBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            remove.Enabled = false;
            add.Enabled = true;
            constSelection = constBox.SelectedItem.ToString();

        }

        private void Remove_Click(object sender, EventArgs e)
        {
            
            varBox.Items.Remove(varBox.SelectedItem);

        }

        private void Add_Click(object sender, EventArgs e)
        {
            if(constSelection == "Car")
            {
                Car car = new Car();
                varBox.Items.Add(car);
            }
            if (constSelection == "Submarine")
            {
                Submarine submarine = new Submarine();
                varBox.Items.Add(submarine);
            }
            if (constSelection == "Plane")
            {
                Plane plane = new Plane();  
                varBox.Items.Add(plane );
            }
            if (constSelection == "Computer")
            {
                Computer computer = new Computer();
                varBox.Items.Add(computer );
            }

        }

        private void VarBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Object toy = varBox.SelectedItem;
            remove.Enabled = true;
            add.Enabled = false;
            accelerate.Visible = false;
            deep.Visible = false;
            height.Visible = false;
            if (toy is IAccelerate)
            {
                accelerate.Visible = true;
                speed.Value = ((IAccelerate)toy).GetSpeed();
            }
            if (toy is IDive)
            {
                deep.Visible = true;
                deepnes.Value = ((IDive)toy).GetDeepnes();
            }
            if (toy is IRise)
            {
                height.Visible = true;
                altitude.Value = ((IRise)toy).GetAltitude();
            }
        }

        private void Speed_ValueChanged(object sender, EventArgs e)
        {
            Object toy = varBox.SelectedItem;
            ((IAccelerate)toy).Accelerate(speed.Value);
            SpeedValue.Text = speed.Value.ToString();
        }

        private void Deepnes_ValueChanged(object sender, EventArgs e)
        {
            Object toy = varBox.SelectedItem;
            ((IDive)toy).Dive(deepnes.Value);
            DeepValue.Text = deepnes.Value.ToString();
        }

        private void Altitude_ValueChanged(object sender, EventArgs e)
        {
            Object toy = varBox.SelectedItem;
            ((IRise)toy).Rise(altitude.Value);
            AltitudeValue.Text = altitude.Value.ToString();
        }
    }
}
