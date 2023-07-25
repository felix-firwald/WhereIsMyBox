﻿using Common;
using System;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using WhereIsMyBox.Classes.Models;

namespace WhereIsMyBox.Forms
{
    // [Docking(DockingBehavior.Ask)]
    public partial class UC_Boxes : UserControl
    {
        ModelBoxes foundBox = new ModelBoxes();
        public UC_Boxes(string username)
        {
            InitializeComponent();
            this.Dock = DockStyle.Fill;
            this.Focus();
            this.foundBox.user = username;
        }

        private void CopyAllToolStrip_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(sender.ToString());
        }

        private void buttonFind_MouseEnter(object sender, EventArgs e)
        {
            this.buttonFind.IconColor = ColorTheme.TextHovered;
            

        }

        private void buttonFind_MouseLeave(object sender, EventArgs e)
        {
            this.buttonFind.IconColor = Color.DimGray;
        }

        private void InputFind_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonFind_Click(object sender, EventArgs e)
        {
            this.inputFind.Text = this.inputFind.Text.ToUpper();
            this.HelpTextFind.Text = $"Поиск короба №{this.inputFind.Text}...";
            //ModelBoxes foundBox = new ModelBoxes();
            if (foundBox.GetBoxByNumber(this.inputFind.Text))
            {
                string [] result = foundBox.GetSplitedNumber();
                this.BoxInfoPanel.changeData(
                    prefix: result[0],
                    postfix: result[1],
                    initLocation: foundBox.initialLocation,
                    currLocation: foundBox.currentPlace,
                    status: foundBox.status,
                    comment: foundBox.note,
                    user: foundBox.user,
                    willBeFree: foundBox.willFree
                );
                this.tableMicroActions.Visible = true;
                this.BoxInfoPanel.Visible = true;
                this.HelpTextFind.Visible = false;
            }
            else
            {
                this.HelpTextFind.Text = $"Короб №{this.inputFind.Text} не найден!";
            }
        }

        private void inputFind_Enter(object sender, EventArgs e)
        {
           
        }

        private void buttonCancelFind_Click(object sender, EventArgs e)
        {
            this.inputFind.Text = "";
            this.buttonFind.Enabled = false;
            this.HelpTextFind.Visible = true;
            this.HelpTextFind.Text = "Вы и сами знаете, что делать.";
            this.tableMicroActions.Visible = false;
            this.BoxInfoPanel.Visible = false;
        }

        private void buttonCancelFind_MouseEnter(object sender, EventArgs e)
        {
            this.buttonCancelFind.IconColor = ColorTheme.TextHovered;
        }

        private void buttonCancelFind_MouseLeave(object sender, EventArgs e)
        {
            this.buttonCancelFind.IconColor = Color.DimGray;
        }

        private void inputFind_TextChanged(object sender, EventArgs e)
        {
            bool regex = Regex.IsMatch(this.inputFind.Text, @"^[a-zA-Z]\w*[1-9]$");
            bool length = this.inputFind.Text.Length > 5;

            if (regex && length)
            {
                this.inputFind.ForeColor = Color.LightGreen;
                this.buttonFind.Enabled = true;
            }
            else if (regex)
            {
                this.inputFind.ForeColor = ColorTheme.TextHovered;
                this.buttonFind.Enabled = false;
            }
            else
            {
                this.inputFind.ForeColor = Color.IndianRed;
                this.buttonFind.Enabled = false;
            }
        }

        private void elementHost2_ChildChanged(object sender, System.Windows.Forms.Integration.ChildChangedEventArgs e)
        {

        }

        private void inputFind_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                this.inputFind.SelectAll();
                Clipboard.SetText(this.inputFind.Text);
            }
        }

        private void MicroButtonAdd_Click(object sender, EventArgs e)
        {
            ModelUsing use = new ModelUsing();
            use.box = foundBox;
            use.AddBoxIntoUsing(120);
        }
    }
}
