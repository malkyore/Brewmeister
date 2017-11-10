using Microsoft.Win32;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Brewcrosoft_Brewmeister.Data;

namespace Brewcrosoft_Brewmeister
{
    public partial class IngredientManager : Form
    {
        public string dataurl;
        private APIHandler handler = new APIHandler();
        public IngredientManager()
        {
            InitializeComponent();
            RegistryKey adsfa = Registry.CurrentUser.OpenSubKey("SOFTWARE/Brewmeister");
            dataurl = (string)adsfa.GetValue("dataurl");
            //hopGrid.Columns.Add("Name","Name");
            //hopGrid.Columns.Add("AAU","AAU");

            maltTypeBox.Items.Add("Adjunct");
            maltTypeBox.Items.Add("Base Malt");
            maltTypeBox.Items.Add("Caramel/Crystal");
            maltTypeBox.Items.Add("Dry Extract");
            maltTypeBox.Items.Add("Grain");
            maltTypeBox.Items.Add("Kilned Malt");
            maltTypeBox.Items.Add("Liquid Extract");
            maltTypeBox.Items.Add("Mash");
            maltTypeBox.Items.Add("Roasted Malt");
            maltTypeBox.Items.Add("Sugar");

            refreshGrids();

        }

        private void refreshGrids()
        {
            refreshHopGrid();
            refreshMaltGrid();
            refreshYeastGrid();
        }
        private void refreshMaltGrid()
        {
            maltGrid.Rows.Clear();
            maltGrid.Columns.Clear();
            APIHandler data = new APIHandler();
            List<fermentable2> maltList = data.getFermentables();

            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colMaltName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "name",
                HeaderText = "Name",
                DataPropertyName = "name"
            };
            DataGridViewTextBoxColumn colMaltPPG= new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "ppg",
                HeaderText = "PPG",
                DataPropertyName = "ppg",
                Width = 50
            };
            DataGridViewTextBoxColumn colMaltColor = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "color",
                HeaderText = "Color",
                DataPropertyName = "color"
            };
            DataGridViewTextBoxColumn colMaltType = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "type",
                HeaderText = "Type",
                DataPropertyName = "type"
            };
            DataGridViewTextBoxColumn colMaltMaltster = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "maltster",
                HeaderText = "Maltster",
                DataPropertyName = "maltster"
            };
            DataGridViewTextBoxColumn colMaltID = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "id",
                HeaderText = "ID",
                DataPropertyName = "id",
                Visible = false
            };
            maltGrid.Columns.Add(colMaltName);
            maltGrid.Columns.Add(colMaltPPG);
            maltGrid.Columns.Add(colMaltColor);
            maltGrid.Columns.Add(colMaltType);
            maltGrid.Columns.Add(colMaltMaltster);
            maltGrid.Columns.Add(colMaltID);
            var bindingList = new BindingList<fermentable2>(maltList);
            maltGrid.DataSource = bindingList;
        }

        private void refreshHopGrid()
        {
            hopGrid.Rows.Clear();
            hopGrid.Columns.Clear();
            APIHandler data = new APIHandler();
            List<hop2> hopList = data.getHops();

            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colHopName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "name",
                HeaderText = "Name",
                DataPropertyName = "name"
            };
            DataGridViewTextBoxColumn colHopAAU = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "aau",
                HeaderText = "AAU",
                DataPropertyName = "aau",
                Width = 50
            };
            DataGridViewTextBoxColumn colHopID = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "id",
                HeaderText = "ID",
                DataPropertyName = "id",
                Visible = false
            };
            hopGrid.Columns.Add(colHopName);
            hopGrid.Columns.Add(colHopAAU);
            hopGrid.Columns.Add(colHopID);
            var bindingList = new BindingList<hop2>(hopList);
            hopGrid.DataSource = bindingList;
        }

        private void refreshYeastGrid()
        {
            yeastGrid.Rows.Clear();
            yeastGrid.Columns.Clear();
            APIHandler data = new APIHandler();
            List<yeast2> yeastList = data.getYeasts();

            DataGridViewCell cell = new DataGridViewTextBoxCell();
            DataGridViewTextBoxColumn colYeastName = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "name",
                HeaderText = "Name",
                DataPropertyName = "name"
            };
            DataGridViewTextBoxColumn colYeastLab = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "lab",
                HeaderText = "Lab",
                DataPropertyName = "lab",
                Width = 70
            };
            DataGridViewTextBoxColumn colYeastAttenuation = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "attenuation",
                HeaderText = "Attenuation",
                DataPropertyName = "attenuation",
                Width = 90
            };
            DataGridViewTextBoxColumn colYeastID = new DataGridViewTextBoxColumn()
            {
                CellTemplate = cell,
                Name = "id",
                HeaderText = "ID",
                DataPropertyName = "id",
                Visible = false
            };
            yeastGrid.Columns.Add(colYeastName);
            yeastGrid.Columns.Add(colYeastLab);
            yeastGrid.Columns.Add(colYeastAttenuation);
            yeastGrid.Columns.Add(colYeastID);
            var bindingList = new BindingList<yeast2>(yeastList);
            yeastGrid.DataSource = bindingList;
        }


        private void addHopButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(handler.GetDataProvider());
            var request = new RestRequest("/beernet/hop/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                name = postnamebox.Text,
                aau = postaaubox.Text
            }); // AddJsonBody serializes the object automatically

            IRestResponse response = client.Execute(request);
            refreshGrids();
    }

        private void postaaubox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void postnamebox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void deleteHopButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(handler.GetDataProvider());
            var request = new RestRequest("/beernet/hop/" + hopGrid.SelectedRows[0].Cells[3].Value , Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");

            IRestResponse response = client.Execute(request);
            refreshGrids();
        }

        private void addMaltButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(handler.GetDataProvider());
            var request = new RestRequest("/beernet/fermentable/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            fermentable2 currentFermentable = new fermentable2();
            currentFermentable.name = maltNameBox.Text;
            currentFermentable.ppg = float.Parse(maltPPGBox.Text);
            currentFermentable.color = float.Parse(maltColorBox.Text);
            currentFermentable.type = maltTypeBox.Text;
            currentFermentable.maltster = maltMaltsterBox.Text;
            request.AddJsonBody(currentFermentable); // AddJsonBody serializes the object automatically

            IRestResponse response = client.Execute(request);
            refreshGrids();
        }

        private void DeleteMaltButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(handler.GetDataProvider());
            var request = new RestRequest("/beernet/fermentable/" + maltGrid.SelectedRows[0].Cells[6].Value, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            IRestResponse response = client.Execute(request);
            refreshGrids();
        }

        private void addYeastButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(handler.GetDataProvider());
            var request = new RestRequest("/beernet/yeast/", Method.POST);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            request.AddJsonBody(
            new
            {
                name = yeastNameBox.Text,
                lab = yeastLabBox.Text,
                attenuation = yeastAttenuationBox.Text
            }); // AddJsonBody serializes the object automatically

            IRestResponse response = client.Execute(request);
            refreshGrids();
        }

        private void deleteYeastButton_Click(object sender, EventArgs e)
        {
            var client = new RestClient(handler.GetDataProvider());
            var request = new RestRequest("/beernet/yeast/" + yeastGrid.SelectedRows[0].Cells[4].Value, Method.DELETE);
            request.RequestFormat = DataFormat.Json;
            request.AddHeader("Content-type", "application/json");
            IRestResponse response = client.Execute(request);
            refreshGrids();
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            refreshGrids();
        }

        private void maltTypeBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
