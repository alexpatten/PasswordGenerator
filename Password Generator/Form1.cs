using System.Text.Json.Nodes;
using System.Text.RegularExpressions;

namespace Password_Generator
{
    public partial class Form1 : Form
    {
        // Instantiate variables
        private string pw = ""; // Variable for password
        private static string word1 = ""; // Variable for 1st word
        private string word2 = ""; // Variable for 2nd word
        private string apikey = ""; // RapidAPI Key

        public Form1()
        {
            InitializeComponent();
            pwLabel.UseMnemonic = false; // Fix special character glitch in form
        }

        // When user clicks password label
        #pragma warning disable CS4014 // Because this call is not awaited, execution of the current method continues before the call is completed
        void pwLabel_Click(object sender, EventArgs e)
        {
            Run(); // Begin Run task
        }

        // Task to generate the password, send it to clipboard, and update the passwordLabel
        async Task Run()
        {
            word1 = await RunAsync(); // Generate first word
            word2 = await RunAsync(); // Generate second word
            FormatPassword(); // Format the words
            SetPassword(); // Set the password
            if(GetPassword() != null) // If password is not null
            {
                pwLabel.Text = GetPassword(); // Add password to pwLabel
                Clipboard.SetText(GetPassword()); // Add password to clipboard
                copiedLabel.Text = "Text has been copied!"; // Change text of copedLabel
            }
            else
            {
                copiedLabel.Text = "No results! Check your connection and token."; // If no results, display on copiedLabel
            }
        }

        // Method for WordsAPI to get random 6 character word
        async Task<string> RunAsync()
        {
            string word = "";
            var client = new HttpClient();
            client.Timeout = TimeSpan.FromSeconds(10);
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wordsapiv1.p.rapidapi.com/words/?random=true&letters=6"),
                Headers =
                    {
                        { "X-RapidAPI-Key", apikey },
                        { "X-RapidAPI-Host", "wordsapiv1.p.rapidapi.com" },
                    },
            };

            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                word = await response.Content.ReadAsStringAsync();
            }
            client.Dispose();

            return word;
        }

        // Format JSON results
        void FormatPassword()
        {
            var jsonObject = JsonNode.Parse(word1);
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            word1 = Regex.Replace(jsonObject["word"].ToString(), @"\s+", "");
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
            jsonObject = JsonNode.Parse(word2);
            #pragma warning disable CS8602 // Dereference of a possibly null reference.
            word2 = Regex.Replace(jsonObject["word"].ToString(), @"\s+", "");
            #pragma warning restore CS8602 // Dereference of a possibly null reference.
        }

        // Generate random special character
        private char GetSpecChar()
        {
            var rand = new Random();
            char specChar = Convert.ToChar(rand.Next(35, 38));
            return specChar;
        }

        // Generate random number
        private char GetNum()
        {
            var rand = new Random();
            char middle = Convert.ToChar(rand.Next(0,9)+48);
            return middle;
        }

        // Combine words and random characters to generate password
        private void SetPassword()
        {
            pw = word1 + GetNum() + word2 + GetSpecChar();
        }

        // Get random password
        private string GetPassword()
        {
            return pw;
        }
    }
}