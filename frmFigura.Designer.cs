
namespace simpleCRUD
{
    partial class frmFigura
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.button1 = new System.Windows.Forms.Button();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.txtAngulos = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.txtNombre = new MetroFramework.Controls.MetroTextBox();
            this.txtId = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.lblId = new MetroFramework.Controls.MetroLabel();
            this.btnSalir = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.lNew = new MetroFramework.Controls.MetroLink();
            this.dtgFigura = new System.Windows.Forms.DataGridView();
            this.actions = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.edit = new System.Windows.Forms.ToolStripMenuItem();
            this.delete = new System.Windows.Forms.ToolStripMenuItem();
            this.btnCancelar = new MetroFramework.Controls.MetroButton();
            this.btnGuardar = new MetroFramework.Controls.MetroButton();
            this.tabs = new MetroFramework.Controls.MetroTabControl();
            this.tabForm = new MetroFramework.Controls.MetroTabPage();
            this.txtLados = new MetroFramework.Controls.MetroTextBox();
            this.tabData = new MetroFramework.Controls.MetroTabPage();
            ((System.ComponentModel.ISupportInitialize)(this.dtgFigura)).BeginInit();
            this.actions.SuspendLayout();
            this.tabs.SuspendLayout();
            this.tabForm.SuspendLayout();
            this.tabData.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1289, 799);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Test";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Visible = false;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(83, 165);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(43, 19);
            this.metroLabel4.TabIndex = 20;
            this.metroLabel4.Text = "Lados";
            // 
            // txtAngulos
            // 
            // 
            // 
            // 
            this.txtAngulos.CustomButton.Image = null;
            this.txtAngulos.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtAngulos.CustomButton.Name = "";
            this.txtAngulos.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtAngulos.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtAngulos.CustomButton.TabIndex = 1;
            this.txtAngulos.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtAngulos.CustomButton.UseSelectable = true;
            this.txtAngulos.CustomButton.Visible = false;
            this.txtAngulos.Lines = new string[0];
            this.txtAngulos.Location = new System.Drawing.Point(210, 115);
            this.txtAngulos.MaxLength = 32767;
            this.txtAngulos.Name = "txtAngulos";
            this.txtAngulos.PasswordChar = '\0';
            this.txtAngulos.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtAngulos.SelectedText = "";
            this.txtAngulos.SelectionLength = 0;
            this.txtAngulos.SelectionStart = 0;
            this.txtAngulos.ShortcutsEnabled = true;
            this.txtAngulos.Size = new System.Drawing.Size(303, 23);
            this.txtAngulos.TabIndex = 19;
            this.txtAngulos.UseSelectable = true;
            this.txtAngulos.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtAngulos.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel3.Location = new System.Drawing.Point(83, 115);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(53, 19);
            this.metroLabel3.TabIndex = 18;
            this.metroLabel3.Text = "Angulo";
            // 
            // txtNombre
            // 
            // 
            // 
            // 
            this.txtNombre.CustomButton.Image = null;
            this.txtNombre.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtNombre.CustomButton.Name = "";
            this.txtNombre.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNombre.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNombre.CustomButton.TabIndex = 1;
            this.txtNombre.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNombre.CustomButton.UseSelectable = true;
            this.txtNombre.CustomButton.Visible = false;
            this.txtNombre.Lines = new string[0];
            this.txtNombre.Location = new System.Drawing.Point(210, 69);
            this.txtNombre.MaxLength = 32767;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.PasswordChar = '\0';
            this.txtNombre.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNombre.SelectedText = "";
            this.txtNombre.SelectionLength = 0;
            this.txtNombre.SelectionStart = 0;
            this.txtNombre.ShortcutsEnabled = true;
            this.txtNombre.Size = new System.Drawing.Size(303, 23);
            this.txtNombre.TabIndex = 17;
            this.txtNombre.UseSelectable = true;
            this.txtNombre.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNombre.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtId
            // 
            // 
            // 
            // 
            this.txtId.CustomButton.Image = null;
            this.txtId.CustomButton.Location = new System.Drawing.Point(79, 1);
            this.txtId.CustomButton.Name = "";
            this.txtId.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtId.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtId.CustomButton.TabIndex = 1;
            this.txtId.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtId.CustomButton.UseSelectable = true;
            this.txtId.CustomButton.Visible = false;
            this.txtId.Lines = new string[0];
            this.txtId.Location = new System.Drawing.Point(210, 25);
            this.txtId.MaxLength = 32767;
            this.txtId.Name = "txtId";
            this.txtId.PasswordChar = '\0';
            this.txtId.ReadOnly = true;
            this.txtId.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtId.SelectedText = "";
            this.txtId.SelectionLength = 0;
            this.txtId.SelectionStart = 0;
            this.txtId.ShortcutsEnabled = true;
            this.txtId.Size = new System.Drawing.Size(101, 23);
            this.txtId.TabIndex = 16;
            this.txtId.UseSelectable = true;
            this.txtId.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtId.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(83, 69);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(59, 19);
            this.metroLabel2.TabIndex = 15;
            this.metroLabel2.Text = "Nombre";
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(83, 25);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(61, 19);
            this.lblId.TabIndex = 14;
            this.lblId.Text = "Figura Id";
            // 
            // btnSalir
            // 
            this.btnSalir.BackColor = System.Drawing.Color.Firebrick;
            this.btnSalir.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnSalir.ForeColor = System.Drawing.Color.White;
            this.btnSalir.Location = new System.Drawing.Point(507, 451);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(112, 28);
            this.btnSalir.Style = MetroFramework.MetroColorStyle.White;
            this.btnSalir.TabIndex = 27;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseCustomBackColor = true;
            this.btnSalir.UseSelectable = true;
            this.btnSalir.UseStyleColors = true;
            this.btnSalir.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.BackColor = System.Drawing.Color.Transparent;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(377, 27);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(78, 25);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroLabel1.TabIndex = 28;
            this.metroLabel1.Text = "FIGURA";
            // 
            // lNew
            // 
            this.lNew.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lNew.Location = new System.Drawing.Point(487, 27);
            this.lNew.Name = "lNew";
            this.lNew.Size = new System.Drawing.Size(75, 23);
            this.lNew.TabIndex = 29;
            this.lNew.Text = "| new figura";
            this.lNew.UseSelectable = true;
            this.lNew.Click += new System.EventHandler(this.lNew_Click);
            // 
            // dtgFigura
            // 
            this.dtgFigura.AllowUserToAddRows = false;
            this.dtgFigura.AllowUserToDeleteRows = false;
            this.dtgFigura.AllowUserToResizeColumns = false;
            this.dtgFigura.AllowUserToResizeRows = false;
            this.dtgFigura.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgFigura.BackgroundColor = System.Drawing.Color.White;
            this.dtgFigura.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgFigura.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowFrame;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dtgFigura.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dtgFigura.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgFigura.ContextMenuStrip = this.actions;
            this.dtgFigura.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtgFigura.Location = new System.Drawing.Point(13, 17);
            this.dtgFigura.MultiSelect = false;
            this.dtgFigura.Name = "dtgFigura";
            this.dtgFigura.ReadOnly = true;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtgFigura.RowsDefaultCellStyle = dataGridViewCellStyle2;
            this.dtgFigura.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgFigura.Size = new System.Drawing.Size(772, 263);
            this.dtgFigura.TabIndex = 32;
            // 
            // actions
            // 
            this.actions.BackColor = System.Drawing.Color.White;
            this.actions.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.actions.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.actions.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.actions.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.edit,
            this.delete});
            this.actions.Name = "actions";
            this.actions.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.actions.ShowImageMargin = false;
            this.actions.Size = new System.Drawing.Size(93, 52);
            this.actions.Style = MetroFramework.MetroColorStyle.Blue;
            this.actions.Text = "Actions";
            this.actions.UseCustomBackColor = true;
            this.actions.UseCustomForeColor = true;
            this.actions.UseStyleColors = true;
            this.actions.UseWaitCursor = true;
            // 
            // edit
            // 
            this.edit.AutoToolTip = true;
            this.edit.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.edit.Name = "edit";
            this.edit.Size = new System.Drawing.Size(92, 24);
            this.edit.Text = "Edit";
            this.edit.ToolTipText = "Edit Book";
            this.edit.Click += new System.EventHandler(this.edit_Click);
            // 
            // delete
            // 
            this.delete.AutoToolTip = true;
            this.delete.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(92, 24);
            this.delete.Text = "Delete";
            this.delete.ToolTipText = "Delete Book";
            this.delete.Click += new System.EventHandler(this.delete_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.DarkGray;
            this.btnCancelar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(503, 296);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 33);
            this.btnCancelar.Style = MetroFramework.MetroColorStyle.White;
            this.btnCancelar.TabIndex = 28;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseCustomBackColor = true;
            this.btnCancelar.UseSelectable = true;
            this.btnCancelar.UseStyleColors = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.DarkTurquoise;
            this.btnGuardar.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.Location = new System.Drawing.Point(351, 296);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(110, 33);
            this.btnGuardar.Style = MetroFramework.MetroColorStyle.White;
            this.btnGuardar.TabIndex = 29;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.UseCustomBackColor = true;
            this.btnGuardar.UseSelectable = true;
            this.btnGuardar.UseStyleColors = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tabs
            // 
            this.tabs.Controls.Add(this.tabForm);
            this.tabs.Controls.Add(this.tabData);
            this.tabs.FontSize = MetroFramework.MetroTabControlSize.Small;
            this.tabs.Location = new System.Drawing.Point(75, 75);
            this.tabs.Name = "tabs";
            this.tabs.SelectedIndex = 0;
            this.tabs.Size = new System.Drawing.Size(823, 374);
            this.tabs.TabIndex = 33;
            this.tabs.UseSelectable = true;
            // 
            // tabForm
            // 
            this.tabForm.Controls.Add(this.txtLados);
            this.tabForm.Controls.Add(this.btnCancelar);
            this.tabForm.Controls.Add(this.btnGuardar);
            this.tabForm.Controls.Add(this.metroLabel4);
            this.tabForm.Controls.Add(this.lblId);
            this.tabForm.Controls.Add(this.txtAngulos);
            this.tabForm.Controls.Add(this.metroLabel2);
            this.tabForm.Controls.Add(this.metroLabel3);
            this.tabForm.Controls.Add(this.txtId);
            this.tabForm.Controls.Add(this.txtNombre);
            this.tabForm.HorizontalScrollbarBarColor = true;
            this.tabForm.HorizontalScrollbarHighlightOnWheel = false;
            this.tabForm.HorizontalScrollbarSize = 10;
            this.tabForm.Location = new System.Drawing.Point(4, 34);
            this.tabForm.Name = "tabForm";
            this.tabForm.Size = new System.Drawing.Size(815, 336);
            this.tabForm.TabIndex = 0;
            this.tabForm.Text = "FIGURA FORM";
            this.tabForm.VerticalScrollbarBarColor = true;
            this.tabForm.VerticalScrollbarHighlightOnWheel = false;
            this.tabForm.VerticalScrollbarSize = 10;
            this.tabForm.Click += new System.EventHandler(this.tabForm_Click);
            // 
            // txtLados
            // 
            // 
            // 
            // 
            this.txtLados.CustomButton.Image = null;
            this.txtLados.CustomButton.Location = new System.Drawing.Point(281, 1);
            this.txtLados.CustomButton.Name = "";
            this.txtLados.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLados.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLados.CustomButton.TabIndex = 1;
            this.txtLados.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLados.CustomButton.UseSelectable = true;
            this.txtLados.CustomButton.Visible = false;
            this.txtLados.Lines = new string[0];
            this.txtLados.Location = new System.Drawing.Point(210, 165);
            this.txtLados.MaxLength = 32767;
            this.txtLados.Name = "txtLados";
            this.txtLados.PasswordChar = '\0';
            this.txtLados.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLados.SelectedText = "";
            this.txtLados.SelectionLength = 0;
            this.txtLados.SelectionStart = 0;
            this.txtLados.ShortcutsEnabled = true;
            this.txtLados.Size = new System.Drawing.Size(303, 23);
            this.txtLados.TabIndex = 30;
            this.txtLados.UseSelectable = true;
            this.txtLados.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLados.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tabData
            // 
            this.tabData.Controls.Add(this.dtgFigura);
            this.tabData.HorizontalScrollbarBarColor = true;
            this.tabData.HorizontalScrollbarHighlightOnWheel = false;
            this.tabData.HorizontalScrollbarSize = 10;
            this.tabData.Location = new System.Drawing.Point(4, 34);
            this.tabData.Name = "tabData";
            this.tabData.Size = new System.Drawing.Size(815, 336);
            this.tabData.TabIndex = 1;
            this.tabData.Text = "FIGURA LIST";
            this.tabData.VerticalScrollbarBarColor = true;
            this.tabData.VerticalScrollbarHighlightOnWheel = false;
            this.tabData.VerticalScrollbarSize = 10;
            // 
            // frmFigura
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(941, 535);
            this.Controls.Add(this.tabs);
            this.Controls.Add(this.lNew);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmFigura";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Libary | Book";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtgFigura)).EndInit();
            this.actions.ResumeLayout(false);
            this.tabs.ResumeLayout(false);
            this.tabForm.ResumeLayout(false);
            this.tabForm.PerformLayout();
            this.tabData.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroTextBox txtAngulos;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTextBox txtNombre;
        private MetroFramework.Controls.MetroTextBox txtId;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel lblId;
        private MetroFramework.Controls.MetroButton btnSalir;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLink lNew;
        private System.Windows.Forms.DataGridView dtgFigura;
        private MetroFramework.Controls.MetroButton btnCancelar;
        private MetroFramework.Controls.MetroButton btnGuardar;
        private MetroFramework.Controls.MetroTabControl tabs;
        private MetroFramework.Controls.MetroTabPage tabForm;
        private MetroFramework.Controls.MetroTabPage tabData;
        public MetroFramework.Controls.MetroContextMenu actions;
        private System.Windows.Forms.ToolStripMenuItem edit;
        private System.Windows.Forms.ToolStripMenuItem delete;
        private MetroFramework.Controls.MetroTextBox txtLados;
    }
}

