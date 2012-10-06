using System;
using System.Text;
using System.Windows.Forms;
using GumpStudio;
using GumpStudio.Plugins;

namespace ConversionUtility
{
    public class ConversionUtility_Plugin : BasePlugin
    {
        protected DesignerForm designer = new DesignerForm();
        protected ConversionForm conversionForm;
        protected MenuItem m_MenuConverter;
        protected MenuItem m_UtilityMenu = new MenuItem("Tools");
        private PluginInfo info;
        private string stringvalue = "";
        private int toInt = 0;
        private string toHex = "";
        private const string HexChars = "0123456789ABCDEF";
        private const string hexPrefix = "0x";
        private const string intChars = "0123456789";

        private bool error;
        private int InvalidHex = -1;
        private int NotInteger = -2;

        #region [ (bool) NullString() null string check ]
        private bool NullString()
        {
            if (stringvalue == "" || stringvalue == " " || stringvalue.Length == 0)
            {
                stringvalue = "please insert a value to check!";
                conversionForm.ConvertValue = stringvalue;
                return true;
            }
            return false;
        }
        #endregion

        #region [ (bool) Check text value ]
        public bool CheckValue(string text, out string cha)
        {
            string ch;
            int i;
            StringBuilder sb = new StringBuilder();

            bool yes = int.TryParse(text, out i);
            if (yes)
            {
                cha = "";
                return true;
            }
            else
            {
                for (int it = 0; it < text.Length; ++it)
                {
                    int yep;
                    ch = text[it].ToString();
                    bool ok = int.TryParse(ch, out yep);
                    if (ok)
                        continue;
                    else
                    {
                        if (sb.Length == 0)
                            sb.AppendFormat(String.Format("{0}", ch));
                        else
                            sb.AppendFormat(String.Format("{0},", ch));
                    }
                }
                cha = sb.ToString();
                return false;
            }
        }
        #endregion

        #region [ Hexidecimal to Integer Conversion Methods ]
        public void Index0(ConversionForm form)
        {
            conversionForm = form;
            stringvalue = conversionForm.SourceText;

            if (NullString())
                return;

            HexToIntConversion();
        }

        private void HexToIntConversion()
        {
            toInt = ValidHex(stringvalue);

            if (toInt == InvalidHex && error == true)
                conversionForm.ConvertValue = "Invalid Hex Value!";
            else if (toInt == NotInteger && error == true)
            {
                conversionForm.ConvertValue = "Error";
                MessageBox.Show("Hex Value is too Large for an (int) Conversion.", "(Hex to (int)) Conversion Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
            }
            else
                conversionForm.ConvertValue = toInt.ToString();

            toInt = 0;
            error = false;
        }

        private int ValidHex(string hexString)
        {
            string newString = "";
            if (hexString.StartsWith("0x"))
            {
                newString = hexString.Substring(2).ToUpper();
            }
            else
                newString = hexString.ToUpper();

            for (int i = 0; i < newString.Length; ++i)
            {
                if (HexChars.Contains(newString[i].ToString()))
                    continue;
                else
                {
                    error = true;
                    return InvalidHex;// Invalid Hex Value
                }
            }

            return HexToInt(newString);
        }

        private int HexToInt(string hexString)
        {
            int value = 0;
            string validInt = "";
            bool ok = false;

            ok = int.TryParse(hexString, System.Globalization.NumberStyles.HexNumber, null, out value);
            
            if (ok)
                validInt = value.ToString("x");
            else
            {
                error = true;
                return NotInteger;// Hex not convertable to Int.
            }

            return value = int.Parse(validInt, System.Globalization.NumberStyles.HexNumber);
        }
        #endregion

        #region [ Integer to Hexidecimal Conversion Methods ]
        public void Index1(ConversionForm form)
        {
            conversionForm = form;
            stringvalue = conversionForm.SourceText;

            if (NullString())
                return;

            IntToHexConversion();
        }

        private void IntToHexConversion()
        {
            if (stringvalue != "" && stringvalue.Length > 0)
                toHex = IntToHex(stringvalue);
            
            if (toHex == "")
                conversionForm.ConvertValue = "Insert Valid (int) Value!";
            else
                conversionForm.ConvertValue = toHex.ToString();
        }

        private string IntToHex(string intValue)
        {
            for (int i = 0; i < intValue.Length; i++)
            {
                string ch = intValue[i].ToString();
                if (intChars.Contains(ch))
                    continue;
                else if (ch == "-")
                {
                    MessageBox.Show("Negative ((int)value) to ((Hex)value) conversion not supported!", "Negative Integer Warning", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                    return "Error";
                }
                else
                    return "Invalid Format: (int)value!";
            }
            int number;
            bool ok = int.TryParse(intValue, out number);
            
            if (ok)
                return hexPrefix + number.ToString("x");
            else
                return "Invalid (int) value";
        }
        #endregion

        #region [ Core Conversion Functions ]
        public void StartConverter(object sender, EventArgs e)
        {
            if (conversionForm != null)
            {
                conversionForm.Close();
                conversionForm = new ConversionForm(this);
                conversionForm.Show();
            }
            else
            {
                conversionForm = new ConversionForm(this);
                conversionForm.Show();
            }
        }

        private MenuItem FindMenu(MainMenu menu)
        {
            foreach (MenuItem item in menu.MenuItems)
            {
                if (item.Text == "Tools")
                    return item;
                else
                    continue;
            }

            // item was not found
            menu.MenuItems.Add(m_UtilityMenu);
            return m_UtilityMenu;
        }

        private string ParseVersion()
        {
            string major = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Major.ToString();
            string minor = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Minor.ToString();
            string build = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Build.ToString();
            string revision = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.Revision.ToString();

            return String.Format("{0}.{1}.{2}.{3}", major, minor, build, revision);
        }
        #endregion

        #region [ GumpStudio overrides ]
        public override void Load(DesignerForm frmDesigner)
        {
            try
            {
                designer = frmDesigner;
                m_MenuConverter = new MenuItem("Hex Conversion Utility", new EventHandler(StartConverter), Shortcut.CtrlH);

                MenuItem utility = FindMenu(designer.MainMenu);
                utility.MenuItems.Add(m_MenuConverter);

                base.Load(frmDesigner);
            }
            catch (Exception e)
            {
                MessageBox.Show("Load(DesignerForm frmDesigner)\r\n" + e);
                Application.Exit();
            }
        }

        public override PluginInfo GetPluginInfo()
        {
            info = new PluginInfo();
            info.AuthorEmail = "roadmaster64@comcast.net";
            info.AuthorName = "roadmaster / Mark Sweetman";
            info.Description = "Utility Plugin for converting a Hexidecimal to a Integer or a Integer to a Hexidecimal value.";
            info.Version = ParseVersion();
            info.PluginName = this.Name;
            return info;
        }

        public override string Name
        {
            get { return "Conversion Utility (c)2008"; }
        }
        #endregion
    }
}
