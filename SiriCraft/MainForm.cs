using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Win32;

namespace SiriCraft
{
	public partial class MainForm : Form
	{

		public string command = " -Xmx{MAXMB}M -Xms{MINMB}M -cp \"%APPDATA%/.minecraft/bin/minecraft.jar;%APPDATA%/.minecraft/bin/lwjgl.jar;%APPDATA%/.minecraft/bin/lwjgl_util.jar;%APPDATA%/.minecraft/bin/jinput.jar\" -Djava.library.path=\"%APPDATA%/.minecraft/bin/natives\" net.minecraft.client.Minecraft ";
		public string javapath;
		
		public MainForm()
		{
			InitializeComponent();
			
			if(Environment.Is64BitOperatingSystem){
				javapath = JavaPath64();
			}else{
				javapath = JavaPath32();
			}
			
			if(javapath == ""){
				MessageBox.Show("No se ha podido localizar Java en su sistema, es necesario instalar Java para que Minecraft funcione", "Java no encontrado", MessageBoxButtons.OK);
				this.Close();
			}
			
			object userNameFR = Registry.GetValue("HKEY_CURRENT_USER\\SiriCraft","username","");
			object megabytesFR = Registry.GetValue("HKEY_CURRENT_USER\\SiriCraft","megabytes",512);
			
			if(userNameFR == null){
				Registry.SetValue("HKEY_CURRENT_USER\\SiriCraft","username","");
				userName.Text = "";
			}else{
				userName.Text = userNameFR.ToString();
			}
			
			if(megabytesFR == null){
				Registry.SetValue("HKEY_CURRENT_USER\\SiriCraft","megabytes",megabytes.Minimum);
				megabytes.Value = megabytes.Minimum;
			}else{
				megabytes.Value = Convert.ToDecimal(megabytesFR);
			}
		}
		
		void EnterButtonClick(object sender, EventArgs e)
		{
			string com = command.Replace("{MAXMB}", megabytes.Value.ToString());
			string attr;
			com = com.Replace("{MINMB}", megabytes.Value.ToString());
			System.Diagnostics.Process process = new System.Diagnostics.Process();
			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
			if (showConsole.Checked == false){
				startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
				attr = "/C";
			}else{
				attr = "/K";
			}
			startInfo.FileName = "cmd.exe";
			startInfo.Arguments = attr + " \"" + "\"" + javapath + "\\bin\\java.exe\"" + com + userName.Text + "\"";
			process.StartInfo = startInfo;
			Registry.SetValue("HKEY_CURRENT_USER\\SiriCraft","username",userName.Text);
			Registry.SetValue("HKEY_CURRENT_USER\\SiriCraft","megabytes",megabytes.Value);
			process.Start();
			this.Close();
		}
		
		string JavaPath64(){
			string value64 = string.Empty; 
			RegistryKey localKey = 
			    RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, 
			        RegistryView.Registry64); 
			localKey = localKey.OpenSubKey(@"SOFTWARE\JavaSoft\Java Runtime Environment\1.7"); 
			if (localKey != null){ 
			    value64 = localKey.GetValue("JavaHome").ToString();
			    return value64;
			}else{
				return "";
			}
		}
		
		string JavaPath32(){
			string value32 = string.Empty; 
			RegistryKey localKey = 
			    RegistryKey.OpenBaseKey(Microsoft.Win32.RegistryHive.LocalMachine, 
			        RegistryView.Registry32); 
			localKey = localKey.OpenSubKey(@"SOFTWARE\JavaSoft\Java Runtime Environment\1.7"); 
			if (localKey != null){ 
			    value32 = localKey.GetValue("JavaHome").ToString();
			    return value32;
			}else{
				return "";
			}
		}
	}
}
