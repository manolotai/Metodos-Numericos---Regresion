namespace Regresion {
    partial class Form1 {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.@__PnlMainForm = new System.Windows.Forms.Panel();
            this.@__PnlTblMain = new System.Windows.Forms.TableLayoutPanel();
            this.@__PnlTblDivMain = new System.Windows.Forms.TableLayoutPanel();
            this.@__PnlInput = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.@__PanelInputPuntos = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.@__TxtGrado = new System.Windows.Forms.TextBox();
            this.@__BtnRegresion = new System.Windows.Forms.Button();
            this.@__ChartGrafica = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label4 = new System.Windows.Forms.Label();
            this.@__TxtNPuntos = new System.Windows.Forms.TextBox();
            this.@__LblPolinomio = new System.Windows.Forms.Label();
            this.@__PnlMainForm.SuspendLayout();
            this.@__PnlTblMain.SuspendLayout();
            this.@__PnlTblDivMain.SuspendLayout();
            this.@__PnlInput.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.@__ChartGrafica)).BeginInit();
            this.SuspendLayout();
            // 
            // __PnlMainForm
            // 
            this.@__PnlMainForm.Controls.Add(this.@__PnlTblMain);
            this.@__PnlMainForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PnlMainForm.Location = new System.Drawing.Point(0, 0);
            this.@__PnlMainForm.Name = "__PnlMainForm";
            this.@__PnlMainForm.Size = new System.Drawing.Size(679, 321);
            this.@__PnlMainForm.TabIndex = 0;
            // 
            // __PnlTblMain
            // 
            this.@__PnlTblMain.ColumnCount = 1;
            this.@__PnlTblMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__PnlTblMain.Controls.Add(this.@__PnlTblDivMain, 0, 0);
            this.@__PnlTblMain.Controls.Add(this.@__LblPolinomio, 0, 1);
            this.@__PnlTblMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PnlTblMain.Location = new System.Drawing.Point(0, 0);
            this.@__PnlTblMain.Name = "__PnlTblMain";
            this.@__PnlTblMain.RowCount = 2;
            this.@__PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.@__PnlTblMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.@__PnlTblMain.Size = new System.Drawing.Size(679, 321);
            this.@__PnlTblMain.TabIndex = 1;
            // 
            // __PnlTblDivMain
            // 
            this.@__PnlTblDivMain.ColumnCount = 2;
            this.@__PnlTblDivMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40F));
            this.@__PnlTblDivMain.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60F));
            this.@__PnlTblDivMain.Controls.Add(this.@__PnlInput, 0, 0);
            this.@__PnlTblDivMain.Controls.Add(this.@__ChartGrafica, 1, 0);
            this.@__PnlTblDivMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PnlTblDivMain.Location = new System.Drawing.Point(0, 0);
            this.@__PnlTblDivMain.Margin = new System.Windows.Forms.Padding(0);
            this.@__PnlTblDivMain.Name = "__PnlTblDivMain";
            this.@__PnlTblDivMain.RowCount = 1;
            this.@__PnlTblDivMain.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.@__PnlTblDivMain.Size = new System.Drawing.Size(679, 256);
            this.@__PnlTblDivMain.TabIndex = 0;
            // 
            // __PnlInput
            // 
            this.@__PnlInput.Controls.Add(this.@__TxtNPuntos);
            this.@__PnlInput.Controls.Add(this.label4);
            this.@__PnlInput.Controls.Add(this.label3);
            this.@__PnlInput.Controls.Add(this.label2);
            this.@__PnlInput.Controls.Add(this.@__PanelInputPuntos);
            this.@__PnlInput.Controls.Add(this.label1);
            this.@__PnlInput.Controls.Add(this.@__TxtGrado);
            this.@__PnlInput.Controls.Add(this.@__BtnRegresion);
            this.@__PnlInput.Dock = System.Windows.Forms.DockStyle.Fill;
            this.@__PnlInput.Location = new System.Drawing.Point(0, 0);
            this.@__PnlInput.Margin = new System.Windows.Forms.Padding(0);
            this.@__PnlInput.Name = "__PnlInput";
            this.@__PnlInput.Size = new System.Drawing.Size(271, 256);
            this.@__PnlInput.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(174, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(14, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Y";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(65, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(14, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "X";
            // 
            // __PanelInputPuntos
            // 
            this.@__PanelInputPuntos.Location = new System.Drawing.Point(20, 80);
            this.@__PanelInputPuntos.Name = "__PanelInputPuntos";
            this.@__PanelInputPuntos.Size = new System.Drawing.Size(234, 135);
            this.@__PanelInputPuntos.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(28, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Grado Polinomio";
            // 
            // __TxtGrado
            // 
            this.@__TxtGrado.Location = new System.Drawing.Point(34, 33);
            this.@__TxtGrado.Name = "__TxtGrado";
            this.@__TxtGrado.Size = new System.Drawing.Size(71, 20);
            this.@__TxtGrado.TabIndex = 1;
            this.@__TxtGrado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // __BtnRegresion
            // 
            this.@__BtnRegresion.Location = new System.Drawing.Point(103, 230);
            this.@__BtnRegresion.Name = "__BtnRegresion";
            this.@__BtnRegresion.Size = new System.Drawing.Size(75, 23);
            this.@__BtnRegresion.TabIndex = 0;
            this.@__BtnRegresion.Text = "Regresion";
            this.@__BtnRegresion.UseVisualStyleBackColor = true;
            this.@__BtnRegresion.Click += new System.EventHandler(this.@__BtnRegresion_Click);
            // 
            // __ChartGrafica
            // 
            chartArea6.Name = "ChartArea1";
            this.@__ChartGrafica.ChartAreas.Add(chartArea6);
            this.@__ChartGrafica.Dock = System.Windows.Forms.DockStyle.Fill;
            legend6.Name = "Legend1";
            this.@__ChartGrafica.Legends.Add(legend6);
            this.@__ChartGrafica.Location = new System.Drawing.Point(274, 3);
            this.@__ChartGrafica.Name = "__ChartGrafica";
            series6.ChartArea = "ChartArea1";
            series6.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series6.Legend = "Legend1";
            series6.Name = "Series1";
            this.@__ChartGrafica.Series.Add(series6);
            this.@__ChartGrafica.Size = new System.Drawing.Size(402, 250);
            this.@__ChartGrafica.TabIndex = 1;
            this.@__ChartGrafica.Text = "chart1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(169, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "N Puntos";
            // 
            // __TxtNPuntos
            // 
            this.@__TxtNPuntos.Location = new System.Drawing.Point(158, 33);
            this.@__TxtNPuntos.Name = "__TxtNPuntos";
            this.@__TxtNPuntos.Size = new System.Drawing.Size(74, 20);
            this.@__TxtNPuntos.TabIndex = 2;
            this.@__TxtNPuntos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.@__TxtNPuntos.TextChanged += new System.EventHandler(this.@__TxtNPuntos_TextChanged);
            // 
            // __LblPolinomio
            // 
            this.@__LblPolinomio.AutoSize = true;
            this.@__LblPolinomio.Location = new System.Drawing.Point(3, 256);
            this.@__LblPolinomio.Name = "__LblPolinomio";
            this.@__LblPolinomio.Size = new System.Drawing.Size(16, 13);
            this.@__LblPolinomio.TabIndex = 1;
            this.@__LblPolinomio.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(679, 321);
            this.Controls.Add(this.@__PnlMainForm);
            this.Name = "Form1";
            this.Text = "Regresion Polinomial - Ruiz Alcaraz Angel Emmanuel";
            this.@__PnlMainForm.ResumeLayout(false);
            this.@__PnlTblMain.ResumeLayout(false);
            this.@__PnlTblMain.PerformLayout();
            this.@__PnlTblDivMain.ResumeLayout(false);
            this.@__PnlInput.ResumeLayout(false);
            this.@__PnlInput.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.@__ChartGrafica)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel __PnlMainForm;
        private System.Windows.Forms.TableLayoutPanel __PnlTblMain;
        private System.Windows.Forms.TableLayoutPanel __PnlTblDivMain;
        private System.Windows.Forms.Panel __PnlInput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel __PanelInputPuntos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox __TxtGrado;
        private System.Windows.Forms.Button __BtnRegresion;
        private System.Windows.Forms.DataVisualization.Charting.Chart __ChartGrafica;
        private System.Windows.Forms.TextBox __TxtNPuntos;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label __LblPolinomio;
    }
}

