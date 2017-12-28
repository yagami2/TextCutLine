using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Windows.Forms;

namespace TextcutLine2._0
{
    class WorkWithFile
    {
        //проверяем что все необходимыем параметры заданы

        public static bool checkPar(string file)
        {
            if (File.Exists(file))
            {
                return true;
            }
            else
            {
                MessageBox.Show("Указанный файл не найден." + '\n' + "Либо у вас недостаточно прав на его чтение.");
                return false;
            }
        }

        public static bool checkPar(string maxCount, string file, string folder)
        {
            int Count = 0;
            try
            {Count = Convert.ToInt32(maxCount);}
            catch
            {
                MessageBox.Show("Количество строк в каждой части должно быть указано целым числом.");
                return false;
            }

            //проверяем количество строк в каждом файле
            if (Count < 1) 
            {
                MessageBox.Show("Количество строк должно быть больше нуля!");
                return false;
            }

            //проверяем наличие файла
            if (!File.Exists(file)) 
            {
                MessageBox.Show("Указанный файл не найден."+'\n'+"Либо у вас недостаточно прав на его чтение.");
                return false;
            }

            //проверяем наличие папки для сохранения результатов
            if (!Directory.Exists(folder)) 
            {
                try
                {
                    Directory.CreateDirectory(folder); //если папки нет пробуем ее создать...
                }
                catch //...а если не получилось
                {
                    MessageBox.Show("Не возможно создать указанный каталог" + '\n' + "для сохранения результатов." + '\n' + "Либо у вас недостаточно прав.");
                    return false;
                }
            }
            return true; //если все хорошо
        }

        public static bool checkPar(string start, string finish, string file, string folder)
        {
            int Count = 0;
            try
            {
                Count = Convert.ToInt32(start);
                Count = Convert.ToInt32(finish);
            }
            catch
            {
                MessageBox.Show("Номер строки должен быть указан целым числом.");
                return false;
            }

            //проверяем количество строк в каждом файле
            if (Count < 1) //в данном случае count это конечный номер строки
            {
                MessageBox.Show("Укажите количество строк в должно быть больше нуля!");
                return false;
            }

            //проверяем наличие файла
            if (!File.Exists(file)) 
            {
                MessageBox.Show("Указанный файл не найден." + '\n' + "Либо у вас недостаточно прав на его чтение.");
                return false;
            }

            //проверяем наличие папки для сохранения результатов
            if (!Directory.Exists(folder)) 
            {
                try
                {
                    Directory.CreateDirectory(folder); //если папки нет пробуем ее создать...
                }
                catch //...а если не получилось
                {
                    MessageBox.Show("Не возможно создать указанный каталог" + '\n' + "для сохранения результатов." + '\n' + "Либо у вас недостаточно прав.");
                    return false;
                }
            }

            return true;
        }


        //считаем количесво строк в файле
        public static int numberOfLines(string file)
        {
            if(checkPar(file))
            {
                int count = 0;
                using (StreamReader reader = new StreamReader(file))
                {
                    while (reader.ReadLine() != null)
                    {
                        count++;
                    }
                }
                return count;
            }
            else
            {
                return 0;
            }
        }

        //режем файл на равные части
        public static void CutIntoPieces(int maxCount, string file, string folder)
        {
            int countFile = 0; //счетчик файлов
            int countLine = 0; //счетчик строк
            string fileName = Path.GetFileNameWithoutExtension(file); //имя файла 
            string ext = Path.GetExtension(file); //расширение файла
            string newFile = folder + "\\" + fileName+"("+countFile+")"+ext; //новый файл
            
            using (StreamReader reader = new StreamReader(file))
            {
                StreamWriter writer = new StreamWriter(newFile);
                while (!reader.EndOfStream)
                {
                    if (countLine < maxCount)
                    {
                        writer.WriteLine(reader.ReadLine());
                        countLine++;
                    }
                    else
                    {
                        writer.Dispose(); //закрываем поток на запись
                        newFile = folder + "\\" + fileName + "(" + ++countFile + ")" + ext; //создаем имя нового файла
                        countLine = 0; //обнуляем счетчик строк
                        writer = new StreamWriter(newFile); //создаем поток записи уже на новый файл
                    }
                }
                writer.Dispose();
            }
            MessageBox.Show("Completed");
        }

        //вырезать диаппазон строк
        public static void cutPiece(int start, int finish, string file, string folder)
        {
            int countLine = 0; //счетчик строк
            string fileName = Path.GetFileName(file);
            string newFile = folder + "\\NEW_" + fileName;

            using (StreamReader reader = new StreamReader(file))
            {
                StreamWriter writer = new StreamWriter(newFile);
                while (!reader.EndOfStream) //если в файле нет столько строк сколько указано
                {
                    if (countLine > start-1)
                    {
                        writer.WriteLine(reader.ReadLine());
                        countLine++;
                        if (countLine > finish)
                        {
                            break;
                        }
                    }
                    countLine++;
                }
                writer.Dispose(); //закрываем поток на запись
            }
            MessageBox.Show("Completed");
        }
    }
}
