using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;
namespace coursework
{

    public partial class Form1 : Form
    {
        private string inputString;
        private string inputN;
        private bool validInput = false;
        public string get_inputString()
        {
            return inputString;
        }
        public string get_inputN()
        {
            return inputN;
        }
        public void set_inputString(string inputString)
        {
            this.inputString = inputString;
        }
        public void set_inputN(string inputN)
        {
            this.inputN = inputN;
        }
        public Form1()
        {
            InitializeComponent();
        }
        private string_processing stringProcessing = new string_processing();
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void notification_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void stringInput_TextChanged(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            inputString = stringInput.Text;
            inputN = numberInput.Text;
            if (inputN == "" || inputString == "")
            {
                notification.Text = "Please enter both string and number";
                return;
            }
            else if (!int.TryParse(inputN, out int N))
            {
                notification.Text = "Please enter a valid integer";
                return;
            }



            int inputNInt = Convert.ToInt32(inputN);
            stringProcessing.SetInput(inputString, inputNInt);
            int output = stringProcessing.ValidateInput();

            string notify = "";
            if (output == 7)
            {
                notify = "Valid input";
                validInput = true;
            }
            else
            {
                notify = "Invalid input";
                if ((output & 1) == 0)
                {
                    if (notify.Length > 0)
                    {
                        notify += ", ";
                    }
                    notify += " String must contain only characters A-Z";
                }
                if ((output & 2) == 0)
                {
                    if (notify.Length > 0)
                    {
                        notify += ", ";
                    }
                    notify += "String length must be in range [1; 40]";
                }
                if ((output & 4) == 0)
                {
                    if (notify.Length > 0)
                    {
                        notify += ", ";
                    }
                    notify += "Number must be in range [-25; 25]";
                }
            }
            notification.Text = notify;
        }
        
        private class string_processing
        {

            private string inputString;
            private int inputN;
            private int[] R = new int[40];
            private int[] L = new int[40];
            // Setter to assign data from UI
            public void SetInput(string inputString, int inputN)
            {
                this.inputString = inputString;
                this.inputN = inputN;
            }
            public int ValidateInput()
            {
                int output = 7; // 111 in binary: assume all conditions valid

                // Bit 1: Validate string length [1; 40]
                // If invalid, clear bit 1 (value 2)
                output = output & ((inputString.Length >= 1 && inputString.Length <= 40) ? 7 : 5); // 5 = 101 (clear bit 1)

                // Bit 0: Validate all characters A-Z
                // If invalid, clear bit 0 (value 1)
                output = output & (inputString.All(c => c >= 'A' && c <= 'Z') ? 7 : 6); // 6 = 110 (clear bit 0)

                // Bit 2: Validate inputN in [0; 25]
                // If invalid, clear bit 2 (value 4)
                output = output & ((inputN >= -25 && inputN <= 25) ? 7 : 3); // 3 = 011 (clear bit 2)

                return output;
            }

            // AES encryption, combined with SHA256 hash
            public string Encrypt()
            {
                string plainText = inputString;
                string key = inputN.ToString();

                string hash = GetSHA256(plainText);
                string combined = plainText + "|" + hash;

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
                    aes.IV = new byte[16]; // Default IV is 0
                    ICryptoTransform encryptor = aes.CreateEncryptor();

                    byte[] inputBytes = Encoding.UTF8.GetBytes(combined);
                    byte[] encrypted = encryptor.TransformFinalBlock(inputBytes, 0, inputBytes.Length);

                    return Convert.ToBase64String(encrypted);
                }
            }

            // AES decryption, validates hash after decryption
            public string Decrypt(string encryptedText)
            {
                string key = inputN.ToString();

                using (Aes aes = Aes.Create())
                {
                    aes.Key = Encoding.UTF8.GetBytes(key.PadRight(32).Substring(0, 32));
                    aes.IV = new byte[16]; // same as during encryption
                    ICryptoTransform decryptor = aes.CreateDecryptor();

                    byte[] encryptedBytes = Convert.FromBase64String(encryptedText);
                    byte[] decrypted = decryptor.TransformFinalBlock(encryptedBytes, 0, encryptedBytes.Length);

                    string combined = Encoding.UTF8.GetString(decrypted);
                    string[] parts = combined.Split('|');
                    string original = parts[0];
                    string hash = parts[1];

                    return GetSHA256(original) == hash ? original : null;
                }
            }

            // SHA256 hash generator
            private static string GetSHA256(string text)
            {
                using (SHA256 sha256 = SHA256.Create())
                {
                    byte[] bytes = Encoding.UTF8.GetBytes(text);
                    byte[] hashBytes = sha256.ComputeHash(bytes);
                    return BitConverter.ToString(hashBytes).Replace("-", "");
                }
            }

            public string EncodeString()
            {
                string result = "";
                foreach (char ch in inputString)
                {
                    char newChar = (char)((((ch - 'A') + inputN) % 26 + 26) % 26 + 'A');
                    result += newChar;
                }
                return result;
            }

            private int[] GetAcssiValues(string st)
            {
                int l = st.Length;
                int[] values = new int[l];
                for(int i = 0; i < l; i++)
                {
                    values[i] = (int)st[i];
                }
                return values;
            }
            public int[] GetAcsiiValuesBeforeEncoding()
            {
                return GetAcssiValues(inputString);
            }
            
            public int[] GetAcsiiValuesAfterEncoding()
            {
                return GetAcssiValues(EncodeString());
            }

            private void Merge_Arr(ref int[] arr , int l , int r , int mid)
            {
                int n1 = mid - l + 1;
                int n2 = r - mid;
                for (int i1 =0; i1 < n1; i1++)
                {
                    L[i1] = arr[l + i1];
                }
                for(int i2 = 0; i2 < n2; i2++)
                {
                    R[i2] = arr[mid + 1 + i2];
                }

                int i = 0, j = 0;
                int k = l;
                for(; i < n1 && j < n2;)
                {
                    if(L[i] <= R[j])
                    {
                        arr[k] = L[i];
                        i++;
                    }
                    else
                    {
                        arr[k] = R[j];
                        j++;    
                    }
                    k++;
                }
                while (i < n1)
                {
                    arr[k] = L[i];
                    i++;
                    k++;
                }
                while (j < n2)
                {
                    arr[k] = R[j];
                    j++;
                    k++;
                }

            }

            public int[] MergeSort(int[] arr, int l, int r)
            {
                if (l < r)
                {
                    int mid = l + (r - l) / 2;
                    MergeSort(arr, l, mid);
                    MergeSort(arr, mid + 1, r);
                    Merge_Arr(ref arr, l, r, mid);
                }
                return arr;
            }

        }


        private void EncodeButton_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);  
            if (!validInput)
            {
                return;
            }

            button1_Click(sender, e);
            if (!validInput) return;

            string result = stringProcessing.EncodeString();
            EncodeResult.Text = result;

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void print1Button_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            if (!validInput)
            {
                return;
            }
            int[] arr = stringProcessing.GetAcsiiValuesBeforeEncoding();
            EncodeResult.Text = "";
            foreach (int i in arr)
            {
                EncodeResult.Text += i.ToString() + "; ";
            }


        }
        

        private void SortButton_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            if (!validInput)
            {
                return;
            }
            int[] arr = stringProcessing.GetAcsiiValuesBeforeEncoding();
            int l = 0;
            int r = arr.Length - 1;
            arr = stringProcessing.MergeSort(arr, l, r);
            EncodeResult.Text = "";
            foreach (int i in arr)
            {
                EncodeResult.Text += i.ToString() + "; ";
            }
        }

        private void print2Button_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            if (!validInput)
            {
                return;
            }
            int[] arr = stringProcessing.GetAcsiiValuesAfterEncoding();
            EncodeResult.Text = "";
            foreach (int i in arr)
            {
                EncodeResult.Text += i.ToString() + "; ";
            }
        }
        private void PrintEncryptedbutton_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            if (!validInput)
            {
                return;
            }
            string result = stringProcessing.Encrypt();
            EncodeResult.Text = result;
            Console.Write(result);
        }

        private void PrintDecryptedbutton_Click(object sender, EventArgs e)
        {
            button1_Click(sender, e);
            if (!validInput)
            {
                return;
            }
            string encryptedText = textBox1.Text;
            string decryptedText = stringProcessing.Decrypt(encryptedText);
            if (decryptedText != null)
            {
                Result_2.Text = decryptedText;
            }
            else
            {
                Result_2.Text = "Decryption failed: Hash mismatch";
            }
        }
    } 
}
