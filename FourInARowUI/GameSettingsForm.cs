using System.Windows.Forms;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FourInARowUI;

namespace FourInARowUI
{
    public class GameSettingsForm : Form
    {
        private const string k_AIName = "[Computer]";
       
        private Label labelPlayers;
        private Label labelPlayer1;
        private CheckBox checkBoxPlayer2;
        private TextBox textBoxPlayer1;
        private TextBox textBoxPlayer2;
        private Label labelBoardSize;
        private Label labelRows;
        private Label labelCols;
        private ComboBox comboBoxRows;
        private ComboBox comboBoxCols;
        private Label labelDifficulty;
        private TrackBar trackBarDifficulty;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonStartGame;


        public GameSettingsForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelPlayer1 = new System.Windows.Forms.Label();
            this.checkBoxPlayer2 = new System.Windows.Forms.CheckBox();
            this.textBoxPlayer1 = new System.Windows.Forms.TextBox();
            this.textBoxPlayer2 = new System.Windows.Forms.TextBox();
            this.labelBoardSize = new System.Windows.Forms.Label();
            this.labelRows = new System.Windows.Forms.Label();
            this.labelCols = new System.Windows.Forms.Label();
            this.buttonStartGame = new System.Windows.Forms.Button();
            this.comboBoxRows = new System.Windows.Forms.ComboBox();
            this.comboBoxCols = new System.Windows.Forms.ComboBox();
            this.labelDifficulty = new System.Windows.Forms.Label();
            this.trackBarDifficulty = new System.Windows.Forms.TrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDifficulty)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelPlayers.Location = new System.Drawing.Point(25, 25);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(78, 20);
            this.labelPlayers.TabIndex = 0;
            this.labelPlayers.Text = "Players:";
            // 
            // labelPlayer1
            // 
            this.labelPlayer1.AutoSize = true;
            this.labelPlayer1.Location = new System.Drawing.Point(49, 58);
            this.labelPlayer1.Name = "labelPlayer1";
            this.labelPlayer1.Size = new System.Drawing.Size(73, 17);
            this.labelPlayer1.TabIndex = 1;
            this.labelPlayer1.Text = "Player 1:";
            // 
            // checkBoxPlayer2
            // 
            this.checkBoxPlayer2.AutoSize = true;
            this.checkBoxPlayer2.Location = new System.Drawing.Point(52, 84);
            this.checkBoxPlayer2.Name = "checkBoxPlayer2";
            this.checkBoxPlayer2.Size = new System.Drawing.Size(95, 21);
            this.checkBoxPlayer2.TabIndex = 1;
            this.checkBoxPlayer2.Text = "Player 2:";
            this.checkBoxPlayer2.UseVisualStyleBackColor = true;
            this.checkBoxPlayer2.CheckedChanged += new System.EventHandler(this.checkBoxSecondPlayer_Click);
            // 
            // textBoxPlayer1
            // 
            this.textBoxPlayer1.Location = new System.Drawing.Point(136, 55);
            this.textBoxPlayer1.Name = "textBoxPlayer1";
            this.textBoxPlayer1.Size = new System.Drawing.Size(100, 23);
            this.textBoxPlayer1.TabIndex = 0;
            // 
            // textBoxPlayer2
            // 
            this.textBoxPlayer2.Enabled = false;
            this.textBoxPlayer2.Location = new System.Drawing.Point(136, 82);
            this.textBoxPlayer2.Name = "textBoxPlayer2";
            this.textBoxPlayer2.Size = new System.Drawing.Size(100, 23);
            this.textBoxPlayer2.TabIndex = 2;
            this.textBoxPlayer2.Text = "[Computer]";
            // 
            // labelBoardSize
            // 
            this.labelBoardSize.AutoSize = true;
            this.labelBoardSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelBoardSize.Location = new System.Drawing.Point(21, 204);
            this.labelBoardSize.Name = "labelBoardSize";
            this.labelBoardSize.Size = new System.Drawing.Size(108, 20);
            this.labelBoardSize.TabIndex = 6;
            this.labelBoardSize.Text = "Board Size:";
            // 
            // labelRows
            // 
            this.labelRows.AutoSize = true;
            this.labelRows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelRows.Location = new System.Drawing.Point(25, 237);
            this.labelRows.Name = "labelRows";
            this.labelRows.Size = new System.Drawing.Size(53, 20);
            this.labelRows.TabIndex = 9;
            this.labelRows.Text = "Rows";
            // 
            // labelCols
            // 
            this.labelCols.AutoSize = true;
            this.labelCols.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelCols.Location = new System.Drawing.Point(158, 237);
            this.labelCols.Name = "labelCols";
            this.labelCols.Size = new System.Drawing.Size(44, 20);
            this.labelCols.TabIndex = 10;
            this.labelCols.Text = "Cols";
            // 
            // buttonStartGame
            // 
            this.buttonStartGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.buttonStartGame.Location = new System.Drawing.Point(132, 311);
            this.buttonStartGame.Name = "buttonStartGame";
            this.buttonStartGame.Size = new System.Drawing.Size(221, 32);
            this.buttonStartGame.TabIndex = 5;
            this.buttonStartGame.Text = "Start!";
            this.buttonStartGame.UseVisualStyleBackColor = true;
            this.buttonStartGame.Click += new System.EventHandler(this.buttonStart_Click);
            // 
            // comboBoxRows
            // 
            this.comboBoxRows.FormattingEnabled = true;
            this.comboBoxRows.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxRows.Location = new System.Drawing.Point(82, 236);
            this.comboBoxRows.Name = "comboBoxRows";
            this.comboBoxRows.Size = new System.Drawing.Size(47, 25);
            this.comboBoxRows.TabIndex = 11;
            this.comboBoxRows.Text = "5";
            // 
            // comboBoxCols
            // 
            this.comboBoxCols.FormattingEnabled = true;
            this.comboBoxCols.Items.AddRange(new object[] {
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBoxCols.Location = new System.Drawing.Point(210, 236);
            this.comboBoxCols.Name = "comboBoxCols";
            this.comboBoxCols.Size = new System.Drawing.Size(47, 25);
            this.comboBoxCols.TabIndex = 12;
            this.comboBoxCols.Text = "5";
            // 
            // labelDifficulty
            // 
            this.labelDifficulty.AutoSize = true;
            this.labelDifficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.labelDifficulty.Location = new System.Drawing.Point(21, 133);
            this.labelDifficulty.Name = "labelDifficulty";
            this.labelDifficulty.Size = new System.Drawing.Size(91, 20);
            this.labelDifficulty.TabIndex = 13;
            this.labelDifficulty.Text = "Difficulty:";
            this.labelDifficulty.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // trackBarDifficulty
            // 
            this.trackBarDifficulty.AutoSize = false;
            this.trackBarDifficulty.Location = new System.Drawing.Point(136, 133);
            this.trackBarDifficulty.Maximum = 3;
            this.trackBarDifficulty.Name = "trackBarDifficulty";
            this.trackBarDifficulty.Size = new System.Drawing.Size(130, 20);
            this.trackBarDifficulty.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label1.Location = new System.Drawing.Point(118, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 15);
            this.label1.TabIndex = 15;
            this.label1.Text = "easy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label2.Location = new System.Drawing.Point(159, 156);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 15);
            this.label2.TabIndex = 16;
            this.label2.Text = "meduim";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label3.Location = new System.Drawing.Point(208, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 15);
            this.label3.TabIndex = 17;
            this.label3.Text = "hard";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.label4.Location = new System.Drawing.Point(241, 156);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(70, 15);
            this.label4.TabIndex = 18;
            this.label4.Text = "imposible";
            // 
            // GameSettingsForm
            // 
            this.AcceptButton = this.buttonStartGame;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(475, 368);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.trackBarDifficulty);
            this.Controls.Add(this.labelDifficulty);
            this.Controls.Add(this.comboBoxCols);
            this.Controls.Add(this.comboBoxRows);
            this.Controls.Add(this.buttonStartGame);
            this.Controls.Add(this.labelCols);
            this.Controls.Add(this.labelRows);
            this.Controls.Add(this.labelBoardSize);
            this.Controls.Add(this.textBoxPlayer2);
            this.Controls.Add(this.textBoxPlayer1);
            this.Controls.Add(this.checkBoxPlayer2);
            this.Controls.Add(this.labelPlayer1);
            this.Controls.Add(this.labelPlayers);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(177)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GameSettingsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game Settings";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarDifficulty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void checkBoxSecondPlayer_Click(object sender, System.EventArgs e)
        {
            this.textBoxPlayer2.Enabled = !this.textBoxPlayer2.Enabled;
            textBoxPlayer2.Text = textBoxPlayer2.Enabled ? string.Empty : k_AIName;
            this.trackBarDifficulty.Enabled = textBoxPlayer2.Enabled ? false : true;
            this.labelDifficulty.Enabled = textBoxPlayer2.Enabled ? false : true;
        }

        private void buttonStart_Click(object sender, System.EventArgs e)
        {
            if (this.textBoxPlayer1.Text == string.Empty || this.textBoxPlayer2.Text == string.Empty)
            {
                MessageBox.Show("Please enter proper names (no blanks)", "Error");
            }
            else if(string.IsNullOrEmpty(comboBoxRows.Text) || string.IsNullOrEmpty(comboBoxRows.Text))
            {
                MessageBox.Show("Please enter rows and cols", "Error");
            }
            else
            {
                int rows = int.Parse(BoardRows);
                int cols = int.Parse(BoardCols);
                GameForm gameForm = new GameForm(rows, cols, Player1Name, Player2Name, IsPlayer2AI);
                if(IsPlayer2AI)
                {
                    gameForm.SetDifficulty(trackBarDifficulty.Value);
                }
                this.Dispose();
                gameForm.ShowDialog();
            }
        }

        public string BoardRows
        {
            get { return this.comboBoxRows.SelectedItem.ToString(); }
        }

        public string BoardCols
        {
            get { return this.comboBoxCols.SelectedItem.ToString(); }
        }

        public string Player1Name
        {
            get { return this.textBoxPlayer1.Text; }
        }

        public string Player2Name
        {
            get { return textBoxPlayer2.Text; }
        }

        public bool IsPlayer2AI
        {
            get { return !this.checkBoxPlayer2.Checked; }
        }

       
    }
}
