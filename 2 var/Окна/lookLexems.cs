using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Linq;

namespace Lexems
{
    public partial class LookLexems : Form
    {
        public string[] inputStr;
        public LookLexems()
        {
            InitializeComponent();

            table_lexems.ColumnCount = 3;
            table_lexems.RowCount = 2;
            table_lexems.Controls.Add(new Label { Text = "№ п/п", AutoSize = true }, 0, 0);
            table_lexems.Controls.Add(new Label { Text = "Лексема", AutoSize = true }, 1, 0);
            table_lexems.Controls.Add(new Label { Text = "Значение", AutoSize = true }, 2, 0);
        }


        private void lookLexems_Load(object sender, EventArgs e)
        {
            if (inputStr != null)
            {
                DataUpload.Text = "Данные успешно загружены";

                 LexicalAnalyzer lexicalAnalyzer = new LexicalAnalyzer(inputStr);

                 string[] lexemes = lexicalAnalyzer.GetLexemes();
                 string[] lexemType = lexicalAnalyzer.GetLexemType();


                 int ind = 1;

                 foreach (string lexeme in lexemes)
                 {
                     table_lexems.Controls.Add(new Label { Text = ind.ToString(), AutoSize = true }, 0, ind);
                     if (lexemType.Length <= ind - 1)
                         table_lexems.Controls.Add(new Label { Text = lexemType.Length.ToString(), AutoSize = true }, 1, ind);
                     else
                         table_lexems.Controls.Add(new Label { Text = lexemType[ind - 1], AutoSize = true }, 1, ind);

                     table_lexems.Controls.Add(new Label { Text = lexeme.ToString(), AutoSize = true }, 2, ind);

                     ind++;
                 }
            }
            else
            {
                DataUpload.Text = "Ошибка загрузки данных";
            }
        }

        private void back_btn_Click(object sender, EventArgs e)
        {
            MainScreen lookScreen = new MainScreen();
            lookScreen.Show();
        }

        private void database_tree_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }


     public class LexicalAnalyzer
     {
         private List<Tuple<string, string>> _lexemesAndTypes;

         public LexicalAnalyzer(string[] input)
         {
             _lexemesAndTypes = new List<Tuple<string, string>>();

             foreach (string line in input)
             {
                if (line.Trim().StartsWith("//")) continue;

                string[] tokens = line.Split(new[] { ' ', ';', '(', ')' }, StringSplitOptions.RemoveEmptyEntries);

                Console.WriteLine(line.Trim());
                foreach (string token in tokens)
                 {
                     if (token.Equals("or") || token.Equals("xor") || token.Equals("and") || token.Equals("not"))
                    {
                        _lexemesAndTypes.Add(Tuple.Create(token, "Знак операции"));
                    }
                    else if (token.Equals(":="))
                     {
                         _lexemesAndTypes.Add(Tuple.Create(token, "Оператор присваивания"));
                     }
                    else if (token.Equals(";") || token.Equals("(") || token.Equals(")"))
                    {
                        _lexemesAndTypes.Add(Tuple.Create(token, "Разделитель"));
                    }
                    else if (token.Equals("true") || token.Equals("false"))
                     {
                         _lexemesAndTypes.Add(Tuple.Create(token.Trim(), "Константа"));
                     }
                     else if (Regex.IsMatch(token, @"^[A-Za-z][A-Za-z0-9]*$"))
                     {
                         _lexemesAndTypes.Add(Tuple.Create(token.Trim(), "Идентификатор"));
                     }
                    Console.WriteLine(token.Trim());
                 }
             }
         }

        public string[] GetLexemes()
         {
             return _lexemesAndTypes.Select(t => t.Item1).ToArray();
         }

         public string[] GetLexemType()
         {
             return _lexemesAndTypes.Select(t => t.Item2).ToArray();
         }
     }
}
