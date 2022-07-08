using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Array point1;
        public Array point2;
        public Array point3;
        public Array point4;
        public int[] pointS1;
        public int[] pointS2;
        public int[] pointS3;
        public int[] pointS4;

        public float[] pointSf1;
        public float[] pointSf2;
        public float[] pointSf3;
        public float[] pointSf4;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label18_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        internal void show()
        {
            throw new NotImplementedException();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label23_Click(object sender, EventArgs e)
        {

        }

        private int[] OverXY(int x, int y , int z) { 
            
            
            int[] result = {x,y,-z};
            return result; 
        }
        private int[] OverXZ(int x, int y, int z)
        {
            int[] result = { x, -y, z };
            return result;
        }
        private int[] OverYZ(int x, int y, int z)
        {

            int[] result = { -x, y, z };
            return result;
        }

     

    
       

        private void textBox13_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }
        private int[] point3dArray(int x, int y, int z)
        {
            int[] arry3d = { x, y, z };
            return arry3d;
        }

        private int[] point3dT(int x, int y, int z, int T1, int T2, int T3)
        {
            int[] arry3d = { (x + T1), (y + T2), (z + T3) };

            return arry3d;
        }

        private void showN(int[] point1T, int[] point2T, int[] point3T, int[] point4T)
        {

            Npoint1.Text = "(" + point1T[0] + "," + point1T[1] + "," + point1T[2] + ")";
            Npoint2.Text = "(" + point2T[0] + "," + point2T[1] + "," + point2T[2] + ")";
            Npoint3.Text = "(" + point3T[0] + "," + point3T[1] + "," + point3T[2] + ")";
            Npoint4.Text = "(" + point4T[0] + "," + point4T[1] + "," + point4T[2] + ")";

        }

        private void showN(float[] point1T, float[] point2T, float[] point3T, float[] point4T)
        {

            Npoint1.Text = "(" + point1T[0] + "," + point1T[1] + "," + point1T[2] + ")";
            Npoint2.Text = "(" + point2T[0] + "," + point2T[1] + "," + point2T[2] + ")";
            Npoint3.Text = "(" + point3T[0] + "," + point3T[1] + "," + point3T[2] + ")";
            Npoint4.Text = "(" + point4T[0] + "," + point4T[1] + "," + point4T[2] + ")";

        }
        private void showN(int[] point1T)
        {
            Npoint1.Text = "(" + point1T[0] + "," + point1T[1] + "," + point1T[2] + ")";
        }
        private void Transtion_button_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    int Tx = int.Parse(T1.Text);
                    int Ty = int.Parse(T2.Text);
                    int Tz = int.Parse(T3.Text);
                    int[] point1T = point3dT(x1, y1, z1, Tx, Ty, Tz);
                    int[] point2T = point3dT(x2, y2, z2, Tx, Ty, Tz);
                    int[] point3T = point3dT(x3, y3, z3, Tx, Ty, Tz);
                    int[] point4T = point3dT(x4, y4, z4, Tx, Ty, Tz);
                    pointS1 = point1T;
                    pointS2 = point2T;
                    pointS3 = point3T;
                    pointS4 = point4T;
                    showN(point1T, point2T, point3T, point4T);
                }
                else
                {
                    int Tx = int.Parse(T1.Text);
                    int Ty = int.Parse(T2.Text);
                    int Tz = int.Parse(T3.Text);
                    int[] point1T = point3dT(pointS1[0], pointS1[1], pointS1[2], Tx, Ty, Tz);
                    int[] point2T = point3dT(pointS2[0], pointS2[1], pointS2[2], Tx, Ty, Tz);
                    int[] point3T = point3dT(pointS3[0], pointS3[1], pointS3[2], Tx, Ty, Tz);
                    int[] point4T = point3dT(pointS4[0], pointS4[1], pointS4[2], Tx, Ty, Tz);
                    pointS1 = point1T;
                    pointS2 = point2T;
                    pointS3 = point3T;
                    pointS4 = point4T;
                    showN(point1T, point2T, point3T, point4T);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Npoint1.Clear();
            Npoint2.Clear();
            Npoint3.Clear();
            Npoint4.Clear();
        }

        private void T2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged_1(object sender, EventArgs e)
        {

        }
        private int[] point3dS(int x, int y, int z, int T1, int T2, int T3)
        {
            int[] arry3d = { (x * T1), (y * T2), (z * T3) };

            return arry3d;
        }
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    int Tx = int.Parse(T1.Text);
                    int Ty = int.Parse(T2.Text);
                    int Tz = int.Parse(T3.Text);
                    int[] point1S = point3dS(x1, y1, z1, Tx, Ty, Tz);
                    int[] point2S = point3dS(x2, y2, z2, Tx, Ty, Tz);
                    int[] point3S = point3dS(x3, y3, z3, Tx, Ty, Tz);
                    int[] point4S = point3dS(x4, y4, z4, Tx, Ty, Tz);
                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);
                }
                else
                {
                    int Tx = int.Parse(T1.Text);
                    int Ty = int.Parse(T2.Text);
                    int Tz = int.Parse(T3.Text);
                    int[] point1S = point3dS(pointS1[0], pointS1[1], pointS1[2], Tx, Ty, Tz);
                    int[] point2S = point3dS(pointS2[0], pointS2[1], pointS2[2], Tx, Ty, Tz);
                    int[] point3S = point3dS(pointS3[0], pointS3[1], pointS3[2], Tx, Ty, Tz);
                    int[] point4S = point3dS(pointS4[0], pointS4[1], pointS4[2], Tx, Ty, Tz);
                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }

        private void Angle(object sender, EventArgs e)
        {

        }

        private float[] point3dRX(float x, float y, float z)
        {
             int angle = int.Parse(BoxAngle.Text);
            float X = (float)x;
            float Y = (float)(y * Math.Cos(angle) - z * Math.Sin(angle));
            float Z =(float)(y*Math.Sin(angle) +z*Math.Cos(angle));
            float[] arry3d = {X ,Y ,Z};
            return arry3d;
        }
        private float[] point3dRY(float x, float y, float z)
        {
            int angle = int.Parse(BoxAngle.Text);
            float X = (float)(x*Math.Cos(angle) +z*Math.Sin(angle));
            float Y = (float)(y);
            float Z = (float)(-x*Math.Sin(angle) + z * Math.Cos(angle));
            float[] arry3d = { X, Y, Z };
            return arry3d;
        }
        private float[] point3dRZ(float x, float y, float z)
        {
            int angle = int.Parse(BoxAngle.Text);
            float X = (float)(x * Math.Cos(angle) - y * Math.Sin(angle));
            float Y = (float)(x * Math.Sin(angle) + y * Math.Cos(angle));
            float Z = (float)(x * Math.Sin(angle) + y * Math.Cos(angle));
            float[] arry3d = { X, Y, Z };
            return arry3d;
        }
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    float[] point1S = point3dRX(x1, y1, z1);
                    float[] point2S = point3dRX(x2, y2, z2);
                    float[] point3S = point3dRX(x3, y3, z3);
                    float[] point4S = point3dRX(x4, y4, z4);
                    pointSf1 = point1S;
                    pointSf2 = point2S;
                    pointSf3 = point3S;
                    pointSf4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }
                else {
                    float[] point1S = point3dRX(pointSf1[0], pointSf1[1], pointSf1[2]);
                    float[] point2S = point3dRX(pointSf2[0], pointSf2[1], pointSf2[2]);
                    float[] point3S = point3dRX(pointSf3[0], pointSf3[1], pointSf1[2]);
                    float[] point4S = point3dRX(pointSf4[0], pointSf4[1], pointSf4[2]);

                    pointSf1 = point1S;
                    pointSf2 = point2S;
                    pointSf3 = point3S;
                    pointSf4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }
                
            
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }

     
        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    float[] point1S = point3dRY(x1, y1, z1);
                    float[] point2S = point3dRY(x2, y2, z2);
                    float[] point3S = point3dRY(x3, y3, z3);
                    float[] point4S = point3dRY(x4, y4, z4);
                    pointSf1 = point1S;
                    pointSf2 = point2S;
                    pointSf3 = point3S;
                    pointSf4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }
                else
                {
                    float[] point1S = point3dRY(pointSf1[0], pointSf1[1], pointSf1[2]);
                    float[] point2S = point3dRY(pointSf2[0], pointSf2[1], pointSf2[2]);
                    float[] point3S = point3dRY(pointSf3[0], pointSf3[1], pointSf1[2]);
                    float[] point4S = point3dRY(pointSf4[0], pointSf4[1], pointSf4[2]);
                    pointSf1 = point1S;
                    pointSf2 = point2S;
                    pointSf3 = point3S;
                    pointSf4 = point4S;
                    showN(point1S, point2S, point3S, point4S);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    float[] point1S = point3dRZ(x1, y1, z1);
                    float[] point2S = point3dRZ(x2, y2, z2);
                    float[] point3S = point3dRZ(x3, y3, z3);
                    float[] point4S = point3dRZ(x4, y4, z4);
                    pointSf1 = point1S;
                    pointSf2 = point2S;
                    pointSf3 = point3S;
                    pointSf4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }
                else
                {
                    float[] point1S = point3dRZ(pointSf1[0], pointSf1[1], pointSf1[2]);
                    float[] point2S = point3dRZ(pointSf2[0], pointSf2[1], pointSf2[2]);
                    float[] point3S = point3dRZ(pointSf3[0], pointSf3[1], pointSf1[2]);
                    float[] point4S = point3dRZ(pointSf4[0], pointSf4[1], pointSf4[2]);

                    pointSf1 = point1S;
                    pointSf2 = point2S;
                    pointSf3 = point3S;
                    pointSf4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    int[] point1S = OverXY(x1, y1, z1);
                    int[] point2S = OverXY(x2, y2, z2);
                    int[] point3S = OverXY(x3, y3, z3);
                    int[] point4S = OverXY(x4, y4, z4);
                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }
                else
                {
                    int[] point1S = OverXY(pointS1[0], pointS1[1], pointS1[2]);
                    int[] point2S = OverXY(pointS2[0], pointS2[1], pointS2[2]);
                    int[] point3S = OverXY(pointS3[0], pointS3[1], pointS1[2]);
                    int[] point4S = OverXY(pointS4[0], pointS4[1], pointS4[2]);

                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    int[] point1S = OverYZ(x1, y1, z1);
                    int[] point2S = OverYZ(x2, y2, z2);
                    int[] point3S = OverYZ(x3, y3, z3);
                    int[] point4S = OverYZ(x4, y4, z4);
                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }
                else
                {
                    int[] point1S = OverYZ(pointS1[0], pointS1[1], pointS1[2]);
                    int[] point2S = OverYZ(pointS2[0], pointS2[1], pointS2[2]);
                    int[] point3S = OverYZ(pointS3[0], pointS3[1], pointS1[2]);
                    int[] point4S = OverYZ(pointS4[0], pointS4[1], pointS4[2]);

                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }


        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int x2 = int.Parse(X2.Text);
                    int y2 = int.Parse(Y2.Text);
                    int z2 = int.Parse(Z2.Text);
                    point2 = point3dArray(x2, y2, z2);
                    int x3 = int.Parse(X3.Text);
                    int y3 = int.Parse(Y3.Text);
                    int z3 = int.Parse(Z3.Text);
                    point3 = point3dArray(x3, y3, z3);
                    int x4 = int.Parse(X4.Text);
                    int y4 = int.Parse(Y4.Text);
                    int z4 = int.Parse(Z4.Text);
                    point4 = point3dArray(x4, y4, z3);
                    int[] point1S = OverXZ(x1, y1, z1);
                    int[] point2S = OverXZ(x2, y2, z2);
                    int[] point3S = OverXZ(x3, y3, z3);
                    int[] point4S = OverXZ(x4, y4, z4);
                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }
                else
                {
                    int[] point1S = OverXZ(pointS1[0], pointS1[1], pointS1[2]);
                    int[] point2S = OverXZ(pointS2[0], pointS2[1], pointS2[2]);
                    int[] point3S = OverXZ(pointS3[0], pointS3[1], pointS1[2]);
                    int[] point4S = OverXZ(pointS4[0], pointS4[1], pointS4[2]);

                    pointS1 = point1S;
                    pointS2 = point2S;
                    pointS3 = point3S;
                    pointS4 = point4S;
                    showN(point1S, point2S, point3S, point4S);

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
    MessageBoxIcon.Warning
 );
            }
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

        private int[] SHX(int x, int y, int z, int shx, int shY, int shZ) {

            int X=x;
            int Y=y+shY*x;
            int Z =z+shZ*x;
            int[] result = { X, Y, Z };
            return result;

        }
        private int[] SHY(int x, int y, int z, int shx, int shY, int shZ)
        {

            int X = x+shx*y;
            int Y = y;
            int Z = z + shZ * y;
            int[] result = { X, Y, Z };
            return result;

        }
        private int[] SHZ(int x, int y, int z, int shx, int shY, int shZ)
        {

            int X = x +shx*z;
            int Y = y + shY * z;
            int Z = z ;
            int[] result = { X, Y, Z };
            return result;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int shx = int.Parse(textBox1.Text);
                    int shy = int.Parse(textBox2.Text);
                    int shz = int.Parse(textBox3.Text);
                    int[] point1S = SHX(x1, y1, z1, shx, shy, shz);
                    pointS1 = point1S;
                    showN(point1S);
                }
                else {
                    int shx = int.Parse(textBox1.Text);
                    int shy = int.Parse(textBox2.Text);
                    int shz = int.Parse(textBox3.Text);
                    int[] point1S = SHX(pointS1[0], pointS1[1], pointS1[2], shx, shy, shz);
                    pointS1 = point1S;
                    showN(point1S);
                }

            }
            catch (Exception ex) {

                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
        MessageBoxIcon.Warning
     );
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int shx = int.Parse(textBox1.Text);
                    int shy = int.Parse(textBox2.Text);
                    int shz = int.Parse(textBox3.Text);
                    int[] point1S = SHY(x1, y1, z1, shx, shy, shz);
                    pointS1 = point1S;
                    showN(point1S);
                }
                else
                {
                    int shx = int.Parse(textBox1.Text);
                    int shy = int.Parse(textBox2.Text);
                    int shz = int.Parse(textBox3.Text);
                    int[] point1S = SHY(pointS1[0], pointS1[1], pointS1[2], shx, shy, shz);
                    pointS1 = point1S;
                    showN(point1S);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
        MessageBoxIcon.Warning
     );
            }
        }

        private void textBox2_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_3(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (Npoint1.Text.Length == 0 && Npoint2.Text.Length == 0 && Npoint3.Text.Length == 0 && Npoint4.Text.Length == 0)
                {
                    int x1 = int.Parse(X1.Text);
                    int y1 = int.Parse(Y1.Text);
                    int z1 = int.Parse(Z1.Text);
                    point1 = point3dArray(x1, y1, z1);
                    int shx = int.Parse(textBox1.Text);
                    int shy = int.Parse(textBox2.Text);
                    int shz = int.Parse(textBox3.Text);
                    int[] point1S = SHZ(x1, y1, z1, shx, shy, shz);
                    pointS1 = point1S;
                    showN(point1S);
                }
                else
                {
                    int shx = int.Parse(textBox1.Text);
                    int shy = int.Parse(textBox2.Text);
                    int shz = int.Parse(textBox3.Text);
                    int[] point1S = SHZ(pointS1[0], pointS1[1], pointS1[2], shx, shy, shz);
                    pointS1 = point1S;
                    showN(point1S);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show("Error you have input empty and it's from requirement", "Erorr alarm", MessageBoxButtons.OK,
        MessageBoxIcon.Warning
     );
            }
        }
    }


}

