namespace LecturaArchivo
{
    partial class Form2
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
            buscar = new Button();
            url = new TextBox();
            info = new TextBox();
            caheInmediata = new TextBox();
            limpiar = new Button();
            cache = new Button();
            SuspendLayout();
            // 
            // buscar
            // 
            buscar.Location = new Point(88, 25);
            buscar.Name = "buscar";
            buscar.Size = new Size(75, 23);
            buscar.TabIndex = 0;
            buscar.Text = "Buscar";
            buscar.UseVisualStyleBackColor = true;
            buscar.Click += buscar_Click;
            // 
            // url
            // 
            url.Location = new Point(192, 25);
            url.Name = "url";
            url.Size = new Size(416, 23);
            url.TabIndex = 1;
            // 
            // info
            // 
            info.Location = new Point(88, 71);
            info.Multiline = true;
            info.Name = "info";
            info.Size = new Size(249, 213);
            info.TabIndex = 2;
            // 
            // caheInmediata
            // 
            caheInmediata.Location = new Point(359, 71);
            caheInmediata.Multiline = true;
            caheInmediata.Name = "caheInmediata";
            caheInmediata.Size = new Size(249, 213);
            caheInmediata.TabIndex = 3;
            // 
            // limpiar
            // 
            limpiar.Location = new Point(168, 307);
            limpiar.Name = "limpiar";
            limpiar.Size = new Size(75, 23);
            limpiar.TabIndex = 4;
            limpiar.Text = "Limpiar";
            limpiar.UseVisualStyleBackColor = true;
            limpiar.Click += limpiar_Click;
            // 
            // cache
            // 
            cache.Location = new Point(446, 307);
            cache.Name = "cache";
            cache.Size = new Size(75, 23);
            cache.TabIndex = 5;
            cache.Text = "Caché";
            cache.UseVisualStyleBackColor = true;
            cache.Click += cache_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(cache);
            Controls.Add(limpiar);
            Controls.Add(caheInmediata);
            Controls.Add(info);
            Controls.Add(url);
            Controls.Add(buscar);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buscar;
        private TextBox url;
        private TextBox info;
        private TextBox textBox2;
        private Button limpiar;
        private Button cache;
        private TextBox caheInmediata;
    }
}