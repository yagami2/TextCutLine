using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace TextcutLine2._0
{
    public partial class Form : System.Windows.Forms.Form
    {
        private Thread thread = null; //поток
        private object locker = new object(); //локер
        public static string resultNumberStr = ""; //кол-во строк в файле

        //инициализируем форму
        public Form()
        {
            InitializeComponent();
        }
        //указываем файл
        private void browsePathFile_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                openFileDialog1.CheckPathExists = true;
                pathFile.Text = openFileDialog1.FileName;
            }
            else
            {
                //MessageBox.Show("Ошибка при открытии файла!");
            }
        }
        //укаываем в какую папку сохранить результат
        private void browseSaveFolder_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                saveFolder.Text = folderBrowserDialog1.SelectedPath;
            }
            else
            {
                //MessageBox.Show("Ошибка при открытии файла!");
            }
        }

        //счиваем кол-во строк
        private void countRows_Click(object sender, EventArgs e)
        {
            string txtPathFile = pathFile.Text; //путь к файлу
            this.SetEnabled(false); //вызываем метод для блокировки элементов
            
            ThreadStart start = new ThreadStart(() => //отправляем исполняться код в другой поток
            {
                if (WorkWithFile.checkPar(pathFile.Text))
                {
                    resultNumberStr = WorkWithFile.numberOfLines(txtPathFile).ToString(); //выполняем подсчет строк
                }
                ThreadStart method = new ThreadStart(() => //создаем доп делегат для заполнения текстово формы
                {
                    this.numStr.Text = resultNumberStr;
                });
                this.Invoke(method); //выполнить "method" в основном потоке
                this.SetEnabled(true); //флаг разблокировки элементов формы
                lock (locker) //блокируем изменения с потоком
                {
                    this.thread = null;
                }   
            });
            //локер для потока
            lock (locker)
            {
                this.thread = new Thread(start);
                this.thread.Start();
            }
        }

        //режем файл на равные части
        private void cutInPart_Click(object sender, EventArgs e)
        {
            string txtNumStrInPart = numStrInPart.Text; //количество строк
            string txtPathFile = pathFile.Text; //путь к файлу
            string txtSaveFolder = saveFolder.Text; //куда сохранить...

            this.SetEnabled(false); //вызываем метод для блокировки элементов
            ThreadStart start = new ThreadStart(() => //отправляем исполняться код в другой поток
            {
                if (WorkWithFile.checkPar(txtNumStrInPart, txtPathFile, txtSaveFolder))
                {
                    WorkWithFile.CutIntoPieces(Convert.ToInt32(txtNumStrInPart), txtPathFile, txtSaveFolder);
                }
                this.SetEnabled(true); //флаг разблокировки
                lock (locker) //блокируем изменения с потоком
                {
                    this.thread = null;
                }
            });
            
            //локер для потока
            lock (locker)
            {
                this.thread = new Thread(start);
                this.thread.Start();
            }
        }
        //вырезаем диаппазон строк
        private void cutRange_Click(object sender, EventArgs e)
        {
            string txtStartStr = startStr.Text; //с какой строки начать 
            string txtFinishStr = finishStr.Text; //на какой строке закончить
            
            string txtPathFile = pathFile.Text; //путь к файлу
            string txtSaveFolder = saveFolder.Text; //куда сохранить...

            this.SetEnabled(false); //вызываем метод для блокировки элементов
            ThreadStart start = new ThreadStart(() => //отправляем исполняться код в другой поток
            {
                if (WorkWithFile.checkPar(startStr.Text,finishStr.Text,pathFile.Text, saveFolder.Text))
                {
                    WorkWithFile.cutPiece(Convert.ToInt32(startStr.Text), Convert.ToInt32(finishStr.Text), pathFile.Text, saveFolder.Text);
                }
                this.SetEnabled(true); //флаг разблокировки
                lock (locker) //блокируем изменения с потоком
                {
                    this.thread = null;
                }
            });

            //локер для потока
            lock (locker)
            {
                this.thread = new Thread(start);
                this.thread.Start();
            }
        }


        private void SetEnabled(bool enabled) //блокируем кнопки и меняем курсор во время работы
        {
            ThreadStart method = new ThreadStart(() =>
            {
                this.countRows.Enabled = enabled; //посчитать кол-во строк
                this.cutInPart.Enabled = enabled; //разрезать файл на части
                this.cutRange.Enabled = enabled; //вырезать диаппазон строк

                this.browsePathFile.Enabled = enabled; //кнопка обзор
                this.browseSaveFolder.Enabled = enabled; //кнопка обзор

                this.pathFile.Enabled = enabled; //путь к файлу
                this.saveFolder.Enabled = enabled; //путь к папке

                this.numStr.Enabled = enabled; //количество строк в файле
                this.numStrInPart.Enabled = enabled; //количество строк в каждой части
                this.startStr.Enabled = enabled; //с какой строки начать
                this.finishStr.Enabled = enabled; //на какой строке закончить

                this.Cursor = enabled ? Cursors.Default : Cursors.WaitCursor; //курсор
            });
            if (this.InvokeRequired) //выполнение в основном потоке
                this.Invoke(method);
            else
                method();
        }

        protected override void OnClosing(CancelEventArgs e)
        {
            lock (locker)
            {
                if (!object.ReferenceEquals(this.thread, null))
                    this.thread.Abort();
            }
            base.OnClosing(e);
        }
    }
}