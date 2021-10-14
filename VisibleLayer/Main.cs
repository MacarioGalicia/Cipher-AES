using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using BussinesLayer;

namespace VisibleLayer
{
    public partial class Main : Form
    {
        private bool loadKey = false;
        AESCipher aes = new AESCipher();
        public Main()
        {
            InitializeComponent();
        }

        private void btnCipher_Click(object sender, EventArgs e)
        {
            string clearMessage = txtClearMessageCipher.Text.Trim();
            if(clearMessage.Equals(""))
            {
                txtCipherMessageCipher.Text = String.Empty;
                MessageBox.Show("Mensaje en claro vació");                
                return;
            }

            try
            {
                txtCipherMessageCipher.Text = aes.Cipher(clearMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception: " + ex.InnerException +
                    "Message: " + ex.Message);
                txtCipherMessageCipher.Text = string.Empty;
            }
            
        }
        private void btnDecipher_Click(object sender, EventArgs e)
        {

            string cipherMessage = txtCipherMessageDecipher.Text.Trim();

            if (cipherMessage.Equals(""))
            {
                txtClearMessageDecipher.Text = String.Empty;
                MessageBox.Show("Mensaje cifrado vacío");
                return;
            }
            if (!(cipherMessage.Length % 4 == 0) && Regex.IsMatch(cipherMessage, @"^[a-zA-Z0-9\+/]*={0,3}$", RegexOptions.None))
            {
                txtClearMessageDecipher.Text = String.Empty;
                MessageBox.Show("El mensaje cifrado no esta codificado en base64");
                return;
            }

            try
            {
                txtClearMessageDecipher.Text = aes.Decipher(cipherMessage);
            }
            catch (Exception ex)
            {

                MessageBox.Show("Exception: " + ex.GetType()
                    + "\nMessage: " + ex.Message);

                txtClearMessageDecipher.Text = string.Empty;
            }
            
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim().ToUpper();
            if(!Regex.IsMatch(key, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("La llave no esta codificada en formato hexadecimal");
                return;
            }

            if (key.Length != 32 && key.Length != 48 && key.Length != 64 )
            {
                MessageBox.Show("La llave no es de 128, 192 ó 256 bits, no se puede utilizar para efectuar un cifrado AES");
                return;
            }

            aes.SetKey(key);
            loadKey = true;
            btnCipher.Enabled = loadKey;
            btnDecipher.Enabled = loadKey;


            txtKey.Text = BlindKey(key);
            MessageBox.Show("Llave cargada ..");
        }


        private string BlindKey(string key)
        {
            int length = key.Length;
            string aux = key.Substring(length - 3, 3);


            for (int i = 0; i < length-3; i++)
            {
                aux = "*" + aux;
            }
            return aux;
        }

        private void Main_Load(object sender, EventArgs e)
        {
            btnCipher.Enabled = loadKey;
            btnDecipher.Enabled = loadKey;
        }

        private void txtKey_TextChanged(object sender, EventArgs e)
        {
            lblNumCharacteres.Text = "Caracteres: " + txtKey.Text.Trim().Length;
        }

        private void pbShowImage_Click(object sender, EventArgs e)
        {
            txtKey.Text = aes.GetKey();
        }
    }
}
