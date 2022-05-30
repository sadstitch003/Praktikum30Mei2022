using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Praktikum30Mei2022
{
    public partial class FormTeam : Form
    {
        MySqlConnection sqlConnect = new MySqlConnection("server=localhost;uid=root;pwd=;database=premier_league");
        MySqlCommand sqlCommand;
        MySqlDataAdapter sqlAdapter;
        string sqlQuery;

        DataTable dtTeam;
        int index = 0;

        void updateTable()
        {
            dtTeam = new DataTable();
            sqlQuery = "SELECT * FROM team t LEFT JOIN manager m ON m.manager_id = t.manager_id LEFT JOIN nationality n ON m.nationality_id = n.nationality_id;";
            sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
            sqlAdapter = new MySqlDataAdapter(sqlCommand);
            sqlAdapter.Fill(dtTeam);
        }

        void isiDataTeam(int indexTeam)
        {
            try
            {
                LblTeam.Text = dtTeam.Rows[indexTeam]["team_name"].ToString();
                LblManager.Text = $"{dtTeam.Rows[indexTeam]["manager_name"].ToString()} ({dtTeam.Rows[indexTeam]["nation"].ToString()})";
                LblStadium.Text = $"{dtTeam.Rows[indexTeam]["home_stadium"].ToString()}, {dtTeam.Rows[indexTeam]["city"].ToString()} ({dtTeam.Rows[indexTeam]["capacity"].ToString()})";

                sqlConnect.Open();
                sqlQuery = $"SELECT CONCAT(player_name, ' (', goal_penalty,')') FROM (SELECT p.player_name AS 'player_name', SUM(type = 'GO' OR type = 'GP'), SUM(type = 'GP') AS 'goal_penalty' FROM `dmatch` dm LEFT JOIN player p ON p.player_id = dm.player_id WHERE dm.team_id = '{dtTeam.Rows[indexTeam]["team_id"].ToString()}' GROUP BY dm.player_id ORDER BY 2 DESC LIMIT 1) dt;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                LblTopScorer.Text = sqlCommand.ExecuteScalar().ToString();

                sqlQuery = $"SELECT CONCAT(player_name,', ', yellow_card, ' Yellow Card and ', red_card, ' Red Card') FROM(SELECT p.player_name AS 'player_name', SUM(IF(type = 'CY', 1, 3)), SUM(type = 'CY') AS 'yellow_card', SUM(type = 'CR') AS 'red_card' FROM `dmatch` dm LEFT JOIN player p ON p.player_id = dm.player_id WHERE dm.team_id = '{dtTeam.Rows[indexTeam]["team_id"].ToString()}' AND (dm.type = 'CY' OR dm.type = 'CR') GROUP BY dm.player_id ORDER BY 2 DESC LIMIT 1) dt;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                LblWorstDiscipline.Text = sqlCommand.ExecuteScalar().ToString();
                sqlConnect.Close();

                DataTable dtMatch = new DataTable();
                sqlQuery = $"SELECT * FROM (SELECT m.match_date, IF(m.team_home = '{dtTeam.Rows[indexTeam]["team_id"].ToString()}', 'HOME', 'AWAY') AS 'Home / Away', CONCAT('vs ', IF(m.team_home = '{dtTeam.Rows[indexTeam]["team_id"].ToString()}', tAway.team_name, tHome.team_name)) AS 'Lawan', CONCAT(goal_home, ' - ', goal_away) AS 'Score' FROM `match` m LEFT JOIN team tHome ON m.team_home = tHome.team_id LEFT JOIN team tAway ON tAway.team_id = m.team_away WHERE m.team_home = '{dtTeam.Rows[indexTeam]["team_id"].ToString()}' OR m.team_away = '{dtTeam.Rows[indexTeam]["team_id"].ToString()}' ORDER BY m.match_id DESC LIMIT 5) dt ORDER BY 1;";
                sqlCommand = new MySqlCommand(sqlQuery, sqlConnect);
                sqlAdapter = new MySqlDataAdapter(sqlCommand);
                sqlAdapter.Fill(dtMatch);
                DgvMatch.DataSource = dtMatch;
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        public FormTeam()
        {
            InitializeComponent();
        }

        private void FormTeam_Load(object sender, EventArgs e)
        {
            updateTable();
            isiDataTeam(0);
        }

        private void BtnFirst_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > 0)
                {
                    index = 0;
                    isiDataTeam(index);
                }
                else MessageBox.Show("Sudah data pertama !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnPrev_Click(object sender, EventArgs e)
        {
            try
            {
                if (index > 0)
                {
                    index--;
                    isiDataTeam(index);
                }
                else MessageBox.Show("Sudah data pertama !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < dtTeam.Rows.Count - 1)
                {
                    index++;
                    isiDataTeam(index);
                }
                else MessageBox.Show("Sudah data terakhir !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void BtnLast_Click(object sender, EventArgs e)
        {
            try
            {
                if (index < dtTeam.Rows.Count - 1)
                {
                    index = dtTeam.Rows.Count - 1;
                    isiDataTeam(index);
                }
                else MessageBox.Show("Sudah data terakhir !");
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }
    }
}
