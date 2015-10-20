using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CertidaoNascimento {
    public partial class FormPrincipal : Form {

        public FormPrincipal() {
            InitializeComponent();
        }

        private void buttonGerar_Click(object sender, EventArgs e) {
            Task.Run(() => {
                ClearText();
                Random random = new Random((int) DateTime.Now.Ticks);
                SortedSet<string> numerosCertidao = new SortedSet<string>();

                int quantidade;
                if (!Int32.TryParse(textBoxQtd.Text, out quantidade)) {
                    InsertText(String.Format("Erro: \"{0}\" não é uma quantidade válida.", textBoxQtd.Text));
                    return;
                }

                while (numerosCertidao.Count() < quantidade) {
                    string numeroCertidao = CertidaoNascimentoHelper.GerarNumeroCertidao(random);
                    numeroCertidao =
                        numeroCertidao.Substring(0, 6) + " " +
                        numeroCertidao.Substring(6, 2) + " " +
                        numeroCertidao.Substring(8, 2) + " " +
                        numeroCertidao.Substring(10, 4) + " " +
                        numeroCertidao.Substring(14, 1) + " " +
                        numeroCertidao.Substring(15, 5) + " " +
                        numeroCertidao.Substring(20, 3) + " " +
                        numeroCertidao.Substring(23, 7) + " " +
                        numeroCertidao.Substring(30, 2);
                    numerosCertidao.Add(numeroCertidao);
                }

                foreach (var numero in numerosCertidao) {
                    InsertText(numero);
                }
            });
        }

        private void ClearText() {
            textBoxCertidoes.Invoke((Action)(() => {
                textBoxCertidoes.Clear();
            }));
        }

        private void InsertText(string text) {
            textBoxCertidoes.Invoke((Action)(() => {
                textBoxCertidoes.AppendText(text + Environment.NewLine);
            }));
        }

        private void buttonValidar_Click(object sender, EventArgs e) {
            string numero = textBoxValidar.Text
                .Replace(" ", "")
                .Replace(".", " ")
                .Replace("-", "");
            try {
                CertidaoNascimentoHelper.Validar(numero);
                MessageBox.Show("Número correto.", "Número Correto!", MessageBoxButtons.OK, MessageBoxIcon.None);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Número Incorreto!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
