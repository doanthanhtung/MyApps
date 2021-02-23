using Newtonsoft.Json;
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
    public partial class MainForm : Form
    {
        public static string KEY = Properties.Settings.Default.KEY;

        public MainForm()
        {
            InitializeComponent();
        }

        private void btnCheckGrammar_Click(object sender, EventArgs e)
        {
            txtResult.Clear();
            btnCheckGrammar.Enabled = false;
            checkGrammar(txtText.Text);
        }

        async void checkGrammar(string text)
        {
            string webCheck = "https://virtualwritingtutor.com/api/checkgrammar.php";
            IEnumerable<KeyValuePair<string, string>> queries = new List<KeyValuePair<string, string>>()
            {
                new KeyValuePair<string, string>("text",text),
                new KeyValuePair<string, string>("appKey",Properties.Settings.Default.KEY)
            };
            HttpContent body = new FormUrlEncodedContent(queries);
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    using (HttpResponseMessage response = await client.PostAsync(webCheck, body))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string json = await content.ReadAsStringAsync();
                            Result result = JsonConvert.DeserializeObject<Result>(json);
                            showResult(result);
                            btnCheckGrammar.Enabled = true;
                        }
                    }
                }
                catch (Exception e)
                {
                    using (HttpResponseMessage response = await client.PostAsync(webCheck, body))
                    {
                        using (HttpContent content = response.Content)
                        {
                            string json = await content.ReadAsStringAsync();
                            Result result = JsonConvert.DeserializeObject<Result>(json);
                            showResult(result);
                            btnCheckGrammar.Enabled = true;
                        }
                    }
                    return;
                }

            }
        }

        private void showResult(Result result)
        {
            if (result.status.Equals("401"))
            {
                txtResult.Clear();
                txtResult.AppendText("Bạn đã sử dụng hết số lượt miễn phí. Liên hệ Doãn Thanh Tùng để nhận key!", Color.Red);
            }
            else
            {
                txtResult.AppendText("Error count: ", FontStyle.Bold);
                txtResult.AppendText(result.error_grammar_count_total + "\n");
                txtResult.AppendText("Error density: ", FontStyle.Bold);
                txtResult.AppendText(result.error_grammar_percent + "\n");
            }
            
            if (result.error_grammar_count_total > 0)
            {

                for (int i = 1; i <= result.error_grammar_count_total; i++)
                {
                    txtResult.AppendText("\n" + i + ". You wrote: ", FontStyle.Bold);
                    mark_error_grammar(result, i);
                    txtResult.AppendText("\n" + "Feedback: ", FontStyle.Bold);
                    txtResult.AppendText(result.feedbacks[i - 1].feedback_grammar);
                    txtResult.AppendText("\nSuggestion: ", FontStyle.Bold);
                    for (int j = 0; j < result.feedbacks[i - 1].suggestions.Count; j++)
                    {
                        txtResult.AppendText(" " + result.feedbacks[i - 1].suggestions[j], Color.Blue);
                    }
                    txtResult.AppendText("\n");
                }
            }

        }

        private void mark_error_grammar(Result result, int i)
        {
            int firstIndex = result.feedbacks[i - 1].context.IndexOf(result.feedbacks[i - 1].error_grammar);
            int lastIndex = firstIndex + result.feedbacks[i - 1].error_grammar.Length;
            txtResult.AppendText(result.feedbacks[i - 1].context.Substring(0, firstIndex));
            txtResult.AppendText(result.feedbacks[i - 1].context.Substring(firstIndex, result.feedbacks[i - 1].error_grammar.Length), Color.Red);
            txtResult.AppendText(result.feedbacks[i - 1].context.Substring(lastIndex));
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtText.Clear();
            txtResult.Clear();
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtResult.Clear();
                btnCheckGrammar.Enabled = false;
                checkGrammar(txtText.Text);
            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.ShowDialog();
        }
    }

    public class Result
    {
        [JsonProperty("status")]
        public string status { get; set; }
        [JsonProperty("message")]
        public string message { get; set; }
        [JsonProperty("error_grammar_count_total")]
        public int error_grammar_count_total { get; set; }
        [JsonProperty("error_grammar_percent")]
        public string error_grammar_percent { get; set; }

        [JsonProperty("check_grammar_feedback")]
        public List<Feedback> feedbacks { get; set; }

    }

    public class Feedback
    {
        [JsonProperty("context")]
        public string context { get; set; }
        [JsonProperty("error_grammar")]
        public string error_grammar { get; set; }

        public string feedback_grammar { get; set; }
        [JsonProperty("feedback_grammar_suggestion")]
        public List<string> suggestions { get; set; }
    }

    public static class RichTextBoxExtensions
    {
        public static void AppendText(this RichTextBox box, string text, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        public static void AppendText(this RichTextBox box, string text, FontStyle fontStyle)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;
            box.SelectionFont = new Font(box.Font, fontStyle);
            box.AppendText(text);
            box.SelectionFont = new Font(box.Font, FontStyle.Regular);
        }
    }

}
