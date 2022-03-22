using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// для работы с библиотекой OpenGL 
using Tao.OpenGl;
// для работы с библиотекой FreeGLUT 
using Tao.FreeGlut;
// для работы с элементом управления SimpleOpenGLControl 
using Tao.Platform.Windows;

namespace Lab2_Afanaseva
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            AnT.InitializeContexts();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Инициализация FreeGlut
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_SINGLE);

            //Очистка окна
            Gl.glClearColor(255, 255, 255, 1);
            Gl.glViewport(0, 0, AnT.Width, AnT.Height);

            //Настройка проекции
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();

            if ((float)AnT.Width <= (float)AnT.Height)
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Height / (float)AnT.Width, 0.0, 30.0);
            }
            else 
            {
                Glu.gluOrtho2D(0.0, 30.0 * (float)AnT.Width / (float)AnT.Height, 0.0, 30.0);
            }

            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();
        }

        private void Quit(object sender, EventArgs e)
        {
            Application.Exit(); 
        }

        private void AnT_Load(object sender, EventArgs e)
        {

        }

        private void drawA(object sender, EventArgs e)
        {
            float x0 = 8.0f, y0 = 7.0f;
            float W = 15.0f, H = 20.0f;

            // очищаем буфер цвета 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // очищаем текущую матрицу 
            Gl.glLoadIdentity();
            // устанавливаем текущий цвет - красный 
            Gl.glColor3f(255, 0, 0);

            ///////////////////////
            // активируем режим рисования линий, на основе 
            // последовательного соединения всех вершин в отрезки 

            //1 линия
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x0, y0);
            Gl.glVertex2f(x0+0.467f*W, y0+H);
            Gl.glVertex2f(x0+0.6f*W, y0+H);
            Gl.glVertex2f(x0+W, y0);
            Gl.glVertex2f(x0+0.867f*W, y0);
            Gl.glVertex2f(x0+0.733f*W, y0+0.35f*H);
            Gl.glVertex2f(x0+0.3f*W, y0+0.35f*H);
            Gl.glVertex2f(x0+0.133f*W, y0);
            // завершаем режим рисования 
            Gl.glEnd();
            /////////////////////////////////
            //2 линия
            Gl.glBegin(Gl.GL_LINE_LOOP);


            Gl.glVertex2f(x0+0.7f*W, y0+0.45f*H);
            Gl.glVertex2f(x0+0.53f*W, y0+0.9f*H);
            Gl.glVertex2f(x0+0.346f*W, y0+0.45f*H);
            // завершаем режим рисования 
            Gl.glEnd();

            // дожидаемся конца визуализации кадра 
            Gl.glFlush();

            // посылаем сигнал перерисовки элемента AnT. 
            AnT.Invalidate();
        }

        private void drawFIO(object sender, EventArgs e)
        {
            float x01 = 5.0f, y01 = 10.0f;
            float W1 = 10.0f, H1 = 10.0f;
            float dist = 5.0f;

            // очищаем буфер цвета 
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // очищаем текущую матрицу 
            Gl.glLoadIdentity();
            // устанавливаем текущий цвет - красный 
            Gl.glColor3f(225, 0, 125);
            Gl.glLineWidth(2);

            ///////////////////////
            // активируем режим рисования линий, на основе 
            // последовательного соединения всех вершин в отрезки 

            //Буква Г
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x01, y01);
            Gl.glVertex2f(x01, y01+H1);
            Gl.glVertex2f(x01+W1, y01+H1);
            Gl.glVertex2f(x01+W1, y01+0.75f*H1);
            Gl.glVertex2f(x01+0.25f*W1, y01+0.75f*H1);
            Gl.glVertex2f(x01+0.25f*W1, y01);
            Gl.glEnd();


            //Буква И
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x01 + W1 + dist, y01);
            Gl.glVertex2f(x01 + W1 + dist, y01 + H1);
            Gl.glVertex2f(x01 + W1 + dist + 0.25f * W1, y01 + H1);
            Gl.glVertex2f(x01 + W1 + dist + 0.25f * W1, y01 + 0.25f*H1);
            Gl.glVertex2f(x01 + W1 + dist + 0.75f * W1, y01 + H1);
            Gl.glVertex2f(x01 + W1 + dist + W1, y01 + H1);
            Gl.glVertex2f(x01 + W1 + dist + W1, y01);
            Gl.glVertex2f(x01 + W1 + dist + 0.75f * W1, y01);
            Gl.glVertex2f(x01 + W1 + dist + 0.75f * W1, y01 + 0.75f*H1);
            Gl.glVertex2f(x01 + W1 + dist + 0.25f * W1, y01);

            Gl.glEnd();

            //Буква Р
            //Внешний контур
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x01 + W1 + dist + W1 + dist, y01);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist, y01 + H1);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + W1, y01 + H1);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + W1, y01 + 0.5f*H1);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + 0.25f * W1, y01 + 0.5f*H1);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + 0.25f * W1, y01);

            Gl.glEnd();

            //Внутрений контур
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + 0.25f * W1, y01 + 0.625f*H1);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + 0.25f * W1, y01 + 0.875f*H1);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + 0.75f * W1, y01 + 0.875f * H1);
            Gl.glVertex2f(x01 + W1 + dist + W1 + dist + 0.75f * W1, y01 + 0.625f * H1);

            Gl.glEnd();

            Gl.glFlush();
            AnT.Invalidate();
        }

        private void drawCat(object sender, EventArgs e)
        {
            float x0 = 4.0f, y0 = 3.0f;
            float W = 39.0f, H = 36.0f;

            // очищаем буфер цвета
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT);

            // очищаем текущую матрицу 
            Gl.glLoadIdentity();
            // устанавливаем текущий цвет - черный
            Gl.glColor3f(0, 0, 0);
            Gl.glLineWidth(4);

            ///////////////////////
            // активируем режим рисования линий, на основе 
            // последовательного соединения всех вершин в отрезки 

            //Тело кошки
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x0 + 0.205f * W, y0 + 0.194f * H);
            Gl.glVertex2f(x0 + 0.205f * W, y0 + 0.472f * H);
            Gl.glVertex2f(x0 + 0.641f * W, y0 + 0.472f * H);
            Gl.glVertex2f(x0 + 0.641f * W, y0 + 0.194f * H);

            Gl.glEnd();

            //Голова кошки
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x0 + 0.641f * W, y0 + 0.528f * H);
            Gl.glVertex2f(x0 + W, y0 + 0.528f * H);
            Gl.glVertex2f(x0 + W, y0 + 0.139f * H);
            Gl.glVertex2f(x0 + 0.641f * W, y0 + 0.139f * H);

            Gl.glEnd();

            //Левая нога кошки
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x0 + 0.282f * W, y0 + 0.194f * H);
            Gl.glVertex2f(x0 + 0.33f * W, y0 + 0.194f * H);
            Gl.glVertex2f(x0 + 0.33f * W, y0);
            Gl.glVertex2f(x0 + 0.282f * W, y0);

            Gl.glEnd();

            //Правая нога кошки
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x0 + 0.513f * W, y0 + 0.194f * H);
            Gl.glVertex2f(x0 + 0.564f * W, y0 + 0.194f * H);
            Gl.glVertex2f(x0 + 0.564f * W, y0);
            Gl.glVertex2f(x0 + 0.513f * W, y0);

            Gl.glEnd();

            //Рот
            Gl.glBegin(Gl.GL_LINE_STRIP);

            Gl.glVertex2f(x0 + 0.705f * W, y0 + 0.236f * H);
            Gl.glVertex2f(x0 + 0.756f * W, y0 + 0.181f * H);
            Gl.glVertex2f(x0 + 0.885f * W, y0 + 0.181f * H);
            Gl.glVertex2f(x0 + 0.936f * W, y0 + 0.236f * H);

            Gl.glEnd();

            //Нос
            Gl.glBegin(Gl.GL_LINE_LOOP);

            Gl.glVertex2f(x0 + 0.782f * W, y0 + 0.33f * H);
            Gl.glVertex2f(x0 + 0.821f * W, y0 + 0.359f * H);
            Gl.glVertex2f(x0 + 0.859f * W, y0 + 0.308f * H);

            Gl.glEnd();


            //Создаем массивы для прорисовки глаз
            float[,] crdEyesLeft = new float[6, 2] { { x0 + 0.692f*W, y0 + 0.417f * H }, { x0 + 0.718f * W, y0 + 0.41f * H }, { x0 + 0.769f * W, y0 + 0.444f * H }, { x0 + 0.795f * W, y0 + 0.417f * H }, { x0 + 0.769f * W, y0 + 0.359f * H }, { x0 + 0.718f * W, y0 + 0.389f * H } };
            // Отсюда  исправить коэффиценты при H ( * 25 / 36)
            float[,] crdPupilLeft = new float[6, 2] { { x0 + 0.744f * W, y0 + 0.444f * H }, { x0 + 0.769f * W, y0 + 0.431f * H }, { x0 + 0.769f * W, y0 + 0.403f * H }, { x0 + 0.744f * W, y0 + 0.389f * H }, { x0 + 0.718f * W, y0 + 0.403f * H }, { x0 + 0.718f * W, y0 + 0.431f * H } };
            float[,] crdEyesRight = new float[6, 2] { { x0 + 0.872f * W, y0 + 0.417f * H }, { x0 + 0.897f * W, y0 + 0.444f * H }, { x0 + 0.949f * W, y0 + 0.444f * H }, { x0 + 0.974f * W, y0 + 0.417f * H }, { x0 + 0.949f * W, y0 + 0.389f * H }, { x0 + 0.897f * W, y0 + 0.389f * H } };
            float[,] crdPupilRight = new float[6, 2] { { x0 + 0.923f * W, y0 + 0.444f * H }, { x0 + 0.949f * W, y0 + 0.431f * H }, { x0 + 0.949f * W, y0 + 0.403f * H }, { x0 + 0.923f * W, y0 + 0.389f * H }, { x0 + 0.897f * W, y0 + 0.403f * H }, { x0 + 0.897f * W, y0 + 0.431f * H } };
            float[,] crdTail = new float[8, 2] { { x0 + 0.205f * W, y0 + 0.361f * H }, { x0 + 0.154f * W, y0 + 0.361f * H }, { x0, y0 + 0.472f * H }, { x0, y0 + 0.694f * H }, { x0 + 0.077f * W, y0 + 0.694f * H }, { x0 + 0.077f * W, y0 + 0.528f * H }, { x0 + 0.154f * W, y0 + 0.472f * H }, { x0 + 0.205f * W, y0 + 0.472f * H } };

            Gl.glColor3f(56, 67, 0);      //Меняем цвет на бледно-желтый

            //Рисуем левый глаз
            Gl.glBegin(Gl.GL_POLYGON);

            for (int i = 0; i < 6; i++)
            {
                Gl.glVertex2f(crdEyesLeft[i, 0], crdEyesLeft[i, 1]);
            }

            Gl.glEnd();

            Gl.glColor3f(0, 0, 0);        //Возвращаем цвет на красный


            //Рисуем левый зрачок
            Gl.glBegin(Gl.GL_POLYGON);

            for (int i = 0; i < 6; i++)
            {
                Gl.glVertex2f(crdPupilLeft[i, 0], crdPupilLeft[i, 1]);
            }

            Gl.glEnd();

            Gl.glColor3f(56, 67, 0);      //Меняем цвет на бледно-желтый

            //Рисуем правый глаз
            Gl.glBegin(Gl.GL_POLYGON);

            for (int i = 0; i < 6; i++)
            {
                Gl.glVertex2f(crdEyesRight[i, 0], crdEyesRight[i, 1]);
            }

            Gl.glEnd();

            Gl.glColor3f(0, 0, 0);

            //Рисуем правый зрачок
            Gl.glBegin(Gl.GL_POLYGON);

            for (int i = 0; i < 6; i++)
            {
                Gl.glVertex2f(crdPupilRight[i, 0], crdPupilRight[i, 1]);
            }

            Gl.glEnd();

            ///////////////////////
            //Рисуем уши

            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glVertex2f(29, 22);
            Gl.glVertex2f(31, 26);
            Gl.glVertex2f(33, 22);

            Gl.glEnd();

            Gl.glBegin(Gl.GL_TRIANGLES);

            Gl.glVertex2f(39, 22);
            Gl.glVertex2f(41, 26);
            Gl.glVertex2f(43, 22);

            Gl.glEnd();

            //Рисуем хвост

            Gl.glColor3f(0, 0, 0);

            Gl.glBegin(Gl.GL_LINE_STRIP);

            for (int i = 0; i < 8; i++)
            {
                Gl.glVertex2f(crdTail[i, 0], crdTail[i, 1]);
            }

            Gl.glEnd();

            Gl.glFlush();
            AnT.Invalidate();
        }
    }
}
