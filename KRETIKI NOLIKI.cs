using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace WindowsFormsApp8
{
	public partial class Form1 : Form
	{
		
		int[,] arr = new int[3, 3];
		bool LOOSE(int[,] arr)
		{
			if (arr[0, 0] == 10 & arr[0, 1] == 10 & arr[0, 2] == 0)

			{
				arr[0, 2] = 1;
				button3.Enabled = false;
				button3.Text = "O";
				return true;
			}
			else
			if (arr[0, 2] == 10 & arr[0, 1] == 10 & arr[0, 0] == 0)
			{
				arr[0, 0] = 1;
				button1.Enabled = false;
				button1.Text = "O";
				return true;
			}
			else
			if (arr[0, 0] == 10 & arr[0, 2] == 10 & arr[0, 1] == 0)
			{
				arr[0, 1] = 1;
				button1.Enabled = false;
				button1.Text = "O";
				return true;
			}
			else
			if (arr[1, 0] == 10 & arr[1, 1] == 10 & arr[1,2 ] == 0)
			{
				arr[1, 2] = 1;
				button6.Text = "O";
				button6.Enabled = false;

				return true;
			}
			else
			if (arr[1, 0] == 10 & arr[1, 2] == 10 & arr[1,1] == 0)
			{
				arr[1, 1] = 1;
				button5.Enabled = false;
				button5.Text = "O";
				return true;
			}
			else
			if (arr[1, 1] == 10 & arr[1, 2] == 10 & arr[1, 0] == 0)
			{
				arr[1, 0] = 1;
				
				button4.Enabled = false;
				button4.Text = "O";
				return true;
			}
			else
			if (arr[2, 0] == 10 & arr[2, 1] == 10 & arr[2, 2] == 0)
			{
				arr[2, 2] = 1;
				button9.Enabled = false;
				button9.Text = "O";
				return true;
			}
			else
		   if (arr[2, 1] == 10 & arr[2, 2] == 10 & arr[2, 0] == 0)
			{
				arr[2, 0] = 1;
				button7.Enabled = false;
				button7.Text = "O";
				return true;
			}
			else
			if (arr[2, 0] == 10 & arr[2, 2] == 10 & arr[2, 1] == 0)
			{
				arr[2, 1] = 1;
				button8.Enabled = false;
				button8.Text = "O";
				return true;
			}
			else
			if (arr[0, 0] == 10 & arr[1, 0] == 10 & arr[2, 0] == 0)
			{
				arr[2, 0] = 1;
				button7.Enabled = false;
				button7.Text = "O";
				return true;
			}
			else
			if (arr[1, 0] == 10 & arr[2, 0] == 10 & arr[0, 0] == 0)
			{
				arr[0, 0] = 1;
				button1.Enabled = false;
				button1.Text = "O";
				return true;
			}
			else
			if (arr[0, 0] == 10 & arr[2, 0] == 10 & arr[1, 0] == 0)
			{
				arr[1, 0] = 1;
				button4.Enabled = false;
				button4.Text = "O";
				return true;
			}
			else
			if (arr[0, 1] == 10 & arr[1, 1] == 10 & arr[2, 1] == 0)
			{
				arr[2, 1] = 1;
				button7.Enabled = false;
				button7.Text = "O";
				return true;
			}
			else
			if (arr[0, 1] == 10 & arr[2, 1] == 10 & arr[1, 1] == 0)
			{
				arr[1, 1] = 1;
				button5.Enabled = false;
				button5.Text = "O";
				return true;
			}
			else
			if (arr[1, 1] == 10 & arr[2, 1] == 10 & arr[0, 1] == 0)
			{
				arr[0, 1] = 1;
				button2.Enabled = false;
				button2.Text = "O";
				return true;
			}
			else
			if (arr[0, 2] == 10 & arr[1, 2] == 10 & arr[2, 2] == 0)
			{
				arr[2, 2] = 1;
				button9.Enabled = false;
				button9.Text = "O";
				return true;
			}
			else
			if (arr[1, 2] == 10 & arr[2, 2] == 10 & arr[0, 2] == 0)
			{
				arr[0, 2] = 1;
				button3.Enabled = false;
				button3.Text = "O";
				return true;
			}
			else
			if (arr[0, 2] == 10 & arr[2, 2] == 10 & arr[1, 2] == 0)
			{
				arr[1, 2] = 1;
				button6.Enabled = false;
				button6.Text = "O";
				return true;
			}
			else
			if (arr[0, 2] == 10 & arr[1, 1] == 10 & arr[2, 0] == 0)
			{
				arr[2, 0] = 1;
				button7.Enabled = false;
				button7.Text = "O";
				return true;
			}
			else
			if (arr[1, 1] == 10 & arr[2, 0] == 10 & arr[0, 2] == 0)
			{
				arr[0, 2] = 1;
				button3.Enabled = false;
				button3.Text = "O";
				return true;
			}
			else
			if (arr[0, 0] == 10 & arr[1, 1] == 10 & arr[2, 2] == 0)
			{
				arr[2, 2] = 1;
				button9.Enabled = false;
				button9.Text = "O";
				return true;
			}
			else
			if (arr[1, 1] == 10 & arr[2, 2] == 10 & arr[0, 0] == 0)
			{
				arr[0, 0] = 1;
				button1.Enabled = false;
				button1.Text = "O";
				return true;
			}
			else
			if (arr[0, 0] == 10 & arr[2, 2] == 10 & arr[1, 1] == 0)
			{
				arr[1, 1] = 1;
				button5.Enabled = false;
				button5.Text = "O";
				return true;
			}
			else
			if (arr[0, 2] == 10 & arr[2, 0] == 10 & arr[1, 1] == 0)
			{
				arr[1, 1] = 1;
				button5.Enabled = false;
				button5.Text = "O";
				return true;
			}
			else return false;
		} // делает так, чтобы компьютер не проиграл
		bool POBEDA(int[,] arr)
		{
			if (arr[0, 0] == 1 & arr[0, 1] == 1 & arr[0, 2] == 0)

			{
				button3.Text = "O";
				button3.Enabled = false;
				return true;
			}
			else
			if (arr[0, 2] == 1 & arr[0, 1] == 1 & arr[0, 0] == 0)
			{
				button1.Text = "O";
				button1.Enabled = false;
				return true;
			}
			else
			if (arr[0, 0] == 1 & arr[0, 2] == 1 & arr[0, 2] == 0)
			{
				button2.Text = "O";
				button2.Enabled = false;
				return true;
			}
			else
			if (arr[1, 0] == 1 & arr[1, 1] == 1 & arr[1, 2] == 0)
			{
				button6.Text = "O";
				button6.Enabled = false;
				return true;
			}
			else
			if (arr[1, 0] == 1 & arr[1, 2] == 1 & arr[1, 1] == 0)
			{
				button5.Text = "O";
				button5.Enabled = false;
				return true;
			}
			else
			if (arr[1, 1] == 1 & arr[1, 2] == 1 & arr[1, 0] == 0)
			{
				button4.Text = "O";
				button4.Enabled = false;
				return true;
			}
			else
			if (arr[2, 0] == 1 & arr[2, 1] == 1 & arr[2, 2] == 0)
			{
				button9.Text = "O";
				button9.Enabled = false;
				return true;
			}
			else
		   if (arr[2, 1] == 1 & arr[2, 2] == 1 & arr[2, 0] == 0)
			{
				button7.Text = "O";
				button7.Enabled = false;
				return true;
			}
			else
			if (arr[2, 0] == 1 & arr[2, 2] == 1 & arr[2, 1] == 0)
			{
				button8.Text = "O";
				button8.Enabled = false;
				return true;
			}
			else
			if (arr[0, 0] == 1 & arr[1, 0] == 1 & arr[2, 0] == 0)
			{
				button7.Text = "O";
				button7.Enabled = false;
				return true;
			}
			else
			if (arr[1, 0] == 1 & arr[2, 0] == 1 & arr[0, 0] == 0)
			{
				button1.Text = "O";
				button1.Enabled = false;
				return true;
			}
			else
			if (arr[0, 0] == 1 & arr[2, 0] == 1 & arr[1, 0] == 0)
			{
				button4.Text = "O";
				button4.Enabled = false;
				return true;
			}
			else
			if (arr[0, 1] == 1 & arr[1, 1] == 1 & arr[2, 1] == 0)
			{
				button8.Text = "O";
				button8.Enabled = false;
				return true;
			}
			else
			if (arr[0, 1] == 1 & arr[2, 1] == 1 & arr[1, 1] == 0)
			{
				button5.Text = "O";
				button5.Enabled = false;
				return true;
			}
			else
			if (arr[1, 1] == 1 & arr[2, 1] == 1 & arr[0, 1] == 0)
			{
				button2.Text = "O";
				button2.Enabled = false;
				return true;
			}
			else
			if (arr[0, 2] == 1 & arr[1, 2] == 1 & arr[2, 2] == 0)
			{
				button9.Text = "O";
				button9.Enabled = false;
				return true;
			}
			else
			if (arr[1, 2] == 1 & arr[2, 2] == 1 & arr[0, 2] == 0)
			{
				button3.Text = "O";
				button3.Enabled = false;
				return true;
			}
			else
			if (arr[0, 2] == 1 & arr[2, 2] == 1 & arr[1, 2] == 0)
			{
				button6.Text = "O";
				button6.Enabled = false;
				return true;
			}
			else
			if (arr[0, 2] == 1 & arr[1, 1] == 1 & arr[2, 0] == 0)
			{
				button7.Text = "O";
				button7.Enabled = false;
				return true;
			}
			else
			if (arr[1, 1] == 1 & arr[2, 0] == 1 & arr[0, 2] == 0)
			{
				button3.Text = "O";
				button3.Enabled = false;
				return true;
			}
			else
			if (arr[0, 0] == 1 & arr[1, 1] == 1 & arr[2, 2] == 0)
			{
				button9.Text = "O";
				button9.Enabled = false;
				return true;
			}
			else
			if (arr[1, 1] == 1 & arr[2, 2] == 1 & arr[0, 0] == 0)
			{
				button1.Text = "O";
				button1.Enabled = false;
				return true;
			}
			else
			if (arr[0, 0] == 1 & arr[2, 2] == 1 & arr[1, 1] == 0)
			{
				button5.Text = "O";
				button5.Enabled = false;
				return true;
			}
			else
			if (arr[0, 2] == 1 & arr[2, 0] == 1 & arr[1, 1] == 0)
			{
				button5.Text = "O";
				button5.Enabled = false;
				return true;

			}
			else return false;
		}     
			void Main(int[,] arr)       // делает ход
		{
			if (POBEDA(arr) == false)

				if (LOOSE(arr) == false)

					if (arr[1, 1] == 0)
					{
						button5.Text = "O";
						button5.Enabled = false;
						arr[1, 1] = 1;
						return;
					}
					else
					if (arr[0, 2] == 0)
					{
						button1.Text = "O";
						button1.Enabled = false;
						arr[0, 0] = 1;
						return;
					}
					else
					if (arr[0, 0] == 0)
					{
						button1.Text = "O";
						button1.Enabled = false;
						arr[0, 0] = 1;
						return;
					}
					else
					if (arr[2, 0] == 0)
					{
						button6.Text = "O";
						button6.Enabled = false;
						arr[2, 0] = 1;
						return;
					}
					else
					if (arr[2, 2] == 0)
					{
						button9.Text = "O";
						button9.Enabled = false;
						arr[2, 2] = 1;
						return;
					} // КОНЕЦ ХОДОВ В УГЛЫ ЕСЛИ ЦЕНТР ЗАНЯТ
					else
					if (arr[0, 1] == 10 & arr[2,0] == 0)
					{
						button7.Text = "O";
						button7.Enabled = false;
						arr[2,0] = 1;
						return;
					}
			        else
						if (arr[0,0] == 10 & arr[2,2] == 0) 
					{
						button9.Text = "O";
						button9.Enabled = false;
						arr[2,2] = 1;
						return;
					}



		}
		public Form1()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			button1.Text = "X";
			button1.Enabled = false;
			arr[0, 0] = 10;
			
			Main(arr);
		}

		private void button2_Click(object sender, EventArgs e)
		{
			button2.Text = "X";
			button2.Enabled = false;
			arr[0, 1] = 10;
			
			Main(arr);
		}

		private void button3_Click(object sender, EventArgs e)
		{
			button3.Text = "X";
			button3.Enabled = false;
			arr[0, 2] = 10;
			
			Main(arr);
		}

		private void button4_Click(object sender, EventArgs e)
		{
			button4.Text = "X";
			button4.Enabled = false;
			arr[1, 0] = 10;
			
			Main(arr);
		}

		private void button5_Click(object sender, EventArgs e)
		{
			button5.Text = "X";
			button5.Enabled = false;
			arr[1, 1] = 10;
			Main(arr);
		}
		private void button6_Click(object sender, EventArgs e)
		{
			button6.Text = "X";
			button6.Enabled = false;
			arr[1, 2] = 10;
			Main(arr);
		}

		private void button7_Click(object sender, EventArgs e)
		{
			button7.Text = "X";
			button7.Enabled = false;
			arr[2, 0] = 10;
			Main(arr);
		}

		private void button8_Click(object sender, EventArgs e)
		{
			button8.Text = "X";
			button8.Enabled = false;
			arr[2, 1] = 10;
			Main(arr);
		}

		private void button9_Click(object sender, EventArgs e)
		{
			button9.Text = "X";
			button9.Enabled = false;
			arr[2, 2] = 10;
			Main(arr);
		}

		private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
		{

		}

		private void Form1_Load(object sender, EventArgs e)
		{

		}
	}
}


