using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loan_Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void newton()
        {
            
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.DarkGray, 2);
            pen.DashPattern = new float[] { 2, 2 };
            e.Graphics.DrawRectangle(pen, 1, 1, pictureBox1.Width - 2, pictureBox1.Height - 2);
        }

        private void comboBox11_SelectedIndexChanged(object sender, EventArgs e)
        {
            var val = dateTimePicker1.Value;
            dateTimePicker1.Value = val.AddDays((double)loanDays.Value);
        }

        private void comboBox10_SelectedIndexChanged(object sender, EventArgs e)
        {
            label82.Text = comboBox10.Text;
        }

        private void loanValue_Scroll(object sender, EventArgs e)
        {
            label68.Text = loanValue.Value.ToString();
            int v = loanValue.Value / 100 * loanDays.Value;
            int i = loanValue.Value + v;
            label66.Text = Convert.ToString(v);
            label67.Text = Convert.ToString(i);
        }

        private void loanValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void loanDays_Scroll(object sender, EventArgs e)
        {
            
            int v = loanValue.Value / 100 * loanDays.Value;
            int i = loanValue.Value + v;
            label69.Text = loanDays.Value.ToString();
            label67.Text = Convert.ToString(i);
            label66.Text = Convert.ToString(v);

        }

        private void switch1_Load(object sender, EventArgs e)
        {

        }

        private void largeLoanValue_Scroll(object sender, EventArgs e)
        {
            label48.Text = largeLoanValue.Value.ToString();
            label54.Text = largeLoanValue.Value.ToString();
            int weekdays = 7;
            int d = largeLoanValue.Value / 220 * (loanWeeks.Value * weekdays);
            int c = largeLoanValue.Value + d;
            int m = loanWeeks.Value / 2;
            int p = c / m;
            label48.Text = Convert.ToString(d);
            label49.Text = Convert.ToString(c);
            label50.Text = Convert.ToString(p);
            label51.Text = Convert.ToString(m);
        }

        private void loanWeeks_Scroll(object sender, EventArgs e)
        {
            int weekdays = 7;
            int d = largeLoanValue.Value / 220 * (loanWeeks.Value * weekdays);
            int c = largeLoanValue.Value + d;
            int m = loanWeeks.Value / 2;
            //int lv = 364/52;
            //int annuitete = (((lv * (1 + lv) * loanWeeks.Value) / (1 + lv) * loanWeeks.Value - 1));
            int p = c / m;
            label53.Text = loanWeeks.Value.ToString();
            label48.Text = Convert.ToString(d);
            label49.Text = Convert.ToString(c);
            label50.Text = Convert.ToString(p);
            label51.Text = Convert.ToString(m);
        }

        private void largeLoanPercentageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void largeLoanAverageTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void AnnuiteteValue_TextChanged(object sender, EventArgs e)
        {

        }

        private void largeLoanValueTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void loanWeaksTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_Enter(object sender, EventArgs e)
        {
            textBox2.Text = "";
            textBox2.Enter -= textBox2_Enter;
            textBox2.Leave += textBox2_Leave;
            textBox2.TextChanged += textBox2_TextChanged;
        }

        private void textBox2_Leave(object sender, EventArgs e)
        {
            textBox2.ForeColor = Color.DarkGray;
            textBox2.Text = "Отчество";
            textBox2.Enter += textBox2_Enter;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            textBox2.Leave -= textBox2_Leave;
            textBox2.TextChanged -= textBox2_TextChanged;
        }

        private void comboBox13_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox63_Enter(object sender, EventArgs e)
        {
            textBox63.Text = "";
            textBox63.Enter -= textBox63_Enter;
            textBox63.Leave += textBox63_Leave;
            textBox63.TextChanged += textBox63_TextChanged;
        }

        private void textBox63_Leave(object sender, EventArgs e)
        {
            textBox63.ForeColor = Color.DarkGray;
            textBox63.Text = "FL.ru";
            textBox63.Enter += textBox63_Enter;
        }

        private void textBox63_TextChanged(object sender, EventArgs e)
        {
            textBox63.Leave -= textBox63_Leave;
            textBox63.TextChanged -= textBox63_TextChanged;
        }

        private void checkBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_Enter(object sender, EventArgs e)
        {
            textBox8.Text = "";
            textBox8.Enter -= textBox8_Enter;
            textBox8.Leave += textBox8_Leave;
            textBox8.TextChanged += textBox8_TextChanged;
        }

        private void textBox8_Leave(object sender, EventArgs e)
        {
            textBox8.ForeColor = Color.DarkGray;
            textBox8.Text = "Номер ТК";
            textBox8.Enter += textBox8_Enter;
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            textBox8.Leave -= textBox8_Leave;
            textBox8.TextChanged -= textBox8_TextChanged;
        }

        private void textBox1_Enter(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox1.Enter -= textBox1_Enter;
            textBox1.Leave += textBox1_Leave;
            textBox1.TextChanged += textBox1_TextChanged;
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.DarkGray;
            textBox1.Text = "Фамилия";
            textBox1.Enter += textBox1_Enter;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Leave -= textBox1_Leave;
            textBox1.TextChanged -= textBox1_TextChanged;
        }

        private void textBox4_Enter(object sender, EventArgs e)
        {
            textBox4.Text = "";
            textBox4.Enter -= textBox4_Enter;
            textBox4.Leave += textBox4_Leave;
            textBox4.TextChanged += textBox4_TextChanged;
        }

        private void textBox4_Leave(object sender, EventArgs e)
        {
            textBox4.ForeColor = Color.DarkGray;
            textBox4.Text = "Имя";
            textBox4.Enter += textBox4_Enter;
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            textBox4.Leave -= textBox4_Leave;
            textBox4.TextChanged -= textBox4_TextChanged;
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            textBox3.Text = "";
            textBox3.Enter -= textBox3_Enter;
            textBox3.Leave += textBox3_Leave;
            textBox3.TextChanged += textBox3_TextChanged;
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {
            textBox3.ForeColor = Color.DarkGray;
            textBox3.Text = "Место рождения";
            textBox3.Enter += textBox3_Enter;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            textBox3.Leave -= textBox3_Leave;
            textBox3.TextChanged -= textBox3_TextChanged;
        }

        private void maskedTextBox6_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox12_Enter(object sender, EventArgs e)
        {
            textBox12.Text = "";
            textBox12.Enter -= textBox12_Enter;
            textBox12.Leave += textBox12_Leave;
            textBox12.TextChanged += textBox12_TextChanged;
        }

        private void textBox12_Leave(object sender, EventArgs e)
        {
            textBox12.ForeColor = Color.DarkGray;
            textBox12.Text = "Населенный пункт";
            textBox12.Enter += textBox12_Enter;
        }

        private void textBox12_TextChanged(object sender, EventArgs e)
        {
            textBox12.Leave -= textBox12_Leave;
            textBox12.TextChanged -= textBox12_TextChanged;
        }

        private void tabPage6_Click(object sender, EventArgs e)
        {

        }

        private void textBox11_Enter(object sender, EventArgs e)
        {
            textBox11.Text = "";
            textBox11.Enter -= textBox11_Enter;
            textBox11.Leave += textBox11_Leave;
            textBox11.TextChanged += textBox11_TextChanged;
        }

        private void textBox11_Leave(object sender, EventArgs e)
        {
            textBox11.ForeColor = Color.DarkGray;
            textBox11.Text = "Район";
            textBox11.Enter += textBox11_Enter;
        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            textBox11.Leave -= textBox11_Leave;
            textBox11.TextChanged -= textBox11_TextChanged;
        }

        private void textBox15_Enter(object sender, EventArgs e)
        {
            textBox15.Text = "";
            textBox15.Enter -= textBox15_Enter;
            textBox15.Leave += textBox15_Leave;
            textBox15.TextChanged += textBox15_TextChanged;
        }

        private void textBox15_Leave(object sender, EventArgs e)
        {
            textBox15.ForeColor = Color.DarkGray;
            textBox15.Text = "Улица";
            textBox15.Enter += textBox15_Enter;
        }

        private void textBox15_TextChanged(object sender, EventArgs e)
        {
            textBox15.Leave -= textBox15_Leave;
            textBox15.TextChanged -= textBox15_TextChanged;
        }

        private void textBox13_Enter(object sender, EventArgs e)
        {
            textBox13.Text = "";
            textBox13.Enter -= textBox13_Enter;
            textBox13.Leave += textBox13_Leave;
            textBox13.TextChanged += textBox13_TextChanged;
        }

        private void textBox13_Leave(object sender, EventArgs e)
        {
            textBox13.ForeColor = Color.DarkGray;
            textBox13.Text = "Дом";
            textBox13.Enter += textBox13_Enter;
        }

        private void textBox13_TextChanged(object sender, EventArgs e)
        {
            textBox13.Leave -= textBox13_Leave;
            textBox13.TextChanged -= textBox13_TextChanged;
        }

        private void textBox14_Enter(object sender, EventArgs e)
        {
            textBox14.Text = "";
            textBox14.Enter -= textBox14_Enter;
            textBox14.Leave += textBox14_Leave;
            textBox14.TextChanged += textBox14_TextChanged;
        }

        private void textBox14_Leave(object sender, EventArgs e)
        {
            textBox14.ForeColor = Color.DarkGray;
            textBox14.Text = "Корпус";
            textBox14.Enter += textBox14_Enter;
        }

        private void textBox14_TextChanged(object sender, EventArgs e)
        {
            textBox14.Leave -= textBox14_Leave;
            textBox14.TextChanged -= textBox14_TextChanged;
        }

        private void textBox17_Enter(object sender, EventArgs e)
        {
            textBox17.Text = "";
            textBox17.Enter -= textBox17_Enter;
            textBox17.Leave += textBox17_Leave;
            textBox17.TextChanged += textBox17_TextChanged;
        }

        private void textBox17_Leave(object sender, EventArgs e)
        {
            textBox17.ForeColor = Color.DarkGray;
            textBox17.Text = "Квартира";
            textBox17.Enter += textBox17_Enter;
        }

        private void textBox17_TextChanged(object sender, EventArgs e)
        {
            textBox17.Leave -= textBox17_Leave;
            textBox17.TextChanged -= textBox17_TextChanged;
        }

        private void textBox22_Enter(object sender, EventArgs e)
        {
            textBox22.Text = "";
            textBox22.Enter -= textBox22_Enter;
            textBox22.Leave += textBox22_Leave;
            textBox22.TextChanged += textBox22_TextChanged;
        }

        private void textBox22_Leave(object sender, EventArgs e)
        {
            textBox22.ForeColor = Color.DarkGray;
            textBox22.Text = "Населенный пункт";
            textBox22.Enter += textBox22_Enter;
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            textBox22.Leave -= textBox22_Leave;
            textBox22.TextChanged -= textBox22_TextChanged;
        }

        private void textBox24_Enter(object sender, EventArgs e)
        {
            textBox24.Text = "";
            textBox24.Enter -= textBox24_Enter;
            textBox24.Leave += textBox24_Leave;
            textBox24.TextChanged += textBox24_TextChanged;
        }

        private void textBox24_Leave(object sender, EventArgs e)
        {
            textBox24.ForeColor = Color.DarkGray;
            textBox24.Text = "Район";
            textBox24.Enter += textBox24_Enter;
        }

        private void textBox24_TextChanged(object sender, EventArgs e)
        {
            textBox24.Leave -= textBox24_Leave;
            textBox24.TextChanged -= textBox24_TextChanged;
        }

        private void textBox20_Enter(object sender, EventArgs e)
        {
            textBox20.Text = "";
            textBox20.Enter -= textBox20_Enter;
            textBox20.Leave += textBox20_Leave;
            textBox20.TextChanged += textBox20_TextChanged;
        }

        private void textBox20_Leave(object sender, EventArgs e)
        {
            textBox20.ForeColor = Color.DarkGray;
            textBox20.Text = "Улица";
            textBox20.Enter += textBox20_Enter;
        }

        private void textBox20_TextChanged(object sender, EventArgs e)
        {
            textBox20.Leave -= textBox20_Leave;
            textBox20.TextChanged -= textBox20_TextChanged;
        }

        private void textBox16_TextChanged(object sender, EventArgs e)
        {

        }

        private void tabPage7_Click(object sender, EventArgs e)
        {

        }

        private void textBox21_Enter(object sender, EventArgs e)
        {
            textBox21.Text = "";
            textBox21.Enter -= textBox21_Enter;
            textBox21.Leave += textBox21_Leave;
            textBox21.TextChanged += textBox21_TextChanged;
        }

        private void textBox21_Leave(object sender, EventArgs e)
        {
            textBox21.ForeColor = Color.DarkGray;
            textBox21.Text = "Дом";
            textBox21.Enter += textBox21_Enter;
        }

        private void textBox21_TextChanged(object sender, EventArgs e)
        {
            textBox21.Leave -= textBox21_Leave;
            textBox21.TextChanged -= textBox21_TextChanged;
        }

        private void textBox19_Enter(object sender, EventArgs e)
        {
            textBox19.Text = "";
            textBox19.Enter -= textBox19_Enter;
            textBox19.Leave += textBox19_Leave;
            textBox19.TextChanged += textBox19_TextChanged;
        }

        private void textBox19_Leave(object sender, EventArgs e)
        {
            textBox19.ForeColor = Color.DarkGray;
            textBox19.Text = "Корпус";
            textBox19.Enter += textBox19_Enter;
        }

        private void textBox19_TextChanged(object sender, EventArgs e)
        {
            textBox19.Leave -= textBox19_Leave;
            textBox19.TextChanged -= textBox19_TextChanged;
        }

        private void textBox18_Enter(object sender, EventArgs e)
        {
            textBox18.Text = "";
            textBox18.Enter -= textBox18_Enter;
            textBox18.Leave += textBox18_Leave;
            textBox18.TextChanged += textBox18_TextChanged;
        }

        private void textBox18_Leave(object sender, EventArgs e)
        {
            textBox18.ForeColor = Color.DarkGray;
            textBox18.Text = "Квартира";
            textBox18.Enter += textBox18_Enter;
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            textBox18.Leave -= textBox18_Leave;
            textBox18.TextChanged -= textBox18_TextChanged;
        }

        private void checkBox17_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox15_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox12_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox8_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox5_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox6_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox4_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox12_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        public Bitmap ResizeBitmap(Bitmap b, int nWidth, int nHeight)
        {
            Bitmap result = new Bitmap(nWidth, nHeight);
            using (Graphics g = Graphics.FromImage((Image)result))
                g.DrawImage(b, 0, 0, nWidth, nHeight);
            return result;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image; //Bitmap для открываемого изображения
            OpenFileDialog open_dialog = new OpenFileDialog(); //создание диалогового окна для выбора файла
            open_dialog.Filter = "Image Files(*.BMP;*.JPG;*.GIF;*.PNG)|*.BMP;*.JPG;*.GIF;*.PNG|All files (*.*)|*.*"; //формат загружаемого файла
            if (open_dialog.ShowDialog() == DialogResult.OK) //если в окне была нажата кнопка "ОК"
            {
                try
                {
                    image = new Bitmap(open_dialog.FileName);
                    //вместо pictureBox1 укажите pictureBox, в который нужно загрузить изображение 
                    this.pictureBox1.Size = image.Size;
                    pictureBox1.Image = image;
                    pictureBox1.Invalidate();
                }
                catch
                {
                    DialogResult rezult = MessageBox.Show("Невозможно открыть выбранный файл",
                    "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.SizeMode = PictureBoxSizeMode.CenterImage;
            pictureBox1.Size = new Size(115, 135);
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox15_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tabPage12_Click(object sender, EventArgs e)
        {

        }

        private void comboBox21_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox14_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox9_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox30_Enter(object sender, EventArgs e)
        {
            textBox30.Text = "";
            textBox30.Enter -= textBox30_Enter;
            textBox30.Leave += textBox30_Leave;
            textBox30.TextChanged += textBox30_TextChanged;
        }

        private void textBox30_Leave(object sender, EventArgs e)
        {
            textBox30.ForeColor = Color.DarkGray;
            textBox30.Text = "Название организации";
            textBox30.Enter += textBox30_Enter;
        }

        private void textBox30_TextChanged(object sender, EventArgs e)
        {
            textBox30.Leave -= textBox30_Leave;
            textBox30.TextChanged -= textBox30_TextChanged;
        }

        private void textBox34_Enter(object sender, EventArgs e)
        {
            textBox34.Text = "";
            textBox34.Enter -= textBox34_Enter;
            textBox34.Leave += textBox34_Leave;
            textBox34.TextChanged += textBox34_TextChanged;
        }

        private void textBox34_Leave(object sender, EventArgs e)
        {
            textBox34.ForeColor = Color.DarkGray;
            textBox34.Text = "Сайт организации";
            textBox34.Enter += textBox34_Enter;
        }

        private void textBox34_TextChanged(object sender, EventArgs e)
        {
            textBox34.Leave -= textBox34_Leave;
            textBox34.TextChanged -= textBox34_TextChanged;
        }

        private void textBox33_Enter(object sender, EventArgs e)
        {
            textBox33.Text = "";
            textBox33.Enter -= textBox33_Enter;
            textBox33.Leave += textBox33_Leave;
            textBox33.TextChanged += textBox33_TextChanged;
        }

        private void textBox33_Leave(object sender, EventArgs e)
        {
            textBox33.ForeColor = Color.DarkGray;
            textBox33.Text = "ИНН организации";
            textBox33.Enter += textBox33_Enter;
        }

        private void textBox33_TextChanged(object sender, EventArgs e)
        {
            textBox33.Leave -= textBox33_Leave;
            textBox33.TextChanged -= textBox33_TextChanged;
        }

        private void textBox67_Enter(object sender, EventArgs e)
        {
            textBox67.Text = "";
            textBox67.Enter -= textBox67_Enter;
            textBox67.Leave += textBox67_Leave;
            textBox67.TextChanged += textBox67_TextChanged;
        }

        private void textBox67_Leave(object sender, EventArgs e)
        {
            textBox67.ForeColor = Color.DarkGray;
            textBox67.Text = "ОГРН организации";
            textBox67.Enter += textBox67_Enter;
        }

        private void textBox67_TextChanged(object sender, EventArgs e)
        {
            textBox67.Leave -= textBox67_Leave;
            textBox67.TextChanged -= textBox67_TextChanged;
        }

        private void textBox32_Enter(object sender, EventArgs e)
        {
            textBox32.Text = "";
            textBox32.Enter -= textBox32_Enter;
            textBox32.Leave += textBox32_Leave;
            textBox32.TextChanged += textBox32_TextChanged;
        }

        private void textBox32_Leave(object sender, EventArgs e)
        {
            textBox32.ForeColor = Color.DarkGray;
            textBox32.Text = "Адрес организации";
            textBox32.Enter += textBox32_Enter;
        }

        private void textBox32_TextChanged(object sender, EventArgs e)
        {
            textBox32.Leave -= textBox32_Leave;
            textBox32.TextChanged -= textBox32_TextChanged;
        }

        private void textBox29_Enter(object sender, EventArgs e)
        {
            textBox29.Text = "";
            textBox29.Enter -= textBox29_Enter;
            textBox29.Leave += textBox29_Leave;
            textBox29.TextChanged += textBox29_TextChanged;
        }

        private void textBox29_Leave(object sender, EventArgs e)
        {
            textBox29.ForeColor = Color.DarkGray;
            textBox29.Text = "ФИО руководителя";
            textBox29.Enter += textBox29_Enter;
        }

        private void textBox29_TextChanged(object sender, EventArgs e)
        {
            textBox29.Leave -= textBox29_Leave;
            textBox29.TextChanged -= textBox29_TextChanged;
        }

        private void textBox26_Enter(object sender, EventArgs e)
        {
            textBox26.Text = "";
            textBox26.Enter -= textBox26_Enter;
            textBox26.Leave += textBox26_Leave;
            textBox26.TextChanged += textBox26_TextChanged;
        }

        private void textBox26_Leave(object sender, EventArgs e)
        {
            textBox26.ForeColor = Color.DarkGray;
            textBox26.Text = "Совокупный доход";
            textBox26.Enter += textBox26_Enter;
        }

        private void textBox26_TextChanged(object sender, EventArgs e)
        {
            textBox26.Leave -= textBox26_Leave;
            textBox26.TextChanged -= textBox26_TextChanged;
        }

        private void textBox28_Enter(object sender, EventArgs e)
        {
            textBox28.Text = "";
            textBox28.Enter -= textBox28_Enter;
            textBox28.Leave += textBox28_Leave;
            textBox28.TextChanged += textBox28_TextChanged;
        }

        private void textBox28_Leave(object sender, EventArgs e)
        {
            textBox28.ForeColor = Color.DarkGray;
            textBox28.Text = "Ежемесячные расходы";
            textBox28.Enter += textBox28_Enter;
        }

        private void textBox28_TextChanged(object sender, EventArgs e)
        {
            textBox28.Leave -= textBox28_Leave;
            textBox28.TextChanged -= textBox28_TextChanged;
        }

        private void maskedTextBox10_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox17_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox44_Enter(object sender, EventArgs e)
        {
            textBox44.Text = "";
            textBox44.Enter -= textBox44_Enter;
            textBox44.Leave += textBox44_Leave;
            textBox44.TextChanged += textBox44_TextChanged;
        }

        private void textBox44_Leave(object sender, EventArgs e)
        {
            textBox44.ForeColor = Color.DarkGray;
            textBox44.Text = "ФИО";
            textBox44.Enter += textBox44_Enter;
        }

        private void textBox44_TextChanged(object sender, EventArgs e)
        {
            textBox44.Leave -= textBox44_Leave;
            textBox44.TextChanged -= textBox44_TextChanged;
        }

        private void maskedTextBox11_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox8_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void comboBox18_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox19_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox20_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox47_Enter(object sender, EventArgs e)
        {
            textBox47.Text = "";
            textBox47.Enter -= textBox47_Enter;
            textBox47.Leave += textBox47_Leave;
            textBox47.TextChanged += textBox47_TextChanged;
        }

        private void textBox47_Leave(object sender, EventArgs e)
        {
            textBox47.ForeColor = Color.DarkGray;
            textBox47.Text = "ФИО";
            textBox47.Enter += textBox47_Enter;
        }

        private void textBox47_TextChanged(object sender, EventArgs e)
        {
            textBox47.Leave -= textBox47_Leave;
            textBox47.TextChanged -= textBox47_TextChanged;
        }

        private void textBox49_Enter(object sender, EventArgs e)
        {
            textBox49.Text = "";
            textBox49.Enter -= textBox49_Enter;
            textBox49.Leave += textBox49_Leave;
            textBox49.TextChanged += textBox49_TextChanged;
        }

        private void textBox49_Leave(object sender, EventArgs e)
        {
            textBox49.ForeColor = Color.DarkGray;
            textBox49.Text = "ФИО";
            textBox49.Enter += textBox49_Enter;
        }

        private void textBox49_TextChanged(object sender, EventArgs e)
        {
            textBox49.Leave -= textBox49_Leave;
            textBox49.TextChanged -= textBox49_TextChanged;
        }

        private void textBox51_Enter(object sender, EventArgs e)
        {
            textBox51.Text = "";
            textBox51.Enter -= textBox51_Enter;
            textBox51.Leave += textBox51_Leave;
            textBox51.TextChanged += textBox51_TextChanged;
        }

        private void textBox51_Leave(object sender, EventArgs e)
        {
            textBox51.ForeColor = Color.DarkGray;
            textBox51.Text = "ФИО";
            textBox51.Enter += textBox51_Enter;
        }

        private void textBox51_TextChanged(object sender, EventArgs e)
        {
            textBox51.Leave -= textBox51_Leave;
            textBox51.TextChanged -= textBox51_TextChanged;
        }

        private void maskedTextBox12_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox13_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox14_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void checkBox9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox10_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox11_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox65_Enter(object sender, EventArgs e)
        {
            textBox65.Text = "";
            textBox65.Enter -= textBox65_Enter;
            textBox65.Leave += textBox65_Leave;
            textBox65.TextChanged += textBox65_TextChanged;
        }

        private void textBox65_Leave(object sender, EventArgs e)
        {
            textBox65.ForeColor = Color.DarkGray;
            textBox65.Text = "Rabota.ru";
            textBox65.Enter += textBox65_Enter;
        }

        private void textBox65_TextChanged(object sender, EventArgs e)
        {
            textBox65.Leave -= textBox65_Leave;
            textBox65.TextChanged -= textBox65_TextChanged;
        }

        private void textBox66_Enter(object sender, EventArgs e)
        {
            textBox66.Text = "";
            textBox66.Enter -= textBox66_Enter;
            textBox66.Leave += textBox66_Leave;
            textBox66.TextChanged += textBox66_TextChanged;
        }

        private void textBox66_Leave(object sender, EventArgs e)
        {
            textBox66.ForeColor = Color.DarkGray;
            textBox66.Text = "Suberjob.ru";
            textBox66.Enter += textBox66_Enter;
        }

        private void textBox66_TextChanged(object sender, EventArgs e)
        {
            textBox66.Leave -= textBox66_Leave;
            textBox66.TextChanged -= textBox66_TextChanged;
        }

        private void textBox64_Enter(object sender, EventArgs e)
        {
            textBox64.Text = "";
            textBox64.Enter -= textBox64_Enter;
            textBox64.Leave += textBox64_Leave;
            textBox64.TextChanged += textBox64_TextChanged;
        }

        private void textBox64_Leave(object sender, EventArgs e)
        {
            textBox64.ForeColor = Color.DarkGray;
            textBox64.Text = "HH.ru";
            textBox64.Enter += textBox64_Enter;
        }

        private void textBox64_TextChanged(object sender, EventArgs e)
        {
            textBox64.Leave -= textBox64_Leave;
            textBox64.TextChanged -= textBox64_TextChanged;
        }

        private void textBox61_Enter(object sender, EventArgs e)
        {
            textBox61.Text = "";
            textBox61.Enter -= textBox61_Enter;
            textBox61.Leave += textBox61_Leave;
            textBox61.TextChanged += textBox61_TextChanged;
        }

        private void textBox61_Leave(object sender, EventArgs e)
        {
            textBox61.ForeColor = Color.DarkGray;
            textBox61.Text = "YouDo.ru";
            textBox61.Enter += textBox61_Enter;
        }

        private void textBox61_TextChanged(object sender, EventArgs e)
        {
            textBox61.Leave -= textBox61_Leave;
            textBox61.TextChanged -= textBox61_TextChanged;
        }

        private void textBox60_Enter(object sender, EventArgs e)
        {
            textBox60.Text = "";
            textBox60.Enter -= textBox60_Enter;
            textBox60.Leave += textBox60_Leave;
            textBox60.TextChanged += textBox60_TextChanged;
        }

        private void textBox60_Leave(object sender, EventArgs e)
        {
            textBox60.ForeColor = Color.DarkGray;
            textBox60.Text = "Profi.ru";
            textBox60.Enter += textBox60_Enter;
        }

        private void textBox60_TextChanged(object sender, EventArgs e)
        {
            textBox60.Leave -= textBox60_Leave;
            textBox60.TextChanged -= textBox60_TextChanged;
        }

        private void textBox57_Enter(object sender, EventArgs e)
        {
            textBox57.Text = "";
            textBox57.Enter -= textBox57_Enter;
            textBox57.Leave += textBox57_Leave;
            textBox57.TextChanged += textBox57_TextChanged;
        }

        private void textBox57_Leave(object sender, EventArgs e)
        {
            textBox57.ForeColor = Color.DarkGray;
            textBox57.Text = "Yandex";
            textBox57.Enter += textBox57_Enter;
        }

        private void textBox57_TextChanged(object sender, EventArgs e)
        {
            textBox57.Leave -= textBox57_Leave;
            textBox57.TextChanged -= textBox57_TextChanged;
        }

        private void textBox59_Enter(object sender, EventArgs e)
        {
            textBox59.Text = "";
            textBox59.Enter -= textBox59_Enter;
            textBox59.Leave += textBox59_Leave;
            textBox59.TextChanged += textBox59_TextChanged;
        }

        private void textBox59_Leave(object sender, EventArgs e)
        {
            textBox59.ForeColor = Color.DarkGray;
            textBox59.Text = "mail.ru";
            textBox59.Enter += textBox59_Enter;
        }

        private void textBox59_TextChanged(object sender, EventArgs e)
        {
            textBox59.Leave -= textBox59_Leave;
            textBox59.TextChanged -= textBox59_TextChanged;
        }

        private void textBox62_Enter(object sender, EventArgs e)
        {
            textBox62.Text = "";
            textBox62.Enter -= textBox62_Enter;
            textBox62.Leave += textBox62_Leave;
            textBox62.TextChanged += textBox62_TextChanged;
        }

        private void textBox62_Leave(object sender, EventArgs e)
        {
            textBox62.ForeColor = Color.DarkGray;
            textBox62.Text = "Freelance.ru";
            textBox62.Enter += textBox62_Enter;
        }

        private void textBox62_TextChanged(object sender, EventArgs e)
        {
            textBox62.Leave -= textBox62_Leave;
            textBox62.TextChanged -= textBox62_TextChanged;
        }

        private void textBox52_Enter(object sender, EventArgs e)
        {
            textBox52.Text = "";
            textBox52.Enter -= textBox52_Enter;
            textBox52.Leave += textBox52_Leave;
            textBox52.TextChanged += textBox52_TextChanged;
        }

        private void textBox52_Leave(object sender, EventArgs e)
        {
            textBox52.ForeColor = Color.DarkGray;
            textBox52.Text = "Одноклассники";
            textBox52.Enter += textBox52_Enter;
        }

        private void textBox52_TextChanged(object sender, EventArgs e)
        {
            textBox52.Leave -= textBox52_Leave;
            textBox52.TextChanged -= textBox52_TextChanged;
        }

        private void textBox53_Enter(object sender, EventArgs e)
        {
            textBox53.Text = "";
            textBox53.Enter -= textBox53_Enter;
            textBox53.Leave += textBox53_Leave;
            textBox53.TextChanged += textBox53_TextChanged;
        }

        private void textBox53_Leave(object sender, EventArgs e)
        {
            textBox53.ForeColor = Color.DarkGray;
            textBox53.Text = "Вконтакте";
            textBox53.Enter += textBox53_Enter;
        }

        private void textBox53_TextChanged(object sender, EventArgs e)
        {
            textBox53.Leave -= textBox53_Leave;
            textBox53.TextChanged -= textBox53_TextChanged;
        }

        private void textBox56_Enter(object sender, EventArgs e)
        {
            textBox56.Text = "";
            textBox56.Enter -= textBox56_Enter;
            textBox56.Leave += textBox56_Leave;
            textBox56.TextChanged += textBox56_TextChanged;
        }

        private void textBox56_Leave(object sender, EventArgs e)
        {
            textBox56.ForeColor = Color.DarkGray;
            textBox56.Text = "YouTube";
            textBox56.Enter += textBox56_Enter;
        }

        private void textBox56_TextChanged(object sender, EventArgs e)
        {
            textBox56.Leave -= textBox56_Leave;
            textBox56.TextChanged -= textBox56_TextChanged;
        }

        private void textBox54_Enter(object sender, EventArgs e)
        {
            textBox54.Text = "";
            textBox54.Enter -= textBox54_Enter;
            textBox54.Leave += textBox54_Leave;
            textBox54.TextChanged += textBox54_TextChanged;
        }

        private void textBox54_Leave(object sender, EventArgs e)
        {
            textBox54.ForeColor = Color.DarkGray;
            textBox54.Text = "FaceBook";
            textBox54.Enter += textBox54_Enter;
        }

        private void textBox54_TextChanged(object sender, EventArgs e)
        {
            textBox54.Leave -= textBox54_Leave;
            textBox54.TextChanged -= textBox54_TextChanged;
        }

        private void textBox55_Enter(object sender, EventArgs e)
        {
            textBox55.Text = "";
            textBox55.Enter -= textBox55_Enter;
            textBox55.Leave += textBox55_Leave;
            textBox55.TextChanged += textBox55_TextChanged;
        }

        private void textBox55_Leave(object sender, EventArgs e)
        {
            textBox55.ForeColor = Color.DarkGray;
            textBox55.Text = "Instagram";
            textBox55.Enter += textBox55_Enter;
        }

        private void textBox55_TextChanged(object sender, EventArgs e)
        {
            textBox55.Leave -= textBox55_Leave;
            textBox55.TextChanged -= textBox55_TextChanged;
        }

        private void textBox68_Enter(object sender, EventArgs e)
        {
            textBox68.Text = "";
            textBox68.Enter -= textBox68_Enter;
            textBox68.Leave += textBox68_Leave;
            textBox68.TextChanged += textBox68_TextChanged;
        }

        private void textBox68_Leave(object sender, EventArgs e)
        {
            textBox68.ForeColor = Color.DarkGray;
            textBox68.Text = "ICQ";
            textBox68.Enter += textBox68_Enter;
        }

        private void textBox68_TextChanged(object sender, EventArgs e)
        {
            textBox68.Leave -= textBox68_Leave;
            textBox68.TextChanged -= textBox68_TextChanged;
        }

        private void textBox58_Enter(object sender, EventArgs e)
        {
            textBox58.Text = "";
            textBox58.Enter -= textBox58_Enter;
            textBox58.Leave += textBox58_Leave;
            textBox58.TextChanged += textBox58_TextChanged;
        }

        private void textBox58_Leave(object sender, EventArgs e)
        {
            textBox58.ForeColor = Color.DarkGray;
            textBox58.Text = "Telegram name";
            textBox58.Enter += textBox58_Enter;
        }

        private void textBox58_TextChanged(object sender, EventArgs e)
        {
            textBox58.Leave -= textBox58_Leave;
            textBox58.TextChanged -= textBox58_TextChanged;
        }

        private void textBox69_Enter(object sender, EventArgs e)
        {
            textBox69.Text = "";
            textBox69.Enter -= textBox69_Enter;
            textBox69.Leave += textBox69_Leave;
            textBox69.TextChanged += textBox69_TextChanged;
        }

        private void textBox69_Leave(object sender, EventArgs e)
        {
            textBox69.ForeColor = Color.DarkGray;
            textBox69.Text = "Электронная почта";
            textBox69.Enter += textBox69_Enter;
        }

        private void textBox69_TextChanged(object sender, EventArgs e)
        {
            textBox69.Leave -= textBox69_Leave;
            textBox69.TextChanged -= textBox69_TextChanged;
        }

        private void checkBox13_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox14_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox16_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void maskedTextBox2_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox4_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            textBox7.Text = "";
            textBox7.Enter -= textBox7_Enter;
            textBox7.Leave += textBox7_Leave;
            textBox7.TextChanged += textBox7_TextChanged;
        }

        private void textBox7_Leave(object sender, EventArgs e)
        {
            textBox7.ForeColor = Color.DarkGray;
            textBox7.Text = "Кем выдан";
            textBox7.Enter += textBox7_Enter;
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            textBox7.Leave -= textBox7_Leave;
            textBox7.TextChanged -= textBox7_TextChanged;
        }

        private void maskedTextBox9_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox7_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void maskedTextBox8_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox5_Enter(object sender, EventArgs e)
        {
            textBox5.Text = "";
            textBox5.Enter -= textBox5_Enter;
            textBox5.Leave += textBox5_Leave;
            textBox5.TextChanged += textBox5_TextChanged;
        }
        private void textBox5_Leave(object sender, EventArgs e)
        {
            textBox5.ForeColor = Color.DarkGray;
            textBox5.Text = "Категория В/У";
            textBox5.Enter += textBox5_Enter;
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            textBox5.Leave -= textBox5_Leave;
            textBox5.TextChanged -= textBox5_TextChanged;
        }

        private void comboBox16_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox41_Enter(object sender, EventArgs e)
        {
            textBox41.Text = "";
            textBox41.Enter -= textBox41_Enter;
            textBox41.Leave += textBox41_Leave;
            textBox41.TextChanged += textBox41_TextChanged;
        }

        private void textBox41_Leave(object sender, EventArgs e)
        {
            textBox41.ForeColor = Color.DarkGray;
            textBox41.Text = "Регистрационный номер ТС";
            textBox41.Enter += textBox41_Enter;
        }

        private void textBox41_TextChanged(object sender, EventArgs e)
        {
            textBox41.Leave -= textBox41_Leave;
            textBox41.TextChanged -= textBox41_TextChanged;
        }

        private void textBox42_Enter(object sender, EventArgs e)
        {
            textBox42.Text = "";
            textBox42.Enter -= textBox42_Enter;
            textBox42.Leave += textBox42_Leave;
            textBox42.TextChanged += textBox42_TextChanged;
        }

        private void textBox42_Leave(object sender, EventArgs e)
        {
            textBox42.ForeColor = Color.DarkGray;
            textBox42.Text = "Номер СТС";
            textBox42.Enter += textBox42_Enter;
        }

        private void textBox42_TextChanged(object sender, EventArgs e)
        {
            textBox42.Leave -= textBox42_Leave;
            textBox42.TextChanged -= textBox42_TextChanged;
        }

        private void textBox43_Enter(object sender, EventArgs e)
        {
            textBox43.Text = "";
            textBox43.Enter -= textBox43_Enter;
            textBox43.Leave += textBox43_Leave;
            textBox43.TextChanged += textBox43_TextChanged;
        }

        private void textBox43_Leave(object sender, EventArgs e)
        {
            textBox43.ForeColor = Color.DarkGray;
            textBox43.Text = "Номер ПТС";
            textBox43.Enter += textBox43_Enter;
        }

        private void textBox43_TextChanged(object sender, EventArgs e)
        {
            textBox43.Leave -= textBox43_Leave;
            textBox43.TextChanged -= textBox43_TextChanged;
        }

        private void textBox6_Enter(object sender, EventArgs e)
        {
            textBox6.Text = "";
            textBox6.Enter -= textBox6_Enter;
            textBox6.Leave += textBox6_Leave;
            textBox6.TextChanged += textBox6_TextChanged;
        }

        private void textBox6_Leave(object sender, EventArgs e)
        {
            textBox6.ForeColor = Color.DarkGray;
            textBox6.Text = "VIN Номер";
            textBox6.Enter += textBox6_Enter;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            textBox6.Leave -= textBox6_Leave;
            textBox6.TextChanged -= textBox6_TextChanged;
        }

        private void maskedTextBox5_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void textBox9_Enter(object sender, EventArgs e)
        {
            textBox9.Text = "";
            textBox9.Enter -= textBox9_Enter;
            textBox9.Leave += textBox9_Leave;
            textBox9.TextChanged += textBox9_TextChanged;
        }

        private void textBox9_Leave(object sender, EventArgs e)
        {
            textBox9.ForeColor = Color.DarkGray;
            textBox9.Text = "СНИЛС";
            textBox9.Enter += textBox9_Enter;
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            textBox9.Leave -= textBox9_Leave;
            textBox9.TextChanged -= textBox9_TextChanged;
        }

        private void textBox10_Enter(object sender, EventArgs e)
        {
            textBox10.Text = "";
            textBox10.Enter -= textBox10_Enter;
            textBox10.Leave += textBox10_Leave;
            textBox10.TextChanged += textBox10_TextChanged;
        }

        private void textBox10_Leave(object sender, EventArgs e)
        {
            textBox10.ForeColor = Color.DarkGray;
            textBox10.Text = "ИНН";
            textBox10.Enter += textBox10_Enter;
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {
            textBox10.Leave -= textBox10_Leave;
            textBox10.TextChanged -= textBox10_TextChanged;
        }

        private void textBox39_Enter(object sender, EventArgs e)
        {
            textBox39.Text = "";
            textBox39.Enter -= textBox39_Enter;
            textBox39.Leave += textBox39_Leave;
            textBox39.TextChanged += textBox39_TextChanged;
        }

        private void textBox39_Leave(object sender, EventArgs e)
        {
            textBox39.ForeColor = Color.DarkGray;
            textBox39.Text = "Пенсионное удостоверение";
            textBox39.Enter += textBox39_Enter;
        }

        private void textBox39_TextChanged(object sender, EventArgs e)
        {
            textBox39.Leave -= textBox39_Leave;
            textBox39.TextChanged -= textBox39_TextChanged;
        }

        private void textBox38_Enter(object sender, EventArgs e)
        {
            textBox38.Text = "";
            textBox38.Enter -= textBox38_Enter;
            textBox38.Leave += textBox38_Leave;
            textBox38.TextChanged += textBox38_TextChanged;
        }

        private void textBox38_Leave(object sender, EventArgs e)
        {
            textBox38.ForeColor = Color.DarkGray;
            textBox38.Text = "Военный билет";
            textBox38.Enter += textBox38_Enter;
        }

        private void textBox38_TextChanged(object sender, EventArgs e)
        {
            textBox38.Leave -= textBox38_Leave;
            textBox38.TextChanged -= textBox38_TextChanged;
        }

        private void textBox23_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox16_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void label69_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            
        }
    }
}
