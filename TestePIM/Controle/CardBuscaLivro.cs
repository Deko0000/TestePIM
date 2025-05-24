using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestePIM.Controle
{
    public static class CardBuscaLivro
    {        
        public static Panel CriarCard(Livro livro, EventHandler verMaisHandler, int largura = 185, int altura = 325)
        {
            Panel card = new Panel
            {
                Width = largura,
                Height = altura,
                BorderStyle = BorderStyle.FixedSingle,
                BackColor = Color.FromArgb(78, 52, 46)
            };

            int margemInterna = 10;


            // PictureBox para capa
            PictureBox picCapa = new PictureBox
            {
                Left = margemInterna,
                Top = margemInterna,
                Width = largura - 2 * margemInterna,
                Height = 200,
                SizeMode = PictureBoxSizeMode.Zoom,
                BorderStyle = BorderStyle.None,
                BackColor = Color.FromArgb(107, 74, 68)
            };

            if (!string.IsNullOrEmpty(livro.CaminhoCapa))
            {
                if (livro.CaminhoCapa.StartsWith("http"))
                {
                    try
                    {
                        using (var client = new System.Net.WebClient())
                        {
                            using (var stream = client.OpenRead(livro.CaminhoCapa))
                            {
                                picCapa.Image = Image.FromStream(stream);
                            }
                        }
                    }
                    catch
                    {
                        picCapa.Image = null;
                    }
                }
                else if (System.IO.File.Exists(livro.CaminhoCapa))
                {
                    try
                    {
                        picCapa.Image = Image.FromFile(livro.CaminhoCapa);
                    }
                    catch
                    {
                        picCapa.Image = null;
                    }
                }
            }

            // Título
            Label lblTitulo = new Label
            {
                Text = livro.Titulo,
                Top = picCapa.Bottom + 5,
                Left = margemInterna,
                Width = largura - 2 * margemInterna,
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                AutoEllipsis = true,
                ForeColor = Color.FromArgb(255, 253, 250)
            };

            // Autor
            Label lblAutor = new Label
            {
                Text = "Autor: " + livro.Autor,
                Top = lblTitulo.Bottom + 5,
                Left = margemInterna,
                Width = largura - 2 * margemInterna,
                Font = new Font("Segoe UI", 8, FontStyle.Regular),
                AutoEllipsis = true,
                ForeColor = Color.FromArgb(255, 253, 250)
            };

            // Botão Ver mais
            Button btnVerMais = new Button
            {
                Text = "Ver mais",
                Top = lblAutor.Bottom + 10,
                Left = margemInterna,
                Width = largura - 2 * margemInterna,
                Height = 30,
                Tag = livro,
                FlatStyle = FlatStyle.Flat,
                BackColor = Color.FromArgb(255, 253, 250),
                Font = new Font("Segoe UI", 10, FontStyle.Bold),
                ForeColor = Color.FromArgb(78, 52, 46)
            };

            btnVerMais.Click += verMaisHandler;

            // Adiciona ao card
            card.Controls.Add(picCapa);
            card.Controls.Add(lblTitulo);
            card.Controls.Add(lblAutor);
            card.Controls.Add(btnVerMais);

            return card;
        }
    }
}
