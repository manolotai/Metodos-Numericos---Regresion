using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyBackPack;

namespace Regresion {
    public partial class Form1 : Form {
        private int _NPuntosActuales;
        private TableLayoutPanel __PanelTblPuntos;
        public Form1()
        {
            InitializeComponent();
            MyInitComponents();
        }

        private void MyInitComponents()
        {
            __ChartGrafica.InitSimpleFuncGraph(true);
            __ChartGrafica.ChartAreas[0].AxisX.RoundAxisValues();
            __TxtNPuntos.Text = "10";
            __TxtGrado.Text = "2";
            _NPuntosActuales = __TxtGrado.Text.ToInt();

            __TxtNPuntos_TextChanged(__TxtNPuntos, new EventArgs());
        }

        private void __TxtNPuntos_TextChanged(object sender, EventArgs e)
        {
            __PanelInputPuntos.Controls.Clear();
            __PanelTblPuntos = new TableLayoutPanel();

            __PanelTblPuntos.InitTable(
                2, __TxtNPuntos.Text.ToInt(),
                new RowStyle(SizeType.Absolute, 20),
                new ColumnStyle(SizeType.Percent, 40));

            __PanelTblPuntos.AutoScroll = true;
            __PanelTblPuntos.Dock = DockStyle.Fill;
            //__PanelTblPuntos.ColumnStyles.Insert(0, new ColumnStyle(SizeType.Absolute, 20));
            //__PanelTblPuntos.ColumnStyles.RemoveAt(1);

            __PanelTblPuntos.FillWithCloneItem(new TextBox() {
                Name = "__TxtPuntos",
                TabIndex = 3},
                0, 0);
            //__PanelTblPuntos.Controls.Add(new Button() {
            //    Name = "__BtnAgregar",
            //    Text = "+", TextAlign = ContentAlignment.MiddleCenter },
            //    0, __TxtNPuntos.Text.ToInt() - 1);
            __PanelInputPuntos.Controls.Add(__PanelTblPuntos);
        }

        private void __BtnRegresion_Click(object sender, EventArgs e)
        {
            __ChartGrafica.Series[0].Points.Clear();
            __ChartGrafica.Series[1].Points.Clear();
            var listaPuntos = new List<JaceFunciones.Point>();
            for (int i = 0; i < __TxtNPuntos.Text.ToInt(); i++) {
                listaPuntos.Add(new JaceFunciones.Point(
                    __PanelTblPuntos.GetControlFromPosition(0, i).Text.ToDouble(),
                    __PanelTblPuntos.GetControlFromPosition(1, i).Text.ToDouble()));
            }

            var matriz = RegresionExtend.Regresion(listaPuntos, __TxtGrado.Text.ToInt());

            var soluciones = matriz.Solucion;
            string polinomio = "";
            for (int i = 0; i < soluciones.Count(); i++) {
                polinomio += String.Format("{0}{1}*x^{2}   ", 
                    soluciones[i] < 0 ? "" : "+", 
                    ("" + soluciones[i]).Contains("E") ? String.Format("{0:F9}") : "" + soluciones[i],
                    i);
            }

            __LblPolinomio.Text = polinomio;
            var fx = JaceFunciones.Fx(polinomio.TrimStart('+'), "x");

            double mayorX = listaPuntos.Max(p => p.X);
            double menorX = listaPuntos.Min(p => p.X);
            double incremento = (mayorX - menorX) / 500;
            for (double i = menorX; i <= mayorX; i += incremento) {
                __ChartGrafica.Series[0].Points.AddXY(i, fx(i));
            }

            listaPuntos.ForEach(p => __ChartGrafica.Series[1].Points.AddXY(p.X, p.Y));
        }
    }
}
