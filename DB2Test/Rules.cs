using System;
using System.ComponentModel;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace DB2Test
{
    public class Rules
    {
        public bool isAutoCompleteProduct { get; set; } = false;
        public bool isConnected { get; set; }
        /*
         * 
         * Aciona a ação de um botão caso uma tecla do teclado for pressionado em outro componente
         * Ex: Ao pressionar enter em um TEXTBOX ativa um BUTTON
         * 
         */
        public void PressButton(Button btnHasBePressed, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.Return:
                    btnHasBePressed.PerformClick();
                    break;
            }
        }
        /*
         * 
         * Verifica se o campo informado está preenchido
         * Recebe o textBox e a string para formatar o texto de erro. Também recebe o ultimo argumento para determinar o erro.
         * 
         */
        public bool VerificarCampos(MetroTextBox verificarTxt, String verificarStr, String verificarArg)
        {
            if (verificarTxt.Text.Length <= 0)
            {
                MessageBox.Show("Você deve especificar " + verificarStr + " para " + verificarArg + ".",
                    "Campo invalido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /*
         * 
         * Simples mensagem de erro
         * 
         */

        public void ErrorMessage(String msg, String title)
        {
            MessageBox.Show(msg, title, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
