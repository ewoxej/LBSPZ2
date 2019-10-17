using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace LB2SPZ
{
    public partial class Form1 : Form
    {
        private List<Factory> factoriesList = new List<Factory>();

        private BindingSource bindingSource = new BindingSource();


        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = bindingSource;
            bindingSource.DataSource = factoriesList;
        }

        private void remove_btn_click(object sender, EventArgs e)
        {
            var tableCount = dataGridView1.SelectedRows.Count;
            if (tableCount > 0)
            {
                for (var i = 0; i < tableCount; i++)
                    dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[i].Index);
            }
        }

        private void retire_or_employ(bool isEmploy)
        {
            var tableCount = dataGridView1.SelectedRows.Count;
            if (tableCount <= 0) return;
            Factory.WorkerType type = !(master_cbx.Checked) ? Factory.WorkerType.Worker : Factory.WorkerType.Master;
            var index = this.dataGridView1.SelectedRows[0].Index;
            if (index >= 0)
            {
                if (index >= factoriesList.Count) return;
                var current = factoriesList.ElementAt(index);
                if (isEmploy)
                    current.employ(type);
                else
                    current.unemploy(type);
            }
            dataGridView1.Refresh();
            dataGridView1.Update();
        }

        private void employ_btn_click(object sender, EventArgs e)
        {
            retire_or_employ(true);
        }

        private void retire_btn_click(object sender, EventArgs e)
        {
            retire_or_employ(false);
        }

        private void compare_btn_click(object sender, EventArgs e)
        {
            var indexes = this.dataGridView1.SelectedRows;
            string message = "Too much or too less factories for compare";
            if (indexes.Count == 2)
            {
                var firstElement = factoriesList.ElementAt(indexes[0].Index);
                var secondElement = factoriesList.ElementAt(indexes[1].Index);
                int compareResult = (firstElement.CompareTo(secondElement));
                message =
                    (compareResult == 0) ?
                    "Elements are equal" :
                    (firstElement.factoryName + ((compareResult < 0) ? " is less than " : " is greater than ") + secondElement.factoryName);
            }
            MessageBox.Show(message, "Comparsion result", MessageBoxButtons.OK, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1, MessageBoxOptions.ServiceNotification);

        }

        private void total_btn_click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0) return;
            var index = this.dataGridView1.SelectedRows[0].Index;
            MessageBox.Show(
    factoriesList.ElementAt(index).getTotalSalary().ToString(),
    "Total salary",
    MessageBoxButtons.OK,
    MessageBoxIcon.Information,
    MessageBoxDefaultButton.Button1,
    MessageBoxOptions.DefaultDesktopOnly);

        }
        private void merge_btn_click(object sender, EventArgs e)
        {
            var indexes = this.dataGridView1.SelectedRows;
            if (indexes.Count == 2)
            {
                var firstFactory = factoriesList.ElementAt(indexes[0].Index);
                var secondFactory = factoriesList.ElementAt(indexes[1].Index);
                factoriesList[indexes[1].Index] = firstFactory + secondFactory;
                dataGridView1.Rows.RemoveAt(indexes[0].Index);
            }

            dataGridView1.Refresh();
            dataGridView1.Update();
        }
    }

    public class Factory : IComparable
    {
        public string factoryName { get; set; }
        public int Workers { get; set; }
        public int Districts { get; set; }
        public int Masters { get; set; }
        public float Master_salary { get; set; }
        public float Worker_salary { get; set; }
        public float Master_benefit { get; set; }
        public float Worker_benefit { get; set; }
        public enum WorkerType { Worker, Master };
        public Factory()
        {

        }
        public Factory(Factory instance)
        {
            factoryName = instance.factoryName;
            Workers = instance.Workers;
            Districts = instance.Districts;
            Masters = instance.Masters;
            Master_salary = instance.Master_salary;
            Worker_salary = instance.Worker_salary;
            Master_benefit = instance.Master_benefit;
            Worker_benefit = instance.Worker_benefit;
        }
        public void employ(WorkerType type)
        {
            if (type == WorkerType.Worker)
                Workers++;
            else
                Masters++;
        }

        public void unemploy(WorkerType type)
        {
            if (type == WorkerType.Worker)
            {
                if (Workers > 0) Workers--;
            }
            else
            {
                if (Masters > 0) Masters--;
            }
        }
        public float getTotalSalary()
        {
            return Master_salary * Masters + Worker_salary * Workers;
        }

        public static Factory operator +(Factory a, Factory b)
        {
            return new Factory
            {
                factoryName = a.factoryName + b.factoryName + "(Holding)",
                Workers = a.Workers + b.Workers,
                Districts = a.Districts + b.Districts,
                Masters = a.Masters + b.Masters,
                Master_salary = a.Master_salary + b.Master_salary,
                Worker_salary = a.Worker_salary + b.Worker_salary,
                Master_benefit = a.Master_benefit + b.Master_benefit,
                Worker_benefit = a.Worker_benefit + b.Worker_benefit
            };
        }

        public int CompareTo(object o)
        {
            Factory p = o as Factory;
            if (p != null)
                return this.Workers.CompareTo(p.Workers);
            else
                throw new Exception("Incomparable");
        }
        public float calculateBenefit(float investment)
        {
            int workers = 0;
            int masters = 0;
            for (int i = 0; investment >= 0; i++)
            {
                investment -= Worker_salary;
                workers++;
                if (workers % 10 == 0)
                {
                    masters++;
                    investment -= Master_salary;
                }
            }
            return workers * Worker_benefit + masters * Master_benefit;
        }

    }

}
