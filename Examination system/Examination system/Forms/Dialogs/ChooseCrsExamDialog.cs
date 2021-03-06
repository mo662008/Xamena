using Examination_system.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Examination_system.Forms
{
	public partial class ChooseCrsExamDialog : Form
	{
		public Student PrevForm { get; set; }
		public ExamSystemEntities Ent { get; set; } = new ExamSystemEntities();

		public ChooseCrsExamDialog(Student prevForm)
		{
			InitializeComponent();
			this.PrevForm = prevForm;
			ShowAvaliableCourses();
		}

		private void ShowAvaliableCourses()
		{
			var stdCrs = Ent.Std_Crs
				.Where(x => (x.Std_Id == PrevForm.StudentId)
				&& (x.Grade == null));
			if (stdCrs.Count() > 0)
			{
				foreach (var item in stdCrs)
				{
					comboBox1.Items.Add(item.Course.Crs_Name);
				}
			}
			else
			{
				label1.Text = "No Avaliabe Course";
				label1.ForeColor = Color.Red;
				Start.Enabled = false;
			}
		}

		private void Start_Click(object sender, EventArgs e)
		{
			PrevForm.CourseName = comboBox1.Text;
			this.Close();
		}
	}
}
