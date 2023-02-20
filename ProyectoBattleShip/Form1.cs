using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoBattleShip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();


            // Tamaño y espaciado de los botones
            int buttonSize = 40;
            int spacing = 10;

            // Número de filas y columnas de botones
            int rows = 9;
            int cols = 9;

            //Crear panel que contiene a los botones
            Panel board = new Panel();
            this.Controls.Add(board);
            board.Location = new Point(50, 50);
            board.Size = new Size((buttonSize + spacing)*rows, (buttonSize + cols) * rows);
            board.BorderStyle = BorderStyle.Fixed3D;

            //columnas

            // Crear y agregar los botones al formulario
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Crear un nuevo botón
                    Button button = new Button();

                    // Establecer el ID del botón
                    char colsLetter = (char)('A' + j);
                    button.Name = colsLetter.ToString() + i.ToString();

                    // Establecer la ubicación y el tamaño del botón
                    button.Location = new Point(j * (buttonSize + spacing), i * (buttonSize + spacing));
                    button.Size = new Size(buttonSize, buttonSize);

                    // Agregar el evento Click al botón
                    button.Click += new EventHandler(button_Click);

                    //Agregar el botón creado al tablero
                    board.Controls.Add(button);
                }
            }            
        }

        // Evento Click para los botones
        private void button_Click(object sender, EventArgs e)
        {
            // Obtener el botón que ha sido pulsado
            Button button = sender as Button;

            // Hacer algo con el botón pulsado
            // ...
            button.Text = button.Name;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
    }
}
