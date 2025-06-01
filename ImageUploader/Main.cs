using Newtonsoft.Json;
using System.Runtime.InteropServices;

namespace ImageUploader
{
    public partial class Main : Form
    {
        private static string ApiPostEndpoint(string endpoint) => endpoint + "/upload";
        private static string ApiGetEndpoint(string endpoint) => endpoint + "/get";

        private readonly HttpClient httpClient = new();

        public Main()
        {
            InitializeComponent();

            string endpointFilePath = "./endpoint";
            if (File.Exists(endpointFilePath))
            {
                try
                {
                    string endpoint = File.ReadAllText(endpointFilePath).Trim();
                    if (!string.IsNullOrEmpty(endpoint))
                    {
                        endpointBox.Text = endpoint;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("�G���h�|�C���g�̓ǂݍ��݂Ɏ��s���܂����B\n" + ex.Message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            string apiKeyFilePath = "./apikey";
            if (File.Exists(apiKeyFilePath))
            {
                try
                {
                    string apiKey = File.ReadAllText(apiKeyFilePath).Trim();
                    if (!string.IsNullOrEmpty(apiKey))
                    {
                        apiKeyBox.Text = apiKey;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("API�L�[�̓ǂݍ��݂Ɏ��s���܂����B\n" + ex.Message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void Form1_DragEnter(object sender, DragEventArgs e) => e.Effect = DragDropEffects.All;

        private async void Form1_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                if (!CheckAuth()) return;
                string[]? files = e.Data?.GetData(DataFormats.FileDrop) as string[];
                if (files == null || files.Length == 0) return;

                string file = files[0];
                string ext = Path.GetExtension(file).ToLower();

                using var image = Image.FromFile(file);
                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Image)image.Clone(); // Clone to avoid disposing issues

                byte[] fileBytes = await File.ReadAllBytesAsync(file);
                await UploadAndDisplayImageAsync(fileBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�G���[���������܂����B\n" + ex.Message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!CheckAuth()) return;
                if (!(Clipboard.ContainsImage()))
                {
                    MessageBox.Show("�N���b�v�{�[�h�ɉ摜������܂���B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                var image = Clipboard.GetImage();
                if (image == null)
                {
                    MessageBox.Show("�N���b�v�{�[�h�ɉ摜������܂���B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                pictureBox1.Image?.Dispose();
                pictureBox1.Image = (Image)image.Clone();

                using var ms = new MemoryStream();
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                byte[] fileBytes = ms.ToArray();

                await UploadAndDisplayImageAsync(fileBytes);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�G���[���������܂����B\n" + ex.Message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async Task UploadAndDisplayImageAsync(byte[] fileBytes)
        {
            try
            {
                string endpoint = endpointBox.Text.Trim();
                string apiKey = apiKeyBox.Text.Trim();

                SaveApiData(endpoint, apiKey);

                httpClient.DefaultRequestHeaders.Remove("Authorization");
                httpClient.DefaultRequestHeaders.Add("Authorization", apiKey);

                using var content = new ByteArrayContent(fileBytes);
                HttpResponseMessage response = await httpClient.PostAsync(ApiPostEndpoint(endpoint), content);

                if (!response.IsSuccessStatusCode)
                {
                    var reason = response.ReasonPhrase ?? "�s���ȃG���[";
                    MessageBox.Show("�A�b�v���[�h�Ɏ��s���܂����B\n" + "�G���[: " + reason, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string json = await response.Content.ReadAsStringAsync();
                var jsonObj = JsonConvert.DeserializeObject<Dictionary<string, string>>(json);

                if (jsonObj == null || !jsonObj.TryGetValue("fileName", out string? uploadedFileName))
                {
                    MessageBox.Show("�A�b�v���[�h�Ɏ��s���܂����B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string url = ApiGetEndpoint(endpoint) + "?id=" + uploadedFileName;

                uploadedUrl.Text = url;

                CopyText();
            }
            catch (Exception ex)
            {
                MessageBox.Show("�A�b�v���[�h���ɃG���[���������܂����B\n" + ex.Message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private static void SaveApiData(string endpoint, string apiKey)
        {
            try
            {
                File.WriteAllText("./endpoint", endpoint);
                File.WriteAllText("./apikey", apiKey);
            }
            catch (Exception ex)
            {
                MessageBox.Show("�ݒ�̕ۑ��Ɏ��s���܂����B\n" + ex.Message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
            => CopyText();

        private void CopyText()
        {
            try
            {
                if (string.IsNullOrEmpty(uploadedUrl.Text))
                {
                    MessageBox.Show("�A�b�v���[�h���ꂽ�摜��URL������܂���B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                Clipboard.SetText(uploadedUrl.Text);
                System.Media.SystemSounds.Asterisk.Play();
            }
            catch (Exception ex)
            {
                if (ex is not ExternalException)
                    MessageBox.Show("�N���b�v�{�[�h�ւ̃R�s�[�Ɏ��s���܂����B\n" + ex.Message, "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool CheckAuth()
        {
            string endpoint = endpointBox.Text.Trim();
            string apiKey = apiKeyBox.Text.Trim();

            if (string.IsNullOrEmpty(endpoint) || string.IsNullOrEmpty(apiKey))
            {
                MessageBox.Show("�G���h�|�C���g�܂���API�L�[���ݒ肳��Ă��܂���B", "�G���[", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}
