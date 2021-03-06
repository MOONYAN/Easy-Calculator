﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Easy_Calculator
{
    public partial class EchoForm : Form
    {
        public EchoForm()
        {
            InitializeComponent();
        }

        private void EchoForm_Load(object sender, EventArgs e)
        {
            string[] contents = { "NTUT", "CSIE", "SDT" };
            CreateRadios(contents);
            _comboBox.DataSource = contents;
            _comboBox.SelectedValueChanged += Combo_SelectedValueChanged;
            _numericUpDown.ValueChanged += Numeric_ValueChanged;
            _linkLabel.LinkClicked += linkLabel_LinkClicked;
        }

        private void CreateRadios(string[] contents)
        {
            foreach (var element in contents)
            {
                RadioButton radio = new RadioButton()
                {
                    Text = element,
                    AccessibleName = element
                };
                radio.Click += Radio_Click;
                _radioTableLayoutPanel.Controls.Add(radio);
            }
        }

        private void Numeric_ValueChanged(object sender, EventArgs e)
        {
            var numeric = sender as NumericUpDown;
            _replyLabel.Text = "echo:" + numeric.Value;
        }

        private void Combo_SelectedValueChanged(object sender, EventArgs e)
        {
            var combo = sender as ComboBox;
            _replyLabel.Text = "echo:" + combo.SelectedValue;
        }

        private void Radio_Click(object sender, EventArgs e)
        {
            var radio = sender as RadioButton;
            _replyLabel.Text = "echo:" + radio.Text;
        }

        private void linkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://google.com");
        }
    }
}
