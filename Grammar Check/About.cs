using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Grammar_Check
{
    public partial class About : Form
    {
        bool clicked = false;
        public About()
        {
            InitializeComponent();
        }

        private void clearKey(object sender, EventArgs e)
        {
            if (!clicked)
            {
                txtKey.Clear();
                clicked = true;
            }
                
        }

        private void btnActive_Click(object sender, EventArgs e)
        {
            txtActiveResult.SelectAll();
            txtActiveResult.SelectionAlignment = HorizontalAlignment.Center;
            if (txtKey.Text == "" || txtKey.Text == "Nhập KEY")
                txtActiveResult.Text = "Vui lòng nhập key trước!";
            else
            {
                txtActiveResult.Text = "";
                btnActive.Enabled = false;
                getActive();
            }
        }

        async void getActive()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage response = await client.GetAsync("https://console.virtualwritingtutor.com/console/auth/info?vwtapikey=" + txtKey.Text))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string json = await content.ReadAsStringAsync();
                            if (json.Contains("remaining_grammar_hits"))
                            {
                                Properties.Settings.Default.KEY = txtKey.Text;
                                Properties.Settings.Default.Save();
                                txtActiveResult.Text = "Kích hoạt thành công!\nSố lượt check còn lại: "+json.Substring(json.Length - 4, 2);
                            }
                            else
                            {
                                txtActiveResult.Text = "Key không hợp lệ!";
                            }
                            btnActive.Enabled = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    getActive();
                    return;
                }
            }
        }

        private void ActiveKey(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtActiveResult.SelectAll();
                txtActiveResult.SelectionAlignment = HorizontalAlignment.Center;
                if (txtKey.Text == "" || txtKey.Text == "Nhập KEY")
                    txtActiveResult.Text = "Vui lòng nhập key trước!";
                else
                {
                    txtActiveResult.Text = "";
                    btnActive.Enabled = false;
                    getActive();
                }
            }
        }
    }
}
