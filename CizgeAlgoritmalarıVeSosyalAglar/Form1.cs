using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CizgeAlgoritmalarıVeSosyalAglar
{
    public partial class Form1 : Form
    {
        int size;
        int k = 0;
        int m = 0;

        int[] kose1dizi;
        int[] kose2dizi;
        int[] agirlikdizi;

        Graph graph;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnKoseSayisi_Click(object sender, EventArgs e)
        {
            size = int.Parse(txtKoseSayisi.Text);
            graph = new Graph(size);
            kose1dizi = new int[size];
            kose2dizi = new int[size];
            agirlikdizi = new int[size];

            for (int i = 0; i < size; i++)
            {
                kose1dizi[i] = 0;
                kose2dizi[i] = 0;
                agirlikdizi[i] = 0;
            }

            
        }

        private void btnKenarBilGir_Click(object sender, EventArgs e)
        {

            int a, b, c;

           

            a = int.Parse(txtKose1.Text);
            b = int.Parse(txtKose2.Text);
            c = int.Parse(txtKoselerArasıAgırlık.Text);

            

            kose1dizi[k]= a;
            kose2dizi[k] = b;
            agirlikdizi[k] = c;

            k++;



            graph.ekle(a-1, b-1, c-1);

            txtKose1.Clear();
            txtKose2.Clear();
            txtKoselerArasıAgırlık.Clear();

           
        }

        private void dijktraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbBFS.Visible = false;
            gbPrim.Visible = false;
            gbDijktra.Visible = true;
            gbKruskal.Visible = false;
        }

        private void genişlikÖncelikliDolaşmaProblemiBFSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbBFS.Visible = true;
            gbPrim.Visible = false;
            gbDijktra.Visible = false;
            gbKruskal.Visible = false;
        }

        private void btnDijktra_Click(object sender, EventArgs e)
        {
            
           
            int kose1, kose2, uzaklik;

            kose1 = int.Parse(txtDijktra1.Text) - 1;
            kose2 = int.Parse(txtDijktra2.Text) - 1;

            uzaklik = graph.Dijktras(kose1, kose2);

            if (uzaklik != 1000) 
            {

                MessageBox.Show("Köşe çifti arasındaki en kısa uzaklık: " + (uzaklik+1));
            }
            else {

                MessageBox.Show("Köşe çifti arasında bir yol yok!");
            }

            txtDijktra1.Clear();
            txtDijktra2.Clear();

            gbDijktra.Visible = false;
        }

        private void btnBFSHesapla_Click(object sender, EventArgs e)
        {
            
            int kose;

            ArrayList isim = new ArrayList();

            listBFS.Items.Clear();

            kose = int.Parse(txtBFS.Text) - 1;

            isim = graph.BFS(kose);

            listBFS.Visible = true;

            foreach (int i in isim)
                listBFS.Items.Add((i + 1) + "\n");

            txtBFS.Clear();
        }

        private void kruskalAlgoritmasıTabanlıToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbKruskal.Visible = true;
            gbBFS.Visible = false;
            gbPrim.Visible = false;
            gbDijktra.Visible = false;
            

            Adjacency adjacency = new Adjacency(size);

           
            for (int i = 0; i < size; i++)
            {
                
                    adjacency.setElementAt(true, kose1dizi[i]-1, kose2dizi[i]-1);
                    adjacency.setWeight(kose1dizi[i]-1, kose2dizi[i]-1, agirlikdizi[i]-1);
                
            }

            KruskalMST mst = new KruskalMST();
            Pair[] A = mst.MSTKruskal(size,adjacency);

            txtKruskal.Text = "Minimum Spanning Tree Kenarları \r\n\r\n";

            for (int j = 0; j < A.Length; j++)
            {
                if (A[j] != null)
                    txtKruskal.Text += A[j].ToString() + "\r\n";
            }
        }

        private void primAlgoritmasıTabanlıEnKüçükAğaçKapsayanProblemiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbKruskal.Visible = false;
            gbBFS.Visible = false;
            gbDijktra.Visible = false;
            gbPrim.Visible = true;

            int[,] graphPrim = new int[size, size];
            string cikti2;

            for (int i = 0; i < size; i++)
            {

                for (int j = 0; j < size; j++)
                {
                    graphPrim[i, j] = agirlikdizi[i];

                }


                /*  int[,] graph = {
                                 { 0, 2, 0, 6, 0 },
                                 { 2, 0, 3, 8, 5 },
                                 { 0, 3, 0, 0, 7 },
                                 { 6, 8, 0, 0, 9 },
                                 { 0, 5, 7, 9, 0 },
                                 };*/

                  Prim prim = new Prim();
                  cikti2 = prim.Prim1(graphPrim, size);

                  txtPrim.Text = "Edge     Weight";
                  txtPrim.Text = "Edge     Weight" + Environment.NewLine + Environment.NewLine + cikti2;

                
            }
        }

        private void sosyalAğToolStripMenuItem_Click(object sender, EventArgs e)
        {
            gbPrim.Visible = false;
            gbKruskal.Visible = false;
            gbDijktra.Visible = false;
            gbBFS.Visible = false;

            Form2 frm2 = new Form2();
            frm2.Show();
        }

        private void txtKruskal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
