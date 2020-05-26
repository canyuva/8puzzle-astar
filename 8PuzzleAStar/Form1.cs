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
        public Form1()
        {
            InitializeComponent();
             node = new Node();
            populateStartInitialState();
            populateGoalInitialState();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            bool found = false;
            int selected_depth = 0;

            int Max_Depth = 50;

            List<Node> FrontHere = new List<Node>();
            List<Node> Checked = new List<Node>();
            List<string> actions = new List<string>();

            int[,] GoalState = new int[,] {
                { 1 , 3 , 2 },
                { 8 , 0 , 4 },
                { 5 , 6 , 7 }
            };

            int[,] StartState = new int[,] {
                { 1 , 2 , 3 },
                { 8 , 0 , 4 },
                { 7 , 6 , 5 }
            };

            Node start = new Node()
            {
                state = StartState,
                depth = 0
            };
            FrontHere.Add(start);

            void print_state(int[,] state)
            {
                string to_print = "";

                for (int j = 0; j < 3; j++)
                {
                    for (int i = 0; i < 3; i++)
                    {
                        to_print += state[j, i] + " ";
                    }
                    to_print += "\n";
                }
                stepsLog.Text += to_print + "\n";
            }


            bool can_right(int[,] state)
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
            bool can_left(int[,] state)
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
            bool can_up(int[,] state)
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
            bool can_down(int[,] state)
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



            int[,] right(int[,] state)
            {
                int[,] what = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        what[height, width] = state[height, width];
                    }
                }

                int j = zero_position(state, false);
                int i = zero_position(state);

                what[j, i] = state[j, i + 1];
                what[j, i + 1] = 0;

                return what;
            }
            int[,] left(int[,] state)
            {
                int[,] what = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        what[height, width] = state[height, width];
                    }
                }

                int j = zero_position(state, false);
                int i = zero_position(state);

                what[j, i] = state[j, i - 1];
                what[j, i - 1] = 0;

                return what;
            }
            int[,] up(int[,] state)
            {
                int[,] what = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        what[height, width] = state[height, width];
                    }
                }

                int j = zero_position(state, false);
                int i = zero_position(state);

                what[j, i] = state[j - 1, i];
                what[j - 1, i] = 0;

                return what;
            }
            int[,] down(int[,] state)
            {
                int[,] what = new int[,] {
                    { 1 , 2 , 3 },
                    { 4 , 5 , 6 },
                    { 7 , 0 , 8 }
                };
                for (int height = 0; height < 3; height++)
                {
                    for (int width = 0; width < 3; width++)
                    {
                        what[height, width] = state[height, width];
                    }
                }

                int j = zero_position(state, false);
                int i = zero_position(state);

                what[j, i] = state[j + 1, i];
                what[j + 1, i] = 0;

                return what;
            }

            int zero_position(int[,] state, bool width = true)
            {
                int what = 0;

                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (state[j, i] == 0)
                        {
                            if (width == true)
                                what = i;
                            else
                                what = j;
                        }
                    }
                }
                return what;
            }

            bool was_checked(int[,] state)
            {
                bool what = false;

                foreach (Node nd in Checked)
                {
                    if (match_array(nd.state, state))
                    {
                        what = true;
                    }
                }

                return what;
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

            string get_action(int[,] state)
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

            void print_path(int[,] state, string action)
            {
                int[,] current_state = state;

                if (action == "right")
                {
                    current_state = left(current_state);
                    actions.Add("right");
                }

                else if (action == "left")
                {
                    current_state = right(current_state);
                    actions.Add("left");
                }
                else if (action == "up")
                {
                    current_state = down(current_state);
                    actions.Add("up");
                }
                else if (action == "down")
                {
                    current_state = up(current_state);
                    actions.Add("down");
                }

                while (!match_array(current_state, StartState))
                {
                    string current_action = get_action(current_state);

                    if (current_action == "right")
                    {
                        current_state = left(current_state);
                        actions.Add("right");
                    }

                    else if (current_action == "left")
                    {
                        current_state = right(current_state);
                        actions.Add("left");
                    }
                    else if (current_action == "up")
                    {
                        current_state = down(current_state);
                        actions.Add("up");
                    }
                    else if (current_action == "down")
                    {
                        current_state = up(current_state);
                        actions.Add("down");
                    }
                }


                stepsLog.Text += ($"Steps ({actions.Count} Step):\n");
                print_state(StartState);

                for (int a = actions.Count - 1; a >= 0; a--)
                {

                    if (actions[a] == "right")
                    {
                        current_state = right(current_state);
                    }

                    else if (actions[a] == "left")
                    {
                        current_state = left(current_state);
                    }
                    else if (actions[a] == "up")
                    {
                        current_state = up(current_state);
                    }
                    else if (actions[a] == "down")
                    {
                        current_state = down(current_state);
                    }



                    print_state(current_state);
                }
            }

            int h(int[,] state)
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

            Node get_state()
            {
                Node what = new Node();
                int index = 0;
                int selected_index = 0;
                int min_f = Max_Depth + 9;
                foreach (Node nd in FrontHere)
                {
                    if (nd.depth + h(nd.state) < min_f)
                    {
                        min_f = nd.depth + h(nd.state);
                        what.state = nd.state;
                        what.depth = nd.depth;
                        what.action = nd.action;
                        selected_index = index;
                    }
                    index++;
                }

                FrontHere.RemoveAt(selected_index);

                return what;
            }


            stepsLog.Text += ("Start State:\n");
            print_state(StartState);
            stepsLog.Text += ("Goal State:\n");
            print_state(GoalState);


            while (FrontHere.Count != 0 && !found && selected_depth <= Max_Depth)
            {
                Node best_result = get_state();
                if (match_array(best_result.state, GoalState))
                {
                    print_path(best_result.state, best_result.action);
                    found = true;
                }
                else
                {

                    if (can_right(best_result.state) && !was_checked(right(best_result.state)))
                    {
                        Node data = new Node();
                        data.depth = best_result.depth + 1;
                        data.state = right(best_result.state);
                        data.action = "right";

                        FrontHere.Add(data);
                    }

                    if (can_left(best_result.state) && !was_checked(left(best_result.state)))
                    {
                        Node data = new Node();
                        data.depth = best_result.depth + 1;
                        data.state = left(best_result.state);
                        data.action = "left";

                        FrontHere.Add(data);
                    }

                    if (can_up(best_result.state) && !was_checked(up(best_result.state)))
                    {
                        Node data = new Node();
                        data.depth = best_result.depth + 1;
                        data.state = up(best_result.state);
                        data.action = "up";

                        FrontHere.Add(data);
                    }

                    if (can_down(best_result.state) && !was_checked(down(best_result.state)))
                    {
                        Node data = new Node();
                        data.depth = best_result.depth + 1;
                        data.state = down(best_result.state);
                        data.action = "down";

                        FrontHere.Add(data);
                    }

                    selected_depth = best_result.depth;
                    Checked.Add(best_result);
                }
            }
            if (selected_depth > Max_Depth)
            {
                Console.WriteLine("Can't Solve!");
            }
        
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



    }
}
