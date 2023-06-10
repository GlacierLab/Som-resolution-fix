using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace XGWin
{
	// Token: 0x02000039 RID: 57
	public class Form1 : Form
	{
		// Token: 0x060000C5 RID: 197 RVA: 0x0000940C File Offset: 0x0000760C
		private string ChangeWindowModeText(bool isFullScreen)
		{
			string text = string.Empty;
			switch (this.userLanguage)
			{
			case 0:
				text = (isFullScreen ? "ウィンドウモード" : "フルスクリーン");
				break;
			case 1:
				text = (isFullScreen ? "WindowMode" : "FullScreen");
				break;
			case 2:
				text = (isFullScreen ? "Mode fenêtre" : "Plein écran");
				break;
			case 3:
				text = (isFullScreen ? "窗口顯示" : "全屏");
				break;
			case 4:
				text = (isFullScreen ? "窗口显示" : "全屏");
				break;
			}
			return text;
		}

		// Token: 0x060000C6 RID: 198 RVA: 0x0000949C File Offset: 0x0000769C
		public Form1(params string[] args)
		{
			if (args.Length != 0)
			{
				int num = Array.IndexOf<string>(args, "-lang");
				if (num >= 0 && args.Length > num + 1)
				{
					int num2 = -1;
					if (int.TryParse(args[num + 1], out num2))
					{
						this.SetUserLanguage(num2);
					}
				}
			}
			this.InitializeComponent(this.client_width, this.client_height);
			base.ClientSize = new Size(this.client_width, this.client_height + 25);
			ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(KeyConfig));
			base.Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
			Screen screen = Screen.FromControl(this);
			this.disp_width = screen.Bounds.Size.Width;
			this.disp_height = screen.Bounds.Size.Height;
			base.FormBorderStyle = FormBorderStyle.FixedSingle;
			switch (this.userLanguage)
			{
			case 0:
				this.FileToolStripMenuItem.Text = "ファイル";
				this.QuickSaveToolStripMenuItem.Text = "クイックセーブ";
				this.QuickLoadToolStripMenuItem.Text = "クイックロード";
				this.SaveToolStripMenuItem.Text = "セーブ";
				this.LoadToolStripMenuItem.Text = "ロード";
				this.FullscreenToolStripMenuItem.Text = this.ChangeWindowModeText(false);
				this.BackToTitleToolStripMenuItem.Text = "タイトルに戻る";
				this.ExitGameToolStripMenuItem.Text = "ゲーム終了";
				this.GameOperationToolStripMenuItem.Text = "ゲーム操作";
				this.AutoToolStripMenuItem.Text = "オート";
				this.TextSkipToolStripMenuItem.Text = "テキストスキップ";
				this.HideTextAreaToolStripMenuItem.Text = "テキストエリア非表示";
				this.MenuToolStripMenuItem.Text = "メニュー";
				this.ChartToolStripMenuItem.Text = "チャート";
				this.D4UStatusToolStripMenuItem.Text = "D4Uステータス";
				this.BackLogToolStripMenuItem.Text = "バックログ";
				this.DictionaryToolStripMenuItem.Text = "辞書";
				this.OptionToolStripMenuItem.Text = "オプション";
				this.HelpToolStripMenuItem.Text = "ヘルプ";
				this.VersionInfoToolStripMenuItem.Text = "バージョン情報";
				this.KeyConfigToolStripMenuItem.Text = "キーコンフィグ";
				this.HelpToolStripMenuItem1.Text = "ヘルプ";
				return;
			case 1:
				this.FileToolStripMenuItem.Text = "File";
				this.QuickSaveToolStripMenuItem.Text = "Quick Save";
				this.QuickLoadToolStripMenuItem.Text = "Quick Load";
				this.SaveToolStripMenuItem.Text = "Save";
				this.LoadToolStripMenuItem.Text = "Load";
				this.FullscreenToolStripMenuItem.Text = this.ChangeWindowModeText(false);
				this.BackToTitleToolStripMenuItem.Text = "To Title";
				this.ExitGameToolStripMenuItem.Text = "Game Exit";
				this.GameOperationToolStripMenuItem.Text = "Operation";
				this.AutoToolStripMenuItem.Text = "Auto";
				this.TextSkipToolStripMenuItem.Text = "Text Skip";
				this.HideTextAreaToolStripMenuItem.Text = "Hidden Text Area";
				this.MenuToolStripMenuItem.Text = "Menu";
				this.ChartToolStripMenuItem.Text = "Chart";
				this.D4UStatusToolStripMenuItem.Text = "D4U Status";
				this.BackLogToolStripMenuItem.Text = "Logs";
				this.DictionaryToolStripMenuItem.Text = "Glossary";
				this.OptionToolStripMenuItem.Text = "Option";
				this.HelpToolStripMenuItem.Text = "Help";
				this.VersionInfoToolStripMenuItem.Text = "Version Info";
				this.KeyConfigToolStripMenuItem.Text = "Key Config";
				this.HelpToolStripMenuItem1.Text = "Help";
				return;
			case 2:
				this.FileToolStripMenuItem.Text = "Fichier";
				this.QuickSaveToolStripMenuItem.Text = "Sauv Rapide";
				this.QuickLoadToolStripMenuItem.Text = "Charg Rap";
				this.SaveToolStripMenuItem.Text = "Sauver";
				this.LoadToolStripMenuItem.Text = "Charger";
				this.FullscreenToolStripMenuItem.Text = this.ChangeWindowModeText(false);
				this.BackToTitleToolStripMenuItem.Text = "Vers Titre";
				this.ExitGameToolStripMenuItem.Text = "Fin du jeu";
				this.GameOperationToolStripMenuItem.Text = "Opération";
				this.AutoToolStripMenuItem.Text = "Auto";
				this.TextSkipToolStripMenuItem.Text = "Passer";
				this.HideTextAreaToolStripMenuItem.Text = "Masquer le texte";
				this.MenuToolStripMenuItem.Text = "Menu";
				this.ChartToolStripMenuItem.Text = "Graphique";
				this.D4UStatusToolStripMenuItem.Text = "Status D4U";
				this.BackLogToolStripMenuItem.Text = "Logs";
				this.DictionaryToolStripMenuItem.Text = "Glossaire";
				this.OptionToolStripMenuItem.Text = "Optin";
				this.HelpToolStripMenuItem.Text = "Aide";
				this.VersionInfoToolStripMenuItem.Text = "Informations sur la version";
				this.KeyConfigToolStripMenuItem.Text = "configuration de clé";
				this.HelpToolStripMenuItem1.Text = "Aide";
				return;
			case 3:
				this.FileToolStripMenuItem.Text = "文件";
				this.QuickSaveToolStripMenuItem.Text = "快速保存";
				this.QuickLoadToolStripMenuItem.Text = "快速繼續";
				this.SaveToolStripMenuItem.Text = "保存";
				this.LoadToolStripMenuItem.Text = "繼續遊戲";
				this.FullscreenToolStripMenuItem.Text = this.ChangeWindowModeText(false);
				this.BackToTitleToolStripMenuItem.Text = "返回標題畫面";
				this.ExitGameToolStripMenuItem.Text = "結束遊戲";
				this.GameOperationToolStripMenuItem.Text = "遊戲操作";
				this.AutoToolStripMenuItem.Text = "自動模式";
				this.TextSkipToolStripMenuItem.Text = "跳過文本";
				this.HideTextAreaToolStripMenuItem.Text = "隱藏文本欄";
				this.MenuToolStripMenuItem.Text = "選單";
				this.ChartToolStripMenuItem.Text = "路線圖表";
				this.D4UStatusToolStripMenuItem.Text = "D4U狀態";
				this.BackLogToolStripMenuItem.Text = "對話記錄";
				this.DictionaryToolStripMenuItem.Text = "辭典";
				this.OptionToolStripMenuItem.Text = "設定";
				this.HelpToolStripMenuItem.Text = "幫助";
				this.VersionInfoToolStripMenuItem.Text = "版本信息";
				this.KeyConfigToolStripMenuItem.Text = "關鍵配置";
				this.HelpToolStripMenuItem1.Text = "幫助";
				return;
			case 4:
				this.FileToolStripMenuItem.Text = "文件";
				this.QuickSaveToolStripMenuItem.Text = "快速保存";
				this.QuickLoadToolStripMenuItem.Text = "快速继续";
				this.SaveToolStripMenuItem.Text = "保存";
				this.LoadToolStripMenuItem.Text = "继续游戏";
				this.FullscreenToolStripMenuItem.Text = "全屏";
				this.BackToTitleToolStripMenuItem.Text = "返回标题画面";
				this.ExitGameToolStripMenuItem.Text = "结束游戏";
				this.GameOperationToolStripMenuItem.Text = "游戏操作";
				this.AutoToolStripMenuItem.Text = "自动模式";
				this.TextSkipToolStripMenuItem.Text = "跳过文本";
				this.HideTextAreaToolStripMenuItem.Text = "隐藏文本栏";
				this.MenuToolStripMenuItem.Text = "菜单";
				this.ChartToolStripMenuItem.Text = "路线图表";
				this.D4UStatusToolStripMenuItem.Text = "D4U状态";
				this.BackLogToolStripMenuItem.Text = "对话记录";
				this.DictionaryToolStripMenuItem.Text = "辞典";
				this.OptionToolStripMenuItem.Text = "设置";
				this.HelpToolStripMenuItem.Text = "帮助";
				this.VersionInfoToolStripMenuItem.Text = "版本信息";
				this.KeyConfigToolStripMenuItem.Text = "关键配置";
				this.HelpToolStripMenuItem1.Text = "帮助";
				return;
			default:
				return;
			}
		}

		// Token: 0x060000C7 RID: 199 RVA: 0x00009CE8 File Offset: 0x00007EE8
		public Form1(string comm)
		{
			this.InitializeComponent(this.client_width, this.client_height);
			this.Text = "hoge";
			Environment.Exit(0);
		}

		// Token: 0x060000C8 RID: 200 RVA: 0x00002888 File Offset: 0x00000A88
		private void Form1_Shown(object sender, EventArgs e)
		{
			this.PreviewTitleInit(-1);
		}

		// Token: 0x060000C9 RID: 201
		private void Form1_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!this.bFinished)
			{
				this.SetSystemMenuTrg(64U, 0U);
				e.Cancel = true;
				return;
			}
		}

		// Token: 0x060000CA RID: 202
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GLInit")]
		private static extern int GLSetup(IntPtr hwnd, IntPtr hdc);

		// Token: 0x060000CB RID: 203
		private void Form1_Load(object sender, EventArgs e)
		{
			this.client_height = 1440;
			this.client_width = 2560;
			this.gs = this.panel1.CreateGraphics();
			this.hdc = this.gs.GetHdc();
			Form1.APIPostMessageDLL(1, 0U, (uint)this.userLanguage);
			this.LoadKeyMap();
			Form1.GLSetup(this.panel1.Handle, this.hdc);
		}

		// Token: 0x060000CC RID: 204
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GLInit")]
		private static extern int GLInit2(IntPtr hwnd, IntPtr hdc, int adr);

		// Token: 0x060000CD RID: 205 RVA: 0x00009DD4 File Offset: 0x00007FD4
		private bool GLInit(IntPtr hwnd, IntPtr hdc, int adr)
		{
			if (this.GLError)
			{
				return false;
			}
			bool flag = Form1.GLInit2(hwnd, hdc, adr) != 0;
			if (!flag)
			{
				this.GLError = true;
				MessageBox.Show("エラーが発生したので、ツールを再起動してください");
				this.bFinished = true;
				Form1.SetDisplayFullScreen(Screen.FromControl(this).DeviceName, this.disp_width, this.disp_height);
				Application.Exit();
			}
			return flag;
		}

		// Token: 0x060000CE RID: 206
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GLInitToTitle")]
		private static extern int GLInitToTitle2(IntPtr hwnd, IntPtr hdc);

		// Token: 0x060000CF RID: 207 RVA: 0x00009E34 File Offset: 0x00008034
		private bool GLInitToTitle(IntPtr hwnd, IntPtr hdc)
		{
			if (this.GLError)
			{
				return false;
			}
			bool flag = Form1.GLInitToTitle2(hwnd, hdc) != 0;
			if (!flag)
			{
				this.GLError = true;
				MessageBox.Show("エラーが発生したので、ツールを再起動してください");
				this.bFinished = true;
				Form1.SetDisplayFullScreen(Screen.FromControl(this).DeviceName, this.disp_width, this.disp_height);
				Application.Exit();
			}
			return flag;
		}

		// Token: 0x060000D0 RID: 208
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, EntryPoint = "GLDraw")]
		private static extern int GLDraw2();

		// Token: 0x060000D1 RID: 209
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void APIPostMessageDLL(int type, uint wParam, uint lParam);

		// Token: 0x060000D2 RID: 210 RVA: 0x00009E94 File Offset: 0x00008094
		private void GLDraw()
		{
			if (this.GLError)
			{
				return;
			}
			Queue<Form1.MessageCommand> queue = this.commandQueue;
			lock (queue)
			{
				Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeCommandEnd);
				this.commandQueue.Enqueue(messageCommand);
				while (this.commandQueue.Count != 0)
				{
					Form1.MessageCommand messageCommand2 = this.commandQueue.Dequeue();
					Form1.APIPostMessageDLL((int)messageCommand2.type, messageCommand2.wParam, messageCommand2.lParam);
				}
			}
			if (Form1.GLDraw2() == 0)
			{
				this.GLError = true;
				MessageBox.Show("エラーが発生したので、ツールを再起動してください");
				this.bFinished = true;
				Form1.SetDisplayFullScreen(Screen.FromControl(this).DeviceName, this.disp_width, this.disp_height);
				Application.Exit();
			}
		}

		// Token: 0x060000D3 RID: 211
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void APIPush(int bit);

		// Token: 0x060000D4 RID: 212
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void APIClick(int x, int y);

		// Token: 0x060000D5 RID: 213
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void APIGetStr(StringBuilder lpbuf);

		// Token: 0x060000D6 RID: 214
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void APIGetNowFile(StringBuilder lpbuf);

		// Token: 0x060000D7 RID: 215
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void APISetNowFile(string fname);

		// Token: 0x060000D8 RID: 216
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void APISetName(int type, int kind);

		// Token: 0x060000D9 RID: 217
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern void APISetValue(int n, int val);

		// Token: 0x060000DA RID: 218
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl)]
		private static extern int APIGetValue(int n);

		// Token: 0x060000DB RID: 219
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void APIGetNowBG(StringBuilder lpbuf);

		// Token: 0x060000DC RID: 220
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void APIGetErrorLog(StringBuilder lpbuf);

		// Token: 0x060000DD RID: 221 RVA: 0x000028C9 File Offset: 0x00000AC9
		private void PreviewTitleInit(int line = -1)
		{
			if (!this.GLInitToTitle(base.Handle, this.hdc))
			{
				return;
			}
			this.befTime = DateTime.Now;
			this.timerFrame.Enabled = true;
		}

		// Token: 0x060000DE RID: 222 RVA: 0x00009F64 File Offset: 0x00008164
		private void timerFrame_Tick(object sender, EventArgs e)
		{
			if (base.WindowState == FormWindowState.Maximized)
			{
				this.menuStrip1.Visible = this.mouse_y <= 34;
				this.menuStrip1.BringToFront();
			}
			this.GLDraw();
			this.FPSCount++;
			DateTime now = DateTime.Now;
			if ((now - this.befTime).TotalMilliseconds > 1000.0)
			{
				this.befTime = now;
				this.FPSCount = 0;
				GC.Collect();
			}
		}

		// Token: 0x060000DF RID: 223
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int APIGetInput(string lpbuf);

		// Token: 0x060000E0 RID: 224
		[DllImport("Imm32.Dll")]
		private static extern int ImmGetContext(IntPtr hWnd);

		// Token: 0x060000E1 RID: 225
		[DllImport("Imm32.Dll")]
		private static extern bool ImmReleaseContext(IntPtr hWnd, int hIMC);

		// Token: 0x060000E2 RID: 226
		[DllImport("Imm32.Dll")]
		private static extern bool ImmSetOpenStatus(int hIMC, bool fOpen);

		// Token: 0x060000E3 RID: 227 RVA: 0x00009FEC File Offset: 0x000081EC
		private void panel1_MouseDown(object sender, MouseEventArgs e)
		{
			if (this.inputFlg)
			{
				Form1.APIGetInput(this.myText.Text);
				IntPtr handle = this.myText.Handle;
				int num = Form1.ImmGetContext(handle);
				Form1.ImmSetOpenStatus(num, false);
				Form1.ImmSetOpenStatus(num, true);
				Form1.ImmReleaseContext(handle, num);
				this.myText.TextChanged -= this.ime_TextChanged;
				base.Controls.Remove(this.myText);
				this.myText.Dispose();
				this.myText = null;
				this.inputFlg = false;
			}
			Queue<Form1.MessageCommand> queue = this.commandQueue;
			lock (queue)
			{
				Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeMouseDown);
				messageCommand.wParam = (uint)(e.Button >> 20);
				this.commandQueue.Enqueue(messageCommand);
			}
		}

		// Token: 0x060000E4 RID: 228 RVA: 0x0000A0CC File Offset: 0x000082CC
		private void panel1_MouseUp(object sender, MouseEventArgs e)
		{
			Queue<Form1.MessageCommand> queue = this.commandQueue;
			lock (queue)
			{
				Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeMouseUp);
				messageCommand.wParam = (uint)(e.Button >> 20);
				this.commandQueue.Enqueue(messageCommand);
			}
		}

		// Token: 0x060000E5 RID: 229 RVA: 0x0000A128 File Offset: 0x00008328
		private void panel1_MouseMove(object sender, MouseEventArgs e)
		{
			Queue<Form1.MessageCommand> queue = this.commandQueue;
			lock (queue)
			{
				this.mouse_y = e.Y;
				Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeMouseMove);
				float num = 1920f / (float)this.panel1.Width * (float)e.X;
				float num2 = 1080f / (float)this.panel1.Height * (float)e.Y;
				messageCommand.lParam = (uint)(((int)num << 16) + (int)num2);
				this.commandQueue.Enqueue(messageCommand);
			}
		}

		// Token: 0x060000E6 RID: 230 RVA: 0x0000A1C8 File Offset: 0x000083C8
		private void panel1_MouseWheel(object sender, MouseEventArgs e)
		{
			Queue<Form1.MessageCommand> queue = this.commandQueue;
			lock (queue)
			{
				Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeMouseWheel);
				messageCommand.lParam = (uint)e.Delta;
				this.commandQueue.Enqueue(messageCommand);
			}
		}

		// Token: 0x060000E7 RID: 231 RVA: 0x0000A224 File Offset: 0x00008424
		private bool isArrowKey(KeyEventArgs e)
		{
			if (this.keyMap.ContainsValue(e.KeyCode))
			{
				KeyConfig.keyCode key = this.keyMap.First((KeyValuePair<KeyConfig.keyCode, Keys> k) => k.Value == e.KeyCode).Key;
				return key == KeyConfig.keyCode.eBUTTON_UP || key == KeyConfig.keyCode.eBUTTON_DOWN || key == KeyConfig.keyCode.eBUTTON_RIGHT || key == KeyConfig.keyCode.eBUTTON_LEFT;
			}
			return false;
		}

		// Token: 0x060000E8 RID: 232 RVA: 0x0000A28C File Offset: 0x0000848C
		private void Form1_KeyDown(object sender, KeyEventArgs e)
		{
			if (this.keyPair.ContainsKey(e.KeyCode) && this.keyPair[e.KeyCode])
			{
				return;
			}
			if (this.keyPair.ContainsKey(e.KeyCode))
			{
				this.keyPair[e.KeyCode] = true;
			}
			else
			{
				this.keyPair.Add(e.KeyCode, true);
			}
			if (e.KeyCode == Keys.ShiftKey)
			{
				this.isShiftDown = true;
			}
			if (e.KeyCode == Keys.ControlKey)
			{
				this.isCtrlDown = true;
			}
			if (this.keyMap.ContainsValue(e.KeyCode))
			{
				KeyConfig.keyCode key = this.keyMap.First((KeyValuePair<KeyConfig.keyCode, Keys> k) => k.Value == e.KeyCode).Key;
				Queue<Form1.MessageCommand> queue = this.commandQueue;
				lock (queue)
				{
					if (this.isShiftDown && this.isArrowKey(e))
					{
						Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeRStickMove);
						messageCommand.lParam = this.ConvertStickForce(key, true);
						this.commandQueue.Enqueue(messageCommand);
						return;
					}
					if (this.isCtrlDown && this.isArrowKey(e))
					{
						Form1.MessageCommand messageCommand2 = new Form1.MessageCommand(Form1.MessageType.TypeLStickMove);
						messageCommand2.lParam = this.ConvertStickForce(key, true);
						this.commandQueue.Enqueue(messageCommand2);
						return;
					}
					Form1.MessageCommand messageCommand3 = new Form1.MessageCommand(Form1.MessageType.TypeKeyDown);
					messageCommand3.lParam = (uint)key;
					this.commandQueue.Enqueue(messageCommand3);
					return;
				}
			}
			if (e.KeyCode == Keys.Return)
			{
				if (((Form)sender).ActiveControl is TextBox)
				{
					Form1.APIGetInput(this.myText.Text);
					this.myText.TextChanged -= this.ime_TextChanged;
					base.Controls.Remove(this.myText);
					this.myText.Dispose();
					this.myText = null;
					this.inputFlg = false;
				}
				Form1.MessageCommand messageCommand4 = new Form1.MessageCommand(Form1.MessageType.TypeKeyDown);
				messageCommand4.lParam = 65536U;
				this.commandQueue.Enqueue(messageCommand4);
				return;
			}
			if (e.KeyCode == Keys.Space)
			{
				Form1.MessageCommand messageCommand5 = new Form1.MessageCommand(Form1.MessageType.TypeSpaceKeyDown);
				messageCommand5.lParam = 131072U;
				this.commandQueue.Enqueue(messageCommand5);
				return;
			}
			if (e.KeyCode == Keys.Tab)
			{
				this.FullscreenToolStripMenuItem_Click(this, new EventArgs());
			}
		}

		// Token: 0x060000E9 RID: 233 RVA: 0x0000A53C File Offset: 0x0000873C
		private void Form1_KeyUp(object sender, KeyEventArgs e)
		{
			if (!this.keyPair.ContainsKey(e.KeyCode) || !this.keyPair[e.KeyCode])
			{
				return;
			}
			this.keyPair[e.KeyCode] = false;
			if (e.KeyCode == Keys.ShiftKey)
			{
				this.isShiftDown = false;
				Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeRStickReset);
				this.commandQueue.Enqueue(messageCommand);
			}
			if (e.KeyCode == Keys.ControlKey)
			{
				this.isCtrlDown = false;
				Form1.MessageCommand messageCommand2 = new Form1.MessageCommand(Form1.MessageType.TypeLStickReset);
				this.commandQueue.Enqueue(messageCommand2);
			}
			if (this.keyMap.ContainsValue(e.KeyCode))
			{
				KeyConfig.keyCode key = this.keyMap.First((KeyValuePair<KeyConfig.keyCode, Keys> k) => k.Value == e.KeyCode).Key;
				Queue<Form1.MessageCommand> queue = this.commandQueue;
				lock (queue)
				{
					if (this.isShiftDown && this.isArrowKey(e))
					{
						Form1.MessageCommand messageCommand3 = new Form1.MessageCommand(Form1.MessageType.TypeRStickMove);
						messageCommand3.lParam = this.ConvertStickForce(key, false);
						this.commandQueue.Enqueue(messageCommand3);
						return;
					}
					if (this.isCtrlDown && this.isArrowKey(e))
					{
						Form1.MessageCommand messageCommand4 = new Form1.MessageCommand(Form1.MessageType.TypeLStickMove);
						messageCommand4.lParam = this.ConvertStickForce(key, false);
						this.commandQueue.Enqueue(messageCommand4);
						return;
					}
					Form1.MessageCommand messageCommand5 = new Form1.MessageCommand(Form1.MessageType.TypeKeyUp);
					messageCommand5.lParam = (uint)key;
					this.commandQueue.Enqueue(messageCommand5);
					return;
				}
			}
			if (e.KeyCode == Keys.Return)
			{
				Form1.MessageCommand messageCommand6 = new Form1.MessageCommand(Form1.MessageType.TypeKeyUp);
				messageCommand6.lParam = 65536U;
				this.commandQueue.Enqueue(messageCommand6);
				return;
			}
			if (e.KeyCode == Keys.Space)
			{
				Form1.MessageCommand messageCommand7 = new Form1.MessageCommand(Form1.MessageType.TypeSpaceKeyUp);
				messageCommand7.lParam = 131072U;
				this.commandQueue.Enqueue(messageCommand7);
			}
		}

		// Token: 0x060000EA RID: 234 RVA: 0x000028F7 File Offset: 0x00000AF7
		private uint ConvertStickForce(KeyConfig.keyCode code, bool isDown)
		{
			return (uint)(((uint)code << 16) + (isDown ? 128 : 0));
		}

		// Token: 0x060000EB RID: 235 RVA: 0x0000A764 File Offset: 0x00008964
		private void Form1_LostFocus(object sender, EventArgs e)
		{
			this.isShiftDown = false;
			this.isCtrlDown = false;
			Queue<Form1.MessageCommand> queue = this.commandQueue;
			lock (queue)
			{
				this.commandQueue.Enqueue(new Form1.MessageCommand(Form1.MessageType.TypeRStickReset));
				this.commandQueue.Enqueue(new Form1.MessageCommand(Form1.MessageType.TypeLStickReset));
				this.commandQueue.Enqueue(new Form1.MessageCommand(Form1.MessageType.TypeButtonReset));
				this.commandQueue.Enqueue(new Form1.MessageCommand(Form1.MessageType.TypeMouseReset));
			}
		}

		// Token: 0x060000EC RID: 236 RVA: 0x0000A7F4 File Offset: 0x000089F4
		private void SetSystemMenuTrg(uint eventMask, uint w)
		{
			Queue<Form1.MessageCommand> queue = this.commandQueue;
			lock (queue)
			{
				Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeMenuBarEvent);
				messageCommand.lParam = eventMask;
				messageCommand.wParam = w;
				this.commandQueue.Enqueue(messageCommand);
			}
		}

		// Token: 0x060000ED RID: 237 RVA: 0x00002909 File Offset: 0x00000B09
		private void VersionInfoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(32768U, 0U);
			this._version_dialog.Show();
		}

		// Token: 0x060000EE RID: 238 RVA: 0x00002922 File Offset: 0x00000B22
		private void KeyConfigToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(65536U, 0U);
			Form1._keyconfig_dialog.Show(this);
		}

		// Token: 0x060000EF RID: 239 RVA: 0x0000293B File Offset: 0x00000B3B
		private int calcSize(int i0, int i1, float scale)
		{
			return (int)((float)i0 * scale - (float)i1 * scale);
		}

		// Token: 0x060000F0 RID: 240 RVA: 0x0000A850 File Offset: 0x00008A50
		private void HelpToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			switch (this.userLanguage)
			{
			case 0:
				Process.Start("jp\\manual\\manual.pdf");
				break;
			case 1:
				Process.Start("EN\\manual\\manual_en.pdf");
				break;
			case 2:
				Process.Start("FR\\manual\\manual_fr.pdf");
				break;
			case 3:
				Process.Start("CH_HAN\\manual\\manual_han.pdf");
				break;
			case 4:
				Process.Start("CH_KAN\\manual\\manual_kan.pdf");
				break;
			}
			this.SetSystemMenuTrg(131072U, 0U);
		}

		// Token: 0x060000F1 RID: 241 RVA: 0x00002947 File Offset: 0x00000B47
		private void ChartToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(1024U, 0U);
		}

		// Token: 0x060000F2 RID: 242 RVA: 0x00002955 File Offset: 0x00000B55
		private void D4UStatusToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(2048U, 0U);
		}

		// Token: 0x060000F3 RID: 243 RVA: 0x00002963 File Offset: 0x00000B63
		private void BackLogToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(4096U, 0U);
		}

		// Token: 0x060000F4 RID: 244 RVA: 0x00002971 File Offset: 0x00000B71
		private void DictionaryToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(8192U, 0U);
		}

		// Token: 0x060000F5 RID: 245 RVA: 0x0000297F File Offset: 0x00000B7F
		private void OptionToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(16384U, 0U);
		}

		// Token: 0x060000F6 RID: 246 RVA: 0x0000298D File Offset: 0x00000B8D
		private void AutoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(128U, 0U);
		}

		// Token: 0x060000F7 RID: 247 RVA: 0x0000299B File Offset: 0x00000B9B
		private void TextSkipToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(256U, 0U);
		}

		// Token: 0x060000F8 RID: 248 RVA: 0x000029A9 File Offset: 0x00000BA9
		private void HideTextAreaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(512U, 0U);
		}

		// Token: 0x060000F9 RID: 249 RVA: 0x000029B7 File Offset: 0x00000BB7
		private void QuickSaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(1U, 0U);
		}

		// Token: 0x060000FA RID: 250 RVA: 0x000029C1 File Offset: 0x00000BC1
		private void QuickLoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(2U, 0U);
		}

		// Token: 0x060000FB RID: 251 RVA: 0x000029CB File Offset: 0x00000BCB
		private void SaveToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(4U, 0U);
		}

		// Token: 0x060000FC RID: 252 RVA: 0x000029D5 File Offset: 0x00000BD5
		private void LoadToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(8U, 0U);
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000A8CC File Offset: 0x00008ACC
		private void FullscreenToolStripMenuItem_Click(object sender, EventArgs e)
		{
			uint num = ((base.WindowState == FormWindowState.Maximized) ? 0U : 2U);
			base.WindowState = (FormWindowState)num;
		}

		// Token: 0x060000FE RID: 254 RVA: 0x000029DF File Offset: 0x00000BDF
		private void BackToTitleToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(32U, 0U);
		}

		// Token: 0x060000FF RID: 255 RVA: 0x000029EA File Offset: 0x00000BEA
		private void ExitGameToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.SetSystemMenuTrg(64U, 0U);
			this.bFinished = false;
		}

		// Token: 0x06000100 RID: 256 RVA: 0x0000A8F0 File Offset: 0x00008AF0
		internal void LoadKeyMap()
		{
			string text = "config.csv";
			if (this.keyMap.Count != 0)
			{
				this.keyMap.Clear();
			}
			KeyConfig.InitKeyConfig();
			try
			{
				using (StreamReader streamReader = new StreamReader(text, Encoding.UTF8))
				{
					string text2 = string.Empty;
					while ((text2 = streamReader.ReadLine()) != null)
					{
						string[] array = text2.Split(new char[] { ',' });
						int num = int.Parse(array[0]);
						int num2 = int.Parse(array[1]);
						this.keyMap.Add((KeyConfig.keyCode)num2, (Keys)num);
					}
				}
			}
			catch
			{
				File.Delete(text);
				this.LoadKeyMap();
			}
		}

		// Token: 0x06000101 RID: 257 RVA: 0x0000A9B0 File Offset: 0x00008BB0
		protected override void WndProc(ref Message m)
		{
			if (m.Msg == 74)
			{
				if (m.WParam.ToInt32() == 0)
				{
					Form1.COPYDATASTRUCT copydatastruct = (Form1.COPYDATASTRUCT)m.GetLParam(typeof(Form1.COPYDATASTRUCT));
					Encoding unicode = Encoding.Unicode;
					byte[] bytes = unicode.GetBytes(copydatastruct.lpData);
					string @string = unicode.GetString(bytes, 0, int.Parse(copydatastruct.cbData.ToString()));
					int width;
					int height;
					if (((base.WindowState == FormWindowState.Maximized) ? 1 : 0) == 1)
					{
						width = base.Width;
						height = base.Height;
					}
					else
					{
						width = this.client_width;
						height = this.client_height;
					}
					float num = (float)width / 1920f;
					float num2 = (float)height / 1080f;
					if (this.count == 0)
					{
						this.myText = new XGTextBox();
						this.myText.Name = "ime";
						this.myText.TextChanged += this.ime_TextChanged;
						this.myText.Text = @string;
					}
					else if (this.count == 1)
					{
						this.x0 = int.Parse(@string);
					}
					else if (this.count == 2)
					{
						this.x1 = int.Parse(@string);
					}
					else if (this.count == 3)
					{
						this.y0 = int.Parse(@string);
					}
					else if (this.count == 4)
					{
						this.y1 = int.Parse(@string);
					}
					else if (this.count == 5)
					{
						this.textWidth = int.Parse(@string);
						this.myText.Width = (int)((float)this.textWidth * num);
					}
					else if (this.count == 6)
					{
						this.textHeight = int.Parse(@string);
						this.myText.Height = (int)((float)this.textHeight * num);
						this.myText.AutoSize = false;
						if (FormWindowState.Maximized == base.WindowState)
						{
							this.myText.Location = new Point(this.calcSize(this.x0, this.x1, num), this.calcSize(this.y0, this.y1, num));
						}
						else
						{
							this.myText.Location = new Point(this.calcSize(this.x0, this.x1, num), this.calcSize(this.y0, this.y1, num) + 27);
						}
					}
					else if (this.count == 7)
					{
						this.fontSize = int.Parse(@string);
						this.myText.Font = new Font(this.myText.Font.FontFamily.Name, (float)((int)((float)this.fontSize * num)));
						this.myText.BorderStyle = BorderStyle.None;
						base.Controls.Add(this.myText);
						this.myText.BringToFront();
						this.myText.Focus();
						this.myText.SelectAll();
						this.inputFlg = true;
						this.count = -1;
					}
					this.count++;
				}
				else if (1 != m.WParam.ToInt32() && 2 != m.WParam.ToInt32())
				{
					if (3 == m.WParam.ToInt32())
					{
						this.UpdateHashFile(this.GetHashDataFileName(), this.GetSourceDataFileName());
					}
					else
					{
						if (4 == m.WParam.ToInt32())
						{
							Queue<Form1.MessageCommand> queue;
							if (this.IsMatchHashFile(this.GetHashDataFileName(), this.GetSourceDataFileName()))
							{
								queue = this.commandQueue;
								lock (queue)
								{
									Form1.MessageCommand messageCommand = new Form1.MessageCommand(Form1.MessageType.TypeHashCheck);
									messageCommand.lParam = 2U;
									this.commandQueue.Enqueue(messageCommand);
									goto IL_446;
								}
							}
							queue = this.commandQueue;
							lock (queue)
							{
								Form1.MessageCommand messageCommand2 = new Form1.MessageCommand(Form1.MessageType.TypeHashCheck);
								messageCommand2.lParam = 0U;
								this.commandQueue.Enqueue(messageCommand2);
								goto IL_446;
							}
						}
						if (5 == m.WParam.ToInt32())
						{
							this.bFinished = true;
							base.Close();
						}
					}
				}
			}
			else if (m.Msg == 5121)
			{
				Form1.APIPostMessageDLL(18, (uint)m.WParam.ToInt32(), (uint)m.LParam.ToInt32());
			}
			IL_446:
			base.WndProc(ref m);
		}

		// Token: 0x06000102 RID: 258 RVA: 0x000029FC File Offset: 0x00000BFC
		private string GetSourceDataFileName()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Song of Memories\\SOM000.dat";
		}

		// Token: 0x06000103 RID: 259 RVA: 0x00002A0F File Offset: 0x00000C0F
		private string GetHashDataFileName()
		{
			return Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "\\Song of Memories\\SOM001.dat";
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000AE28 File Offset: 0x00009028
		private void UpdateHashFile(string dest_fname, string source_fname)
		{
			byte[] array = crypt.CreateHash(Form1.LoadFileData(source_fname));
			Form1.SaveFileData(dest_fname, array, array.Length);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x00002A22 File Offset: 0x00000C22
		private bool IsMatchHashFile(string hash_fname, string source_fname)
		{
			return crypt.IsMatchHash(Form1.LoadFileData(source_fname), Form1.LoadFileData(hash_fname));
		}

		// Token: 0x06000106 RID: 262 RVA: 0x0000AE4C File Offset: 0x0000904C
		private static byte[] LoadFileData(string fname)
		{
			byte[] array = null;
			if (!File.Exists(fname))
			{
				return null;
			}
			using (FileStream fileStream = new FileStream(fname, FileMode.Open, FileAccess.Read))
			{
				array = new byte[fileStream.Length];
				int i = (int)fileStream.Length;
				int num = 0;
				while (i > 0)
				{
					int num2 = fileStream.Read(array, num, i);
					if (num2 == 0)
					{
						break;
					}
					num += num2;
					i -= num2;
				}
			}
			return array;
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000AEC4 File Offset: 0x000090C4
		private static void SaveFileData(string fname, byte[] bytes, int data_size)
		{
			using (FileStream fileStream = new FileStream(fname, FileMode.Create, FileAccess.Write))
			{
				fileStream.Write(bytes, 0, data_size);
			}
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000AF00 File Offset: 0x00009100
		internal void SaveKeyMap()
		{
			using (StreamWriter streamWriter = new StreamWriter("config.csv", false, Encoding.UTF8))
			{
				foreach (KeyValuePair<KeyConfig.keyCode, Keys> keyValuePair in this.keyMap)
				{
					streamWriter.WriteLine((int)keyValuePair.Key + "," + (int)keyValuePair.Value);
				}
			}
		}

		// Token: 0x06000109 RID: 265
		[DllImport("XGWinDll.dll", CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int SetDisplayFullScreen(string deviceName, int width, int height);

		// Token: 0x0600010A RID: 266 RVA: 0x0000AF9C File Offset: 0x0000919C
		private void Form1_SizeChanged(object sender, EventArgs e)
		{
			Screen screen = Screen.FromControl(this);
			FormWindowState windowState = base.WindowState;
			if (windowState == FormWindowState.Maximized)
			{
				this.disp_width = screen.Bounds.Size.Width;
				this.disp_height = screen.Bounds.Size.Height;
				base.SizeChanged -= this.Form1_SizeChanged;
				base.WindowState = FormWindowState.Normal;
				base.FormBorderStyle = FormBorderStyle.None;
				base.FormBorderStyle = FormBorderStyle.None;
				base.WindowState = FormWindowState.Maximized;
				base.SizeChanged += this.Form1_SizeChanged;
			}
			else if (windowState == FormWindowState.Normal)
			{
				base.SizeChanged -= this.Form1_SizeChanged;
				base.WindowState = FormWindowState.Normal;
				base.FormBorderStyle = FormBorderStyle.FixedSingle;
				base.WindowState = FormWindowState.Normal;
				base.SizeChanged += this.Form1_SizeChanged;
			}
			this.SetSystemMenuTrg(16U, (uint)windowState);
			this.FullscreenToolStripMenuItem.Text = this.ChangeWindowModeText(base.WindowState == FormWindowState.Maximized);
			this.SetClientSize(base.Width, base.Height, (uint)windowState);
			if (this.inputFlg)
			{
				int width;
				int height;
				if (base.WindowState == FormWindowState.Maximized)
				{
					width = base.Width;
					height = base.Height;
				}
				else
				{
					width = this.client_width;
					height = this.client_height;
				}
				float num = (float)width / 1920f;
				float num2 = (float)height / 1080f;
				if (FormWindowState.Maximized == base.WindowState)
				{
					this.myText.Location = new Point(this.calcSize(this.x0, this.x1, num), this.calcSize(this.y0, this.y1, num));
				}
				else
				{
					this.myText.Location = new Point(this.calcSize(this.x0, this.x1, num), this.calcSize(this.y0, this.y1, num) + 17);
				}
				this.myText.Width = (int)((float)this.textWidth * num);
				this.myText.Height = (int)((float)this.textHeight * num);
				this.myText.Font = new Font(this.myText.Font.FontFamily.Name, (float)this.fontSize * num);
			}
		}

		// Token: 0x0600010B RID: 267 RVA: 0x00002A35 File Offset: 0x00000C35
		private void SetUserLanguage(int val)
		{
			if (val > -1 && val < 5)
			{
				this.userLanguage = val;
			}
		}

		// Token: 0x0600010C RID: 268 RVA: 0x0000B1CC File Offset: 0x000093CC
		private void SetClientSize(int w, int h, uint mode)
		{
			if (w == 0 || h == 0)
			{
				throw new Exception();
			}
			if (mode == 2U)
			{
				base.SizeChanged -= this.Form1_SizeChanged;
				this.client_width = (int)((float)(h + 25) * 1.77777779f);
				this.client_height = (int)((float)w / 1.77777779f);
				this.panel1.Location = new Point(0, 0);
				this.panel1.Size = new Size(this.client_width, this.client_height);
				this.panel1.ClientSize = new Size(this.client_width, this.client_height);
				this.menuStrip1.Visible = false;
				base.SizeChanged += this.Form1_SizeChanged;
				return;
			}
			if (mode == 0U)
			{
				base.SizeChanged -= this.Form1_SizeChanged;
				this.client_width = 1280;
				this.client_height = 720;
				this.panel1.Location = new Point(0, 25);
				this.panel1.Size = new Size(this.client_width, this.client_height);
				this.panel1.ClientSize = new Size(this.client_width, this.client_height);
				this.menuStrip1.Visible = true;
				base.SizeChanged += this.Form1_SizeChanged;
			}
		}

		// Token: 0x0600010D RID: 269 RVA: 0x0000B320 File Offset: 0x00009520
		private void ime_TextChanged(object sender, EventArgs e)
		{
			Encoding unicode = Encoding.Unicode;
			int byteCount = unicode.GetByteCount(this.myText.Text);
			int selectionStart = this.myText.SelectionStart;
			int num = 0;
			switch (this.userLanguage)
			{
			case 0:
				num = 6;
				break;
			case 1:
				num = 12;
				break;
			case 2:
				num = 12;
				break;
			case 3:
				num = 6;
				break;
			case 4:
				num = 6;
				break;
			}
			if (byteCount > num)
			{
				byte[] bytes = unicode.GetBytes(this.myText.Text);
				string text = unicode.GetString(bytes, 0, num);
				int length = unicode.GetString(bytes, 0, num + 1).Length;
				if (text.Length == length)
				{
					text = text.Remove(text.Length - 1);
				}
				this.myText.Text = text;
				this.myText.Select(selectionStart, 0);
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x00002A46 File Offset: 0x00000C46
		protected override void Dispose(bool disposing)
		{
			if (disposing && this.components != null)
			{
				this.components.Dispose();
			}
			base.Dispose(disposing);
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000B3FC File Offset: 0x000095FC
		private void InitializeComponent(int client_width, int client_height)
		{
			this.components = new Container();
			this.panel1 = new Panel();
			this.timerFrame = new Timer(this.components);
			this.menuStrip1 = new MenuStrip();
			this.FileToolStripMenuItem = new ToolStripMenuItem();
			this.QuickSaveToolStripMenuItem = new ToolStripMenuItem();
			this.QuickLoadToolStripMenuItem = new ToolStripMenuItem();
			this.SaveToolStripMenuItem = new ToolStripMenuItem();
			this.LoadToolStripMenuItem = new ToolStripMenuItem();
			this.FullscreenToolStripMenuItem = new ToolStripMenuItem();
			this.BackToTitleToolStripMenuItem = new ToolStripMenuItem();
			this.ExitGameToolStripMenuItem = new ToolStripMenuItem();
			this.GameOperationToolStripMenuItem = new ToolStripMenuItem();
			this.AutoToolStripMenuItem = new ToolStripMenuItem();
			this.TextSkipToolStripMenuItem = new ToolStripMenuItem();
			this.HideTextAreaToolStripMenuItem = new ToolStripMenuItem();
			this.MenuToolStripMenuItem = new ToolStripMenuItem();
			this.ChartToolStripMenuItem = new ToolStripMenuItem();
			this.D4UStatusToolStripMenuItem = new ToolStripMenuItem();
			this.BackLogToolStripMenuItem = new ToolStripMenuItem();
			this.DictionaryToolStripMenuItem = new ToolStripMenuItem();
			this.OptionToolStripMenuItem = new ToolStripMenuItem();
			this.HelpToolStripMenuItem = new ToolStripMenuItem();
			this.VersionInfoToolStripMenuItem = new ToolStripMenuItem();
			this.KeyConfigToolStripMenuItem = new ToolStripMenuItem();
			this.HelpToolStripMenuItem1 = new ToolStripMenuItem();
			this.menuStrip1.SuspendLayout();
			base.SuspendLayout();
			this.panel1.Location = new Point(0, 25);
			this.panel1.Name = "panel1";
			this.panel1.Size = new Size(client_width, client_height);
			this.panel1.TabIndex = 0;
			this.panel1.MouseDown += this.panel1_MouseDown;
			this.panel1.MouseUp += this.panel1_MouseUp;
			this.panel1.MouseMove += this.panel1_MouseMove;
			this.panel1.MouseWheel += this.panel1_MouseWheel;
			this.panel1.AutoSizeMode = AutoSizeMode.GrowAndShrink;
			this.timerFrame.Interval = 1;
			this.timerFrame.Tick += this.timerFrame_Tick;
			this.menuStrip1.Items.AddRange(new ToolStripItem[] { this.FileToolStripMenuItem, this.GameOperationToolStripMenuItem, this.MenuToolStripMenuItem, this.HelpToolStripMenuItem });
			this.menuStrip1.Location = new Point(0, 0);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new Size(client_width, 24);
			this.menuStrip1.TabIndex = 53;
			this.menuStrip1.Text = "menuStrip1";
			this.FileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.QuickSaveToolStripMenuItem, this.QuickLoadToolStripMenuItem, this.SaveToolStripMenuItem, this.LoadToolStripMenuItem, this.FullscreenToolStripMenuItem, this.BackToTitleToolStripMenuItem, this.ExitGameToolStripMenuItem });
			this.FileToolStripMenuItem.Name = "FileToolStripMenuItem";
			this.FileToolStripMenuItem.Size = new Size(53, 20);
			this.FileToolStripMenuItem.Text = "ファイル";
			this.QuickSaveToolStripMenuItem.Name = "QuickSaveToolStripMenuItem";
			this.QuickSaveToolStripMenuItem.ShortcutKeys = (Keys)196691;
			this.QuickSaveToolStripMenuItem.Size = new Size(217, 22);
			this.QuickSaveToolStripMenuItem.Text = "クイックセーブ";
			this.QuickSaveToolStripMenuItem.Click += this.QuickSaveToolStripMenuItem_Click;
			this.QuickLoadToolStripMenuItem.Name = "QuickLoadToolStripMenuItem";
			this.QuickLoadToolStripMenuItem.ShortcutKeys = (Keys)196687;
			this.QuickLoadToolStripMenuItem.Size = new Size(217, 22);
			this.QuickLoadToolStripMenuItem.Text = "クイックロード";
			this.QuickLoadToolStripMenuItem.Click += this.QuickLoadToolStripMenuItem_Click;
			this.SaveToolStripMenuItem.Name = "SaveToolStripMenuItem";
			this.SaveToolStripMenuItem.ShortcutKeys = (Keys)131155;
			this.SaveToolStripMenuItem.Size = new Size(217, 22);
			this.SaveToolStripMenuItem.Text = "セーブ";
			this.SaveToolStripMenuItem.Click += this.SaveToolStripMenuItem_Click;
			this.LoadToolStripMenuItem.Name = "LoadToolStripMenuItem";
			this.LoadToolStripMenuItem.ShortcutKeys = (Keys)131151;
			this.LoadToolStripMenuItem.Size = new Size(217, 22);
			this.LoadToolStripMenuItem.Text = "ロード";
			this.LoadToolStripMenuItem.Click += this.LoadToolStripMenuItem_Click;
			this.FullscreenToolStripMenuItem.Name = "FullscreenToolStripMenuItem";
			this.FullscreenToolStripMenuItem.ShortcutKeys = (Keys)262265;
			this.FullscreenToolStripMenuItem.Size = new Size(217, 22);
			this.FullscreenToolStripMenuItem.Text = "フルスクリーン";
			this.FullscreenToolStripMenuItem.Click += this.FullscreenToolStripMenuItem_Click;
			this.BackToTitleToolStripMenuItem.Name = "BackToTitleToolStripMenuItem";
			this.BackToTitleToolStripMenuItem.ShortcutKeys = (Keys)196723;
			this.BackToTitleToolStripMenuItem.Size = new Size(217, 22);
			this.BackToTitleToolStripMenuItem.Text = "タイトルに戻る";
			this.BackToTitleToolStripMenuItem.Click += this.BackToTitleToolStripMenuItem_Click;
			this.ExitGameToolStripMenuItem.Name = "ExitGameToolStripMenuItem";
			this.ExitGameToolStripMenuItem.ShortcutKeys = (Keys)262259;
			this.ExitGameToolStripMenuItem.Size = new Size(217, 22);
			this.ExitGameToolStripMenuItem.Text = "ゲーム終了";
			this.ExitGameToolStripMenuItem.Click += this.ExitGameToolStripMenuItem_Click;
			this.GameOperationToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.AutoToolStripMenuItem, this.TextSkipToolStripMenuItem, this.HideTextAreaToolStripMenuItem });
			this.GameOperationToolStripMenuItem.Name = "GameOperationToolStripMenuItem";
			this.GameOperationToolStripMenuItem.Size = new Size(70, 20);
			this.GameOperationToolStripMenuItem.Text = "ゲーム操作";
			this.AutoToolStripMenuItem.Name = "AutoToolStripMenuItem";
			this.AutoToolStripMenuItem.ShortcutKeys = Keys.F1;
			this.AutoToolStripMenuItem.Size = new Size(190, 22);
			this.AutoToolStripMenuItem.Text = "オート";
			this.AutoToolStripMenuItem.Click += this.AutoToolStripMenuItem_Click;
			this.TextSkipToolStripMenuItem.Name = "TextSkipToolStripMenuItem";
			this.TextSkipToolStripMenuItem.ShortcutKeys = Keys.F2;
			this.TextSkipToolStripMenuItem.Size = new Size(190, 22);
			this.TextSkipToolStripMenuItem.Text = "テキストスキップ";
			this.TextSkipToolStripMenuItem.Click += this.TextSkipToolStripMenuItem_Click;
			this.HideTextAreaToolStripMenuItem.Name = "HideTextAreaToolStripMenuItem";
			this.HideTextAreaToolStripMenuItem.ShortcutKeys = Keys.F3;
			this.HideTextAreaToolStripMenuItem.Size = new Size(190, 22);
			this.HideTextAreaToolStripMenuItem.Text = "テキストエリア非表示";
			this.HideTextAreaToolStripMenuItem.Click += this.HideTextAreaToolStripMenuItem_Click;
			this.MenuToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.ChartToolStripMenuItem, this.D4UStatusToolStripMenuItem, this.BackLogToolStripMenuItem, this.DictionaryToolStripMenuItem, this.OptionToolStripMenuItem });
			this.MenuToolStripMenuItem.Name = "MenuToolStripMenuItem";
			this.MenuToolStripMenuItem.Size = new Size(52, 20);
			this.MenuToolStripMenuItem.Text = "メニュー";
			this.ChartToolStripMenuItem.Name = "ChartToolStripMenuItem";
			this.ChartToolStripMenuItem.ShortcutKeys = Keys.F5;
			this.ChartToolStripMenuItem.Size = new Size(159, 22);
			this.ChartToolStripMenuItem.Text = "チャート";
			this.ChartToolStripMenuItem.Click += this.ChartToolStripMenuItem_Click;
			this.D4UStatusToolStripMenuItem.Name = "D4UStatusToolStripMenuItem";
			this.D4UStatusToolStripMenuItem.ShortcutKeys = Keys.F6;
			this.D4UStatusToolStripMenuItem.Size = new Size(159, 22);
			this.D4UStatusToolStripMenuItem.Text = "D4Uステータス";
			this.D4UStatusToolStripMenuItem.Click += this.D4UStatusToolStripMenuItem_Click;
			this.BackLogToolStripMenuItem.Name = "BackLogToolStripMenuItem";
			this.BackLogToolStripMenuItem.ShortcutKeys = Keys.F7;
			this.BackLogToolStripMenuItem.Size = new Size(159, 22);
			this.BackLogToolStripMenuItem.Text = "バックログ";
			this.BackLogToolStripMenuItem.Click += this.BackLogToolStripMenuItem_Click;
			this.DictionaryToolStripMenuItem.Name = "DictionaryToolStripMenuItem";
			this.DictionaryToolStripMenuItem.ShortcutKeys = Keys.F8;
			this.DictionaryToolStripMenuItem.Size = new Size(159, 22);
			this.DictionaryToolStripMenuItem.Text = "辞書";
			this.DictionaryToolStripMenuItem.Click += this.DictionaryToolStripMenuItem_Click;
			this.OptionToolStripMenuItem.Name = "OptionToolStripMenuItem";
			this.OptionToolStripMenuItem.ShortcutKeys = Keys.F9;
			this.OptionToolStripMenuItem.Size = new Size(159, 22);
			this.OptionToolStripMenuItem.Text = "オプション";
			this.OptionToolStripMenuItem.Click += this.OptionToolStripMenuItem_Click;
			this.HelpToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { this.VersionInfoToolStripMenuItem, this.KeyConfigToolStripMenuItem, this.HelpToolStripMenuItem1 });
			this.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem";
			this.HelpToolStripMenuItem.Size = new Size(48, 20);
			this.HelpToolStripMenuItem.Text = "ヘルプ";
			this.VersionInfoToolStripMenuItem.Name = "VersionInfoToolStripMenuItem";
			this.VersionInfoToolStripMenuItem.Size = new Size(157, 22);
			this.VersionInfoToolStripMenuItem.Text = "バージョン情報";
			this.VersionInfoToolStripMenuItem.Click += this.VersionInfoToolStripMenuItem_Click;
			this.KeyConfigToolStripMenuItem.Name = "KeyConfigToolStripMenuItem";
			this.KeyConfigToolStripMenuItem.ShortcutKeys = Keys.F10;
			this.KeyConfigToolStripMenuItem.Size = new Size(157, 22);
			this.KeyConfigToolStripMenuItem.Text = "キーコンフィグ";
			this.KeyConfigToolStripMenuItem.Click += this.KeyConfigToolStripMenuItem_Click;
			this.HelpToolStripMenuItem1.Name = "HelpToolStripMenuItem1";
			this.HelpToolStripMenuItem1.ShortcutKeys = Keys.F11;
			this.HelpToolStripMenuItem1.Size = new Size(157, 22);
			this.HelpToolStripMenuItem1.Text = "ヘルプ";
			this.HelpToolStripMenuItem1.Click += this.HelpToolStripMenuItem1_Click;
			base.AutoScaleDimensions = new SizeF(6f, 12f);
			base.AutoScaleMode = AutoScaleMode.Font;
			base.ClientSize = new Size(client_width, client_height);
			base.Controls.Add(this.panel1);
			base.Controls.Add(this.menuStrip1);
			base.KeyPreview = true;
			base.MainMenuStrip = this.menuStrip1;
			base.Name = "Song of Memories";
			this.Text = "Song of Memories";
			base.Load += this.Form1_Load;
			base.Shown += this.Form1_Shown;
			base.FormClosing += this.Form1_FormClosing;
			base.KeyDown += this.Form1_KeyDown;
			base.KeyUp += this.Form1_KeyUp;
			base.LostFocus += this.Form1_LostFocus;
			base.SizeChanged += this.Form1_SizeChanged;
			this.menuStrip1.ResumeLayout(false);
			this.menuStrip1.PerformLayout();
			base.ResumeLayout(false);
			base.PerformLayout();
		}

		// Token: 0x040000C9 RID: 201
		private Queue<Form1.MessageCommand> commandQueue = new Queue<Form1.MessageCommand>();

		// Token: 0x040000CA RID: 202
		private const int default_window_width = 1280;

		// Token: 0x040000CB RID: 203
		private const int default_window_height = 720;

		// Token: 0x040000CC RID: 204
		private const float aspect_rate = 1.77777779f;

		// Token: 0x040000CD RID: 205
		private int client_width = 1280;

		// Token: 0x040000CE RID: 206
		private int client_height = 720;

		// Token: 0x040000CF RID: 207
		private bool inputFlg;

		// Token: 0x040000D0 RID: 208
		private bool bFinished;

		// Token: 0x040000D1 RID: 209
		private const int DEFAULT_LANGUAGE = 0;

		// Token: 0x040000D2 RID: 210
		private int userLanguage;

		// Token: 0x040000D3 RID: 211
		private int mouse_y;

		// Token: 0x040000D4 RID: 212
		private VersionDialog _version_dialog = new VersionDialog();

		// Token: 0x040000D5 RID: 213
		private static KeyConfigDialog _keyconfig_dialog = new KeyConfigDialog();

		// Token: 0x040000D6 RID: 214
		private Dictionary<KeyConfig.keyCode, Keys> keyMap = new Dictionary<KeyConfig.keyCode, Keys>();

		// Token: 0x040000D7 RID: 215
		private bool GLError;

		// Token: 0x040000D8 RID: 216
		private Graphics gs;

		// Token: 0x040000D9 RID: 217
		private IntPtr hdc;

		// Token: 0x040000DA RID: 218
		private DateTime befTime;

		// Token: 0x040000DB RID: 219
		private int FPSCount;

		// Token: 0x040000DC RID: 220
		private bool isShiftDown;

		// Token: 0x040000DD RID: 221
		private bool isCtrlDown;

		// Token: 0x040000DE RID: 222
		private bool keyPressed;

		// Token: 0x040000DF RID: 223
		private Dictionary<Keys, bool> keyPair = new Dictionary<Keys, bool>();

		// Token: 0x040000E0 RID: 224
		private XGTextBox myText;

		// Token: 0x040000E1 RID: 225
		private int count;

		// Token: 0x040000E2 RID: 226
		private int x0;

		// Token: 0x040000E3 RID: 227
		private int x1;

		// Token: 0x040000E4 RID: 228
		private int y0;

		// Token: 0x040000E5 RID: 229
		private int y1;

		// Token: 0x040000E6 RID: 230
		private int textWidth;

		// Token: 0x040000E7 RID: 231
		private int textHeight;

		// Token: 0x040000E8 RID: 232
		private int fontSize;

		// Token: 0x040000E9 RID: 233
		private int disp_width = 1920;

		// Token: 0x040000EA RID: 234
		private int disp_height = 1080;

		// Token: 0x040000EB RID: 235
		private IContainer components;

		// Token: 0x040000EC RID: 236
		private Panel panel1;

		// Token: 0x040000ED RID: 237
		private Timer timerFrame;

		// Token: 0x040000EE RID: 238
		private MenuStrip menuStrip1;

		// Token: 0x040000EF RID: 239
		private ToolStripMenuItem FileToolStripMenuItem;

		// Token: 0x040000F0 RID: 240
		private ToolStripMenuItem QuickSaveToolStripMenuItem;

		// Token: 0x040000F1 RID: 241
		private ToolStripMenuItem QuickLoadToolStripMenuItem;

		// Token: 0x040000F2 RID: 242
		private ToolStripMenuItem SaveToolStripMenuItem;

		// Token: 0x040000F3 RID: 243
		private ToolStripMenuItem LoadToolStripMenuItem;

		// Token: 0x040000F4 RID: 244
		private ToolStripMenuItem FullscreenToolStripMenuItem;

		// Token: 0x040000F5 RID: 245
		private ToolStripMenuItem BackToTitleToolStripMenuItem;

		// Token: 0x040000F6 RID: 246
		private ToolStripMenuItem ExitGameToolStripMenuItem;

		// Token: 0x040000F7 RID: 247
		private ToolStripMenuItem GameOperationToolStripMenuItem;

		// Token: 0x040000F8 RID: 248
		private ToolStripMenuItem AutoToolStripMenuItem;

		// Token: 0x040000F9 RID: 249
		private ToolStripMenuItem TextSkipToolStripMenuItem;

		// Token: 0x040000FA RID: 250
		private ToolStripMenuItem HideTextAreaToolStripMenuItem;

		// Token: 0x040000FB RID: 251
		private ToolStripMenuItem MenuToolStripMenuItem;

		// Token: 0x040000FC RID: 252
		private ToolStripMenuItem ChartToolStripMenuItem;

		// Token: 0x040000FD RID: 253
		private ToolStripMenuItem D4UStatusToolStripMenuItem;

		// Token: 0x040000FE RID: 254
		private ToolStripMenuItem BackLogToolStripMenuItem;

		// Token: 0x040000FF RID: 255
		private ToolStripMenuItem DictionaryToolStripMenuItem;

		// Token: 0x04000100 RID: 256
		private ToolStripMenuItem OptionToolStripMenuItem;

		// Token: 0x04000101 RID: 257
		private ToolStripMenuItem HelpToolStripMenuItem;

		// Token: 0x04000102 RID: 258
		private ToolStripMenuItem VersionInfoToolStripMenuItem;

		// Token: 0x04000103 RID: 259
		private ToolStripMenuItem KeyConfigToolStripMenuItem;

		// Token: 0x04000104 RID: 260
		private ToolStripMenuItem HelpToolStripMenuItem1;

		// Token: 0x0200003A RID: 58
		private enum MessageType
		{
			// Token: 0x04000106 RID: 262
			TypeCommandEnd,
			// Token: 0x04000107 RID: 263
			TypeSetLangauge,
			// Token: 0x04000108 RID: 264
			TypeMenuBarEvent,
			// Token: 0x04000109 RID: 265
			TypeKeyDown,
			// Token: 0x0400010A RID: 266
			TypeMouseDown,
			// Token: 0x0400010B RID: 267
			TypeMouseUp,
			// Token: 0x0400010C RID: 268
			TypeMouseMove,
			// Token: 0x0400010D RID: 269
			TypeMouseWheel,
			// Token: 0x0400010E RID: 270
			TypeMouseReset,
			// Token: 0x0400010F RID: 271
			TypeKeyUp,
			// Token: 0x04000110 RID: 272
			TypeHashCheck,
			// Token: 0x04000111 RID: 273
			TypeButtonReset,
			// Token: 0x04000112 RID: 274
			TypeRStickMove,
			// Token: 0x04000113 RID: 275
			TypeRStickReset,
			// Token: 0x04000114 RID: 276
			TypeLStickMove,
			// Token: 0x04000115 RID: 277
			TypeLStickReset,
			// Token: 0x04000116 RID: 278
			TypeSpaceKeyDown,
			// Token: 0x04000117 RID: 279
			TypeSpaceKeyUp,
			// Token: 0x04000118 RID: 280
			TypeMediaFoundation
		}

		// Token: 0x0200003B RID: 59
		private class MessageCommand
		{
			// Token: 0x06000111 RID: 273 RVA: 0x00002098 File Offset: 0x00000298
			public MessageCommand()
			{
			}

			// Token: 0x06000112 RID: 274 RVA: 0x00002A71 File Offset: 0x00000C71
			public MessageCommand(Form1.MessageType type)
			{
				this.type = type;
			}

			// Token: 0x04000119 RID: 281
			public Form1.MessageType type;

			// Token: 0x0400011A RID: 282
			public uint wParam;

			// Token: 0x0400011B RID: 283
			public uint lParam;
		}

		// Token: 0x0200003C RID: 60
		private enum Language
		{
			// Token: 0x0400011D RID: 285
			Min = -1,
			// Token: 0x0400011E RID: 286
			Japanese,
			// Token: 0x0400011F RID: 287
			English,
			// Token: 0x04000120 RID: 288
			French,
			// Token: 0x04000121 RID: 289
			TraditionalChinese,
			// Token: 0x04000122 RID: 290
			SimplifiedChinese,
			// Token: 0x04000123 RID: 291
			Max
		}

		// Token: 0x0200003D RID: 61
		[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Unicode)]
		private struct COPYDATASTRUCT
		{
			// Token: 0x04000124 RID: 292
			public IntPtr dwData;

			// Token: 0x04000125 RID: 293
			public uint cbData;

			// Token: 0x04000126 RID: 294
			public string lpData;
		}
	}
}
