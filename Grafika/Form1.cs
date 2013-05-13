using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace Grafika
{
    
    public partial class Form1 : Form
    {
        public Graphics prav;
        public Mreza mrda = new Mreza();
        public Graphics ramka;
        public Mreza grid = new Mreza();
        public SolidBrush drap = new SolidBrush(Color.BurlyWood);
        public SolidBrush crven = new SolidBrush(Color.Red);
        public SolidBrush safari = new SolidBrush(Color.DarkGoldenrod);
        public SolidBrush zelen = new SolidBrush(Color.Green);
        public SolidBrush zolt = new SolidBrush(Color.Yellow);
        public SolidBrush plav = new SolidBrush(Color.Blue);
        public SolidBrush tirkiz = new SolidBrush(Color.Cyan);
        public SolidBrush lila = new SolidBrush(Color.DarkViolet);
        public SolidBrush trava = new SolidBrush(Color.GreenYellow);
        public SolidBrush zlato = new SolidBrush(Color.Orange);
        public SolidBrush cigla = new SolidBrush(Color.Maroon);
        public SolidBrush roze = new SolidBrush(Color.Magenta);
        public Pen mol = new Pen(Color.Black, 2);
        public int[] X_br = new int[5] { 1, 10, 11, 12, 21 };
        public int[] B_br = new int[5] { 0, 1, 10, 11, 20 };
        public int[] C_br = new int[5] { 0, 1, 10, 20, 21 };
        public int[] I_br = new int[5] { 0, 10, 20, 30, 40 };
        public int[] T_br = new int[5] { 0, 1, 2, 11, 21 };
        public int[] L_br = new int[5] { 0, 10, 20, 30, 31 };
        public int[] W_br = new int[5] { 0, 10, 11, 21, 22 };
        public int[] Z_br = new int[5] { 0, 1, 11, 21, 22 };
        public int[] F_br = new int[5] { 0, 1, 11, 12, 21 };
        public int[] S_br = new int[5] { 1, 10, 11, 20, 30 };
        public int[] G_br = new int[5] { 0, 1, 2, 10, 20 };
        public int[] P_br = new int[5] { 0, 10, 11, 20, 30 };
        public Blok X_blok;
        public Blok B_blok;
        public Blok C_blok;
        public Blok I_blok;
        public Blok T_blok;
        public Blok L_blok;
        public Blok W_blok;
        public Blok Z_blok;
        public Blok F_blok;
        public Blok S_blok;
        public Blok G_blok;
        public Blok P_blok;
        bool crtaj_X = false;
        bool crtaj_B = false;
        bool crtaj_C = false;
        bool crtaj_I = false;
        bool crtaj_T = false;
        bool crtaj_L = false;
        bool crtaj_W = false;
        bool crtaj_Z = false;
        bool crtaj_F = false;
        bool crtaj_S = false;
        bool crtaj_G = false;
        bool crtaj_P = false;
        char ZNAK = ' ';
        public bool r;
        public bool f;
        int rot = 0;
        int kody = 0;
        int kodx = 0;
        int gran = 0;

        public Form1()
        {
            InitializeComponent();

            prav = button1.CreateGraphics();
            ramka = button1.CreateGraphics();
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            ramka.DrawRectangles(mol, grid.pretvori());

            Graphics X_gr = button5.CreateGraphics();
            X_gr.FillRectangle(drap, 20, 40, 60, 20);
            X_gr.FillRectangle(drap, 40, 20, 20, 60);
            X_gr.DrawRectangle(mol, 20, 40, 60, 20);
            X_gr.DrawRectangle(mol, 40, 20, 20, 60);

            Graphics B_gr = button3.CreateGraphics();
            B_gr.FillRectangle(crven, 20, 20, 40, 20);
            B_gr.FillRectangle(crven, 20, 40, 40, 20);
            B_gr.FillRectangle(crven, 20, 20, 20, 60);
            B_gr.DrawRectangle(mol, 20, 20, 40, 20);
            B_gr.DrawRectangle(mol, 20, 40, 40, 20);
            B_gr.DrawRectangle(mol, 20, 20, 20, 60);

            Graphics C_gr = button4.CreateGraphics();
            C_gr.FillRectangle(safari, 20, 20, 40, 20);
            C_gr.FillRectangle(safari, 20, 60, 40, 20);
            C_gr.FillRectangle(safari, 20, 20, 20, 60);
            C_gr.DrawRectangle(mol, 20, 20, 40, 20);
            C_gr.DrawRectangle(mol, 20, 60, 40, 20);
            C_gr.DrawRectangle(mol, 20, 20, 20, 60);

            Graphics I_gr = button2.CreateGraphics();
            I_gr.FillRectangle(zelen, 5, 41, 90, 18);
            I_gr.DrawRectangle(mol, 5, 41, 90, 18);
            I_gr.DrawRectangle(mol, 23, 41, 54, 18);
            I_gr.DrawRectangle(mol, 41, 41, 18, 18);

            Graphics T_gr = button6.CreateGraphics();
            T_gr.FillRectangle(zolt, 20, 20, 60, 20);
            T_gr.FillRectangle(zolt, 40, 20, 20, 60);
            T_gr.DrawRectangle(mol, 20, 20, 60, 20);
            T_gr.DrawRectangle(mol, 40, 20, 20, 60);
            T_gr.DrawRectangle(mol, 40, 60, 20, 20);

            Graphics L_gr = button7.CreateGraphics();
            L_gr.FillRectangle(plav, 30, 10, 20, 80);
            L_gr.FillRectangle(plav, 30, 70, 40, 20);
            L_gr.DrawRectangle(mol, 30, 10, 20, 80);
            L_gr.DrawRectangle(mol, 30, 30, 20, 20);
            L_gr.DrawRectangle(mol, 30, 70, 40, 20);

            Graphics W_gr = button13.CreateGraphics();
            W_gr.FillRectangle(tirkiz, 20, 20, 20, 40);
            W_gr.FillRectangle(tirkiz, 40, 60, 40, 20);
            W_gr.FillRectangle(tirkiz, 40, 40, 20, 20);
            W_gr.DrawRectangle(mol, 20, 20, 20, 40);
            W_gr.DrawRectangle(mol, 40, 40, 20, 40);
            W_gr.DrawRectangle(mol, 20, 40, 40, 20);
            W_gr.DrawRectangle(mol, 40, 60, 40, 20);

            Graphics Z_gr = button12.CreateGraphics();
            Z_gr.FillRectangle(lila, 40, 20, 20, 60);
            Z_gr.FillRectangle(lila, 40, 60, 40, 20);
            Z_gr.FillRectangle(lila, 20, 20, 40, 20);
            Z_gr.DrawRectangle(mol, 40, 20, 20, 60);
            Z_gr.DrawRectangle(mol, 40, 60, 40, 20);
            Z_gr.DrawRectangle(mol, 20, 20, 40, 20);

            Graphics F_gr = button11.CreateGraphics();
            F_gr.FillRectangle(trava, 40, 20, 20, 60);
            F_gr.FillRectangle(trava, 40, 40, 40, 20);
            F_gr.FillRectangle(trava, 20, 20, 40, 20);
            F_gr.DrawRectangle(mol, 40, 20, 20, 60);
            F_gr.DrawRectangle(mol, 40, 40, 40, 20);
            F_gr.DrawRectangle(mol, 20, 20, 40, 20);

            Graphics S_gr = button10.CreateGraphics();
            S_gr.FillRectangle(zlato, 30, 30, 20, 60);
            S_gr.FillRectangle(zlato, 50, 10, 20, 40);
            S_gr.DrawRectangle(mol, 30, 30, 20, 60);
            S_gr.DrawRectangle(mol, 50, 10, 20, 40);
            S_gr.DrawRectangle(mol, 30, 30, 40, 20);
            S_gr.DrawRectangle(mol, 30, 70, 20, 20);

            Graphics G_gr = button9.CreateGraphics();
            G_gr.FillRectangle(cigla, 20, 20, 60, 20);
            G_gr.FillRectangle(cigla, 20, 20, 20, 60);
            G_gr.DrawRectangle(mol, 20, 20, 60, 20);
            G_gr.DrawRectangle(mol, 20, 20, 20, 60);
            G_gr.DrawRectangle(mol, 40, 20, 20, 20);
            G_gr.DrawRectangle(mol, 20, 60, 20, 20);

            Graphics P_gr = button8.CreateGraphics();
            P_gr.FillRectangle(roze, 30, 10, 20, 80);
            P_gr.FillRectangle(roze, 30, 30, 40, 20);
            P_gr.DrawRectangle(mol, 30, 10, 20, 80);
            P_gr.DrawRectangle(mol, 30, 30, 20, 40);
            P_gr.DrawRectangle(mol, 30, 30, 40, 20);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (crtaj_X)
            {
                crtaj_X = false;
                grid.tocno[X_br[0]] = false;
                grid.tocno[X_br[1]] = false;
                grid.tocno[X_br[2]] = false;
                grid.tocno[X_br[3]] = false;
                grid.tocno[X_br[4]] = false;
            }

            X_br[0] = 1; X_br[1] = 10; X_br[2] = 11; X_br[3] = 12; X_br[4] = 21;
            X_blok = new Blok(X_br, mrda);
            kodx = 0; kody = 0;
            ZNAK = 'X';
            prav.Clear(Color.White);
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P){
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
        }

        private void button5_KeyDown(object sender, KeyEventArgs e)
        {
            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        X_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        X_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        X_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 3)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        X_br[i] += 10;
                    kody++;
                }
            }
            prav.Clear(Color.White);
            X_blok = new Blok(X_br, mrda);
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (crtaj_B)
            {
                crtaj_B = false;
                grid.tocno[B_br[0]] = false;
                grid.tocno[B_br[1]] = false;
                grid.tocno[B_br[2]] = false;
                grid.tocno[B_br[3]] = false;
                grid.tocno[B_br[4]] = false;
            }

            B_br[0] = 0; B_br[1] = 1; B_br[2] = 10; B_br[3] = 11; B_br[4] = 20;
            B_blok = new Blok(B_br, mrda);
            kodx = 0; kody = 0; gran = 1; rot = 0;
            f = false; ZNAK = 'B';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
        }

        private void button3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F))
            {
                if (f == false)
                {
                    f = true;
                    if (rot == 0)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 10; B_br[3] = 11; B_br[4] = 21;
                        gran = 1;
                    }
                    else if (rot == 1)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 2; B_br[3] = 10; B_br[4] = 11;
                    }
                    else if (rot == 2)
                    {
                        B_br[0] = 0; B_br[1] = 10; B_br[2] = 11; B_br[3] = 20; B_br[4] = 21;
                        gran = 1;
                    }
                    else if (rot == -1)
                    {
                        B_br[0] = 1; B_br[1] = 2; B_br[2] = 10; B_br[3] = 11; B_br[4] = 12;
                    }
                }
                else if (f == true)
                {
                    f = false;
                    if (rot == 0)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 10; B_br[3] = 11; B_br[4] = 20;
                        gran = 1;
                    }
                    else if (rot == 1)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 10; B_br[3] = 11; B_br[4] = 12;
                    }
                    else if (rot == 2)
                    {
                        B_br[0] = 1; B_br[1] = 10; B_br[2] = 11; B_br[3] = 20; B_br[4] = 21;
                        gran = 1;
                    }
                    else if (rot == -1)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 2; B_br[3] = 11; B_br[4] = 12;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (e.KeyCode.Equals(Keys.R))
            {
                rot++;
                gran = 0;
                if (f == false)
                {
                    if (rot == 0)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 10; B_br[3] = 11; B_br[4] = 20;
                        gran = 1;
                    }
                    else if (rot == 1)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 10; B_br[3] = 11; B_br[4] = 12;
                    }
                    else if (rot == 2)
                    {
                        B_br[0] = 1; B_br[1] = 10; B_br[2] = 11; B_br[3] = 20; B_br[4] = 21;
                        gran = 1;
                    }
                    else if (rot == 3)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 2; B_br[3] = 11; B_br[4] = 12;
                        rot = -1;
                    }
                }
                else if (f == true)
                {
                    if (rot == 0)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 10; B_br[3] = 11; B_br[4] = 21;
                        gran = 1;
                    }
                    else if (rot == 1)
                    {
                        B_br[0] = 0; B_br[1] = 1; B_br[2] = 2; B_br[3] = 10; B_br[4] = 11;
                    }
                    else if (rot == 2)
                    {
                        B_br[0] = 0; B_br[1] = 10; B_br[2] = 11; B_br[3] = 20; B_br[4] = 21;
                        gran = 1;
                    }
                    else if (rot == 3)
                    {
                        B_br[0] = 1; B_br[1] = 2; B_br[2] = 10; B_br[3] = 11; B_br[4] = 12;
                        rot = -1;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        B_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7+gran)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        B_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        B_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 4-gran)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        B_br[i] += 10;
                    kody++;
                }
            }
            B_blok = new Blok(B_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (crtaj_C)
            {
                crtaj_C = false;
                grid.tocno[C_br[0]] = false;
                grid.tocno[C_br[1]] = false;
                grid.tocno[C_br[2]] = false;
                grid.tocno[C_br[3]] = false;
                grid.tocno[C_br[4]] = false;
            }

            C_br[0] = 0; C_br[1] = 1; C_br[2] = 10; C_br[3] = 20; C_br[4] = 21;
            C_blok = new Blok(C_br, mrda);
            kodx = 0; kody = 0; gran = 1;
            f = false; r = false; ZNAK = 'C';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
        }

        private void button4_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode.Equals(Keys.F))
            {
                gran = 1;
                if (f == false)
                {
                    f = true;
                    if (r == false)
                    {
                        C_br[0] = 0; C_br[1] = 1; C_br[2] = 11; C_br[3] = 20; C_br[4] = 21;
                    }
                    else if (r == true)
                    {
                        C_br[0] = 0; C_br[1] = 1; C_br[2] = 2; C_br[3] = 10; C_br[4] = 12;
                        gran = 0;
                    }
                }
                else if (f == true)
                {
                    f = false;
                    if (r == false)
                    {
                        C_br[0] = 0; C_br[1] = 1; C_br[2] = 10; C_br[3] = 20; C_br[4] = 21;
                    }
                    else if (r == true)
                    {
                        C_br[0] = 0; C_br[1] = 2; C_br[2] = 10; C_br[3] = 11; C_br[4] = 12;
                        gran = 0;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (e.KeyCode.Equals(Keys.R))
            {
                gran = 1;
                if (r == false)
                {
                    r = true;
                    gran = 0;
                    if (f == false)
                    {
                        C_br[0] = 0; C_br[1] = 2; C_br[2] = 10; C_br[3] = 11; C_br[4] = 12;
                    }
                    else if (f == true)
                    {
                        C_br[0] = 0; C_br[1] = 1; C_br[2] = 2; C_br[3] = 10; C_br[4] = 12;
                    }
                }
                else if (r == true)
                {
                    r = false;
                    if (f == false)
                    {
                        C_br[0] = 0; C_br[1] = 1; C_br[2] = 10; C_br[3] = 20; C_br[4] = 21;
                    }
                    else if (f == true)
                    {
                        C_br[0] = 0; C_br[1] = 1; C_br[2] = 11; C_br[3] = 20; C_br[4] = 21;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        C_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7 + gran)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        C_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        C_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 4 - gran)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        C_br[i] += 10;
                    kody++;
                }
            }
            C_blok = new Blok(C_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (crtaj_I)
            {
                crtaj_I = false;
                grid.tocno[I_br[0]] = false;
                grid.tocno[I_br[1]] = false;
                grid.tocno[I_br[2]] = false;
                grid.tocno[I_br[3]] = false;
                grid.tocno[I_br[4]] = false;
            }

            I_br[0] = 0; I_br[1] = 1; I_br[2] = 2; I_br[3] = 3; I_br[4] = 4;
            I_blok = new Blok(I_br, mrda);
            kodx = 0; kody = 0; gran = 0;
            r = false; ZNAK = 'I';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
        }

        private void button2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.R))
            {
                if (r == true)
                {
                    I_br[0] = 0; I_br[1] = 1; I_br[2] = 2; I_br[3] = 3; I_br[4] = 4;
                    kodx = 0; kody = 0; gran = 0;
                    r = false;
                }
                else if (r == false)
                {
                    I_br[0] = 0; I_br[1] = 10; I_br[2] = 20; I_br[3] = 30; I_br[4] = 40;
                    kodx = 0; kody = 0; gran = 4;
                    r = true;
                }
            }


            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        I_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 5 + gran)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        I_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        I_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 5 - gran)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        I_br[i] += 10;
                    kody++;
                }
            }
            I_blok = new Blok(I_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (crtaj_T)
            {
                crtaj_T = false;
                grid.tocno[T_br[0]] = false;
                grid.tocno[T_br[1]] = false;
                grid.tocno[T_br[2]] = false;
                grid.tocno[T_br[3]] = false;
                grid.tocno[T_br[4]] = false;

                if (crtaj_X)
                    button5.Enabled = false;
                if (crtaj_B)
                    button3.Enabled = false;
                if (crtaj_C)
                    button4.Enabled = false;
                if (crtaj_I)
                    button2.Enabled = false;
                if (crtaj_L)
                    button7.Enabled = false;
                if (crtaj_W)
                    button13.Enabled = false;
                if (crtaj_Z)
                    button12.Enabled = false;
                if (crtaj_F)
                    button11.Enabled = false;
                if (crtaj_S)
                    button10.Enabled = false;
                if (crtaj_G)
                    button9.Enabled = false;
                if (crtaj_P)
                    button8.Enabled = false;
            }

            T_br[0] = 0; T_br[1] = 1; T_br[2] = 2; T_br[3] = 11; T_br[4] = 21;
            T_blok = new Blok(T_br, mrda);
            kodx = 0; kody = 0;
            ZNAK = 'T';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
        }

        private void button6_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode.Equals(Keys.R))
            {
                rot++;
                if (rot == 0)
                {
                    T_br[0] = 0; T_br[1] = 1; T_br[2] = 2; T_br[3] = 11; T_br[4] = 21;
                }
                else if (rot == 1)
                {
                    T_br[0] = 0; T_br[1] = 10; T_br[2] = 11; T_br[3] = 12; T_br[4] = 20;
                }
                else if (rot == 2)
                {
                    T_br[0] = 1; T_br[1] = 11; T_br[2] = 20; T_br[3] = 21; T_br[4] = 22;
                }
                else if (rot == 3)
                {
                    T_br[0] = 2; T_br[1] = 10; T_br[2] = 11; T_br[3] = 12; T_br[4] = 22;
                    rot = -1;
                }
                kodx = 0;
                kody = 0;
            }



            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        T_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        T_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        T_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 3)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        T_br[i] += 10;
                    kody++;
                }
            }
            T_blok = new Blok(T_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (crtaj_L)
            {
                crtaj_L = false;
                grid.tocno[L_br[0]] = false;
                grid.tocno[L_br[1]] = false;
                grid.tocno[L_br[2]] = false;
                grid.tocno[L_br[3]] = false;
                grid.tocno[L_br[4]] = false;
            }

            L_br[0] = 0; L_br[1] = 10; L_br[2] = 20; L_br[3] = 30; L_br[4] = 31;
            L_blok = new Blok(L_br, mrda);
            kodx = 0; kody = 0; gran = 0; rot = 0;
            f = false; ZNAK = 'L';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
        }

        private void button7_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F))
            {
                gran = 0;
                if (f == false)
                {
                    f = true;
                    if (rot == 0)
                    {
                        L_br[0] = 1; L_br[1] = 11; L_br[2] = 21; L_br[3] = 30; L_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 2; L_br[3] = 3; L_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 10; L_br[3] = 20; L_br[4] = 30;
                    }
                    else if (rot == -1)
                    {
                        L_br[0] = 0; L_br[1] = 10; L_br[2] = 11; L_br[3] = 12; L_br[4] = 13;
                        gran = 2;
                    }
                }
                else if (f == true)
                {
                    f = false;
                    if (rot == 0)
                    {
                        L_br[0] = 0; L_br[1] = 10; L_br[2] = 20; L_br[3] = 30; L_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        L_br[0] = 3; L_br[1] = 10; L_br[2] = 11; L_br[3] = 12; L_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 11; L_br[3] = 21; L_br[4] = 31;
                    }
                    else if (rot == -1)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 2; L_br[3] = 3; L_br[4] = 10;
                        gran = 2;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (e.KeyCode.Equals(Keys.R))
            {
                rot++;
                gran = 0;
                if (f == false)
                {
                    if (rot == 0)
                    {
                        L_br[0] = 0; L_br[1] = 10; L_br[2] = 20; L_br[3] = 30; L_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        L_br[0] = 3; L_br[1] = 10; L_br[2] = 11; L_br[3] = 12; L_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 11; L_br[3] = 21; L_br[4] = 31;
                    }
                    else if (rot == 3)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 2; L_br[3] = 3; L_br[4] = 10;
                        gran = 2; rot = -1;
                    }
                }
                else if (f == true)
                {
                    if (rot == 0)
                    {
                        L_br[0] = 1; L_br[1] = 11; L_br[2] = 21; L_br[3] = 30; L_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 2; L_br[3] = 3; L_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        L_br[0] = 0; L_br[1] = 1; L_br[2] = 10; L_br[3] = 20; L_br[4] = 30;
                    }
                    else if (rot == 3)
                    {
                        L_br[0] = 0; L_br[1] = 10; L_br[2] = 11; L_br[3] = 12; L_br[4] = 13;
                        gran = 2; rot = -1;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        L_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 8 - gran)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        L_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        L_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 2 + gran)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        L_br[i] += 10;
                    kody++;
                }
            }
            L_blok = new Blok(L_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
        }

        private void button13_Click(object sender, EventArgs e)
        {
            if (crtaj_W)
            {
                crtaj_W = false;
                grid.tocno[W_br[0]] = false;
                grid.tocno[W_br[1]] = false;
                grid.tocno[W_br[2]] = false;
                grid.tocno[W_br[3]] = false;
                grid.tocno[W_br[4]] = false;
            }

            W_br[0] = 0; W_br[1] = 10; W_br[2] = 11; W_br[3] = 21; W_br[4] = 22;
            W_blok = new Blok(W_br, mrda);
            kodx = 0; kody = 0;
            ZNAK = 'W';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
        }

        private void button13_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.R))
            {
                rot++;
                if (rot == 0)
                {
                    W_br[0] = 0; W_br[1] = 10; W_br[2] = 11; W_br[3] = 21; W_br[4] = 22;
                }
                else if (rot == 1)
                {
                    W_br[0] = 2; W_br[1] = 11; W_br[2] = 12; W_br[3] = 20; W_br[4] = 21;
                }
                else if (rot == 2)
                {
                    W_br[0] = 0; W_br[1] = 1; W_br[2] = 11; W_br[3] = 12; W_br[4] = 22;
                }
                else if (rot == 3)
                {
                    W_br[0] = 1; W_br[1] = 2; W_br[2] = 10; W_br[3] = 11; W_br[4] = 20;
                    rot = -1;
                }
                kodx = 0;
                kody = 0;
            }



            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        W_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        W_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        W_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 3)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        W_br[i] += 10;
                    kody++;
                }
            }
            W_blok = new Blok(W_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));

        }

        private void button12_Click(object sender, EventArgs e)
        {
            if (crtaj_Z)
            {
                crtaj_Z = false;
                grid.tocno[Z_br[0]] = false;
                grid.tocno[Z_br[1]] = false;
                grid.tocno[Z_br[2]] = false;
                grid.tocno[Z_br[3]] = false;
                grid.tocno[Z_br[4]] = false;
            }

            Z_br[0] = 0; Z_br[1] = 1; Z_br[2] = 11; Z_br[3] = 21; Z_br[4] = 22;
            Z_blok = new Blok(Z_br, mrda);
            prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            kodx = 0; kody = 0;
            f = false; r = false; ZNAK = 'Z';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
        }

        private void button12_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F))
            {
                if (f == false)
                {
                    f = true;
                    if (r == false)
                    {
                        Z_br[0] = 1; Z_br[1] = 2; Z_br[2] = 11; Z_br[3] = 20; Z_br[4] = 21;
                    }
                    else if (r == true)
                    {
                        Z_br[0] = 0; Z_br[1] = 10; Z_br[2] = 11; Z_br[3] = 12; Z_br[4] = 22;
                    }
                }
                else if (f == true)
                {
                    f = false;
                    if (r == false)
                    {
                        Z_br[0] = 0; Z_br[1] = 1; Z_br[2] = 11; Z_br[3] = 21; Z_br[4] = 22;
                    }
                    else if (r == true)
                    {
                        Z_br[0] = 2; Z_br[1] = 10; Z_br[2] = 11; Z_br[3] = 12; Z_br[4] = 20;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (e.KeyCode.Equals(Keys.R))
            {
                if (r == false)
                {
                    r = true;
                    if (f == false)
                    {
                        Z_br[0] = 2; Z_br[1] = 10; Z_br[2] = 11; Z_br[3] = 12; Z_br[4] = 20;
                    }
                    else if (f == true)
                    {
                        Z_br[0] = 0; Z_br[1] = 10; Z_br[2] = 11; Z_br[3] = 12; Z_br[4] = 22;
                    }
                }
                else if (r == true)
                {
                    r = false;
                    if (f == false)
                    {
                        Z_br[0] = 0; Z_br[1] = 1; Z_br[2] = 11; Z_br[3] = 21; Z_br[4] = 22;
                    }
                    else if (f == true)
                    {
                        Z_br[0] = 1; Z_br[1] = 2; Z_br[2] = 11; Z_br[3] = 20; Z_br[4] = 21;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        Z_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        Z_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        Z_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 3)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        Z_br[i] += 10;
                    kody++;
                }
            }
            Z_blok = new Blok(Z_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (crtaj_F)
            {
                crtaj_F = false;
                grid.tocno[F_br[0]] = false;
                grid.tocno[F_br[1]] = false;
                grid.tocno[F_br[2]] = false;
                grid.tocno[F_br[3]] = false;
                grid.tocno[F_br[4]] = false;
            }

            F_br[0] = 0; F_br[1] = 1; F_br[2] = 11; F_br[3] = 12; F_br[4] = 21;
            F_blok = new Blok(F_br, mrda);
            kodx = 0; kody = 0; rot = 0;
            f = false; ZNAK = 'F';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
        }

        private void button11_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F))
            {
                if (f == false)
                {
                    f = true;
                    if (rot == 0)
                    {
                        F_br[0] = 1; F_br[1] = 2; F_br[2] = 10; F_br[3] = 11; F_br[4] = 21;
                    }
                    else if (rot == 1)
                    {
                        F_br[0] = 0; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 21;
                    }
                    else if (rot == 2)
                    {
                        F_br[0] = 1; F_br[1] = 11; F_br[2] = 12; F_br[3] = 20; F_br[4] = 21;
                    }
                    else if (rot == -1)
                    {
                        F_br[0] = 1; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 22;
                    }
                }
                else if (f == true)
                {
                    f = false;
                    if (rot == 0)
                    {
                        F_br[0] = 0; F_br[1] = 1; F_br[2] = 11; F_br[3] = 12; F_br[4] = 21;
                    }
                    else if (rot == 1)
                    {
                        F_br[0] = 1; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 20;
                    }
                    else if (rot == 2)
                    {
                        F_br[0] = 1; F_br[1] = 10; F_br[2] = 11; F_br[3] = 21; F_br[4] = 22;
                    }
                    else if (rot == -1)
                    {
                        F_br[0] = 2; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 21;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (e.KeyCode.Equals(Keys.R))
            {
                rot++;
                if (f == false)
                {
                    if (rot == 0)
                    {
                        F_br[0] = 0; F_br[1] = 1; F_br[2] = 11; F_br[3] = 12; F_br[4] = 21;
                    }
                    else if (rot == 1)
                    {
                        F_br[0] = 1; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 20;
                    }
                    else if (rot == 2)
                    {
                        F_br[0] = 1; F_br[1] = 10; F_br[2] = 11; F_br[3] = 21; F_br[4] = 22;
                    }
                    else if (rot == 3)
                    {
                        F_br[0] = 2; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 21;
                        rot = -1;
                    }
                }
                else if (f == true)
                {
                    if (rot == 0)
                    {
                        F_br[0] = 1; F_br[1] = 2; F_br[2] = 10; F_br[3] = 11; F_br[4] = 21;
                    }
                    else if (rot == 1)
                    {
                        F_br[0] = 0; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 21;
                    }
                    else if (rot == 2)
                    {
                        F_br[0] = 1; F_br[1] = 11; F_br[2] = 12; F_br[3] = 20; F_br[4] = 21;
                    }
                    else if (rot == 3)
                    {
                        F_br[0] = 1; F_br[1] = 10; F_br[2] = 11; F_br[3] = 12; F_br[4] = 22;
                        rot = -1;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        F_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        F_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        F_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 3)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        F_br[i] += 10;
                    kody++;
                }
            }
            F_blok = new Blok(F_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (crtaj_S)
            {
                crtaj_S = false;
                grid.tocno[S_br[0]] = false;
                grid.tocno[S_br[1]] = false;
                grid.tocno[S_br[2]] = false;
                grid.tocno[S_br[3]] = false;
                grid.tocno[S_br[4]] = false;
            }

            S_br[0] = 1; S_br[1] = 10; S_br[2] = 11; S_br[3] = 20; S_br[4] = 30;
            S_blok = new Blok(S_br, mrda);
            kodx = 0; kody = 0; gran = 0; rot = 0;
            f = false; ZNAK = 'S';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
        }

        private void button10_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F))
            {
                gran = 0;
                if (f == false)
                {
                    f = true;
                    if (rot == 0)
                    {
                        S_br[0] = 0; S_br[1] = 10; S_br[2] = 11; S_br[3] = 21; S_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        S_br[0] = 1; S_br[1] = 2; S_br[2] = 3; S_br[3] = 10; S_br[4] = 11;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        S_br[0] = 0; S_br[1] = 10; S_br[2] = 20; S_br[3] = 21; S_br[4] = 31;
                    }
                    else if (rot == -1)
                    {
                        S_br[0] = 2; S_br[1] = 3; S_br[2] = 10; S_br[3] = 11; S_br[4] = 12;
                        gran = 2;
                    }
                }
                else if (f == true)
                {
                    f = false;
                    if (rot == 0)
                    {
                        S_br[0] = 1; S_br[1] = 10; S_br[2] = 11; S_br[3] = 20; S_br[4] = 30;
                    }
                    else if (rot == 1)
                    {
                        S_br[0] = 0; S_br[1] = 1; S_br[2] = 11; S_br[3] = 12; S_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        S_br[0] = 1; S_br[1] = 11; S_br[2] = 20; S_br[3] = 21; S_br[4] = 30;
                    }
                    else if (rot == -1)
                    {
                        S_br[0] = 0; S_br[1] = 1; S_br[2] = 2; S_br[3] = 12; S_br[4] = 13;
                        gran = 2;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (e.KeyCode.Equals(Keys.R))
            {
                rot++;
                gran = 0;
                if (f == false)
                {
                    if (rot == 0)
                    {
                        S_br[0] = 1; S_br[1] = 10; S_br[2] = 11; S_br[3] = 20; S_br[4] = 30;
                    }
                    else if (rot == 1)
                    {
                        S_br[0] = 0; S_br[1] = 1; S_br[2] = 11; S_br[3] = 12; S_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        S_br[0] = 1; S_br[1] = 11; S_br[2] = 20; S_br[3] = 21; S_br[4] = 30;
                    }
                    else if (rot == 3)
                    {
                        S_br[0] = 0; S_br[1] = 1; S_br[2] = 2; S_br[3] = 12; S_br[4] = 13;
                        gran = 2; rot = -1;
                    }
                }
                else if (f == true)
                {
                    if (rot == 0)
                    {
                        S_br[0] = 0; S_br[1] = 10; S_br[2] = 11; S_br[3] = 21; S_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        S_br[0] = 1; S_br[1] = 2; S_br[2] = 3; S_br[3] = 10; S_br[4] = 11;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        S_br[0] = 0; S_br[1] = 10; S_br[2] = 20; S_br[3] = 21; S_br[4] = 31;
                    }
                    else if (rot == 3)
                    {
                        S_br[0] = 2; S_br[1] = 3; S_br[2] = 10; S_br[3] = 11; S_br[4] = 12;
                        gran = 2; rot = -1;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        S_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 8 - gran)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        S_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        S_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 2 + gran)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        S_br[i] += 10;
                    kody++;
                }
            }
            S_blok = new Blok(S_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (crtaj_G)
            {
                crtaj_G = false;
                grid.tocno[G_br[0]] = false;
                grid.tocno[G_br[1]] = false;
                grid.tocno[G_br[2]] = false;
                grid.tocno[G_br[3]] = false;
                grid.tocno[G_br[4]] = false;
            }

            G_br[0] = 0; G_br[1] = 1; G_br[2] = 2; G_br[3] = 10; G_br[4] = 20;
            G_blok = new Blok(G_br, mrda);
            kodx = 0; kody = 0;
            ZNAK = 'G';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_P)
            {
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
                button8.Enabled = false;
            }
            prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
        }

        private void button9_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.R))
            {
                rot++;
                if (rot == 0)
                {
                    G_br[0] = 0; G_br[1] = 1; G_br[2] = 2; G_br[3] = 10; G_br[4] = 20;
                }
                else if (rot == 1)
                {
                    G_br[0] = 0; G_br[1] = 10; G_br[2] = 20; G_br[3] = 21; G_br[4] = 22;
                }
                else if (rot == 2)
                {
                    G_br[0] = 2; G_br[1] = 12; G_br[2] = 20; G_br[3] = 21; G_br[4] = 22;
                }
                else if (rot == 3)
                {
                    G_br[0] = 0; G_br[1] = 1; G_br[2] = 2; G_br[3] = 12; G_br[4] = 22;
                    rot = -1;
                }
                kodx = 0;
                kody = 0;
            }



            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        G_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 7)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        G_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        G_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 3)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        G_br[i] += 10;
                    kody++;
                }
            }
            G_blok = new Blok(G_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
            prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (crtaj_P)
            {
                crtaj_P = false;
                grid.tocno[P_br[0]] = false;
                grid.tocno[P_br[1]] = false;
                grid.tocno[P_br[2]] = false;
                grid.tocno[P_br[3]] = false;
                grid.tocno[P_br[4]] = false;
            }

            P_br[0] = 0; P_br[1] = 10; P_br[2] = 11; P_br[3] = 20; P_br[4] = 30;
            P_blok = new Blok(P_br, mrda);
            kodx = 0; kody = 0; gran = 0; rot = 0;
            f = false; ZNAK = 'P';
            prav.Clear(Color.White);
            if (crtaj_X)
            {
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
                button5.Enabled = false;
            }
            if (crtaj_B)
            {
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
                button3.Enabled = false;
            }
            if (crtaj_C)
            {
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
                button4.Enabled = false;
            }
            if (crtaj_I)
            {
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
                button2.Enabled = false;
            }
            if (crtaj_T)
            {
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
                button6.Enabled = false;
            }
            if (crtaj_L)
            {
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
                button7.Enabled = false;
            }
            if (crtaj_W)
            {
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
                button13.Enabled = false;
            }
            if (crtaj_Z)
            {
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
                button12.Enabled = false;
            }
            if (crtaj_F)
            {
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
                button11.Enabled = false;
            }
            if (crtaj_S)
            {
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
                button10.Enabled = false;
            }
            if (crtaj_G)
            {
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
                button9.Enabled = false;
            }
            prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
        }

        private void button8_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.F))
            {
                gran = 0;
                if (f == false)
                {
                    f = true;
                    if (rot == 0)
                    {
                        P_br[0] = 1; P_br[1] = 10; P_br[2] = 11; P_br[3] = 21; P_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        P_br[0] = 0; P_br[1] = 1; P_br[2] = 2; P_br[3] = 3; P_br[4] = 11;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        P_br[0] = 0; P_br[1] = 10; P_br[2] = 20; P_br[3] = 21; P_br[4] = 30;
                    }
                    else if (rot == -1)
                    {
                        P_br[0] = 2; P_br[1] = 10; P_br[2] = 11; P_br[3] = 12; P_br[4] = 13;
                        gran = 2;
                    }
                }
                else if (f == true)
                {
                    f = false;
                    if (rot == 0)
                    {
                        P_br[0] = 0; P_br[1] = 10; P_br[2] = 11; P_br[3] = 20; P_br[4] = 30;
                    }
                    else if (rot == 1)
                    {
                        P_br[0] = 1; P_br[1] = 10; P_br[2] = 11; P_br[3] = 12; P_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        P_br[0] = 1; P_br[1] = 11; P_br[2] = 20; P_br[3] = 21; P_br[4] = 31;
                    }
                    else if (rot == -1)
                    {
                        P_br[0] = 0; P_br[1] = 1; P_br[2] = 2; P_br[3] = 3; P_br[4] = 12;
                        gran = 2;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (e.KeyCode.Equals(Keys.R))
            {
                rot++;
                gran = 0;
                if (f == false)
                {
                    if (rot == 0)
                    {
                        P_br[0] = 0; P_br[1] = 10; P_br[2] = 11; P_br[3] = 20; P_br[4] = 30;
                    }
                    else if (rot == 1)
                    {
                        P_br[0] = 1; P_br[1] = 10; P_br[2] = 11; P_br[3] = 12; P_br[4] = 13;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        P_br[0] = 1; P_br[1] = 11; P_br[2] = 20; P_br[3] = 21; P_br[4] = 31;
                    }
                    else if (rot == 3)
                    {
                        P_br[0] = 0; P_br[1] = 1; P_br[2] = 2; P_br[3] = 3; P_br[4] = 12;
                        gran = 2; rot = -1;
                    }
                }
                else if (f == true)
                {
                    if (rot == 0)
                    {
                        P_br[0] = 1; P_br[1] = 10; P_br[2] = 11; P_br[3] = 21; P_br[4] = 31;
                    }
                    else if (rot == 1)
                    {
                        P_br[0] = 0; P_br[1] = 1; P_br[2] = 2; P_br[3] = 3; P_br[4] = 11;
                        gran = 2;
                    }
                    else if (rot == 2)
                    {
                        P_br[0] = 0; P_br[1] = 10; P_br[2] = 20; P_br[3] = 21; P_br[4] = 30;
                    }
                    else if (rot == 3)
                    {
                        P_br[0] = 2; P_br[1] = 10; P_br[2] = 11; P_br[3] = 12; P_br[4] = 13;
                        gran = 2; rot = -1;
                    }
                }
                kodx = 0; kody = 0;
            }

            if (kodx > 0)
            {
                if (e.KeyCode.Equals(Keys.A))
                {
                    for (int i = 0; i < 5; i++)
                        P_br[i]--;
                    kodx--;
                }
            }

            if (kodx < 8 - gran)
            {
                if (e.KeyCode.Equals(Keys.D))
                {
                    for (int i = 0; i < 5; i++)
                        P_br[i]++;
                    kodx++;
                }
            }

            if (kody > 0)
            {
                if (e.KeyCode.Equals(Keys.W))
                {
                    for (int i = 0; i < 5; i++)
                        P_br[i] -= 10;
                    kody--;
                }
            }

            if (kody < 2 + gran)
            {
                if (e.KeyCode.Equals(Keys.S))
                {
                    for (int i = 0; i < 5; i++)
                        P_br[i] += 10;
                    kody++;
                }
            }
            P_blok = new Blok(P_br, mrda);
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));
        }

        private void button14_Click(object sender, EventArgs e)
        {

            if (ZNAK.Equals('X'))
            {
                mrda.tocno[X_br[0]] = true;
                mrda.tocno[X_br[1]] = true;
                mrda.tocno[X_br[2]] = true;
                mrda.tocno[X_br[3]] = true;
                mrda.tocno[X_br[4]] = true;
            }
            else if (ZNAK.Equals('B'))
            {
                mrda.tocno[B_br[0]] = true;
                mrda.tocno[B_br[1]] = true;
                mrda.tocno[B_br[2]] = true;
                mrda.tocno[B_br[3]] = true;
                mrda.tocno[B_br[4]] = true;
            }
            else if (ZNAK.Equals('C'))
            {
                mrda.tocno[C_br[0]] = true;
                mrda.tocno[C_br[1]] = true;
                mrda.tocno[C_br[2]] = true;
                mrda.tocno[C_br[3]] = true;
                mrda.tocno[C_br[4]] = true;
            }
            else if (ZNAK.Equals('I'))
            {
                mrda.tocno[I_br[0]] = true;
                mrda.tocno[I_br[1]] = true;
                mrda.tocno[I_br[2]] = true;
                mrda.tocno[I_br[3]] = true;
                mrda.tocno[I_br[4]] = true;
            }
            else if (ZNAK.Equals('T'))
            {
                mrda.tocno[T_br[0]] = true;
                mrda.tocno[T_br[1]] = true;
                mrda.tocno[T_br[2]] = true;
                mrda.tocno[T_br[3]] = true;
                mrda.tocno[T_br[4]] = true;
            }
            else if (ZNAK.Equals('L'))
            {
                mrda.tocno[L_br[0]] = true;
                mrda.tocno[L_br[1]] = true;
                mrda.tocno[L_br[2]] = true;
                mrda.tocno[L_br[3]] = true;
                mrda.tocno[L_br[4]] = true;
            }
            else if (ZNAK.Equals('W'))
            {
                mrda.tocno[W_br[0]] = true;
                mrda.tocno[W_br[1]] = true;
                mrda.tocno[W_br[2]] = true;
                mrda.tocno[W_br[3]] = true;
                mrda.tocno[W_br[4]] = true;
            }
            else if (ZNAK.Equals('Z'))
            {
                mrda.tocno[Z_br[0]] = true;
                mrda.tocno[Z_br[1]] = true;
                mrda.tocno[Z_br[2]] = true;
                mrda.tocno[Z_br[3]] = true;
                mrda.tocno[Z_br[4]] = true;
            }
            else if (ZNAK.Equals('F'))
            {
                mrda.tocno[F_br[0]] = true;
                mrda.tocno[F_br[1]] = true;
                mrda.tocno[F_br[2]] = true;
                mrda.tocno[F_br[3]] = true;
                mrda.tocno[F_br[4]] = true;
            }
            else if (ZNAK.Equals('S'))
            {
                mrda.tocno[S_br[0]] = true;
                mrda.tocno[S_br[1]] = true;
                mrda.tocno[S_br[2]] = true;
                mrda.tocno[S_br[3]] = true;
                mrda.tocno[S_br[4]] = true;
            }
            else if (ZNAK.Equals('G'))
            {
                mrda.tocno[G_br[0]] = true;
                mrda.tocno[G_br[1]] = true;
                mrda.tocno[G_br[2]] = true;
                mrda.tocno[G_br[3]] = true;
                mrda.tocno[G_br[4]] = true;
            }
            else if (ZNAK.Equals('P'))
            {
                mrda.tocno[P_br[0]] = true;
                mrda.tocno[P_br[1]] = true;
                mrda.tocno[P_br[2]] = true;
                mrda.tocno[P_br[3]] = true;
                mrda.tocno[P_br[4]] = true;
            }

            bool odgovor = grid.kontrola(mrda);
            
            if (odgovor)
            {

                if (ZNAK.Equals('X'))
                {
                    crtaj_X = true;
                    button5.Enabled = false;
                    grid.tocno[X_br[0]] = true;
                    grid.tocno[X_br[1]] = true;
                    grid.tocno[X_br[2]] = true;
                    grid.tocno[X_br[3]] = true;
                    grid.tocno[X_br[4]] = true;
                }
                else if (ZNAK.Equals('B'))
                {
                    crtaj_B = true;
                    button3.Enabled = false;
                    grid.tocno[B_br[0]] = true;
                    grid.tocno[B_br[1]] = true;
                    grid.tocno[B_br[2]] = true;
                    grid.tocno[B_br[3]] = true;
                    grid.tocno[B_br[4]] = true;
                }
                else if (ZNAK.Equals('C'))
                {
                    crtaj_C = true;
                    button4.Enabled = false;
                    grid.tocno[C_br[0]] = true;
                    grid.tocno[C_br[1]] = true;
                    grid.tocno[C_br[2]] = true;
                    grid.tocno[C_br[3]] = true;
                    grid.tocno[C_br[4]] = true;
                }
                else if (ZNAK.Equals('I'))
                {
                    crtaj_I = true;
                    button2.Enabled = false;
                    grid.tocno[I_br[0]] = true;
                    grid.tocno[I_br[1]] = true;
                    grid.tocno[I_br[2]] = true;
                    grid.tocno[I_br[3]] = true;
                    grid.tocno[I_br[4]] = true;
                }
                else if (ZNAK.Equals('T'))
                {
                    crtaj_T = true;
                    button6.Enabled = false;
                    grid.tocno[T_br[0]] = true;
                    grid.tocno[T_br[1]] = true;
                    grid.tocno[T_br[2]] = true;
                    grid.tocno[T_br[3]] = true;
                    grid.tocno[T_br[4]] = true;
                }
                else if (ZNAK.Equals('L'))
                {
                    crtaj_L = true;
                    button7.Enabled = false;
                    grid.tocno[L_br[0]] = true;
                    grid.tocno[L_br[1]] = true;
                    grid.tocno[L_br[2]] = true;
                    grid.tocno[L_br[3]] = true;
                    grid.tocno[L_br[4]] = true;
                }
                else if (ZNAK.Equals('W'))
                {
                    crtaj_W = true;
                    button13.Enabled = false;
                    grid.tocno[W_br[0]] = true;
                    grid.tocno[W_br[1]] = true;
                    grid.tocno[W_br[2]] = true;
                    grid.tocno[W_br[3]] = true;
                    grid.tocno[W_br[4]] = true;
                }
                else if (ZNAK.Equals('Z'))
                {
                    crtaj_Z = true;
                    button12.Enabled = false;
                    grid.tocno[Z_br[0]] = true;
                    grid.tocno[Z_br[1]] = true;
                    grid.tocno[Z_br[2]] = true;
                    grid.tocno[Z_br[3]] = true;
                    grid.tocno[Z_br[4]] = true;
                }
                else if (ZNAK.Equals('F'))
                {
                    crtaj_F = true;
                    button11.Enabled = false;
                    grid.tocno[F_br[0]] = true;
                    grid.tocno[F_br[1]] = true;
                    grid.tocno[F_br[2]] = true;
                    grid.tocno[F_br[3]] = true;
                    grid.tocno[F_br[4]] = true;
                }
                else if (ZNAK.Equals('S'))
                {
                    crtaj_S = true;
                    button10.Enabled = false;
                    grid.tocno[S_br[0]] = true;
                    grid.tocno[S_br[1]] = true;
                    grid.tocno[S_br[2]] = true;
                    grid.tocno[S_br[3]] = true;
                    grid.tocno[S_br[4]] = true;
                }
                else if (ZNAK.Equals('G'))
                {
                    crtaj_G = true;
                    button9.Enabled = false;
                    grid.tocno[G_br[0]] = true;
                    grid.tocno[G_br[1]] = true;
                    grid.tocno[G_br[2]] = true;
                    grid.tocno[G_br[3]] = true;
                    grid.tocno[G_br[4]] = true;
                }
                else if (ZNAK.Equals('P'))
                {
                    crtaj_P = true;
                    button8.Enabled = false;
                    grid.tocno[P_br[0]] = true;
                    grid.tocno[P_br[1]] = true;
                    grid.tocno[P_br[2]] = true;
                    grid.tocno[P_br[3]] = true;
                    grid.tocno[P_br[4]] = true;
                }

                int pobeda=0;
                for (int j = 0; j < 60; j++)
                {
                    if (grid.tocno[j])
                        pobeda++;
                    if (pobeda == 60)
                    {
                        MessageBox.Show("Честитки на успешно завршената игра !!!", "Крај на играта", 
                            MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                        ZNAK = ' ';
                        for (int i = 0; i < 60; i++)
                        {
                            mrda.tocno[i] = false;
                            grid.tocno[i] = false;
                        }
                        crtaj_X = false;
                        crtaj_B = false;
                        crtaj_C = false;
                        crtaj_I = false;
                        crtaj_T = false;
                        crtaj_L = false;
                        crtaj_W = false;
                        crtaj_Z = false;
                        crtaj_F = false;
                        crtaj_S = false;
                        crtaj_G = false;
                        crtaj_P = false;
                        button2.Enabled = true;
                        button3.Enabled = true;
                        button4.Enabled = true;
                        button5.Enabled = true;
                        button6.Enabled = true;
                        button7.Enabled = true;
                        button8.Enabled = true;
                        button9.Enabled = true;
                        button10.Enabled = true;
                        button11.Enabled = true;
                        button12.Enabled = true;
                        button13.Enabled = true;
                        prav.Clear(Color.White);
                    }
                }

            }
            else
            {
                MessageBox.Show("Не е дозволено две фигури да се преклопуваат.","Недозволена постапка",
                    MessageBoxButtons.OK,MessageBoxIcon.Stop);
                odgovor = true;
            }

            for (int i = 0; i < 60; i++)
            {
                mrda.tocno[i] = false;
            }
            
        }

        private void button15_Click(object sender, EventArgs e)
        {
            prav.Clear(Color.White);
            if (crtaj_X)
                prav.FillRectangles(drap, X_blok.nizaPravoagolnici(X_blok));
            if (crtaj_B)
                prav.FillRectangles(crven, B_blok.nizaPravoagolnici(B_blok));
            if (crtaj_C)
                prav.FillRectangles(safari, C_blok.nizaPravoagolnici(C_blok));
            if (crtaj_I)
                prav.FillRectangles(zelen, I_blok.nizaPravoagolnici(I_blok));
            if (crtaj_T)
                prav.FillRectangles(zolt, T_blok.nizaPravoagolnici(T_blok));
            if (crtaj_L)
                prav.FillRectangles(plav, L_blok.nizaPravoagolnici(L_blok));
            if (crtaj_W)
                prav.FillRectangles(tirkiz, W_blok.nizaPravoagolnici(W_blok));
            if (crtaj_Z)
                prav.FillRectangles(lila, Z_blok.nizaPravoagolnici(Z_blok));
            if (crtaj_F)
                prav.FillRectangles(trava, F_blok.nizaPravoagolnici(F_blok));
            if (crtaj_S)
                prav.FillRectangles(zlato, S_blok.nizaPravoagolnici(S_blok));
            if (crtaj_G)
                prav.FillRectangles(cigla, G_blok.nizaPravoagolnici(G_blok));
            if (crtaj_P)
                prav.FillRectangles(roze, P_blok.nizaPravoagolnici(P_blok));

            MessageBox.Show("Изберете со кликање врз некое од дванаесте копчиња,"+"\n"+
                            "која фигура сакате да ја избришете од платното.","Избриши фигура од платното",
                            MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
        }

        private void button17_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Одбравте дека сакате да започнете нова игра.","Нова игра",MessageBoxButtons.OK,MessageBoxIcon.Asterisk);
            ZNAK = ' ';
            for (int i = 0; i < 60; i++)
            {
                mrda.tocno[i] = false;
                grid.tocno[i] = false;
            }
            crtaj_X = false;
            crtaj_B = false;
            crtaj_C = false;
            crtaj_I = false;
            crtaj_T = false;
            crtaj_L = false;
            crtaj_W = false;
            crtaj_Z = false;
            crtaj_F = false;
            crtaj_S = false;
            crtaj_G = false;
            crtaj_P = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
            button9.Enabled = true;
            button10.Enabled = true;
            button11.Enabled = true;
            button12.Enabled = true;
            button13.Enabled = true;
            prav.Clear(Color.White);
        }

        private void button16_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button18_Click(object sender, EventArgs e)
        {
            String izvesti = "Целта на играта е:" + "\n" +
                "Уфрлете фигура на платното со притискање на едно од дванаесте копчиња"+ "\n" +
                "поставени од десната страна на прозорецот."+ "\n" +
                "Движете ги фигурите со притискање на типките од тастатурата: за горе(up) W," + "\n" +
                "за доле(down) S, за десно(right) D и за лево(left) A." + "\n" +
                "Типките ротација(rotate) R и преврти(flip, roll) S се истотака корисни." + "\n" +
                "Запишете ги сите дванаесет фигури во предвидениот простор на платното но"+ "\n" +
                "не дозволувајте да Ви се преклопуваат т.е. најдете им го вистинското место.";
            MessageBox.Show(izvesti,"Правила на играта",MessageBoxButtons.OK);
        }
    }
}
