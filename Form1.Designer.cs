namespace TallerEventos
{
    partial class controlTareas
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            textBoxTarea = new TextBox();
            flowSinEmpezar = new FlowLayoutPanel();
            flowEnProgreso = new FlowLayoutPanel();
            flowCompletadas = new FlowLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // textBoxTarea
            // 
            textBoxTarea.BackColor = SystemColors.HighlightText;
            textBoxTarea.Location = new Point(195, 41);
            textBoxTarea.Name = "textBoxTarea";
            textBoxTarea.Size = new Size(418, 27);
            textBoxTarea.TabIndex = 0;
            textBoxTarea.Text = "Ingrese su Tarea";
            textBoxTarea.TextAlign = HorizontalAlignment.Center;
            textBoxTarea.TextChanged += textBoxTarea_TextChanged;
            // 
            // flowSinEmpezar
            // 
            flowSinEmpezar.BorderStyle = BorderStyle.Fixed3D;
            flowSinEmpezar.FlowDirection = FlowDirection.TopDown;
            flowSinEmpezar.Location = new Point(103, 127);
            flowSinEmpezar.Name = "flowSinEmpezar";
            flowSinEmpezar.Size = new Size(187, 297);
            flowSinEmpezar.TabIndex = 2;
            flowSinEmpezar.Paint += flowPanel_Paint;
            // 
            // flowEnProgreso
            // 
            flowEnProgreso.BorderStyle = BorderStyle.Fixed3D;
            flowEnProgreso.FlowDirection = FlowDirection.TopDown;
            flowEnProgreso.Location = new Point(296, 127);
            flowEnProgreso.Name = "flowEnProgreso";
            flowEnProgreso.Size = new Size(187, 297);
            flowEnProgreso.TabIndex = 3;
            flowEnProgreso.Paint += flowEnProgreso_Paint;
            // 
            // flowCompletadas
            // 
            flowCompletadas.BorderStyle = BorderStyle.Fixed3D;
            flowCompletadas.FlowDirection = FlowDirection.TopDown;
            flowCompletadas.Location = new Point(489, 127);
            flowCompletadas.Name = "flowCompletadas";
            flowCompletadas.Size = new Size(187, 297);
            flowCompletadas.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(146, 95);
            label1.Name = "label1";
            label1.Size = new Size(74, 20);
            label1.TabIndex = 5;
            label1.Text = "Pendiente";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 95);
            label2.Name = "label2";
            label2.Size = new Size(88, 20);
            label2.TabIndex = 6;
            label2.Text = "En Progreso";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(526, 95);
            label3.Name = "label3";
            label3.Size = new Size(97, 20);
            label3.TabIndex = 7;
            label3.Text = "Completadas";
            // 
            // controlTareas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(flowCompletadas);
            Controls.Add(flowEnProgreso);
            Controls.Add(flowSinEmpezar);
            Controls.Add(textBoxTarea);
            Name = "controlTareas";
            Text = "controlTareas";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTarea;
        private FlowLayoutPanel flowSinEmpezar;
        private FlowLayoutPanel flowEnProgreso;
        private FlowLayoutPanel flowCompletadas;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}
