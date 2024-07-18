using System;
using System.Drawing;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace Doyohim_DictionaryProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private async void searchBtn_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;

            if (string.IsNullOrWhiteSpace(searchTerm))
            {
                displayBox.Text = "Please enter a word to search.";
                return;
            }

            string apiUrl = $"https://api.dictionaryapi.dev/api/v2/entries/en/{searchTerm}";

            displayWord.Text = searchTerm;
            searchBox.Clear();

            string jsonData = await getData(apiUrl);
            displayBox.Tag = jsonData;
            displayWordInfo(jsonData, DisplayMode.All);
        }

        private async Task<string> getData(string url)
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    HttpResponseMessage response = await client.GetAsync(url);
                    if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                    {
                        return "The requested word was not found.";
                    }

                    response.EnsureSuccessStatusCode();
                    string responseData = await response.Content.ReadAsStringAsync();
                    return responseData;
                }
                catch (HttpRequestException e)
                {
                    return $"Request error: {e.Message}";
                }
                catch (Exception e)
                {
                    return $"An error occurred: {e.Message}";
                }
            }
        }

        private enum DisplayMode
        {
            All,
            Definition,
            LexicalRelationship,
            Example
        }

        private void displayWordInfo(string jsonData, DisplayMode mode)
        {
            if (jsonData.StartsWith("Request error") || jsonData.StartsWith("An error occurred") || jsonData == "The requested word was not found.")
            {
                displayBox.Text = "No definitions found. Please check the spelling and try again.";
                return;
            }

            try
            {
                var json = JArray.Parse(jsonData);

                if (json.Count == 0)
                {
                    displayBox.Text = "No definitions found. Please check the spelling and try again.";
                    return;
                }

                var wordDetails = json[0];
                var meanings = wordDetails["meanings"];
                var phonetic = wordDetails["phonetic"]?.ToString() ?? "N/A";

                displayBox.Clear();

                if (mode == DisplayMode.All || mode == DisplayMode.Definition)
                {
                    AppendText(displayBox, $"Phonetic: {phonetic}\n\n", FontStyle.Italic, ColorTranslator.FromHtml("#1A5319"));
                }

                foreach (var meaning in meanings)
                {
                    string partOfSpeech = meaning["partOfSpeech"]?.ToString() ?? "N/A";

                    if (mode == DisplayMode.All || mode == DisplayMode.Definition)
                    {
                        AppendText(displayBox, $"Part of Speech: {partOfSpeech}\n", FontStyle.Bold, ColorTranslator.FromHtml("#1A5319"));
                        AppendText(displayBox, "Definition:\n", FontStyle.Regular, ColorTranslator.FromHtml("#1A5319"));
                        foreach (var definition in meaning["definitions"])
                        {
                            string def = definition["definition"]?.ToString() ?? "N/A";
                            AppendText(displayBox, $"• {def}\n", FontStyle.Regular, ColorTranslator.FromHtml("#508D4E"));
                        }
                    }

                    if (mode == DisplayMode.All || mode == DisplayMode.LexicalRelationship)
                    {
                        bool synonymsDisplayed = false;
                        bool antonymsDisplayed = false;
                        foreach (var definition in meaning["definitions"])
                        {
                            var synonymsArray = definition["synonyms"]?.ToObject<string[]>();
                            string synonyms = (synonymsArray != null && synonymsArray.Length > 0) ? string.Join(", ", synonymsArray) : null;

                            var antonymsArray = definition["antonyms"]?.ToObject<string[]>();
                            string antonyms = (antonymsArray != null && antonymsArray.Length > 0) ? string.Join(", ", antonymsArray) : null;

                            if (!synonymsDisplayed)
                            {
                                AppendText(displayBox, $"Part of Speech: {partOfSpeech}\n", FontStyle.Bold, ColorTranslator.FromHtml("#1A5319"));
                                AppendText(displayBox, "Synonyms:\n", FontStyle.Regular, ColorTranslator.FromHtml("#1A5319"));
                                AppendText(displayBox, $"• {(synonyms ?? "There are no synonyms for this word.")}\n", FontStyle.Regular, ColorTranslator.FromHtml("#508D4E"));
                                synonymsDisplayed = true;
                            }

                            if (!antonymsDisplayed)
                            {
                                AppendText(displayBox, $"Part of Speech: {partOfSpeech}\n", FontStyle.Bold, ColorTranslator.FromHtml("#1A5319"));
                                AppendText(displayBox, "Antonyms:\n", FontStyle.Regular, ColorTranslator.FromHtml("#1A5319"));
                                AppendText(displayBox, $"• {(antonyms ?? "There are no antonyms for this word.")}\n", FontStyle.Regular, ColorTranslator.FromHtml("#508D4E"));
                                antonymsDisplayed = true;
                            }
                        }
                    }

                    if (mode == DisplayMode.All || mode == DisplayMode.Example)
                    {
                        bool exampleExists = false;
                        foreach (var definition in meaning["definitions"])
                        {
                            string example = definition["example"]?.ToString();
                            if (!string.IsNullOrEmpty(example))
                            {
                                if (!exampleExists)
                                {
                                    AppendText(displayBox, $"Part of Speech: {partOfSpeech}\n", FontStyle.Bold, ColorTranslator.FromHtml("#1A5319"));
                                    AppendText(displayBox, "\nExample Usage:\n", FontStyle.Regular, ColorTranslator.FromHtml("#1A5319"));
                                    exampleExists = true;
                                }
                                AppendText(displayBox, $"• {example}\n", FontStyle.Regular, ColorTranslator.FromHtml("#508D4E"));
                            }
                        }
                    }

                    displayBox.AppendText("\n");
                }
            }
            catch (Exception e)
            {
                displayBox.Text = $"An error occurred while processing the data: {e.Message}";
            }
        }

        private void AppendText(RichTextBox box, string text, FontStyle style, Color color)
        {
            box.SelectionStart = box.TextLength;
            box.SelectionLength = 0;

            box.SelectionFont = new Font(box.Font, style);
            box.SelectionColor = color;
            box.AppendText(text);
            box.SelectionColor = box.ForeColor;
        }

        private void defBtn_Click(object sender, EventArgs e)
        {
            string jsonData = displayBox.Tag as string;
            if (string.IsNullOrEmpty(jsonData))
            {
                displayBox.Text = "Please enter a word to search.";
                return;
            }

            displayWordInfo(jsonData, DisplayMode.Definition);
        }

        private void lexicalRelBtn_Click(object sender, EventArgs e)
        {
            string jsonData = displayBox.Tag as string;
            if (string.IsNullOrEmpty(jsonData))
            {
                displayBox.Text = "Please enter a word to search.";
                return;
            }

            displayWordInfo(jsonData, DisplayMode.LexicalRelationship);
        }

        private void examBtn_Click(object sender, EventArgs e)
        {
            string jsonData = displayBox.Tag as string;
            if (string.IsNullOrEmpty(jsonData))
            {
                displayBox.Text = "Please enter a word to search.";
                return;
            }

            displayWordInfo(jsonData, DisplayMode.Example);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            displayBox.Clear();
            displayWord.Clear();
            displayBox.Tag = null;
        }
    }
}
