using Accord;
using Accord.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SimulatedAnnealing1000
{
    public partial class Form1 : Form
    {
        private static Random random;
        private static int point = 1000;
        private double[,] map = null;
        double[,] edge = null;
        List<List<int>> lstEdge = null;// Danh sách các điểm có thể đi tới
        private double currTemp;        // Nhiệt độ hiện thời
        private double alpha;           // Tốc độ làm lạnh
        private int maxIteration;       // Giới hạn vòng lặp
        private int start;
        private int end;
        int c = 0;
        private Thread workerThread = null;
        bool first = true;
        private volatile bool needToStop = false;

        public Form1()
        {
            InitializeComponent();

            // set up map control
            mapControl.RangeX = new Range(0, 1000);
            mapControl.RangeY = new Range(0, 1000);
            mapControl.AddDataSeries("map", Color.Red, Chart.SeriesType.Dots, 4, false);// điểm
            mapControl.AddDataSeries("edge", Color.Pink, Chart.SeriesType.Line, 1, false);// cạnh
            GenerateMap();
            first = false;
        }

        private void GenerateMap()
        {
            Random rand = new Random((int)DateTime.Now.Ticks);
            // tạo 1000 điểm
            map = new double[point, 2];
            for (int i = 0; i < point; i++)
            {
                map[i, 0] = rand.Next(1001);
                map[i, 1] = rand.Next(1001);
            }

            // tạo cạnh ngẫu nhiên
            edge = new double[point, point];
            double d = 0;
            random = new Random(0);
            for (int i = 0; i < point; i++)
            {
                for (int j = 0; j < point; j++)
                {
                    if (i == j)
                        edge[i, j] = 0;
                    else
                    {
                        d = Math.Sqrt(Math.Pow((map[i, 0] - map[j, 0]), 2) + Math.Pow((map[i, 1] - map[j, 1]), 2));
                        //if (random.NextDouble() > 0.99)
                        if (d < 80)//60
                        {
                            edge[i, j] = d;
                        }
                        else
                            edge[i, j] = 9999;
                    }
                }
            }

            // reset map
            if (!first)
            {
                for (int i = 0; i < c; i++)
                {
                    mapControl.RemoveDataSeries("edge" + i);
                }
                mapControl.UpdateDataSeries("start", null);
                mapControl.UpdateDataSeries("end", null);
                mapControl.UpdateDataSeries("state", null);
            }

            // show edge
            double[,] t = new double[2, 2];
            c = 0;
            for (int i=0; i<point; i++)
            {
                t[0, 0] = map[i, 0];
                t[0, 1] = map[i, 1];
                for(int j=0; j<point; j++)
                {
                    if (edge[i, j] != 9999 && edge[i, j] != 0)
                    {
                        t[1, 0] = map[j, 0];
                        t[1, 1] = map[j, 1];
                        mapControl.AddDataSeries("edge" + c, Color.Pink, Chart.SeriesType.Line, 1, false);
                        mapControl.UpdateDataSeries("edge" + c, t);
                        c++;
                    }
                }
            }

            // set the map
            mapControl.UpdateDataSeries("map", map);

            // Tạo ds điểm có thể đi tới từ điểm hiện tại
            lstEdge = new List<List<int>>();
            for (int i = 0; i < point; i++)
            {
                List<int> lst = new List<int>();
                for (int j = 0; j < point; j++)
                {
                    if (edge[i, j] != 9999 && edge[i, j] != 0)
                    {
                        lst.Add(j);
                    }
                }
                lstEdge.Add(lst);
            }

        }

        void SearchSolution()
        {
            double[,] se = new double[1, 2];
            se[0, 0] = map[start - 1, 0];
            se[0, 1] = map[start - 1, 1];
            mapControl.RemoveDataSeries("start");
            mapControl.AddDataSeries("start", Color.Green, Chart.SeriesType.Dots, 7, false);
            mapControl.UpdateDataSeries("start", se);
            se[0, 0] = map[end - 1, 0];
            se[0, 1] = map[end - 1, 1];
            mapControl.RemoveDataSeries("end");
            mapControl.AddDataSeries("end", Color.Yellow, Chart.SeriesType.Dots, 7, false);
            mapControl.UpdateDataSeries("end", se);

            random = new Random(0);
                
            // Tạo trạng thái ngẫu nhiên.
            int[] state = RandomState(start, end);
            // Tính toán năng lượng của trạng thái.
            double energy = Energy(state);

            // Trạng thái tốt nhất hiện tại
            int[] bestState = state;
            double bestEnergy = energy;

            // Trạng thái liền kề: adjacent
            int[] adjState;
            double adjEnergy;

            // Số lần lặp
            int iteration = 0;

            // Quá trình tìm kiếm
            ListViewItem item = null;

            while (!needToStop && iteration < maxIteration && currTemp > 0.0001)
            //while (currTemp > 0.0001)
            {
                adjState = AdjacentState(state);
                adjEnergy = Energy(adjState);

                // Kiểm tra xem trạng thái liền kề có phải là trạng thái mới tốt hơn hay không.
                if (adjEnergy < bestEnergy)
                {
                    bestState = adjState;
                    bestEnergy = adjEnergy;

                    double[,] tmp = new double[bestState.Length, 2];
                    int dem = 0;
                    while (dem < bestState.Length)
                    {
                        tmp[dem, 0] = map[bestState[dem] - 1, 0];
                        tmp[dem, 1] = map[bestState[dem] - 1, 1];
                        dem++;
                    }
                    ShowRoad(tmp);

                    item = AddListItem(listView1, bestEnergy.ToString());
                }
                // Nếu trạng thái liền kề tốt hơn, hãy chấp nhận trạng thái với xác suất thay đổi.
                double p = random.NextDouble();
                if (AcceptanceProb(energy, adjEnergy, currTemp) > p)
                {
                    state = adjState;
                    energy = adjEnergy;
                }

                // Giảm nhiệt độ và tăng bộ đếm lặp.
                currTemp = currTemp * alpha;
                iteration++;

                SetText(currentIterationBox, iteration.ToString());
                SetText(currentTempBox, currTemp.ToString());
            }
            // enable settings controls
            EnableControls(true);
        }

        int[] RandomState(int s, int e)
        {
            int[] state = new int[100000];
            int j = s;
            state[0] = s;
            int d = 1;
            while(j != e)
            {
                int w = random.Next(0, lstEdge[j-1].Count);
                state[d] = lstEdge[j-1][w] + 1;
                j = state[d];
                d++;
            }

            // Tinh chỉnh lại mảng đường đi
            int l = 1;
            for (int i = 1; i < state.Length; i++)
            {
                if (state[i] == 0)
                    break;
                l++;
            }
            int[] tmp = new int[l];
            for (int i = 0; i < l; i++)
            {
                tmp[i] = state[i];
            }

            return tmp;
        }

        void ShowRoad(double[,] state)
        {
            mapControl.RemoveDataSeries("state");
            mapControl.AddDataSeries("state", Color.Blue, Chart.SeriesType.Line, 1, false);
            mapControl.UpdateDataSeries("state", state);
        }

        int[] AdjacentState(int[] currState)
        {
            int[] state = new int[100000];
            int r = random.Next(1, currState.Length - 1);
            //int r = random.Next(1, currState.Length/2);
            for (int i = 0; i < r; i++)
                state[i] = currState[i];
            int e = currState[currState.Length - 1] - 1;
            int j = currState[r - 1] - 1;
            int w = random.Next(0, lstEdge[j].Count);
            while (lstEdge[j][w] == currState[r] - 1)
            {
                w = random.Next(0, lstEdge[j].Count);
            }
            state[r] = lstEdge[j][w] + 1;

            int s = state[r] - 1;
            r++;
            while (s != e)
            {
                int ww = random.Next(0, lstEdge[s].Count);
                state[r] = lstEdge[s][ww] + 1;
                s = state[r] - 1;
                r++;
            }

            int l = 1;
            for (int i = 1; i < state.Length; i++)
            {
                if (state[i] == 0)
                    break;
                l++;
            }
            int[] tmp = new int[l];
            for (int i = 0; i < l; i++)
            {
                tmp[i] = state[i];
            }
            return tmp;
        }

        double Energy(int[] state)
        {
            double result = 0.0;
            for (int t = 0; t < state.Length - 1; ++t)
            {
                result += edge[state[t]-1, state[t+1]-1];
            }
            return result;
        }

        static double AcceptanceProb(double energy, double adjEnergy, double currTemp)
        {
            if (adjEnergy < energy)
                return 1.0;
            else
                return Math.Exp((energy - adjEnergy) / currTemp);
        }

        private void generateMapButton_Click(object sender, EventArgs e)
        {
            GenerateMap();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            try
            {
                alpha = Math.Max(0.1, Math.Min(1, double.Parse(coolingRateBox.Text)));
            }
            catch
            {
                alpha = 0.995;
            }
            // get current temp
            try
            {
                currTemp = Math.Max(0, double.Parse(currTempBox.Text));
            }
            catch
            {
                currTemp = 1000000;
            }
            // get iterations limit
            try
            {
                maxIteration = Math.Max(0, int.Parse(iterationsBox.Text));
            }
            catch
            {
                maxIteration = 1000000;
            }
            // get start
            try
            {
                start = int.Parse(txtstart.Text);
            }
            catch
            {
                start = 1;
            }
            // get end
            try
            {
                end = int.Parse(txtend.Text);
            }
            catch
            {
                end = 1000;
            }

            // update settings controls
            UpdateSettings();

            // disable all settings controls
            EnableControls(false);

            ClearSolution();

            // run worker thread
            needToStop = false;
            workerThread = new Thread(new ThreadStart(SearchSolution));
            workerThread.Start();

        }

        private delegate void SetTextCallback(System.Windows.Forms.Control control, string text);
        private void SetText(System.Windows.Forms.Control control, string text)
        {
            if (control.InvokeRequired)
            {
                SetTextCallback d = new SetTextCallback(SetText);
                Invoke(d, new object[] { control, text });
            }
            else
            {
                control.Text = text;
            }
        }
        private void UpdateSettings()
        {
            coolingRateBox.Text = alpha.ToString();
            currTempBox.Text = currTemp.ToString();
            iterationsBox.Text = maxIteration.ToString();
        }
        // Delegates to enable async calls for setting controls properties
        private delegate void EnableCallback(bool enable);

        // Enable/disale controls (safe for threading)
        private void EnableControls(bool enable)
        {
            if (InvokeRequired)
            {
                EnableCallback d = new EnableCallback(EnableControls);
                Invoke(d, new object[] { enable });
            }
            else
            {
                coolingRateBox.Enabled = enable;
                currTempBox.Enabled = enable;
                iterationsBox.Enabled = enable;

                txtstart.Enabled = enable;
                txtend.Enabled = enable;

                generateMapButton.Enabled = enable;
                startButton.Enabled = enable;
                stopButton.Enabled = !enable;
            }
        }
        private void ClearSolution()
        {
            listView1.Items.Clear();
            currentIterationBox.Text = string.Empty;
            currentTempBox.Text = string.Empty;
        }

        private delegate ListViewItem AddListItemCallback(System.Windows.Forms.ListView control, string itemText);
        private ListViewItem AddListItem(System.Windows.Forms.ListView control, string itemText)
        {
            ListViewItem item = null;

            if (control.InvokeRequired)
            {
                AddListItemCallback d = new AddListItemCallback(AddListItem);
                item = (ListViewItem)Invoke(d, new object[] { control, itemText });
            }
            else
            {
                item = control.Items.Add(itemText);
            }

            return item;
        }

        private void stopButton_Click(object sender, EventArgs e)
        {
            // stop worker thread
            needToStop = true;
            while (!workerThread.Join(100))
                Application.DoEvents();
            workerThread = null;
        }
    }
}
