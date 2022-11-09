using System;
using Reproductor;
using System.Windows.Forms;
using Usuarios;

namespace ReproductorDeMusica
{
    public partial class FormIngreso : Form
    {
        private string usuario;
        private string password;
        private Coleccion cUsuarios;
      //  private Usuario Usuario;

        public FormIngreso()
        {
            InitializeComponent();
            cUsuarios = new Coleccion();
        //    Usuario = new Usuario();
        //  Usuario.NomUsuario = "";
        //  Usuario.Password = "";
            
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {

            Valida();

        }

        private void txtbContra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if( e.KeyChar == (char)Keys.Enter  )
            {
                Valida();
            }
            
        }

        public void Valida()
        {
            string usuario = txtbUsuario.Text;
            string password = txtbContra.Text;

            //    txtbUsuario.Text = Usuario.NomUsuario;
            //   txtbContra.Text = Usuario.Password;

            for (int i = 0; i < 2; i++)
            {
                Usuario miUsuario = new Usuario();
                miUsuario =(Usuario)cUsuarios.usuarios[i];
                this.usuario = miUsuario.NomUsuario;
                this.password = miUsuario.Password;


                if (this.usuario == usuario && this.password == password)
                {
                    //  MessageBox.Show("Ingreso Exitoso");
                  /*  FormReproductor formReproductor = new FormReproductor();
                    formReproductor.Show();
                  */
                    FormListaMusica formListaMusica = new FormListaMusica();
                    formListaMusica.Show();
                    break;
                }
                if( i== 1  )
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto  ");
                }
            }
        }
    }
}
