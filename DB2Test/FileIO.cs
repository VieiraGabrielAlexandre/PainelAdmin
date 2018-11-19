using System;
using System.IO;
using System.Windows;
using System.Windows.Forms;
using DB2Test;

namespace Painel
{
    class FileIO
    {
        Rules rules; // Vamos usar as mesmas configurações em todos lugares
        String pathToFile { get; set; } // caminho para o arquivo 
        String[] lines; // string contendo a lista de materiais
        AutoCompleteStringCollection materialList;

        FileIO(String pathToFile, Rules rules)
        {
            this.pathToFile = pathToFile;
            this.rules = rules;

            try
            {
                lines = File.ReadAllLines(pathToFile);
            }catch(FileNotFoundException e)
            {
                rules.ErrorMessage("Arquivo não encontrado " + pathToFile + "\n"+e.ToString(), "Arquivo não encontrado");
            }
        }
    }
}
;
