using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace AppClases.ViewModels
{
    public class LoginViewModel
    {
        #region Propiedades
        public string Email { get; set; }
        public string Contrasena { get; set; }
        public bool IsRunnig { get; set; }
        public bool Recordado { get; set; }
        #endregion


        
        #region constructor

        public LoginViewModel()
        {
           this.Recordado = true;

        }
        #endregion

        #region Command
        public ICommand LoginCommand { get; set; }
        #endregion

    }

}
