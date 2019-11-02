using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XLA_Project6_Fix
{
    public partial class Form1 : Form
    {
        Bitmap hinhgoc;
        Rectangle Rect;
        Point LocationX1Y1;//chứa giá trị vị trí X1, Y1 trên hình
        Point LocationX2Y2;//chứa giá trị vị trí X2, Y2 trên hình
        bool IsMouseDown = false;//check chuột đã được nhấn hay chưa, kéo thả giống paint
        bool IsMouseUp = false;//check chuột đã được thả hay chưa
        public Form1()
        {
            InitializeComponent();
            hinhgoc = new Bitmap(@"C:\Users\hoang\OneDrive\Máy tính\Image Processing\C#\lena_color.gif");
            pictureBox_hinhgoc.Image = hinhgoc;
        }

        private void pictureBox_hinhgoc_MouseDown(object sender, MouseEventArgs e)//event click chuột trái
        {
            IsMouseDown = true;
            LocationX1Y1 = e.Location;//lấy cặp vị trí X,Y của trỏ chuột trong hình, chính là vị trí (x,y) của pixel ngay trỏ chuột
            label_X1.Text = "X1: "+LocationX1Y1.X.ToString();//chuyển thành chuỗi để hiển thị
            label_Y1.Text = "Y1: "+LocationX1Y1.Y.ToString();
        }

        private void pictureBox_hinhgoc_MouseMove(object sender, MouseEventArgs e)//event rê trỏ chuột khi trong khi chuột trái còn nhấn
        {
            if(IsMouseDown==true)//check chuột trái còn nhấn thì refresh giá trị x,y liên tục khi rê chuột
            {
                LocationX2Y2 = e.Location;
                label_X2.Text = "X2: "+LocationX2Y2.X.ToString();
                label_Y2.Text = "Y2: "+LocationX2Y2.Y.ToString();
                Refresh();
            }
        }

        private void pictureBox_hinhgoc_MouseUp(object sender, MouseEventArgs e)//event thả chuột để lấy vị trí pixel cuối
        {
            if (IsMouseDown == true)
            {
                LocationX2Y2 = e.Location;
                label_X2.Text = "X2: "+LocationX2Y2.X.ToString();
                label_Y2.Text = "Y2: "+LocationX2Y2.Y.ToString();
                IsMouseDown = false;
                IsMouseUp = true;
            }
        }

        private void pictureBox_hinhgoc_Paint(object sender, PaintEventArgs e)//vẽ vùng rê chuột hình chữ nhật có tọa độ điểm đầu cuối (X1,Y1)-(X2,Y2)
        {
            if(Rect!=null)
            {
                e.Graphics.DrawRectangle(Pens.Red, GetRect());
            }
        }

        private Rectangle GetRect()//hàm lấy giá trị của vùng đã chọn để vẽ 1 hình chữ nhật
        {
            Rect = new Rectangle();
            Rect.X = Math.Min(LocationX1Y1.X, LocationX2Y2.X);
            Rect.Y = Math.Min(LocationX1Y1.Y, LocationX2Y2.Y);
            Rect.Width = Math.Abs(LocationX1Y1.X - LocationX2Y2.X);
            Rect.Height = Math.Abs(LocationX1Y1.Y - LocationX2Y2.Y);
            return Rect;
        }

        double[] VectorA(Bitmap Hinhgoc,int X1,int Y1,int X2,int Y2)
        {
            double[] a = new double[3];//vector màu trung bình-giá trị trung bình các kênh R-G-B trong vùng màu đã chọn
            a[0] = 0;
            a[1] = 0;
            a[2] = 0;
            int temp=0;//biến tạm dùng xử lý 2 if bên dưới

            if (X1 > X2)//X1>X2 for dưới sẽ báo lỗi
            {
                temp = X1;
                X1 = X2;
                X2 = temp;
            }
            if (Y1 > Y2)
            {
                temp = Y1;
                Y1 = Y2;
                Y2 = temp;
            }

            for (int x = X1; x <= X2; x++)
                for(int y = Y1; y <= Y2; y++)
                {
                    Color c = Hinhgoc.GetPixel(x, y);
                    byte R = c.R;
                    byte G = c.G;
                    byte B = c.B;
                    a[0] += R;//cộng dồn giá trị màu đỏ của tất cả pixel trong vùng màu trung bình
                    a[1] += G;//_____________________green_______________________________________
                    a[2] += B;//_____________________blue_________________________________________
                }
            double size = (X2 - X1) * (Y2 - Y1);//size của vùng ảnh đã chọn, là tổng số pixel trong vùng màu đã chọn(hình chữ nhật) 
            a[0] = a[0] / size;//giá trị màu đỏ trung bình
            a[1] = a[1] / size;//giá trị màu green trung bình
            a[2] = a[2] / size;//____________blue________

            return a;//trả về vector màu trung bình của vùng đã chọn, gồm a[0], a[1], a[2]
        }

        Bitmap Segmentation(Bitmap Hinhgoc,double[] a,int D0)
        {
            Bitmap Seg = new Bitmap(Hinhgoc.Width,hinhgoc.Height);
            
            for(int x=0;x<Hinhgoc.Width;x++)
                for(int y=0;y<Hinhgoc.Height;y++)
                {
                    Color color = Hinhgoc.GetPixel(x, y);
                    byte zR = color.R;
                    byte zG = color.G;
                    byte zB = color.B;

                    double D = 0;
                    D = Math.Sqrt(Math.Pow(zR - a[0], 2) + Math.Pow(zG - a[1], 2) + Math.Pow(zB - a[2], 2));//euclidean distance

                    if (D <= Convert.ToInt32(textBox_threshold.Text))//chuyển từ kiểu string trong textbox về dạng Integer
                        Seg.SetPixel(x, y, Color.FromArgb(255, 255, 255));
                    else
                        Seg.SetPixel(x, y, Color.FromArgb(zR, zG, zB));

                }
            return Seg;
        }

        private void button_seg_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox_threshold.Text))//nếu textbox chưa nhập giá trị hoặc chứa khoảng trống thì hiện thông báo
            {
                MessageBox.Show("Nhap D0");
            }

            if(IsMouseUp==true)//việc phân đoạn ảnh sẽ đc gọi sau khi thả chuột ở vị trí X2,Y2
            {
                double[] av = new double[3];
                av=VectorA(hinhgoc, LocationX1Y1.X, LocationX1Y1.Y, LocationX2Y2.X, LocationX2Y2.Y);

                if (String.IsNullOrEmpty(textBox_threshold.Text)==false)//nếu textbox có giá trị thì mới thực hiện phân đoạn
                {
                    pictureBox_seg.Image = Segmentation(hinhgoc, av, Convert.ToInt32(textBox_threshold.Text));
                }
            }
            
        }
    }
}
