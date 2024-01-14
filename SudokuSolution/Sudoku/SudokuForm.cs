using System.Diagnostics.Eventing.Reader;
using System.Windows.Forms;

namespace Sudoku
{

    public partial class SudokuForm : Form
    {
        public SudokuForm()
        {
            InitializeComponent();
            //inicijalizacija matrice pri pokretanja programa
            InitializeMatrix();
            //onemogucije koristenje buttona za odabir broja dok se ne pokrene igra
            DisableNumbButtons();
            this.KeyPreview = true; // Postavljanje KeyPreview na true omogućuje formi hvatanje događaja tipkovnice
            this.KeyPress += SudokuForm_KeyPress; // Dodavanje rukovatelja događaja za pritisak tipke
        }

        //inicijalizacija matrice buttona 
        private Button[,] matrixButtons;

        // x označava broj koji se upisiva u matricu
        public int x = 0;

        //uveo jer se stvara bug di se broj ne odabere ali se unese u sudoku 
        public int clickedNum = 0;

        //var koja oznacava tezinu sudokua
        public int diff = 0;

        //matrica koja sprema rijeseni sudoku kad napravi onaj koji trebamo rijesit
        private int[,] SudokuSolved;

        //brojac pogreski
        private int mistake = 0;

        //brojac koji broji broj ponavljanja u funkciji solve i kada prede 1000 opet se poziva funkcija jer smo naisli na
        //neku sekvencu brojeva koji ne mogu biti sudoku
        private int errorCount = 0;

        //ako je 0 onda se ne igra, ako je 1 igra se
        private int isPlayed = 0;

        //lista pogresno upisanih brojeva, potrebno da bi ih obojali u crveno
        private Button[] wrongButton;

        //posljednji pritisnuti button u sudoku, potreban radi funkcije clear
        private Button lastClicked;

        private void InitializeMatrix()
        {
            int rows = 9; // broj redaka
            int columns = 9; // broj stupaca

            matrixButtons = new Button[rows, columns];  //stvaranje matrice buttona
            lastClicked = new Button();
            // dvi for petlje koje stvaraju buttone i postavljaju početne vrijednosti

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    matrixButtons[i, j] = new Button();
                    matrixButtons[i, j].Font = new Font(matrixButtons[i, j].Font.FontFamily, 20, matrixButtons[i, j].Font.Style);
                    matrixButtons[i, j].Width = 60;
                    matrixButtons[i, j].Height = 60;
                    matrixButtons[i, j].Text = "0";  // tekst gumba je 0 da bi nam lakše bilo manipulirati s unosom brojeva a obojan je u bijelu boju da ostane neprimjecen
                    matrixButtons[i, j].ForeColor = Color.White;
                    matrixButtons[i, j].Click += MatrixButton_Click;

                    // Dodajte gumb u TableLayoutPanel
                    tableLayoutPanel1.Controls.Add(matrixButtons[i, j], j, i);
                }
            }
            Clear();

        }

        // funkcija koja se izvršava kada pritisnemo neki od buttona u matrici
        private void MatrixButton_Click(object sender, EventArgs e)
        {
            dehighliteButtons(); // funkcija koju pozivamo da oboja sve buttone na pocetnu boju
            Button clickedButton = sender as Button;
            lastClicked = clickedButton;
            int rowIndex = tableLayoutPanel1.GetRow(clickedButton);
            int colIndex = tableLayoutPanel1.GetColumn(clickedButton);
            highliteButtons(clickedButton, rowIndex, colIndex); //funkcija boja sve buttone istog stupca i retka, te pritisnuti button
            if (x != 0 && x==clickedNum && checkRowsAndColumns(clickedButton) && checkBox(clickedButton) && matrixButtons[rowIndex, colIndex].Text == "0" && CheckSudoku(clickedButton, rowIndex, colIndex)) // provjeravamo je li izabran broj za unos i postoji li taj broj u istom retku ili stupcu
            {
                if (WrongButtonCheck(clickedButton))
                {
                    wrongButton = null;
                }
                clickedButton.Text = x.ToString();
                x = 0;
                clickedButton.ForeColor = Color.Black;
                WinnerCheck();
            }
            else if (x != 0 && x == clickedNum && x != SudokuSolved[rowIndex, colIndex]) //ako je odabrani broj ne pripada mjestu u sudoku
            {
                clickedButton.Text = x.ToString();
                clickedButton.ForeColor = Color.Red;
                wrongButton[mistake] = clickedButton;
                x = 0;
                MistakeChecker();
            }
            x = 0;
        }

        // funkcija koja se pokrece kada odaberemo broj za unijeti, pohranjivamo u globalnu varijablu x
        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button b = sender as Button;
            x = int.Parse(b.Text);
            clickedNum = x;
        }

        // provjerava je li odabrani broj za odabrani button postoji u njegovom retku ili stupcu
        private bool checkRowsAndColumns(Button b)
        {
            int tren = 0;
            int rowIndex = tableLayoutPanel1.GetRow(b);
            int colIndex = tableLayoutPanel1.GetColumn(b);

            for (int i = 0; i < 9; i++)
            {
                // ako je x u odabranom retku ili stupcu varijabla se povecava
                if (x == int.Parse(matrixButtons[rowIndex, i].Text) || x == int.Parse(matrixButtons[i, colIndex].Text))
                    tren++;
            }
            //ako naidemo na isti broj funkcija vraca false i postavlja x na 0
            if (tren != 0)
            {
                return false;
            }
            else
                return true;
        }

        // boja sve stupce i retke odabranog clana matrice
        private void highliteButtons(Button b, int rows, int cols)
        {
            for (int i = 0; i < 9; i++)
            {
                matrixButtons[rows, i].BackColor = Color.FromArgb(226, 235, 243); //svijetlo plava boja
                matrixButtons[i, cols].BackColor = Color.FromArgb(226, 235, 243);
                if (matrixButtons[rows, i].Text == "0" && matrixButtons[rows, i] != b)
                {
                    matrixButtons[rows, i].ForeColor = Color.FromArgb(226, 235, 243);
                }
                if (matrixButtons[i, cols].Text == "0" && matrixButtons[i, cols] != b)
                {
                    matrixButtons[i, cols].ForeColor = Color.FromArgb(226, 235, 243);
                }
                if (WrongButtonCheck(matrixButtons[rows, i]) && matrixButtons[rows, i].Text != "0")
                    matrixButtons[rows, i].ForeColor = Color.Red;
                if (WrongButtonCheck(matrixButtons[i, cols]) && matrixButtons[i, cols].Text != "0")
                    matrixButtons[i, cols].ForeColor = Color.Red;
            }
            b.BackColor = Color.FromArgb(187, 222, 251); //plava boja za odabrani clan matrice
            if (b.Text == "0")
            {
                b.ForeColor = Color.FromArgb(187, 222, 251);
            }
            if (WrongButtonCheck(b) && b.Text != "0")
                b.ForeColor = Color.Red;
            for (int x = 0; x < 9; x++)
            {
                for (int y = 0; y < 9; y++)
                {
                    if (matrixButtons[x, y].Text == b.Text && b.Text != "0")
                    {
                        matrixButtons[x, y].BackColor = Color.FromArgb(195, 215, 234);
                    }
                }
            }
        }

        //vraca pocetnu boju matrici
        private void dehighliteButtons()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrixButtons[i, j].BackColor = Color.White;
                    if (matrixButtons[i, j].Text == "0")
                    {
                        matrixButtons[i, j].ForeColor = Color.White;
                    }
                    else if (WrongButtonCheck(matrixButtons[i, j]))
                    {
                        matrixButtons[i, j].ForeColor = Color.Red;
                    }
                    else
                    {
                        matrixButtons[i, j].ForeColor = Color.Black;
                    }
                }
            }
        }

        private bool checkBox(Button b) //provjerava mali 9x9 blok
        {
            int row = tableLayoutPanel1.GetRow(b);
            int col = tableLayoutPanel1.GetColumn(b);
            for (int k = 0; k < 3; k++)
            {
                if (row % 3 == k)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (col % 3 == i)
                        {
                            for (int y1 = row - k; y1 < row + (3 - k); y1++)
                            {
                                for (int y2 = col - i; y2 < col + (3 - i); y2++)
                                {
                                    if (matrixButtons[y1, y2].Text == x.ToString() && matrixButtons[y1, y2].Text != "0")
                                        return false;
                                }
                            }
                        }
                    }
                }
            }
            return true;
        }

        public void GenerateSudoku()
        {
            Random rand = new Random();
            for (int i = 0; i < 2; i++) //prva dva broja su neka random 
            {
                int rowRand = 0;
                int colRand = i;
                int numb = rand.Next(1, 9);
                matrixButtons[rowRand, colRand].Text = numb.ToString();
                matrixButtons[rowRand, colRand].ForeColor = Color.Black;
            }
            Solve(matrixButtons[0, 0], 0, 0); // vrtimo backtracking algoritam dok ne dobijemo sudoku
            SudokuSaver(); //spremamo sudoku
            errorCount = 0;
            for (int i = 0; i < diff; i++) // pravimo "krnji" sudoku
            {
                int rowRand = rand.Next(0, 9);
                int colRand = rand.Next(0, 9);
                if (matrixButtons[rowRand, colRand].Text != "0")
                {
                    matrixButtons[rowRand, colRand].Text = "0";
                    matrixButtons[rowRand, colRand].ForeColor = Color.White;
                }
                else if (errorCount < 10)
                    i--;
                errorCount++;
            }

        }

        private bool CheckSudoku(Button b, int row, int col) // provjerava je li odabrani broj u sudoku
        {
            if (x == SudokuSolved[row, col])
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void Clear()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrixButtons[i, j].Text = "0";
                    matrixButtons[i, j].ForeColor = Color.White;
                    matrixButtons[i, j].BackColor = Color.White;
                    matrixButtons[i, j].Enabled = true;
                    x = 0;
                }
            }
        }

        private void ClearButton_Click(object sender, EventArgs e)
        {
            lastClicked.Text = "0";
            lastClicked.ForeColor = Color.FromArgb(187, 222, 251);
            lastClicked.BackColor = Color.FromArgb(187, 222, 251);
        }

        private bool Solve(Button b, int row, int col)
        {
            //provjerava ako se funkcija rekurzivno ponovi vise od 1000 puta da zapocne ispocetka jer sudoku nije moguc
            if (errorCount > 1000)
            {
                Clear();
                errorCount = 0;
                GenerateSudoku();
            }
            // BACKTRACKING ALGORITAM
            if (row == 9)
                return true;
            else if (col == 9)
                return Solve(matrixButtons[row + 1, 0], row + 1, 0);
            else if (matrixButtons[row, col].Text != "0")
                if (col != 8)
                {
                    return Solve(matrixButtons[row, col + 1], row, col + 1);
                }
                else
                {
                    if (row != 8)
                    {
                        return Solve(matrixButtons[row + 1, 0], row + 1, 0);
                    }
                    else
                    {
                        return true;
                    }
                }
            else
            {
                for (int i = 1; i < 10; i++)
                {
                    x = i;
                    if (checkBox(matrixButtons[row, col]) && checkRowsAndColumns(matrixButtons[row, col]))
                    {
                        matrixButtons[row, col].Text = x.ToString();
                        matrixButtons[row, col].ForeColor = Color.Black;
                        errorCount++;
                        if (col != 8)
                        {
                            if (Solve(matrixButtons[row, col + 1], row, col + 1))
                                return true;
                            matrixButtons[row, col].Text = "0";

                        }
                        else if (row != 8)
                        {
                            return Solve(matrixButtons[row + 1, 0], row + 1, 0);
                        }
                        else
                        {
                            return true;
                        }
                    }
                }
                return false;
            }
        }

        private void newGame_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            mistake = 0;
            mistakeLabel.Text = "0/3";
            ClearButton.Enabled = true;
            hintButton.Enabled = true;
            AbleMatrix();
            Clear();

            if (radioButton1.Checked)
                diff = 30;
            else if (radioButton2.Checked)
                diff = 35;
            else if (radioButton3.Checked)
                diff = 45;

            GenerateSudoku();
            EnableNumbButtons();
            wrongButton = new Button[3];

            isPlayed = 1;

        }

        private void SudokuForm_Load(object sender, EventArgs e)
        {
            this.CenterToScreen();
        }

        private void SudokuSaver()
        {
            SudokuSolved = new int[9, 9];

            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    SudokuSolved[i, j] = Int32.Parse(matrixButtons[i, j].Text);
                }
            }

        } // sprema sudoku u matricu

        private void WinnerCheck()
        {
            int temp = 0;
            int w = 0;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    if (matrixButtons[i, j].Text == SudokuSolved[i, j].ToString())
                    {
                        temp++;
                    }
                    if (matrixButtons[i, j].Text != "0")
                    {
                        w++;
                    }

                }
            }
            if (w == 81 && temp == 81)
            {
                MessageBox.Show("Čestitam! Riješili ste sudoku!", "Bravo!");
                DisableNumbButtons();
                ClearButton.Enabled = false;
                hintButton.Enabled = false;
            }
            else if (w == 81)
            {
                MessageBox.Show("Pogrešno riješen sudoku!", "Sudoku");
                DisableNumbButtons();
                ClearButton.Enabled = false;
                hintButton.Enabled = false;
            }
        }

        private void EnableNumbButtons()
        {
            b1.Enabled = true;
            b2.Enabled = true;
            b3.Enabled = true;
            b4.Enabled = true;
            b5.Enabled = true;
            b6.Enabled = true;
            b7.Enabled = true;
            b8.Enabled = true;
            b9.Enabled = true;
        }

        private void DisableNumbButtons()
        {
            b1.Enabled = false;
            b2.Enabled = false;
            b3.Enabled = false;
            b4.Enabled = false;
            b5.Enabled = false;
            b6.Enabled = false;
            b7.Enabled = false;
            b8.Enabled = false;
            b9.Enabled = false;
        }

        private void AbleMatrix()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    matrixButtons[i, j].Enabled = true;
                }
            }
        }

        private void MistakeChecker()
        {
            mistake++;
            if (mistake == 3)
            {
                mistakeLabel.Text = "3/3";
                MessageBox.Show("Izgubio si!", "Sudoku");
                isPlayed = 0;
                DisableNumbButtons();


            }
            else if (mistake == 2)
            {
                mistakeLabel.Text = "2/3";
            }
            else if (mistake == 1)
            {
                mistakeLabel.Text = "1/3";
            }
            else
            {
                mistakeLabel.Text = "0/3";
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Jure Vučko", "About");
        }

        //new click
        private void saveSudokuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            radioButton1.Enabled = true;
            radioButton2.Enabled = true;
            radioButton3.Enabled = true;
            mistake = 0;
            mistakeLabel.Text = "0/3";
            AbleMatrix();
            Clear();

            if (radioButton1.Checked)
                diff = 30;
            else if (radioButton2.Checked)
                diff = 50;
            else if (radioButton3.Checked)
                diff = 65;

            GenerateSudoku();
            EnableNumbButtons();
        }

        //save click
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Rectangle bounds = this.RectangleToScreen(new Rectangle(41, 47, 540, 540));

            Bitmap screenshot = new Bitmap(bounds.Width, bounds.Height);

            using (Graphics graphics = Graphics.FromImage(screenshot))
            {
                graphics.CopyFromScreen(bounds.X, bounds.Y, 0, 0, bounds.Size);
            }

            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Title = "Save Screenshot";
                saveFileDialog.Filter = "PNG Image|*.png";
                saveFileDialog.FileName = "screenshot.png";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    screenshot.Save(saveFileDialog.FileName);
                }
            }
        }

        private bool WrongButtonCheck(Button b)
        {
            if (mistake == 0)
                return false;
            foreach (Button but in wrongButton)
            {
                if (but == b)
                    return true;
            }
            return false;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void hintButton_Click(object sender, EventArgs e)
        {
            if (isPlayed == 1)
            {
                Random rand = new Random();
                int w = 0;
                while (w == 0)
                {
                    x = rand.Next(1, 10); // uzimamo neki random broj i provjeravamo di se nalazi u rijesenoj matrici pa ako je to misto u sudoku jednako 0
                                          //upisujemo ga tamo
                    for (int i = 0; i < 9; i++)
                    {
                        for (int j = 0; j < 9; j++)
                        {

                            if (CheckSudoku(matrixButtons[i, j], i, j) && matrixButtons[i, j].Text == "0")
                            {
                                matrixButtons[i, j].Text = x.ToString();
                                matrixButtons[i, j].ForeColor = Color.Black;
                                matrixButtons[i, j].BackColor = Color.FromArgb(74, 192, 192);
                                w = 1;
                                break;
                            }
                        }
                        if (w == 1)
                            break;
                    }
                }
                WinnerCheck();
            }
        }

        private void SudokuForm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (isPlayed == 1 && Char.IsDigit(e.KeyChar) && e.KeyChar >= '1' && e.KeyChar <= '9')
            {
                x = (int)(e.KeyChar - '0');
                clickedNum = x;
            }
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Made by Jure Vučko\n\nmail: jvucko02@fesb.hr", "Sudoku");
        }

        private void hToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sudoku je logička igra koja se igra na 9x9 ploči podijeljenoj na devet 3x3 područja. Cilj je popuniti svaku ćeliju brojevima od 1 do 9, uz uvjet da se isti brojevi ne ponavljaju u istom retku, stupcu ili području. Početni brojevi već postoje na ploči. Igra se smatra uspješnom kada su sva pravila ispoštovana, a svaka ćelija sadrži jedinstveni broj.\n\nMožete koristiti unos s tipkovnice tako da prvo kliknete na željenu čeliju ili uz pomoć brojeva sastrane tako da prvo odaberete broj, zatim čeliju.", "Sudoku");
        }

    }
}
