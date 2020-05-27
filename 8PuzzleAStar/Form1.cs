using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _8PuzzleAStar
{
    public partial class Form1 : Form
    {
        Node node;

        int[,] StartState;
        int[,] GoalState;

        public Form1()
        {
            InitializeComponent();
            node = new Node();
            populateStartInitialState();
            populateGoalInitialState();
        }

        public void solve()
        {

            bool found = false;
            int depth = 0;

            int maxDepth = 50;

            List<Node> FrontHere = new List<Node>();
            List<Node> Checked = new List<Node>();
            List<string> actions = new List<string>();

            setStartState();
            setGoalState();

            if (GoalState == null || StartState == null)
            {
                MessageBox.Show("Eksik seçim yaptınız!");
                return;
            }

            Node start = new Node()
            {
                state = StartState,
                depth = 0
            };
            FrontHere.Add(start);

            void printState(int[,] state)
            {
                string str = "";

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        str += state[j, i] + " ";
                    }
                    str += "\n";
                }
                stepsLog.Text += str + "\n";
            }


            bool canRight(int[,] state)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (state[i, 2] == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool canLeft(int[,] state)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (state[i, 0] == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool canUp(int[,] state)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (state[0, i] == 0)
                    {
                        return false;
                    }
                }
                return true;
            }
            bool canDown(int[,] state)
            {
                for (int i = 0; i < 3; i++)
                {
                    if (state[2, i] == 0)
                    {
                        return false;
                    }
                }
                return true;
            }



            int[,] rightMove(int[,] state)
            {
                int[,] temp = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        temp[height, width] = state[height, width];
                    }
                }

                int j = zeroPosition(state, false);
                int i = zeroPosition(state);

                temp[j, i] = state[j, i + 1];
                temp[j, i + 1] = 0;

                return temp;
            }
            int[,] leftMove(int[,] state)
            {
                int[,] temp = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        temp[height, width] = state[height, width];
                    }
                }

                int j = zeroPosition(state, false);
                int i = zeroPosition(state);

                temp[j, i] = state[j, i - 1];
                temp[j, i - 1] = 0;

                return temp;
            }
            int[,] upMove(int[,] state)
            {
                int[,] temp = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        temp[height, width] = state[height, width];
                    }
                }

                int j = zeroPosition(state, false);
                int i = zeroPosition(state);

                temp[j, i] = state[j - 1, i];
                temp[j - 1, i] = 0;

                return temp;
            }
            int[,] downMove(int[,] state)
            {
                int[,] temp = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        temp[height, width] = state[height, width];
                    }
                }

                int j = zeroPosition(state, false);
                int i = zeroPosition(state);

                temp[j, i] = state[j + 1, i];
                temp[j + 1, i] = 0;

                return temp;
            }

            int zeroPosition(int[,] state, bool width = true)
            {
                int temp = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (state[j, i] == 0)
                        {
                            if (width == true)
                                temp = i;
                            else
                                temp = j;
                        }
                    }
                }
                return temp;
            }

            bool isCheck(int[,] state)
            {
                bool temp = false;

                foreach (Node nd in Checked)
                {
                    if (match_array(nd.state, state))
                    {
                        temp = true;
                    }
                }

                return temp;
            }

            bool match_array(int[,] arr1, int[,] arr2)
            {
                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (arr1[j, i] != arr2[j, i]) return false;
                    }
                }

                return true;
            }

            string getAction(int[,] state)
            {
                foreach (Node nd in Checked)
                {
                    if (match_array(nd.state, state))
                    {
                        return nd.action;
                    }
                }
                return "none";
            }

            void printSteps(int[,] state, string action)
            {
                int[,] currentState = state;

                if (action == "rightMove")
                {
                    currentState = leftMove(currentState);
                    actions.Add("rightMove");
                }

                else if (action == "leftMove")
                {
                    currentState = rightMove(currentState);
                    actions.Add("leftMove");
                }
                else if (action == "upMove")
                {
                    currentState = downMove(currentState);
                    actions.Add("upMove");
                }
                else if (action == "downMove")
                {
                    currentState = upMove(currentState);
                    actions.Add("downMove");
                }

                while (!match_array(currentState, StartState))
                {
                    string current_action = getAction(currentState);

                    if (current_action == "rightMove")
                    {
                        currentState = leftMove(currentState);
                        actions.Add("rightMove");
                    }

                    else if (current_action == "leftMove")
                    {
                        currentState = rightMove(currentState);
                        actions.Add("leftMove");
                    }
                    else if (current_action == "upMove")
                    {
                        currentState = downMove(currentState);
                        actions.Add("upMove");
                    }
                    else if (current_action == "downMove")
                    {
                        currentState = upMove(currentState);
                        actions.Add("downMove");
                    }
                }


                stepsLog.Text += ("Adımlar ("+actions.Count+") : \n");
                printState(StartState);

                for (int a = actions.Count - 1; a >= 0; a--)
                {

                    if (actions[a] == "rightMove")
                    {
                        currentState = rightMove(currentState);
                    }

                    else if (actions[a] == "leftMove")
                    {
                        currentState = leftMove(currentState);
                    }
                    else if (actions[a] == "upMove")
                    {
                        currentState = upMove(currentState);
                    }
                    else if (actions[a] == "downMove")
                    {
                        currentState = downMove(currentState);
                    }



                    printState(currentState);
                }
            }

            int control(int[,] state)
            {
                int match = 0;

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        if (state[j, i] == GoalState[j, i]) match++;
                    }
                }

                return 9 - match;
            }

            Node getState()
            {
                Node temp = new Node();
                int index = 0;
                int selectedIndex = 0;
                int min_f = maxDepth + 9;
                foreach (Node nd in FrontHere)
                {
                    if (nd.depth + control(nd.state) < min_f)
                    {
                        min_f = nd.depth + control(nd.state);
                        temp.state = nd.state;
                        temp.depth = nd.depth;
                        temp.action = nd.action;
                        selectedIndex = index;
                    }
                    index++;
                }

                FrontHere.RemoveAt(selectedIndex);

                return temp;
            }


            stepsLog.Text += ("Başlangıç Durumu:\n");
            printState(StartState);
            stepsLog.Text += ("Hedef Durum:\n");
            printState(GoalState);


            while (FrontHere.Count != 0 && !found && depth <= maxDepth)
            {
                Node bestResult = getState();
                if (match_array(bestResult.state, GoalState))
                {
                    printSteps(bestResult.state, bestResult.action);
                    found = true;
                }
                else
                {

                    if (canRight(bestResult.state) && !isCheck(rightMove(bestResult.state)))
                    {
                        Node data = new Node();
                        data.depth = bestResult.depth + 1;
                        data.state = rightMove(bestResult.state);
                        data.action = "rightMove";

                        FrontHere.Add(data);
                    }

                    if (canLeft(bestResult.state) && !isCheck(leftMove(bestResult.state)))
                    {
                        Node data = new Node();
                        data.depth = bestResult.depth + 1;
                        data.state = leftMove(bestResult.state);
                        data.action = "leftMove";

                        FrontHere.Add(data);
                    }

                    if (canUp(bestResult.state) && !isCheck(upMove(bestResult.state)))
                    {
                        Node data = new Node();
                        data.depth = bestResult.depth + 1;
                        data.state = upMove(bestResult.state);
                        data.action = "upMove";

                        FrontHere.Add(data);
                    }

                    if (canDown(bestResult.state) && !isCheck(downMove(bestResult.state)))
                    {
                        Node data = new Node();
                        data.depth = bestResult.depth + 1;
                        data.state = downMove(bestResult.state);
                        data.action = "downMove";

                        FrontHere.Add(data);
                    }

                    depth = bestResult.depth;
                    Checked.Add(bestResult);
                }
            }
            if (depth > maxDepth)
            {
                Console.WriteLine("Can't Solve!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            solve();
        
        }

        private void removeTextsFromButtons(Control groupBox)
        {
            foreach (Control c in groupBox.Controls)
            {
                if (c is Button)
                {
                    c.Text = "";
                }
            }
        }

        private void refreshButtons(Control groupBox)
        {
            foreach (Control c in groupBox.Controls)
            {
                if (!c.Enabled)
                {
                    c.Enabled = true;
                }
            }
        }

        private void startStateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (startStateCB.Checked)
            {
                startStateGB.Enabled = true;
                removeTextsFromButtons(startStateSelected);
                refreshButtons(startStateGB);
            }
            else
            {
                startStateGB.Enabled = false;

                populateStartInitialState();


            }
        }

        private void goalStateCB_CheckedChanged(object sender, EventArgs e)
        {
            if (goalStateCB.Checked)
            {
                goalStateGB.Enabled = true;
                removeTextsFromButtons(goalStateSelected);
                refreshButtons(startStateGB);
            }
            else
            {
                goalStateGB.Enabled = false;

                populateGoalInitialState();

            }
        }

        int counter = 0;

        private void startButtons_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            string buttonText = b.Text;

            Control groupBox = startStateSelected;

            List<Button> buttons = groupBox.Controls.OfType<Button>().ToList();

            buttons[counter].Text = buttonText;

            counter++;

            if (counter == 9)
            {
                counter = 0;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            counter = 0;
            removeTextsFromButtons(startStateSelected);
            refreshButtons(startStateGB);

        }

        ToolTip toolTip = new ToolTip();

        private void button2_MouseHover(object sender, EventArgs e)
        {
            toolTip.UseFading = true;
            toolTip.UseAnimation = true;
            toolTip.IsBalloon = true;
            toolTip.ShowAlways = true;
            toolTip.AutoPopDelay = 5000;
            toolTip.InitialDelay = 500;
            toolTip.BackColor = Color.Black;

            toolTip.SetToolTip((Button)sender, "Seçtiğiniz başlangıç durumunu buraya tıklayarak yenileyebilirsiniz.");
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            counter2 = 0;
            removeTextsFromButtons(goalStateSelected);
            refreshButtons(goalStateGB);
        }

        int counter2 = 0;
        private void goalButton1_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            b.Enabled = false;
            string buttonText = b.Text;

            Control groupBox = goalStateSelected;

            List<Button> buttons = groupBox.Controls.OfType<Button>().ToList();

            buttons[counter2].Text = buttonText;

            counter2++;

            if (counter2 == 9)
            {
                counter2 = 0;
            }
        }

        private void populateStartInitialState()
        {
            Control groupBox = startStateSelected;

            List<Button> buttons = groupBox.Controls.OfType<Button>().ToList();

            int[,] StartInitialState = new int[,] {
                { 1 , 3 , 2 },
                { 8 , 0 , 4 },
                { 5 , 6 , 7 }
            };

            List<int> arr = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr.Add(StartInitialState[i, j]);
                }
            }

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Text = arr[i].ToString();
            }
        }

        private void populateGoalInitialState()
        {
            Control groupBox = goalStateSelected;

            List<Button> buttons = groupBox.Controls.OfType<Button>().ToList();

            int[,] GoalInitialState = new int[,] {
                { 1 , 2 , 3 },
                { 8 , 0 , 4 },
                { 7 , 6 , 5 }
            };

            List<int> arr = new List<int>();

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    arr.Add(GoalInitialState[i, j]);
                }
            }

            for (int i = 0; i < buttons.Count; i++)
            {
                buttons[i].Text = arr[i].ToString();
            }
        }

        private void setStartState()
        {
            Control groupBox = startStateSelected;

            List<Button> buttons = groupBox.Controls.OfType<Button>().ToList();

            int[,] numbers = new int[3, 3];

            if (!buttons.Any(x => x.Text.Equals(string.Empty)))
            {
                int i = 0;
                for (int m = 0; m < 3; m++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        numbers[m, n] = int.Parse(buttons[i].Text);
                        i++;
                    }
                }

                StartState = numbers;
            }
            else
            {
                StartState = null;
            }
        }

        private void setGoalState()
        {

            Control groupBox = goalStateSelected;

            List<Button> buttons = groupBox.Controls.OfType<Button>().ToList();

            int[,] numbers = new int[3, 3];

            if (!buttons.Any(x => x.Text.Equals(string.Empty)))
            {
                int i = 0;
                for (int m = 0; m < 3; m++)
                {
                    for (int n = 0; n < 3; n++)
                    {
                        numbers[m, n] = int.Parse(buttons[i].Text);
                        i++;
                    }
                }

                GoalState = numbers;
            }
            else
            {
                GoalState = null;
            }

        }



    }
}
