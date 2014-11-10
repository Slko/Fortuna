using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.IO;

namespace Fortuna
{
    public partial class MainForm : Form
    {
        private const string dataSourceUrl = "http://bm.inbet.cc/fortuna_json";
        private int roundTime = 120;
        private int lastPacketVersion = 0;

        public MainForm()
        {
            InitializeComponent();
        }

        private void updateDataCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            updateTimer.Enabled = updateDataCheckBox.Checked;
        }

        private async void updateTimer_Tick(object sender, EventArgs e)
        {
            JObject data;
            try
            {
                data = await GetJson(String.Format("{0}?vsn={1}", dataSourceUrl, lastPacketVersion));
            }
            catch (WebException ex)
            {
                statusLabel.Text = "Ошибка подключения: " + ex.Message;
                return;
            }
            catch (JsonException ex)
            {
                statusLabel.Text = "Ошибка обработки данных от сервера: " + ex.Message;
                return;
            }
            catch (Exception ex)
            {
                statusLabel.Text = "Неизвестная ошибка: " + ex.Message;
                return;
            }
            lastPacketVersion = data["state"].Value<int>("vsn");
            string state = data["state"].Value<string>("state");
            roundLabel.Text = data["state"].Value<int>("round").ToString();
            switch (state)
            {
                case "betting":
                    statusLabel.Text = "Приём ставок";
                    int scrollOffset = betsGridView.FirstDisplayedScrollingRowIndex;
                    betsGridView.Rows.Clear();
                    JObject stakesObject = (JObject)data["state"]["stakes"];
                    IEnumerable<KeyValuePair<int, float>> stakes = stakesObject.Properties()
                                                                               .Select(x => new KeyValuePair<int, float>(int.Parse(x.Name), x.Value.Value<float>()))
                                                                               .OrderBy(x => x.Key);
                    betsGridView.Rows.AddRange(stakes.Select(x => 
                        {
                            DataGridViewRow row = new DataGridViewRow();
                            row.Cells.Add(new DataGridViewTextBoxCell()
                                {
                                    Value = x.Key.ToString(),
                                });
                            row.Cells.Add(new DataGridViewTextBoxCell()
                                {
                                    Value = x.Value.ToString(),
                                });
                            return row;
                        }).ToArray());
                    if ((scrollOffset != -1) && (betsGridView.RowCount > scrollOffset))
                    {
                        betsGridView.FirstDisplayedScrollingRowIndex = scrollOffset;
                    }
                    break;
                case "playing":
                    statusLabel.Text = "Розыгрыш";
                    break;
                default:
                    statusLabel.Text = state;
                    break;
            }
            roundTime = (int)(data["state"].Value<double>("time2switch") - data["state"].Value<double>("stamp"));
            int tick = roundTime - (int)Math.Round(data["state"].Value<double>("time2switch") - data.Value<double>("time"));
            gameProgressBar.Maximum = roundTime;
            gameProgressBar.Value = tick;
        }

        async Task<JObject> GetJson(string url)
        {
            HttpWebRequest request = WebRequest.CreateHttp(url);
            request.AutomaticDecompression = DecompressionMethods.Deflate | DecompressionMethods.GZip;

            string jsonString;

            using (WebResponse response = await request.GetResponseAsync())
            using (StreamReader reader = new StreamReader(response.GetResponseStream()))
            {
                jsonString = await reader.ReadToEndAsync();
            }

            return JObject.Parse(jsonString);
        }

        private void updatePeriodNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            updateTimer.Interval = (int)updatePeriodNumericUpDown.Value;
        }

        private void updateProgressBarTimer_Tick(object sender, EventArgs e)
        {
            gameProgressBar.Value = Math.Min(gameProgressBar.Value + 1, gameProgressBar.Maximum);
        }
    }
}
