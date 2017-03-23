namespace ConexionFinal
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Dgview = new System.Windows.Forms.DataGridView();
            this.consulta = new System.Windows.Forms.Button();
            this.insert = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txtedad = new System.Windows.Forms.TextBox();
            this.btnconex = new System.Windows.Forms.Button();
            this.btneliminar = new System.Windows.Forms.Button();
            this.txtnombres = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnordenar = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Dgview)).BeginInit();
            this.SuspendLayout();
            // 
            // Dgview
            // 
            this.Dgview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dgview.Location = new System.Drawing.Point(1, -2);
            this.Dgview.Name = "Dgview";
            this.Dgview.Size = new System.Drawing.Size(299, 347);
            this.Dgview.TabIndex = 0;
            // 
            // consulta
            // 
            this.consulta.Location = new System.Drawing.Point(329, 12);
            this.consulta.Name = "consulta";
            this.consulta.Size = new System.Drawing.Size(75, 23);
            this.consulta.TabIndex = 1;
            this.consulta.Text = "CONSULTA";
            this.consulta.UseVisualStyleBackColor = true;
            this.consulta.Click += new System.EventHandler(this.consulta_Click);
            // 
            // insert
            // 
            this.insert.Location = new System.Drawing.Point(329, 231);
            this.insert.Name = "insert";
            this.insert.Size = new System.Drawing.Size(75, 23);
            this.insert.TabIndex = 2;
            this.insert.Text = "INSERTAR";
            this.insert.UseVisualStyleBackColor = true;
            this.insert.Click += new System.EventHandler(this.insert_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 257);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "NOMBRE";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(343, 296);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "EDAD";
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(317, 273);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(100, 20);
            this.txtnombre.TabIndex = 5;
            // 
            // txtedad
            // 
            this.txtedad.Location = new System.Drawing.Point(317, 312);
            this.txtedad.Name = "txtedad";
            this.txtedad.Size = new System.Drawing.Size(100, 20);
            this.txtedad.TabIndex = 6;
            // 
            // btnconex
            // 
            this.btnconex.Location = new System.Drawing.Point(329, 186);
            this.btnconex.Name = "btnconex";
            this.btnconex.Size = new System.Drawing.Size(75, 23);
            this.btnconex.TabIndex = 7;
            this.btnconex.Text = "CONEXION";
            this.btnconex.UseVisualStyleBackColor = true;
            this.btnconex.Click += new System.EventHandler(this.btnconex_Click);
            // 
            // btneliminar
            // 
            this.btneliminar.Location = new System.Drawing.Point(329, 105);
            this.btneliminar.Name = "btneliminar";
            this.btneliminar.Size = new System.Drawing.Size(75, 23);
            this.btneliminar.TabIndex = 8;
            this.btneliminar.Text = "ELIMINAR";
            this.btneliminar.UseVisualStyleBackColor = true;
            this.btneliminar.Click += new System.EventHandler(this.btneliminar_Click);
            // 
            // txtnombres
            // 
            this.txtnombres.Location = new System.Drawing.Point(317, 151);
            this.txtnombres.Name = "txtnombres";
            this.txtnombres.Size = new System.Drawing.Size(100, 20);
            this.txtnombres.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(343, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 9;
            this.label3.Text = "NOMBRE";
            // 
            // btnordenar
            // 
            this.btnordenar.Location = new System.Drawing.Point(329, 59);
            this.btnordenar.Name = "btnordenar";
            this.btnordenar.Size = new System.Drawing.Size(75, 23);
            this.btnordenar.TabIndex = 11;
            this.btnordenar.Text = "ORDENAR";
            this.btnordenar.UseVisualStyleBackColor = true;
            this.btnordenar.Click += new System.EventHandler(this.btnordenar_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 312);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(186, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Alumno: Jesus Antonio Juarez Devora";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 338);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnordenar);
            this.Controls.Add(this.txtnombres);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btneliminar);
            this.Controls.Add(this.btnconex);
            this.Controls.Add(this.txtedad);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.insert);
            this.Controls.Add(this.consulta);
            this.Controls.Add(this.Dgview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "MYSQL";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgview;
        private System.Windows.Forms.Button consulta;
        private System.Windows.Forms.Button insert;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtnombre;
        private System.Windows.Forms.TextBox txtedad;
        private System.Windows.Forms.Button btnconex;
        private System.Windows.Forms.Button btneliminar;
        private System.Windows.Forms.TextBox txtnombres;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnordenar;
        private System.Windows.Forms.Label label4;
    }
}

