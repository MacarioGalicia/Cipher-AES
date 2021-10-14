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

            txtCipherMessageCipher.Text = aes.Cipher(clearMessage);
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

            txtClearMessageDecipher.Text = aes.Decipher(cipherMessage);
        }

        private void btnSetKey_Click(object sender, EventArgs e)
        {
            string key = txtKey.Text.Trim().ToUpper();
            if(!Regex.IsMatch(key, @"\A\b[0-9a-fA-F]+\b\Z"))
            {
                MessageBox.Show("La llave no esta codificada en formato hexadecimal");
                return;
            }

            if (key.Length != 64 && key.Length != 32)
            {
                MessageBox.Show("La llave no es de 128 ó 256 bits, no se puede utilizar para efectuar un cifrado AES");
                return;
            }

            aes.SetKey(key);
            loadKey = true;
            btnCipher.Enabled = loadKey;
            btnDecipher.Enabled = loadKey;
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
        
    }
}
