using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp1
{
    /// <summary>
    /// A small form that asks the player to choose a category. It has no close button, so a choice must be made.
    /// </summary>
    public partial class CategoryForm : Form
    {
        /// <summary>The category the player picked.</summary>
        public string SelectedCategory => categoryCombo.Text;

        /// <summary>
        /// Creates the form and fills the list with the categories that can still be chosen.
        /// </summary>
        /// <param name="categories">The categories the player has not used yet.</param>
        /// <param name="difficulty">The difficulty of the questions (easy, medium or hard).</param>
        public CategoryForm(List<string> categories, string difficulty)
        {
            InitializeComponent();
            promptLabel.Text = $"Choose a category for the {difficulty} questions";
            categoryCombo.Items.AddRange(categories.ToArray());
            categoryCombo.SelectedIndex = 0;
        }
    }
}