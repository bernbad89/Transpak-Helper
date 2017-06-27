using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TransPak
{
    public partial class LumberCalculator : Form
    {
        public LumberCalculator()
        {
            InitializeComponent();
        }

        static Dictionary<string, string> defaultCount = new Dictionary<string, string>
        {
            {"1x4", "416"},
            {"1x6", "250"},
            {"2x4", "189"},
            {"2x6", "189"},
            {"2x8", "105"},
            {"2x10", "85"},
            {"2x12", "68"},
            {"3x6", "80"},
            {"4x4", "100"},
            {"4x6", "80"}
        };
        static Dictionary<string, string> locationWorsheet = new Dictionary<string, string>
        {
            {"Austin, TX", "4"},
            {"San Jose, CA", "5"},
            {"Tualatin, OR", "6"},
            {"Memphis, TN", "7"},
            {"Houston, TX", "8"},
            {"Houston-Sheldon, TX", "9"},
            {"Laredo, TX", "10"},
            {"Robertsdale, AL", "11"},
            {"Korea", "12"},
            {"Guadalajara", "13"},
            {"Los Angeles, CA", "14"},
            {"San Diego, CA", "15"},
        };
        static Dictionary<string, string> dimMultiply = new Dictionary<string, string>
        {
            {"1x4", "4"},
            {"1x6", "6"},
            {"2x4", "8"},
            {"2x6", "12"},
            {"2x8", "16"},
            {"2x10", "20"},
            {"2x12", "24"},
            {"3x6", "18"},
            {"4x4", "16"},
            {"4x6", "24"}
        };
        static Dictionary<string, string> comboBoxToLength = new Dictionary<string, string>
        {
            {"comboBox6ft", "6"},
            {"comboBox8ft", "8"},
            {"comboBox10ft", "10"},
            {"comboBox12ft", "12"},
            {"comboBox14ft", "14"},
            {"comboBox16ft", "16"},
            {"comboBox18ft", "18"},
            {"comboBox20ft", "20"},
        };

        static Dictionary<string, string> plywoodConversion = new Dictionary<string, string>
        {
            {"1/4", "0.25"},
            {"1/2", "0.50"},
            {"3/4", "0.75"},
            {"3/8", "0.375"},
            {"1 1/8", "1.125"}
        };

        static Dictionary<string, string> fracLookupPiecesPerUnit = new Dictionary<string, string>
        {
            {"1/4", "150"},
            {"1/2", "66"},
            {"3/4", "44"},
            {"3/8", "88"},
            {"1 1/8", "33"}
        };

        private void lumberDimensionsDropBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string result;
            if (defaultCount.TryGetValue((string)lumberDimensionsDropBox.SelectedItem, out result))
            {
                countDropBox.Items.Add(result);
                countDropBox.SelectedItem = result;
            }
        }

        private void calculatePlywoodButton_Click(object sender, EventArgs e)
        {
            plywoodResultTextBox.Clear();
            if (plywoodDimensionsDropBox.Text == "")
            {
                plywoodResultTextBox.Text = "No Data";
                return;
            }
            string result;           
            if (fracLookupPiecesPerUnit.TryGetValue((string)plywoodDimensionsDropBox.SelectedItem, out result))
            {
                double frac = Convert.ToDouble(unitsDropBox.Text);
                double piecesPerUnit = Convert.ToDouble(result);
                plywoodResultTextBox.Text = Convert.ToString(Math.Ceiling(piecesPerUnit * frac * 32.0));
            }
        }

        public void calculateLumberButton_Click(object sender, EventArgs e)
        {
            lumberResultTextBox.Clear();
            if (lumberDimensionsDropBox.Text == "")
            {
                lumberResultTextBox.Text = "No Data";
                return;
            }
            string result1;
            string result2;
            if (dimMultiply.TryGetValue((string)lumberDimensionsDropBox.SelectedItem, out result1))
            {
                double final = 0;
                double dims = Convert.ToDouble(result1);
                double piecesPerUnit = Convert.ToDouble(countDropBox.Text);
                foreach (Control c in panel1.Controls)
                {
                    if (c is ComboBox && c.Text != "0")
                    {
                        string lookupName = c.Name;
                        comboBoxToLength.TryGetValue(lookupName, out result2);
                        double length  = Convert.ToDouble(result2);
                        double units = Convert.ToDouble(c.Text);
                        final += (piecesPerUnit * units * dims * length) / 12;
                    }

                }
                lumberResultTextBox.Text = Convert.ToString(Math.Ceiling(final));
            }
        }

        private void checkBox6ft_Click(object sender, EventArgs e)
        {
            comboBox6ft.Text = "0";
            if (comboBox6ft.Visible == false)
            {
                comboBox6ft.Visible = true;
            }
            else
            {
                comboBox6ft.Visible = false;
            }
        }
        private void checkBox8ft_Click(object sender, EventArgs e)
        {
            comboBox8ft.Text = "0";
            if (comboBox8ft.Visible == false)
            {
                comboBox8ft.Visible = true;
            }
            else
            {
                comboBox8ft.Visible = false;
            }
        }
        private void checkBox10ft_Click(object sender, EventArgs e)
        {
            comboBox10ft.Text = "0";
            if (comboBox10ft.Visible == false)
            {
                comboBox10ft.Visible = true;
            }
            else
            {
                comboBox10ft.Visible = false;
            }
        }
        private void checkBox12ft_Click(object sender, EventArgs e)
        {
            comboBox12ft.Text = "0";
            if (comboBox12ft.Visible == false)
            {
                comboBox12ft.Visible = true;
            }
            else
            {
                comboBox12ft.Visible = false;
            }
        }
        private void checkBox14ft_Click(object sender, EventArgs e)
        {
            comboBox14ft.Text = "0";
            if (comboBox14ft.Visible == false)
            {
                comboBox14ft.Visible = true;
            }
            else
            {
                comboBox14ft.Visible = false;
            }
        }
        private void checkBox16ft_Click(object sender, EventArgs e)
        {
            comboBox16ft.Text = "0";
            if (comboBox16ft.Visible == false)
            {
                comboBox16ft.Visible = true;
            }
            else
            {
                comboBox16ft.Visible = false;
            }
        }
        private void checkBox18ft_Click(object sender, EventArgs e)
        {
            comboBox18ft.Text = "0";
            if (comboBox18ft.Visible == false)
            {
                comboBox18ft.Visible = true;
            }
            else
            {
                comboBox18ft.Visible = false;
            }
        }
        private void checkBox20ft_Click(object sender, EventArgs e)
        {
            comboBox20ft.Text = "0";
            if (comboBox20ft.Visible == false)
            {
                comboBox20ft.Visible = true;
            }
            else
            {
                comboBox20ft.Visible = false;
            }
        }
        private void plywoodDimensionsDropBox_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculatePlywoodButton_Click(O, e);
            }
        }
        private void unitsDropBox_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculatePlywoodButton_Click(O, e);
            }
        }


        private void comboBox6ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }
        private void comboBox8ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }
        private void comboBox10ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }
        private void comboBox12ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }
        private void comboBox14ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }
        private void comboBox16ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }
        private void comboBox18ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }
        private void comboBox20ft_OnKeyPress(Object O, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                calculateLumberButton_Click(O, e);
            }
        }

        private void calculatePricePerThousandSheetButton_Click(object sender, EventArgs e)
        {
            resultPricePerThousandPlywood.Clear();
            if (pricePerSheetComboBox.Text == "")
            {
                resultPricePerThousandPlywood.Text = "No Data";
                return;
            }
            double result = Convert.ToDouble(pricePerSheetComboBox.Text) / (32 * 0.001);
            resultPricePerThousandPlywood.Text = "$" + Math.Round(result, 2).ToString();
        }

        private void calculateCostPerThousandPieceButton_Click(object sender, EventArgs e)
        {
            if (pricePerPieceComboBox.Text == "" || lumberCostDimensionsComboBox.Text == "" || lumberLengthCostComboBox.Text == "" )
            {
                resultPricePerThousandLumber.Text = "No Data";
                return;
            }
            string result;
            double costPerPiece = Convert.ToDouble(pricePerPieceComboBox.Text);
            double length = Convert.ToDouble(lumberLengthCostComboBox.Text);
            dimMultiply.TryGetValue((string)lumberCostDimensionsComboBox.SelectedItem, out result);
            double dim = Convert.ToDouble(result);
            resultPricePerThousandLumber.Text = "$" + Math.Round((costPerPiece * 1000 * 12 /(dim * length)), 2).ToString();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            descripionTextBox.Clear();
            partNumberResultTextBox.Clear();
            notesTextBox.Clear();
            partNumberResultTextBox.Text = "Searching...";
            descripionTextBox.Text = "Searching...";
            notesTextBox.Text = "Searching...";
            altPartNumberTextBox.Text = "Searching...";
            altDescriptionTextBox.Text = "Searching...";
            altNotesTextBox.Text = "Searching...";
            string File_name = "C:\\Users\\Bernard\\Desktop\\CAL+MATL.xlsx"; //must change for other users
            Microsoft.Office.Interop.Excel.Application oXL = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook oWB;
            Microsoft.Office.Interop.Excel.Worksheet oSheet;
            string result;
            if ((string)transpakFacilitiesSearch.SelectedItem == null || (string)plywoodSizeSearchComboBox.SelectedItem == null)
            {
                descripionTextBox.Text = "No Data";
                partNumberResultTextBox.Text = "No Data";
                notesTextBox.Text = "No Data";
                altDescriptionTextBox.Text = "No Data";
                altPartNumberTextBox.Text = "No Data";
                altNotesTextBox.Text = "No Data";
                return;
            }
            locationWorsheet.TryGetValue((string)transpakFacilitiesSearch.SelectedItem, out result);
            int i = Convert.ToInt32(result);
            object missing = System.Reflection.Missing.Value;
            oWB = oXL.Workbooks.Open(File_name, missing, missing, missing, missing,
                missing, missing, missing, missing, missing, missing,
                missing, missing, missing, missing);
            oSheet = (Microsoft.Office.Interop.Excel.Worksheet)oWB.Worksheets[i];
            Microsoft.Office.Interop.Excel.Range oRng = GetSpecifiedRange(plywoodSizeSearchComboBox.SelectedItem.ToString(), oSheet);
            Microsoft.Office.Interop.Excel.Range oRng2 = GetSpecifiedRangeReverse(plywoodSizeSearchComboBox.SelectedItem.ToString(), oSheet);
            if (oRng == null)
            {
                partNumberResultTextBox.Text = "Not Available";
                descripionTextBox.Text = "Not Available";
                notesTextBox.Text = "Not Available";
                altPartNumberTextBox.Text = "Not Available";
                altDescriptionTextBox.Text = "Not Available";
                altNotesTextBox.Text = "Not Available";
                return;
            }
            var partNumberValue = (string)(oWB.Worksheets[i].Cells[oRng.Row, 2] as Microsoft.Office.Interop.Excel.Range).Value;
            if (partNumberValue != null)
            {
                partNumberResultTextBox.Text = partNumberValue.ToString();
            }
            else
            {
                partNumberResultTextBox.Text = "N/A";
            }
            var description = (string)(oWB.Worksheets[i].Cells[oRng.Row, 3] as Microsoft.Office.Interop.Excel.Range).Value;
            if (description != null)
            {
                descripionTextBox.Text = description.ToString();
            }
            else
            {
                descripionTextBox.Text = "N/A";
            }
            var notes = (string)(oWB.Worksheets[i].Cells[oRng.Row, 4] as Microsoft.Office.Interop.Excel.Range).Value;
            if (notes != null)
            {
                notesTextBox.Text = notes.ToString();
            }
            else
            {
                notesTextBox.Text = "N/A";
            }
            if(oRng2.Row == oRng.Row || oRng2 == null)
            {
                altPartNumberTextBox.Text = "Not Available";
                altDescriptionTextBox.Text = "Not Available";
                altNotesTextBox.Text = "Not Available";
                return;
            }
            var partNumberValue2 = (string)(oWB.Worksheets[i].Cells[oRng2.Row, 2] as Microsoft.Office.Interop.Excel.Range).Value;
            if (partNumberValue2 != null)
            {
                altPartNumberTextBox.Text = partNumberValue2.ToString();
            }
            else
            {
                altPartNumberTextBox.Text = "N/A";
            }
            var description2 = (string)(oWB.Worksheets[i].Cells[oRng2.Row, 3] as Microsoft.Office.Interop.Excel.Range).Value;
            if (description2 != null)
            {
                altDescriptionTextBox.Text = description2.ToString();
            }
            else
            {
                altDescriptionTextBox.Text = "N/A";
            }
            var notes2 = (string)(oWB.Worksheets[i].Cells[oRng2.Row, 4] as Microsoft.Office.Interop.Excel.Range).Value;
            if (notes2 != null)
            {
                altNotesTextBox.Text = notes2.ToString();
            }
            else
            {
                altNotesTextBox.Text = "N/A";
            }
            oWB.Close(false, missing, missing);
            oSheet = null;
            oWB = null;
            oXL.Quit();
        }
        
        private Microsoft.Office.Interop.Excel.Range GetSpecifiedRange(string matchStr, Microsoft.Office.Interop.Excel.Worksheet objWs)
        {
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Range currentFind = null;
            currentFind = objWs.get_Range("A1", "AM100").Find(matchStr, missing,
                           Microsoft.Office.Interop.Excel.XlFindLookIn.xlValues,
                           Microsoft.Office.Interop.Excel.XlLookAt.xlPart,
                           Microsoft.Office.Interop.Excel.XlSearchOrder.xlByRows,
                           Microsoft.Office.Interop.Excel.XlSearchDirection.xlNext, false, missing, missing);
            return currentFind;
        }
        private Microsoft.Office.Interop.Excel.Range GetSpecifiedRangeReverse(string matchStr, Microsoft.Office.Interop.Excel.Worksheet objWs)
        {
            object missing = System.Reflection.Missing.Value;
            Microsoft.Office.Interop.Excel.Range currentFind = null;
            currentFind = objWs.get_Range("A1", "AM100").Find(matchStr, missing,
                           Microsoft.Office.Interop.Excel.XlFindLookIn.xlValues,
                           Microsoft.Office.Interop.Excel.XlLookAt.xlPart,
                           Microsoft.Office.Interop.Excel.XlSearchOrder.xlByRows,
                           Microsoft.Office.Interop.Excel.XlSearchDirection.xlPrevious, false, missing, missing);
            return currentFind;
        }
    }
}
