using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Controle.Emprestimo
{
    public static class CardLivroEmp
    {
        /// <summary>
        /// Cria um painel (card) visual para exibir informações de um livro.
        /// </summary>
        /// <param name="livro">Objeto Livro com os dados a serem exibidos.</param>
        /// <param name="largura">Largura do card.</param>
        /// <param name="altura">Altura do card.</param>
        /// <returns>Painel preenchido com capa, título e autor do livro.</returns>
        public static Panel CriarCard(Livro livro, int largura = 220, int altura = 280)
        {
            // Painel principal do card
            Panel card = new Panel
            {
                Width = largura,
                Height = altura,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(78, 52, 46)
            };

            int margem = 10;

            // PictureBox para exibir a capa do livro
            PictureBox picCapa = new PictureBox
            {
                Left = margem,
                Top = margem,
                Width = largura - 2 * margem,
                Height = 250,
                SizeMode = PictureBoxSizeMode.Zoom,
                BackColor = Color.FromArgb(107, 74, 68)
            };

            // Carrega a imagem da capa do livro, se disponível
            if (!string.IsNullOrEmpty(livro.CaminhoCapa))
            {
                try
                {
                    if (livro.CaminhoCapa.StartsWith("http"))
                    {
                        // Baixa a imagem da internet
                        using (var client = new System.Net.WebClient())
                        {
                            using (var stream = client.OpenRead(livro.CaminhoCapa))
                            {
                                picCapa.Image = Image.FromStream(stream);
                            }
                        }
                    }
                    else if (System.IO.File.Exists(livro.CaminhoCapa))
                    {
                        // Carrega a imagem de um arquivo local
                        picCapa.Image = Image.FromFile(livro.CaminhoCapa);
                    }
                }
                catch
                {
                    // Se houver erro, não exibe imagem
                    picCapa.Image = null;
                }
            }            

            // Adiciona os controles ao painel principal
            card.Controls.Add(picCapa);            

            return card;
        }
    }
}
