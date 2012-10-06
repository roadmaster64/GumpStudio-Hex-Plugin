using System;
using System.IO;
using System.Drawing;
using System.Windows.Forms;

namespace ConversionUtility
{
    public partial class ConversionForm : Form
    {
        ConversionForm form;
        ConversionUtility_Plugin plugin;
        private string text = "";
        public string SourceText { get { return text; } set { text = value; } }
        public string ConvertValue { get { return ConvertedValue.Text; } set { ConvertedValue.Text = value; } }
        private ComboBox box = new ComboBox();

        //static public void Main()
        //{
        //    Application.Run(new ConversionForm());
        //}

        //public ConversionForm()
        //{
        //    InitializeComponent();
        //    plugin = new ConversionUtility_Plugin();
        //}

        public ConversionForm(ConversionUtility_Plugin cuPlugin)
        {
            InitializeComponent();
            form = this;
            plugin = cuPlugin;
        }

        private void SourceValue_TextChanged(object sender, EventArgs e)
        {
            text = SourceValue.Text;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            box = comboBox1;

            int selectedIndex = box.SelectedIndex;
            Object selectedItem = box.SelectedItem;

            box.Text = box.SelectedItem.ToString();

            if (selectedIndex == 0)//Hex to Int
            {
                plugin.Index0(this);
            }
            if (selectedIndex == 1)//Int to Hex
            {
                string ch;
                bool Integer = plugin.CheckValue(text, out ch);
                string str = string.Format("The source value is not a (int)value\r\nInvalid (int)characters in Source value:\r\n\r\n\t [{0}]", ch);
                if (Integer)
                    plugin.Index1(this);
                else
                {
                    ConvertedValue.Text = "Error";
                    MessageBox.Show(str, "Invalid Source Format", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                }
            }
        }

        private void classBreakdownToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Documentation Under Construction");
            //try
            //{
            //    ClassOverview.DisplayHtml();
            //}
            //catch (IOException io)
            //{
            //    MessageBox.Show("classBreakdownToolStripMenuItem_Click\r\n" + io.Message + "\r\n" + io.StackTrace);
            //}
        }

        private void Quit_Click(object sender, EventArgs e)
        {
            // no matter what i do i cant seem to force null the converter on exit.
            form.Close();
            form.Dispose();
            form = null;
            if(plugin.IsLoaded)
            plugin.Unload();
            plugin = null;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            form.Close();
        }

        private void exitGumpStudioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AboutBox1 about = new AboutBox1(plugin, form);
            about.Show(form);
        }
    }
}


//namespace Plugins 
//{ 
//    public abstract class BasePlugin 
//    { 
//        protected bool mIsLoaded = false; 
        
//        public abstract string Name { 
//            get; 
//        } 
//        public abstract PluginInfo GetPluginInfo(); 
        
//        public virtual void Unload() 
//        { 
//        } 
        
//        public virtual void InitializeElementExtenders(BaseElement Element) 
//        { 
//            //The plugin should walk the array of BaseElements and check the type. 
//            //If it is a type that this plugin handles it should cast it to the correct type 
//            //and call the elements AddExtender method. 
//        } 
        
//        public virtual void MouseMoveHook(ref MouseMoveHookEventArgs e) 
//        { 
            
//        } 
        
//        public virtual void Load(DesignerForm frmDesigner) 
//        { 
//            mIsLoaded = true; 
//        } 
        
//        public bool IsLoaded { 
//            get { return mIsLoaded; } 
//        } 
        
//    } 
    
//    [Serializable()] 
//    public class PluginInfo 
//    { 
//        public string PluginName; 
//        public string AuthorName; 
//        public string AuthorEmail; 
//        public string Version; 
//        public string Description; 
        
//        public override string ToString() 
//        { 
//            return PluginName; 
//        } 
        
//        public bool Equals(PluginInfo Info) 
//        { 
//            if (this.AuthorEmail != Info.AuthorEmail) 
//                return false; 
//            if (this.AuthorName != Info.AuthorName) 
//                return false; 
//            if (this.Description != Info.Description) 
//                return false; 
//            if (this.PluginName != Info.PluginName) 
//                return false; 
//            if (this.Version != Info.Version) 
//                return false; 
//            return true; 
//        } 
//    } 
    
//    public abstract class ElementExtender 
//    { 
//        public virtual void AddContextMenus(ref System.Windows.Forms.MenuItem GroupMenu, ref System.Windows.Forms.MenuItem PositionMenu, ref System.Windows.Forms.MenuItem OrderMenu, ref System.Windows.Forms.MenuItem MiscMenu) 
//        { 
            
//        } 
//    } 
    
//    public class MouseMoveHookEventArgs : EventArgs 
//    { 
//        public Point MouseLocation; 
//        public MoveModeType MoveMode; 
//        public Windows.Forms.MouseButtons MouseButtons; 
//        public Windows.Forms.Keys Keys; 
//    } 
//} 