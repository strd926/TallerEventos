using TallerEventos.Clases;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace TallerEventos
{
    public partial class controlTareas : Form
    {
        List<Tarea> tareas = new List<Tarea>();
        public controlTareas()
        {
            InitializeComponent();
            textBoxTarea.KeyDown += TextBoxTarea_KeyDown; 
            //Keydown funciona cada vez que se presiona la tecla
            //Defino enter abajo que sera la tecla que inicia el evento
        }

        private void TextBoxTarea_KeyDown(object? sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                agregarTarea();
            }
        }

        private void agregarTarea()
        {
            if (textBoxTarea.Text.Trim() == "")
            {
                MessageBox.Show("No ha ingresado un nombre para la tarea");
                return;
          
            }

            Tarea nuevaTarea = new Tarea(textBoxTarea.Text, "Sin Empezar");
            tareas.Add(nuevaTarea);

            agregarTareaAlFlowPanel(nuevaTarea, flowSinEmpezar);
            textBoxTarea.Clear();
        }

        private void agregarTareaAlFlowPanel(Tarea tarea, FlowLayoutPanel panel)
        {
            Label etiquetaTarea = new Label
            {
                Text = tarea.Nombre,
                AutoSize = true,
                Tag = tarea
            };

            etiquetaTarea.DoubleClick += (s, e) => 
            //s(sender) representa el evento, e es el dato del evento
            //+= es para suscribir el metodo al evento (dobleclick)
            //=> Lambda, define las funciones en linea como parametro
            {
                tareas.Remove(tarea);
                flowSinEmpezar.Controls.Remove(etiquetaTarea);
                flowEnProgreso.Controls.Remove(etiquetaTarea);
                flowCompletadas.Controls.Remove(etiquetaTarea);
            };

            etiquetaTarea.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Right)
                {
                   ContextMenuStrip menu = new ContextMenuStrip(); //crea un menu con click derecho
              
            //menu.Items.add(agrega opcion al menu) null se usa para mostar un item junto a la opcion del menu
                   menu.Items.Add("Sin Empezar", null, (s, e) => CambiarEstadoTarea(tarea, "Sin Empezar", etiquetaTarea));
                   menu.Items.Add("En Progreso", null, (s, e) => CambiarEstadoTarea(tarea, "En Progreso", etiquetaTarea));
                   menu.Items.Add("Completada", null, (s, e) => CambiarEstadoTarea(tarea, "Completada", etiquetaTarea));
                   menu.Show(etiquetaTarea, e.Location);
                    //menu show muestra el menu en la pantalla, e.location mostrara el menu donde este el click
               }
           };
            panel.Controls.Add(etiquetaTarea);
        }
        private void CambiarEstadoTarea(Tarea tarea, string nuevoEstado, Label etiqueta)
        {
            //flowLayoutPanel? se refiere a que podria no referirse a un objeto valido, panelanterior es donde se encuentra la tarea
            FlowLayoutPanel? panelAnterior = etiqueta.Parent as FlowLayoutPanel; //uso .parent para devolver la propiedad inmediata de un control, osea la tarea
            //as FlowLaout... convierte etiqueta.parent para que sea asignada al panel
            if (panelAnterior != null) 
            {
                panelAnterior.Controls.Remove(etiqueta); //Para eliminar el label de donde estaba
            }

            tarea.Estado = nuevoEstado;

            //metodo swich para que la tarea pueda regresar o avanzar
            switch (nuevoEstado)
            {
                case "Sin Empezar":
                    flowSinEmpezar.Controls.Add(etiqueta);
                    break;
                case "En Progreso":
                    flowEnProgreso.Controls.Add(etiqueta);
                    break;
                case "Completada":
                    flowCompletadas.Controls.Add(etiqueta);
                    break;

            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void textBoxTarea_TextChanged(object sender, EventArgs e)
        {

        }
        private void flowPanel_Paint(object sender, PaintEventArgs e)
        {
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void flowEnProgreso_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBoxEstado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
