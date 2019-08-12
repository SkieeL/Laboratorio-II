using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using Entidades;

namespace Formulario
{
    public partial class frmFinal : Form
    {
        private MEspecialista _medicoEspecialista;
        private MGeneral _medicoGeneral;
        private Thread _mocker;
        private Queue<Paciente> _pacientesEnEspera;

        public frmFinal() {
            InitializeComponent();

            this._medicoEspecialista = new MEspecialista("Jorge", "Iglesias", MEspecialista.Especialidad.Traumatologo);
            this._medicoGeneral = new MGeneral("Luis", "Salinas");
            this._pacientesEnEspera = new Queue<Paciente>();
        }

        private void frmFinal_Load(object sender, EventArgs e) {
            this._mocker = new Thread(MockPacientes);
        }

        private void frmFinal_FormClosing(object sender, FormClosingEventArgs e) {
            if (this._mocker.IsAlive)
                this._mocker.Abort();
        }

        private void btnGeneral_Click(object sender, EventArgs e) {
            this.AtenderPacientes(this._medicoGeneral);
        }

        private void btnEspecialista_Click(object sender, EventArgs e) {
            this.AtenderPacientes(this._medicoEspecialista);
        }

        private void MockPacientes() {
            Thread.Sleep(5000);
            Paciente pacientito = new Paciente("Ezequiel", "Mahafud");
            this._pacientesEnEspera.Enqueue(pacientito);
        }

        private void AtenderPacientes(IMedico iMedico) {
            if (this._pacientesEnEspera.Count > 0) {
                if (((Medico)iMedico).EstaAtendiendoA == null)
                    ((Medico)iMedico).AtenderA = this._pacientesEnEspera.Dequeue();
            }  
        }

        private void FinAtencion(Paciente p, Medico m) {
            StringBuilder mensaje = new StringBuilder();

            mensaje.AppendFormat("Finalizó la atención de {0} por el doctor {1}!", p.ToString(), m.ToString());

            this.txtBox.Text = mensaje.ToString();
        }
    }
}
