using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolNET
{
    public class LembrarDeMim
    {
        public void Salvar(string usuario, string senha, bool lembrar)
        {
            Properties.Settings.Default.Usuario = usuario;
            Properties.Settings.Default.Senha = senha;
            Properties.Settings.Default.LembrarMim = lembrar;
        }

        public void Excluir()
        {
            Properties.Settings.Default.Usuario = string.Empty;
            Properties.Settings.Default.Senha = string.Empty;
            Properties.Settings.Default.LembrarMim = false;
        }
    }
}
