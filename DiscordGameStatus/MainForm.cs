using MaterialSkin;
using MaterialSkin.Controls;
using System;
using System.IO;
using System.Runtime.Serialization.Json;
using System.Windows.Forms;

/// <summary>
/// Discord game status namespace
/// </summary>
namespace DiscordGameStatus
{
    /// <summary>
    /// Main form class
    /// </summary>
    public partial class MainForm : MaterialForm
    {
        /// <summary>
        /// Serializer
        /// </summary>
        private static readonly DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(ConfigDataContract));

        /// <summary>
        /// Config file name
        /// </summary>
        private static readonly string configFileName = "./config.json";

        /// <summary>
        /// Config data
        /// </summary>
        private static ConfigDataContract configData;

        /// <summary>
        /// Config data
        /// </summary>
        private static ConfigDataContract ConfigData
        {
            get
            {
                if (configData == null)
                {
                    try
                    {
                        if (File.Exists(configFileName))
                        {
                            using (FileStream fs = new FileStream(configFileName, FileMode.Open))
                            {
                                configData = serializer.ReadObject(fs) as ConfigDataContract;
                            }
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                }
                if (configData == null)
                {
                    ConfigData = new ConfigDataContract();
                }
                return configData;
            }
            set
            {
                if (value != null)
                {
                    configData = value;
                    try
                    {
                        using (FileStream fs = new FileStream(configFileName, FileMode.Create))
                        {
                            serializer.WriteObject(fs, configData);
                        }
                    }
                    catch (Exception e)
                    {
                        Console.Error.WriteLine(e.Message);
                    }
                }
            }
        }

        /// <summary>
        /// Default constructor
        /// </summary>
        public MainForm()
        {
            InitializeComponent();
            MaterialSkinManager material_skin_manager = MaterialSkinManager.Instance;
            material_skin_manager.AddFormToManage(this);
            material_skin_manager.Theme = MaterialSkinManager.Themes.DARK;
            material_skin_manager.ColorScheme = new ColorScheme(Primary.Blue700, Primary.Blue800, Primary.Blue500, Accent.LightBlue200, TextShade.WHITE);
            gameStatusSingleLineTextField.Text = ConfigData.GameStatus;
        }

        /// <summary>
        /// Game status single line text field text changed event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Event arguments</param>
        private void gameStatusSingleLineTextField_TextChanged(object sender, EventArgs e)
        {
            ConfigData.GameStatus = gameStatusSingleLineTextField.Text;
            Text = configData.GameStatus;
        }

        /// <summary>
        /// Main form closing event
        /// </summary>
        /// <param name="sender">Sender</param>
        /// <param name="e">Form closing event arguments</param>
        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            ConfigData.GameStatus = gameStatusSingleLineTextField.Text;
            ConfigData = configData;
        }
    }
}
