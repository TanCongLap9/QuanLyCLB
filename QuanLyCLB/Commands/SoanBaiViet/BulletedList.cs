using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace QuanLyCLB.Commands.SoanBaiViet
{
    public class BulletedList : Command
    {
        public const string Bullet1 = "- ";
        public const string Bullet2 = "* ";
        public const string Bullet3 = "+ ";
        public static readonly Regex BulletRegex = new Regex($@"^\s*({Regex.Escape(Bullet1)}|{Regex.Escape(Bullet2)}|{Regex.Escape(Bullet3)})");

        public BulletedList(TextBox textBox) : base(textBox) { }

        public override void Execute()
        {
            int selStart = TextBox.SelectionStart;
            int selLen = TextBox.SelectionLength;
            int firstIndex = GetFirstCharIndexOfCurrentLine();
            string startLine = GetStartLine();

            Match match;
            if ((match = BulletRegex.Match(startLine)).Success)
            {
                Group gBullet = match.Groups[1];
                TextBox.Select(firstIndex + gBullet.Index, gBullet.Length);
                TextBox.SelectedText = string.Empty;
                selStart -= gBullet.Length;
            }
            else if ((match = NumberedList.NumberRegex.Match(startLine)).Success)
            {
                Group gNumber = match.Groups[1];
                TextBox.Select(firstIndex + gNumber.Index, gNumber.Length);
                TextBox.SelectedText = Bullet1;
                selStart += Bullet1.Length - gNumber.Length;
            }
            else if ((match = LineIndentRegex.Match(startLine)).Success)
            {
                Group gIndent = match.Groups[1];
                TextBox.Select(firstIndex + gIndent.Index, 0);
                TextBox.SelectedText = Bullet1;
                selStart += Bullet1.Length;
            }
            TextBox.Select(Math.Max(firstIndex, selStart), selLen);
            TextBox.Focus();
        }
    }
}
