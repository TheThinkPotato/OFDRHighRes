using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace OperationFlashPointVideoConfig
{
    public partial class Form1 : Form
    {
        string myDocumentsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        string ofdrPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\OFDR\hardwaresettings";

        string hardwareSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\OFDR\hardwaresettings\hardware_settings_info.xml";
        string configSettingsPath = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + @"\My Games\OFDR\hardwaresettings\hardware_settings_config.xml";

        private List<DisplayMode> displayModes = new List<DisplayMode>();
        private List<int> refreshRates = new List<int>();

        private DisplayMode currentResoltion;
        private int currentRefreshRate;
        private bool fullscreen = false;
        private bool vsync = false;

        public Form1()
        {
            InitializeComponent();
            detectResolutions();
            getRefreshRates();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            syncSettings();
        }

        private void syncSettings()
        {
            try
            {
                getSettings();
                syncGui();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void syncGui()
        {
            comboBoxRes.SelectedIndex = displayModes.FindIndex(dm => dm.width == currentResoltion.width && dm.height == currentResoltion.height);
            comboBoxRefresh.SelectedIndex = refreshRates.FindIndex(rr => rr == currentRefreshRate);
            checkBoxFullscreen.Checked = fullscreen;
            checkBoxVsync.Checked = vsync;
        }

        private void getSettings()
        {
            var xmlDoc = XDocument.Load(configSettingsPath);

            var graphicsCard = xmlDoc.Root.Element("graphics_card");
            var resolution = graphicsCard?.Element("resolution");

            if (resolution != null)
            {
                // Read attributes from resolution
                int width = (int)resolution.Attribute("width");
                int height = (int)resolution.Attribute("height");
                currentResoltion = new DisplayMode(width, height);

                fullscreen = (string)resolution.Attribute("fullscreen") == "1";
                vsync = (string)resolution.Attribute("vsync") == "1";

                // Read refresh rate
                var refreshRate = resolution.Element("refreshRate");
                currentRefreshRate = (int)refreshRate.Attribute("rate");
            }
        }

        private void saveSettings()
        {
            try
            {
                XmlDocument doc = new XmlDocument();
                doc.Load(configSettingsPath);

                XmlNode resolutionNode = doc.SelectSingleNode("//resolution");
                XmlNode refreshNode = doc.SelectSingleNode("//refreshRate");

                if (resolutionNode != null)
                {
                    // Update attributes
                    XmlElement resolutionElement = (XmlElement)resolutionNode;
                    resolutionElement.SetAttribute("width", displayModes[comboBoxRes.SelectedIndex].width.ToString());  // New width
                    resolutionElement.SetAttribute("height", displayModes[comboBoxRes.SelectedIndex].height.ToString()); // New height
                    resolutionElement.SetAttribute("aspect", displayModes[comboBoxRes.SelectedIndex].aspectRatio); // New aspect ratio
                    resolutionElement.SetAttribute("fullscreen", checkBoxFullscreen.Checked ? "1" : "0"); // New fullscreen setting
                    resolutionElement.SetAttribute("vsync", checkBoxVsync.Checked ? "1" : "0"); // New vsync setting


                    XmlElement refreshElement = (XmlElement)refreshNode;
                    refreshElement.SetAttribute("rate", refreshRates[comboBoxRefresh.SelectedIndex].ToString()); // New refresh rate setting

                    // Save the changes back to the file
                    doc.Save(configSettingsPath);
                }
                else
                {
                    MessageBox.Show("Resolution element not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void getRefreshRates(bool debug = false)
        {
            try
            {
                XDocument xDoc = XDocument.Load(hardwareSettingsPath);

                List<int> readRefreshRates = xDoc.Descendants("refreshRate")
                                 .Select(rrr => (int)rrr.Attribute("rate"))
                                 .Distinct()
                                 .OrderByDescending(rrr => rrr)
                                 .ToList();

                refreshRates = readRefreshRates;

                comboBoxRefresh.Items.Clear();
                comboBoxRefresh.DataSource = refreshRates;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void detectResolutions(bool debug = false)
        {
            var screens = Screen.AllScreens;
            List<DisplayMode> detectedDisplayModes = new List<DisplayMode>();
            foreach (var screen in screens)
            {
                // Get the current resolution
                var bounds = screen.Bounds;
                detectedDisplayModes.Add(new DisplayMode(bounds.Width, bounds.Height));
            }


            List<DisplayMode> extraDisplayModes = new List<DisplayMode>();

            //add extra resolutions
            foreach (var mode in detectedDisplayModes)
            {
                List<DisplayMode> newModes = new List<DisplayMode>();

                newModes.Add(new DisplayMode((int)(mode.width * 0.75), (int)(mode.height * 0.75)));
                newModes.Add(new DisplayMode((int)(mode.width * 0.5), (int)(mode.height * 0.5)));

                foreach (var newMode in newModes)
                {
                    if (newMode.width > 1280 && newMode.height > 1024)
                    {
                        extraDisplayModes.Add(newMode);
                    }
                }
            }

            detectedDisplayModes.AddRange(extraDisplayModes);

            //removed doubles up in the list
            displayModes = detectedDisplayModes
                .Select(dm => new { dm.width, dm.height })
                .Distinct()
                .Select(dm => new DisplayMode(dm.width, dm.height))
                .OrderByDescending(dm => dm.width)
                .ThenByDescending(dm => dm.height)
                .ToList();

            comboBoxRes.Items.Clear();
            comboBoxRes.DataSource = displayModes;
        }

        private void detectFiles()
        {
            string[] files = System.IO.Directory.GetFiles(ofdrPath, "*.xml");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saveSettings();
        }
    }

    public class DisplayMode
    {
        public int width { get; set; }
        public int height { get; set; }
        public string aspectRatio
        {
            get
            {
                return ((double)width / (double)height).ToString("F7").Substring(0, 8);
            }
        }

        public DisplayMode(int width, int height)
        {
            this.width = width;
            this.height = height;
        }

        public override string ToString()
        {
            return $"{width}x{height} ({getRatioForDisplay()})";
        }

        private string getRatioForDisplay()
        {
            switch (aspectRatio)
            {
                case "1.333333":
                    return "4:3";
                case "1.777777":
                    return "16:9";
                case "1.600000":
                    return "16:10";
                default:
                    return "unknown";
            }
        }

    }
}
