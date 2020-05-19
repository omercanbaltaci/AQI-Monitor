using Newtonsoft.Json.Linq;
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
using System.Runtime.InteropServices;
using System.Globalization;
using GMap.NET.MapProviders;
using GMap.NET;
using System.Diagnostics;

namespace SampleProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MaximizeBox = false;
            this.CenterToScreen();
            panel1.Visible = false;
            hkeLabel.Visible = false;
            dominantPol.Visible = false;
            karbonmonoksit.Visible = false;
            humidity.Visible = false;
            azotdioksit.Visible = false;
            ozon.Visible = false;
            basinc.Visible = false;
            pm10.Visible = false;
            pm25.Visible = false;
            kukurtdioksit.Visible = false;
            sicaklik.Visible = false;
            ruzgar.Visible = false;
            goodLabel.Visible = false;
            moderateLabel.Visible = false;
            sensitiveLabel.Visible = false;
            sagliksizLabel.Visible = false;
            coksagliksizLabel.Visible = false;
            zehirliLabel.Visible = false;
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://api.waqi.info/feed/" + RemoveDiacritics(cityField.Text) + "/?token=e36f4ad8cc0b43ea569f98629f981c92d86ee98a";

            var client = new RestClient(url);
            client.Timeout = -1;
            var request = new RestRequest(Method.GET);
            request.AlwaysMultipartFormData = true;
            IRestResponse response = client.Execute(request);

            var myJsonString = response.Content;
            var jo = JObject.Parse(myJsonString);

            gMapControl1.MapProvider = GMapProviders.GoogleMap;

            if (!jo["status"].ToString().Equals("ok"))
            {
                MessageBox.Show("Aradığınız şehre ait veri bulunamadı.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cityField.Text = "";
                return;
            }

            var aqi = jo["data"]["aqi"].ToString();

            gMapControl1.Position = new PointLatLng(Convert.ToDouble(jo["data"]["city"]["geo"][0].ToString()),
                Convert.ToDouble(jo["data"]["city"]["geo"][1].ToString()));
            gMapControl1.DragButton = MouseButtons.Left;
            gMapControl1.Zoom = 10;

            if (Int32.Parse(aqi) <= 50)
            {
                panel1.BackColor = Color.FromArgb(0, 228, 0);
                panel1.Visible = true;
                hkeLabel.ForeColor = Color.Black;
                hkeLabel.Text = "HKE: " + aqi;
                hkeLabel.Visible = true;
            }
            else if (Int32.Parse(aqi) >= 51 & Int32.Parse(aqi) <= 100)
            {
                panel1.BackColor = Color.FromArgb(255, 255, 0);
                panel1.Visible = true;
                hkeLabel.ForeColor = Color.Black;
                hkeLabel.Text = "HKE: " + aqi;
                hkeLabel.Visible = true;
            }
            else if (Int32.Parse(aqi) >= 101 & Int32.Parse(aqi) <= 150)
            {
                panel1.BackColor = Color.FromArgb(255, 126, 0);
                panel1.Visible = true;
                hkeLabel.ForeColor = Color.Black;
                hkeLabel.Text = "HKE: " + aqi;
                hkeLabel.Visible = true;
            }
            else if (Int32.Parse(aqi) >= 151 & Int32.Parse(aqi) <= 200)
            {
                panel1.BackColor = Color.FromArgb(255, 0, 0);
                panel1.Visible = true;
                hkeLabel.ForeColor = Color.White;
                hkeLabel.Text = "HKE: " + aqi;
                hkeLabel.Visible = true;
            }
            else if (Int32.Parse(aqi) >= 201 & Int32.Parse(aqi) <= 300)
            {
                panel1.BackColor = Color.FromArgb(153, 0, 76);
                panel1.Visible = true;
                hkeLabel.ForeColor = Color.White;
                hkeLabel.Text = "HKE: " + aqi;
                hkeLabel.Visible = true;
            }
            else if (Int32.Parse(aqi) >= 301 & Int32.Parse(aqi) <= 500)
            {
                panel1.BackColor = Color.FromArgb(126, 0, 35);
                panel1.Visible = true;
                hkeLabel.ForeColor = Color.White;
                hkeLabel.Text = "HKE: " + aqi;
                hkeLabel.Visible = true;
            }

            sourceLabel.ForeColor = hkeLabel.ForeColor;
            sourceLabel.Text = jo["data"]["attributions"][0]["url"].ToString();
            lastUpdated.ForeColor = hkeLabel.ForeColor;
            string date = jo["data"]["time"]["s"].ToString();
            lastUpdated.Text = date.Substring(8, 2) + "/" + date.Substring(5, 2) + "/" + date.Substring(0, 4) + 
                " " + date.Substring(11, 5);

            dominantPol.Visible = true;
            dominantPol.Text = "Dominant kirletici: " + jo["data"]["dominentpol"].ToString().ToUpper();

            karbonmonoksit.Visible = true;
            if (jo["data"]["iaqi"]["co"] != null) 
                karbonmonoksit.Text = "Karbonmonoksit: " + jo["data"]["iaqi"]["co"]["v"].ToString();
            else 
                karbonmonoksit.Text = "Karbonmonoksit: -";

            humidity.Visible = true;
            if (jo["data"]["iaqi"]["h"] != null) 
                humidity.Text = "Nem: " + jo["data"]["iaqi"]["h"]["v"].ToString();
            else 
                humidity.Text = "Nem: -";

            azotdioksit.Visible = true;
            if (jo["data"]["iaqi"]["no2"] != null)
                azotdioksit.Text = "Azot dioksit: " + jo["data"]["iaqi"]["no2"]["v"].ToString();
            else
                azotdioksit.Text = "Azot dioksit: -";

            ozon.Visible = true;
            if (jo["data"]["iaqi"]["o3"] != null)
                ozon.Text = "Ozon: " + jo["data"]["iaqi"]["o3"]["v"].ToString();
            else
                ozon.Text = "Ozon: -";

            basinc.Visible = true;
            if (jo["data"]["iaqi"]["p"] != null)
                basinc.Text = "Basınç: " + jo["data"]["iaqi"]["p"]["v"].ToString();
            else
                basinc.Text = "Basınç: -";

            pm10.Visible = true;
            if (jo["data"]["iaqi"]["pm10"] != null)
                pm10.Text = "PM10: " + jo["data"]["iaqi"]["pm10"]["v"].ToString();
            else
                pm10.Text = "PM10: -";

            pm25.Visible = true;
            if (jo["data"]["iaqi"]["pm25"] != null)
                pm25.Text = "PM25: " + jo["data"]["iaqi"]["pm25"]["v"].ToString();
            else
                pm25.Text = "PM25: -";

            kukurtdioksit.Visible = true;
            if (jo["data"]["iaqi"]["so2"] != null)
                kukurtdioksit.Text = "Kükürt dioksit: " + jo["data"]["iaqi"]["so2"]["v"].ToString();
            else
                kukurtdioksit.Text = "Kükürt dioksit: -";

            sicaklik.Visible = true;
            if (jo["data"]["iaqi"]["t"] != null)
                sicaklik.Text = "Sıcaklık: " + jo["data"]["iaqi"]["t"]["v"].ToString() + "°C";
            else
                sicaklik.Text = "Sıcaklık: -";

            ruzgar.Visible = true;
            if (jo["data"]["iaqi"]["w"] != null)
                ruzgar.Text = "Rüzgar: " + jo["data"]["iaqi"]["w"]["v"].ToString() + " mph";
            else
                ruzgar.Text = "Rüzgar: -";

            cityField.Text = "";

            panel3.BackColor = Color.FromArgb(0, 228, 0);
            goodLabel.Visible = true;
            goodLabel.Text = "İyi\n0-50";
            goodLabel.ForeColor = Color.Black;

            panel4.BackColor = Color.FromArgb(255, 255, 0);
            moderateLabel.Visible = true;
            moderateLabel.Text = "Orta\n51-100";
            moderateLabel.ForeColor = Color.Black;

            panel5.BackColor = Color.FromArgb(255, 126, 0);
            sensitiveLabel.Visible = true;
            sensitiveLabel.Text = "Kötü\n101-150";
            sensitiveLabel.ForeColor = Color.Black;

            panel6.BackColor = Color.FromArgb(255, 0, 0);
            sagliksizLabel.Visible = true;
            sagliksizLabel.Text = "Sağlıksız\n151-200";
            sagliksizLabel.ForeColor = Color.White;

            panel7.BackColor = Color.FromArgb(153, 0, 76);
            coksagliksizLabel.Visible = true;
            coksagliksizLabel.Text = "Çok sağlıksız\n201-300";
            coksagliksizLabel.ForeColor = Color.White;

            panel8.BackColor = Color.FromArgb(126, 0, 35);
            zehirliLabel.Visible = true;
            zehirliLabel.Text = "Zehirli\n201-300";
            zehirliLabel.ForeColor = Color.White;
        }

        static string RemoveDiacritics(string text)
        {
            var normalizedString = text.Normalize(NormalizationForm.FormD);
            var stringBuilder = new StringBuilder();

            foreach (var c in normalizedString)
            {
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);
                if (unicodeCategory != UnicodeCategory.NonSpacingMark)
                {
                    stringBuilder.Append(c);
                }
            }

            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}
