﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using StoryDev.Components;
using StoryDev.Components.ElementAdditionals;

namespace StoryDev.Forms
{
    partial class AddElementForm : Form
    {

        public ElementType SelectedType
        {
            get
            {
                if (lvElements.SelectedIndices.Count > 0)
                {
                    var index = lvElements.SelectedIndices[0];
                    var node = lvElements.Items[index];
                    switch (node.Tag)
                    {
                        case "_Button":
                            return ElementType.Button;
                        case "_CheckBox":
                            return ElementType.CheckBox;
                        case "_CheckList":
                            return ElementType.CheckList;
                        case "_ComboBox":
                            return ElementType.ComboBox;
                        case "_DatePicker":
                            return ElementType.DatePicker;
                        case "_IconSelector":
                            return ElementType.IconSelector;
                        case "_InputCode":
                            return ElementType.InputCode;
                        case "_InputMultiline":
                            return ElementType.InputMultiline;
                        case "_InputSingle":
                            return ElementType.InputSingle;
                        case "_Label":
                            return ElementType.Label;
                        case "_LinkedDetailedView":
                            return ElementType.LinkedDetailedView;
                        case "_ListBox":
                            return ElementType.ListBox;
                        case "_Numeric":
                            return ElementType.Numeric;
                        case "_SingleLink":
                            return ElementType.SingleLink;
                        case "_TabControl":
                            return ElementType.TabControl;
                    }
                }

                return ElementType._TEST;
            }
        }

        public string FieldName
        {
            get => txtFieldName.Text;
        }

        public int SelectedReference
        {
            get => cmbReference.SelectedIndex;
        }

        public string CustomSourceData
        {
            get;
            private set;
        }



        public AddElementForm()
        {
            InitializeComponent();
        }

        private void SelectElement(string tag)
        {
            var fieldRefVisible = true;
            var customDataVisible = false;
            var additionalVisible = false;

            pnlAdditionalOptions.Controls.Clear();

            switch (tag)
            {
                case "_Label":
                case "_Button":
                case "_TabControl":
                    fieldRefVisible = false;
                    break;
                case "_CheckList":
                case "_ComboBox":
                    customDataVisible = true;
                    break;
                case "_ListBox":
                    customDataVisible = true;
                    additionalVisible = true;
                    pnlAdditionalOptions.Controls.Add(new ListBoxAdditional() { Dock = DockStyle.Fill });
                    break;
                case "_SingleLink":
                    additionalVisible = true;
                    pnlAdditionalOptions.Controls.Add(new ListBoxAdditional() { Dock = DockStyle.Fill });
                    break;
                case "_LinkedDetailedView":
                    additionalVisible = true;
                    pnlAdditionalOptions.Controls.Add(new LinkedDetailedAdditional() { Dock = DockStyle.Fill });
                    break;
            }

            pnlFieldReference.Visible = fieldRefVisible;
            pnlCustomDataSource.Visible = customDataVisible;
            pnlAdditionalOptions.Visible = additionalVisible;
        }

        private void lvElements_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvElements.SelectedItems.Count > 0)
            {
                ListViewItem item = lvElements.SelectedItems[0];
                SelectElement((string)item.Tag);
            }
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {

        }
    }
}
