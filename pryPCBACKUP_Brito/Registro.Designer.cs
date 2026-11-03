namespace pryPCBACKUP_Brito
{
    partial class Registro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro));
            lblNombre = new Label();
            lblApellido = new Label();
            lblNumero = new Label();
            lblMail = new Label();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtNumero = new TextBox();
            groupBox1 = new GroupBox();
            mtxtMail = new MaskedTextBox();
            gboEquipo = new GroupBox();
            dtpFecha = new DateTimePicker();
            cboTipo = new ComboBox();
            txtPresupuesto = new TextBox();
            lblPresupuesto = new Label();
            txtModelo = new TextBox();
            lblModelo = new Label();
            txtNSerie = new TextBox();
            lblNSerie = new Label();
            txtFalla = new TextBox();
            lblTipo = new Label();
            txtMarca = new TextBox();
            lblMarca = new Label();
            lblFalla = new Label();
            btnRegistrar = new Button();
            tcoRegistro = new TabControl();
            tabPage1 = new TabPage();
            tabPage2 = new TabPage();
            groupBox1.SuspendLayout();
            gboEquipo.SuspendLayout();
            tcoRegistro.SuspendLayout();
            tabPage1.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombre
            // 
            resources.ApplyResources(lblNombre, "lblNombre");
            lblNombre.Name = "lblNombre";
            // 
            // lblApellido
            // 
            resources.ApplyResources(lblApellido, "lblApellido");
            lblApellido.Name = "lblApellido";
            // 
            // lblNumero
            // 
            resources.ApplyResources(lblNumero, "lblNumero");
            lblNumero.Name = "lblNumero";
            // 
            // lblMail
            // 
            resources.ApplyResources(lblMail, "lblMail");
            lblMail.Name = "lblMail";
            // 
            // txtNombre
            // 
            resources.ApplyResources(txtNombre, "txtNombre");
            txtNombre.Name = "txtNombre";
            // 
            // txtApellido
            // 
            resources.ApplyResources(txtApellido, "txtApellido");
            txtApellido.Name = "txtApellido";
            // 
            // txtNumero
            // 
            resources.ApplyResources(txtNumero, "txtNumero");
            txtNumero.Name = "txtNumero";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(mtxtMail);
            groupBox1.Controls.Add(txtNombre);
            groupBox1.Controls.Add(lblNombre);
            groupBox1.Controls.Add(txtNumero);
            groupBox1.Controls.Add(lblApellido);
            groupBox1.Controls.Add(txtApellido);
            groupBox1.Controls.Add(lblNumero);
            groupBox1.Controls.Add(lblMail);
            groupBox1.ForeColor = SystemColors.WindowText;
            resources.ApplyResources(groupBox1, "groupBox1");
            groupBox1.Name = "groupBox1";
            groupBox1.TabStop = false;
            groupBox1.Enter += groupBox1_Enter;
            // 
            // mtxtMail
            // 
            resources.ApplyResources(mtxtMail, "mtxtMail");
            mtxtMail.Name = "mtxtMail";
            // 
            // gboEquipo
            // 
            gboEquipo.Controls.Add(dtpFecha);
            gboEquipo.Controls.Add(cboTipo);
            gboEquipo.Controls.Add(txtPresupuesto);
            gboEquipo.Controls.Add(lblPresupuesto);
            gboEquipo.Controls.Add(txtModelo);
            gboEquipo.Controls.Add(lblModelo);
            gboEquipo.Controls.Add(txtNSerie);
            gboEquipo.Controls.Add(lblNSerie);
            gboEquipo.Controls.Add(txtFalla);
            gboEquipo.Controls.Add(lblTipo);
            gboEquipo.Controls.Add(txtMarca);
            gboEquipo.Controls.Add(lblMarca);
            gboEquipo.Controls.Add(lblFalla);
            gboEquipo.ForeColor = SystemColors.WindowText;
            resources.ApplyResources(gboEquipo, "gboEquipo");
            gboEquipo.Name = "gboEquipo";
            gboEquipo.TabStop = false;
            gboEquipo.Enter += gboEquipo_Enter;
            // 
            // dtpFecha
            // 
            dtpFecha.Format = DateTimePickerFormat.Short;
            resources.ApplyResources(dtpFecha, "dtpFecha");
            dtpFecha.Name = "dtpFecha";
            // 
            // cboTipo
            // 
            cboTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipo.FormattingEnabled = true;
            cboTipo.Items.AddRange(new object[] { resources.GetString("cboTipo.Items"), resources.GetString("cboTipo.Items1") });
            resources.ApplyResources(cboTipo, "cboTipo");
            cboTipo.Name = "cboTipo";
            // 
            // txtPresupuesto
            // 
            resources.ApplyResources(txtPresupuesto, "txtPresupuesto");
            txtPresupuesto.Name = "txtPresupuesto";
            // 
            // lblPresupuesto
            // 
            resources.ApplyResources(lblPresupuesto, "lblPresupuesto");
            lblPresupuesto.Name = "lblPresupuesto";
            // 
            // txtModelo
            // 
            resources.ApplyResources(txtModelo, "txtModelo");
            txtModelo.Name = "txtModelo";
            // 
            // lblModelo
            // 
            resources.ApplyResources(lblModelo, "lblModelo");
            lblModelo.Name = "lblModelo";
            // 
            // txtNSerie
            // 
            resources.ApplyResources(txtNSerie, "txtNSerie");
            txtNSerie.Name = "txtNSerie";
            // 
            // lblNSerie
            // 
            resources.ApplyResources(lblNSerie, "lblNSerie");
            lblNSerie.Name = "lblNSerie";
            // 
            // txtFalla
            // 
            resources.ApplyResources(txtFalla, "txtFalla");
            txtFalla.Name = "txtFalla";
            // 
            // lblTipo
            // 
            resources.ApplyResources(lblTipo, "lblTipo");
            lblTipo.Name = "lblTipo";
            // 
            // txtMarca
            // 
            resources.ApplyResources(txtMarca, "txtMarca");
            txtMarca.Name = "txtMarca";
            // 
            // lblMarca
            // 
            resources.ApplyResources(lblMarca, "lblMarca");
            lblMarca.Name = "lblMarca";
            // 
            // lblFalla
            // 
            resources.ApplyResources(lblFalla, "lblFalla");
            lblFalla.Name = "lblFalla";
            // 
            // btnRegistrar
            // 
            resources.ApplyResources(btnRegistrar, "btnRegistrar");
            btnRegistrar.Name = "btnRegistrar";
            btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // tcoRegistro
            // 
            tcoRegistro.Controls.Add(tabPage1);
            tcoRegistro.Controls.Add(tabPage2);
            resources.ApplyResources(tcoRegistro, "tcoRegistro");
            tcoRegistro.Name = "tcoRegistro";
            tcoRegistro.SelectedIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(groupBox1);
            tabPage1.Controls.Add(btnRegistrar);
            tabPage1.Controls.Add(gboEquipo);
            resources.ApplyResources(tabPage1, "tabPage1");
            tabPage1.Name = "tabPage1";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            resources.ApplyResources(tabPage2, "tabPage2");
            tabPage2.Name = "tabPage2";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // Registro
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(tcoRegistro);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            MaximizeBox = false;
            Name = "Registro";
            Load += Registro_Load;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            gboEquipo.ResumeLayout(false);
            gboEquipo.PerformLayout();
            tcoRegistro.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label lblNombre;
        private Label lblApellido;
        private Label lblNumero;
        private Label lblMail;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtNumero;
        private GroupBox groupBox1;
        private GroupBox gboEquipo;
        private Label lblTipo;
        private TextBox txtMarca;
        private Label lblMarca;
        private Label lblFalla;
        private TextBox txtFalla;
        private Button btnRegistrar;
        private MaskedTextBox mtxtMail;
        private TextBox txtModelo;
        private Label lblModelo;
        private TextBox txtNSerie;
        private Label lblNSerie;
        private TabControl tcoRegistro;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TextBox txtPresupuesto;
        private Label lblPresupuesto;
        private DateTimePicker dtpFecha;
        private ComboBox cboTipo;
    }
}