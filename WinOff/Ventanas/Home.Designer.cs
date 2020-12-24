
namespace WinOff.Ventanas {
    partial class Home {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            this.butApagar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbTiempo = new System.Windows.Forms.ComboBox();
            this.gbUnidad = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.butCancelar = new System.Windows.Forms.Button();
            this.gbUnidad.SuspendLayout();
            this.SuspendLayout();
            // 
            // butApagar
            // 
            this.butApagar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butApagar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butApagar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butApagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butApagar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butApagar.ForeColor = System.Drawing.Color.White;
            this.butApagar.Location = new System.Drawing.Point(24, 268);
            this.butApagar.Name = "butApagar";
            this.butApagar.Size = new System.Drawing.Size(138, 27);
            this.butApagar.TabIndex = 0;
            this.butApagar.Text = "Programar apagado";
            this.butApagar.UseVisualStyleBackColor = false;
            this.butApagar.Click += new System.EventHandler(this.butApagar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(94, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tiempo para apagar";
            // 
            // cbTiempo
            // 
            this.cbTiempo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.cbTiempo.DropDownHeight = 75;
            this.cbTiempo.ForeColor = System.Drawing.Color.White;
            this.cbTiempo.FormattingEnabled = true;
            this.cbTiempo.IntegralHeight = false;
            this.cbTiempo.Location = new System.Drawing.Point(100, 171);
            this.cbTiempo.Name = "cbTiempo";
            this.cbTiempo.Size = new System.Drawing.Size(121, 21);
            this.cbTiempo.TabIndex = 5;
            // 
            // gbUnidad
            // 
            this.gbUnidad.Controls.Add(this.radioButton3);
            this.gbUnidad.Controls.Add(this.radioButton2);
            this.gbUnidad.Controls.Add(this.radioButton1);
            this.gbUnidad.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbUnidad.ForeColor = System.Drawing.Color.White;
            this.gbUnidad.Location = new System.Drawing.Point(65, 24);
            this.gbUnidad.Name = "gbUnidad";
            this.gbUnidad.Size = new System.Drawing.Size(200, 100);
            this.gbUnidad.TabIndex = 6;
            this.gbUnidad.TabStop = false;
            this.gbUnidad.Text = "Unidades de tiempo";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton3.Location = new System.Drawing.Point(7, 65);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(65, 21);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Horas.";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton2.Location = new System.Drawing.Point(6, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(79, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Minutos.";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton1.Location = new System.Drawing.Point(7, 20);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Segundos.";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // butCancelar
            // 
            this.butCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butCancelar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.butCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(21)))), ((int)(((byte)(21)))));
            this.butCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.butCancelar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butCancelar.ForeColor = System.Drawing.Color.White;
            this.butCancelar.Location = new System.Drawing.Point(171, 268);
            this.butCancelar.Name = "butCancelar";
            this.butCancelar.Size = new System.Drawing.Size(125, 27);
            this.butCancelar.TabIndex = 7;
            this.butCancelar.Text = "Cancelar apagado";
            this.butCancelar.UseVisualStyleBackColor = false;
            this.butCancelar.Click += new System.EventHandler(this.butCancelar_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(31)))), ((int)(((byte)(31)))));
            this.ClientSize = new System.Drawing.Size(331, 329);
            this.Controls.Add(this.butCancelar);
            this.Controls.Add(this.gbUnidad);
            this.Controls.Add(this.cbTiempo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.butApagar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WinOff";
            this.Load += new System.EventHandler(this.Home_Load);
            this.gbUnidad.ResumeLayout(false);
            this.gbUnidad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butApagar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbTiempo;
        private System.Windows.Forms.GroupBox gbUnidad;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Button butCancelar;
    }
}