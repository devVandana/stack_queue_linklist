using Microsoft.VisualBasic.Devices;
using System.Collections.Generic;

namespace Assignment_2_n01531431
{
    public partial class Form1 : Form
    {
        Stack<Course> courseStack;
        Queue<Course> courseQueue;
        LinkedList<Course> courseList;

        public Form1()
        {
            InitializeComponent();
            courseStack = new Stack<Course>();
            courseQueue = new Queue<Course>();
            courseList = new LinkedList<Course>();
        }

        private void btnpush_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text==" " || txtScore.Text=="")
            {
                MessageBox.Show("Please Enter Value in both TextBox");
                return;
            }

            else
            {
                courseStack.Push(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }

        private void btnPop_Click(object sender, EventArgs e)
        {
            if (courseStack.Count==0)
            {
                MessageBox.Show("Stack is Empty");
                return;
            }
            else
            {
                courseStack.Pop();
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseStack.Count == 0)
            {
                MessageBox.Show("Stack is Empty");
            }

            else
            {
                foreach (Course course in courseStack)
                {
                    lbxOutput.Items.Add(course.CourseName + "--" + course.Score);
                    txtCourseName.Clear();
                    txtScore.Clear();
                }
            }
        }

        private void btnPeek_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseStack.Count > 0)
            {
                Course peek = courseStack.Peek();
                lbxOutput.Items.Add(peek.ToString());
                txtCourseName.Clear();
                txtScore.Clear();
            }
            else
            {
                MessageBox.Show("Stack is Empty");
            }
        }

        private void btnenq_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Please Enter Value in both Textboxes");
                return;
            }
            else
            {
                courseQueue.Enqueue(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }

        private void btnDeq_Click(object sender, EventArgs e)
        {
            if (courseQueue.Count == 0)
            {
                MessageBox.Show("Queue is empty");
                return;
            }
            else
            {
                lbxOutput.Items.Clear();
                courseQueue.Dequeue();
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }

        private void btnQDisplay_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseQueue.Count == 0)
            {
                MessageBox.Show("Queue is empty");
                return;
            }
            foreach (Course course in courseQueue)
            {
                lbxOutput.Items.Add(course.CourseName + "--" + course.Score);
            }
        }

        private void btnQPeek_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseQueue.Count == 0)
            {
                MessageBox.Show("Queue is empty");
                return;
            }
            else { 
            Course peek = courseQueue.Peek();
            lbxOutput.Items.Add(peek);
                txtCourseName.Clear();
                txtScore.Clear();
            }
    }


        private void btnAddLastLL_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Please Enter Value in both textbox");
                return;
            }
            else
            {
                courseList.AddLast(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }

        private void btnAddFirstLL_Click(object sender, EventArgs e)
        {
            if (txtCourseName.Text == "" || txtScore.Text == "")
            {
                MessageBox.Show("Please Enter Value in both Textbox");
                return;
            }
            else
            {
                courseList.AddFirst(new Course(txtCourseName.Text, Int32.Parse(txtScore.Text)));
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }


        private void btnDisplayLL_Click(object sender, EventArgs e)
        {
            if (courseList.Count == 0)
            {
                MessageBox.Show("Link list is empty");
                return;
            }
            else
            {
                lbxOutput.Items.Clear();
                foreach (Course c in courseList)
                {
                    lbxOutput.Items.Add(c.CourseName + "--" + c.Score);
                }
            }
        }

        private void btnRemoveLL_Click(object sender, EventArgs e)
        {
            var node = courseList.First;
            while (node != null)
            {
                var nextNode = node.Next;
                if (node.Value.CourseName == txtCourseName.Text && node.Value.Score == Int32.Parse(txtScore.Text))
                {
                    courseList.Remove(node);
                }
                node = nextNode;
            }
            txtCourseName.Clear();
            txtScore.Clear();
        }

        private void btnFindLL_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            var node = courseList.FirstOrDefault(x => x.CourseName == txtCourseName.Text);
            if(node!= null)
            {
                lbxOutput.Items.Add(node.CourseName + "--" + node.Score);
            }
           
            else
            {
                MessageBox.Show("Data Not found in Linked list");
            }
        }

        private void btnRemoveFirstLL_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseList.Count == 0)
            {
                MessageBox.Show("you can not remove as Linked list is empty..");

            }
            else
            {
                courseList.RemoveFirst();
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }

        private void btnRemoveLastLL_Click(object sender, EventArgs e)
        {
            lbxOutput.Items.Clear();
            if (courseList.Count == 0)
            {
                MessageBox.Show("You can not remove as Linked list is empty..");
            }
            else
            {
                courseList.RemoveLast();
                txtCourseName.Clear();
                txtScore.Clear();
            }
        }
    }
}