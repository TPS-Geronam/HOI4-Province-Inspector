using H4ProvinceEditor.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H4ProvinceEditor {
    public partial class mainForm : Form {
        private List<DefItem> defList;
        private ErrorHandler errorhandler;

        [DllImport("user32.dll")]
        static extern bool GetCursorPos(ref Point lpPoint);

        [DllImport("gdi32.dll", CharSet = CharSet.Auto, SetLastError = true, ExactSpelling = true)]
        public static extern int BitBlt(IntPtr hDC, int x, int y, int nWidth, int nHeight, IntPtr hSrcDC, int xSrc, int ySrc, int dwRop);

        public mainForm() {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e) {
            defList = new List<DefItem>();
            errorhandler = new ErrorHandler();

            backupProvImageCheckbox.Checked = Properties.Settings.Default.BackupImage;
            backupDefinitionCheckbox.Checked = Properties.Settings.Default.BackupDefinition;
        }

        private void SelectImageButton_Click(object sender, EventArgs e) {
            OpenFileDialog open = new OpenFileDialog {
                Filter = "Windows Bitmap (*.bmp)|*.bmp"
            };
            if(open.ShowDialog() == DialogResult.OK) {
                if(!backupProvImageCheckbox.Checked) {
                    imageDisplay.Image = new Bitmap(open.FileName);
                    pathToImageBox.Text = open.FileName;
                } else {
                    string fPath = $"{Environment.CurrentDirectory}/resources/b_provinces_{DateTime.Now.ToString("HHmmss", DateTimeFormatInfo.InvariantInfo)}.bmp";
                    File.Copy(open.FileName, fPath);
                    imageDisplay.Image = new Bitmap(fPath);
                    pathToImageBox.Text = fPath;
                }
            }
            /*
            Bitmap img = new Bitmap("*imagePath*");
            for(int i = 0; i < img.Width; i++) {
                for(int j = 0; j < img.Height; j++) {
                    Color pixel = img.GetPixel(i, j);

                    if(pixel.R = ) {
                        
                    }
                }
            }*/
        }

        private void DefinitionButton_Click(object sender, EventArgs e) {
            try {
                OpenFileDialog open = new OpenFileDialog {
                    Filter = "Character-Separated Values (*.csv)|*.csv"
                };
                if(open.ShowDialog() == DialogResult.OK) {
                    if(!backupProvImageCheckbox.Checked) {
                        defList = File.ReadLines(open.FileName).Select(line => new DefItem(line)).ToList();
                        pathToDefinitionBox.Text = open.FileName;
                        defWarningLabel.Text = "";
                    } else {
                        string fPath = $"{Environment.CurrentDirectory}/resources/b_definition_{DateTime.Now.ToString("HHmmss", DateTimeFormatInfo.InvariantInfo)}.csv";
                        File.Copy(open.FileName, fPath);
                        defList = File.ReadLines(fPath).Select(line => new DefItem(line)).ToList();
                        pathToDefinitionBox.Text = fPath;
                        defWarningLabel.Text = "";
                    }
                }
            } catch(Exception ex) {
                errorhandler.ErrorMessage(ex.Message);
            }
        }

        private void HelpButton_Click(object sender, EventArgs e) {
            HelpWindow helpWindow = new HelpWindow();
            helpWindow.Show();
        }

        private void OpenResourcesButton_Click(object sender, EventArgs e) {
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + "/resources/");
        }

        private void BackupProvImageCheckbox_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.BackupImage = backupProvImageCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void BackupDefinitionCheckbox_CheckedChanged(object sender, EventArgs e) {
            Properties.Settings.Default.BackupDefinition = backupDefinitionCheckbox.Checked;
            Properties.Settings.Default.Save();
        }

        private void SearchButton_Click(object sender, EventArgs e) {
            if(!pathToDefinitionBox.Text.Equals("")) {
                if(searchIDRadio.Checked || searchRGBRadio.Checked) {
                    if((!searchIDBox.Text.Equals("") && searchRGBRadio.Checked) || (!searchRGBBox.Text.Equals("")) && searchIDRadio.Checked) {
                        if(searchRGBRadio.Checked) {
                            foreach(DefItem item in defList) {
                                if(item.Id.ToString().Equals(searchIDBox.Text)) {
                                    searchRGBBox.Text = $"{item.R};{item.G};{item.B}";
                                    searchErrorLabel.Text = "";
                                    break;
                                } else {
                                    searchRGBBox.Text = "";
                                    searchErrorLabel.Text = $"Could not find RGB of province ID {searchIDBox.Text}.";
                                }
                            }
                        } else if (searchIDRadio.Checked) {
                            var split = searchRGBBox.Text.Split(';');
                            if(split.Length > 2) {
                                foreach(DefItem item in defList) {
                                    if(item.R.ToString().Equals(split[0]) && item.G.ToString().Equals(split[1]) && item.B.ToString().Equals(split[2])) {
                                        searchIDBox.Text = $"{item.Id}";
                                        searchErrorLabel.Text = "";
                                        break;
                                    } else {
                                        searchIDBox.Text = "";
                                        searchErrorLabel.Text = $"Could not find ID of province with RGB {searchRGBBox.Text}.";
                                    }
                                }
                            } else {
                                searchErrorLabel.Text = "Syntax error.\nMake sure each value is seperated by a ;\nand between 0 and 255.";
                            }
                        }
                    } else {
                        searchErrorLabel.Text = "Please insert either the ID or RGB!";
                    }
                } else {
                    searchErrorLabel.Text = "Please select what to search for and by!";
                }
            } else {
                defWarningLabel.Text = "Please select your definition.csv first!";
            }
        }

        private void GenIDButton_Click(object sender, EventArgs e) {
            if(!pathToDefinitionBox.Text.Equals("")) {
                genIDBox.Text = $"{defList.LastOrDefault().Id + 1}";
            } else {
                defWarningLabel.Text = "Please select your definition.csv first!";
            }
        }

        private void GenRGBButton_Click(object sender, EventArgs e) {
            if(!pathToDefinitionBox.Text.Equals("")) {
                Random rnd = new Random();
                string RGB = $"{rnd.Next(0, 255)};{rnd.Next(0, 255)};{rnd.Next(0, 255)}";
                foreach(DefItem item in defList) {
                    if(item.GetRGBString().Equals(RGB)) {
                        GenRGBButton_Click(sender, e);
                        return;
                    }
                }
                genRGBBox.Text = RGB;
            } else {
                defWarningLabel.Text = "Please select your definition.csv first!";
            }
        }

        private void GenResultButton_Click(object sender, EventArgs e) {
            if(!pathToDefinitionBox.Text.Equals("")) {
                if(!genIDBox.Text.Equals("") && !genRGBBox.Text.Equals("")) {
                    if(genTypeCombo.SelectedIndex > -1 && genTerrainCombo.SelectedIndex > -1) {
                        genErrorLabel.Text = "";
                        genResult.Text = $"{genIDBox.Text};{genRGBBox.Text};{genTypeCombo.SelectedItem};{genCoastalCheck.Checked.ToString().ToLower()};{genTerrainCombo.SelectedItem};{genContinentNumeric.Value}";
                    } else {
                        genErrorLabel.Text = "Please select the type and terrain!";
                    }
                } else {
                    genErrorLabel.Text = "Please generate the ID and RGB!";
                }
            } else {
                defWarningLabel.Text = "Please select your definition.csv first!";
            }
        }

        private void ImageDisplay_MouseDown(object sender, MouseEventArgs e) {
            if(imageDisplay.Image != null && e.Button == MouseButtons.Left) {
                if(!pathToDefinitionBox.Text.Equals("")) {
                    Point cursor = new Point();
                    GetCursorPos(ref cursor);

                    var c = GetColorAt(cursor);
                    string color = $"{c.R};{c.G};{c.B}";

                    provColorBox.Text = color;
                    foreach(DefItem item in defList) {
                        if(item.R == c.R && item.G == c.G && item.B == c.B) {
                            provIdBox.Text = $"{item.Id}";
                            provTypeBox.Text = item.Type;
                            provCoastalBox.Text = $"{item.Coastal}";
                            provTerrainBox.Text = item.Terrain;
                            provContinentBox.Text = $"{item.Continent}";
                            blurryErrorLabel.Text = "";
                            break;
                        } else {
                            provIdBox.Text = "";
                            provTypeBox.Text = "";
                            provCoastalBox.Text = "";
                            provTerrainBox.Text = "";
                            provContinentBox.Text = "";
                            blurryErrorLabel.Text = "Could not find definition.\nMaybe the pixel is blurred?";
                        }
                    }
                } else {
                    defWarningLabel.Text = "Please select your definition.csv first!";
                }
            }
        }

        Bitmap screenPixel = new Bitmap(1, 1, PixelFormat.Format32bppArgb);
        public Color GetColorAt(Point location) {
            using(Graphics gdest = Graphics.FromImage(screenPixel)) {
                using(Graphics gsrc = Graphics.FromHwnd(IntPtr.Zero)) {
                    IntPtr hSrcDC = gsrc.GetHdc();
                    IntPtr hDC = gdest.GetHdc();
                    int retval = BitBlt(hDC, 0, 0, 1, 1, hSrcDC, location.X, location.Y, (int)CopyPixelOperation.SourceCopy);
                    gdest.ReleaseHdc();
                    gsrc.ReleaseHdc();
                }
            }

            return screenPixel.GetPixel(0, 0);
        }
    }
}
