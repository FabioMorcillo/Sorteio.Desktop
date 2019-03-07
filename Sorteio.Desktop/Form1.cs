using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Sorteio.Desktop
{
    public partial class FrmSorteio : Form
    {
        private readonly Dictionary<int, int> _numeros = new Dictionary<int, int>();
        private bool _sorteioRealizado = false;
        private bool _wins = false;
        private readonly int _matchCount = 10;
        private readonly int _minCandidates = 3;

        public FrmSorteio()
        {
            InitializeComponent();
        }

        private void TxtNome_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (
                (e.KeyChar != (char)Keys.Return)
                || (String.IsNullOrWhiteSpace(txtNome.Text))
                )
                return;

            e.Handled = true;

            if (ExistsName(txtNome.Text))
            {
                MessageBox.Show("Nome já está participando do sorteio !");

                return;
            }

            listBoxNomes.Items.Add(txtNome.Text);

            ClearAndFocus();

            TryEnableLottery();
        }

        private void TryEnableLottery()
        {
            btnSortear.Enabled = listBoxNomes.Items.Count >= _minCandidates;
        }

        private void FrmSorteio_Shown(object sender, EventArgs e)
        {
            ClearAndFocus();

            SetImagesDisabled();

            LoadImagesDisabled();
        }

        private void ClearAndFocus()
        {
            txtNome.Text = String.Empty;
            txtNome.Focus();
        }

        private Boolean ExistsName(string name)
        {
            return listBoxNomes.Items.Contains(name);
        }

        private void ListBoxNomes_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                if (listBoxNomes.SelectedItem != null)
                {
                    listBoxNomes.Items.Remove(listBoxNomes.SelectedItem);
                }
            }
        }

        private void SetImagesDisabled()
        {
            pictureBoxNome1.Image = Bitmap.FromFile("ddddisabled.png");
            pictureBoxNome2.Image = Bitmap.FromFile("ddddisabled.png");
            pictureBoxNome3.Image = Bitmap.FromFile("ddddisabled.png");
        }

        private void LoadImagesDisabled()
        {
            pictureBoxNumber1.Image = Bitmap.FromFile("1disabled.png");
            pictureBoxNumber2.Image = Bitmap.FromFile("2disabled.png");
            pictureBoxNumber3.Image = Bitmap.FromFile("3disabled.png");
        }

        private void BtnSortear_Click(object sender, EventArgs e)
        {
            InicializarVariaveis();
            InicializarDicionario();

            var quantidadeParticipantes = listBoxNomes.Items.Count;

            var random = new Random();

            while (!PossuiGanhadores())
            {
                var numero = random.Next(0, quantidadeParticipantes);

                IncrementarNumero(numero);
            }

            _sorteioRealizado = true;

            MessageBox.Show("Candidatos sorteados !");
        }

        private void InicializarVariaveis()
        {
            _sorteioRealizado = false;
            _wins = false;
        }

        private void IncrementarNumero(int numero)
        {
            if (!_numeros.ContainsKey(numero))
                return;

            if (_numeros[numero] < _matchCount)
            {
                _numeros[numero] += 1;

                HabilitarSorteado(numero);
            }
        }

        private void HabilitarSorteado(int numero)
        {
            if (_numeros[numero] == _matchCount)
            {
                var posicaoAtual = GetCandidateCount();

                var pictureBox = (PictureBox)Controls.Find($"PictureBoxNome{posicaoAtual}", true)[0];
                var label = (Label)Controls.Find($"LabelNome{posicaoAtual}", true)[0];

                pictureBox.Image = Bitmap.FromFile("dddenabled.png");
                label.Text = listBoxNomes.Items[numero].ToString();
            }
        }

        private int GetCandidateCount() {
            return _numeros
                .Where(n => n.Value == _matchCount)
                .Count();
        }

        private Boolean PossuiGanhadores()
        {
            return GetCandidateCount() == _minCandidates;
        }

        private void InicializarDicionario()
        {
            _numeros.Clear();

            for (var i = 0; i < listBoxNomes.Items.Count; i++)
            {
                _numeros.Add(i, 0);
            }
        }

        private void Candidato_Click(object sender, EventArgs e)
        {
            if (!_sorteioRealizado)
                return;

            var selectedNumber = ((Control)sender).Tag;

            var pictureBox = (PictureBox)Controls.Find($"PictureBoxNome{selectedNumber}", true)[0];

            pictureBox.Visible = false;

            if (!_wins)
            {
                var pictureBoxNumber = (PictureBox)Controls.Find($"PictureBoxNumber{selectedNumber}", true)[0];

                pictureBoxNumber.Image = Bitmap.FromFile(selectedNumber.ToString() + ".png");
            }

            _wins = true;
        }
    }
}
