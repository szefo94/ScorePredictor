// http://www.football-data.co.uk/data.php


using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace ScorePredictor
{
    public partial class ScorePredictor : Form
    {
        private readonly OpenFileDialog openFile = new OpenFileDialog();

        private string[] lines;
        private string fileName;
        private readonly DataTable dt = new DataTable();
        private readonly List<int> resultsA = new List<int>();
        private readonly List<int> resultsB = new List<int>();

        public static double[][] XORIdeal =
        {
            new[] {0.0},
            new[] {1.0},
            new[] {1.0},
            new[] {0.0}
        };

        public ScorePredictor()
        {
            InitializeComponent();
        }

        private void btnLoadFile_Click(object sender, EventArgs e)
        {
            //saving data from csv to DataTable
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                labelStatus.Text = "file opened";

                fileName = openFile.FileName;
                lines = File.ReadAllLines(fileName);
                if (lines.Length > 0)
                {
                    var firstLine = lines[0];
                    var headerLabels = firstLine.Split(',');

                    foreach (var headerWord in headerLabels) dt.Columns.Add(new DataColumn(headerWord));
                    for (var r = 1; r < lines.Length; r++)
                    {
                        var dataWords = lines[r].Split(',');
                        var dr = dt.NewRow();
                        var columnIndex = 0;
                        foreach (var headerWord in headerLabels) dr[headerWord] = dataWords[columnIndex++];
                        dt.Rows.Add(dr);
                    }
                }

                if (dt.Rows.Count > 0) dataGridView1.DataSource = dt;
            }

            updateComboBoxes();
        }

        private void updateComboBoxes()
        {
            int i = 1, j;
            for (j = 5; j < 7; j++)
            for (i = 1; i < dt.Rows.Count; i++)
                if (comboA.Items.Contains(dt.Rows[i][j]))
                {
                    i++;
                }
                else
                {
                    comboA.Items.Add(dt.Rows[i][j]);
                    comboB.Items.Add(dt.Rows[i][j]);
                }
        }

        private void btnPredict_Click(object sender, EventArgs e)
        {
            var matchCount = 0;
            labelStatus.Text = "searching for matches";
            labelHelper.Text = comboA.SelectedItem.ToString();

            var n = 0; // n jako licznik tabeli A
            int scoreA = 0, scoreB = 0;
            for (var k = 0; k < dt.Rows.Count; k++)
                if (comboA.SelectedItem.ToString().Equals(dt.Rows[k][5].ToString()) &&
                    comboB.SelectedItem.ToString().Equals(dt.Rows[k][6].ToString()))
                {
                    if (int.Parse(dt.Rows[k][7].ToString()) > int.Parse(dt.Rows[k][8].ToString()))
                    {
                        scoreA += 2;
                        resultsA.Add(2);
                        resultsB.Add(0);
                    }
                    else if (int.Parse(dt.Rows[k][7].ToString()) == int.Parse(dt.Rows[k][8].ToString()))
                    {
                        scoreA++;
                        scoreB++;

                        resultsA.Add(1);
                        resultsB.Add(1);
                    }
                    else
                    {
                        scoreB += 2;

                        resultsA.Add(0);
                        resultsB.Add(2);
                    }

                    n++;
                    matchCount++;
                }
                else if (comboB.SelectedItem.ToString().Equals(dt.Rows[k][5].ToString()) &&
                         comboA.SelectedItem.ToString().Equals(dt.Rows[k][6].ToString()))
                {
                    if (int.Parse(dt.Rows[k][7].ToString()) < int.Parse(dt.Rows[k][8].ToString()))
                    {
                        scoreA += 2;
                        resultsA.Add(2);
                        resultsB.Add(0);
                    }
                    else if (int.Parse(dt.Rows[k][7].ToString()) == int.Parse(dt.Rows[k][8].ToString()))
                    {
                        scoreB++;
                        scoreA++;
                        resultsA.Add(1);
                        resultsB.Add(1);
                    }
                    else
                    {
                        scoreB += 2;
                        resultsA.Add(0);
                        resultsB.Add(2);
                    }

                    n++;
                    matchCount++;
                }

            labelA.Text = scoreA.ToString();
            labelB.Text = scoreB.ToString();

            label3.Text = "Matches count: ";
            labelStatus.Text = matchCount.ToString();

            var results = new int[resultsA.Count + 1, 2];
            for (var g = 0; g < resultsA.Count; g++) results[g, 0] = resultsA[g];
            for (var g = 0; g < resultsB.Count; g++) results[g, 1] = resultsB[g];

            var resultString = (scoreA / (scoreA + (double) scoreB) * 100).ToString("#") + "%";

            labelPrediction.Text = resultString;
            label3.Text = "Status:";
            labelStatus.Text = "Predicted";
        }

        private void comboB_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void labelStatus_Click(object sender, EventArgs e)
        {
        }
    }
}